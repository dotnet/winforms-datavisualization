//-------------------------------------------------------------
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


#region Used Namespaces

using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
#if WINFORMS_CONTROL
	using System.Windows.Forms.DataVisualization.Charting;
#else
using System.Web.UI.DataVisualization.Charting;

#endif

#endregion

#if WINFORMS_CONTROL

	namespace System.Windows.Forms.Design.DataVisualization.Charting


#else
	namespace System.Web.UI.Design.DataVisualization.Charting
#endif
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

#if !WINFORMS_CONTROL
		/// <summary>
		/// Edit area value. 
		/// Saves a referense to the chart descriptor context.
		/// </summary>
		/// <param name="context">Editing context.</param>
		/// <param name="provider">Provider.</param>
		/// <param name="value">Value to edit.</param>
		/// <returns>Result</returns>
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) 
		{
			if (context != null && context.Instance != null)
			{
				// Save current control type descriptor context
				if(context.Instance is Chart)
				{
					Chart.controlCurrentContext = context;
				}
			}
			return base.EditValue(context, provider, value);
		}
#endif // !WINFORMS_CONTROL
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

