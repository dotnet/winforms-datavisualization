//-------------------------------------------------------------
// <copyright company=’Microsoft Corporation’>
//   Copyright © Microsoft Corporation. All Rights Reserved.
// </copyright>
//-------------------------------------------------------------
// @owner=alexgor, deliant
//=================================================================
//  File:		AnnotationCollectionEditor.cs
//
//  Namespace:	Microsoft.VisualStudio.Data.Visualization.Win[Web]Controls
//
//	Classes:	ColorPaletteEditor
//
//  Purpose:	Design-time UI editor for Annotations.
//
//	Reviewed:	AG - August 7, 2002
//
//===================================================================

using System.ComponentModel;
using System.Drawing.Design;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace System.Windows.Forms.Design.DataVisualization.Charting
{
    /// <summary>
    /// Designer editor for the Annotation Collection.
    /// </summary>
    internal class AnnotationCollectionEditor : ChartCollectionEditor
    {
        #region Methods

        /// <summary>
        /// Object constructor.
        /// </summary>
        public AnnotationCollectionEditor()
            : base(typeof(AnnotationCollection))
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
            Chart control = (Chart)GetChartReference(Context.Instance);

            // Call base class
            Annotation annotation = base.CreateInstance(itemType) as Annotation;

            // Generate unique name 
            if (control != null)
            {
                annotation.Name = NextUniqueName(control, itemType);
            }

            return annotation;
        }



        /// <summary>
        /// Finds the unique name for a new annotation being added to the collection
        /// </summary>
        /// <param name="control">Chart control reference.</param>
        /// <param name="type">Type of the annotation added.</param>
        /// <returns>Next unique chart annotation name</returns>
        private static string NextUniqueName(Chart control, Type type)
        {
            // Find unique name
            string result = string.Empty;
            string prefix = type.Name;
            for (int i = 1; i < System.Int32.MaxValue; i++)
            {
                result = prefix + i.ToString(CultureInfo.InvariantCulture);

                // Check whether the name is unique
                if (control.Annotations.IsUniqueName(result))
                {
                    break;
                }
            }
            return result;
        }


        #endregion // Methods
    }

    /// <summary>
    /// UI type editor for the annotation anchor point
    /// </summary>
    internal class AnchorPointUITypeEditor : System.Drawing.Design.UITypeEditor
    {
        #region Editor methods and properties

        /// <summary>
        /// Display a drop down list with check boxes.
        /// </summary>
        /// <param name="context">Editing context.</param>
        /// <param name="provider">Provider.</param>
        /// <param name="value">Value to edit.</param>
        /// <returns>Result</returns>
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if (context != null && context.Instance != null && provider != null)
            {
                IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
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
    internal class AnchorPointNameTreeView : TreeView
    {
        #region Control fields

        // Annotation object to edit
        private Annotation _annotation = null;
        private DataPoint _dataPoint = null;
        IWindowsFormsEditorService _edSvc = null;

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
            this._annotation = annotation;
            this._dataPoint = dataPoint;
            this._edSvc = edSvc;

            // Set control border style
            this.BorderStyle = BorderStyle.None;

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
            bool nodeSelected = false;
            this.BeginUpdate();

            // Add "None" option
            TreeNode noPoint = this.Nodes.Add("NotSet");

            // Get chart object
            if (this._annotation != null &&
                _annotation.AnnotationGroup == null &&
                this._annotation.Chart != null)
            {
                Chart chart = this._annotation.Chart;

                // Loop through all series
                foreach (Series series in chart.Series)
                {
                    TreeNode seriesNode = this.Nodes.Add(series.Name);
                    seriesNode.Tag = series;

                    // Indicate that there are no points in series
                    if (series.Points.Count == 0)
                    {
                        seriesNode.Nodes.Add("(empty)");
                    }

                    // Loop through all points
                    int index = 1;
                    foreach (DataPoint point in series.Points)
                    {
                        TreeNode dataPointNode = seriesNode.Nodes.Add("DataPoint" + index.ToString(System.Globalization.CultureInfo.InvariantCulture));
                        dataPointNode.Tag = point;
                        ++index;

                        // Check if this node should be selected
                        if (point == _dataPoint)
                        {
                            seriesNode.Expand();
                            this.SelectedNode = dataPointNode;
                            nodeSelected = true;
                        }
                    }
                }
            }

            // Select default node
            if (!nodeSelected)
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
            if (this.SelectedNode != null &&
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
            if (this._edSvc != null)
            {
                if (GetNewValue() != null)
                {
                    this._edSvc.CloseDropDown();
                }
                else if (this.SelectedNode != null &&
                    this.SelectedNode.Text == "NotSet")
                {
                    this._edSvc.CloseDropDown();
                }
            }
        }
        #endregion
    }

    /// <summary>
    /// UI type editor for the annotation axes.
    /// </summary>
    internal class AnnotationAxisUITypeEditor : System.Drawing.Design.UITypeEditor
    {
        #region Editor methods and properties

        /// <summary>
        /// Display a drop down list with check boxes.
        /// </summary>
        /// <param name="context">Editing context.</param>
        /// <param name="provider">Provider.</param>
        /// <param name="value">Value to edit.</param>
        /// <returns>Result</returns>
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if (context != null && context.Instance != null && provider != null)
            {
                IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
                if (edSvc != null &&
                    context.Instance is Annotation)
                {
                    // Check if we dealing with X or Y axis
                    bool showXAxes = true;
                    if (context.PropertyDescriptor != null &&
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
    internal class AnnotationAxisNameTreeView : TreeView
    {
        #region Control fields

        // Annotation object to edit
        private Annotation _annotation = null;
        private Axis _axis = null;
        IWindowsFormsEditorService _edSvc = null;
        private bool _showXAxes = true;

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
            this._annotation = annotation;
            this._axis = axis;
            this._edSvc = edSvc;
            this._showXAxes = showXAxes;

            // Set control border style
            this.BorderStyle = BorderStyle.None;

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
            bool nodeSelected = false;
            this.BeginUpdate();

            // Add "None" option
            TreeNode noPoint = this.Nodes.Add("NotSet");

            // Get chart object
            if (this._annotation != null &&
                _annotation.AnnotationGroup == null &&
                this._annotation.Chart != null)
            {
                Chart chart = this._annotation.Chart;

                // Loop through all chart areas
                foreach (ChartArea chartArea in chart.ChartAreas)
                {
                    TreeNode areaNode = this.Nodes.Add(chartArea.Name);
                    areaNode.Tag = chartArea;

                    // Loop through all axes
                    foreach (Axis curAxis in chartArea.Axes)
                    {
                        // Hide X or Y axes
                        if (curAxis.AxisName == AxisName.Y || curAxis.AxisName == AxisName.Y2)
                        {
                            if (_showXAxes)
                            {
                                continue;
                            }
                        }
                        if (curAxis.AxisName == AxisName.X || curAxis.AxisName == AxisName.X2)
                        {
                            if (!_showXAxes)
                            {
                                continue;
                            }
                        }

                        // Create child node
                        TreeNode axisNode = areaNode.Nodes.Add(curAxis.Name);
                        axisNode.Tag = curAxis;

                        // Check if this node should be selected
                        if (_axis == curAxis)
                        {
                            areaNode.Expand();
                            this.SelectedNode = axisNode;
                            nodeSelected = true;
                        }
                    }
                }
            }

            // Select default node
            if (!nodeSelected)
            {
                this.SelectedNode = noPoint;
            }

            this.EndUpdate();
        }

        /// <summary>
        /// Gets new data point.
        /// </summary>
        /// <returns>New enum value.</returns>
        public Axis GetNewValue()
        {
            if (this.SelectedNode != null &&
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
            if (this._edSvc != null)
            {
                if (GetNewValue() != null)
                {
                    this._edSvc.CloseDropDown();
                }
                else if (this.SelectedNode != null &&
                    this.SelectedNode.Text == "NotSet")
                {
                    this._edSvc.CloseDropDown();
                }
            }
        }
        #endregion
    }

}