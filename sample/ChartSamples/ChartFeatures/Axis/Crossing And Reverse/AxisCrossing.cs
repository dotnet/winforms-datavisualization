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
	/// Summary description for AxisCrossing.
	/// </summary>
	public class AxisCrossing : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.ComboBox CrossingX;
		private System.Windows.Forms.ComboBox ChartTypes;
		private System.Windows.Forms.ComboBox CrossingY;
		private System.Windows.Forms.CheckBox ReverseYCheck;
		private System.Windows.Forms.CheckBox ReverseXCheck;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AxisCrossing()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			this.CrossingY.SelectedIndex = 0;
			this.CrossingX.SelectedIndex = 0;
			this.ChartTypes.SelectedIndex = 0;

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
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 550);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 900);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1800);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 700);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1500);
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 900);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1800);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1400);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1600);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2000);
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1800);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2400);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 800);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2200);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 550);
			this.CrossingX = new System.Windows.Forms.ComboBox();
			this.ChartTypes = new System.Windows.Forms.ComboBox();
			this.CrossingY = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ReverseYCheck = new System.Windows.Forms.CheckBox();
			this.ReverseXCheck = new System.Windows.Forms.CheckBox();
			this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// CrossingX
			// 
			this.CrossingX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CrossingX.Items.AddRange(new object[] {
														   "Auto",
														   "1",
														   "3",
														   "5",
														   "Max",
														   "Min"});
			this.CrossingX.Location = new System.Drawing.Point(168, 8);
			this.CrossingX.Name = "CrossingX";
			this.CrossingX.TabIndex = 4;
			this.CrossingX.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
			// 
			// ChartTypes
			// 
			this.ChartTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ChartTypes.Items.AddRange(new object[] {
															"Column",
															"Bar"});
			this.ChartTypes.Location = new System.Drawing.Point(168, 72);
			this.ChartTypes.Name = "ChartTypes";
			this.ChartTypes.TabIndex = 8;
			this.ChartTypes.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
			// 
			// CrossingY
			// 
			this.CrossingY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CrossingY.Items.AddRange(new object[] {
														   "Auto",
														   "1000",
														   "1500",
														   "2000",
														   "Max",
														   "Min"});
			this.CrossingY.Location = new System.Drawing.Point(168, 40);
			this.CrossingY.Name = "CrossingY";
			this.CrossingY.TabIndex = 6;
			this.CrossingY.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(148, 16);
			this.label5.TabIndex = 3;
			this.label5.Text = "Crossing &X:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(148, 16);
			this.label7.TabIndex = 7;
			this.label7.Text = "Chart &Type:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(148, 16);
			this.label8.TabIndex = 5;
			this.label8.Text = "Crossing &Y:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(702, 34);
			this.label9.TabIndex = 1;
			this.label9.Text = "This sample demonstrates how to use the Crossing and Reverse properties of an axi" +
				"s.";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.ReverseYCheck,
																				 this.ReverseXCheck,
																				 this.label5,
																				 this.CrossingX,
																				 this.label7,
																				 this.label8,
																				 this.CrossingY,
																				 this.ChartTypes});
			this.panel1.Location = new System.Drawing.Point(432, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 288);
			this.panel1.TabIndex = 0;
			// 
			// ReverseYCheck
			// 
			this.ReverseYCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ReverseYCheck.Location = new System.Drawing.Point(14, 136);
			this.ReverseYCheck.Name = "ReverseYCheck";
			this.ReverseYCheck.Size = new System.Drawing.Size(168, 24);
			this.ReverseYCheck.TabIndex = 0;
			this.ReverseYCheck.Text = "R&everse Y Axis:";
			this.ReverseYCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ReverseYCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
			// 
			// ReverseXCheck
			// 
			this.ReverseXCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ReverseXCheck.Location = new System.Drawing.Point(14, 104);
			this.ReverseXCheck.Name = "ReverseXCheck";
			this.ReverseXCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ReverseXCheck.Size = new System.Drawing.Size(168, 24);
			this.ReverseXCheck.TabIndex = 9;
			this.ReverseXCheck.Text = "&Reverse X Axis:";
			this.ReverseXCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ReverseXCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
			// 
			// Chart1
			// 
			this.Chart1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(243)), ((System.Byte)(223)), ((System.Byte)(193)));
			this.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(181)), ((System.Byte)(64)), ((System.Byte)(1)));
			this.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			this.Chart1.BorderlineWidth = 2;
			this.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LabelStyle.Format = "N0";
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.AxisX2.MajorGrid.Enabled = false;
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.AxisY2.MajorGrid.Enabled = false;
			chartArea1.BackColor = System.Drawing.Color.OldLace;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			this.Chart1.ChartAreas.Add(chartArea1);
			legend1.Alignment = System.Drawing.StringAlignment.Far;
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.Enabled = false;
			legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
			legend1.Name = "Default";
			this.Chart1.Legends.Add(legend1);
			this.Chart1.Location = new System.Drawing.Point(16, 48);
			this.Chart1.Name = "Chart1";
			this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.Name = "Default";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series2.Name = "Series2";
			series2.Points.Add(dataPoint6);
			series2.Points.Add(dataPoint7);
			series2.Points.Add(dataPoint8);
			series2.Points.Add(dataPoint9);
			series2.Points.Add(dataPoint10);
			series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series3.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series3.Name = "Series3";
			series3.Points.Add(dataPoint11);
			series3.Points.Add(dataPoint12);
			series3.Points.Add(dataPoint13);
			series3.Points.Add(dataPoint14);
			series3.Points.Add(dataPoint15);
			series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			this.Chart1.Series.Add(series1);
			this.Chart1.Series.Add(series2);
			this.Chart1.Series.Add(series3);
			this.Chart1.Size = new System.Drawing.Size(412, 296);
			this.Chart1.TabIndex = 2;
			// 
			// AxisCrossing
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.Chart1,
																		  this.panel1,
																		  this.label9});
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "AxisCrossing";
			this.Size = new System.Drawing.Size(728, 480);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		private void AxisCrossing_Load(object sender, System.EventArgs e)
		{ 
		
		}

		private void ControlChange(object sender, System.EventArgs e)
		{

			System.Windows.Forms.DataVisualization.Charting.Axis AxisX;
			System.Windows.Forms.DataVisualization.Charting.Axis AxisY;

			AxisX = Chart1.ChartAreas["Default"].AxisX;
			AxisY = Chart1.ChartAreas["Default"].AxisY;

			// Set Crossing value for X axis
			if(this.CrossingX.SelectedIndex >= 0)
			{
				string sel = CrossingX.SelectedItem.ToString();
				switch (sel)
				{
					case "Auto":
						AxisX.Crossing = Double.NaN;
						break;
					case "Max":
						AxisX.Crossing = Double.MaxValue;
						break;
					case "Min":
						AxisX.Crossing = Double.MinValue;
						break;
					default:
						AxisX.Crossing = Double.Parse( this.CrossingX.SelectedItem.ToString() );
						break;
				}
			}

			// Set Reverse value for X axis
			AxisX.IsReversed = ReverseXCheck.Checked;

			// Set Crossing value for Y axis
			if(this.CrossingY.SelectedIndex >= 0)
			{
				string sel = CrossingY.SelectedItem.ToString();

				switch(sel)
				{
					case "Auto":
						AxisY.Crossing = Double.NaN;
						break;
					case "Max":
						AxisY.Crossing = Double.MaxValue;
						break;
					case "Min":
						AxisY.Crossing = Double.MinValue;
						break;
					default:
						AxisY.Crossing = Double.Parse( this.CrossingY.SelectedItem.ToString() );
						break;
				}
			}

			// Set Reverse value for Y axis
			AxisY.IsReversed = ReverseYCheck.Checked;
			
			foreach( Series series in Chart1.Series)
			{
				if(this.ChartTypes.SelectedIndex >= 0)
				{
					series.ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), this.ChartTypes.SelectedItem.ToString(), true );
				}
				else
				{
					series.ChartType = SeriesChartType.Column;
				}
			}


		}

	}
}
