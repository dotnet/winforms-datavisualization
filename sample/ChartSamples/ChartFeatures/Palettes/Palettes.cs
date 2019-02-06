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
	/// Summary description for Palettes.
	/// </summary>
	public class Palettes : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cb_Palette;
		private System.Windows.Forms.ComboBox cb_CustomPalette;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;

		Random random = new Random();
		private System.Windows.Forms.RadioButton rb_Palette;
		private System.Windows.Forms.RadioButton rb_CustomPalette;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Palettes()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			chart2.Series.Clear();
			FillSeries(chart2, 5, 30);
			FillSeries(chart2, 20, 40);
			FillSeries(chart2, 40, 50);
			FillSeries(chart2, 11, 50);

			this.cb_CustomPalette.SelectedIndex = 0;
			this.cb_Palette.SelectedIndex = 0;
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = ((System.Windows.Forms.DataVisualization.Charting.ChartArea)(new System.Windows.Forms.DataVisualization.Charting.ChartArea()));
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = ((System.Windows.Forms.DataVisualization.Charting.Legend)(new System.Windows.Forms.DataVisualization.Charting.Legend()));
            System.Windows.Forms.DataVisualization.Charting.Series series1 = ((System.Windows.Forms.DataVisualization.Charting.Series)(new System.Windows.Forms.DataVisualization.Charting.Series()));
            System.Windows.Forms.DataVisualization.Charting.Series series2 = ((System.Windows.Forms.DataVisualization.Charting.Series)(new System.Windows.Forms.DataVisualization.Charting.Series()));
            System.Windows.Forms.DataVisualization.Charting.Series series3 = ((System.Windows.Forms.DataVisualization.Charting.Series)(new System.Windows.Forms.DataVisualization.Charting.Series()));
            System.Windows.Forms.DataVisualization.Charting.Series series4 = ((System.Windows.Forms.DataVisualization.Charting.Series)(new System.Windows.Forms.DataVisualization.Charting.Series()));
            System.Windows.Forms.DataVisualization.Charting.Title title1 = ((System.Windows.Forms.DataVisualization.Charting.Title)(new System.Windows.Forms.DataVisualization.Charting.Title()));
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSampleComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_CustomPalette = new System.Windows.Forms.RadioButton();
            this.rb_Palette = new System.Windows.Forms.RadioButton();
            this.cb_CustomPalette = new System.Windows.Forms.ComboBox();
            this.cb_Palette = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart2.BackSecondaryColor = System.Drawing.Color.White;
            this.chart2.BorderlineColor = System.Drawing.Color.Navy;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart2.BorderlineWidth = 2;
            this.chart2.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            this.chart2.BorderSkin.Tag = null;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 8;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Interval = 0;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Interval = 0;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Interval = 0;
            chartArea1.AxisX.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.LabelStyle.Interval = 0;
            chartArea1.AxisX2.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisX2.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorGrid.Interval = 0;
            chartArea1.AxisX2.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisX2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorTickMark.Interval = 0;
            chartArea1.AxisX2.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisX2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Interval = 0;
            chartArea1.AxisY.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Interval = 0;
            chartArea1.AxisY.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.Interval = 0;
            chartArea1.AxisY.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.LabelStyle.Interval = 0;
            chartArea1.AxisY2.LabelStyle.IntervalOffset = 0;
            chartArea1.AxisY2.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorGrid.Interval = 0;
            chartArea1.AxisY2.MajorGrid.IntervalOffset = 0;
            chartArea1.AxisY2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorTickMark.Interval = 0;
            chartArea1.AxisY2.MajorTickMark.IntervalOffset = 0;
            chartArea1.AxisY2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY2.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.InnerPlotPosition.Height = 85.94743F;
            chartArea1.InnerPlotPosition.Tag = null;
            chartArea1.InnerPlotPosition.Width = 88.8228F;
            chartArea1.InnerPlotPosition.X = 9.4162F;
            chartArea1.InnerPlotPosition.Y = 3.40178F;
            chartArea1.Name = "Default";
            chartArea1.Position.Height = 77.16559F;
            chartArea1.Position.Tag = null;
            chartArea1.Position.Width = 89.43796F;
            chartArea1.Position.X = 4.824818F;
            chartArea1.Position.Y = 16.02085F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            legend1.Position.Tag = null;
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(16, 56);
            this.chart2.Name = "chart2";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series1.BorderWidth = 3;
            series1.CustomProperties = "DrawingStyle=LightToDark";
            series1.EmptyPointStyle.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series1.EmptyPointStyle.Name = null;
            series1.Name = "Series1";
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series2.BorderWidth = 3;
            series2.CustomProperties = "DrawingStyle=LightToDark";
            series2.EmptyPointStyle.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series2.EmptyPointStyle.Name = null;
            series2.Name = "Series2";
            series2.YValuesPerPoint = 2;
            series3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series3.BorderWidth = 3;
            series3.CustomProperties = "DrawingStyle=LightToDark";
            series3.EmptyPointStyle.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series3.EmptyPointStyle.Name = null;
            series3.Name = "Series3";
            series3.YValuesPerPoint = 2;
            series4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series4.BorderWidth = 3;
            series4.CustomProperties = "DrawingStyle=LightToDark";
            series4.EmptyPointStyle.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopLeft;
            series4.EmptyPointStyle.Name = null;
            series4.Name = "Series4";
            series4.YValuesPerPoint = 2;
            this.chart2.Series.Add(series1);
            this.chart2.Series.Add(series2);
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(412, 296);
            this.chart2.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Position.Height = 7.478481F;
            title1.Position.Tag = null;
            title1.Position.Width = 89.43796F;
            title1.Position.X = 4.824818F;
            title1.Position.Y = 5.542373F;
            title1.Text = "Chart Control for .NET Framework";
            this.chart2.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 34);
            this.labelSampleComment.TabIndex = 2;
            this.labelSampleComment.Text = "This sample demonstrates how a chart palette can be specified.";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_CustomPalette);
            this.panel1.Controls.Add(this.rb_Palette);
            this.panel1.Controls.Add(this.cb_CustomPalette);
            this.panel1.Controls.Add(this.cb_Palette);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 288);
            this.panel1.TabIndex = 1;
            // 
            // rb_CustomPalette
            // 
            this.rb_CustomPalette.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_CustomPalette.Location = new System.Drawing.Point(24, 48);
            this.rb_CustomPalette.Name = "rb_CustomPalette";
            this.rb_CustomPalette.Size = new System.Drawing.Size(136, 24);
            this.rb_CustomPalette.TabIndex = 6;
            this.rb_CustomPalette.Text = "Custom Palette:";
            this.rb_CustomPalette.CheckedChanged += new System.EventHandler(this.rb_CustomPalette_CheckedChanged);
            // 
            // rb_Palette
            // 
            this.rb_Palette.Checked = true;
            this.rb_Palette.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_Palette.Location = new System.Drawing.Point(24, 16);
            this.rb_Palette.Name = "rb_Palette";
            this.rb_Palette.Size = new System.Drawing.Size(136, 24);
            this.rb_Palette.TabIndex = 5;
            this.rb_Palette.TabStop = true;
            this.rb_Palette.Text = "Standard Palette:";
            this.rb_Palette.CheckedChanged += new System.EventHandler(this.rb_Palette_CheckedChanged);
            // 
            // cb_CustomPalette
            // 
            this.cb_CustomPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CustomPalette.Enabled = false;
            this.cb_CustomPalette.Items.AddRange(new object[] {
            "CorporateGold",
            "CorporateBlue",
            "Pastel"});
            this.cb_CustomPalette.Location = new System.Drawing.Point(168, 48);
            this.cb_CustomPalette.Name = "cb_CustomPalette";
            this.cb_CustomPalette.Size = new System.Drawing.Size(128, 22);
            this.cb_CustomPalette.TabIndex = 4;
            this.cb_CustomPalette.SelectedIndexChanged += new System.EventHandler(this.cb_CustomPalette_SelectedIndexChanged);
            // 
            // cb_Palette
            // 
            this.cb_Palette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Palette.Items.AddRange(new object[] {
            "BrightPastel",
            "EarthTones",
            "Pastel",
            "Excel",
            "SeaGreen"});
            this.cb_Palette.Location = new System.Drawing.Point(168, 16);
            this.cb_Palette.Name = "cb_Palette";
            this.cb_Palette.Size = new System.Drawing.Size(128, 22);
            this.cb_Palette.TabIndex = 1;
            this.cb_Palette.SelectedIndexChanged += new System.EventHandler(this.cb_Palette_SelectedIndexChanged);
            // 
            // Palettes
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart2);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Palettes";
            this.Size = new System.Drawing.Size(760, 376);
            this.Load += new System.EventHandler(this.Palettes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void cb_CustomPalette_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateCustomPalette();
            chart2.Invalidate();
		}

		public void AddSeries(Chart chart, string seriesName)
		{
			Series s = new Series(seriesName);
			chart.Series.Add(s);
			chart.Series[seriesName].ChartType = SeriesChartType.Column;
			chart.Series[seriesName]["DrawingStyle"] = "Emboss";
		}

		public void GenerateData(Chart chart, string seriesName, int min, int max)
		{
			//random 
			DateTime dateSeries2;
			for (int pointIndex = 0; pointIndex < 5; pointIndex++)
			{
				dateSeries2 = DateTime.Now.AddDays(pointIndex);
				chart.Series[seriesName].Points.AddXY(dateSeries2, random.Next(min, max));
			}
		}

		
		public void FillSeries(Chart chart, int min, int max)
		{            
			// Add series to the chart
			string seriesName = "Series" + min;
			this.AddSeries(chart, seriesName);

			chart.Series[seriesName].BorderWidth = 3;
			chart.Series[seriesName].ShadowOffset = 1;

			// Fill the series with data
			GenerateData(chart, seriesName, min, max);
		}

		private void UpdateCustomPalette()
		{            
			Color[] colorSet;

            chart2.Palette = ChartColorPalette.None;
			if (cb_CustomPalette.SelectedItem.ToString() == "CorporateGold")
			{
				colorSet = new Color[4] { Color.FromArgb(224, 131, 10), Color.FromArgb(255, 227, 130), Color.FromArgb(251, 197, 65), Color.FromArgb(251, 180, 65) };
				chart2.PaletteCustomColors = colorSet;
			}

			else if (cb_CustomPalette.SelectedItem.ToString() == "CorporateBlue")
			{
				colorSet = new Color[4] { Color.FromArgb(5, 100, 146), Color.FromArgb(144, 218, 255), Color.FromArgb(149, 193, 254), Color.FromArgb(65, 140, 240) };
				chart2.PaletteCustomColors = colorSet;
			}

			else
			{
				colorSet = new Color[4] { Color.FromArgb(120, 147, 190), Color.FromArgb(241, 185, 168), Color.FromArgb(128, 184, 209), Color.FromArgb(243, 210, 136) };
				chart2.PaletteCustomColors = colorSet;
			}
		}
		

		private void UpdatePalette()
		{
			chart2.PaletteCustomColors = new Color[0];
			chart2.Palette = (ChartColorPalette)ChartColorPalette.Parse(typeof(ChartColorPalette), this.cb_Palette.SelectedItem.ToString());
		}

		private void cb_Palette_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdatePalette();
			chart2.Invalidate();
		}

		private void rb_CustomPalette_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateControls();
			UpdateCustomPalette();
        }

		private void UpdateControls()
		{			
			if (this.rb_CustomPalette.Checked) 
			{
				this.cb_Palette.Enabled = false;
				this.cb_CustomPalette.Enabled = true;
			}

			else 
			{
				this.cb_Palette.Enabled = true;
				this.cb_CustomPalette.Enabled = false;
			}
		}

		private void rb_Palette_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateControls();
			UpdatePalette();
		}

        private void Palettes_Load(object sender, EventArgs e)
        {

        }
	}
}
