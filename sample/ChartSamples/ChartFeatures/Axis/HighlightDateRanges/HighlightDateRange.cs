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
	/// Summary description for HighlightDateRange.
	/// </summary>
	public class HighlightDateRange : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxPointsHighlight;
		private System.Windows.Forms.Label label1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public HighlightDateRange()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSampleComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxPointsHighlight = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "MMM d";
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Interval = 200;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Interval = 200;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.Interval = 200;
            chartArea1.AxisY.Maximum = 1000;
            chartArea1.AxisY.Minimum = 0;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.LabelStyle.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 48);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series1.CustomProperties = "DrawingStyle=LightToDark";
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(412, 306);
            this.chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 34);
            this.labelSampleComment.TabIndex = 0;
            this.labelSampleComment.Text = "This sample demonstrates how to highlight a range of data using StripLine objects" +
                ". ";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxPointsHighlight);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxPointsHighlight
            // 
            this.comboBoxPointsHighlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPointsHighlight.Items.AddRange(new object[] {
            "Weekends",
            "Weekdays",
            "Mondays",
            "Wednesdays",
            "Fridays",
            "Mondays and Fridays"});
            this.comboBoxPointsHighlight.Location = new System.Drawing.Point(168, 2);
            this.comboBoxPointsHighlight.Name = "comboBoxPointsHighlight";
            this.comboBoxPointsHighlight.Size = new System.Drawing.Size(121, 22);
            this.comboBoxPointsHighlight.TabIndex = 1;
            this.comboBoxPointsHighlight.SelectedIndexChanged += new System.EventHandler(this.comboBoxPointsHighlight_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Points to &Highlight:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "StripLine objects, unlike interlaced strip lines, have interval-related propertie" +
                "s that determine how often and where strip lines are displayed.";
            // 
            // HighlightDateRange
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HighlightDateRange";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.Sample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
		}

		private void FillData()
		{
			// Populate chart with random sales data
			Random		random = new Random();
			DateTime	xTime = new DateTime(2000, 8, 1, 0, 0, 0);
			chart1.Series["Default"].Points.Clear();
			for(int pointIndex = 0; pointIndex < 21; pointIndex++)
			{
				// Simulate lower sales on the weekends	
				double	yValue = random.Next(600, 950);
				if(xTime.DayOfWeek == DayOfWeek.Sunday || xTime.DayOfWeek == DayOfWeek.Saturday)
				{
					yValue = random.Next(100, 400);
				}
				chart1.Series["Default"].Points.AddXY(xTime, yValue);
				xTime = xTime.AddDays(1);
			}

			chart1.Invalidate();
		}



		private void Sample_Load(object sender, System.EventArgs e)
		{
			// Set current selection
			comboBoxPointsHighlight.SelectedIndex = 0;
			
			// Fill chart data
			FillData();
		}

		private void comboBoxPointsHighlight_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			double offset = -1.5;
			double width = 2;
			chart1.ChartAreas["Default"].AxisX.StripLines.Clear();

			string SelectedText = comboBoxPointsHighlight.SelectedItem.ToString();

			if(SelectedText == "Weekends")
			{
				offset = -1.5;
				width = 2;
			}
			else if(SelectedText == "Weekdays")
			{
				offset = 0.5;
				width = 5;
			}
			else if(SelectedText == "Mondays")
			{
				offset = 0.5;
				width = 1;
			}
			else if(SelectedText == "Wednesdays")
			{
				offset = 2.5;
				width = 1;
			}
			else if(SelectedText == "Fridays")
			{
				offset = 4.5;
				width = 1;
			}
			else if(SelectedText == "Mondays and Fridays")
			{
				// Create a re-occurring strip line for the monday
				StripLine strip = new StripLine();
				strip.BackColor = Color.FromArgb(120, Color.Gray);
				strip.IntervalOffset = 0.5;
				strip.IntervalOffsetType = DateTimeIntervalType.Days; 
				strip.Interval = 1;
				strip.IntervalType = DateTimeIntervalType.Weeks; 
				strip.StripWidth = 1;
				strip.StripWidthType =  DateTimeIntervalType.Days; 
				chart1.ChartAreas["Default"].AxisX.StripLines.Add(strip);

				offset = 4.5;
				width = 1;
			}


			// Create a re-occurring strip line for the selected range or 
			// just the firday if monday and friday is the selection
			StripLine stripLine = new StripLine();
			stripLine.BackColor = Color.FromArgb(120, Color.Gray);
			stripLine.IntervalOffset = offset;
			stripLine.IntervalOffsetType = DateTimeIntervalType.Days; 
			stripLine.Interval = 1;
			stripLine.IntervalType = DateTimeIntervalType.Weeks; 
			stripLine.StripWidth = width;
			stripLine.StripWidthType =  DateTimeIntervalType.Days; 
			chart1.ChartAreas["Default"].AxisX.StripLines.Add(stripLine);

		}
	}
}
