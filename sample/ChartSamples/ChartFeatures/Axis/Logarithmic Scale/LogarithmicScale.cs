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
	/// Summary description for AxisScale.
	/// </summary>
	public class LogarithmicScale : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox Base;
		private System.Windows.Forms.ComboBox MinorInterval;
		private System.Windows.Forms.CheckBox Logaritmic;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox MajorInterval;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LogarithmicScale()
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
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 400);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2600);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1700);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3000);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 200);
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1600);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2400);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2500);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2800);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1000);
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2100);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2100);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3200);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2500);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1500);
			this.label9 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.MajorInterval = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.MinorInterval = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Base = new System.Windows.Forms.ComboBox();
			this.Logaritmic = new System.Windows.Forms.CheckBox();
			this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 14);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(702, 34);
			this.label9.TabIndex = 0;
			this.label9.Text = "This sample demonstrates how to use a logarithmic scale and a logarithmic base.";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label3,
																				 this.MajorInterval,
																				 this.label2,
																				 this.MinorInterval,
																				 this.label1,
																				 this.Base,
																				 this.Logaritmic});
			this.panel1.Location = new System.Drawing.Point(432, 68);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 288);
			this.panel1.TabIndex = 2;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(4, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Ma&jor Interval:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MajorInterval
			// 
			this.MajorInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MajorInterval.Items.AddRange(new object[] {
															   "1",
															   "2",
															   "3"});
			this.MajorInterval.Location = new System.Drawing.Point(168, 64);
			this.MajorInterval.Name = "MajorInterval";
			this.MajorInterval.Size = new System.Drawing.Size(112, 22);
			this.MajorInterval.TabIndex = 4;
			this.MajorInterval.SelectedIndexChanged += new System.EventHandler(this.MajorInterval_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(4, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Mi&nor Interval:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MinorInterval
			// 
			this.MinorInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MinorInterval.Items.AddRange(new object[] {
															   "1",
															   "2",
															   "5"});
			this.MinorInterval.Location = new System.Drawing.Point(168, 96);
			this.MinorInterval.Name = "MinorInterval";
			this.MinorInterval.Size = new System.Drawing.Size(112, 22);
			this.MinorInterval.TabIndex = 6;
			this.MinorInterval.SelectedIndexChanged += new System.EventHandler(this.MinorInterval_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Logarithmic &Base:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Base
			// 
			this.Base.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Base.Items.AddRange(new object[] {
													  "10",
													  "2",
													  "e"});
			this.Base.Location = new System.Drawing.Point(168, 32);
			this.Base.Name = "Base";
			this.Base.Size = new System.Drawing.Size(112, 22);
			this.Base.TabIndex = 2;
			this.Base.SelectedIndexChanged += new System.EventHandler(this.Base_SelectedIndexChanged);
			// 
			// Logaritmic
			// 
			this.Logaritmic.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Logaritmic.Location = new System.Drawing.Point(12, 8);
			this.Logaritmic.Name = "Logaritmic";
			this.Logaritmic.Size = new System.Drawing.Size(168, 16);
			this.Logaritmic.TabIndex = 0;
			this.Logaritmic.Text = "&Logarithmic:";
			this.Logaritmic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Logaritmic.CheckedChanged += new System.EventHandler(this.Logaritmic_CheckedChanged);
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
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LabelStyle.Format = "N0";
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.AxisX2.MajorGrid.Enabled = false;
			chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LabelStyle.Format = "N0";
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
            chartArea1.AxisY.MinorGrid.Enabled = true;
			chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.AxisY2.MajorGrid.Enabled = false;
			chartArea1.BackColor = System.Drawing.Color.Gainsboro;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			this.Chart1.ChartAreas.Add(chartArea1);
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Enabled = false;
			legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			this.Chart1.Legends.Add(legend1);
			this.Chart1.Location = new System.Drawing.Point(16, 60);
			this.Chart1.Name = "Chart1";
			this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.Name = "Series1";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series2.Name = "Series2";
			series2.Points.Add(dataPoint6);
			series2.Points.Add(dataPoint7);
			series2.Points.Add(dataPoint8);
			series2.Points.Add(dataPoint9);
			series2.Points.Add(dataPoint10);
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
			this.Chart1.Click += new System.EventHandler(this.Chart1_Click);
			// 
			// LogarithmicScale
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.Chart1,
																		  this.panel1,
																		  this.label9});
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "LogarithmicScale";
			this.Size = new System.Drawing.Size(728, 480);
			this.Load += new System.EventHandler(this.LogarithmicScale_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void LogarithmicScale_Load(object sender, System.EventArgs e)
		{
			// Initialize combo boxes
			this.Base.SelectedIndex = 0;
			this.MajorInterval.SelectedIndex = 0;
			this.MinorInterval.SelectedIndex = 0;
		}

		private void SetData()
		{
			// If the Major Interval is not set get out
			if( this.MajorInterval.Text == "" )
			{
				return;
			}
			
			// The logarithmic scale is enabled
			if( this.Logaritmic.Checked == true )
			{

				// Enable combo boxes
				this.Base.Enabled = true;
				this.MajorInterval.Enabled = true;
				this.MinorInterval.Enabled = true;

				// Enable logarithmic scale
				Chart1.ChartAreas[0].AxisY.IsLogarithmic = true;

				// Set logarithmic base
				if( this.Base.Text == "10" || this.Base.Text == "2" )
				{
					Chart1.ChartAreas[0].AxisY.LogarithmBase = double.Parse( this.Base.Text );
				}
				else
				{
					Chart1.ChartAreas[0].AxisY.LogarithmBase = Math.E;
				}	

				// Set the interval for the axis and minor intervals 
				// for gridlines and tick marks.
				if( this.Base.Text == "10" && this.Logaritmic.Checked == true )
				{
					this.MinorInterval.Enabled = true;
					Chart1.ChartAreas[0].AxisY.Interval = double.Parse( this.MajorInterval.Text );
					Chart1.ChartAreas[0].AxisY.MinorTickMark.Interval = double.Parse( this.MinorInterval.Text );
					Chart1.ChartAreas[0].AxisY.MinorGrid.Interval = double.Parse( this.MinorInterval.Text );
					Chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = true;
					Chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled = true;
				}
				else
				{
					this.MinorInterval.Enabled = false;
					Chart1.ChartAreas[0].AxisY.Interval = double.Parse( this.MajorInterval.Text );
					Chart1.ChartAreas[0].AxisY.MinorTickMark.Interval = 0;
					Chart1.ChartAreas[0].AxisY.MinorGrid.Interval = 0;
					Chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
					Chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled = false;
				}
			}
			else
			{
				// Logarithmic axis are disabled
				Chart1.ChartAreas[0].AxisY.IsLogarithmic = false;
				this.Base.Enabled = false;
				this.MajorInterval.Enabled = false;
				this.MinorInterval.Enabled = false;				
				Chart1.ChartAreas[0].AxisY.MinorGrid.Interval = 0;
				Chart1.ChartAreas[0].AxisY.MinorTickMark.Interval = 0;
				Chart1.ChartAreas[0].AxisY.LogarithmBase = 10;
				Chart1.ChartAreas[0].AxisY.Interval = 0;
				Chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = true;
				Chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled = true;
			}
		}

		private void Chart1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void Logaritmic_CheckedChanged(object sender, System.EventArgs e)
		{
			SetData();
		}

		private void Base_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetData();
		}

		private void MinorInterval_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetData();
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void MajorInterval_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetData();
		}

	}
}
