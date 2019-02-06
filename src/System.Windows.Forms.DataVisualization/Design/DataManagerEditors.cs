// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	Design-time editors and converter classes for the 
//				Series and DataPoint properties.
//


using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Design;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.ChartTypes;

namespace System.Windows.Forms.Design.DataVisualization.Charting
{

    /// <summary>
    /// UI type editor for the Y data source members of the series.
    /// </summary>
    internal class SeriesDataSourceMemberValueAxisUITypeEditor : System.Drawing.Design.UITypeEditor 
	{
		#region Editor methods and properties

        internal virtual SeriesDataSourceMemberYCheckedListBox GetDropDownControl(Chart chart, ITypeDescriptorContext context, object value, bool flag)
        {
            return new SeriesDataSourceMemberYCheckedListBox(chart, value, flag);
        }


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
				if(edSvc != null) 
				{
                    Chart chart = ConverterHelper.GetChartFromContext(context);

					if(chart != null)
					{

						// Create control for editing
						SeriesDataSourceMemberYCheckedListBox control = this.GetDropDownControl(chart, context, value, true);

						// Show drop down control
						edSvc.DropDownControl(control);

						// Get new enumeration value
						value = control.GetNewValue();
					}
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
				// Check how many Y values in the series.
				int	yValuesNumber = 1;
				if(context.Instance is Series)
				{
					yValuesNumber = ((Series)context.Instance).YValuesPerPoint;
				}
				else if(context.Instance is Array)
				{
					Array	array = (Array)context.Instance;
					if(array.Length > 0 && array.GetValue(0) is Series)
					{
						yValuesNumber = Math.Max(yValuesNumber, ((Series)array.GetValue(0)).YValuesPerPoint);
					}
				}

				return (yValuesNumber == 1) ? UITypeEditorEditStyle.None : UITypeEditorEditStyle.DropDown;
			}
			return base.GetEditStyle(context);
		}

		#endregion
	}

	/// <summary>
	/// Checked list box, which is used for the series Y dats source member UI type editing.
	/// </summary>
    internal class SeriesDataSourceMemberYCheckedListBox : CheckedListBox
    {
        // Chart object 
        private Chart _chart = null;

        // Object to edit
        protected object editValue = null;

        // Indicates that editor was used for the Y values members
        protected bool usedForYValue = false;

        #region Control constructor

        /// <summary>
        /// Public constructor.
        /// </summary>
        /// <param name="chart">Chart control.</param>
        /// 
        /// <param name="editValue">Value to edit.</param>
        /// <param name="usedForYValue">Indicates that editor was used for the Y values members.</param>
        public SeriesDataSourceMemberYCheckedListBox(Chart chart, object editValue, bool usedForYValue)
        {
            // Set editable value
            this.editValue = editValue;
            this.usedForYValue = usedForYValue;

            // Set control border style
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.IntegralHeight = false;
            // Fill member items list
            //this.FillList();

            // Set Chart
            _chart = chart;
        }

        #endregion

        #region Control methods

        protected override void OnCreateControl()
        {
            this.FillList();
        }

        internal virtual ArrayList GetMemberNames()
        {
            object dataSource = null;
            if (ChartWinDesigner.controlDesigner != null)
            {
                dataSource = ChartWinDesigner.controlDesigner.GetControlDataSource(_chart);
            }

            // Get list of members
            if (dataSource != null)
            {
                return ChartImage.GetDataSourceMemberNames(dataSource, this.usedForYValue);
            }
            return new ArrayList();
        }

        /// <summary>
        /// Fills checked list items
        /// </summary>
        private void FillList()
        {
            // Create arry of current names
            string[] currentNames = null;
            if (editValue != null && editValue is string)
            {
                string editedString = (string)editValue;
                currentNames = editedString.Split(',');
            }

            ArrayList memberNames = this.GetMemberNames();

            // Fill list with all possible values in the enumeration
            foreach (string name in memberNames)
            {
                // Test if item should be checked by default
                bool isChecked = false;
                if (currentNames != null)
                {
                    foreach (string curName in currentNames)
                    {
                        if (name == curName.Trim())
                        {
                            isChecked = true;
                        }
                    }
                }

                // Add items into the list
                this.Items.Add(name, isChecked);
            }
        }

        /// <summary>
        /// Gets new enumeration value.
        /// </summary>
        /// <returns>New enum value.</returns>
        public string GetNewValue()
        {
            // Update enumeration flags
            string result = String.Empty;
            foreach (object checkedItem in this.CheckedItems)
            {
                if (result.Length > 0)
                {
                    result += ", ";
                }
                result += (string)checkedItem;
            }

            // Return value
            return result;
        }

        #endregion
    }

	/// <summary>
	/// Chart type editor. Paint chart type image in the property grid.
	/// </summary>
	internal class ChartTypeEditor : UITypeEditor
	{
		#region Converter methods

		// Reference to the chart type registry
		private ChartTypeRegistry	_chartTypeRegistry = null;

		/// <summary>
		/// Override this function to support chart type drawing
		/// </summary>
		/// <param name="context">Descriptor context.</param>
		/// <returns>Can paint values.</returns>
		public override bool GetPaintValueSupported(ITypeDescriptorContext context)
		{
            // Initialize the chartTypeRegistry using context
			if (context != null && context.Instance != null)
			{
                IChartElement chartElement = context.Instance as IChartElement;
                if (chartElement != null)
                {
                    this._chartTypeRegistry = chartElement.Common.ChartTypeRegistry;
                }
			}

            // Always return true
			return true;
		}

		/// <summary>
		/// Override this function to support chart type drawing
		/// </summary>
		/// <param name="e">Paint value event arguments.</param>
		public override void PaintValue(PaintValueEventArgs e)
		{
			string	chartTypeName = String.Empty;
			if(_chartTypeRegistry != null && e != null)
			{
				if(e.Value is string)
				{
					chartTypeName = (string)e.Value;
				}
				else if(e.Value is SeriesChartType)
				{
					chartTypeName = Series.GetChartTypeName((SeriesChartType)e.Value);
				}


				if(!string.IsNullOrEmpty(chartTypeName))
				{
					IChartType chartType = _chartTypeRegistry.GetChartType(chartTypeName);

					// Get imahe from the chart type
					System.Drawing.Image	chartImage = null;
					if(chartType != null)
					{
						chartImage = chartType.GetImage(_chartTypeRegistry);
					}

					// Draw image
					if(chartImage != null)
					{
						e.Graphics.DrawImage(chartImage, e.Bounds);
					}
				}
			}
		}
		
        #endregion
	}

	/// <summary>
	/// Designer editor for the data points collection.
	/// </summary>
	internal class DataPointCollectionEditor : ChartCollectionEditor
	{
		#region Editor methods

		/// <summary>
		/// Default constructor
		/// </summary>
		public DataPointCollectionEditor() : base(typeof(DataPointCollection))
		{
		}

		/// <summary>
		/// Do not allow to edit if multiple series selected.
		/// </summary>
		/// <param name="context">Descriptor context.</param>
		/// <param name="provider">Service provider.</param>
		/// <param name="value">Value to edit.</param>
		/// <returns>The new value of the object.</returns>
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) 
		{
			if (context != null && context.Instance != null)
			{
				// Save current control type descriptor context
				if(!(context.Instance is Series))
				{
                    throw (new InvalidOperationException(SR.ExceptionEditorMultipleSeriesEditiingUnsupported));
				}
			}
			return base.EditValue(context, provider, value);
		}

		/// <summary>
		/// Create instance of data point object
		/// </summary>
		/// <param name="itemType">Item type.</param>
		/// <returns>New item instance.</returns>
		protected override object CreateInstance(Type itemType)
		{
			if (Context != null && Context.Instance != null)
			{
				if (Context.Instance is Series)
				{
					Series	series = (Series)Context.Instance;
					DataPoint	newDataPoint = new DataPoint(series);
					return newDataPoint;
				}
				else if(Context.Instance is Array)
				{
                    throw (new InvalidOperationException(SR.ExceptionEditorMultipleSeriesEditiingUnsupported));
				}
			}

			return base.CreateInstance(itemType);
		}
	
		#endregion
	}


	/// <summary>
	/// Collection editor that supports property help in the property grid
	/// </summary>
	internal class ChartCollectionEditor : CollectionEditor
	{
		#region Editor methods and properties 

		// Collection editor form
		CollectionForm	_form = null;
        Chart _chart = null;
        ITypeDescriptorContext _context = null;
        
        // Help topic string
		string	_helpTopic = "";
		/// <summary>
		/// Object constructor.
		/// </summary>
		/// <param name="type">AxisName.</param>
		public ChartCollectionEditor(Type type) : base(type)
		{
		}

		/// <summary>
		/// Edit object's value.
		/// </summary>
		/// <param name="context">Descriptor context.</param>
		/// <param name="provider">Service provider.</param>
		/// <param name="value">Value to edit.</param>
		/// <returns>The new value of the object.</returns>
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) 
		{
            _context = context;
            if (context != null && context.Instance != null)
			{
				// Save current control type descriptor context
                _chart = context.Instance as Chart;
			}
            INameController controller = value as INameController;
            bool isReferenceCollection = controller != null && (value is ChartAreaCollection || value is LegendCollection);
            try
            {
                if (isReferenceCollection)
                {
                    controller.DoSnapshot(true, 
                        new EventHandler<NameReferenceChangedEventArgs>(OnNameReferenceChanging),
                        new EventHandler<NameReferenceChangedEventArgs>(OnNameReferenceChanged)
                        );
                    controller.IsColectionEditing = true;
                }
                return base.EditValue(context, provider, value);;
            }
            finally
            {
                if (isReferenceCollection)
                {
                    controller.IsColectionEditing = false;

                    controller.DoSnapshot(false,
                        new EventHandler<NameReferenceChangedEventArgs>(OnNameReferenceChanging),
                        new EventHandler<NameReferenceChangedEventArgs>(OnNameReferenceChanged)
                        );
                }
            }
        }

        /// <summary>
        /// Called when [name reference changing].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="NameReferenceChangedEventArgs"/> instance containing the event data.</param>
        private void OnNameReferenceChanging(object sender, NameReferenceChangedEventArgs e)
        {
            IComponentChangeService svc = _context.GetService(typeof(IComponentChangeService)) as IComponentChangeService;
            if (svc != null)
            {
                svc.OnComponentChanging(this._chart, null);
            }
        }

        /// <summary>
        /// Called when [name reference changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="NameReferenceChangedEventArgs"/> instance containing the event data.</param>
        private void OnNameReferenceChanged(object sender, NameReferenceChangedEventArgs e)
        {
            IComponentChangeService svc = _context.GetService(typeof(IComponentChangeService)) as IComponentChangeService;
            if (svc != null)
            {
                svc.OnComponentChanged(this._chart, null, null, null);
            }
        }

        /// <summary>
        /// Sets the specified array as the items of the collection.
        /// </summary>
        /// <param name="editValue">The collection to edit.</param>
        /// <param name="value">An array of objects to set as the collection items.</param>
        /// <returns>
        /// The newly created collection object or, otherwise, the collection indicated by the <paramref name="editValue"/> parameter.
        /// </returns>
        protected override object SetItems(object editValue, object[] value)
        {
            object result = base.SetItems(editValue, value);

            IComponentChangeService svc = _context.GetService(typeof(IComponentChangeService)) as IComponentChangeService;
            INameController controller = editValue as INameController;
            if (controller != null && svc != null && (editValue is ChartAreaCollection || editValue is LegendCollection))
            {
                IList newList = (IList)result;
                bool elementsRemoved = false;
                foreach (ChartNamedElement element in controller.Snapshot)
                {
                    if (newList.IndexOf(element) < 0)
                    {
                        elementsRemoved = true;
                    }
                }
                if (elementsRemoved)
                {
                    svc.OnComponentChanging(this._chart, null);
                    ChartNamedElement defaultElement = (ChartNamedElement)(newList.Count > 0 ? newList[0] : null);
                    foreach (ChartNamedElement element in controller.Snapshot)
                    {
                        if (newList.IndexOf(element) < 0)
                        {
                            controller.OnNameReferenceChanged(new NameReferenceChangedEventArgs(element, defaultElement));
                        }
                    }
                    svc.OnComponentChanged(this._chart, null, null, null);
                }
            }
            return result;
        }


		/// <summary>
		/// Ovveride the HelpTopic property to provide different topics,
		/// depending on selected property.
		/// </summary>
		protected override string HelpTopic
		{
			get
			{
				return (_helpTopic.Length == 0) ? base.HelpTopic : _helpTopic;
			}
		}

		/// <summary>
		/// Displaying help for the curently selected item in the property grid
		/// </summary>
		protected override void ShowHelp()
		{
			// Init topic name
			_helpTopic = "";
            PropertyGrid grid = this.GetPropertyGrid(_form.Controls);

			// Check currently selected grid item
			if(grid != null)
			{
				GridItem item = grid.SelectedGridItem;
				if(item != null && (item.GridItemType == GridItemType.Property || item.GridItemType == GridItemType.ArrayValue))
				{
					_helpTopic = item.PropertyDescriptor.ComponentType.ToString() + "." + item.PropertyDescriptor.Name;
				}
			}

			// Call base class
			base.ShowHelp();

			// Re-Init topic name
			_helpTopic = "";
		}

        /// <summary>
        /// Returns the collection form property grid. Added for VS2005 compatibility.
        /// </summary>
        /// <param name="controls"></param>
        /// <returns></returns>
        private PropertyGrid GetPropertyGrid(System.Windows.Forms.Control.ControlCollection controls)
        {
            foreach (System.Windows.Forms.Control control in controls)
            {
                PropertyGrid grid = control as PropertyGrid;
                if (grid != null)
                {
                    return grid;
                }
                if (control.Controls.Count > 0)
                {
                    grid = GetPropertyGrid(control.Controls);
                    if (grid != null)
                    {
                        return grid;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Collect the collection editor form buttons into array. Added for VS2005 compatibility.
        /// </summary>
        /// <param name="buttons"></param>
        /// <param name="controls"></param>
        private void CollectButtons(ArrayList buttons, System.Windows.Forms.Control.ControlCollection controls)
        {
            foreach (System.Windows.Forms.Control control in controls)
            {
                if (control is System.Windows.Forms.Button)
                {
                    buttons.Add(control);
                }
                if (control.Controls.Count > 0)
                {
                    CollectButtons(buttons, control.Controls);
                }
            }
        }

		/// <summary>
		/// Cretaes form for collection editing.
		/// </summary>
		/// <returns>Form object.</returns>
		protected override CollectionForm CreateCollectionForm()
		{
			_form = base.CreateCollectionForm();

            // Changed Apr 29, DT,  for VS2005 compatibility
            PropertyGrid grid = GetPropertyGrid(_form.Controls);
            if (grid != null)
            {
                // Show properties help
                grid.HelpVisible = true;
                grid.CommandsVisibleIfAvailable = true;

                // Hookup to the update events
                grid.PropertyValueChanged += new PropertyValueChangedEventHandler(this.OnPropertyChanged);
                grid.ControlAdded += new ControlEventHandler(this.OnControlAddedRemoved);
                grid.ControlRemoved += new ControlEventHandler(this.OnControlAddedRemoved);

            }
            
            // Changed Apr 29, DT, for VS2005 compatibility
            ArrayList buttons = new ArrayList();
            this.CollectButtons(buttons, _form.Controls);
            foreach (System.Windows.Forms.Button button in buttons)
            {
                if (button.DialogResult == DialogResult.OK ||
                    button.DialogResult == DialogResult.Cancel)
                {
                    button.Click += new EventHandler(this.OnOkClicked);
                }

            }

			return _form;
		}


		/// <summary>
		/// Update design-time HTML when OK button is clicked in the collection editor
		/// </summary>
		private void OnOkClicked(object sender, EventArgs e)
		{
			// Clear the help topic
			_helpTopic = "";
		}

		/// <summary>
		/// Update design-time HTML when propery is added or removed
		/// </summary>
		private void OnControlAddedRemoved(object sender, ControlEventArgs e)
		{
		}

		/// <summary>
		/// Update design-time HTML when propery is changed
		/// </summary>
		private void OnPropertyChanged(object sender, PropertyValueChangedEventArgs e)
		{
		}

		/// <summary>
		/// Checks if the instance belongs to Chart type or contains the field of chart type. 
		/// NOTE: Required for the Diagram product.
		/// </summary>
		/// <param name="instance">
		/// Instance to check.
		/// </param>
		/// <returns>
		/// Object of chart type.
		/// </returns>
		public static object GetChartReference(object instance)
		{
			// Check instance type.
			if(instance is Chart)
			{
				return instance;
			}

			// Read chart reference from the "chart" field.
            IChartElement element = instance as IChartElement;
            if (element != null)
                return element.Common.Chart;
            else
                throw (new InvalidOperationException(SR.ExceptionEditorContectInstantsIsNotChartObject));
		}

        protected override void DestroyInstance(object instance)
        {
            // don't destroy instance because remove is clicked.
        }

		#endregion
	}


	/// <summary>
	/// Designer editor for the data series collection.
	/// </summary>
	internal class SeriesCollectionEditor : ChartCollectionEditor
	{
		#region Editor methods

		/// <summary>
		/// Object constructor.
		/// </summary>
		public SeriesCollectionEditor() : base(typeof(SeriesCollection))
		{
		}

        internal static Series CreateNewSeries(Chart control, string suggestedChartArea)
        {
            int countSeries = control.Series.Count + 1;
            string seriesName = "Series" + countSeries.ToString(System.Globalization.CultureInfo.InvariantCulture);

            // Check if this name already in use
            bool seriesFound = true;
            while (seriesFound)
            {
                seriesFound = false;
                foreach (Series series in control.Series)
                {
                    if (series.Name == seriesName)
                    {
                        seriesFound = true;
                    }
                }

                if (seriesFound)
                {
                    ++countSeries;
                    seriesName = "Series" + countSeries.ToString(System.Globalization.CultureInfo.InvariantCulture);
                }
            }

            // Create new series
            Series newSeries = new Series(seriesName);

            // Check if default chart area name exists
            if (control.ChartAreas.Count > 0)
            {
                bool defaultFound = false;

                if (!string.IsNullOrEmpty(suggestedChartArea) &&
                    control.ChartAreas.IndexOf(suggestedChartArea) != -1)
                {
                    newSeries.ChartArea = suggestedChartArea;
                    defaultFound = true;
                }
                else
                {
                    foreach (ChartArea area in control.ChartAreas)
                    {
                        if (area.Name == newSeries.ChartArea)
                        {
                            defaultFound = true;
                            break;
                        }
                    }
                }

                // If default chart area was not found - use name of the first area
                if (!defaultFound)
                {
                    newSeries.ChartArea = control.ChartAreas[0].Name;
                }

                // Check if series area is circular
                if (control.ChartAreas[newSeries.ChartArea].chartAreaIsCurcular)
                {
                    // Change default chart type
                    newSeries.ChartTypeName = ChartTypeNames.Radar;

                    // Check if it's a Polar chart type
                    IChartType chartType = control.ChartAreas[newSeries.ChartArea].GetCircularChartType() as IChartType;
                    if (chartType != null && String.Compare(chartType.Name, ChartTypeNames.Polar, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        newSeries.ChartTypeName = ChartTypeNames.Polar;
                    }
                }
            }

            return newSeries;
        }

		/// <summary>
		/// Create series instance in the editor 
		/// </summary>
		/// <param name="itemType">Item type.</param>
		/// <returns>Newly created item.</returns>
		protected override object CreateInstance(Type itemType)
		{
			if (Context != null && Context.Instance != null)
			{
				Chart	control = (Chart)GetChartReference(Context.Instance);
                return SeriesCollectionEditor.CreateNewSeries(control, String.Empty);
            }

			return base.CreateInstance(itemType);
		}
	
		#endregion
	}
}


