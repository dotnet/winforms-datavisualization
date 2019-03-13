﻿//-------------------------------------------------------------
// <copyright company=’Microsoft Corporation’>
//   Copyright © Microsoft Corporation. All Rights Reserved.
// </copyright>
//-------------------------------------------------------------
// @owner=alexgor, deliant
//=================================================================
//  File:		AreaDesigner.cs
//
//  Namespace:	DataVisualization.Charting.Design
//
//	Classes:	AreaCollectionEditor
//
//  Purpose:	Design-time chart areas collection editor class
//
//	Reviewed:	AG - August 7, 2002
//
//===================================================================

using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace System.Windows.Forms.Design.DataVisualization.Charting
{
    /// <summary>
    /// Designer editor for the chart areas collection.
    /// </summary>
    internal class AreaCollectionEditor : ChartCollectionEditor
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public AreaCollectionEditor() : base(typeof(ChartAreaCollection))
		{
		}
	}

    /// <summary>
    /// Used for invoking windows forms MesageBox dialog.
    /// </summary>
    internal class DesignerMessageBoxDialog : IDesignerMessageBoxDialog
    {
        /// <summary>
        /// Shows Yes/No MessageBox.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>
        /// rue if user confirms with Yes
        /// </returns>
        bool IDesignerMessageBoxDialog.ShowQuestion(string message)
        {

            // Show dialog box to the user with Yes and No options
            DialogResult result = MessageBox.Show(
                message,
                SR.MessageChartTitle,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, GetMessageBoxOptions());
            
            return result == DialogResult.Yes;
        }

        // Gets the MessageBoxOptions based on the system Culture settings
        internal static MessageBoxOptions GetMessageBoxOptions()
        {
            if (CultureInfo.CurrentCulture.TextInfo.IsRightToLeft)
                return MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign;
            else
                return (MessageBoxOptions)0; // Unfortunately, the MessageBoxOptions enum doesn't have a predefined ".None" value.;                        
        }
    }
}

