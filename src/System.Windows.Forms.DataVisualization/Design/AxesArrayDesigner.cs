// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	Design-time editors and converters for the Axes array.
//


using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;

namespace System.Windows.Forms.Design.DataVisualization.Charting
{
    /// <summary>
    /// Designer editor for the chart areas collection.
    /// </summary>
    internal class AxesArrayEditor : ArrayEditor
		{
    #region Fields and Constructor

			// Collection form
			CollectionForm	_form = null;

			// Help topic string
			private string	_helpTopic = "";

			/// <summary>
			/// Object constructor.
			/// </summary>
			public AxesArrayEditor() : base(typeof(Axis[]))
			{
			}

        #endregion

    #region Methods

		/// <summary>
		/// Items can not be removed.
		/// </summary>
		/// <param name="value">Value.</param>
		/// <returns>False if can't remove.</returns>
		protected override bool CanRemoveInstance(object value)
		{
			return false;
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
		/// Displaying help for the curently selected item in the property grid
		/// </summary>
		protected override void ShowHelp()
		{
			// Init topic name
			_helpTopic = "";
			PropertyGrid	grid = this.GetPropertyGrid(_form.Controls);;
			
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
		/// Creates editor's form.
		/// </summary>
		/// <returns>Collection form.</returns>
		protected override CollectionForm CreateCollectionForm()
		{
			// Create collection form using the base class
			_form = base.CreateCollectionForm();
            // Changed Apr 29, DT,  for VS2005 compatibility
            PropertyGrid grid = GetPropertyGrid(_form.Controls);
            if (grid != null)
            {
                // Show properties help
                grid.HelpVisible = true;
                grid.CommandsVisibleIfAvailable = true;
            }

            // Changed Apr 29, DT, for VS2005 compatibility
            ArrayList buttons = new ArrayList();
            this.CollectButtons(buttons, _form.Controls);
            foreach (System.Windows.Forms.Button button in buttons)
            {
                if (button.Name.StartsWith("add", StringComparison.OrdinalIgnoreCase) ||
                    button.Name.StartsWith("remove", StringComparison.OrdinalIgnoreCase) ||
                    button.Text.Length == 0)
                {
                    button.Enabled = false;
                    button.EnabledChanged += new EventHandler(Button_EnabledChanged);
                }
            }
			return _form;
		}

        /// <summary>
        /// Flag to prevent stack overflow.
        /// </summary>
        private bool _button_EnabledChanging = false;

        /// <summary>
        /// Handles the EnabledChanged event of the Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Button_EnabledChanged(object sender, EventArgs e)
        {
            if ( _button_EnabledChanging ) return;
            _button_EnabledChanging = true;
            try
            {
                ((System.Windows.Forms.Button)sender).Enabled = false;
            }
            finally
            {
                _button_EnabledChanging = false;
            }
        }

    #endregion
        }

        internal class DataPointCustomPropertiesConverter : TypeConverter
        {

            /// <summary>
            /// Returns whether this object supports properties, using the specified context.
            /// </summary>
            /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
            /// <returns>
            /// true if <see cref="M:System.ComponentModel.TypeConverter.GetProperties(System.Object)"/> should be called to find the properties of this object; otherwise, false.
            /// </returns>
            public override bool GetPropertiesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            /// <summary>
            /// Returns a collection of properties for the type of array specified by the value parameter, using the specified context and attributes.
            /// </summary>
            /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
            /// <param name="value">An <see cref="T:System.Object"/> that specifies the type of array for which to get properties.</param>
            /// <param name="attributes">An array of type <see cref="T:System.Attribute"/> that is used as a filter.</param>
            /// <returns>
            /// A <see cref="T:System.ComponentModel.PropertyDescriptorCollection"/> with the properties that are exposed for this data type, or null if there are no properties.
            /// </returns>
            public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
            {
                // Fill collection with properties descriptors
                PropertyDescriptorCollection propDescriptors = TypeDescriptor.GetProperties(value, attributes, false);

                // Return original collection if not in design mode
                if (context != null && context.Instance is ChartElement && 
                    (context.Instance as ChartElement).Chart != null &&
                    (context.Instance as ChartElement).Chart.IsDesignMode())
                {
                    // Create new descriptors collection
                    PropertyDescriptorCollection newPropDescriptors = new PropertyDescriptorCollection(null);

                    // Loop through all original property descriptors
                    foreach (PropertyDescriptor propertyDescriptor in propDescriptors)
                    {
                        // Change name of "CustomAttributesEx" property to "CustomProperties"
                        if (propertyDescriptor.Name == "CustomAttributesEx")
                        {
                            DynamicPropertyDescriptor dynPropDesc = new DynamicPropertyDescriptor(
                                propertyDescriptor,
                                "CustomProperties");
                            newPropDescriptors.Add(dynPropDesc);
                        }
                        else
                        {
                            newPropDescriptors.Add(propertyDescriptor);
                        }
                    }
                    return newPropDescriptors;
                }

                // Return original collection if not in design mode
                return propDescriptors;

            }

            /// <summary>
            /// Converts the given value object to the specified type, using the specified context and culture information.
            /// </summary>
            /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
            /// <param name="culture">A <see cref="T:System.Globalization.CultureInfo"/>. If null is passed, the current culture is assumed.</param>
            /// <param name="value">The <see cref="T:System.Object"/> to convert.</param>
            /// <param name="destinationType">The <see cref="T:System.Type"/> to convert the <paramref name="value"/> parameter to.</param>
            /// <returns>
            /// An <see cref="T:System.Object"/> that represents the converted value.
            /// </returns>
            /// <exception cref="T:System.ArgumentNullException">The <paramref name="destinationType"/> parameter is null. </exception>
            /// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
            {
                if (context != null)
                {
                    if (destinationType == typeof(string))
                    {
                        return "";
                    }
                }                // Always call base, even if you can't convert.
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }


        /// <summary>
        /// DataPoint Converter - helps windows form serializer to create inline datapoints.
        /// </summary>
        internal class DataPointConverter : DataPointCustomPropertiesConverter
        {

            /// <summary>
            /// This method overrides CanConvertTo from TypeConverter. This is called when someone
            /// wants to convert an instance of object to another type.  Here,
            /// only conversion to an InstanceDescriptor is supported.
            /// </summary>
            /// <param name="context">Descriptor context.</param>
            /// <param name="destinationType">Destination type.</param>
            /// <returns>True if object can be converted.</returns>
            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                if (destinationType == typeof(InstanceDescriptor))
                {
                    return true;
                }

                // Always call the base to see if it can perform the conversion.
                return base.CanConvertTo(context, destinationType);
            }

            /// <summary>
            /// This methods performs the actual conversion from an object to an InstanceDescriptor.
            /// </summary>
            /// <param name="context">Descriptor context.</param>
            /// <param name="culture">Culture information.</param>
            /// <param name="value">Object value.</param>
            /// <param name="destinationType">Destination type.</param>
            /// <returns>Converted object.</returns>
            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
            {
                DataPoint dataPoint = value as DataPoint;
                if (destinationType == typeof(InstanceDescriptor) && dataPoint != null)
                {
                    if (dataPoint.YValues.Length > 1)
                    {
                        ConstructorInfo ci = typeof(DataPoint).GetConstructor(new Type[] { typeof(double), typeof(string) });
                        string yValues = "";
                        foreach (double y in dataPoint.YValues)
                        {
                            yValues += y.ToString(System.Globalization.CultureInfo.InvariantCulture) + ",";
                        }

                        return new InstanceDescriptor(ci, new object[] { dataPoint.XValue, yValues.TrimEnd(',') }, false);
                    }
                    else
                    {
                        ConstructorInfo ci = typeof(DataPoint).GetConstructor(new Type[] { typeof(double), typeof(double) });
                        return new InstanceDescriptor(ci, new object[] { dataPoint.XValue, dataPoint.YValues[0] }, false);
                    }
                }
                // Always call base, even if you can't convert.
                return base.ConvertTo(context, culture, value, destinationType);
            }

        }

    }
