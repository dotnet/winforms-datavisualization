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
	/// Summary description for ChartAreaPosition.
	/// </summary>
	public class ChartAreaPosition : System.Windows.Forms.UserControl
	{
		# region Fields

		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown ChartArea_X;
		private System.Windows.Forms.NumericUpDown ChartArea_Y;
		private System.Windows.Forms.NumericUpDown ChartArea_Width;
		private System.Windows.Forms.NumericUpDown ChartArea_Height;
		private System.Windows.Forms.NumericUpDown PlottingArea_X;
		private System.Windows.Forms.NumericUpDown PlottingArea_Y;
		private System.Windows.Forms.NumericUpDown PlottingArea_Width;
		private System.Windows.Forms.NumericUpDown PlottingArea_Height;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		#endregion

		# region Constructor

		public ChartAreaPosition()
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
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel3 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel4 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 70);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 80);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 70);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 85);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 65);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 70);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 60);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 75);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 50);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 55);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 40);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 70);
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlottingArea_Height = new System.Windows.Forms.NumericUpDown();
            this.PlottingArea_Width = new System.Windows.Forms.NumericUpDown();
            this.PlottingArea_Y = new System.Windows.Forms.NumericUpDown();
            this.PlottingArea_X = new System.Windows.Forms.NumericUpDown();
            this.ChartArea_Height = new System.Windows.Forms.NumericUpDown();
            this.ChartArea_Width = new System.Windows.Forms.NumericUpDown();
            this.ChartArea_Y = new System.Windows.Forms.NumericUpDown();
            this.ChartArea_X = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlottingArea_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlottingArea_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlottingArea_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlottingArea_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartArea_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartArea_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartArea_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartArea_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 18;
            this.label9.Text = "This sample shows how to manually set the positions of the chart area and plot ar" +
                "ea. ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PlottingArea_Height);
            this.panel1.Controls.Add(this.PlottingArea_Width);
            this.panel1.Controls.Add(this.PlottingArea_Y);
            this.panel1.Controls.Add(this.PlottingArea_X);
            this.panel1.Controls.Add(this.ChartArea_Height);
            this.panel1.Controls.Add(this.ChartArea_Width);
            this.panel1.Controls.Add(this.ChartArea_Y);
            this.panel1.Controls.Add(this.ChartArea_X);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 312);
            this.panel1.TabIndex = 19;
            // 
            // PlottingArea_Height
            // 
            this.PlottingArea_Height.Location = new System.Drawing.Point(176, 280);
            this.PlottingArea_Height.Name = "PlottingArea_Height";
            this.PlottingArea_Height.Size = new System.Drawing.Size(112, 22);
            this.PlottingArea_Height.TabIndex = 21;
            this.PlottingArea_Height.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.PlottingArea_Height.ValueChanged += new System.EventHandler(this.PlottingArea_Height_ValueChanged);
            // 
            // PlottingArea_Width
            // 
            this.PlottingArea_Width.Location = new System.Drawing.Point(176, 248);
            this.PlottingArea_Width.Name = "PlottingArea_Width";
            this.PlottingArea_Width.Size = new System.Drawing.Size(112, 22);
            this.PlottingArea_Width.TabIndex = 20;
            this.PlottingArea_Width.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.PlottingArea_Width.ValueChanged += new System.EventHandler(this.PlottingArea_Width_ValueChanged);
            // 
            // PlottingArea_Y
            // 
            this.PlottingArea_Y.Location = new System.Drawing.Point(176, 216);
            this.PlottingArea_Y.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PlottingArea_Y.Name = "PlottingArea_Y";
            this.PlottingArea_Y.Size = new System.Drawing.Size(112, 22);
            this.PlottingArea_Y.TabIndex = 19;
            this.PlottingArea_Y.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PlottingArea_Y.ValueChanged += new System.EventHandler(this.PlottingArea_Y_ValueChanged);
            // 
            // PlottingArea_X
            // 
            this.PlottingArea_X.Location = new System.Drawing.Point(176, 184);
            this.PlottingArea_X.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PlottingArea_X.Name = "PlottingArea_X";
            this.PlottingArea_X.Size = new System.Drawing.Size(112, 22);
            this.PlottingArea_X.TabIndex = 18;
            this.PlottingArea_X.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PlottingArea_X.ValueChanged += new System.EventHandler(this.PlottingArea_X_ValueChanged);
            // 
            // ChartArea_Height
            // 
            this.ChartArea_Height.Location = new System.Drawing.Point(168, 128);
            this.ChartArea_Height.Name = "ChartArea_Height";
            this.ChartArea_Height.Size = new System.Drawing.Size(112, 22);
            this.ChartArea_Height.TabIndex = 17;
            this.ChartArea_Height.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.ChartArea_Height.ValueChanged += new System.EventHandler(this.ChartArea_Height_ValueChanged);
            // 
            // ChartArea_Width
            // 
            this.ChartArea_Width.Location = new System.Drawing.Point(168, 96);
            this.ChartArea_Width.Name = "ChartArea_Width";
            this.ChartArea_Width.Size = new System.Drawing.Size(112, 22);
            this.ChartArea_Width.TabIndex = 16;
            this.ChartArea_Width.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.ChartArea_Width.ValueChanged += new System.EventHandler(this.ChartArea_Width_ValueChanged);
            // 
            // ChartArea_Y
            // 
            this.ChartArea_Y.Location = new System.Drawing.Point(168, 64);
            this.ChartArea_Y.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ChartArea_Y.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChartArea_Y.Name = "ChartArea_Y";
            this.ChartArea_Y.Size = new System.Drawing.Size(112, 22);
            this.ChartArea_Y.TabIndex = 15;
            this.ChartArea_Y.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChartArea_Y.ValueChanged += new System.EventHandler(this.ChartArea_Y_ValueChanged);
            // 
            // ChartArea_X
            // 
            this.ChartArea_X.Location = new System.Drawing.Point(168, 32);
            this.ChartArea_X.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ChartArea_X.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChartArea_X.Name = "ChartArea_X";
            this.ChartArea_X.Size = new System.Drawing.Size(112, 22);
            this.ChartArea_X.TabIndex = 14;
            this.ChartArea_X.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ChartArea_X.ValueChanged += new System.EventHandler(this.ChartArea_X_ValueChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(16, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Plotting Area Position:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(80, 280);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Height:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(80, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Width:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(80, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Y:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(80, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "X:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(80, 131);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Height:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(80, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Width:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(80, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(72, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "X:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chart Area Position:";
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
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
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 5;
            chartArea1.Area3DStyle.WallWidth = 0;
            customLabel1.FromPosition = 0.5;
            customLabel1.Text = "John";
            customLabel1.ToPosition = 1.5;
            customLabel2.FromPosition = 1.5;
            customLabel2.Text = "Mary";
            customLabel2.ToPosition = 2.5;
            customLabel3.FromPosition = 2.5;
            customLabel3.Text = "Jeff";
            customLabel3.ToPosition = 3.5;
            customLabel4.FromPosition = 3.5;
            customLabel4.Text = "Bob";
            customLabel4.ToPosition = 4.5;
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.CustomLabels.Add(customLabel2);
            chartArea1.AxisX.CustomLabels.Add(customLabel3);
            chartArea1.AxisX.CustomLabels.Add(customLabel4);
            chartArea1.AxisX.Interval = 1;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 75F;
            chartArea1.Position.Width = 90F;
            chartArea1.Position.X = 2F;
            chartArea1.Position.Y = 13F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            legend1.Position.Auto = false;
            legend1.Position.Height = 5F;
            legend1.Position.Width = 40F;
            legend1.Position.X = 5F;
            legend1.Position.Y = 85F;
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(16, 48);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.Legend = "Legend2";
            series1.Name = "Series2";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.Legend = "Default";
            series2.Name = "Series3";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.CustomProperties = "DrawingStyle=Cylinder";
            series3.Legend = "Default";
            series3.Name = "Series4";
            series3.Points.Add(dataPoint9);
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            this.Chart1.Series.Add(series1);
            this.Chart1.Series.Add(series2);
            this.Chart1.Series.Add(series3);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 20;
            this.Chart1.PrePaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.Chart1_PrePaint);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(696, 40);
            this.label12.TabIndex = 21;
            this.label12.Text = "The plot area is the portion within a chart area that is used for plotting data, " +
                "and does not include tick marks and axis labels.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChartAreaPosition
            // 
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChartAreaPosition";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.ZOrder_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlottingArea_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlottingArea_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlottingArea_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlottingArea_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartArea_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartArea_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartArea_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartArea_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		# endregion

		# region Methods

		private void Positions()
		{	
			Chart1.ChartAreas["Default"].Position.Auto = false;
			Chart1.ChartAreas["Default"].Position.X = (float)this.ChartArea_X.Value;
			Chart1.ChartAreas["Default"].Position.Y = (float)this.ChartArea_Y.Value;
			Chart1.ChartAreas["Default"].Position.Width = (float)this.ChartArea_Width.Value;
			Chart1.ChartAreas["Default"].Position.Height= (float)this.ChartArea_Height.Value;

			Chart1.ChartAreas["Default"].InnerPlotPosition.Auto = false;
			Chart1.ChartAreas["Default"].InnerPlotPosition.X = (float)this.PlottingArea_X.Value;
			Chart1.ChartAreas["Default"].InnerPlotPosition.Y = (float)this.PlottingArea_Y.Value;
			Chart1.ChartAreas["Default"].InnerPlotPosition.Width = (float)this.PlottingArea_Width.Value;
			Chart1.ChartAreas["Default"].InnerPlotPosition.Height = (float)this.PlottingArea_Height.Value;
		}	

		private void Chart1_PrePaint(object sender, System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e)
		{
			if( sender is ChartArea )
			{
				RectangleF rect = e.ChartGraphics.GetAbsoluteRectangle( e.Chart.ChartAreas[0].Position.ToRectangleF() );
				e.ChartGraphics.Graphics.DrawRectangle( new Pen(Color.Red), rect.X, rect.Y, rect.Width, rect.Height);
			}
		}
		
		# endregion	

		# region Event Handlers

		private void ZOrder_Load(object sender, System.EventArgs e)
		{
			Positions();
		}

		private void ChartArea_X_ValueChanged(object sender, System.EventArgs e)
		{
			Positions();		
		}

		private void ChartArea_Y_ValueChanged(object sender, System.EventArgs e)
		{
			Positions();	
		}

		private void ChartArea_Width_ValueChanged(object sender, System.EventArgs e)
		{
			Positions();	
		}

		private void ChartArea_Height_ValueChanged(object sender, System.EventArgs e)
		{
			Positions();	
		}

		private void PlottingArea_X_ValueChanged(object sender, System.EventArgs e)
		{
			Positions();	
		}

		private void PlottingArea_Y_ValueChanged(object sender, System.EventArgs e)
		{
			Positions();	
		}

		private void PlottingArea_Width_ValueChanged(object sender, System.EventArgs e)
		{
			Positions();	
		}

		private void PlottingArea_Height_ValueChanged(object sender, System.EventArgs e)
		{
			Positions();	
		}

		# endregion
	}
}