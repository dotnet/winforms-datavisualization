using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;

namespace System.Windows.Forms.DataVisualization.Charting.Utilities
{
	/// <summary>
    /// ChartDataTableHelper is a utility that includes functions to render a table that displays
    /// data that is present on the chart.  This utility mainly focuses on how to add a data table 
    /// to your chart to view all of its points. 
	/// </summary>
	public class ChartDataTableHelper
	{
		#region Members
		protected System.Windows.Forms.DataVisualization.Charting.Chart ChartObj = null;
		protected ArrayList ChartAreas = null;
		protected bool AddTableTotals = false;
		protected System.Drawing.Color tableColor = Color.White;
		protected System.Drawing.Color borderColor = Color.Black;
		protected bool enabled = true;
		protected bool Initialized = false;

		#endregion

		#region Properies

		/// <summary>
		/// Enables or Disables the painting of the Data Table.
		/// </summary>
		public bool Enabled
		{
			get
			{
				return Enabled;
			}
			set
			{
				enabled = value;
			}
		}

		/// <summary>
		/// Sets or gets the Chart object.
		/// </summary>
		public System.Windows.Forms.DataVisualization.Charting.Chart Chart
		{
			get
			{
				return ChartObj;
			}
			set
			{
				ChartObj = value;
			}
		}


		/// <summary>
		/// Sets or gets the Table Color that will be painted.
		/// </summary>
		public System.Drawing.Color TableColor
		{
			get
			{
				return tableColor;
			}
			set
			{
				tableColor = value;
			}
		}

		/// <summary>
		/// Sets or gets the Table Border Color that will be painted.
		/// </summary>
		public System.Drawing.Color BorderColor
		{
			get
			{
				return borderColor;
			}
			set
			{
				borderColor = value;
			}
		}

		#endregion

		#region Constructors
		/// <summary>
		/// Construct a ChartDataTableHelper instance.
		/// </summary>
		public ChartDataTableHelper()
		{
			ChartObj = null;
			ChartAreas = new ArrayList();
		}

		/// <summary>
		/// Construct a ChartDataTableHelper instance and Initialize all ChartAreas with a table.
		/// </summary>
		public ChartDataTableHelper(System.Windows.Forms.DataVisualization.Charting.Chart chartObj)
		{
			ChartAreas = new ArrayList();
			Initialize(chartObj);
		}


		/// <summary>
		/// Construct a ChartDataTableHelper instance and Initialize the specified ChartArea with a table.
		/// </summary>
		public ChartDataTableHelper(System.Windows.Forms.DataVisualization.Charting.Chart chartObj, string chartAreaName)
		{
			ChartAreas = new ArrayList();
			Initialize(chartObj, chartAreaName);

		}

		/// <summary>
		/// Construct a ChartDataTableHelper instance, Initialize the specified ChartArea with a table and
		/// set a boolean to show or hide total columns.
		/// </summary>
		public ChartDataTableHelper(System.Windows.Forms.DataVisualization.Charting.Chart chartObj, string chartAreaName, bool addTableTotals)
		{
			ChartAreas = new ArrayList();
			Initialize(chartObj, chartAreaName, addTableTotals);

		}

		#endregion 

		#region Initialization Methods
		/// <summary>
		/// Initialize all ChartAreas with a table.
		/// </summary>
		public void Initialize(System.Windows.Forms.DataVisualization.Charting.Chart chartObj)
		{
			ChartObj = chartObj;

			foreach(ChartArea area in ChartObj.ChartAreas)
			{
				AddDataTable(area.Name);
			}

            if (!Initialized)
                ChartObj.PostPaint += new EventHandler<ChartPaintEventArgs>(Chart_PostPaint);
		
			Initialized = true;
		}



		/// <summary>
		/// Initialize all ChartAreas with a table and
		/// set a boolean to show or hide total columns.
		/// </summary>
		public void Initialize(System.Windows.Forms.DataVisualization.Charting.Chart chartObj, bool addTableTotals)
		{
			AddTableTotals = addTableTotals;
			Initialize(chartObj);
		}

		/// <summary>
		/// Initialize the specified ChartArea with a table.
		/// </summary>
		public void Initialize(System.Windows.Forms.DataVisualization.Charting.Chart chartObj, string chartAreaName)
		{
			ChartObj = chartObj;
			
			AddDataTable(chartAreaName);

			if(!Initialized)
				ChartObj.PostPaint +=new EventHandler<ChartPaintEventArgs>(Chart_PostPaint);
		
			Initialized = true;
		}

		/// <summary>
		/// Initialize the specified ChartArea with a table and
		/// set a boolean to show or hide total columns.
		/// </summary>
		public void Initialize(System.Windows.Forms.DataVisualization.Charting.Chart chartObj, string chartAreaName, bool addTableTotals)
		{
			ChartObj = chartObj;
			AddTableTotals = addTableTotals;
			
			AddDataTable(chartAreaName);

			if(!Initialized)
				ChartObj.PostPaint +=new EventHandler<ChartPaintEventArgs>(Chart_PostPaint);
		
			Initialized = true;
		}

		/// <summary>
		/// Initialize the specified ChartArea with a table.
		/// </summary>
		public void AddDataTable(string chartAreaName)
		{
			if(ChartObj == null || ChartAreas.IndexOf(chartAreaName) >= 0)
				return;

			// add this chart area to the list of chart areas that need to 
			// have a data table attached
			ChartAreas.Add(chartAreaName);

			int Row = 0;


			if(AddTableTotals)
			{
				// create a dummy series that will not be shown but is used for 
				// showing the totals in the data table
				ChartObj.Series.Add("DUMMY");
				ChartObj.Series["DUMMY"].ChartArea = chartAreaName;
				ChartObj.Series["DUMMY"].Enabled = false;
				ChartObj.Series["DUMMY"].Color = Color.Gainsboro;
			}


			// for each of the series that are attached to this 
			// named chart area, create a custom axis label.
			// All tables lines will be drawn on a paint event.
			// ****************************************************
			// NOTE: ALL SERIES MUST HAVE THE SAME NUMBER OF POINTS!
			// ****************************************************
			foreach(Series ser in ChartObj.Series)
			{
				if(chartAreaName == ser.ChartArea)
				{
					if(AddTableTotals)
					{
						// shadows must be turned off otherwise
						// they will still show up for the transparent points
						ser.ShadowOffset = 0;

						// adjust the series values to ensure they are not
						// indexed and they are sorted... plus adding each point
						// to make the dummy series data 
						AdjustXValues(ser);
					}


					Row++;
					double From = 0.0;
					double To = 0.0;
					bool firstPoint = true;

					double YValueTotal = 0;

					foreach(DataPoint dp in ser.Points)
					{
						if(AddTableTotals)
							YValueTotal += dp.YValues[0];

						if(firstPoint && dp.XValue == 0)
							From = 0.5;
						else if(firstPoint)
							From = dp.XValue - 0.5;

						if(firstPoint)
						{
							ChartObj.ChartAreas[chartAreaName].AxisX.Minimum = From;
							ChartObj.ChartAreas[chartAreaName].AxisX.MajorGrid.Interval = 1;
							ChartObj.ChartAreas[chartAreaName].AxisX.MajorTickMark.Interval = 1;
							ChartObj.ChartAreas[chartAreaName].AxisX.LabelStyle.Interval = 1;
							ChartObj.ChartAreas[chartAreaName].AxisX.MajorGrid.IntervalOffset = 0.5;
							ChartObj.ChartAreas[chartAreaName].AxisX.MajorTickMark.IntervalOffset = 0.5;
							ChartObj.ChartAreas[chartAreaName].AxisX.LabelStyle.IntervalOffset = 0.5;
						
							ChartObj.ChartAreas[chartAreaName].CursorX.IntervalOffset = 0.5;
						}

						To = From + 1;

						ChartObj.ChartAreas[chartAreaName].AxisX.CustomLabels.Add(
							From, To, 
							" ",     // space used as a placeholder
							Row, LabelMarkStyle.None, GridTickTypes.None
							);

						firstPoint = false;
						From += 1;
					}

					if(AddTableTotals)
						ser.Points[ser.Points.Count-1].YValues[0] = YValueTotal;
					
					ChartObj.ChartAreas[chartAreaName].AxisX.Maximum = To;

				}
			}

			if(AddTableTotals)
				AdjustYMaximum(chartAreaName);

		}

		/// <summary>
		/// With the addition of Totals, the chart will try to set the maximum
		/// values according to these totals.  This will cause some series to be
		/// barely visible.  Since the points are transparent this is a poor behavior.
		/// This method will find and explicitly set the YAxis maximum to something
		/// a little more with the user expectations.
		/// </summary>
		private void AdjustYMaximum(string chartAreaName)
		{
			double MaxYValue = 0;

			// find the max YValue from all points in all series
			foreach(Series ser in ChartObj.Series)
			{
				if(chartAreaName == ser.ChartArea && ser.Enabled)
				{
					// check agains all points except the last point
					// which is the totals column
					for(int index = 0; index < ser.Points.Count-1; index++)
					{
						DataPoint pt = ser.Points[index];
						if(pt.YValues[0] > MaxYValue)
							MaxYValue = pt.YValues[0];
					}		
				}
			}

			double LogValue = (int)(Math.Log10(MaxYValue)) + 1;
			double NewMaxYValue = Math.Pow(10, LogValue);
			double ratio = MaxYValue / NewMaxYValue;
			double divisor = 1;

			if(ratio <= 0.1)
				divisor = 10;
			else if(ratio < 0.2)
				divisor = 5;
			else if(ratio < 0.25)
				divisor = 4;
			else if(ratio < 0.4)
				divisor = 2.5;
			else if(ratio < 0.5)
				divisor = 2;
			else if(ratio < 0.8)
				divisor = 1.25;

			ChartObj.ChartAreas[chartAreaName].AxisY.Maximum = NewMaxYValue / divisor;
			ChartObj.ChartAreas[chartAreaName].AxisY.RoundAxisValues();

		}


		/// <summary>
		/// A cleanup method that ensures the XValues are sorted accordingly and set explicitly.  
		/// It will also create the totals for the DUMMY series.
		/// </summary>
		private void AdjustXValues(System.Windows.Forms.DataVisualization.Charting.Series series)
		{
			bool AddDummyPoints = true;

			if(series.Name == "DUMMY")
				return;
			else if(ChartObj.Series["DUMMY"].Points.Count > 0)
				AddDummyPoints = false;

			// sort the series
			series.Sort(PointSortOrder.Ascending, "X");

			bool IsIndexed = false;

			if(series.IsXValueIndexed)
				IsIndexed = true;
			else
			{
				bool IsFirstPoint = true;
				bool IsLastPointZero = false;

				// the series X values must be set and greater than zero
				foreach(DataPoint pt in series.Points)
				{
					if(pt.XValue == 0 && !IsFirstPoint && IsLastPointZero)
					{
						IsIndexed = true;
						break;
					}
					else if (pt.XValue == 0 && IsFirstPoint)
						IsLastPointZero = true;

					IsFirstPoint = false;
				}
			}

			if(IsIndexed)
			{
				series.IsXValueIndexed = false;
				int XValue = 0;
				
				foreach(DataPoint pt in series.Points)
					pt.XValue = ++XValue;
			}

			series.Points.AddXY(series.Points[series.Points.Count-1].XValue + 1, 0);
			series.Points[series.Points.Count-1].AxisLabel = "Total";
			series.Points[series.Points.Count-1].Color = Color.Transparent;
			series.Points[series.Points.Count-1].BorderColor = Color.Transparent;

			int index = 0;
			foreach(DataPoint pt in series.Points)
			{
				if(AddDummyPoints)
				{
					ChartObj.Series["DUMMY"].Points.AddXY(pt.XValue, pt.YValues[0]);
				}
				else
				{
					ChartObj.Series["DUMMY"].Points[index].YValues[0] += pt.YValues[0];
				}

				index++;
			}
		}


		#endregion 

		#region Remove Table 

		public void RemoveDataTable(string chartAreaName)
		{
			if(ChartObj.ChartAreas.IndexOf(chartAreaName) >= 0)
				ChartObj.ChartAreas[chartAreaName].AxisX.CustomLabels.Clear();

			if(ChartAreas.IndexOf(chartAreaName) >= 0)
			{
				ChartAreas.RemoveAt(ChartAreas.IndexOf(chartAreaName));
			}
		}

		#endregion

		#region Paint Event Handling

		/// <summary>
		/// Chart Paint event handler.
		/// </summary>
		private void Chart_PostPaint(object sender, System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e)
		{
            if( e.ChartElement is ChartArea )
			{
                ChartArea area = (ChartArea)e.ChartElement;
				// call the paint method.
				if(ChartAreas.IndexOf(area.Name) >= 0 && enabled)
				{
					PaintDataTable(e);
				}
			}
		
		}	

		/// <summary>
		/// This method does all the work for the painting of the data table.
		/// </summary>
		private void PaintDataTable(System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e)
		{
			ChartArea area = (ChartArea) e.ChartElement; 

			// get the rect of the chart area
			RectangleF rect = e.ChartGraphics.GetAbsoluteRectangle( area.Position.ToRectangleF() );

			// get the inner plot position
			ElementPosition elemPos = area.InnerPlotPosition;
			
			// find the coordinates of the inner plot position
			float x = rect.X + (rect.Width / 100 * elemPos.X);
			float y = rect.Y + (rect.Height / 100 * elemPos.Y);
			float ChartAreaBottomY = rect.Y + rect.Height;
			
			// offset the bottom by the width+1 of the scrollbar if it is visible
			if(area.AxisX.ScrollBar.IsVisible && !area.AxisX.ScrollBar.IsPositionedInside)
				ChartAreaBottomY -= ((float)area.AxisX.ScrollBar.Size+1);

			float width = (rect.Width / 100 * elemPos.Width);
			float height = (rect.Height / 100 * elemPos.Height);

			// find the height of the font that will be used
			Font axisFont = area.AxisX.LabelStyle.Font;
			string testString = "ForFontHeight";
			SizeF axisFontSize = e.ChartGraphics.Graphics.MeasureString(testString, axisFont);

			// find the height of the font that will be used
			Font titleFont = area.AxisX.TitleFont;
			testString = area.AxisX.Title;
            SizeF titleFontSize = e.ChartGraphics.Graphics.MeasureString(testString, titleFont);

			int seriesCount = 0;

			// for each series that is attached to the chart area,
			// draw some boxes around the labels in the color provided
			for(int i = e.Chart.Series.Count-1; i >= 0; i--)
			{
				if(area.Name == e.Chart.Series[i].ChartArea)
				{
					seriesCount++;
				}
			}

			// now, if a box was actually drawn, then draw 
			// the verticle lines to separate the columns of the table.
			if(seriesCount > 0)
			{
				for(int i = 0; i < e.Chart.Series.Count; i++)
				{
					if(area.Name == e.Chart.Series[i].ChartArea)
					{
						double min = area.AxisX.Minimum;
						double max = area.AxisX.Maximum;

						// modify the min value for the current axis view
						if(area.AxisX.ScaleView.Position-1 > min)
							min = area.AxisX.ScaleView.Position-1;

						// modify the max value for the currect axis view
						if( (area.AxisX.ScaleView.Position + area.AxisX.ScaleView.Size + 0.5) < max)
							max = area.AxisX.ScaleView.Position + area.AxisX.ScaleView.Size + 0.5;


						// find the starting point that will be display.
						// this is dependent on the current axis view.
						// this sample assumes the same number of points in each
						// series so always take from the zeroth series
						int pointIndex = 0;
						foreach(DataPoint pt in ChartObj.Series[0].Points)
						{
							if(pt.XValue > min)
								break;

							pointIndex++;
						}

						bool TableLegendDrawn = false;

						for(double AxisValue = min; AxisValue < max; AxisValue++)
						{
							float pixelX = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X,AxisValue);
							float nextPixelX = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X,AxisValue+1);
							float pixelY = ChartAreaBottomY - titleFontSize.Height - (seriesCount * axisFontSize.Height);

							PointF point1 = PointF.Empty;
							PointF point2 = PointF.Empty;

							// Set Maximum and minimum points
							point1.X = pixelX;
							point1.Y = 0;

							// Convert relative coordinates to absolute coordinates.
							point1 = e.ChartGraphics.GetAbsolutePoint(point1);
							point2.X = point1.X;
							point2.Y = ChartAreaBottomY - titleFontSize.Height;
							point1.Y = pixelY;

							// Draw connection line
							e.ChartGraphics.Graphics.DrawLine(new Pen(borderColor), point1,point2);


							point2.X = nextPixelX;
							point2.Y = 0;
							point2 = e.ChartGraphics.GetAbsolutePoint(point2);

							StringFormat format = new StringFormat();
							format.Alignment = StringAlignment.Center;
							format.LineAlignment = StringAlignment.Center;

							// for each series draw one value in the column
							int row = 0;
							foreach(Series ser in ChartObj.Series)
							{
								if(area.Name == ser.ChartArea)
								{
									if(!TableLegendDrawn)
									{
										// draw the series color box 
										e.ChartGraphics.Graphics.FillRectangle(new SolidBrush(ser.Color), 
											x-10, row*(axisFont.Height)+(point1.Y), 10, axisFontSize.Height);

										e.ChartGraphics.Graphics.DrawRectangle(new Pen(borderColor), 
											x-10, row*(axisFont.Height)+(point1.Y), 10, axisFontSize.Height);

										e.ChartGraphics.Graphics.FillRectangle(new SolidBrush(tableColor),
											x, 
											row*(axisFont.Height)+(point1.Y),
											width, 
											axisFontSize.Height); 

										e.ChartGraphics.Graphics.DrawRectangle(new Pen(borderColor), 
											x, 
											row*(axisFont.Height)+(point1.Y),
											width, 
											axisFontSize.Height); 

									}
									
									if(pointIndex < ser.Points.Count)
									{
										string label = ser.Points[pointIndex].YValues[0].ToString();
										RectangleF textRect = new RectangleF(point1.X, row*(axisFont.Height)+(point1.Y+1), point2.X-point1.X, axisFont.Height);
										e.ChartGraphics.Graphics.DrawString(label, axisFont, new SolidBrush(area.AxisX.LabelStyle.ForeColor), textRect, format);
									}

									row++;

								}
							}

							TableLegendDrawn = true;
						
							pointIndex++;
						}

						// do this only once so break!
						break;
					}
				}
			}
		}


		#endregion


	}
}