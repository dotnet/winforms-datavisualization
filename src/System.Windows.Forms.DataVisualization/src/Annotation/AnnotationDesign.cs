//-------------------------------------------------------------
// <copyright company=’Microsoft Corporation’>
//   Copyright © Microsoft Corporation. All Rights Reserved.
// </copyright>
//-------------------------------------------------------------
// @owner=alexgor, deliant
//=================================================================
//  File:		AnnotationDesign.cs
//
//  Namespace:	System.Web.UI.WebControls[Windows.Forms].Charting
//
//	Classes:	AnnotationCollectionEditor, AnchorPointUITypeEditor,
//				AnchorPointNameTreeView, AnchorPointValueConverter, 
//				AnnotationAxisUITypeEditor, AnnotationAxisNameTreeView, 
//				AnnotationAxisValueConverter
//
//  Purpose:	Annotation design-time support classes.
//
//	Reviewed:	
//
//===================================================================


#region Used namespace
using System;
using System.Globalization;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;
#if WINFORMS_CONTROL
	using System.Windows.Forms.Charting;
	using System.Windows.Forms.Charting.Data;
	using System.Windows.Forms.Charting.ChartTypes;
	using System.Windows.Forms.Charting.Utilities;
	using System.Windows.Forms.Charting.Borders3D;
	using System.Windows.Forms.Charting.Design;
#else
using System.Web;
using System.Web.UI;
#if VS_DESIGN_TIME
using System.Web.UI.Design;
#endif //VS_DESIGN_TIME
using System.Web.UI.WebControls.Charting.Design;
using System.Web.UI.WebControls.Charting.Data;
using System.Web.UI.WebControls.Charting.Utilities;
#endif

#endregion

#if WINFORMS_CONTROL
	namespace System.Windows.Forms.Charting.Design
#else
    namespace System.Web.UI.WebControls.Charting.Design
#endif
{
#if !SMART_CLIENT
#if VS_DESIGN_TIME
		/// <summary>
		/// Designer editor for the Animation Collection collection.
		/// </summary>
		[
		SRDescription("DescriptionAttributeAnnotationCollectionEditor_AnnotationCollectionEditor")
		]
		public class AnnotationCollectionEditor : ChartCollectionEditor
		{
			#region Methods

			/// <summary>
			/// Object constructor.
			/// </summary>
			public AnnotationCollectionEditor() : base(typeof(AnnotationCollection))
			{
			}

			/// <summary>
			/// Gets the data types that this collection editor can contain.
			/// </summary>
			/// <returns>An array of data types that this collection can contain.</returns>
			protected override Type[] CreateNewItemTypes()
			{
				return new Type[] { 
										typeof(LineAnnotation), 
										typeof(VerticalLineAnnotation),
										typeof(HorizontalLineAnnotation),
										typeof(TextAnnotation), 
										typeof(RectangleAnnotation), 
									    typeof(EllipseAnnotation), 
									    typeof(ArrowAnnotation),
										typeof(Border3DAnnotation),
									    typeof(CalloutAnnotation),
									    typeof(PolylineAnnotation), 
									    typeof(PolygonAnnotation), 
									    typeof(ImageAnnotation), 
										typeof(AnnotationGroup) 
									};
			}

			/// <summary>
			/// Create annotation instance in the editor 
			/// </summary>
			/// <param name="itemType">Item type.</param>
			/// <returns>Newly created item.</returns>
			protected override object CreateInstance(Type itemType)
			{
				Chart	control = (Chart)GetChartReference(Context.Instance);
				// Call base class
				Annotation annotation = base.CreateInstance(itemType) as Annotation;

				// Generate unique name 
				if(control != null)
				{
					control.Annotations.AssignUniqueName(annotation);
				}

				return annotation;
			}

			#endregion // Methods
		}

		/// <summary>
		/// UI type editor for the annotation anchor point
		/// </summary>
		public class AnchorPointUITypeEditor : System.Drawing.Design.UITypeEditor 
		{
			#region Editor methods and properties

			/// <summary>
			/// Display a dropdown list with check boxes.
			/// </summary>
			/// <param name="context">Editing context.</param>
			/// <param name="provider">Provider.</param>
			/// <param name="value">Value to edit.</param>
			/// <returns>Result</returns>
			public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) 
			{
				if (context != null && context.Instance != null && provider != null) 
				{
					IWindowsFormsEditorService	edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
					if (edSvc != null && 
						context.Instance is Annotation) 
					{
						// Create control for editing
						AnchorPointNameTreeView control = new AnchorPointNameTreeView(
							edSvc,
							(Annotation)context.Instance, 
							value as DataPoint);

						// Show drop down control
						edSvc.DropDownControl(control);

						// Get new enumeration value
						value = control.GetNewValue();

						// Dispose control
						control.Dispose();
					}
				}

				return value;
			}


			/// <summary>
			/// Gets editing style.
			/// </summary>
			/// <param name="context">Editing context.</param>
			/// <returns>Editor style.</returns>
			public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context) 
			{
				if (context != null && context.Instance != null) 
				{
					return UITypeEditorEditStyle.DropDown;
				}
				return base.GetEditStyle(context);
			}
	
			#endregion
		}

		/// <summary>
		/// Anchor data points name tree view, which is used for the UI type editing.
		/// </summary>
        internal class AnchorPointNameTreeView : System.Windows.Forms.TreeView
		{
			#region Control fields

			// Annotation object to edit
			private	Annotation			annotation = null;
			private	DataPoint			dataPoint = null;
			IWindowsFormsEditorService	edSvc = null;

			#endregion

			#region Control constructor

			/// <summary>
			/// Public constructor.
			/// </summary>
			/// <param name="edSvc">Editor service.</param>
			/// <param name="annotation">Annotation to edit.</param>
			/// <param name="dataPoint">Annotation anchor data point to edit.</param>
			public AnchorPointNameTreeView(
				IWindowsFormsEditorService edSvc, 
				Annotation annotation, 
				DataPoint dataPoint)
			{
				// Set editable value
				this.annotation = annotation;
				this.dataPoint = dataPoint;
				this.edSvc = edSvc;

				// Set control border style
                this.BorderStyle = System.Windows.Forms.BorderStyle.None;

				// Fill tree with data point names
				this.FillTree();
			}

			#endregion

			#region Control methods

			/// <summary>
			/// Fills data points name tree.
			/// </summary>
			private void FillTree()
			{
				bool	nodeSelected = false;
				this.BeginUpdate();

				// Add "None" option
				System.Windows.Forms.TreeNode noPoint = this.Nodes.Add(Constants.NotSetValue);

				// Get chart object
				if(this.annotation != null &&
					annotation.GetAnnotationGroup() == null &&
					this.annotation.Chart != null)
				{
					Chart chart = this.annotation.Chart;

					// Loop through all series
					foreach(Series series in chart.Series)
					{
                        System.Windows.Forms.TreeNode seriesNode = this.Nodes.Add(series.Name);
						seriesNode.Tag = series;

						// Indicate that there are no points in series
						if(series.Points.Count == 0)
						{
                            System.Windows.Forms.TreeNode noPointNode = seriesNode.Nodes.Add("(empty)");
						}

						// Loop through all points
						int index = 1;
						foreach(DataPoint point in series.Points)
						{
                            System.Windows.Forms.TreeNode dataPointNode = seriesNode.Nodes.Add("DataPoint" + index.ToString(CultureInfo.InvariantCulture));
							dataPointNode.Tag = point;
							++index;

							// Check if this node should be selected
							if(point == dataPoint)
							{
								seriesNode.Expand();
								this.SelectedNode = dataPointNode;
								nodeSelected = true;
							}
						}
					}
				}

				// Select default node
				if(!nodeSelected)
				{
					this.SelectedNode = noPoint;
				}

				this.EndUpdate();
			}

			/// <summary>
			/// Gets new data point.
			/// </summary>
			/// <returns>New enum value.</returns>
			public DataPoint GetNewValue()
			{
				if(this.SelectedNode != null &&
					this.SelectedNode.Tag != null &&
					this.SelectedNode.Tag is DataPoint)
				{
					return (DataPoint)this.SelectedNode.Tag;
				}
				return null;
			}

			/// <summary>
			/// Mouse double clicked.
			/// </summary>
			protected override void OnDoubleClick(EventArgs e) 
			{
				base.OnDoubleClick(e);
				if(this.edSvc != null)
				{
					if(GetNewValue() != null)
					{
						this.edSvc.CloseDropDown();
					}
					else if(this.SelectedNode != null &&
						this.SelectedNode.Text == Constants.NotSetValue)
					{
						this.edSvc.CloseDropDown();
					}
				}
			}
            #endregion
		}

		/// <summary>
		/// UI type editor for the annotation axes.
		/// </summary>
		public class AnnotationAxisUITypeEditor : System.Drawing.Design.UITypeEditor 
		{
    #region Editor methods and properties

			/// <summary>
			/// Display a dropdown list with check boxes.
			/// </summary>
			/// <param name="context">Editing context.</param>
			/// <param name="provider">Provider.</param>
			/// <param name="value">Value to edit.</param>
			/// <returns>Result</returns>
			public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) 
			{
				if (context != null && context.Instance != null && provider != null) 
				{
					IWindowsFormsEditorService	edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
					if (edSvc != null && 
						context.Instance is Annotation) 
					{
						// Check if we dealing with X or Y axis
						bool showXAxes = true;
						if(context.PropertyDescriptor != null &&
							context.PropertyDescriptor.Name == "AxisY")
						{
							showXAxes = false;
						}

						// Create control for editing
						AnnotationAxisNameTreeView control = new AnnotationAxisNameTreeView(
							edSvc,
							(Annotation)context.Instance, 
							value as Axis,
							showXAxes);

						// Show drop down control
						edSvc.DropDownControl(control);

						// Get new enumeration value
						value = control.GetNewValue();

						// Dispose control
						control.Dispose();
					}
				}

				return value;
			}


			/// <summary>
			/// Gets editing style.
			/// </summary>
			/// <param name="context">Editing context.</param>
			/// <returns>Editor style.</returns>
			public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context) 
			{
				if (context != null && context.Instance != null) 
				{
					return UITypeEditorEditStyle.DropDown;
				}
				return base.GetEditStyle(context);
			}
	
    #endregion
		}

		/// <summary>
		/// Annotation axes names tree view, which is used for the UI type editing.
		/// </summary>
        internal class AnnotationAxisNameTreeView : System.Windows.Forms.TreeView
		{
    #region Control fields

			// Annotation object to edit
			private	Annotation			annotation = null;
			private	Axis				axis = null;
			IWindowsFormsEditorService	edSvc = null;
			private	bool				showXAxes = true;

    #endregion

    #region Control constructor

			/// <summary>
			/// Public constructor.
			/// </summary>
			/// <param name="edSvc">Editor service.</param>
			/// <param name="annotation">Annotation to edit.</param>
			/// <param name="axis">Axis object.</param>
			/// <param name="showXAxes">Indicates if X or Y axis should be shown.</param>
			public AnnotationAxisNameTreeView(
				IWindowsFormsEditorService edSvc, 
				Annotation annotation, 
				Axis axis,
				bool showXAxes)
			{
				// Set editable value
				this.annotation = annotation;
				this.axis = axis;
				this.edSvc = edSvc;
				this.showXAxes = showXAxes;

				// Set control border style
                this.BorderStyle = System.Windows.Forms.BorderStyle.None;

				// Fill tree with data point names
				this.FillTree();
			}

    #endregion

    #region Control methods

			/// <summary>
			/// Fills data points name tree.
			/// </summary>
			private void FillTree()
			{
				bool	nodeSelected = false;
				this.BeginUpdate();

				// Add "None" option
                System.Windows.Forms.TreeNode noPoint = this.Nodes.Add(Constants.NotSetValue);

				// Get chart object
				if(this.annotation != null &&
					annotation.GetAnnotationGroup() == null &&
					this.annotation.Chart != null)
				{
					Chart chart = this.annotation.Chart;

					// Loop through all chart areas
					foreach(ChartArea chartArea in chart.ChartAreas)
					{
                        System.Windows.Forms.TreeNode areaNode = this.Nodes.Add(chartArea.Name);
						areaNode.Tag = chartArea;

						// Loop through all axes
						foreach(Axis curAxis in chartArea.Axes)
						{
							// Hide X or Y axes
							if(curAxis.Type == AxisName.Y || curAxis.Type == AxisName.Y2)
							{
								if(showXAxes)
								{
									continue;
								}
							}
							if(curAxis.Type == AxisName.X || curAxis.Type == AxisName.X2)
							{
								if(!showXAxes)
								{
									continue;
								}
							}

							// Create child node
                            System.Windows.Forms.TreeNode axisNode = areaNode.Nodes.Add(curAxis.Name);
							axisNode.Tag = curAxis;

							// Check if this node should be selected
							if(axis == curAxis)
							{
								areaNode.Expand();
								this.SelectedNode = axisNode;
								nodeSelected = true;
							}
						}
					}
				}

				// Select default node
				if(!nodeSelected)
				{
					this.SelectedNode = noPoint;
				}

				this.EndUpdate();
			}

			/// <summary>
			/// Gets a new data point.
			/// </summary>
			/// <returns>New enum value.</returns>
			public Axis GetNewValue()
			{
				if(this.SelectedNode != null &&
					this.SelectedNode.Tag != null &&
					this.SelectedNode.Tag is Axis)
				{
					return (Axis)this.SelectedNode.Tag;
				}
				return null;
			}

			/// <summary>
			/// Mouse double clicked.
			/// </summary>
			protected override void OnDoubleClick(EventArgs e) 
			{
				base.OnDoubleClick(e);
				if(this.edSvc != null)
				{
					if(GetNewValue() != null)
					{
						this.edSvc.CloseDropDown();
					}
					else if(this.SelectedNode != null &&
						this.SelectedNode.Text == Constants.NotSetValue)
					{
						this.edSvc.CloseDropDown();
					}
				}
			}
    #endregion
		}
#endif // VS_DESIGN_TIME
#endif // !SMART_CLIENT

    /// <summary>
		/// Converts anchor data point to string name.
		/// </summary>
		public class AnchorPointValueConverter : TypeConverter
		{
			#region Converter methods

            /// <summary>
            /// Converts anchor data point to string name.
            /// </summary>
            /// <param name="context">Descriptor context.</param>
            /// <param name="culture">Culture information.</param>
            /// <param name="value">Value to convert.</param>
            /// <param name="destinationType">Conversion destination type.</param>
            /// <returns>Converted object.</returns>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) 
		{  
			if (destinationType == typeof(string))
			{
				if(value == null)
				{
                    return Constants.NotSetValue;
				}
				else if(value is DataPoint)
				{
					DataPoint dataPoint = (DataPoint)value;
					if(dataPoint.series != null)
					{
						int pointIndex = dataPoint.series.Points.IndexOf(dataPoint) + 1;
                        return dataPoint.series.Name + " - " + SR.DescriptionTypePoint + pointIndex.ToString(CultureInfo.InvariantCulture);
					}
				}
			}

			// Call base class
			return base.ConvertTo(context, culture, value, destinationType);
		}
			#endregion
		}

		/// <summary>
		/// Converts anchor data point to string name.
		/// </summary>
		public class AnnotationAxisValueConverter : TypeConverter
		{
			#region Converter methods

            /// <summary>
            /// Converts anchor data point to string name.
            /// </summary>
            /// <param name="context">Descriptor context.</param>
            /// <param name="culture">Culture information.</param>
            /// <param name="value">Value to convert.</param>
            /// <param name="destinationType">Conversion destination type.</param>
            /// <returns>Converted object.</returns>
			public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) 
			{  
				if (destinationType == typeof(string))
				{
					if(value == null)
					{
                        return Constants.NotSetValue;
					}
					else if(value is Axis)
					{
						Axis axis = (Axis)value;
						if(axis.chartArea != null)
						{
							return axis.chartArea.Name + " - " + axis.Name;
						}
					}
				}

				// Call base class
				return base.ConvertTo(context, culture, value, destinationType);
			}
			#endregion
		}


}

