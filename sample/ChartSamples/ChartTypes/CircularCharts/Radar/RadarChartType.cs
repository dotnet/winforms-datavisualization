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
	/// Summary description for RadarChartType.
	/// </summary>
	public class RadarChartType : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxLabelStyle;
		private System.Windows.Forms.ComboBox comboBoxAreaStyle;
		private System.Windows.Forms.ComboBox comboBoxRadarStyle;
		private System.Windows.Forms.Label label5;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RadarChartType()
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
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.labelSampleComment = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBoxLabelStyle = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxAreaStyle = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxRadarStyle = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(243)), ((System.Byte)(223)), ((System.Byte)(193)));
			this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(181)), ((System.Byte)(64)), ((System.Byte)(1)));
			this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			this.chart1.BorderlineWidth = 2;
			this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorTickMark.Size = 0.6F;
			chartArea1.BackColor = System.Drawing.Color.OldLace;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.Position.Auto = false;
			chartArea1.Position.Height = 78F;
			chartArea1.Position.Width = 88F;
			chartArea1.Position.X = 5F;
			chartArea1.Position.Y = 15F;
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Alignment = System.Drawing.StringAlignment.Far;
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			legend1.Position.Auto = false;
			legend1.Position.Height = 14.23021F;
			legend1.Position.Width = 19.34047F;
			legend1.Position.X = 74.73474F;
			legend1.Position.Y = 74.08253F;
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(16, 56);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartType = SeriesChartType.Radar;
			series1.Color = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(65)), ((System.Byte)(140)), ((System.Byte)(240)));
			series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			series1.MarkerSize = 9;
			series1.Name = "Series1";
			series1.ShadowOffset = 1;
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
            series2.ChartType = SeriesChartType.Radar;
			series2.Color = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(252)), ((System.Byte)(180)), ((System.Byte)(65)));
			series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			series2.MarkerSize = 9;
			series2.Name = "Series2";
			series2.ShadowOffset = 1;
			this.chart1.Series.Add(series1);
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(412, 288);
			this.chart1.TabIndex = 1;
			title1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
			title1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(32)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			title1.ShadowOffset = 3;
			title1.Text = "Radar Chart";
			this.chart1.Titles.Add(title1);
			// 
			// labelSampleComment
			// 
			this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelSampleComment.Location = new System.Drawing.Point(16, 8);
			this.labelSampleComment.Name = "labelSampleComment";
			this.labelSampleComment.Size = new System.Drawing.Size(702, 42);
			this.labelSampleComment.TabIndex = 0;
			this.labelSampleComment.Text = "This sample displays a Radar chart, which is a circular graph used primarily as a" +
				" comparative tool. A 3D effect can also be added to the area background.";
			this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.comboBoxLabelStyle,
																				 this.label3,
																				 this.comboBoxAreaStyle,
																				 this.label2,
																				 this.comboBoxRadarStyle,
																				 this.label1});
			this.panel1.Location = new System.Drawing.Point(432, 72);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 272);
			this.panel1.TabIndex = 2;
			// 
			// comboBoxLabelStyle
			// 
			this.comboBoxLabelStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLabelStyle.Items.AddRange(new object[] {
																	"Circular",
																	"Radial",
																	"Horizontal"});
			this.comboBoxLabelStyle.Location = new System.Drawing.Point(168, 64);
			this.comboBoxLabelStyle.Name = "comboBoxLabelStyle";
			this.comboBoxLabelStyle.Size = new System.Drawing.Size(96, 22);
			this.comboBoxLabelStyle.TabIndex = 5;
			this.comboBoxLabelStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(19, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "&Labels Style:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxAreaStyle
			// 
			this.comboBoxAreaStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAreaStyle.Items.AddRange(new object[] {
																   "Circle",
																   "Polygon"});
			this.comboBoxAreaStyle.Location = new System.Drawing.Point(168, 32);
			this.comboBoxAreaStyle.Name = "comboBoxAreaStyle";
			this.comboBoxAreaStyle.Size = new System.Drawing.Size(96, 22);
			this.comboBoxAreaStyle.TabIndex = 3;
			this.comboBoxAreaStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "&Area Drawing Style:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxRadarStyle
			// 
			this.comboBoxRadarStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxRadarStyle.Items.AddRange(new object[] {
																	"Area",
																	"Line",
																	"Marker"});
			this.comboBoxRadarStyle.Location = new System.Drawing.Point(168, 0);
			this.comboBoxRadarStyle.Name = "comboBoxRadarStyle";
			this.comboBoxRadarStyle.Size = new System.Drawing.Size(96, 22);
			this.comboBoxRadarStyle.TabIndex = 1;
			this.comboBoxRadarStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(-14, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(177, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Radar &Style:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.label5.Font = new System.Drawing.Font("Verdana", 11F);
			this.label5.Location = new System.Drawing.Point(16, 352);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(696, 24);
			this.label5.TabIndex = 25;
			this.label5.Text = "Try different styles for the radar, area drawing and labels.";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RadarChartType
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label5,
																		  this.panel1,
																		  this.labelSampleComment,
																		  this.chart1});
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "RadarChartType";
			this.Size = new System.Drawing.Size(728, 480);
			this.Load += new System.EventHandler(this.PieChartType_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Set radar chart style
			chart1.Series["Series1"]["RadarDrawingStyle"] = (string)comboBoxRadarStyle.SelectedItem;
			chart1.Series["Series2"]["RadarDrawingStyle"] = (string)comboBoxRadarStyle.SelectedItem;
			if((string)comboBoxRadarStyle.SelectedItem == "Area")
			{
				chart1.Series["Series1"].BorderColor = Color.FromArgb(100,100,100);
				chart1.Series["Series1"].BorderWidth = 1;
				chart1.Series["Series2"].BorderColor = Color.FromArgb(100,100,100);
				chart1.Series["Series2"].BorderWidth = 1;
			}
			else if((string)comboBoxRadarStyle.SelectedItem == "Line")
			{
				chart1.Series["Series1"].BorderColor = Color.Empty;
				chart1.Series["Series1"].BorderWidth = 2;
				chart1.Series["Series2"].BorderColor = Color.Empty;
				chart1.Series["Series2"].BorderWidth = 2;
			}
			else if((string)comboBoxRadarStyle.SelectedItem == "Marker")
			{
				chart1.Series["Series1"].BorderColor = Color.Empty;
				chart1.Series["Series2"].BorderColor = Color.Empty;
			}

			// Set circular area drawing style
			chart1.Series["Series1"]["AreaDrawingStyle"] = (string)comboBoxAreaStyle.SelectedItem;
			chart1.Series["Series2"]["AreaDrawingStyle"] = (string)comboBoxAreaStyle.SelectedItem;

			// Set labels style
			chart1.Series["Series1"]["CircularLabelsStyle"] = (string)comboBoxLabelStyle.SelectedItem;
			chart1.Series["Series2"]["CircularLabelsStyle"] = (string)comboBoxLabelStyle.SelectedItem;

		}

		private void PieChartType_Load(object sender, System.EventArgs e)
		{
			// Populate series data
			double[]	yValues = {65.62, 75.54, 60.45, 34.73, 85.42, 55.9, 63.6, 55.1, 77.2};
			double[]	yValues2 = {76.45, 23.78, 86.45, 30.76, 23.79, 35.67, 89.56, 67.45, 38.98};
			string[]	xValues = {"France", "Canada", "Germany", "USA", "Italy", "Spain", "Russia", "Sweden", "Japan"};
			chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
			chart1.Series["Series2"].Points.DataBindXY(xValues, yValues2);

			// Set selection
			comboBoxRadarStyle.SelectedIndex = 0;
			comboBoxAreaStyle.SelectedIndex = 0;
			comboBoxLabelStyle.SelectedIndex = 2;

			UpdateChartSettings();	
		}

		private void comboBoxExploded_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();		
		}


	}
}
