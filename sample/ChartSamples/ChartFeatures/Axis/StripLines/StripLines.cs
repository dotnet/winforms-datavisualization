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
	/// Summary description for StripLines.
	/// </summary>
	public class StripLines : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.ComboBox StripEndColor;
		private System.Windows.Forms.ComboBox StripColor;
		private System.Windows.Forms.ComboBox LineColor;
		private System.Windows.Forms.ComboBox LineWidth;
		private System.Windows.Forms.ComboBox Interval;
		private System.Windows.Forms.ComboBox HatchStyle;
		private System.Windows.Forms.ComboBox Gradient;
		private System.Windows.Forms.ComboBox StripLinesStyle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public StripLines()
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
			this.Gradient.SelectedIndex = 1;

	
			// Add Border styles to control.
			foreach(string colorName in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)))
			{
				this.StripLinesStyle.Items.Add(colorName);
			}
			this.StripLinesStyle.SelectedIndex = 5;

			this.StripColor.SelectedIndex = 0;
			this.StripEndColor.SelectedIndex = 0;
			this.LineColor.SelectedIndex = 0;
			this.LineWidth.SelectedIndex = 0;
			this.Interval.SelectedIndex = 3;

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
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 700);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 400);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 200);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 450);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 300);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 245);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 568);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 345);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 789);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 834);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 382);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 599);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 123);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 223);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.StripEndColor = new System.Windows.Forms.ComboBox();
            this.StripColor = new System.Windows.Forms.ComboBox();
            this.HatchStyle = new System.Windows.Forms.ComboBox();
            this.Gradient = new System.Windows.Forms.ComboBox();
            this.LineColor = new System.Windows.Forms.ComboBox();
            this.StripLinesStyle = new System.Windows.Forms.ComboBox();
            this.LineWidth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Interval = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // StripEndColor
            // 
            this.StripEndColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StripEndColor.Items.AddRange(new object[] {
            "DarkRed",
            "Green",
            "Yellow",
            "SlateGray",
            "Gold"});
            this.StripEndColor.Location = new System.Drawing.Point(168, 120);
            this.StripEndColor.Name = "StripEndColor";
            this.StripEndColor.Size = new System.Drawing.Size(121, 22);
            this.StripEndColor.TabIndex = 9;
            this.StripEndColor.SelectedIndexChanged += new System.EventHandler(this.ControlChanged);
            // 
            // StripColor
            // 
            this.StripColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StripColor.Items.AddRange(new object[] {
            "Red",
            "Gainsboro",
            "Khaki",
            "LightSteelBlue"});
            this.StripColor.Location = new System.Drawing.Point(168, 48);
            this.StripColor.Name = "StripColor";
            this.StripColor.Size = new System.Drawing.Size(121, 22);
            this.StripColor.TabIndex = 3;
            this.StripColor.SelectedIndexChanged += new System.EventHandler(this.ControlChanged);
            // 
            // HatchStyle
            // 
            this.HatchStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HatchStyle.Location = new System.Drawing.Point(168, 96);
            this.HatchStyle.Name = "HatchStyle";
            this.HatchStyle.Size = new System.Drawing.Size(121, 22);
            this.HatchStyle.TabIndex = 7;
            this.HatchStyle.SelectedIndexChanged += new System.EventHandler(this.HatchControlChanged);
            // 
            // Gradient
            // 
            this.Gradient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gradient.Location = new System.Drawing.Point(168, 72);
            this.Gradient.Name = "Gradient";
            this.Gradient.Size = new System.Drawing.Size(121, 22);
            this.Gradient.TabIndex = 5;
            this.Gradient.SelectedIndexChanged += new System.EventHandler(this.GradienControlChanged);
            // 
            // LineColor
            // 
            this.LineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LineColor.Items.AddRange(new object[] {
            "MidnightBlue",
            "Green",
            "Black",
            "Red"});
            this.LineColor.Location = new System.Drawing.Point(168, 184);
            this.LineColor.Name = "LineColor";
            this.LineColor.Size = new System.Drawing.Size(121, 22);
            this.LineColor.TabIndex = 13;
            this.LineColor.SelectedIndexChanged += new System.EventHandler(this.ControlChanged);
            // 
            // StripLinesStyle
            // 
            this.StripLinesStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StripLinesStyle.Location = new System.Drawing.Point(168, 160);
            this.StripLinesStyle.Name = "StripLinesStyle";
            this.StripLinesStyle.Size = new System.Drawing.Size(121, 22);
            this.StripLinesStyle.TabIndex = 11;
            this.StripLinesStyle.SelectedIndexChanged += new System.EventHandler(this.ControlChanged);
            // 
            // LineWidth
            // 
            this.LineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LineWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.LineWidth.Location = new System.Drawing.Point(168, 208);
            this.LineWidth.Name = "LineWidth";
            this.LineWidth.Size = new System.Drawing.Size(121, 22);
            this.LineWidth.TabIndex = 15;
            this.LineWidth.SelectedIndexChanged += new System.EventHandler(this.ControlChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Back &Color:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "S&econdary Back Color:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Gradient Style:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "&Hatch Style:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Border &Style:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(18, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "&Border Color:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to set the appearance properties of the StripLine ob" +
                "ject.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Interval);
            this.panel1.Controls.Add(this.StripLinesStyle);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Gradient);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.HatchStyle);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LineWidth);
            this.panel1.Controls.Add(this.StripEndColor);
            this.panel1.Controls.Add(this.StripColor);
            this.panel1.Controls.Add(this.LineColor);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 296);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strip &Interval:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Interval
            // 
            this.Interval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Interval.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.Interval.Location = new System.Drawing.Point(168, 8);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(121, 22);
            this.Interval.TabIndex = 1;
            this.Interval.SelectedIndexChanged += new System.EventHandler(this.ControlChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(18, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Border Si&ze:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            stripLine1.BackColor = System.Drawing.Color.Gainsboro;
            stripLine1.Interval = 2;
            stripLine1.IntervalOffset = 0.5;
            stripLine1.StripWidth = 1;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.Chart1.Location = new System.Drawing.Point(16, 48);
            this.Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Default";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series1.MarkerSize = 8;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Default";
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
            series1.Points.Add(dataPoint12);
            series1.Points.Add(dataPoint13);
            series1.Points.Add(dataPoint14);
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(412, 306);
            this.Chart1.TabIndex = 1;
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Strip Lines";
            this.Chart1.Titles.Add(title1);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(702, 34);
            this.label10.TabIndex = 3;
            this.label10.Text = "Chart interlaced strip lines can also be enabled setting the Axis.IsInterlaced pr" +
                "operty.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StripLines
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StripLines";
            this.Size = new System.Drawing.Size(728, 424);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void ControlChanged(object sender, System.EventArgs e)
		{
			if(this.StripEndColor.SelectedIndex >= 0)
			{
				this.Chart1.ChartAreas[0].AxisX.StripLines[0].BackSecondaryColor =
					Color.FromName(this.StripEndColor.SelectedItem.ToString());
			}

			if(this.StripColor.SelectedIndex >= 0)
			{
				this.Chart1.ChartAreas[0].AxisX.StripLines[0].BackColor =
					Color.FromName(this.StripColor.SelectedItem.ToString());
			}

			if(this.LineColor.SelectedIndex >= 0)
			{
				this.Chart1.ChartAreas[0].AxisX.StripLines[0].BorderColor =
					Color.FromName(this.LineColor.SelectedItem.ToString());
			}

			if(this.LineWidth.SelectedIndex >= 0)
			{
				this.Chart1.ChartAreas[0].AxisX.StripLines[0].BorderWidth =
					int.Parse(this.LineWidth.SelectedItem.ToString());
			}

			if(this.Interval.SelectedIndex >= 0)
			{
				this.Chart1.ChartAreas[0].AxisX.StripLines[0].Interval = 
					int.Parse(this.Interval.SelectedItem.ToString());
			}

			if(this.HatchStyle.SelectedIndex >= 0)
			{
				// Set Hatch Style
				this.Chart1.ChartAreas[0].AxisX.StripLines[0].BackHatchStyle = 
					(ChartHatchStyle)ChartHatchStyle.Parse(typeof(ChartHatchStyle), this.HatchStyle.SelectedItem.ToString());

			}

			if(this.Gradient.SelectedIndex >= 0)
			{
				// Set Gradient Type
				this.Chart1.ChartAreas[0].AxisX.StripLines[0].BackGradientStyle = 
					(GradientStyle)GradientStyle.Parse(typeof(GradientStyle), this.Gradient.SelectedItem.ToString());

			}

			if(this.StripLinesStyle.SelectedIndex >= 0)
			{
				this.Chart1.ChartAreas[0].AxisX.StripLines[0].BorderDashStyle = 
					(ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), this.StripLinesStyle.SelectedItem.ToString());
			}

			// Enable/disable attribute	contros
			StripEndColor.Enabled = (Gradient.SelectedIndex != 0 || HatchStyle.SelectedIndex != 0);
			LineColor.Enabled = (StripLinesStyle.SelectedIndex != 0);
			LineWidth.Enabled = (StripLinesStyle.SelectedIndex != 0);
		}

		private void GradienControlChanged(object sender, System.EventArgs e)
		{
			ControlChanged(sender, e);

			if( this.Chart1.ChartAreas[0].AxisX.StripLines[0].BackGradientStyle != GradientStyle.None )
				this.HatchStyle.SelectedIndex = 0;
		
		}

		private void HatchControlChanged(object sender, System.EventArgs e)
		{
			ControlChanged(sender, e);

			if( this.Chart1.ChartAreas[0].AxisX.StripLines[0].BackHatchStyle != ChartHatchStyle.None )
					this.Gradient.SelectedIndex = 0;		
	
		}
	}
}
