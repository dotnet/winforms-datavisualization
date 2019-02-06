using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace System.Windows.Forms.DataVisualization.Charting.Utilities
{
    /// <summary>
    /// Handles all the RangePolygons logic, including but not limited to:
    /// 1)  Finding all the RangePolygons given two lines
    /// 2)  Setting \ Getting tooltips for a RangePolygon
    /// 3)  Performing a Hit test for the RangePolgyons
    /// 
    /// NOTE: A line that is qualified as TOP is a line that has
    /// the 'good' values.  A lline qualified as BOTTOM is a line with all the
    /// 'bad' values.
    /// </summary>
    public class RangeSpliceChartHelper
    {
        #region Fields
        /// <summary>
        /// All the RangePolygons for the two lines
        /// </summary>
        private List<RangePolygon> rPolygons;

        /// <summary>
        /// Tooltip for the BOTTOM RangePolygon
        /// </summary>
        private string bottomToolTip;

        /// <summary>
        /// Tooltip for the TOP RangePolygon
        /// </summary>
        private string topToolTip;

        /// <summary>
        /// RangePolygon Bottom Color
        /// </summary>
        private Color bottomColor;

        /// <summary>
        /// RangePolygon Top Color
        /// </summary>
        private Color topColor;

        /// <summary>
        /// The chart to draw on
        /// </summary>
        private Chart lineChart;

        //private System.Windows.Forms.ToolTip rpToolTip = new System.Windows.Forms.ToolTip();
        #endregion

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RangeSpliceChartHelper(Chart chart)
        {
            rPolygons = new List<RangePolygon>();
            bottomToolTip = "Line below";
            topToolTip = "Line Above";
            bottomColor = Color.Transparent;
            topColor = Color.Transparent;
            this.lineChart = chart;
        }
        
        #region Properties
        /// <summary>
        /// (READ ONLY) Get all the RangePolygons.  Mainly used for drawing them.
        /// </summary>
        public RangePolygon[] RangePolygons
        {
            get
            {
                return rPolygons.ToArray() ;
            }
        }

        /// <summary>
        /// Bottom Color Property: RangePolygon of type Bottom will be shaded
        /// this color
        /// </summary>
        public Color BottomColor
        {
            set
            {
                this.bottomColor = value;
            }
            get
            {
                return this.bottomColor;
            }
        }

        /// <summary>
        /// Top Color Property: RangePolygon of type Top will be shaded
        /// this color
        /// </summary>
        public Color TopColor
        {
            get
            {
                return this.topColor;
            }
            set
            {
                this.topColor = value;
            }
        }

        /// <summary>
        /// BOTTOM tool tip
        /// </summary>
        private string BottomToolTip
        {
            get
            {
                return this.bottomToolTip;
            }
            set
            {
                this.bottomToolTip = value;
            }
        }

        /// <summary>
        /// TOP tool tip
        /// </summary>
        private string TopToolTip
        {
            get
            {
                return this.topToolTip;
            }
            set
            {
                this.topToolTip = value;
            }
        }

        /// <summary>
        /// Enables or disables the control
        /// </summary>
        public bool Enabled
        {
            set
            {
                if (value)
                {
                    this.lineChart.PostPaint +=new EventHandler<ChartPaintEventArgs>(lineChart_PostPaint);
                    this.lineChart.Resize += new System.EventHandler(lineChart_Resize);
                    this.lineChart.MouseMove += new System.Windows.Forms.MouseEventHandler(lineChart_MouseMove);
                }
                else
                {
                    this.lineChart.PostPaint -= new EventHandler<ChartPaintEventArgs>(lineChart_PostPaint);
                    this.lineChart.Resize -= new System.EventHandler(lineChart_Resize);
                    this.lineChart.MouseMove -= new System.Windows.Forms.MouseEventHandler(lineChart_MouseMove);
                }
                this.lineChart.Invalidate();
            }
        }

        #endregion 

        #region Methods
        /// <summary>
        /// Gets all the RangePolygons between line1 and line2.
        /// </summary>
        /// <param name="cg">used for getting absolute values</param>
        /// <param name="line1">the line that has the 'good' values</param>
        /// <param name="line2">the line that has the 'bad' values </param>
        private void FillRangePolygons(ChartGraphics cg, Series line1, Series line2)
        {

            this.ClearRangePolygons();
            //System.Console.WriteLine("GetRangePolygons Start: " + DateTime.Now.Millisecond);
            DataPoint[] dpIntersections = LineUtils.GetAllIntersections(line1, line2);
            //ArrayList rPolygons = new ArrayList();

            if (dpIntersections != null)
            {
                switch (dpIntersections.Length)
                {
                    case 0:
                        //this is where tehre is no intersection
                        break;
                    case 1:
                        //this is the special case that there is only one intersection
                        RangePolygon sPolygon = GetStartPolygon(cg, line1, line2, dpIntersections[0], this.rPolygons.Count);

                        if (sPolygon != null)
                            rPolygons.Add(sPolygon);
                        RangePolygon ePolygon = GetEndPolygon(cg, line1, line2, dpIntersections[dpIntersections.Length - 1], this.rPolygons.Count);

                        if (ePolygon != null)
                            rPolygons.Add(ePolygon);

                        break;
                    default:

                        if (dpIntersections.Length >= 0)
                        {
                            RangePolygon startPolygon = GetStartPolygon(cg, line1, line2, dpIntersections[0], this.rPolygons.Count);

                            if (startPolygon != null)
                                rPolygons.Add(startPolygon);

                            for (int dpInterIndex = 0; dpInterIndex < dpIntersections.Length - 1; dpInterIndex++)
                            {
                                RangePolygon rp = GetPolygonOfIntersection(cg, line1,
                                    line2, dpIntersections[dpInterIndex], dpIntersections[dpInterIndex + 1], this.rPolygons.Count);
                                if (rp != null)
                                    rPolygons.Add(rp);
                            }

                            RangePolygon endPolygon = GetEndPolygon(cg, line1, line2, dpIntersections[dpIntersections.Length - 1], this.rPolygons.Count);

                            if (endPolygon != null)
                                rPolygons.Add(endPolygon);
                        }
                        else
                        {
                            break;
                        }
                        //System.Console.WriteLine("GetRangePolygons END: " + DateTime.Now.Millisecond);
                        break;
                }
            }
        }

        /// <summary>
        /// Clears all the RangePolygons.
        /// </summary>
        private void ClearRangePolygons()
        {
            foreach (RangePolygon rp in rPolygons)
            {
                rp.Dispose();
            }
            rPolygons.Clear();
        }

        /// <summary>
        /// Performs a hit test
        /// </summary>
        /// <param name="point">point to perform a hit test with</param>
        /// <returns>the polygonID, otherwise -1</returns>
        public int HitTest(PointF point)
        {
            foreach (RangePolygon rp in rPolygons)
            {
                if (rp.HitTest(point))
                    return rp.PolygonID;
            }

            return -1;
        }

        /// <summary>
        /// Gets the polygon that is the right most polygon.  
        /// A RangePolygon will only be created if line1 and line2 have the same final XValues
        /// </summary>
        /// <param name="cg">for finding the absolute coordinates</param>
        /// <param name="line1">line 1</param>
        /// <param name="line2">line 2</param>
        /// <param name="lastIntersection">last point of intersection</param>
        /// <param name="pID">id to give the new polygon</param>
        /// <returns>a RangePolygon, null otherwise</returns>
        private RangePolygon GetEndPolygon(ChartGraphics cg, Series line1,
                Series line2, DataPoint lastIntersection,int pID)
        {
            DataPoint line1X = line1.Points[line1.Points.Count - 1];
            DataPoint line2X = line2.Points[line2.Points.Count - 1];
            if (line1X.XValue == line2X.XValue)
            {
                return GetPolygonOfIntersection(cg, line1, line2, lastIntersection, line1X, pID);
            }
            return null;
        }

        /// <summary>
        /// Gets a RangePolygon between two intersecting points
        /// </summary>
        /// <param name="cg">for finding the absolute coordinates</param>
        /// <param name="line1">line 1</param>
        /// <param name="line2">line 2</param>
        /// <param name="startPoint">the first intersection point</param>
        /// <param name="endPoint">the second intersection point</param>
        /// <param name="polygonID">id for the new polygon</param>
        /// <returns>a RangePolygon, null otherwise</returns>
        private RangePolygon GetPolygonOfIntersection(ChartGraphics cg, Series line1, Series line2, DataPoint startPoint, DataPoint endPoint, int polygonID)
        {
            //System.Console.WriteLine("GetPolygonIntersection Start: " + DateTime.Now.Millisecond);
            Series tempLine1 = LineUtils.PointsInRange(startPoint,
                     endPoint, line1);


            Series tempLine2 = LineUtils.PointsInRange(startPoint,
                                endPoint, line2);

            if (tempLine1 == null || tempLine2 == null)
                return null;

            RangePolygon.RANGETYPE rType;
            Series topLine;
            Series bottomLine;

            if (tempLine1.Points.Count == 0)
            {
                tempLine1.Points.Add(startPoint);
                tempLine1.Points.Add(endPoint);
            }
            if (tempLine2.Points.Count == 0)
            {
                tempLine2.Points.Add(startPoint);
                tempLine2.Points.Add(endPoint);
            }
            if (LineUtils.IsAbove(tempLine1, tempLine2))
            {
                topLine = tempLine1;
                bottomLine = tempLine2;
                rType = RangePolygon.RANGETYPE.TOP;
            }
            else
            {
                rType = RangePolygon.RANGETYPE.BOTTOM;
                topLine = tempLine2;
                bottomLine = tempLine1;
            }

            List<PointF> points = new List<PointF>();

            points.Add(LineUtils.GetAbsolutePoint(cg, startPoint));

            foreach (DataPoint dp in topLine.Points)
            {
                points.Add(LineUtils.GetAbsolutePoint(cg, dp));
            }

            points.Add(LineUtils.GetAbsolutePoint(cg, endPoint));

            bottomLine.Sort(PointSortOrder.Descending, "X");
            foreach (DataPoint dp in bottomLine.Points)
            {
                points.Add(LineUtils.GetAbsolutePoint(cg, dp));
            }

            points.Add(LineUtils.GetAbsolutePoint(cg, startPoint));

            //System.Console.WriteLine("GetPolygonIntersection END: " + DateTime.Now.Millisecond);
            return new RangePolygon(points.ToArray(), rType, polygonID);
        }

        /// <summary>
        /// if line1 and line2 have the same initial X index, then create a polygon for it, else
        /// ignore it.
        /// </summary>
        /// <param name="cg">Chart Graphics finding the absolute coordinates</param>
        /// <param name="line1">line 1</param>
        /// <param name="line2">line 2</param>
        /// <returns>a RangePolygon if line1 and line2 have the same initial x index, else null</returns>
        private RangePolygon GetStartPolygon(ChartGraphics cg, Series line1,
            Series line2, DataPoint firstIntersection,int pID)
        {
            DataPoint line1X = line1.Points[0];
            DataPoint line2X = line2.Points[0];
            if (line1X.XValue == line2X.XValue)
            {
                return GetPolygonOfIntersection(cg, line1, line2, line1X, firstIntersection,pID);
            }
            return null;
        }


        /// <summary>
        /// Gets the RangePolygon that has polygonID as its ID
        /// </summary>
        /// <param name="polygonID">polygon ID</param>
        /// <returns>RangePolygon with polygonID</returns>
        private RangePolygon GetRangePolygon(int polygonID)
        {
            return rPolygons[polygonID];
        }

        /// <summary>
        /// Get the tool tip for a RangePolygon
        /// There are two types, BottomToolTip and TopToolTip
        /// A RangePolygon that is  BOTTOM RANGETYPE will return the BottomToolTip
        /// wherease a TOP RANGETYPE will return the TopToolTip
        /// </summary>
        /// <param name="polygonIndex">index of the polygon</param>
        /// <returns>see summary</returns>
        private string GetToolTip(int polygonIndex)
        {
            RangePolygon polygon = GetRangePolygon(polygonIndex);

            if (polygon.RangeType == RangePolygon.RANGETYPE.BOTTOM)
                return this.BottomToolTip;
            else
                return this.TopToolTip;
        }

        public void DrawPolygons(ChartGraphics cg, Series line1,
            Series line2)
        {
            FillRangePolygons(cg, line1, line2);

            //iterate through all the polygons and draw them
            for (int i = 0; i < RangePolygons.Length; i++)
            {
                //if the polygon is a BOTTOM range polygon than fill the color with transYellow
                //else fill with transBlue;
                if (RangePolygons[i].RangeType == System.Windows.Forms.DataVisualization.Charting.Utilities.RangePolygon.RANGETYPE.BOTTOM)

                    RangePolygons[i].FillColor = this.bottomColor;
                else
                    RangePolygons[i].FillColor = this.topColor;


                SolidBrush fillBrush = new SolidBrush(RangePolygons[i].FillColor);

                //do the actual drawing
                cg.Graphics.FillPolygon(fillBrush, RangePolygons[i].PolygonPoints);
            }
        }

        #endregion

        #region EventHandlers
        /// <summary>
        /// This is used to show the tool tip for the polygon area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lineChart_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            //make sure the mouse has moved over a rangepolygon
            if (HitTest(e.Location) >= 0)
            {
                //make sure the tool tips for rangepolygons are active
                //if (rpToolTip.Active)
                //{
                //    Point show = e.Location;

                //    show.Y = show.Y - 20;

                //    //get the string associated with the range polygon
                //    rpToolTip.Show(GetToolTip(HitTest(e.Location)), this.lineChart, show, 1000);
                //}
            }
        }


        /// <summary>
        /// This insures that the range polygons are redrawn with the chart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lineChart_Resize(object sender, System.EventArgs e)
        {

            this.lineChart.Invalidate();
        }

        private void lineChart_PostPaint(object sender, ChartPaintEventArgs e)
        {
            if (lineChart.Series.Count < 2)

                throw new RangeSpliceChartHelperException("Not enough series (need at least two)");

            if(lineChart.Series[0].ChartType != SeriesChartType.Line)
                throw new RangeSpliceChartHelperException("Series[0] is not a line! (Series[0], the Top Line, needs to be a line)");

            if (lineChart.Series[1].ChartType != SeriesChartType.Line)
                throw new RangeSpliceChartHelperException("Series[1] is not a line! (Series[1], the Bottom Line, needs to be a line)");
            this.DrawPolygons(e.ChartGraphics, lineChart.Series[0], lineChart.Series[1]);
        }

        #endregion

    }

    class RangeSpliceChartHelperException : System.Exception
    {
        public RangeSpliceChartHelperException(string msg)
            : base(msg)
        { }
    }
}
