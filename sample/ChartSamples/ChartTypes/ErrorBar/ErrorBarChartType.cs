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
	/// Summary description for ErrorBarChartType.
	/// </summary>
	public class ErrorBarChartType : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxMarkersStyle;
		private System.Windows.Forms.ComboBox comboBoxErrorStyle;
		private System.Windows.Forms.ComboBox comboBoxCalculationStyle;
		private System.Windows.Forms.ComboBox comboBoxCenterMarkerStyle;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ErrorBarChartType()
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSampleComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCenterMarkerStyle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMarkersStyle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxErrorStyle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCalculationStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.chart1.Location = new System.Drawing.Point(16, 56);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "DataSeries";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.MarkerSize = 6;
            series2.Name = "ErrorBar";
            series2.ShadowOffset = 1;
            series2.YValuesPerPoint = 3;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 40);
            this.labelSampleComment.TabIndex = 0;
            this.labelSampleComment.Text = "This sample shows how to use the Error Bar chart to display error bars for data s" +
                "eries using different error calculation methods. ";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxCenterMarkerStyle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxMarkersStyle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxErrorStyle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxCalculationStyle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 288);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxCenterMarkerStyle
            // 
            this.comboBoxCenterMarkerStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCenterMarkerStyle.Items.AddRange(new object[] {
            "None",
            "Line",
            "Square",
            "Circle",
            "Diamond",
            "Triangle",
            "Cross"});
            this.comboBoxCenterMarkerStyle.Location = new System.Drawing.Point(168, 104);
            this.comboBoxCenterMarkerStyle.Name = "comboBoxCenterMarkerStyle";
            this.comboBoxCenterMarkerStyle.Size = new System.Drawing.Size(144, 22);
            this.comboBoxCenterMarkerStyle.TabIndex = 7;
            this.comboBoxCenterMarkerStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxCenterMarkerStyle_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Center Marker Style:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMarkersStyle
            // 
            this.comboBoxMarkersStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarkersStyle.Items.AddRange(new object[] {
            "None",
            "Line",
            "Square",
            "Circle",
            "Diamond",
            "Triangle",
            "Cross"});
            this.comboBoxMarkersStyle.Location = new System.Drawing.Point(168, 72);
            this.comboBoxMarkersStyle.Name = "comboBoxMarkersStyle";
            this.comboBoxMarkersStyle.Size = new System.Drawing.Size(144, 22);
            this.comboBoxMarkersStyle.TabIndex = 5;
            this.comboBoxMarkersStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarkersStyle_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Markers Style:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxErrorStyle
            // 
            this.comboBoxErrorStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxErrorStyle.Items.AddRange(new object[] {
            "Both",
            "UpperError",
            "LowerError"});
            this.comboBoxErrorStyle.Location = new System.Drawing.Point(168, 40);
            this.comboBoxErrorStyle.Name = "comboBoxErrorStyle";
            this.comboBoxErrorStyle.Size = new System.Drawing.Size(144, 22);
            this.comboBoxErrorStyle.TabIndex = 3;
            this.comboBoxErrorStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxErrorStyle_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Error &Style:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxCalculationStyle
            // 
            this.comboBoxCalculationStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCalculationStyle.Items.AddRange(new object[] {
            "StandardError",
            "StandardDeviation",
            "Percentage(15)",
            "FixedValue(10)"});
            this.comboBoxCalculationStyle.Location = new System.Drawing.Point(168, 8);
            this.comboBoxCalculationStyle.Name = "comboBoxCalculationStyle";
            this.comboBoxCalculationStyle.Size = new System.Drawing.Size(144, 22);
            this.comboBoxCalculationStyle.TabIndex = 1;
            this.comboBoxCalculationStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxCalculationStyle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Error Calculation:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Verdana", 11F);
            this.label5.Location = new System.Drawing.Point(28, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(696, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "Error bars are used to display statistical information about the chart data.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ErrorBarChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ErrorBarChartType";
            this.Size = new System.Drawing.Size(752, 480);
            this.Load += new System.EventHandler(this.PieChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Set error calculation type
			chart1.Series["ErrorBar"]["ErrorBarType"] = (string)comboBoxCalculationStyle.SelectedItem;

			// Set error bar upper & lower error style
			chart1.Series["ErrorBar"]["ErrorBarStyle"] = (string)comboBoxErrorStyle.SelectedItem;

			// Set error bar center marker style
			chart1.Series["ErrorBar"]["ErrorBarCenterMarkerStyle"] = (string)comboBoxCenterMarkerStyle.SelectedItem;

			// Set error bar marker style
			string markerStyle = (string)comboBoxMarkersStyle.SelectedItem;
			chart1.Series["ErrorBar"]["PointWidth"] = "0.4";
			if(markerStyle == "Line")
			{
				chart1.Series["ErrorBar"].MarkerStyle = MarkerStyle.None;
			}
			else if(markerStyle == "None")
			{
				chart1.Series["ErrorBar"]["PointWidth"] = "0";
				chart1.Series["ErrorBar"].MarkerStyle = MarkerStyle.None;
			}
			else if(markerStyle != null)
			{
				chart1.Series["ErrorBar"].MarkerStyle = (MarkerStyle)Enum.Parse(typeof(MarkerStyle), markerStyle);
			}

		}

		private void PieChartType_Load(object sender, System.EventArgs e)
		{
			// Populate series with data
			double[]	yValues = {32.4, 56.9, 89.7, 80.5, 59.3, 33.8, 78.8, 44.6, 76.4, 68.9};
			chart1.Series["DataSeries"].Points.DataBindY(yValues);

			// Link error bar series with data series
			chart1.Series["ErrorBar"]["ErrorBarSeries"] = "DataSeries";

			// Set selection
			comboBoxCalculationStyle.SelectedIndex = 0;
			comboBoxErrorStyle.SelectedIndex = 0;
			comboBoxMarkersStyle.SelectedIndex = 1;
			comboBoxCenterMarkerStyle.SelectedIndex = 0;

			UpdateChartSettings();	
		}

		private void comboBoxCalculationStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxErrorStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxMarkersStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxCenterMarkerStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

	}
}
