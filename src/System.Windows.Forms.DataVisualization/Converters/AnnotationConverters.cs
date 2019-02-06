// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	Annotation Converters.
//


using System.ComponentModel;
using System.Globalization;

namespace System.Windows.Forms.DataVisualization.Charting
{
    /// <summary>
	/// Converts anchor data point to string name.
	/// </summary>
	internal class AnchorPointValueConverter : TypeConverter
	{
		#region Converter methods

	/// <summary>
	/// Converts anchor data point to string name.
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
            if (value == null)
            {
                return Constants.NotSetValue;
            }
            DataPoint dataPoint = value as DataPoint;

            if (dataPoint != null)
            {
                if (dataPoint.series != null)
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
    internal class AnnotationAxisValueConverter : TypeConverter
	{
		#region Converter methods

		/// <summary>
		/// Converts axis associated with anootation to string.
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
                if (value == null)
                {
                    return Constants.NotSetValue;
                }

                Axis axis = value as Axis;
                if (axis != null)
                {
                    if (axis.ChartArea != null)
                    {
                        return axis.ChartArea.Name + " - " + axis.Name;
                    }
                }
            }

            // Call base class
            return base.ConvertTo(context, culture, value, destinationType);
        }
		#endregion
	}
}

