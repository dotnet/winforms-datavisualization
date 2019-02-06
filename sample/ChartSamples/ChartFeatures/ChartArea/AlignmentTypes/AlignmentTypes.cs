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
	/// Summary description for AxisTitle.
	/// </summary>
	public class AlignmentTypes : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkAlign;
        private GroupBox groupBox1;
        private RadioButton positionButton;
        private GroupBox groupBox2;
        private RadioButton noneButton;
        private RadioButton plotButton;
        private CheckBox AxisViewsBox;
        private CheckBox CursorBox;
        private GroupBox groupBox3;
        private System.Windows.Forms.Label AlignStyleLabel;
        private Chart Chart1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AlignmentTypes()
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "12000,84000");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "27000,86000");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "8000,76000");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "15000,97000");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "24000,76000");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "15000,73000");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "34000,87000");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "21000,67000");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "12000,90000");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "10000,96000");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "34000,78000");
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 55000);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 60000);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 53000);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 27000);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 29000);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 25000);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 38000);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 43000);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 68000);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 55000);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint22 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 45000);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint23 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "20,78");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint24 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "33,73");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint25 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "35,63");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint26 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "25,90");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint27 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "44,70");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint28 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "30,70");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint29 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "33,80");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint30 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "23,72");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint31 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "9,65");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint32 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "23,85");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint33 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "13,84");
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint34 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 47);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint35 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 44);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint36 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 37);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint37 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 47);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint38 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 53);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint39 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 42);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint40 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 50);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint41 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 60);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint42 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 43);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint43 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 39);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint44 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 72);
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AlignStyleLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AxisViewsBox = new System.Windows.Forms.CheckBox();
            this.CursorBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noneButton = new System.Windows.Forms.RadioButton();
            this.plotButton = new System.Windows.Forms.RadioButton();
            this.positionButton = new System.Windows.Forms.RadioButton();
            this.checkAlign = new System.Windows.Forms.CheckBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to align two chart areas using various alignment typ" +
                "es.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.checkAlign);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AlignStyleLabel);
            this.groupBox3.Location = new System.Drawing.Point(20, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 76);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Align Type";
            // 
            // AlignStyleLabel
            // 
            this.AlignStyleLabel.AutoSize = true;
            this.AlignStyleLabel.Location = new System.Drawing.Point(7, 22);
            this.AlignStyleLabel.Name = "AlignStyleLabel";
            this.AlignStyleLabel.Size = new System.Drawing.Size(79, 14);
            this.AlignStyleLabel.TabIndex = 0;
            this.AlignStyleLabel.Text = "Not aligned";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AxisViewsBox);
            this.groupBox2.Controls.Add(this.CursorBox);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(20, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Align using mouse interaction";
            // 
            // AxisViewsBox
            // 
            this.AxisViewsBox.Checked = true;
            this.AxisViewsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AxisViewsBox.Location = new System.Drawing.Point(7, 47);
            this.AxisViewsBox.Name = "AxisViewsBox";
            this.AxisViewsBox.Size = new System.Drawing.Size(88, 18);
            this.AxisViewsBox.TabIndex = 1;
            this.AxisViewsBox.Text = "AxisViews";
            this.AxisViewsBox.CheckedChanged += new System.EventHandler(this.AnythingChecked);
            // 
            // CursorBox
            // 
            this.CursorBox.Checked = true;
            this.CursorBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CursorBox.Location = new System.Drawing.Point(7, 22);
            this.CursorBox.Name = "CursorBox";
            this.CursorBox.Size = new System.Drawing.Size(68, 18);
            this.CursorBox.TabIndex = 0;
            this.CursorBox.Text = "Cursor";
            this.CursorBox.CheckedChanged += new System.EventHandler(this.AnythingChecked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noneButton);
            this.groupBox1.Controls.Add(this.plotButton);
            this.groupBox1.Controls.Add(this.positionButton);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(20, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Align using position";
            // 
            // noneButton
            // 
            this.noneButton.Location = new System.Drawing.Point(6, 69);
            this.noneButton.Name = "noneButton";
            this.noneButton.Size = new System.Drawing.Size(58, 18);
            this.noneButton.TabIndex = 2;
            this.noneButton.TabStop = true;
            this.noneButton.Text = "None";
            this.noneButton.CheckedChanged += new System.EventHandler(this.AnythingChecked);
            // 
            // plotButton
            // 
            this.plotButton.Checked = true;
            this.plotButton.Location = new System.Drawing.Point(6, 45);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(145, 18);
            this.plotButton.TabIndex = 1;
            this.plotButton.TabStop = true;
            this.plotButton.Text = "Inner Plot Position ";
            this.plotButton.CheckedChanged += new System.EventHandler(this.AnythingChecked);
            // 
            // positionButton
            // 
            this.positionButton.Location = new System.Drawing.Point(6, 21);
            this.positionButton.Name = "positionButton";
            this.positionButton.Size = new System.Drawing.Size(75, 18);
            this.positionButton.TabIndex = 0;
            this.positionButton.TabStop = true;
            this.positionButton.Text = "Position";
            this.positionButton.CheckedChanged += new System.EventHandler(this.AnythingChecked);
            // 
            // checkAlign
            // 
            this.checkAlign.Location = new System.Drawing.Point(20, 0);
            this.checkAlign.Name = "checkAlign";
            this.checkAlign.Size = new System.Drawing.Size(192, 24);
            this.checkAlign.TabIndex = 0;
            this.checkAlign.Text = "&Align the two chart areas";
            this.checkAlign.CheckedChanged += new System.EventHandler(this.AnythingChecked);
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            this.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
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
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.IndianRed;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Inclination = 15;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Perspective = 10;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea2.AxisY.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BackColor = System.Drawing.Color.OldLace;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorX.SelectionColor = System.Drawing.Color.IndianRed;
            chartArea2.Name = "Chart Area 2";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.Chart1.ChartAreas.Add(chartArea1);
            this.Chart1.ChartAreas.Add(chartArea2);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.DockedToChartArea = "Default";
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(19, 56);
            this.Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Series 1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.Points.Add(dataPoint10);
            series1.Points.Add(dataPoint11);
            series1.YValuesPerPoint = 2;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Default";
            series2.Name = "Series 2";
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.Points.Add(dataPoint15);
            series2.Points.Add(dataPoint16);
            series2.Points.Add(dataPoint17);
            series2.Points.Add(dataPoint18);
            series2.Points.Add(dataPoint19);
            series2.Points.Add(dataPoint20);
            series2.Points.Add(dataPoint21);
            series2.Points.Add(dataPoint22);
            series2.ShadowOffset = 1;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Chart Area 2";
            series3.Legend = "Default";
            series3.Name = "Series 3";
            series3.Points.Add(dataPoint23);
            series3.Points.Add(dataPoint24);
            series3.Points.Add(dataPoint25);
            series3.Points.Add(dataPoint26);
            series3.Points.Add(dataPoint27);
            series3.Points.Add(dataPoint28);
            series3.Points.Add(dataPoint29);
            series3.Points.Add(dataPoint30);
            series3.Points.Add(dataPoint31);
            series3.Points.Add(dataPoint32);
            series3.Points.Add(dataPoint33);
            series3.YValuesPerPoint = 2;
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series4.ChartArea = "Chart Area 2";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Default";
            series4.Name = "Series 4";
            series4.Points.Add(dataPoint34);
            series4.Points.Add(dataPoint35);
            series4.Points.Add(dataPoint36);
            series4.Points.Add(dataPoint37);
            series4.Points.Add(dataPoint38);
            series4.Points.Add(dataPoint39);
            series4.Points.Add(dataPoint40);
            series4.Points.Add(dataPoint41);
            series4.Points.Add(dataPoint42);
            series4.Points.Add(dataPoint43);
            series4.Points.Add(dataPoint44);
            series4.ShadowOffset = 1;
            this.Chart1.Series.Add(series1);
            this.Chart1.Series.Add(series2);
            this.Chart1.Series.Add(series3);
            this.Chart1.Series.Add(series4);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 1;
            // 
            // AlignmentTypes
            // 
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AlignmentTypes";
            this.Size = new System.Drawing.Size(728, 480);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion






        private void AnythingChecked(object sender, EventArgs e)
        {
            if (checkAlign.Checked)
            {
                // Make Chart Area 2 align to Chart Area 1
                Chart1.ChartAreas["Chart Area 2"].AlignWithChartArea = "Default";
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;



            }


            if (noneButton.Checked)
            {
                if (CursorBox.Checked && AxisViewsBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.None | AreaAlignmentStyles.Cursor | AreaAlignmentStyles.AxesView;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.None |\n AreaAlignmentStyles.Cursor |\n AreaAlignmentStyles.AxesView;";
                }
                else if (AxisViewsBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.None | AreaAlignmentStyles.AxesView;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.None |\n AreaAlignmentStyles.AxesView;";
                }
                else if (CursorBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.None | AreaAlignmentStyles.Cursor;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.None |\n AreaAlignmentStyles.Cursor;";
                }
                else if(noneButton.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.None;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.None;";

                }
            }
            if (positionButton.Checked)
            {
                if (CursorBox.Checked && AxisViewsBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.Position | AreaAlignmentStyles.Cursor | AreaAlignmentStyles.AxesView;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.Position |\n AreaAlignmentStyles.Cursor |\n AreaAlignmentStyles.AxesView;";
                }
                else if (AxisViewsBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.Position | AreaAlignmentStyles.AxesView;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.Position |\n AreaAlignmentStyles.AxesView;";
                }
                else if (CursorBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.Position | AreaAlignmentStyles.Cursor;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.Position |\n AreaAlignmentStyles.Cursor;";

                }
                else if (positionButton.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.Position;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.Position;";
                }
            }
            if (plotButton.Checked)
            {
                if (CursorBox.Checked && AxisViewsBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.PlotPosition | AreaAlignmentStyles.Cursor | AreaAlignmentStyles.AxesView;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.PlotPosition |\n AreaAlignmentStyles.Cursor |\n AreaAlignmentStyles.AxesView;";
                }
                else if (AxisViewsBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.PlotPosition | AreaAlignmentStyles.AxesView;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.PlotPosition |\n AreaAlignmentStyles.AxesView";
                }
                else if (CursorBox.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.PlotPosition | AreaAlignmentStyles.Cursor;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.PlotPosition |\n AreaAlignmentStyles.Cursor;";
                }
                else if(plotButton.Checked)
                {
                    Chart1.ChartAreas["Chart Area 2"].AlignmentStyle = AreaAlignmentStyles.PlotPosition;
                    AlignStyleLabel.Text = "AreaAlignmentStyles.PlotPosition;";
                }
            }
            if (!checkAlign.Checked)
            {
                // No alignment
                Chart1.ChartAreas["Chart Area 2"].AlignWithChartArea = "";
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                AlignStyleLabel.Text = "Not aligned";
            }




        }




	}
}

