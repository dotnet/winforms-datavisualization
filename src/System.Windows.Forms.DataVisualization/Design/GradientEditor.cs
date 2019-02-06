// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	Design-time gradient editor class. 
//


using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;

namespace System.Windows.Forms.Design.DataVisualization.Charting
{


    /// <summary>
    /// AxisName editor for the gradient type.
    /// Paints a rectangle with gradient sample.
    /// </summary>
    internal class GradientEditor : UITypeEditor, IDisposable
	{
		#region Editor method and properties

		ChartGraphics	_chartGraph = null;
        private bool _disposed;

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
			if(e.Value is GradientStyle)
			{
				// Create chart graphics object
				if(_chartGraph == null)
				{
					_chartGraph = new ChartGraphics(null);
				}
				_chartGraph.Graphics = e.Graphics;

				// Try to get original color from the object
				Color	color1 = Color.Black;
				Color	color2 = Color.White;
				if(e.Context != null && e.Context.Instance != null)
				{
					// Get color properties using reflection
					PropertyInfo	propertyInfo = e.Context.Instance.GetType().GetProperty("BackColor");
					if(propertyInfo != null)
					{
						color1 = (Color)propertyInfo.GetValue(e.Context.Instance, null);
					}
					else
					{
						propertyInfo = e.Context.Instance.GetType().GetProperty("BackColor");
						if(propertyInfo != null)
						{
							color1 = (Color)propertyInfo.GetValue(e.Context.Instance, null);
						}
						else
						{
							// If object do not have "BackColor" property try using "Color" property 
							propertyInfo = e.Context.Instance.GetType().GetProperty("Color");
							if(propertyInfo != null)
							{
								color1 = (Color)propertyInfo.GetValue(e.Context.Instance, null);
							}
						}
					}
					
					propertyInfo = e.Context.Instance.GetType().GetProperty("BackSecondaryColor");
					if(propertyInfo != null)
					{
						color2 = (Color)propertyInfo.GetValue(e.Context.Instance, null);
					}
					else
					{
						propertyInfo = e.Context.Instance.GetType().GetProperty("BackSecondaryColor");
						if(propertyInfo != null)
						{
							color2 = (Color)propertyInfo.GetValue(e.Context.Instance, null);
						}
					}

				}

				// Check if colors are valid
				if(color1 == Color.Empty)
				{
					color1 = Color.Black;
				}
				if(color2 == Color.Empty)
				{
					color2 = Color.White;
				}
				if(color1 == color2)
				{
					color2 = Color.FromArgb(color1.B, color1.R, color1.G);
				}


				// Draw gradient sample
				if((GradientStyle)e.Value != GradientStyle.None)
				{
					Brush brush = _chartGraph.GetGradientBrush( e.Bounds, color1, color2, (GradientStyle)e.Value);
					e.Graphics.FillRectangle( brush, e.Bounds);

					brush.Dispose();
				}
			}
		}
	
		#endregion

        #region IDisposable Members

        /// <summary>
        /// Finalizer for the GradientEditor, disposes any remaining
        /// resources if it has not already been disposed.
        /// </summary>
        ~GradientEditor()
        {
            Dispose(false);
        }

        /// <summary>
        /// Disposes resources used by this object.
        /// </summary>
        /// <param name="disposing">Whether this method was called form Dispose() or the finalizer.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _chartGraph.Dispose();
                }

                _disposed = true;
            }
        }

        /// <summary>
        /// Disposes all resources used by this object.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }


}
