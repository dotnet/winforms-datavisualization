//-------------------------------------------------------------
// <copyright company=�Microsoft Corporation�>
//   Copyright � Microsoft Corporation. All Rights Reserved.
// </copyright>
//-------------------------------------------------------------
// @owner=alexgor, deliant
//=================================================================
//  File:		ChartAreaCircular.cs
//
//  Namespace:	System.Web.UI.WebControls[Windows.Forms].Charting
//
//	Classes:	CircularChartAreaAxis
//
//  Purpose:	CircularChartAreaAxis is a helper class which is used
//              in circular chart areas for charts like Polar and 
//              Radar. 
//
//	Reviewed:	AG - March 16, 2007
//
//===================================================================


using System.Drawing;

namespace System.Windows.Forms.DataVisualization.Charting
{
    /// <summary>
    /// CircularChartAreaAxis class represents a single axis in the circular 
    /// chart area chart like radar or polar. It contains axis angular 
    /// position, size and title properties.
    /// </summary>
    internal class CircularChartAreaAxis
	{
		#region Fields

		/// <summary>
		/// Angle where axis is located.
		/// </summary>
		internal	float	AxisPosition = 0f;

		/// <summary>
		/// Axis title.
		/// </summary>
		internal	string	Title = string.Empty;

        /// <summary>
        /// Axis title color.
        /// </summary>
        internal    Color TitleForeColor = Color.Empty;

		#endregion

		#region Constructors

		/// <summary>
		/// Constructor.
		/// </summary>
		public CircularChartAreaAxis()
		{
		}

		/// <summary>
		/// Constructor.
		/// </summary>
		internal CircularChartAreaAxis(float axisPosition)
		{
			this.AxisPosition = axisPosition;
		}

		#endregion
	}
}
