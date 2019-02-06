using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Utilities;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for PieCollectedData.
	/// </summary>
	public class PieCollectedData : System.Windows.Forms.UserControl
	{
		// PieCollectedDataHelper is a helper class found in the samples Utilities folder. 
		PieCollectedDataHelper pieHelper = null;

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxChartType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxCollectedPercentage;
		private bool		loadingData = false;
		private System.Windows.Forms.CheckBox checkBoxcollectSmallSegments;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxsupplementalSize;
        private System.Windows.Forms.CheckBox checkBoxOriginalChart;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PieCollectedData()
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
            this.checkBoxOriginalChart = new System.Windows.Forms.CheckBox();
            this.comboBoxsupplementalSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxcollectSmallSegments = new System.Windows.Forms.CheckBox();
            this.comboBoxCollectedPercentage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
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
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Empty;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 61);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieLabelStyle=Ellipse";
            series1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.ShadowOffset = 5;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 45);
            this.labelSampleComment.TabIndex = 0;
            this.labelSampleComment.Text = "This sample demonstrates how to improve the readability of small segments in the " +
                "Pie or Doughnut chart types by displaying them in a supplemental pie chart serie" +
                "s.";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxOriginalChart);
            this.panel1.Controls.Add(this.comboBoxsupplementalSize);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBoxcollectSmallSegments);
            this.panel1.Controls.Add(this.comboBoxCollectedPercentage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxChartType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(432, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxOriginalChart
            // 
            this.checkBoxOriginalChart.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxOriginalChart.Location = new System.Drawing.Point(-19, 7);
            this.checkBoxOriginalChart.Name = "checkBoxOriginalChart";
            this.checkBoxOriginalChart.Size = new System.Drawing.Size(216, 24);
            this.checkBoxOriginalChart.TabIndex = 1;
            this.checkBoxOriginalChart.Text = "&Hide Supplemental Chart:";
            this.checkBoxOriginalChart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxOriginalChart.CheckedChanged += new System.EventHandler(this.checkBoxOriginalChart_CheckedChanged);
            // 
            // comboBoxsupplementalSize
            // 
            this.comboBoxsupplementalSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxsupplementalSize.Items.AddRange(new object[] {
            "Smaller",
            "Same",
            "Larger"});
            this.comboBoxsupplementalSize.Location = new System.Drawing.Point(184, 104);
            this.comboBoxsupplementalSize.Name = "comboBoxsupplementalSize";
            this.comboBoxsupplementalSize.Size = new System.Drawing.Size(104, 22);
            this.comboBoxsupplementalSize.TabIndex = 7;
            this.comboBoxsupplementalSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxsupplementalSize_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Supplemental chart &Size:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxcollectSmallSegments
            // 
            this.checkBoxcollectSmallSegments.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxcollectSmallSegments.Location = new System.Drawing.Point(5, 138);
            this.checkBoxcollectSmallSegments.Name = "checkBoxcollectSmallSegments";
            this.checkBoxcollectSmallSegments.Size = new System.Drawing.Size(192, 24);
            this.checkBoxcollectSmallSegments.TabIndex = 0;
            this.checkBoxcollectSmallSegments.Text = "&Collect Small Segments:";
            this.checkBoxcollectSmallSegments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxcollectSmallSegments.CheckedChanged += new System.EventHandler(this.checkBoxcollectSmallSegments_CheckedChanged);
            // 
            // comboBoxCollectedPercentage
            // 
            this.comboBoxCollectedPercentage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCollectedPercentage.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.comboBoxCollectedPercentage.Location = new System.Drawing.Point(184, 72);
            this.comboBoxCollectedPercentage.Name = "comboBoxCollectedPercentage";
            this.comboBoxCollectedPercentage.Size = new System.Drawing.Size(104, 22);
            this.comboBoxCollectedPercentage.TabIndex = 5;
            this.comboBoxCollectedPercentage.SelectedIndexChanged += new System.EventHandler(this.comboBoxCollectedPercentage_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Collected &Percentage:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType.Items.AddRange(new object[] {
            "Doughnut",
            "Pie"});
            this.comboBoxChartType.Location = new System.Drawing.Point(184, 40);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(104, 22);
            this.comboBoxChartType.TabIndex = 3;
            this.comboBoxChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chart &Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PieCollectedData
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PieCollectedData";
            this.Size = new System.Drawing.Size(728, 424);
            this.Load += new System.EventHandler(this.PieChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			if(!this.loadingData)
			{
				// Set chart type 
				chart1.Series["Default"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), comboBoxChartType.Text, true );

				// Populate series data
				double[]	yValues = {65.62,  2.1, 85.73, 11.42, 34.45,  75.54, 5.7, 4.1};
				string[]	xValues = {"France", "Japan",  "USA", "Italy", "Germany", "Canada",  "Russia", "Spain"};
				chart1.Series["Default"].Points.DataBindXY(xValues, yValues);

				// Remove supplemental series and chart area if they already exsist
				if(chart1.Series.Count > 1)
				{
					chart1.Series.RemoveAt(1);
					chart1.ChartAreas.RemoveAt(1);

					// Reset automatic position for the default chart area
					chart1.ChartAreas["Default"].Position.Auto = true;
				}
				
				
				// Check if supplemental chart should be shown
				if(!checkBoxOriginalChart.Checked)
				{
					chart1.Series["Default"]["PieLabelStyle"] = "Inside";
					
					// Set the percentage of the total series values. This value determines 
					// if the data point value is a "small" value and should be shown as collected.
					pieHelper.CollectedPercentage = double.Parse(comboBoxCollectedPercentage.Text);

					// Indicates if small segments should be shown as one "collected" segment in 
					// the original series.
					pieHelper.ShowCollectedDataAsOneSlice = checkBoxcollectSmallSegments.Checked;

					// Size ratio between the original and supplemental chart areas.
					// Value of 1.0f indicates that same area size will be used.
					if(comboBoxsupplementalSize.SelectedIndex == 0)
					{
						pieHelper.SupplementedAreaSizeRatio = 0.9f;
					}
					else if(comboBoxsupplementalSize.SelectedIndex == 1)
					{
						pieHelper.SupplementedAreaSizeRatio = 1.0f;
					}
					else if(comboBoxsupplementalSize.SelectedIndex == 2)
					{
						pieHelper.SupplementedAreaSizeRatio = 1.1f;
					}

					// Set position in relative coordinates ( 0,0 - top left corner; 100,100 - bottom right corner)
					// where original and supplemental pie charts should be placed.
					pieHelper.ChartAreaPosition = new RectangleF(3f, 3f, 93f, 96f);

					// Show supplemental pie for the "Default" series
					pieHelper.ShowSmallSegmentsAsSupplementalPie("Default");
				}
				else
				{
					chart1.Series["Default"]["PieLabelStyle"] = "Outside";
					chart1.Series["Default"].LabelBackColor = Color.Empty;
				}
				// Enable/Disable controls
				comboBoxChartType.Enabled = !checkBoxOriginalChart.Checked;
				comboBoxCollectedPercentage.Enabled = !checkBoxOriginalChart.Checked;
				comboBoxsupplementalSize.Enabled = !checkBoxOriginalChart.Checked;
				checkBoxcollectSmallSegments.Enabled = !checkBoxOriginalChart.Checked;
			}
		}

		private void PieChartType_Load(object sender, System.EventArgs e)
		{
			// Set series font
			chart1.Series[0].Font = new Font("Trebuchet MS", 8, FontStyle.Bold);

			// Create pie chart helper class
			pieHelper = new PieCollectedDataHelper(chart1);
			pieHelper.CollectedLabel = String.Empty;
            
			// Set current selection
			this.loadingData = true;
			comboBoxChartType.SelectedIndex = 0;
			comboBoxCollectedPercentage.SelectedIndex = 1;
			comboBoxsupplementalSize.SelectedIndex = 0;
			this.loadingData = false;

			// Update chart
			UpdateChartSettings();
		}

		private void comboBoxChartType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxCollectedPercentage_SelectedIndexChanged_1(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxcollectSmallSegments_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxsupplementalSize_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxOriginalChart_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}
	}
}
