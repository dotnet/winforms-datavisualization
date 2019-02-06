using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using System.Drawing;

namespace System.Windows.Forms.DataVisualization.Charting.Utilities
{
    /// <summary>
    /// Set of methods used for analyzing two line series
    /// </summary>
    public class LineUtils
    {
        /// <summary>
        /// Checks to see if two lines intersect
        /// Line 1 is defined by series1_Point1 and series1_Point2
        /// Line 2 is defined by series2_Point1 and series2_Point2
        /// </summary>
        /// <param name="series1_Point1">line's start point for series 1</param>
        /// <param name="series1_Point2">line's end point for series 1</param>
        /// <param name="series2_Point1">line's start point for series 2</param>
        /// <param name="series2_Point2">line's end point for series 2</param>
        /// <returns>DataPoint of where the lines intersect, null otherwise</returns>
        public static DataPoint IsIntersect(DataPoint series1_Point1, DataPoint series1_Point2, DataPoint series2_Point1, DataPoint series2_Point2)
        {
            //find the slope of series 1's line
            double m1 = (series1_Point2.YValues[0] - series1_Point1.YValues[0])
                        /(series1_Point2.XValue - series1_Point1.XValue);

            //find the y intercept of series 1's line
            double b1 = series1_Point2.YValues[0] - m1 * series1_Point2.XValue;

            //find the slope of series 2's line
            double m2 = (series2_Point2.YValues[0] - series2_Point1.YValues[0])
                        / (series2_Point2.XValue - series2_Point1.XValue);

            //check to make sure the lines aren't parallel
            if (m2 == m1)
            {
                //the lines are parallel so they can not intersect
                return null;
            }

            // find the y intercept of series 2's line
            double b2 = series2_Point2.YValues[0] - m2 * series2_Point2.XValue;

            //find where the two lines intersect
            double xIntersection = (b2 - b1) / (m1 - m2);  
      
            //find the max and min X interval of the two line segments

            double xmin=0;
            double xmax=0;
            if (series1_Point1.XValue >= series2_Point1.XValue)
            {
                xmin = series1_Point1.XValue;
            }
            else
            {
                xmin = series2_Point1.XValue;
            }

            if (series1_Point2.XValue >= series2_Point2.XValue)
            {
                xmax = series2_Point2.XValue;
            }
            else
            {
                xmax = series1_Point2.XValue;
            }

            //check to see if the xIntersection falls in this range
            if (xIntersection >= xmin && xIntersection <= xmax)
            {
                //figure out the Y value now

                double yIntersection = m1 * xIntersection + b1;
                return new DataPoint(xIntersection, yIntersection);
            }
          
            return null;
        }

        /// <summary>
        /// Get all the Datapoints that the lines intersect.
        /// </summary>
        /// <param name="series1">line 1</param>
        /// <param name="series2">line 2</param>
        /// <returns>the collection of intersecting datapoints, null otherwise</returns>
        public static DataPoint[] GetAllIntersections(Series series1, Series series2)
        {
            List<DataPoint> intersections = new List<DataPoint>();
            for(int i=0;i<series1.Points.Count - 1;i++)
            {
                for(int j=0;j<series2.Points.Count - 1;j++)
                {
                    DataPoint intersection = LineUtils.IsIntersect(
                        series1.Points[i], series1.Points[i + 1],
                        series2.Points[j], series2.Points[j + 1]);

                    if (intersection != null)
                        intersections.Add(intersection);
                }
            }

            if (intersections.Count == 0)
                return null;
            return intersections.ToArray();
        }

        /// <summary>
        /// Returns a line of the inputLine between startPoint.X and endPoint.X)
        /// </summary>
        /// <param name="startPoint">start X value</param>
        /// <param name="endPoint">end X Value</param>
        /// <param name="series">input line</param>
        /// <returns>the filtered line</returns>
        public static Series PointsInRange(DataPoint startPoint, DataPoint endPoint,Series inputLine)
        {
            Series filteredSeries = new Series("Random");
            //programmatically filter
            for (int i = 0; i < inputLine.Points.Count; i++)
            { 
                DataPoint dp=inputLine.Points[i].Clone();
                if(dp.XValue >= startPoint.XValue && dp.XValue <= endPoint.XValue)
                    filteredSeries.Points.Add(dp);

                if(dp.XValue > endPoint.XValue)
                    break;
            }

            return filteredSeries;
        }

        /// <summary>
        /// Checks to see if line 1 is above line 2
        /// </summary>
        /// <param name="series1">line 1</param>
        /// <param name="series2">line 2</param>
        /// <returns>true if line 1 is above line 2, false otherwise</returns>
        public static bool IsAbove(Series series1, Series series2)
        {
            DataPoint maxValue1 = series1.Points.FindMaxByValue();
            DataPoint maxValue2 = series2.Points.FindMaxByValue();

            if (maxValue1.YValues[0] > maxValue2.YValues[0])
                return true;

            return false;
        }

        /// <summary>
        /// Get the absolute location of dp 
        /// </summary>
        /// <param name="cg">for finding the absolute location</param>
        /// <param name="dp"></param>
        /// <returns></returns>
        public static PointF GetAbsolutePoint(ChartGraphics cg, DataPoint dp)
        {
            PointF p1 = new PointF(
            (float)cg.GetPositionFromAxis("Default", AxisName.X, dp.XValue),
            (float)cg.GetPositionFromAxis("Default", AxisName.Y, dp.YValues[0]));
            p1 = cg.GetAbsolutePoint(p1);
            return p1;
        }
    }
}
