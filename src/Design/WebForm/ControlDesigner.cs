//-------------------------------------------------------------
// <copyright company=’Microsoft Corporation’>
//   Copyright © Microsoft Corporation. All Rights Reserved.
// </copyright>
//-------------------------------------------------------------
// @owner=alexgor, deliant
//=================================================================
//  File:		ControlDesigner.cs
//
//  Namespace:	Design.DataVisualization.Charting
//
//	Classes:	ChartBuilder
//
//  Purpose:    Implements ControlBuilder for chart.
//
//	Reviewed:	--
//
//===================================================================

using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.Design;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.DataVisualization.Charting.Data;
using System.Web.UI.DataVisualization.Charting.Utilities;

namespace System.Web.UI.Design.DataVisualization.Charting
{

    /// <summary>
	/// Chart control builder.
	/// </summary>
	internal class ChartBuilder : ControlBuilder
	{
		#region Methods

		/// <summary>
		/// Get child controls type
		/// </summary>
		/// <param name="tagName">Control tag.</param>
		/// <param name="attributes">Control attributes.</param>
		/// <returns>Control type.</returns>
		public override Type GetChildControlType(String tagName, IDictionary attributes) 
		{
			if(String.Compare(tagName, "Series", StringComparison.OrdinalIgnoreCase) == 0) 
			{
				return typeof(Series);
			}
            else if (String.Compare(tagName, "dcwc:DataPoint", StringComparison.OrdinalIgnoreCase) == 0) 
			{
				return typeof(DataPoint);
			}
            else if (String.Compare(tagName, "dcwc:Legend", StringComparison.OrdinalIgnoreCase) == 0) 
			{
				return typeof(Legend);
			}
            else if (String.Compare(tagName, "dcwc:ChartArea", StringComparison.OrdinalIgnoreCase) == 0) 
			{
				return typeof(ChartArea);
			}

			return null;
		}

		/// <summary>
		/// Override to ignore literals between items
		/// </summary>
		/// <param name="s">Literal string to add.</param>
		public override void AppendLiteralString(string s) 
		{
		}

		#endregion
	}

}
