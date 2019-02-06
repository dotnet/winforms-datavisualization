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
	/// Summary description for Title.
	/// </summary>
	public class ChartTitle : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.ComboBox FontSize;
		private System.Windows.Forms.TextBox Title;
		private System.Windows.Forms.ComboBox FontColorCombo;
		private System.Windows.Forms.ComboBox TheFont;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox Alignment;
		private System.Windows.Forms.ComboBox BorderColor;
		private System.Windows.Forms.TextBox ToolTip;
		private System.Windows.Forms.ComboBox BackColorCom;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ChartTitle()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			
			// Add Chart Line styles to control.
			foreach(FontFamily fontName in FontFamily.Families)
			{
				this.TheFont.Items.Add(fontName.Name);
			}
			this.TheFont.SelectedIndex = this.TheFont.Items.IndexOf( Chart1.Titles[0].Font.Name); 

			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				this.FontColorCombo.Items.Add(colorName);
			}
			
			this.Alignment.SelectedIndex = 1;
			this.FontColorCombo.SelectedIndex = 9;	// "Control Text"

			this.FontSize.SelectedIndex = 3;	// 14 point

			this.BackColorCom.SelectedIndex = 0;
			this.BorderColor.SelectedIndex = 0;

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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 400);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 200);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 700);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 300);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5, 450);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 200);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 300);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 350);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 80);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5, 400);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 500);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 120);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 300);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 50);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5, 130);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.TheFont = new System.Windows.Forms.ComboBox();
            this.FontColorCombo = new System.Windows.Forms.ComboBox();
            this.FontSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToolTip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Alignment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BorderColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackColorCom = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // TheFont
            // 
            this.TheFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TheFont.Location = new System.Drawing.Point(168, 32);
            this.TheFont.Name = "TheFont";
            this.TheFont.Size = new System.Drawing.Size(121, 22);
            this.TheFont.TabIndex = 2;
            this.TheFont.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
            // 
            // FontColorCombo
            // 
            this.FontColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontColorCombo.Location = new System.Drawing.Point(168, 88);
            this.FontColorCombo.Name = "FontColorCombo";
            this.FontColorCombo.Size = new System.Drawing.Size(121, 22);
            this.FontColorCombo.TabIndex = 6;
            this.FontColorCombo.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
            // 
            // FontSize
            // 
            this.FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16"});
            this.FontSize.Location = new System.Drawing.Point(168, 60);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(121, 22);
            this.FontSize.TabIndex = 4;
            this.FontSize.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "&Font:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Font &Color:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Font &Size:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample shows how to set the chart title\'s text, font and color. Note that th" +
                "e PrePaint and PostPaint events allow for custom drawing of the chart\'s title. ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ToolTip);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Alignment);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BorderColor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BackColorCom);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TheFont);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.FontSize);
            this.panel1.Controls.Add(this.FontColorCombo);
            this.panel1.Location = new System.Drawing.Point(432, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 296);
            this.panel1.TabIndex = 2;
            // 
            // ToolTip
            // 
            this.ToolTip.Location = new System.Drawing.Point(169, 200);
            this.ToolTip.Name = "ToolTip";
            this.ToolTip.Size = new System.Drawing.Size(120, 22);
            this.ToolTip.TabIndex = 14;
            this.ToolTip.Text = "Title Tooltip";
            this.ToolTip.TextChanged += new System.EventHandler(this.ControlChange);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "&ToolTip:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "&Alignment:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Alignment
            // 
            this.Alignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Alignment.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.Alignment.Location = new System.Drawing.Point(168, 172);
            this.Alignment.Name = "Alignment";
            this.Alignment.Size = new System.Drawing.Size(121, 22);
            this.Alignment.TabIndex = 12;
            this.Alignment.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "B&order Color:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BorderColor
            // 
            this.BorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorderColor.Items.AddRange(new object[] {
            "None",
            "Red",
            "Green",
            "Blue",
            "Yellow"});
            this.BorderColor.Location = new System.Drawing.Point(168, 144);
            this.BorderColor.Name = "BorderColor";
            this.BorderColor.Size = new System.Drawing.Size(121, 22);
            this.BorderColor.TabIndex = 10;
            this.BorderColor.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "&Back Color:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BackColorCom
            // 
            this.BackColorCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BackColorCom.Items.AddRange(new object[] {
            "None",
            "Red",
            "Green",
            "Blue",
            "Yellow"});
            this.BackColorCom.Location = new System.Drawing.Point(168, 116);
            this.BackColorCom.Name = "BackColorCom";
            this.BackColorCom.Size = new System.Drawing.Size(121, 22);
            this.BackColorCom.TabIndex = 8;
            this.BackColorCom.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(8, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(280, 22);
            this.Title.TabIndex = 0;
            this.Title.Text = "Sales Report\\nYear 2001";
            this.Title.TextChanged += new System.EventHandler(this.ControlChange);
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            this.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.Chart1.BorderlineWidth = 2;
            this.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 5;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Name = "Default";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(16, 60);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
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
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 1;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Sales Report\\nYear 2001";
            this.Chart1.Titles.Add(title1);
            // 
            // ChartTitle
            // 
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChartTitle";
            this.Size = new System.Drawing.Size(728, 480);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void AxisTitle_Load(object sender, System.EventArgs e)
		{ 
		
		}

		private void ControlChange(object sender, System.EventArgs e)
		{
			
			// Set selected axis
			Chart1.Titles[0].Text = Title.Text;

			// Set Font style.
			FontStyle fontStyle = FontStyle.Regular;
			
			// Set Title font
			if(this.TheFont.SelectedIndex >= 0 && this.FontSize.SelectedIndex >= 0)
			{
				string font = this.TheFont.SelectedItem.ToString();
				float fontpoint = float.Parse(this.FontSize.SelectedItem.ToString());
				try
				{
					Chart1.Titles[0].Font = new Font(font, fontpoint, fontStyle);
				}
				catch
				{
					Chart1.Titles[0].Font = new Font("Arial", fontpoint, fontStyle);
				}
			}

			// Set Title alignment
			if( this.Alignment.SelectedIndex == 0 )
			{
				Chart1.Titles[0].Alignment = ContentAlignment.MiddleLeft;
			}
			else if( this.Alignment.SelectedIndex == 1 )
			{
				Chart1.Titles[0].Alignment = ContentAlignment.MiddleCenter;
			}
			else
			{
				Chart1.Titles[0].Alignment = ContentAlignment.MiddleRight;
			}

			// Set Title color
			if(this.FontColorCombo.SelectedIndex >= 0)
			{
				Chart1.Titles[0].ForeColor = Color.FromName(this.FontColorCombo.SelectedItem.ToString());
			}

			// Set Border Title color
			if(this.BorderColor.SelectedIndex > 0)
			{
				Chart1.Titles[0].BorderColor = Color.FromName(this.BorderColor.SelectedItem.ToString());
			}
			else
			{
				Chart1.Titles[0].BorderColor =  Color.Empty;
			}

			// Set Background Title color
			if(this.BackColorCom.SelectedIndex > 0)
			{
				Chart1.Titles[0].BackColor = Color.FromName(this.BackColorCom.SelectedItem.ToString());
			}
			else
			{
				Chart1.Titles[0].BackColor =  Color.Empty;
			}

			// Set Tooltip
			Chart1.Titles[0].ToolTip = this.ToolTip.Text;

		}

	}
}
