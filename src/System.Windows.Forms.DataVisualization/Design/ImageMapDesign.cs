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

using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Utilities;

namespace System.Windows.Forms.Design.DataVisualization.Charting
{

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

}
