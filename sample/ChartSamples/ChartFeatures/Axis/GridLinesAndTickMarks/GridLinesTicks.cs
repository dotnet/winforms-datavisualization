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
	/// Summary description for GridLinesTicks.
	/// </summary>
	public class GridLinesTicks : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.ComboBox MajorInterval;
		private System.Windows.Forms.ComboBox MajorLineColor;
		private System.Windows.Forms.ComboBox MajorLineDashStyle;
		private System.Windows.Forms.ComboBox MajorLineWidth;
		private System.Windows.Forms.ComboBox Major;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox Minor;
		private System.Windows.Forms.ComboBox MinorLineDashStyle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox MinorInterval;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox MinorLineWidth;
		private System.Windows.Forms.ComboBox MinorLineColor;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GridLinesTicks()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Populate list of intervals
			double[] intervals = new double[] { 0.1, 0.2, 0.5 };
			foreach(double interval in intervals)
			{
				this.MinorInterval.Items.Add(interval.ToString());
			}
	
			foreach(string lineName in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)))
			{
				this.MinorLineDashStyle.Items.Add(lineName);
				this.MajorLineDashStyle.Items.Add(lineName);
			}
			this.MajorLineDashStyle.SelectedIndex = 5;
			this.MinorLineDashStyle.SelectedIndex = 5;

			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				this.MinorLineColor.Items.Add(colorName);
				this.MajorLineColor.Items.Add(colorName);
			}

			this.MajorLineColor.SelectedIndex = this.MajorLineColor.Items.IndexOf("DimGray");
			this.MinorLineColor.SelectedIndex = this.MinorLineColor.Items.IndexOf("LightGray");;

			this.MajorLineWidth.SelectedIndex = 1;
			this.MinorLineWidth.SelectedIndex = 0;

			this.Major.SelectedIndex = 0;
			this.Minor.SelectedIndex = 0;

			this.MajorInterval.SelectedIndex = 0;
			this.MinorInterval.SelectedIndex = 0;

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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 700);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 400);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 500);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 600);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 450);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 600);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 500);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 600);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 500);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 550);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 500);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 600);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 700);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 400);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 600);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.MajorInterval = new System.Windows.Forms.ComboBox();
            this.MajorLineColor = new System.Windows.Forms.ComboBox();
            this.MajorLineDashStyle = new System.Windows.Forms.ComboBox();
            this.MajorLineWidth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Minor = new System.Windows.Forms.ComboBox();
            this.MinorLineDashStyle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MinorInterval = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MinorLineWidth = new System.Windows.Forms.ComboBox();
            this.MinorLineColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Major = new System.Windows.Forms.ComboBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // MajorInterval
            // 
            this.MajorInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MajorInterval.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.MajorInterval.Location = new System.Drawing.Point(168, 136);
            this.MajorInterval.Name = "MajorInterval";
            this.MajorInterval.Size = new System.Drawing.Size(121, 22);
            this.MajorInterval.TabIndex = 9;
            this.MajorInterval.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
            // 
            // MajorLineColor
            // 
            this.MajorLineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MajorLineColor.Location = new System.Drawing.Point(168, 72);
            this.MajorLineColor.Name = "MajorLineColor";
            this.MajorLineColor.Size = new System.Drawing.Size(121, 22);
            this.MajorLineColor.TabIndex = 5;
            this.MajorLineColor.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
            // 
            // MajorLineDashStyle
            // 
            this.MajorLineDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MajorLineDashStyle.Location = new System.Drawing.Point(168, 40);
            this.MajorLineDashStyle.Name = "MajorLineDashStyle";
            this.MajorLineDashStyle.Size = new System.Drawing.Size(121, 22);
            this.MajorLineDashStyle.TabIndex = 3;
            this.MajorLineDashStyle.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
            // 
            // MajorLineWidth
            // 
            this.MajorLineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MajorLineWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.MajorLineWidth.Location = new System.Drawing.Point(168, 104);
            this.MajorLineWidth.Name = "MajorLineWidth";
            this.MajorLineWidth.Size = new System.Drawing.Size(121, 22);
            this.MajorLineWidth.TabIndex = 7;
            this.MajorLineWidth.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(86, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "&Interval:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(86, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Line &Style:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(86, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Line &Color:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(86, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Line &Width:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to set the appearance of grid lines and tick marks.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Minor);
            this.panel1.Controls.Add(this.MinorLineDashStyle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.MinorInterval);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.MinorLineWidth);
            this.panel1.Controls.Add(this.MinorLineColor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Major);
            this.panel1.Controls.Add(this.MajorLineDashStyle);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.MajorInterval);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.MajorLineWidth);
            this.panel1.Controls.Add(this.MajorLineColor);
            this.panel1.Location = new System.Drawing.Point(432, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 340);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(86, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mi&nor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Minor
            // 
            this.Minor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Minor.Items.AddRange(new object[] {
            "Grid Lines",
            "Tick Marks"});
            this.Minor.Location = new System.Drawing.Point(168, 176);
            this.Minor.Name = "Minor";
            this.Minor.Size = new System.Drawing.Size(121, 22);
            this.Minor.TabIndex = 11;
            this.Minor.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
            // 
            // MinorLineDashStyle
            // 
            this.MinorLineDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinorLineDashStyle.Location = new System.Drawing.Point(168, 208);
            this.MinorLineDashStyle.Name = "MinorLineDashStyle";
            this.MinorLineDashStyle.Size = new System.Drawing.Size(121, 22);
            this.MinorLineDashStyle.TabIndex = 13;
            this.MinorLineDashStyle.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(86, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "In&terval:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(86, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Line S&tyle:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MinorInterval
            // 
            this.MinorInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinorInterval.Location = new System.Drawing.Point(168, 304);
            this.MinorInterval.Name = "MinorInterval";
            this.MinorInterval.Size = new System.Drawing.Size(121, 22);
            this.MinorInterval.TabIndex = 19;
            this.MinorInterval.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(86, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Line C&olor:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(86, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Line Wi&dth:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MinorLineWidth
            // 
            this.MinorLineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinorLineWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.MinorLineWidth.Location = new System.Drawing.Point(168, 272);
            this.MinorLineWidth.Name = "MinorLineWidth";
            this.MinorLineWidth.Size = new System.Drawing.Size(121, 22);
            this.MinorLineWidth.TabIndex = 17;
            this.MinorLineWidth.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
            // 
            // MinorLineColor
            // 
            this.MinorLineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinorLineColor.Location = new System.Drawing.Point(168, 240);
            this.MinorLineColor.Name = "MinorLineColor";
            this.MinorLineColor.Size = new System.Drawing.Size(121, 22);
            this.MinorLineColor.TabIndex = 15;
            this.MinorLineColor.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(86, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma&jor:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Major
            // 
            this.Major.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Major.Items.AddRange(new object[] {
            "Grid Lines",
            "Tick Marks"});
            this.Major.Location = new System.Drawing.Point(168, 8);
            this.Major.Name = "Major";
            this.Major.Size = new System.Drawing.Size(121, 22);
            this.Major.TabIndex = 1;
            this.Major.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
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
            chartArea1.AxisX.MajorTickMark.Size = 2F;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.White;
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
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            this.Chart1.Series.Add(series1);
            this.Chart1.Series.Add(series2);
            this.Chart1.Series.Add(series3);
            this.Chart1.Size = new System.Drawing.Size(412, 306);
            this.Chart1.TabIndex = 1;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Grid Lines and Tick Marks";
            this.Chart1.Titles.Add(title1);
            // 
            // GridLinesTicks
            // 
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GridLinesTicks";
            this.Size = new System.Drawing.Size(728, 480);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void ControlSelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Disable all elements
			Chart1.ChartAreas["Default"].AxisX.MajorGrid.Enabled = false;
			Chart1.ChartAreas["Default"].AxisX.MajorTickMark.Enabled = false;
			Chart1.ChartAreas["Default"].AxisX.MinorGrid.Enabled = false;
			Chart1.ChartAreas["Default"].AxisX.MinorTickMark.Enabled = false;

			// Enable Major selected element
			if(Major.SelectedIndex >= 0)
			{
				switch( Major.SelectedItem.ToString())
				{
					case "Grid Lines":
						Chart1.ChartAreas["Default"].AxisX.MajorGrid.Enabled = true;
						break;
					case "Tick Marks":
						Chart1.ChartAreas["Default"].AxisX.MajorTickMark.Enabled = true;
						break;
				}
			}

			// Enable Minor selected element
			if(Minor.SelectedIndex >= 0)
			{
				switch( Minor.SelectedItem.ToString() )
				{
					case "Grid Lines":
						Chart1.ChartAreas["Default"].AxisX.MinorGrid.Enabled = true;
						break;
					case "Tick Marks":
						Chart1.ChartAreas["Default"].AxisX.MinorTickMark.Enabled = true;
						break;
				}
			}

			// Set Grid lines and tick marks interval
			if(MajorInterval.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MajorGrid.Interval = double.Parse( MajorInterval.SelectedItem.ToString() );
				Chart1.ChartAreas["Default"].AxisX.MajorTickMark.Interval = double.Parse( MajorInterval.SelectedItem.ToString() );
			}

			if(MinorInterval.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MinorGrid.Interval = double.Parse( MinorInterval.SelectedItem.ToString() );
				Chart1.ChartAreas["Default"].AxisX.MinorTickMark.Interval = double.Parse( MinorInterval.SelectedItem.ToString() );
			}

			// Set Line Color
			if(MajorLineColor.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MajorGrid.LineColor = Color.FromName(MajorLineColor.SelectedItem.ToString());
				Chart1.ChartAreas["Default"].AxisX.MajorTickMark.LineColor = Color.FromName(MajorLineColor.SelectedItem.ToString());
			}
			
			if(MinorLineColor.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MinorGrid.LineColor = Color.FromName(MinorLineColor.SelectedItem.ToString());
				Chart1.ChartAreas["Default"].AxisX.MinorTickMark.LineColor = Color.FromName(MinorLineColor.SelectedItem.ToString());
			}
			
			// Set Line Style
			if(MajorLineDashStyle.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MajorGrid.LineDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), MajorLineDashStyle.SelectedItem.ToString());
				Chart1.ChartAreas["Default"].AxisX.MajorTickMark.LineDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), MajorLineDashStyle.SelectedItem.ToString());
			}

			if(MinorLineDashStyle.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MinorGrid.LineDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), MinorLineDashStyle.SelectedItem.ToString());
				Chart1.ChartAreas["Default"].AxisX.MinorTickMark.LineDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), MinorLineDashStyle.SelectedItem.ToString());
			}
			
			// Set Line Width
			if(MajorLineWidth.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MajorGrid.LineWidth = int.Parse(MajorLineWidth.SelectedItem.ToString());
				Chart1.ChartAreas["Default"].AxisX.MajorTickMark.LineWidth = int.Parse(MajorLineWidth.SelectedItem.ToString());
			}

			if(MinorLineWidth.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.MinorGrid.LineWidth = int.Parse(MinorLineWidth.SelectedItem.ToString());
				Chart1.ChartAreas["Default"].AxisX.MinorTickMark.LineWidth = int.Parse(MinorLineWidth.SelectedItem.ToString());
			}
		}
	}
}
