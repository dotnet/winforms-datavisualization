//=================================================================
//  File:		ActivityLegend.cs
//
//  Namespace:	System.Windows.Forms.DataVisualization.Charting.Utilities
//
//	Classes:	ActivityLegend, AlternateLineColorsClass
//
//  Purpose:	To create a legend which highlights specific points
//              in a specified series.
//
//===================================================================
// Chart Control for .NET Framework
// Copyright © Microsoft Corporation, all rights reserved
//===================================================================

#region Using Statements
using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting; 
#endregion

namespace System.Windows.Forms.DataVisualization.Charting.Utilities
{
    #region Activity Legend Class
    /// <summary>
    /// ActivityLegend adds a legend which documents each point within specified series in a separate legend.
    /// For clarity, lines are drawn to each data point from the legend to the point.
    /// </summary>
    public class ActivityLegend
    {
        #region Private Members
        // The chart that contains the series and is to have this legend added to it
        private Chart myChart;

        // The actual series that are added to this class
        private Series[] mySeries;

        // An array to relate the index of CustomItems within the legend to the series added to this class
        private int[] mySeriesAssignment;

        // An array to relate the index of CustomItems within the legend to points within the Points collection
        private int[] myPointIndex;

        // An array which holds all the DateTimes associated with points if xvalue datetime/date is used
        private DateTime[] myDateArray;

        // Holds the overall index placement within the legendItemsCollection
        private int index;

        // Holds the number of series added to this class
        private int seriesCount;

        // Holds the left padding for when the dock is right-aligned
        private float myLeftPadding;

        // myLegend is used to hold the activity legend object
        private Legend myLegend;

        // myAlternateLineColors is used to hold the alternate line colors setting class
        private AlternateLineColorsClass myAlternateLineColors;

        // myLineThickness is used to hold the thickness of the lines drawn from the Legend to the DataPoints
        private int myLineThickness;

        // myCirclePointRadius holds the thickness of the circle used to mark each point
        private int myCirclePointRadius;

        // myCircleOutlineColor holds the color of the outline of the circle
        private Color myCircleOutlineColor;

        // myCircleOutlineThickness holds the thickness of the circle's outside line
        private int myCircleOutlineThickness;

        // myLegendDateFormat formats the output of a dateTime in the first column (if datetimes are used for
        // x-values)
        private string myLegendDateFormat;

        // myFirstCellFont holds the font used when drawing text in the first cell
        private Font myFirstCellFont;

        // mySecondCellFont holds the font used when drawing text in the second cell
        private Font mySecondCellFont;

        // myItemSpacing holds the amount of margin space at the top and bottom between items
        private int myItemSpacing;        

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the legend used for the Activities.
        /// </summary>
        /// <value>The legend.</value>
        public Legend Legend
        {
            get { return myLegend; }
            set { myLegend = value; }
        }

        /// <summary>
        /// Gets or sets the bottom margin used to pad space between legend items.
        /// </summary>
        public int ItemSpacing
        {
            get { return myItemSpacing; }
            set { myItemSpacing = value; }
        }

        /// <summary>
        /// Gets or sets the alternate line colors class. FirstColor property holds the value of all line colors
        /// if alternate lines are disabled.
        /// </summary>
        /// <value>The alternate line colors.</value>
        public AlternateLineColorsClass AlternateLineColors
        {
            get { return myAlternateLineColors; }
            set { myAlternateLineColors = value; }
        }

        /// <summary>
        /// Gets or sets the line thickness of the lines connecting the Legend to the DataPoint (in pt size).
        /// </summary>
        /// <value>The line thickness.</value>
        public int LineThickness
        {
            get { return myLineThickness; }
            set { myLineThickness = value; }
        }

        /// <summary>
        /// Gets or sets the radius of the circle used to mark each point (in pt size).
        /// </summary>
        /// <value>The point radius.</value>
        public int CirclePointRadius
        {
            get { return myCirclePointRadius; }
            set { myCirclePointRadius = value; }
        }


        /// <summary>
        /// Gets or sets the color of the circle outline. By default, it is the same color as the filled portion
        /// of the circle which is the color of the series.
        /// </summary>
        /// <value>The color of the circle outline.</value>
        public Color CircleOutlineColor
        {
            get { return myCircleOutlineColor; }
            set { myCircleOutlineColor = value; }
        }

        /// <summary>
        /// Gets or sets the circle outline thickness (in pt size).
        /// </summary>
        /// <value>The circle outline thickness.</value>
        public int CircleOutlineThickness
        {
            get { return myCircleOutlineThickness; }
            set { myCircleOutlineThickness = value; }
        }

        /// <summary>
        /// Gets or sets the legend date format. This is only applicable if your XValueType is Date or DateTime.
        /// </summary>
        /// <value>The legend date format.</value>
        public string LegendDateFormat
        {
            get { return myLegendDateFormat; }
            set { myLegendDateFormat = value; }
        }

        /// <summary>
        /// Gets or sets the first cell's font.
        /// </summary>
        /// <value>The first cell font.</value>
        public Font FirstCellFont
        {
            get { return myFirstCellFont; }
            set { myFirstCellFont = value; }
        }

        /// <summary>
        /// Gets or sets the second cell's font.
        /// </summary>
        /// <value>The second cell font.</value>
        public Font SecondCellFont
        {
            get { return mySecondCellFont; }
            set { mySecondCellFont = value; }
        } 
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="T:ActivityLegend"/> class.
        /// </summary>
        /// <param name="mainChart">The chart.</param>
        public ActivityLegend(Chart mainChart)
        {
            // Set up the event handler for chart
            SetUpEventHandler(mainChart);

            // Store the current chart in the private variable
            myChart = mainChart;

            // Reset the seriesCount
            seriesCount = 0;

            // Set line thickness to 1 by default
            myLineThickness = 1;

            // Set the point radius to 5 by default
            myCirclePointRadius = 5;

            // Default the circle outline thickness to 2
            myCircleOutlineThickness = 2;

            // Default the outline of the circle to silver
            myCircleOutlineColor = Color.Silver;

            // Set the default format string to a short date
            myLegendDateFormat = "Y";

            // Set the default fonts used for the cells
            myFirstCellFont = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Bold);
            mySecondCellFont = new System.Drawing.Font("Arial", 8);

            // Set the legend to some default properties
            myLegend = new Legend("ActivityLegend00");
            myLegend.Docking = Docking.Left;

            // Instatiate the AlternateLineColors class
            myAlternateLineColors = new AlternateLineColorsClass();
        } 
        #endregion

        #region Private Functions
        /// <summary>
        /// Sets the up the event handler for Chart's PostPaint event.
        /// </summary>
        /// <param name="mainChart">The chart.</param>
        private void SetUpEventHandler(Chart mainChart)
        {
            mainChart.PostPaint +=new EventHandler<ChartPaintEventArgs>(mainChart_PostPaint);
        }

        /// <summary>
        /// Bubble sorts the legend.
        /// </summary>
        private void bubbleSortLegend()
        {
            // Initialize x to the count of the customItems
            int x = myLegend.CustomItems.Count;

            // Create temporary variables
            LegendItem temp;
            int indexTemp;
            DateTime dateTemp;

            // Condition used for second bubble loop
            bool secondCondition = false;

            // Bubble sort
            for (int i = (x - 1); i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    // The condition is based on whether we're aligning to right or left of the chart
                    if ((myLegend.Docking == Docking.Right && myChart.ChartAreas[mySeries[mySeriesAssignment[j]].ChartArea].AxisX.IsReversed == false) || (myLegend.Docking == Docking.Left && myChart.ChartAreas[mySeries[mySeriesAssignment[j]].ChartArea].AxisX.IsReversed == true))
                    {
                        // If datearray is not empty, use it for comparison instead of the value
                        if (myDateArray == null)
                            secondCondition = (Convert.ToDouble(myLegend.CustomItems[j - 1].Cells[0].Text) > Convert.ToDouble(myLegend.CustomItems[j].Cells[0].Text));
                        else
                            secondCondition = (myDateArray[j - 1] > myDateArray[j]);
                    }
                    else
                    {
                        // If datearray is not empty, use it for comparison instead of the value
                        if (myDateArray == null)
                            secondCondition = (Convert.ToDouble(myLegend.CustomItems[j - 1].Cells[0].Text) < Convert.ToDouble(myLegend.CustomItems[j].Cells[0].Text));
                        else
                            secondCondition = (myDateArray[j - 1] < myDateArray[j]);
                    }

                    if (secondCondition)
                    {
                        // Swap the items
                        temp = myLegend.CustomItems[j - 1];
                        myLegend.CustomItems.Remove(temp);
                        myLegend.CustomItems.Insert(j, temp);

                        // Switch around the indices to reflect a placement change
                        myLegend.CustomItems[j - 1].Cells[1].Name = "ActivityItem" + Convert.ToString(j - 1);
                        myLegend.CustomItems[j].Cells[1].Name = "ActivityItem" + j.ToString();

                        // Move the pointIndex and seriesAssignment arrays to reflect the change
                        indexTemp = myPointIndex[j - 1];
                        myPointIndex[j - 1] = myPointIndex[j];
                        myPointIndex[j] = indexTemp;

                        indexTemp = mySeriesAssignment[j - 1];
                        mySeriesAssignment[j - 1] = mySeriesAssignment[j];
                        mySeriesAssignment[j] = indexTemp;

                        // Swap the DateArray if it's being used
                        if (myDateArray != null)
                        {
                            dateTemp = myDateArray[j - 1];
                            myDateArray[j - 1] = myDateArray[j];
                            myDateArray[j] = dateTemp;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Handles the PostPaint event of the mainChart control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs"/> instance containing the event data.</param>
        private void mainChart_PostPaint(object sender, ChartPaintEventArgs e)
        {
            // Check if the sender is a cell of the Legend
            if (sender is LegendCell)
            {
                // Get the LegendCell
                LegendCell legendCell = sender as LegendCell;				

                // Ensure it's one of the items created by this class
                if (legendCell.Name.IndexOf("ActivityItem")  > -1)
                {
                    // Get the index out of the cell's name
                    index = Convert.ToInt32(legendCell.Name.Substring(12));

                    // Set the line color
                    Color lineColor = myAlternateLineColors.FirstColor;

                    // Set the alternate line colors up if necessary
                    if (myAlternateLineColors.Enabled == true)
                    {
                        if (index % 2 != 0)
                            lineColor = myAlternateLineColors.SecondColor;
                    }

                    // Check if this series is using Indexed x values
                    bool isIndexed = (mySeries[mySeriesAssignment[index]].IsXValueIndexed == true);

                    // Get the AxisType for X and Y axes
                    AxisName myYAxisName;
                    if (mySeries[mySeriesAssignment[index]].YAxisType == AxisType.Primary)
                        myYAxisName = AxisName.Y;
                    else
                        myYAxisName = AxisName.Y2;

                    // The first point of the horizontal line is the end of the legend cell (left aligned),
                    // or beginning of legend cell (right aligned)
                    PointF firstPoint = new PointF();
                    if (myLegend.Docking == Docking.Right)
                    {
                        firstPoint.X = e.Position.X - myLeftPadding;
                        firstPoint.Y = e.Position.Y + (e.Position.Height / 2);
                    }
                    else
                    {
                        firstPoint.X = e.Position.X + e.ChartGraphics.GetRelativeSize((e.ChartGraphics.Graphics.MeasureString(legendCell.Text, mySecondCellFont))).Width + 1;
                        firstPoint.Y = e.Position.Y + (e.Position.Height / 2);
                    }

                    // The second point of the horizontal line is straight to the right of the first point, on
                    // top of the desired point
                    PointF secondPoint = new PointF();
                    if (isIndexed)
                        secondPoint.X = (float)e.ChartGraphics.GetPositionFromAxis(mySeries[mySeriesAssignment[index]].ChartArea, AxisName.X, myPointIndex[index] + 1);
                    else
                        secondPoint.X = (float)e.ChartGraphics.GetPositionFromAxis(mySeries[mySeriesAssignment[index]].ChartArea, AxisName.X, mySeries[mySeriesAssignment[index]].Points[myPointIndex[index]].XValue);
                    secondPoint.Y = firstPoint.Y;

                    // Convert first and second point of horizontal line to absolute co-ordinates
                    firstPoint = e.ChartGraphics.GetAbsolutePoint(firstPoint);
                    secondPoint = e.ChartGraphics.GetAbsolutePoint(secondPoint);

                    // Draw the first line
                    e.ChartGraphics.Graphics.DrawLine(new Pen(lineColor, myLineThickness), firstPoint, secondPoint);

                    // The first point of the vertical line is the second point of the horizontal line.
                    // The second point of the vertical line is the datapoint itself
                    PointF thirdPoint = new PointF();
                    if (isIndexed)
                        thirdPoint.X = (float)e.ChartGraphics.GetPositionFromAxis(mySeries[mySeriesAssignment[index]].ChartArea, AxisName.X, myPointIndex[index] + 1);
                    else
                        thirdPoint.X = (float)e.ChartGraphics.GetPositionFromAxis(mySeries[mySeriesAssignment[index]].ChartArea, AxisName.X, mySeries[mySeriesAssignment[index]].Points[myPointIndex[index]].XValue);
                    thirdPoint.Y = (float)e.ChartGraphics.GetPositionFromAxis(mySeries[mySeriesAssignment[index]].ChartArea, myYAxisName, mySeries[mySeriesAssignment[index]].Points[myPointIndex[index]].YValues[0]);

                    // Convert to the third point to absolute co-ordinates
                    thirdPoint = e.ChartGraphics.GetAbsolutePoint(thirdPoint);

                    // Draw the vertical line
                    e.ChartGraphics.Graphics.DrawLine(new Pen(lineColor, myLineThickness), secondPoint, thirdPoint);

                    // Fill the circle
                    Brush myFillBrush = new SolidBrush(mySeries[mySeriesAssignment[index]].Color);
                    e.ChartGraphics.Graphics.FillEllipse(myFillBrush, new RectangleF(thirdPoint.X - myCirclePointRadius, thirdPoint.Y - myCirclePointRadius, myCirclePointRadius * 2, myCirclePointRadius * 2));

                    // Draw the circle
                    e.ChartGraphics.Graphics.DrawEllipse(new Pen(myCircleOutlineColor, myCircleOutlineThickness), thirdPoint.X - myCirclePointRadius, thirdPoint.Y - myCirclePointRadius, myCirclePointRadius * 2, myCirclePointRadius * 2);
                }
                else if (legendCell.Name.IndexOf("ActivityLeftPadding") > -1)
                {
                    // Store the left cell's width incase the legend is right-docked
                    myLeftPadding = e.Position.Width;
                }
            }
        } 
        #endregion

        #region Public Functions
        /// <summary>
        /// Adds the activity legend to the Chart. This must be done before the PostPaint event if the add-on
        /// is to work correctly.
        /// </summary>
        public void AddActivityLegend()
        {
            // Reset the master index
            index = 0;

            // Determine the total number of points that will be processed
            int pointCount = 0;
            foreach (Series thisSeries in mySeries)
                pointCount += thisSeries.Points.Count;

            // Initiate the arrays with the maximum number of possible points
            mySeriesAssignment = new int[pointCount];
            myPointIndex = new int[pointCount];
            DataPoint[] myDataPoints = new DataPoint[pointCount];

            // Reset seriesIndex (used to determine which series is being processed)
            int seriesIndex = 0;
            foreach (Series thisSeries in mySeries)
            {
                // Add every point from top x to bottom x
                myChart.DataManipulator.Sort(PointSortOrder.Descending, "X", thisSeries);

                // Loop through all points in this series
                foreach (DataPoint dataPoint in thisSeries.Points)
                {
                    if ((dataPoint.IsEmpty != true) && dataPoint.LegendText !="")
                    {
                        // Disable the marker for this datapoint
                        dataPoint.MarkerSize = 0;

                        // Create a new legend row for this data point, assign xvalue as left column and legendText
                        // as right column
                        LegendItem legendRow = new LegendItem();
                        if (thisSeries.XValueType == ChartValueType.Date ||
                            thisSeries.XValueType == ChartValueType.DateTime ||
                            thisSeries.XValueType == ChartValueType.Time)
                        {
                            if (myDateArray == null)
                                myDateArray = new DateTime[pointCount];

                            legendRow.Cells.Add(LegendCellType.Text, System.DateTime.FromOADate(dataPoint.XValue).ToString(myLegendDateFormat), System.Drawing.ContentAlignment.MiddleLeft);
                            myDateArray[index] = System.DateTime.FromOADate(dataPoint.XValue);
                        }
                        else
                            legendRow.Cells.Add(LegendCellType.Text, dataPoint.XValue.ToString(), System.Drawing.ContentAlignment.MiddleLeft);
                        legendRow.Cells.Add(LegendCellType.Text, dataPoint.LegendText, System.Drawing.ContentAlignment.MiddleLeft);

                        // Modify the font of the columns and name the second column
                        legendRow.Cells[0].Font = myFirstCellFont;
                        legendRow.Cells[0].Name = "ActivityLeftPadding" + index.ToString();
                        legendRow.Cells[1].Font = mySecondCellFont;
                        legendRow.Cells[1].Name = "ActivityItem" + index.ToString();

                        // Set margins
                        legendRow.Cells[0].Margins = new Margins(myItemSpacing, myItemSpacing, 15, 15);
                        legendRow.Cells[1].Margins = new Margins(myItemSpacing, myItemSpacing, 15, 15);

                        // Assign the current indices to the arrays for storage
                        mySeriesAssignment[index] = seriesIndex;
                        myDataPoints[index] = dataPoint;

                        // Add the item
                        myLegend.CustomItems.Add(legendRow);

                        // Increment the index
                        index++;
                    }
                }

                // Restore the order of points
                myChart.DataManipulator.Sort(PointSortOrder.Ascending, "X", thisSeries);

                // Assign all the indices to PointIndex array after this final sort
                for (int i = 0; i < index; i++)
                {
                    myPointIndex[i] = mySeries[mySeriesAssignment[i]].Points.IndexOf(myDataPoints[i]);
                }

                // Increment the series index, which indicates which series is being processed
                seriesIndex++;
            }

            // Sort all the legend cell items by X-value (the first column)
            bubbleSortLegend();

            // Reset index
            index = 0;

            // Add the new legend
            myChart.Legends.Add(myLegend);
        }

        /// <summary>
        /// Adds a series to the collection.
        /// </summary>
        /// <param name="series">The series.</param>
        public void AddSeries(Series series)
        {
            // Ensure this series is not using the secondary X-axis
            if (series.XAxisType == AxisType.Secondary)
                throw new ArgumentException("Secondary X-Axis is not supported by this add-on");

            // Create a new temporary array with the new allotted space
            Series[] newMySeries = new Series[seriesCount + 1];

            // If the old array isn't empty, copy it into the new one
            if (mySeries != null)
                Array.Copy(mySeries, newMySeries, seriesCount);

            // Set the last item to the series being added and increment the seriesCount
            newMySeries[seriesCount] = series;
            seriesCount++;

            // Save the newly created series into the old one
            mySeries = newMySeries;
        }

        /// <summary>
        /// Clears the series out of the collection.
        /// </summary>
        public void ClearSeries()
        {
            // Set the series array to null
            mySeries = null;
        }

        /// <summary>
        /// Removes the event handler.
        /// </summary>
        public void RemoveEventHandler()
        {
            myChart.PostPaint -= new EventHandler<ChartPaintEventArgs>(mainChart_PostPaint); 
               // new PaintEventHandler(mainChart_PostPaint);
        }
        #endregion
    }  
    #endregion

    #region Alternate Line Colors Class
    /// <summary>
    /// This class is used by ActivityLegend to hold the settings for the alternate line colors.
    /// </summary>
    public class AlternateLineColorsClass
    {
        #region Private Members
        private bool myEnabled;
        private Color myFirstColor;
        private Color mySecondColor; 
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:AlternateLineColorsClass"/> is enabled.
        /// </summary>
        /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
        public bool Enabled
        {
            get { return myEnabled; }
            set { myEnabled = value; }
        }

        /// <summary>
        /// Gets or sets the color of the second line.
        /// </summary>
        /// <value>The color of the second.</value>
        public Color SecondColor
        {
            get { return mySecondColor; }
            set { mySecondColor = value; }
        }

        /// <summary>
        /// Gets or sets the color of the first line.
        /// </summary>
        /// <value>The color of the first.</value>
        public Color FirstColor
        {
            get { return myFirstColor; }
            set { myFirstColor = value; }
        } 
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="T:AlternateLineColorsClass"/> class.
        /// </summary>
        public AlternateLineColorsClass()
        {
            // Set some default settings
            myEnabled = true;
            myFirstColor = Color.FromArgb(115, Color.Black);
            mySecondColor = Color.FromArgb(115, Color.Green);
        } 
        #endregion
    } 
    #endregion
}
