using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for Borders.
	/// </summary>
	public class Borders : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.ComboBox SkinStyle;
		private System.Windows.Forms.ComboBox ChartForeColor;
		private System.Windows.Forms.ComboBox HatchStyle;
		private System.Windows.Forms.ComboBox Gradient;
		private System.Windows.Forms.ComboBox BorderColor;
		private System.Windows.Forms.ComboBox BorderDashStyle;
		private System.Windows.Forms.ComboBox BorderSize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox ChartBackColor;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private bool initialising = true;

		public Borders()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Add Hatch styles to control.
			foreach(string colorName in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)))
			{
				this.HatchStyle.Items.Add(colorName);
			}
			this.HatchStyle.SelectedIndex = 0;

			// Add Chart Gradient types to control.
			foreach(string colorName in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.GradientStyle)))
			{
				this.Gradient.Items.Add(colorName);
			}
			this.Gradient.SelectedIndex = 0;

			// Add Chart Line styles to control.
			foreach(string skinStyle in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle)))
			{
				this.SkinStyle.Items.Add(skinStyle);
			}
			this.SkinStyle.SelectedIndex = 1;

			
			// Add Border styles to control.
			foreach(string colorName in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)))
			{
				this.BorderDashStyle.Items.Add(colorName);
			}
			this.BorderDashStyle.SelectedIndex = this.BorderDashStyle.Items.IndexOf("Solid");

			// Add Colors to controls.
			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				this.ChartBackColor.Items.Add(colorName);
				this.ChartForeColor.Items.Add(colorName);
				this.BorderColor.Items.Add(colorName);
			}

			this.BorderColor.SelectedIndex = this.BorderColor.Items.IndexOf("Maroon");
			this.ChartBackColor.SelectedIndex = this.BorderColor.Items.IndexOf("PeachPuff");
			this.ChartForeColor.SelectedIndex = this.BorderColor.Items.IndexOf("White");

			this.BorderSize.SelectedIndex = 0;
			
			this.initialising = false;
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChartBackColor = new System.Windows.Forms.ComboBox();
            this.SkinStyle = new System.Windows.Forms.ComboBox();
            this.ChartForeColor = new System.Windows.Forms.ComboBox();
            this.HatchStyle = new System.Windows.Forms.ComboBox();
            this.Gradient = new System.Windows.Forms.ComboBox();
            this.BorderColor = new System.Windows.Forms.ComboBox();
            this.BorderDashStyle = new System.Windows.Forms.ComboBox();
            this.BorderSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartBackColor
            // 
            this.ChartBackColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChartBackColor.Location = new System.Drawing.Point(168, 80);
            this.ChartBackColor.Name = "ChartBackColor";
            this.ChartBackColor.Size = new System.Drawing.Size(121, 22);
            this.ChartBackColor.TabIndex = 2;
            this.ChartBackColor.SelectedIndexChanged += new System.EventHandler(this.SkinItems_Changed);
            // 
            // SkinStyle
            // 
            this.SkinStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SkinStyle.Location = new System.Drawing.Point(168, 8);
            this.SkinStyle.Name = "SkinStyle";
            this.SkinStyle.Size = new System.Drawing.Size(121, 22);
            this.SkinStyle.TabIndex = 0;
            this.SkinStyle.SelectedIndexChanged += new System.EventHandler(this.SkinStyle_SelectedIndexChanged);
            // 
            // ChartForeColor
            // 
            this.ChartForeColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChartForeColor.Location = new System.Drawing.Point(168, 48);
            this.ChartForeColor.Name = "ChartForeColor";
            this.ChartForeColor.Size = new System.Drawing.Size(121, 22);
            this.ChartForeColor.TabIndex = 1;
            this.ChartForeColor.SelectedIndexChanged += new System.EventHandler(this.SkinItems_Changed);
            // 
            // HatchStyle
            // 
            this.HatchStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HatchStyle.Location = new System.Drawing.Point(168, 144);
            this.HatchStyle.Name = "HatchStyle";
            this.HatchStyle.Size = new System.Drawing.Size(121, 22);
            this.HatchStyle.TabIndex = 4;
            this.HatchStyle.SelectedIndexChanged += new System.EventHandler(this.SkinItems_Changed);
            // 
            // Gradient
            // 
            this.Gradient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gradient.Location = new System.Drawing.Point(168, 112);
            this.Gradient.Name = "Gradient";
            this.Gradient.Size = new System.Drawing.Size(121, 22);
            this.Gradient.TabIndex = 3;
            this.Gradient.SelectedIndexChanged += new System.EventHandler(this.SkinItems_Changed);
            // 
            // BorderColor
            // 
            this.BorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorderColor.Location = new System.Drawing.Point(168, 216);
            this.BorderColor.Name = "BorderColor";
            this.BorderColor.Size = new System.Drawing.Size(121, 22);
            this.BorderColor.TabIndex = 6;
            this.BorderColor.SelectedIndexChanged += new System.EventHandler(this.Border_Changed);
            // 
            // BorderDashStyle
            // 
            this.BorderDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorderDashStyle.Location = new System.Drawing.Point(168, 184);
            this.BorderDashStyle.Name = "BorderDashStyle";
            this.BorderDashStyle.Size = new System.Drawing.Size(121, 22);
            this.BorderDashStyle.TabIndex = 5;
            this.BorderDashStyle.SelectedIndexChanged += new System.EventHandler(this.Border_Changed);
            // 
            // BorderSize
            // 
            this.BorderSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorderSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.BorderSize.Location = new System.Drawing.Point(168, 248);
            this.BorderSize.Name = "BorderSize";
            this.BorderSize.Size = new System.Drawing.Size(121, 22);
            this.BorderSize.TabIndex = 7;
            this.BorderSize.SelectedIndexChanged += new System.EventHandler(this.Border_Changed);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "&Skin Style:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "&Fore Color:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "&Back Color:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(26, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "&Gradient:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(26, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "&Hatch Style:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(26, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "B&order Style:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(26, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bo&rder Color:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(26, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bor&der Size:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 18;
            this.label9.Text = "This sample demonstrates how to set the appearance properties of a chart\'s border" +
                " skin.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BorderDashStyle);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Gradient);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.HatchStyle);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SkinStyle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.BorderSize);
            this.panel1.Controls.Add(this.ChartBackColor);
            this.panel1.Controls.Add(this.ChartForeColor);
            this.panel1.Controls.Add(this.BorderColor);
            this.panel1.Location = new System.Drawing.Point(432, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 0;
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.Chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.Chart1.BorderlineColor = System.Drawing.Color.Maroon;
            this.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 14;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 6;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 17;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.Interval = 1;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
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
            this.Chart1.Location = new System.Drawing.Point(16, 60);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
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
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.Legend = "Default";
            series2.Name = "Series3";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.CustomProperties = "DrawingStyle=Cylinder";
            series3.Legend = "Default";
            series3.Name = "Series4";
            series3.Points.Add(dataPoint9);
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
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
            title1.Text = "Chart Control for .NET Framework";
            this.Chart1.Titles.Add(title1);
            // 
            // Borders
            // 
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Borders";
            this.Size = new System.Drawing.Size(728, 480);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private bool IsFrameStyle()
		{
			return Chart1.BorderSkin.SkinStyle.ToString().IndexOf("Frame") != -1;
		}

		private void SkinStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Set Border Skin
			Chart1.BorderSkin.SkinStyle = (System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle)System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Parse(typeof(System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle), SkinStyle.SelectedItem.ToString());
			
			// disable controls
			this.ChartForeColor.Enabled = this.IsFrameStyle();
			this.ChartBackColor.Enabled = this.IsFrameStyle();
			this.Gradient.Enabled		= this.IsFrameStyle();
			this.HatchStyle.Enabled 	= this.IsFrameStyle();
			
			this.SkinItems_Changed( sender, e );
			this.Border_Changed( sender, e );
		}


		private void SkinItems_Changed(object sender, System.EventArgs e)
		{
			
			if ( this.initialising )
			{
				return;
			}

			// Set Fore Color
			Chart1.BorderSkin.BackSecondaryColor = Color.FromName(ChartForeColor.SelectedItem.ToString());		

			// Set Back Color
			Chart1.BorderSkin.BackColor = Color.FromName(ChartBackColor.SelectedItem.ToString());

			// Set Gradient Type
			Chart1.BorderSkin.BackGradientStyle = (System.Windows.Forms.DataVisualization.Charting.GradientStyle)System.Windows.Forms.DataVisualization.Charting.GradientStyle.Parse(typeof(System.Windows.Forms.DataVisualization.Charting.GradientStyle), Gradient.SelectedItem.ToString());

			// Disable hatch if gradient is active
			if( Chart1.BorderSkin.BackGradientStyle != System.Windows.Forms.DataVisualization.Charting.GradientStyle.None )
				this.HatchStyle.SelectedIndex = 0;

			// Set Hatch Style
			Chart1.BorderSkin.BackHatchStyle = (System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Parse(typeof(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle), HatchStyle.SelectedItem.ToString());

			// Disable gradient if hatch style is active
			if( Chart1.BorderSkin.BackHatchStyle != System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.None )
				this.Gradient.SelectedIndex = 0;		

		}

		private void Border_Changed(object sender, System.EventArgs e)
		{
			if ( this.initialising )
			{
				return;
			}

			System.Windows.Forms.DataVisualization.Charting.ChartDashStyle style = (System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Parse(typeof(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle), BorderDashStyle.SelectedItem.ToString());
			
			// set default appearance
			Chart1.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			Chart1.BorderSkin.BorderColor = Color.Empty;
			Chart1.BorderSkin.BorderWidth = 1;

			Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			Chart1.BorderlineColor = Color.Empty;
			Chart1.BorderlineWidth = 1;

			if ( this.IsFrameStyle() )
			{
				// Set Border Style
				Chart1.BorderSkin.BorderDashStyle = style;
				// Set Border Color
				Chart1.BorderSkin.BorderColor = Color.FromName(BorderColor.SelectedItem.ToString());
				// Set Border Width
				Chart1.BorderSkin.BorderWidth = int.Parse(BorderSize.SelectedItem.ToString());
			}
			else
			{
				// Set Border Style
				Chart1.BorderlineDashStyle = style;
				// Set Border Color
				Chart1.BorderlineColor = Color.FromName(BorderColor.SelectedItem.ToString());
				// Set Border Width
				Chart1.BorderlineWidth = int.Parse(BorderSize.SelectedItem.ToString());
			}
		}
	}
}
