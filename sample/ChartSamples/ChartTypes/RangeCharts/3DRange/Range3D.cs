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
	/// Summary description for Range3D.
	/// </summary>
	public class Range3D : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxLineTension;
		private System.Windows.Forms.ComboBox comboBoxChartType;
		private System.Windows.Forms.CheckBox checkBoxShowMargin;
		private System.Windows.Forms.CheckBox ShowMarkerLines;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox LightingType;
        private System.Windows.Forms.CheckBox UsePerspective;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Range3D()
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSampleComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsePerspective = new System.Windows.Forms.CheckBox();
            this.LightingType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowMarkerLines = new System.Windows.Forms.CheckBox();
            this.checkBoxShowMargin = new System.Windows.Forms.CheckBox();
            this.comboBoxLineTension = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 32;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Rotation = 29;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 96F;
            chartArea1.Position.Width = 99F;
            chartArea1.Position.Y = 2F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 48);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValuesPerPoint = 2;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 0);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 42);
            this.labelSampleComment.TabIndex = 0;
            this.labelSampleComment.Text = "This sample demonstrates Range and Spline Range chart types. The Spline Range cha" +
                "rt supports line tension adjustment. ";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UsePerspective);
            this.panel1.Controls.Add(this.LightingType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ShowMarkerLines);
            this.panel1.Controls.Add(this.checkBoxShowMargin);
            this.panel1.Controls.Add(this.comboBoxLineTension);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxChartType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 280);
            this.panel1.TabIndex = 2;
            // 
            // UsePerspective
            // 
            this.UsePerspective.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UsePerspective.Location = new System.Drawing.Point(-2, 168);
            this.UsePerspective.Name = "UsePerspective";
            this.UsePerspective.Size = new System.Drawing.Size(184, 24);
            this.UsePerspective.TabIndex = 8;
            this.UsePerspective.Text = "Use 10% &Perspective:";
            this.UsePerspective.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UsePerspective.CheckedChanged += new System.EventHandler(this.UsePerspective_CheckedChanged);
            // 
            // LightingType
            // 
            this.LightingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LightingType.Items.AddRange(new object[] {
            "None",
            "Simplistic",
            "Realistic"});
            this.LightingType.Location = new System.Drawing.Point(168, 72);
            this.LightingType.Name = "LightingType";
            this.LightingType.Size = new System.Drawing.Size(112, 22);
            this.LightingType.TabIndex = 5;
            this.LightingType.SelectedIndexChanged += new System.EventHandler(this.LightingType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "L&ighting:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShowMarkerLines
            // 
            this.ShowMarkerLines.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowMarkerLines.Location = new System.Drawing.Point(-2, 136);
            this.ShowMarkerLines.Name = "ShowMarkerLines";
            this.ShowMarkerLines.Size = new System.Drawing.Size(184, 24);
            this.ShowMarkerLines.TabIndex = 7;
            this.ShowMarkerLines.Text = "Show Marker &Lines:";
            this.ShowMarkerLines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowMarkerLines.CheckedChanged += new System.EventHandler(this.ShowMarkerLines_CheckedChanged);
            // 
            // checkBoxShowMargin
            // 
            this.checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowMargin.Location = new System.Drawing.Point(-2, 104);
            this.checkBoxShowMargin.Name = "checkBoxShowMargin";
            this.checkBoxShowMargin.Size = new System.Drawing.Size(184, 24);
            this.checkBoxShowMargin.TabIndex = 6;
            this.checkBoxShowMargin.Text = "Show X Axis &Margin:";
            this.checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowMargin.CheckedChanged += new System.EventHandler(this.checkBoxShowMargin_CheckedChanged);
            // 
            // comboBoxLineTension
            // 
            this.comboBoxLineTension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLineTension.Items.AddRange(new object[] {
            "1.2",
            "0.8",
            "0.4",
            "0.2"});
            this.comboBoxLineTension.Location = new System.Drawing.Point(168, 40);
            this.comboBoxLineTension.Name = "comboBoxLineTension";
            this.comboBoxLineTension.Size = new System.Drawing.Size(112, 22);
            this.comboBoxLineTension.TabIndex = 3;
            this.comboBoxLineTension.SelectedIndexChanged += new System.EventHandler(this.comboBoxLineTension_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Spline &Tension:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType.Items.AddRange(new object[] {
            "Spline Range",
            "Range"});
            this.comboBoxChartType.Location = new System.Drawing.Point(168, 8);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(112, 22);
            this.comboBoxChartType.TabIndex = 1;
            this.comboBoxChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxLineTension_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chart &Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Range3D
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Range3D";
            this.Size = new System.Drawing.Size(728, 384);
            this.Load += new System.EventHandler(this.Range3D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			if( comboBoxChartType.Text == "" )
			{
				return;
			}

			// Loop through all series
			foreach(Series series in chart1.Series)
			{
                // Set marker lines
				series["ShowMarkerLines"] = ShowMarkerLines.Checked.ToString();

                // Set chart type and line tension
				if(comboBoxChartType.Text == "Spline Range")
				{
                    series.ChartType = SeriesChartType.SplineRange;
                    comboBoxLineTension.Enabled = true;
					series["LineTension"] = comboBoxLineTension.Text;
				}
				else
				{
                    series.ChartType = SeriesChartType.Range;
                    comboBoxLineTension.Enabled = false;
					series.DeleteCustomProperty("LineTension");
				}
			}

			// Disable/enable X axis margin
			chart1.ChartAreas["Default"].AxisX.IsMarginVisible = checkBoxShowMargin.Checked;

			// Set area lighting
			if(LightingType.Text != "")
				chart1.ChartAreas["Default"].Area3DStyle.LightStyle = (LightStyle)LightStyle.Parse(typeof(LightStyle), LightingType.Text);

			if(UsePerspective.Checked)
			{
				chart1.ChartAreas["Default"].Area3DStyle.Perspective = 10;
				chart1.ChartAreas["Default"].Area3DStyle.PointDepth = 200;
			}
			else
			{
				chart1.ChartAreas["Default"].Area3DStyle.Perspective = 0;
				chart1.ChartAreas["Default"].Area3DStyle.PointDepth = 100;
			}
		}

		private void Range3D_Load(object sender, System.EventArgs e)
		{
			// Populate series data with data
			double[]	yValue11 = {56, 74, 45, 59, 34, 87, 50, 87, 64, 34};
			double[]	yValue12 = {42, 65, 30, 42, 25, 47, 40, 70, 34, 20};
			chart1.Series["Default"].Points.DataBindY(yValue11, yValue12);

			double[]	yValue21 = {46, 64, 55, 69, 34, 57, 20, 67, 64, 34};
			double[]	yValue22 = {12, 45, 50, 12, 15, 27, 10, 40, 24, 30};
			chart1.Series["Series2"].Points.DataBindY(yValue21, yValue22);

			// Set selection
			comboBoxLineTension.SelectedIndex = 1;
			comboBoxChartType.SelectedIndex = 0;
			LightingType.SelectedIndex = 2;
		}

		private void comboBoxLineTension_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxShowMargin_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void ShowMarkerLines_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void LightingType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void UsePerspective_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

	}
}
