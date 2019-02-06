using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for ChartInDataPoint.
	/// </summary>
	public class ChartInDataPoint : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxChartType;
		private System.Windows.Forms.CheckBox checkBoxHideOriginalSeries;
		private System.Windows.Forms.ComboBox comboBoxOriginalChartType;
		private System.Windows.Forms.Label label3;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ChartInDataPoint()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "9,20");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "2,30");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "5,50");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "7,5");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "4,60");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "2,25");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "6,50");
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxHideOriginalSeries = new System.Windows.Forms.CheckBox();
            this.comboBoxOriginalChartType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to create a mini-chart for every point on the origin" +
                "al chart.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxHideOriginalSeries);
            this.panel1.Controls.Add(this.comboBoxOriginalChartType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxChartType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(432, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // checkBoxHideOriginalSeries
            // 
            this.checkBoxHideOriginalSeries.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxHideOriginalSeries.Location = new System.Drawing.Point(15, 72);
            this.checkBoxHideOriginalSeries.Name = "checkBoxHideOriginalSeries";
            this.checkBoxHideOriginalSeries.Size = new System.Drawing.Size(168, 24);
            this.checkBoxHideOriginalSeries.TabIndex = 4;
            this.checkBoxHideOriginalSeries.Text = "&Hide Original Series:";
            this.checkBoxHideOriginalSeries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxHideOriginalSeries.CheckedChanged += new System.EventHandler(this.checkBoxHideOriginalSeries_CheckedChanged);
            // 
            // comboBoxOriginalChartType
            // 
            this.comboBoxOriginalChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOriginalChartType.Items.AddRange(new object[] {
            "Point",
            "Bubble"});
            this.comboBoxOriginalChartType.Location = new System.Drawing.Point(168, 40);
            this.comboBoxOriginalChartType.Name = "comboBoxOriginalChartType";
            this.comboBoxOriginalChartType.Size = new System.Drawing.Size(120, 22);
            this.comboBoxOriginalChartType.TabIndex = 3;
            this.comboBoxOriginalChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxOriginalChartType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Original Chart Type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType.Items.AddRange(new object[] {
            "None",
            "Column",
            "Pie",
            "Doughnut",
            "Area"});
            this.comboBoxChartType.Location = new System.Drawing.Point(168, 8);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(120, 22);
            this.comboBoxChartType.TabIndex = 1;
            this.comboBoxChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "In &Point Chart Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.Chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.Chart1.BorderlineWidth = 2;
            this.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(16, 60);
            this.Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "BubbleScaleMin=-60";
            series1.Legend = "Default";
            series1.MarkerSize = 22;
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.ShadowOffset = 2;
            series1.YValuesPerPoint = 2;
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 1;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Mini-Charts!";
            this.Chart1.Titles.Add(title1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(688, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "In this example, a separate chart area is created for each data point and then po" +
                "sitioned on top of the original data point.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChartInDataPoint
            // 
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChartInDataPoint";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.ChartInDataPoint_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void ChartInDataPoint_Load(object sender, System.EventArgs e)
		{
			comboBoxChartType.SelectedIndex = 0;
			comboBoxOriginalChartType.SelectedIndex = 0;
			// Redrawing chart cause recalculation of series elements positions
			Chart1.SaveImage( System.IO.Stream.Null, ChartImageFormat.Bmp);
			comboBoxChartType.SelectedIndex = 1;
		}

		private void checkBoxHideOriginalSeries_CheckedChanged(object sender, System.EventArgs e)
		{
			// Hide/Show original chart series
			if(checkBoxHideOriginalSeries.Checked)
			{
				Chart1.Series["Default"].Color = Color.Transparent;
				Chart1.Series["Default"].ShadowOffset = 0;
				Chart1.Series["Default"].BorderColor = Color.Transparent;
			}
			else
			{
				Chart1.Series["Default"].Color = Color.FromArgb(220, 65, 140, 240);
				Chart1.Series["Default"].ShadowOffset = 2;
				Chart1.Series["Default"].BorderColor = Color.FromArgb(180, 26, 59, 105);
			}
		}

		private void comboBoxOriginalChartType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Set original series chart type
			Chart1.Series["Default"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), comboBoxOriginalChartType.Text, true );

			comboBoxChartType_SelectedIndexChanged(this, new System.EventArgs());
		}

		private void comboBoxChartType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Remove extra series and chart areas
			while(Chart1.Series.Count > 1)
			{
				Chart1.Series.RemoveAt(1);
			}
			while(Chart1.ChartAreas.Count > 1)
			{
				Chart1.ChartAreas.RemoveAt(1);
			}

			// Check if chart in point should be shown
			if(comboBoxChartType.Text != "None")
			{
				// Create charts for each data point
				CreateChartInSeriesPoints(Chart1, Chart1.Series["Default"], comboBoxChartType.Text);

				checkBoxHideOriginalSeries.Enabled = true;
			}
			else
			{
				checkBoxHideOriginalSeries.Checked = false;
				checkBoxHideOriginalSeries.Enabled = false;
			}
		}

		/// <summary>
		/// Creates a mini-chart in the data points of the original Point or Bubble chart.
		/// </summary>
		/// <param name="chart">Chart object.</param>
		/// <param name="series">Original data series.</param>
		/// <param name="chartType">Mini-chart type.</param>
		public void CreateChartInSeriesPoints(Chart chart, Series series, string chartType)
		{
			//****************************************************
			//** Check if series uses X values or they all set
			//** to zeros (in this case use point index as X value)
			//****************************************************
			bool	zeroXValues = true;
			foreach(DataPoint point in series.Points)
			{
				if(point.XValue != 0.0)
				{
					zeroXValues = false;
					break;
				}
			}

			//****************************************************
			//** Calculate bubble scaling variables required to
			//** for the bubble size calculations.
			//****************************************************
			bool	bubbleChart = false;

			// Minimum/Maximum bubble size
			double	maxPossibleBubbleSize = 15F;
			double	minPossibleBubbleSize = 3F;
			float	maxBubleSize = 0f;
			float	minBubleSize = 0f;

			// Current min/max size of the bubble size
			double	minAll = double.MaxValue;
			double	maxAll = double.MinValue;

			// Bubble size difference value
			double	valueDiff = 0;
			double	valueScale = 1;

			// Check for the Bubble chart type
			if( series.ChartType == SeriesChartType.Bubble )
			{
				bubbleChart = true;

				// Check if custom attributes are set to specify scale
				if(series.IsCustomPropertySet("BubbleScaleMin"))
				{
					minAll = Math.Min(minAll, Double.Parse(series["BubbleScaleMin"]));
				}
				if(series.IsCustomPropertySet("BubbleScaleMax"))
				{
					maxAll = Math.Max(maxAll, Double.Parse(series["BubbleScaleMax"]));
				}

				// Calculate bubble scale
				double	minSer = double.MaxValue;
				double	maxSer = double.MinValue;
				foreach( Series ser in chart.Series )
				{
					if( ser.ChartType == SeriesChartType.Bubble && ser.ChartArea == series.ChartArea )
					{
						foreach(DataPoint point in ser.Points)
						{
							minSer = Math.Min(minSer, point.YValues[1]);
							maxSer = Math.Max(maxSer, point.YValues[1]);
						}
					}
				}
				if(minAll == double.MaxValue)
				{
					minAll = minSer;
				}
				if(maxAll == double.MinValue)
				{
					maxAll = maxSer;
				}

				// Calculate maximum bubble size
				SizeF areaSize = chart.ChartAreas[series.ChartArea].Position.Size;

				// Convert relative coordinates to absolute coordinates
				areaSize.Width = areaSize.Width * (chart.Width - 1) / 100F; 
				areaSize.Height = areaSize.Height * (chart.Height - 1) / 100F; 
				maxBubleSize = (float)(Math.Min(areaSize.Width, areaSize.Height) / (100.0/maxPossibleBubbleSize));
				minBubleSize = (float)(Math.Min(areaSize.Width, areaSize.Height) / (100.0/minPossibleBubbleSize));

				// Calculate scaling variables depending on the Min/Max values
				if(maxAll == minAll)
				{
					valueScale = 1;
					valueDiff = minAll - (maxBubleSize - minBubleSize)/2f;
				}
				else
				{
					valueScale = (maxBubleSize - minBubleSize) / (maxAll - minAll);
					valueDiff = minAll;
				}
			}


			//****************************************************
			//** Create chart area for each data point
			//****************************************************
			int	pointIndex = 0;
			Random	random = new Random();
			foreach(DataPoint point in series.Points)
			{
				//****************************************************
				//** Create chart area and set visual attributes
				//****************************************************
				ChartArea areaPoint = chart.ChartAreas.Add(series.Name + "_" + pointIndex.ToString());
				areaPoint.BackColor = Color.Transparent;
				areaPoint.BorderWidth = 0;
				areaPoint.AxisX.LineWidth = 0;
				areaPoint.AxisY.LineWidth = 0;
				areaPoint.AxisX.MajorGrid.Enabled = false;
				areaPoint.AxisX.MajorTickMark.Enabled = false;
				areaPoint.AxisX.LabelStyle.Enabled = false;
				areaPoint.AxisY.MajorGrid.Enabled = false;
				areaPoint.AxisY.MajorTickMark.Enabled = false;
				areaPoint.AxisY.LabelStyle.Enabled = false;

				//****************************************************
				//** Create data series in the chart area
				//****************************************************
				Series seriesPoint = chart.Series.Add(series.Name + "_" + pointIndex.ToString());
				seriesPoint.ChartArea = areaPoint.Name;
				seriesPoint.ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), chartType, true );
				seriesPoint.IsVisibleInLegend = false;
				seriesPoint.BorderColor = Color.FromArgb(64,64,64);
				seriesPoint.ShadowOffset = 2;
				seriesPoint.Palette = ChartColorPalette.Pastel;

				//****************************************************
				//** Populate data series.
				//** TODO: For this sample each series is populated
				//** with random data. Do your own series population
				//** here.
				//****************************************************
				for(int sliceIndex = 0; sliceIndex < 5; sliceIndex++)
				{
					seriesPoint.Points.AddY(random.Next(2,20));
				}

				//****************************************************
				//** Set chart area position and inner plot position
				//****************************************************

				// Set chart area inner plot position
				areaPoint.InnerPlotPosition = new ElementPosition(3, 3, 94, 94);
				
				// Position chart area over the data point
				PointF position = PointF.Empty;
				position.X = (float)chart.ChartAreas[series.ChartArea].AxisX.GetPosition(zeroXValues ? (pointIndex + 1) : point.XValue);
				position.Y = (float)chart.ChartAreas[series.ChartArea].AxisY.GetPosition(point.YValues[0]);

				float pieSize = (point.MarkerSize < 15) ? 15 : point.MarkerSize;;
				if(bubbleChart)
				{
					pieSize = (float)((point.YValues[1] - valueDiff) * valueScale) + minBubleSize;
				}
				pieSize = pieSize * 100F / ((float)(chart.Width - 1)); 
				areaPoint.Position = new ElementPosition(position.X - pieSize/2f, position.Y - pieSize/2f, pieSize, pieSize);

				// Increase point index
				++pointIndex;
			}
		}

	}
}
