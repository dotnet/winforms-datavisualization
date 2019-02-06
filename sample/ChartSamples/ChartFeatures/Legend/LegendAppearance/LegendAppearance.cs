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
	public class LegendAppearance : System.Windows.Forms.UserControl
	{
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
		private System.Windows.Forms.ComboBox ShadowOffset;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LegendAppearance()
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

			// Add Border styles to control.
			foreach(string colorName in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)))
			{
				this.BorderDashStyle.Items.Add(colorName);
			}
			this.BorderDashStyle.SelectedIndex = this.BorderDashStyle.Items.IndexOf("Solid");


			this.ChartBackColor.SelectedIndex = 0;
			this.ChartForeColor.SelectedIndex = this.BorderColor.Items.IndexOf("Green");;
			this.BorderColor.SelectedIndex = this.BorderColor.Items.IndexOf("Gray");

			this.BorderSize.SelectedIndex = 0;
			this.ShadowOffset.SelectedIndex = 0;

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
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.ChartBackColor = new System.Windows.Forms.ComboBox();
			this.ShadowOffset = new System.Windows.Forms.ComboBox();
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
			this.ChartBackColor.Items.AddRange(new object[] {
																"Transparent",
																"White",
																"Blue",
																"Red",
																"Green",
																"Yellow",
																"Maroon",
																"Gray",
																"Gainsboro"});
			this.ChartBackColor.Location = new System.Drawing.Point(168, 8);
			this.ChartBackColor.Name = "ChartBackColor";
			this.ChartBackColor.TabIndex = 3;
			this.ChartBackColor.SelectedIndexChanged += new System.EventHandler(this.BackColor_SelectedIndexChanged);
			// 
			// ShadowOffset
			// 
			this.ShadowOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ShadowOffset.Items.AddRange(new object[] {
															  "0",
															  "1",
															  "2",
															  "3",
															  "4",
															  "5"});
			this.ShadowOffset.Location = new System.Drawing.Point(168, 248);
			this.ShadowOffset.Name = "ShadowOffset";
			this.ShadowOffset.TabIndex = 15;
			this.ShadowOffset.SelectedIndexChanged += new System.EventHandler(this.ShadowOffset_SelectedIndexChanged);
			// 
			// ChartForeColor
			// 
			this.ChartForeColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ChartForeColor.Items.AddRange(new object[] {
																"Transparent",
																"White",
																"Blue",
																"Red",
																"Green",
																"Yellow",
																"Maroon",
																"Gray",
																"Gainsboro"});
			this.ChartForeColor.Location = new System.Drawing.Point(168, 104);
			this.ChartForeColor.Name = "ChartForeColor";
			this.ChartForeColor.TabIndex = 1;
			this.ChartForeColor.SelectedIndexChanged += new System.EventHandler(this.ChartForeColor_SelectedIndexChanged);
			// 
			// HatchStyle
			// 
			this.HatchStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.HatchStyle.Location = new System.Drawing.Point(168, 72);
			this.HatchStyle.Name = "HatchStyle";
			this.HatchStyle.TabIndex = 7;
			this.HatchStyle.SelectedIndexChanged += new System.EventHandler(this.HatchStyle_SelectedIndexChanged);
			// 
			// Gradient
			// 
			this.Gradient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Gradient.Location = new System.Drawing.Point(168, 40);
			this.Gradient.Name = "Gradient";
			this.Gradient.TabIndex = 5;
			this.Gradient.SelectedIndexChanged += new System.EventHandler(this.Gradient_SelectedIndexChanged);
			// 
			// BorderColor
			// 
			this.BorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BorderColor.Items.AddRange(new object[] {
															 "Transparent",
															 "Black",
															 "White",
															 "Blue",
															 "Red",
															 "Green",
															 "Yellow",
															 "Maroon",
															 "Gray",
															 "Gainsboro"});
			this.BorderColor.Location = new System.Drawing.Point(168, 144);
			this.BorderColor.Name = "BorderColor";
			this.BorderColor.TabIndex = 11;
			this.BorderColor.SelectedIndexChanged += new System.EventHandler(this.BorderColor_SelectedIndexChanged);
			// 
			// BorderDashStyle
			// 
			this.BorderDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BorderDashStyle.Location = new System.Drawing.Point(168, 176);
			this.BorderDashStyle.Name = "BorderDashStyle";
			this.BorderDashStyle.TabIndex = 9;
			this.BorderDashStyle.SelectedIndexChanged += new System.EventHandler(this.BorderDashStyle_SelectedIndexChanged);
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
			this.BorderSize.Location = new System.Drawing.Point(168, 208);
			this.BorderSize.Name = "BorderSize";
			this.BorderSize.TabIndex = 13;
			this.BorderSize.SelectedIndexChanged += new System.EventHandler(this.BorderSize_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 253);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Shadow &Offset:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "&Secondary Back Color:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(11, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "&Back Color:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(156, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "&Gradient:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(156, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "&Hatch Style:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 184);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(156, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "&Border Style:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(156, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "B&order Color:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(12, 216);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(156, 13);
			this.label8.TabIndex = 12;
			this.label8.Text = "Bo&rder Size:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(702, 34);
			this.label9.TabIndex = 0;
			this.label9.Text = "This sample demonstrates how to set the appearance of the legend.";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.BorderDashStyle,
																				 this.label5,
																				 this.Gradient,
																				 this.label6,
																				 this.label4,
																				 this.HatchStyle,
																				 this.label7,
																				 this.label3,
																				 this.ShadowOffset,
																				 this.label1,
																				 this.label2,
																				 this.label8,
																				 this.BorderSize,
																				 this.ChartBackColor,
																				 this.ChartForeColor,
																				 this.BorderColor});
			this.panel1.Location = new System.Drawing.Point(432, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 296);
			this.panel1.TabIndex = 2;
			// 
			// Chart1
			// 
			this.Chart1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Chart1.BackSecondaryColor = System.Drawing.Color.White;
			this.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			this.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			this.Chart1.BorderlineWidth = 2;
			this.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Enable3D = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.PointGapDepth = 0;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 5;
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
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.Position.Auto = false;
			chartArea1.Position.Height = 75F;
			chartArea1.Position.Width = 100F;
			chartArea1.Position.Y = 8F;
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			this.Chart1.ChartAreas.Add(chartArea1);
			legend1.Alignment = System.Drawing.StringAlignment.Center;
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.IsDockedInsideChartArea = false;
			legend1.DockedToChartArea = "Default";
			legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
			legend1.Name = "Default";
			this.Chart1.Legends.Add(legend1);
			this.Chart1.Location = new System.Drawing.Point(16, 48);
			this.Chart1.Name = "Chart1";
			this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartArea = "Default";
			series1.Color = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(65)), ((System.Byte)(140)), ((System.Byte)(240)));
			series1.CustomProperties = "DrawingStyle=Cylinder";
			series1.Name = "Total";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.ShadowColor = System.Drawing.Color.Transparent;
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			series2.ChartArea = "Default";
			series2.Color = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(252)), ((System.Byte)(180)), ((System.Byte)(65)));
			series2.CustomProperties = "DrawingStyle=Cylinder";
			series2.Name = "Last Week";
			series2.Points.Add(dataPoint5);
			series2.Points.Add(dataPoint6);
			series2.Points.Add(dataPoint7);
			series2.Points.Add(dataPoint8);
			series3.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			series3.ChartArea = "Default";
			series3.Color = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(224)), ((System.Byte)(64)), ((System.Byte)(10)));
			series3.CustomProperties = "DrawingStyle=Cylinder";
			series3.Name = "This Week";
			series3.Points.Add(dataPoint9);
			series3.Points.Add(dataPoint10);
			series3.Points.Add(dataPoint11);
			series3.Points.Add(dataPoint12);
			this.Chart1.Series.Add(series1);
			this.Chart1.Series.Add(series2);
			this.Chart1.Series.Add(series3);
			this.Chart1.Size = new System.Drawing.Size(412, 296);
			this.Chart1.TabIndex = 1;
			title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
			title1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
			title1.Position.Auto = false;
			title1.Position.Height = 8.738057F;
			title1.Position.Width = 80F;
			title1.Position.X = 5F;
			title1.Position.Y = 4F;
			title1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(32)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			title1.ShadowOffset = 3;
			title1.Text = "Chart Control for .NET Framework";
			this.Chart1.Titles.Add(title1);
			// 
			// LegendAppearance
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.Chart1,
																		  this.panel1,
																		  this.label9});
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "LegendAppearance";
			this.Size = new System.Drawing.Size(728, 480);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void ShadowOffset_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Set Border Skin
			Chart1.Legends["Default"].ShadowOffset = int.Parse(ShadowOffset.SelectedItem.ToString());
		}

		private void ChartForeColor_SelectedIndexChanged(object sender, System.EventArgs e)
		{
				// Set Fore Color
			Chart1.Legends["Default"].BackSecondaryColor = Color.FromName(ChartForeColor.SelectedItem.ToString());
		}

		private void BackColor_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Set Back Color
			Chart1.Legends["Default"].BackColor = Color.FromName(ChartBackColor.SelectedItem.ToString());
		}

		private void Gradient_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Set Gradient Type
			Chart1.Legends["Default"].BackGradientStyle = (System.Windows.Forms.DataVisualization.Charting.GradientStyle)System.Windows.Forms.DataVisualization.Charting.GradientStyle.Parse(typeof(System.Windows.Forms.DataVisualization.Charting.GradientStyle), Gradient.SelectedItem.ToString());

			// Disable hatch if gradient is active
			if( Chart1.Legends["Default"].BackGradientStyle != System.Windows.Forms.DataVisualization.Charting.GradientStyle.None )
				this.HatchStyle.SelectedIndex = 0;
		
		}

		private void HatchStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
			// Set Hatch Style
			Chart1.Legends["Default"].BackHatchStyle = (System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Parse(typeof(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle), HatchStyle.SelectedItem.ToString());

			// Disable gradient if hatch style is active
			if( Chart1.Legends["Default"].BackHatchStyle != System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.None )
				this.Gradient.SelectedIndex = 0;		
		}

		private void BorderDashStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Set Border Style
			Chart1.Legends["Default"].BorderDashStyle = (System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Parse(typeof(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle), BorderDashStyle.SelectedItem.ToString());
		}

		private void BorderColor_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Set Border Color
			Chart1.Legends["Default"].BorderColor = Color.FromName(BorderColor.SelectedItem.ToString());
		}

		private void BorderSize_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Set Border Width
			Chart1.Legends["Default"].BorderWidth = int.Parse(BorderSize.SelectedItem.ToString());
		}
	}
}
