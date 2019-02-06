// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	Design-time marker style editor class. 
//


using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms.DataVisualization.Charting;

namespace System.Windows.Forms.Design.DataVisualization.Charting
{


    /// <summary>
    /// AxisName editor for the marker style.
    /// Paints a rectangle with marker sample.
    /// </summary>
    internal class MarkerStyleEditor : UITypeEditor, IDisposable
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
        [SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily",
            Justification = "Too large of a code change to justify making this change")]
		public override void PaintValue(PaintValueEventArgs e)
		{
			if(e.Value is MarkerStyle)
			{
				// Create chart graphics object
				if(_chartGraph == null)
				{
					_chartGraph = new ChartGraphics(null);
				}
				_chartGraph.Graphics = e.Graphics;

				// Get marker properties
				DataPointCustomProperties	attributes = null;
				if(e.Context != null && e.Context.Instance != null)
				{
					// Check if several object selected
					object	attrObject = e.Context.Instance;
					if(e.Context.Instance is Array)
					{
						Array	array = (Array)e.Context.Instance;
						if(array.Length > 0)
						{
							attrObject = array.GetValue(0);
						}
					}

					// Check what kind of object is selected
					if(attrObject is Series)
					{
						attributes = (DataPointCustomProperties)attrObject;
					}
					else if(attrObject is DataPoint)
					{
						attributes = (DataPointCustomProperties)attrObject;
					}
					else if(attrObject is DataPointCustomProperties)
					{
						attributes = (DataPointCustomProperties)attrObject;
					}
					else if(attrObject is LegendItem)
					{
						attributes = new DataPointCustomProperties();
						attributes.MarkerColor = ((LegendItem)attrObject).markerColor;
						attributes.MarkerBorderColor = ((LegendItem)attrObject).markerBorderColor;
						attributes.MarkerSize = ((LegendItem)attrObject).markerSize;
					}
				}

				// Draw marker sample
				if(attributes != null && (MarkerStyle)e.Value != MarkerStyle.None)
				{
					PointF	point = new PointF(e.Bounds.X + ((float)e.Bounds.Width)/2F - 0.5F, e.Bounds.Y + ((float)e.Bounds.Height)/2F - 0.5F);
					Color color = (attributes.MarkerColor == Color.Empty) ? Color.Black : attributes.MarkerColor;
					int size = attributes.MarkerSize;
					if(size > (e.Bounds.Height - 4))
					{
						size = e.Bounds.Height - 4;
					}
					_chartGraph.DrawMarkerAbs(
						point, 
						(MarkerStyle)e.Value, 
						size, 
						color, 
						attributes.MarkerBorderColor, 
						attributes.MarkerBorderWidth,
						"", 
						Color.Empty, 
						0, 
						Color.Empty, 
						RectangleF.Empty, 
						true);
				}
			}
		}

		#endregion

        #region IDisposable Members

        /// <summary>
        /// Finalizer for the MarkerStyleEditor, disposes any remaining
        /// resources if it has not already been disposed.
        /// </summary>
        ~MarkerStyleEditor()
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
        /// Disposes all resources used by this object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }


}
