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
	/// Summary description for LegendStylePosition.
	/// </summary>
	public class LegendStylePosition : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.ComboBox TheStyle;
		private System.Windows.Forms.ComboBox TheDocking;
		private System.Windows.Forms.ComboBox TheAlignment;
		private System.Windows.Forms.CheckBox DisableCheck;
		private System.Windows.Forms.CheckBox InsideCheck;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox TheTableStyle;
		private System.Windows.Forms.CheckBox cb_Reversed;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LegendStylePosition()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Add Border styles to control.
			foreach(string styleName in Enum.GetNames(typeof(LegendStyle)))
			{
				this.TheStyle.Items.Add(styleName);
			}
			this.TheStyle.SelectedIndex = 2;

			foreach(string dockName in Enum.GetNames(typeof(Docking)))
			{
				this.TheDocking.Items.Add(dockName);
			}
			this.TheDocking.SelectedIndex = 1;
						
			foreach(string alignName in Enum.GetNames(typeof(StringAlignment)))
			{
				this.TheAlignment.Items.Add(alignName);
			}
			this.TheAlignment.SelectedIndex = 0;

			this.TheTableStyle.SelectedIndex = 0;	
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
			System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle axisScaleBreakStyle1 = new System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle();
			System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle axisScaleBreakStyle2 = new System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle();
			System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle axisScaleBreakStyle3 = new System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle();
			System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle axisScaleBreakStyle4 = new System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 300);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 400);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 200);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 450);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 700);
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 100);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 340);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 420);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 770);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 790);
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 75);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 300);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 400);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 550);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 630);
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 120);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 360);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 410);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 520);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 560);
			this.TheStyle = new System.Windows.Forms.ComboBox();
			this.TheAlignment = new System.Windows.Forms.ComboBox();
			this.TheDocking = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cb_Reversed = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TheTableStyle = new System.Windows.Forms.ComboBox();
			this.DisableCheck = new System.Windows.Forms.CheckBox();
			this.InsideCheck = new System.Windows.Forms.CheckBox();
			this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// TheStyle
			// 
			this.TheStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TheStyle.Location = new System.Drawing.Point(168, 8);
			this.TheStyle.Name = "TheStyle";
			this.TheStyle.TabIndex = 1;
			this.TheStyle.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
			// 
			// TheAlignment
			// 
			this.TheAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TheAlignment.Location = new System.Drawing.Point(168, 104);
			this.TheAlignment.Name = "TheAlignment";
			this.TheAlignment.TabIndex = 5;
			this.TheAlignment.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
			// 
			// TheDocking
			// 
			this.TheDocking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TheDocking.Location = new System.Drawing.Point(168, 72);
			this.TheDocking.Name = "TheDocking";
			this.TheDocking.TabIndex = 3;
			this.TheDocking.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(15, 11);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(148, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "&Style:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(15, 108);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(148, 16);
			this.label7.TabIndex = 4;
			this.label7.Text = "&Alignment:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(15, 75);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(148, 16);
			this.label8.TabIndex = 2;
			this.label8.Text = "&Docking:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(704, 34);
			this.label9.TabIndex = 0;
			this.label9.Text = "This sample demonstrates how to set legend style and position within the chart.";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.cb_Reversed,
																				 this.label1,
																				 this.TheTableStyle,
																				 this.DisableCheck,
																				 this.InsideCheck,
																				 this.label5,
																				 this.TheStyle,
																				 this.label7,
																				 this.label8,
																				 this.TheDocking,
																				 this.TheAlignment});
			this.panel1.Location = new System.Drawing.Point(432, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 288);
			this.panel1.TabIndex = 2;
			// 
			// cb_Reversed
			// 
			this.cb_Reversed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cb_Reversed.Location = new System.Drawing.Point(13, 197);
			this.cb_Reversed.Name = "cb_Reversed";
			this.cb_Reversed.Size = new System.Drawing.Size(168, 24);
			this.cb_Reversed.TabIndex = 11;
			this.cb_Reversed.Text = "&Reversed:";
			this.cb_Reversed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cb_Reversed.CheckedChanged += new System.EventHandler(this.cb_Reversed_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "&Table Style:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TheTableStyle
			// 
			this.TheTableStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TheTableStyle.Enabled = false;
			this.TheTableStyle.Items.AddRange(new object[] {
															   "Auto",
															   "Wide",
															   "Tall"});
			this.TheTableStyle.Location = new System.Drawing.Point(168, 40);
			this.TheTableStyle.Name = "TheTableStyle";
			this.TheTableStyle.TabIndex = 2;
			this.TheTableStyle.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
			// 
			// DisableCheck
			// 
			this.DisableCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.DisableCheck.Location = new System.Drawing.Point(13, 167);
			this.DisableCheck.Name = "DisableCheck";
			this.DisableCheck.Size = new System.Drawing.Size(168, 24);
			this.DisableCheck.TabIndex = 8;
			this.DisableCheck.Text = "&Disable Legend:";
			this.DisableCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.DisableCheck.CheckedChanged += new System.EventHandler(this.DisableCheck_CheckedChanged);
			// 
			// InsideCheck
			// 
			this.InsideCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.InsideCheck.Location = new System.Drawing.Point(13, 136);
			this.InsideCheck.Name = "InsideCheck";
			this.InsideCheck.Size = new System.Drawing.Size(168, 24);
			this.InsideCheck.TabIndex = 6;
			this.InsideCheck.Text = "&Inside Chart Area:";
			this.InsideCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.InsideCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
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
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			axisScaleBreakStyle1.Enabled = false;
			chartArea1.AxisX.ScaleBreakStyle = axisScaleBreakStyle1;
			chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			chartArea1.AxisX2.MajorGrid.Enabled = false;
			axisScaleBreakStyle2.Enabled = false;
			chartArea1.AxisX2.ScaleBreakStyle = axisScaleBreakStyle2;
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			axisScaleBreakStyle3.Enabled = false;
			chartArea1.AxisY.ScaleBreakStyle = axisScaleBreakStyle3;
			chartArea1.AxisY2.MajorGrid.Enabled = false;
			axisScaleBreakStyle4.Enabled = false;
			chartArea1.AxisY2.ScaleBreakStyle = axisScaleBreakStyle4;
			chartArea1.BackColor = System.Drawing.Color.OldLace;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			this.Chart1.ChartAreas.Add(chartArea1);
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.Chart1.Legends.Add(legend1);
			this.Chart1.Location = new System.Drawing.Point(16, 48);
			this.Chart1.Name = "Chart1";
			this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.LegendText = "Projected";
			series1.Name = "Series 1";
			dataPoint1.Label = "";
			dataPoint2.Label = "";
			dataPoint3.Label = "";
			dataPoint4.Label = "";
			dataPoint5.Label = "";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series2.LegendText = "Actual";
			series2.Name = "Series 2";
			series2.Points.Add(dataPoint6);
			series2.Points.Add(dataPoint7);
			series2.Points.Add(dataPoint8);
			series2.Points.Add(dataPoint9);
			series2.Points.Add(dataPoint10);
			series3.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series3.BorderWidth = 2;
			series3.ChartType = SeriesChartType.Line;
			series3.LegendText = "Historical";
			series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
			series3.Name = "Series 3";
			series3.Points.Add(dataPoint11);
			series3.Points.Add(dataPoint12);
			series3.Points.Add(dataPoint13);
			series3.Points.Add(dataPoint14);
			series3.Points.Add(dataPoint15);
			series3.ShadowOffset = 1;
			series4.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series4.BorderWidth = 2;
			series4.ChartType = SeriesChartType.Line;
			series4.LegendText = "Target";
			series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
			series4.Name = "Series 4";
			series4.Points.Add(dataPoint16);
			series4.Points.Add(dataPoint17);
			series4.Points.Add(dataPoint18);
			series4.Points.Add(dataPoint19);
			series4.Points.Add(dataPoint20);
			series4.ShadowOffset = 1;
			this.Chart1.Series.Add(series1);
			this.Chart1.Series.Add(series2);
			this.Chart1.Series.Add(series3);
			this.Chart1.Series.Add(series4);
			this.Chart1.Size = new System.Drawing.Size(412, 296);
			this.Chart1.TabIndex = 1;
			// 
			// LegendStylePosition
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.Chart1,
																		  this.panel1,
																		  this.label9});
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "LegendStylePosition";
			this.Size = new System.Drawing.Size(728, 480);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		private void ControlChange(object sender, System.EventArgs e)
		{			

			if( InsideCheck.Checked )
				Chart1.Legends["Default"].InsideChartArea = "Default";
			else
				Chart1.Legends["Default"].InsideChartArea = "";

			Chart1.Legends["Default"].Enabled = !DisableCheck.Checked;

			if (this.TheStyle.SelectedItem.ToString() == "Table" && !this.DisableCheck.Checked)  
			{
				this.TheTableStyle.Enabled = true;		
			}

			else
				this.TheTableStyle.Enabled = false;

			if (this.TheTableStyle.SelectedIndex >=0) 
			{
				Chart1.Legends["Default"].TableStyle = (LegendTableStyle)LegendTableStyle.Parse(typeof(LegendTableStyle),this.TheTableStyle.SelectedItem.ToString());
			}			
			
			if(this.TheStyle.SelectedIndex >= 0)
			{
				Chart1.Legends["Default"].LegendStyle = (LegendStyle)LegendStyle.Parse(typeof(LegendStyle), this.TheStyle.SelectedItem.ToString());
			}

			if(this.TheDocking.SelectedIndex >= 0)
			{
				Chart1.Legends["Default"].Docking = (Docking)Docking.Parse(typeof(Docking), this.TheDocking.SelectedItem.ToString());
			}

			if(this.TheAlignment.SelectedIndex >= 0)
			{
				Chart1.Legends["Default"].Alignment = (StringAlignment)StringAlignment.Parse(typeof(StringAlignment), this.TheAlignment.SelectedItem.ToString());
			}

            if (this.cb_Reversed.Checked)
                Chart1.Legends["Default"].LegendItemOrder = LegendItemOrder.ReversedSeriesOrder;

            else
                Chart1.Legends["Default"].LegendItemOrder = LegendItemOrder.SameAsSeriesOrder;
		}

		private void cb_Reversed_CheckedChanged(object sender, System.EventArgs e)
		{
			ControlChange(sender,e);
		}

		private void DisableCheck_CheckedChanged(object sender, System.EventArgs e)
		{
			if (!this.DisableCheck.Checked) 
			{
				this.TheAlignment.Enabled = true;
				this.TheDocking.Enabled = true;
				this.TheTableStyle.Enabled = true;
				this.TheStyle.Enabled = true;
				this.InsideCheck.Enabled = true;
				this.cb_Reversed.Enabled = true;
			}

			else
			{
				this.TheAlignment.Enabled = false;
				this.TheDocking.Enabled = false;
				this.TheTableStyle.Enabled = false;
				this.TheStyle.Enabled = false;
				this.InsideCheck.Enabled = false;
				this.cb_Reversed.Enabled = false;
			}

			ControlChange(sender,e);
		}
	}
}
