//-------------------------------------------------------------
// <copyright company=’Microsoft Corporation’>
//   Copyright © Microsoft Corporation. All Rights Reserved.
// </copyright>
//-------------------------------------------------------------
// @owner=deliant, krisztb
//=================================================================
//  File:		ColorExtendedArrayEditor.cs
//
//  Namespace:	DataVisualization.Charting.Design
//
//	Classes:	ColorExtended, ColorExtendedArrayConverter, 
//              ColorExtendedArrayPropertyDescriptor, ColorExtendedEditor
//
//  Purpose:	In case of Web Charts, Editor for Color collection is
//              very basic. In order to use the same ChartColorEditor
//              for color arrays just as for simple color properties
//              an extended Color class can be used to shadow the
//              original property.
//
//	Reviewed:	
//
//===================================================================

using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

namespace System.Web.UI.Design.DataVisualization.Charting
{
    /// <summary>
    /// Extends System.Drawing.Color with Chart's own Color editor
    /// </summary>
    [Editor(typeof(ColorExtendedEditor), typeof(System.Drawing.Design.UITypeEditor))]
    internal class ColorExtended
    {
        private Color _color;


        /// <summary>
        /// Creates and initializes an extended Color.
        /// </summary>
        /// <param name="color">The Color.</param>
        public ColorExtended(Color color)
        {
            _color = color;
        }

        /// <summary>
        /// Creates an extended empty Color.
        /// </summary>
        public ColorExtended() { }


        /// <summary>
        /// Gets or sets the Color value
        /// </summary>
        [
        Editor(typeof(ChartColorEditor), typeof(System.Drawing.Design.UITypeEditor)),
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification="set(Color) is needed in Design Mode")
        ]
        public Color Value
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// Converts the Color value to a human readable string.
        /// </summary>
        /// <returns>The string representation of the Color.</returns>
        public override string ToString()
        {
            ColorConverter colorConverter = new ColorConverter();
            string result = colorConverter.ConvertToInvariantString(_color);

            return (String.IsNullOrEmpty(result) ? Color.Empty.Name : result);
        }
    }

    /// <summary>
    /// Editor for ColorExtended type that displays the color name and the color as a painted box. 
    /// </summary>
    internal class ColorExtendedEditor : System.Drawing.Design.UITypeEditor
    {
        #region UI editor methods

        /// <summary>
        /// Returns true as it supports palette colors drawing
        /// </summary>
        /// <param name="context">Descriptor context.</param>
        /// <returns>Can paint values.</returns>
        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        /// <summary>
        /// Paints the color box beside the color name.
        /// </summary>
        /// <param name="e">Paint value event arguments.</param>
        public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e)
        {
            // Get palette colors array
            ColorExtended color = e.Value as ColorExtended;

            if (color != null)
            {
                e.Graphics.FillRectangle(new SolidBrush(color.Value), e.Bounds);
            }
        }

        #endregion
    }

    /// <summary>
    /// Property descriptor to shadow Color[] with ColorExtended[].
    /// </summary>
    internal class ColorExtendedArrayPropertyDescriptor : PropertyDescriptor
    {
        #region Fields

        private PropertyDescriptor _basePropertyDescriptor;

        #endregion // Fields
        
        #region Constructor

        /// <summary>
        /// Creates and initializes a property descriptor for ColorExtended arrays.
        /// </summary>
        /// <param name="basePropertyDescriptor">Descriptor of the property to shadow with a type of Color[].</param>
        public ColorExtendedArrayPropertyDescriptor(PropertyDescriptor basePropertyDescriptor)
            : base(basePropertyDescriptor)
        {
            _basePropertyDescriptor = basePropertyDescriptor;

            // Alter TypeConverter
            System.ComponentModel.AttributeCollection attributeCollection = System.ComponentModel.AttributeCollection.FromExisting(
                basePropertyDescriptor.Attributes,
                new TypeConverterAttribute(typeof(ColorExtendedArrayConverter)));

            Attribute[] attributes = new Attribute[attributeCollection.Count];
            attributeCollection.CopyTo(attributes, 0);

            base.AttributeArray = attributes;
        }

        #endregion // Constructor

        #region Properties

        /// <summary>
        /// Gets the type of the component this property is bound to.
        /// </summary>
        public override Type ComponentType
        {
            get
            { 
                return _basePropertyDescriptor.ComponentType;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this property is read-only.
        /// </summary>
        public override bool IsReadOnly
        {
            get
            {
                return _basePropertyDescriptor.IsReadOnly;
            }
        }

        /// <summary>
        /// Gets the type of the property.
        /// </summary>
        public override Type PropertyType
        {
            get
            {
                return typeof(ColorExtended[]);
            }
        }

        #endregion // Properties

        #region Methods

        /// <summary>
        /// Returns whether resetting an object changes its value.
        /// </summary>
        /// <param name="component">The component to test for reset capability.</param>
        /// <returns>true if resetting the component changes its value; otherwise, false.</returns>
        public override bool CanResetValue(object component)
        {
            return _basePropertyDescriptor.CanResetValue(component);
        }

        /// <summary>
        /// Gets the current value of the property on a component.
        /// </summary>
        /// <param name="component">The component with the property for which to retrieve the value.</param>
        /// <returns>The value of a property for a given component.</returns>
        public override object GetValue(object component)
        {
            object value = _basePropertyDescriptor.GetValue(component);

            Color[] colors = value as Color[];
            if (colors != null)
            {
                ColorExtended[] results = new ColorExtended[colors.Length];

                for (int i = 0; i < colors.Length; i++)
                {
                    results[i] = new ColorExtended(colors[i]);
                }

                return results;
            }
            else
            {
                return new ColorExtended[] { };
            }
        }

        /// <summary>
        /// Resets the value for this property of the component to the default value.
        /// </summary>
        /// <param name="component">The component with the property value that is to be reset to the default value.</param>
        public override void ResetValue(object component)
        {
            _basePropertyDescriptor.ResetValue(component);
        }

        /// <summary>
        /// Sets the value of the component to a different value.
        /// </summary>
        /// <param name="component">The component with the property value that is to be set.</param>
        /// <param name="value">The new value.</param>
        public override void SetValue(object component, object value)
        {
            ColorExtended[] extendedColors = value as ColorExtended[];

            if (extendedColors != null)
            {
                Color[] colors = new Color[extendedColors.Length];

                for (int i = 0; i < extendedColors.Length; i++)
                {
                    colors[i] = extendedColors[i].Value;
                }

                _basePropertyDescriptor.SetValue(component, colors);
            }
        }

        /// <summary>
        /// Determines a value indicating whether the value of this property needs to be persisted.
        /// </summary>
        /// <param name="component">The component with the property to be examined for persistence.</param>
        /// <returns>True if the property should be persisted; otherwise, false.</returns>
        public override bool ShouldSerializeValue(object component)
        {
            return _basePropertyDescriptor.ShouldSerializeValue(component);
        }

        #endregion // Methods
    }

    /// <summary>
    /// Converter for ColorExtended type.
    /// </summary>
    internal class ColorExtendedArrayConverter : TypeConverter
    {
        #region Converter methods

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
            if (destinationType == typeof(string))
            {
                return true;
            }

            // Always call the base to see if it can perform the conversion.
            return base.CanConvertTo(context, destinationType);
        }

        /// <summary>
        /// Overrides the CanConvertFrom method of TypeConverter.
        /// The ITypeDescriptorContext interface provides the context for the
        /// conversion. Typically this interface is used at design time to 
        /// provide information about the design-time container.
        /// </summary>
        /// <param name="context">Descriptor context.</param>
        /// <param name="sourceType">Convertion source type.</param>
        /// <returns>Indicates if convertion is possible.</returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        /// <summary>
        /// Overrides the ConvertTo method of TypeConverter.
        /// </summary>
        /// <param name="context">Descriptor context.</param>
        /// <param name="culture">Culture information.</param>
        /// <param name="value">Value to convert.</param>
        /// <param name="destinationType">Convertion destination type.</param>
        /// <returns>Converted object.</returns>
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return ColorArrayToString(value as ColorExtended[]);
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

        /// <summary>
        /// Overrides the ConvertFrom method of TypeConverter.
        /// </summary>
        /// <param name="context">Descriptor context.</param>
        /// <param name="culture">Culture information.</param>
        /// <param name="value">Value to convert from.</param>
        /// <returns>Converted object.</returns>
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            // Can convert from string where each array element is separated by comma
            string stringValue = value as string;
            if (stringValue != null)
            {
                return StringToColorArray(stringValue);
            }

            // Call base class
            return base.ConvertFrom(context, culture, value);
        }

        /// <summary>
        /// Converts array of extended colors into string.
        /// </summary>
        /// <param name="colors">Extended Colors array.</param>
        /// <returns>Result string.</returns>
        public static string ColorArrayToString(ColorExtended[] colors)
        {
            if (colors != null && colors.GetLength(0) > 0)
            {
                ColorConverter colorConverter = new ColorConverter();
                string result = string.Empty;
                foreach (ColorExtended colorExtended in colors)
                {
                    if (result.Length > 0)
                    {
                        result += "; ";
                    }
                    result += colorConverter.ConvertToInvariantString(colorExtended.Value);
                }
                return result;
            }
            return string.Empty;
        }

        /// <summary>
        /// Converts string into array of extended colors.
        /// </summary>
        /// <param name="colorNames">String data.</param>
        /// <returns>Array of colors.</returns>
        public static ColorExtended[] StringToColorArray(String colorNames)
        {
            ColorConverter colorConverter = new ColorConverter();
            ColorExtended[] array = new ColorExtended[0];
            if (colorNames.Length > 0)
            {
                string[] colorValues = colorNames.Split(';');
                array = new ColorExtended[colorValues.Length];
                int index = 0;
                foreach (string str in colorValues)
                {
                    array[index++] = new ColorExtended((Color)colorConverter.ConvertFromInvariantString(str));
                }
            }
            return array;
        }

        #endregion
    }
}
