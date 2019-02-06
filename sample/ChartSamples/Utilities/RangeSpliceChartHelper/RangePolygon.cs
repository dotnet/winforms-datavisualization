using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace System.Windows.Forms.DataVisualization.Charting.Utilities
{
    /// <summary>
    /// Class that represents the drawing area \ polygon of the Range in 
    /// between two lines. Implements IDisposable so the graphicsPath is
    /// disposed properly.  
    /// </summary>
    public class RangePolygon: IDisposable
    {
        #region Fields
        /// <summary>
        /// The Range Types
        /// </summary>
        public enum RANGETYPE { TOP, BOTTOM };

        /// <summary>
        /// points of the polygon: the start point must be the same as the end point
        /// </summary>
        private PointF[] polygonPoints;

        /// <summary>
        /// The range type
        /// </summary>
        private RANGETYPE rangeType;

        private System.Drawing.Drawing2D.GraphicsPath graphicsPath;
        /// <summary>
        /// The fill color.  
        /// By default the fill color is a transparent green if the rangeType is TOP
        /// or a transparent red if the rangeType is BOTTOM
        /// </summary>
        private Color fillColor;

        /// <summary>
        /// RangePolygon ID
        /// </summary>
        private int polygonID;

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="points">points of the polygon</param>
        /// <param name="rType">Range Type</param>
        public RangePolygon(PointF[] points, RANGETYPE rType,int id)
        {
            this.rangeType = rType;
            this.polygonPoints = points;
            if(rType == RANGETYPE.TOP)
            {
                fillColor=Color.FromArgb(15,0,255,0);
            }
            else
            {
                fillColor=Color.FromArgb(15,255,0,0);
            }
            this.polygonID = id;
            graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            graphicsPath.AddPolygon(polygonPoints);
        }

        #region Methods
        /// <summary>
        /// Performs a hit test on the polygon
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool HitTest(PointF point)
        {
            return graphicsPath.IsVisible(point);
        }
        #endregion

        #region Properties
        /// <summary>
        /// (READ ONLY) Range Type of the polygon, either TOP or BOTTOM 
        /// </summary>
        public RANGETYPE RangeType
        {
            get
            {
                return rangeType;
            }
        }

        /// <summary>
        /// (READ ONLY) The graphics path of the RangePolygon
        /// </summary>
        public System.Drawing.Drawing2D.GraphicsPath GraphicsPath
        {
            get
            {
                return this.graphicsPath;
            }
        }

        /// <summary>
        /// (READ ONLY)Points of the Polygon 
        /// </summary>
        public PointF[] PolygonPoints
        {
            get
            {
                return polygonPoints;
            }
        }

        /// <summary>
        /// (READ ONLY) polygon id
        /// </summary>
        public int PolygonID
        {
            get
            {
                return this.polygonID;
            }
        }


        /// <summary>
        /// Fill color of the polygon.
        /// By default, transparent green for TOP
        /// transparent red for BOTTOM
        /// </summary>
        public Color FillColor
        {
            get
            {
                return fillColor;
            }
            set
            {
                fillColor = value;
            }
        }
#endregion

        #region IDisposable Members

        /// <summary>
        /// Dispose the graphicsPath
        /// </summary>
        public virtual void Dispose()
        {
            this.graphicsPath.Dispose();
        }

        #endregion
    }
}
