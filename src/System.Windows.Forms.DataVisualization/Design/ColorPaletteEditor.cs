// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	Design-time UI editor for the ColorPalette and Color properties
//


using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Utilities;

namespace System.Windows.Forms.Design.DataVisualization.Charting
{
    /// <summary>
    /// AxisName editor for the palette properties.
    /// </summary>
    internal class ColorPaletteEditor : UITypeEditor
    {
        #region UI editor methods

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
            // Get palette colors array
            ChartColorPalette palette = (ChartColorPalette)e.Value;

            if (palette == ChartColorPalette.None)
            {
                base.PaintValue(e);
            }
            else
            {
                Color[] paletteColors = ChartPaletteColors.GetPaletteColors(palette);
                int numberOfcolors = paletteColors.Length;

                // Draw first colors of the palette
                if (numberOfcolors > 6)
                {
                    numberOfcolors = 6;
                }
                int colorStep = paletteColors.Length / numberOfcolors;
                RectangleF rect = e.Bounds;
                rect.Width = (float)(e.Bounds.Width) / (float)(numberOfcolors);
                for (int i = 0; i < numberOfcolors; i++)
                {
                    if (i == numberOfcolors - 1)
                    {
                        rect.Width = e.Bounds.Right - rect.X;
                    }
                    e.Graphics.FillRectangle(new SolidBrush(paletteColors[i * colorStep]), rect);
                    rect.X = rect.Right;
                    rect.Width = ((float)(e.Bounds.Width) / (float)(numberOfcolors));
                }
            }
        }

        #endregion
    }

    /// <summary>
    /// This class merely subclasses System.Drawing.Design.ColorEditor and nothing more.
    /// This is done so that in the runtime assembly, we refer to this class via an AssemblyQualifiedName
    /// instead of the system ColorEditor. This avoids placing version info in the runtime assembly, allowing
    /// is to build (theoretically) against any version of the system ColorEditor.
    /// </summary>
    internal class ChartColorEditor : ColorEditor
    {
        // left empty on purpose, see summary comment.
    }
}
