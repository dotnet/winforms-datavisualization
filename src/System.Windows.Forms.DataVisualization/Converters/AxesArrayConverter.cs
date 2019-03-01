
//-------------------------------------------------------------
// <copyright company=�Microsoft Corporation�>
//   Copyright � Microsoft Corporation. All Rights Reserved.
// </copyright>
//-------------------------------------------------------------
// @owner=alexgor, deliant
//=================================================================
//  File:		AxesArrayConverter.cs
//
//  Namespace:	DataVisualization.Charting.Design
//
//	Classes:	AxesArrayConverter
//
//  Purpose:	Converter for the Axes array.
//
//	Reviewed:	AG - August 7, 2002
//
//===================================================================

using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace System.Windows.Forms.DataVisualization.Charting
{
    /// <summary>
	/// Converter object of axes array
	/// </summary>
    internal class AxesArrayConverter : TypeConverter
	{
		#region Converter methods

		/// <summary>
		/// Subproperties NOT suported.
		/// </summary>
		/// <param name="context">Descriptor context.</param>
		/// <returns>Always false.</returns>
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return false;
		}

		/// <summary>
		/// Overrides the ConvertTo method of TypeConverter.
		/// </summary>
		/// <param name="context">Descriptor context.</param>
		/// <param name="culture">Culture information.</param>
		/// <param name="value">Value.</param>
		/// <param name="destinationType">Destination type.</param>
		/// <returns>Converted object.</returns>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) 
		{  
			// Convert collection to string
			if (destinationType == typeof(string)) 
			{
                return (new CollectionConverter()).ConvertToString(new ArrayList());
			}

			return base.ConvertTo(context, culture, value, destinationType);
		}

		#endregion
	}
}
