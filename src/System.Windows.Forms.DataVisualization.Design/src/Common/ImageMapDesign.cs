//-------------------------------------------------------------
// <copyright company=’Microsoft Corporation’>
//   Copyright © Microsoft Corporation. All Rights Reserved.
// </copyright>
//-------------------------------------------------------------
// @owner=alexgor, deliant
//=================================================================
//  File:		ImageMapDesign.cs
//
//  Namespace:	DataVisualization.Charting.Design
//
//	Classes:	ImageValueEditor, ChartUrlEditor
//
//  Purpose:	Design-time classes for the image maps.
//
//	Reviewed:	AG - August 7, 2002
//
//===================================================================



#region Used Namespaces

using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Data;
#if WINFORMS_CONTROL
	using System.Windows.Forms.DataVisualization.Charting;
	using System.Windows.Forms.DataVisualization.Charting.Utilities;
#else
	using System.Web;
	using System.Web.UI;
	using System.Web.UI.WebControls;
    using System.Web.UI.Design;
    using System.Web.UI.DataVisualization.Charting;
    using System.Web.UI.DataVisualization.Charting.Utilities;
	using System.Web.UI.DataVisualization.Charting.Data;	
#endif

#endregion

#if WINFORMS_CONTROL

namespace System.Windows.Forms.Design.DataVisualization.Charting

#else
	namespace System.Web.UI.Design.DataVisualization.Charting
#endif
{

#if WINFORMS_CONTROL

    /// <summary>
    /// Image string editor class.
    /// </summary>
    internal class ImageValueEditor : FileNameEditor
    {
        #region Editor method and properties

        /// <summary>
        /// Override this function to support palette colors drawing
        /// </summary>
        /// <param name="context">Descriptor context.</param>
        /// <returns>Can paint values.</returns>
        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        /// <summary>
        /// Override this function to support palette colors drawing
        /// </summary>
        /// <param name="e">Paint value event arguments.</param>
        public override void PaintValue(PaintValueEventArgs e)
        {
            try
            {
                if (e.Value is string)
                {
                    // Get image loader 
                    ImageLoader imageLoader = null;
                    if (e.Context != null && e.Context.Instance != null)
                    {
                        if (e.Context.Instance is Chart)
                        {
                            Chart chart = (Chart)e.Context.Instance;
                            imageLoader = (ImageLoader)chart.GetService(typeof(ImageLoader));
                        }
                        else if (e.Context.Instance is IChartElement)
                        {
                            IChartElement chartElement = (IChartElement)e.Context.Instance;
                            imageLoader = (ImageLoader)chartElement.Common.ImageLoader;
                        }
                    }

                    if (imageLoader != null && !string.IsNullOrEmpty((string)e.Value))
                    {
                        // Load a image
                        System.Drawing.Image image = imageLoader.LoadImage((string)e.Value);

                        // Draw Image
                        e.Graphics.DrawImage(image, e.Bounds);
                    }
                }
            }
            catch (ArgumentException)
            { }
        }
        #endregion
    }

#else

    /// <summary>
	/// Image Url editor class
	/// </summary>
	internal class ImageValueEditor : ImageUrlEditor
	{
    #region Editor methods

		/// <summary>
		/// Edit Image Url value. 
		/// Makes a base class call with a chart control descriptor context.
		/// </summary>
		/// <param name="context">Editing context.</param>
		/// <param name="provider">Provider.</param>
		/// <param name="value">Value to edit.</param>
		/// <returns>Result</returns>
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) 
		{
			// Use current control type descriptor context
			// This allows to use ImageUrlEditor class
			if(Chart.controlCurrentContext != null)
			{
				return base.EditValue(Chart.controlCurrentContext, provider, value);
			}

			return base.EditValue(context, provider, value);
		}

    #endregion
	}

    internal class ChartUrlEditor : UrlEditor
    {
    }
#endif //WINFORMS_CONTROL
}