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
	/// Summary description for ScaleBreaks.
	/// </summary>
	public class ScaleBreaks : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.CheckBox chk_EnableScaleBreaks;
		private System.Windows.Forms.ComboBox cb_BreakLineStyle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cb_Color;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ScaleBreaks()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			foreach (string breakTypes in Enum.GetNames(typeof(BreakLineStyle)))
			{
				this.cb_BreakLineStyle.Items.Add(breakTypes);
			}

			this.cb_BreakLineStyle.SelectedIndex = 3;
			this.cb_Color.SelectedIndex = 0;
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
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38801.6328125, 32);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38802.6328125, 30);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38803.6328125, 38);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38804.6328125, 23);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38805.6328125, 28);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38806.6328125, 24);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38807.6328125, 21);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38808.6328125, 30);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38809.6328125, 24);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38810.6328125, 29);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38811.6328125, 2953);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38812.6328125, 3367);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38813.6328125, 3124);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38814.6328125, 3224);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38815.6328125, 25);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38816.6328125, 18);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38817.6328125, 14);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38818.6328125, 28);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38819.6328125, 19);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38820.6328125, 30);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38821.6328125, 21);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint22 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38822.6328125, 32);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint23 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38823.6328125, 23);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint24 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38824.6328125, 10);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint25 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(38825.6328125, 27);
			this.label9 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cb_Color = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.cb_BreakLineStyle = new System.Windows.Forms.ComboBox();
			this.chk_EnableScaleBreaks = new System.Windows.Forms.CheckBox();
			this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(702, 24);
			this.label9.TabIndex = 0;
			this.label9.Text = "This sample demonstrates how to work with scale breaks.";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.cb_Color,
																				 this.label3,
																				 this.label2,
																				 this.numericUpDown1,
																				 this.label1,
																				 this.cb_BreakLineStyle,
																				 this.chk_EnableScaleBreaks});
			this.panel1.Location = new System.Drawing.Point(432, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(312, 288);
			this.panel1.TabIndex = 2;
			// 
			// cb_Color
			// 
			this.cb_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Color.Enabled = false;
			this.cb_Color.Items.AddRange(new object[] {
														  "Black",
														  "Gray",
														  "Red",
														  "Blue",
														  "Green"});
			this.cb_Color.Location = new System.Drawing.Point(165, 104);
			this.cb_Color.Name = "cb_Color";
			this.cb_Color.Size = new System.Drawing.Size(123, 22);
			this.cb_Color.TabIndex = 6;
			this.cb_Color.SelectedIndexChanged += new System.EventHandler(this.cb_Color_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(40, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "&Color:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(96, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "&Spacing:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Enabled = false;
			this.numericUpDown1.Location = new System.Drawing.Point(166, 72);
			this.numericUpDown1.Maximum = new System.Decimal(new int[] {
																		   10,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(66, 22);
			this.numericUpDown1.TabIndex = 4;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 1,
																		 0,
																		 0,
																		 0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(104, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "&Type:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cb_BreakLineStyle
			// 
			this.cb_BreakLineStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_BreakLineStyle.Enabled = false;
			this.cb_BreakLineStyle.Location = new System.Drawing.Point(165, 39);
			this.cb_BreakLineStyle.Name = "cb_BreakLineStyle";
			this.cb_BreakLineStyle.Size = new System.Drawing.Size(123, 22);
			this.cb_BreakLineStyle.TabIndex = 2;
			this.cb_BreakLineStyle.SelectedIndexChanged += new System.EventHandler(this.cb_BreakLineStyle_SelectedIndexChanged);
			// 
			// chk_EnableScaleBreaks
			// 
			this.chk_EnableScaleBreaks.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chk_EnableScaleBreaks.Location = new System.Drawing.Point(12, 8);
			this.chk_EnableScaleBreaks.Name = "chk_EnableScaleBreaks";
			this.chk_EnableScaleBreaks.Size = new System.Drawing.Size(168, 24);
			this.chk_EnableScaleBreaks.TabIndex = 0;
			this.chk_EnableScaleBreaks.Text = "&Enable Scale Breaks:";
			this.chk_EnableScaleBreaks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chk_EnableScaleBreaks.CheckedChanged += new System.EventHandler(this.chk_EnableScaleBreaks_CheckedChanged);
			// 
			// Chart1
			// 
			this.Chart1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(211)), ((System.Byte)(223)), ((System.Byte)(240)));
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
			chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
			chartArea1.AxisX.LabelAutoFitMinFontSize = 8;
			chartArea1.AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.None;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			chartArea1.AxisX.LabelStyle.Format = "MMM dd";
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.LabelAutoFitMaxFontSize = 8;
			chartArea1.AxisY.LabelAutoFitMinFontSize = 8;
			chartArea1.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
				| System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap);
			chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.LineWidth = 2;
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(165)), ((System.Byte)(191)), ((System.Byte)(228)));
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
			legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.Chart1.Legends.Add(legend1);
			this.Chart1.Location = new System.Drawing.Point(16, 56);
			this.Chart1.Name = "Chart1";
			this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartArea = "Default";
			series1.CustomProperties = "DrawingStyle=LightToDark";
			series1.Name = "Series1";
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
			series1.Points.Add(dataPoint15);
			series1.Points.Add(dataPoint16);
			series1.Points.Add(dataPoint17);
			series1.Points.Add(dataPoint18);
			series1.Points.Add(dataPoint19);
			series1.Points.Add(dataPoint20);
			series1.Points.Add(dataPoint21);
			series1.Points.Add(dataPoint22);
			series1.Points.Add(dataPoint23);
			series1.Points.Add(dataPoint24);
			series1.Points.Add(dataPoint25);
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			this.Chart1.Series.Add(series1);
			this.Chart1.Size = new System.Drawing.Size(412, 296);
			this.Chart1.TabIndex = 1;
			// 
			// ScaleBreaks
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.Chart1,
																		  this.panel1,
																		  this.label9});
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "ScaleBreaks";
			this.Size = new System.Drawing.Size(760, 480);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion		

		private void chk_EnableScaleBreaks_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.chk_EnableScaleBreaks.Checked) 
			{
				this.Chart1.ChartAreas[0].AxisY.ScaleBreakStyle.Enabled = true;
				this.cb_BreakLineStyle.Enabled = true;
				this.numericUpDown1.Enabled = true;
				this.cb_Color.Enabled = true;
			}

			else 
			{
				this.Chart1.ChartAreas[0].AxisY.ScaleBreakStyle.Enabled = false;
				this.cb_BreakLineStyle.Enabled = false;
				this.numericUpDown1.Enabled = false;
				this.cb_Color.Enabled = false;
			}
		}

		private void cb_BreakLineStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Set the scale break type
			Chart1.ChartAreas[0].AxisY.ScaleBreakStyle.BreakLineStyle = (BreakLineStyle)BreakLineStyle.Parse(typeof(BreakLineStyle), this.cb_BreakLineStyle.SelectedItem.ToString());
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			Chart1.ChartAreas[0].AxisY.ScaleBreakStyle.Spacing = (int)this.numericUpDown1.Value;
		}

		private void cb_Color_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Chart1.ChartAreas[0].AxisY.ScaleBreakStyle.LineColor = Color.FromName(this.cb_Color.SelectedItem.ToString());		
		}
	}
}
