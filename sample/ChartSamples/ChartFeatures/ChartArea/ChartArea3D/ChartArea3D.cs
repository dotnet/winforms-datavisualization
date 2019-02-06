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
	/// Summary description for BarColumnChartType.
	/// </summary>
	public class ChartArea3D : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkBoxShow3D;
		private System.Windows.Forms.CheckBox RightAngleAxis;
		private System.Windows.Forms.ComboBox WallWidth;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown Rotation;
		private System.Windows.Forms.NumericUpDown Inclination;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ChartArea3D()
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 23);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 56);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 35);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 68);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 35);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 23);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rotation = new System.Windows.Forms.NumericUpDown();
            this.Inclination = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WallWidth = new System.Windows.Forms.ComboBox();
            this.RightAngleAxis = new System.Windows.Forms.CheckBox();
            this.checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inclination)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
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
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 65);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 1;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "2D Chart";
            this.chart1.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Rotation);
            this.panel1.Controls.Add(this.Inclination);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.WallWidth);
            this.panel1.Controls.Add(this.RightAngleAxis);
            this.panel1.Controls.Add(this.checkBoxShow3D);
            this.panel1.Location = new System.Drawing.Point(432, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // Rotation
            // 
            this.Rotation.Enabled = false;
            this.Rotation.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Rotation.Location = new System.Drawing.Point(168, 136);
            this.Rotation.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Rotation.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.Rotation.Name = "Rotation";
            this.Rotation.Size = new System.Drawing.Size(56, 22);
            this.Rotation.TabIndex = 7;
            this.Rotation.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Rotation.ValueChanged += new System.EventHandler(this.Rotation_ValueChanged);
            // 
            // Inclination
            // 
            this.Inclination.Enabled = false;
            this.Inclination.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Inclination.Location = new System.Drawing.Point(168, 104);
            this.Inclination.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Inclination.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.Inclination.Name = "Inclination";
            this.Inclination.Size = new System.Drawing.Size(56, 22);
            this.Inclination.TabIndex = 5;
            this.Inclination.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Inclination.ValueChanged += new System.EventHandler(this.Inclination_ValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(33, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rotate &Y:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(33, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rotate &X:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Wall Width:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WallWidth
            // 
            this.WallWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WallWidth.Enabled = false;
            this.WallWidth.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "7",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.WallWidth.Location = new System.Drawing.Point(168, 72);
            this.WallWidth.Name = "WallWidth";
            this.WallWidth.Size = new System.Drawing.Size(121, 22);
            this.WallWidth.TabIndex = 3;
            this.WallWidth.SelectedIndexChanged += new System.EventHandler(this.WallWidth_SelectedIndexChanged);
            // 
            // RightAngleAxis
            // 
            this.RightAngleAxis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RightAngleAxis.Enabled = false;
            this.RightAngleAxis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RightAngleAxis.Location = new System.Drawing.Point(16, 33);
            this.RightAngleAxis.Name = "RightAngleAxis";
            this.RightAngleAxis.Size = new System.Drawing.Size(164, 24);
            this.RightAngleAxis.TabIndex = 1;
            this.RightAngleAxis.Text = "Right Angle &Axis:";
            this.RightAngleAxis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RightAngleAxis.CheckedChanged += new System.EventHandler(this.RightAngleAxis_CheckedChanged);
            // 
            // checkBoxShow3D
            // 
            this.checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShow3D.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxShow3D.Location = new System.Drawing.Point(16, 3);
            this.checkBoxShow3D.Name = "checkBoxShow3D";
            this.checkBoxShow3D.Size = new System.Drawing.Size(164, 24);
            this.checkBoxShow3D.TabIndex = 0;
            this.checkBoxShow3D.Text = "Display chart as 3&D:";
            this.checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(702, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "This sample demonstrates chart rotation, isometric projection, and how to set the" +
                " width of 3D walls. ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChartArea3D
            // 
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChartArea3D";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.BarColumnChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Rotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inclination)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void BarColumnChartType_Load(object sender, System.EventArgs e)
		{
			checkBoxShow3D.Checked = false;
			// set the combo selection index
			WallWidth.SelectedIndex = 6;
		}

		private void checkBoxShow3D_CheckedChanged(object sender, System.EventArgs e)
		{
			chart1.ChartAreas[0].Area3DStyle.Enable3D = checkBoxShow3D.Checked;

			if(checkBoxShow3D.Checked)
			{
				chart1.Titles[0].Text = "3D Chart";
				Inclination.Enabled = true;
				Rotation.Enabled = true;
			}
			else
			{
				chart1.Titles[0].Text = "2D Chart";
				Inclination.Enabled = false;
				Rotation.Enabled = false;
			}

			RightAngleAxis.Enabled = checkBoxShow3D.Checked;
			WallWidth.Enabled = checkBoxShow3D.Checked;
		}

		private void RightAngleAxis_CheckedChanged(object sender, System.EventArgs e)
		{
			// Disable/enable right angle axis
			chart1.ChartAreas["Default"].Area3DStyle.IsRightAngleAxes = RightAngleAxis.Checked;
	
		}

		private void WallWidth_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if( WallWidth.SelectedItem == null)
				return;

			int val = int.Parse(WallWidth.GetItemText(WallWidth.SelectedItem));
			chart1.ChartAreas[0].Area3DStyle.WallWidth = val;
		}

		private void Inclination_ValueChanged(object sender, System.EventArgs e)
		{
			if(Inclination.Value > 90)
				Inclination.Value = -90;
			if(Inclination.Value < -90)
				Inclination.Value = 90;

			chart1.ChartAreas["Default"].Area3DStyle.Inclination = (int)Inclination.Value;
		}

		private void Rotation_ValueChanged(object sender, System.EventArgs e)
		{
			if(Rotation.Value > 180)
				Rotation.Value = -180;
			if(Rotation.Value < -180)
				Rotation.Value = 180;

			chart1.ChartAreas["Default"].Area3DStyle.Rotation = (int)Rotation.Value;
		}


	}
}
