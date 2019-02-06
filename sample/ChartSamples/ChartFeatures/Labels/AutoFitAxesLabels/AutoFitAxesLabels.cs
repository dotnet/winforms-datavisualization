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
	/// Summary description for AutoFitAxesLabels.
	/// </summary>
	public class AutoFitAxesLabels : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.CheckBox checkBoxAutoFit;
		private System.Windows.Forms.CheckBox checkBoxFontSize;
		private System.Windows.Forms.CheckBox checkBoxOffsetLabels;
		private System.Windows.Forms.CheckBox checkBoxWordWrap;
		private System.Windows.Forms.ComboBox comboBoInclination;
		private System.Windows.Forms.Label labelAngle;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AutoFitAxesLabels()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize component
			comboBoInclination.SelectedIndex = 1;

			UpdateAutoFitChecked();
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(37622, 345);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(37623, 634);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(37624, 154);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(37625, 765);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(37626, 376);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(37627, 600);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(37622, 345);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(37623, 634);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(37624, 154);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(37625, 765);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(37626, 376);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(37627, 457);
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxFontSize = new System.Windows.Forms.CheckBox();
            this.labelAngle = new System.Windows.Forms.Label();
            this.checkBoxWordWrap = new System.Windows.Forms.CheckBox();
            this.checkBoxOffsetLabels = new System.Windows.Forms.CheckBox();
            this.comboBoInclination = new System.Windows.Forms.ComboBox();
            this.checkBoxAutoFit = new System.Windows.Forms.CheckBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to automatically fit labels along an axis. ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.checkBoxAutoFit);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxFontSize);
            this.groupBox1.Controls.Add(this.labelAngle);
            this.groupBox1.Controls.Add(this.checkBoxWordWrap);
            this.groupBox1.Controls.Add(this.checkBoxOffsetLabels);
            this.groupBox1.Controls.Add(this.comboBoInclination);
            this.groupBox1.Location = new System.Drawing.Point(16, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 160);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automatic Fitting Style:";
            // 
            // checkBoxFontSize
            // 
            this.checkBoxFontSize.Checked = true;
            this.checkBoxFontSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFontSize.Enabled = false;
            this.checkBoxFontSize.Location = new System.Drawing.Point(32, 24);
            this.checkBoxFontSize.Name = "checkBoxFontSize";
            this.checkBoxFontSize.Size = new System.Drawing.Size(216, 24);
            this.checkBoxFontSize.TabIndex = 2;
            this.checkBoxFontSize.Text = "Modify Font &Size";
            this.checkBoxFontSize.CheckedChanged += new System.EventHandler(this.checkBoxFontSize_CheckedChanged);
            // 
            // labelAngle
            // 
            this.labelAngle.Enabled = false;
            this.labelAngle.Location = new System.Drawing.Point(24, 120);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(96, 23);
            this.labelAngle.TabIndex = 5;
            this.labelAngle.Text = "Labels &Angle:";
            this.labelAngle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxWordWrap
            // 
            this.checkBoxWordWrap.Checked = true;
            this.checkBoxWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWordWrap.Enabled = false;
            this.checkBoxWordWrap.Location = new System.Drawing.Point(32, 88);
            this.checkBoxWordWrap.Name = "checkBoxWordWrap";
            this.checkBoxWordWrap.Size = new System.Drawing.Size(216, 24);
            this.checkBoxWordWrap.TabIndex = 4;
            this.checkBoxWordWrap.Text = "Use Word &Wrap";
            this.checkBoxWordWrap.CheckedChanged += new System.EventHandler(this.checkBoxWordWrap_CheckedChanged);
            // 
            // checkBoxOffsetLabels
            // 
            this.checkBoxOffsetLabels.Checked = true;
            this.checkBoxOffsetLabels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOffsetLabels.Enabled = false;
            this.checkBoxOffsetLabels.Location = new System.Drawing.Point(32, 56);
            this.checkBoxOffsetLabels.Name = "checkBoxOffsetLabels";
            this.checkBoxOffsetLabels.Size = new System.Drawing.Size(216, 24);
            this.checkBoxOffsetLabels.TabIndex = 3;
            this.checkBoxOffsetLabels.Text = "Use &Offset Labels";
            this.checkBoxOffsetLabels.CheckedChanged += new System.EventHandler(this.checkBoxOffsetLabels_CheckedChanged);
            // 
            // comboBoInclination
            // 
            this.comboBoInclination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoInclination.Enabled = false;
            this.comboBoInclination.Items.AddRange(new object[] {
            "Not Changed",
            "0-30-60-90",
            "0-45-90",
            "0-90"});
            this.comboBoInclination.Location = new System.Drawing.Point(128, 120);
            this.comboBoInclination.Name = "comboBoInclination";
            this.comboBoInclination.Size = new System.Drawing.Size(120, 22);
            this.comboBoInclination.TabIndex = 6;
            this.comboBoInclination.SelectedIndexChanged += new System.EventHandler(this.comboBoInclination_SelectedIndexChanged);
            // 
            // checkBoxAutoFit
            // 
            this.checkBoxAutoFit.Checked = true;
            this.checkBoxAutoFit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoFit.Location = new System.Drawing.Point(48, 8);
            this.checkBoxAutoFit.Name = "checkBoxAutoFit";
            this.checkBoxAutoFit.Size = new System.Drawing.Size(228, 24);
            this.checkBoxAutoFit.TabIndex = 0;
            this.checkBoxAutoFit.Text = "Automatically Fit &X Axis Labels";
            this.checkBoxAutoFit.CheckedChanged += new System.EventHandler(this.checkBoxAutoFit_CheckedChanged);
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
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
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "ddd, MMM dd";
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Format = "C";
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
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
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Series1";
            dataPoint1.AxisLabel = "";
            dataPoint2.AxisLabel = "";
            dataPoint3.AxisLabel = "";
            dataPoint4.AxisLabel = "";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 1;
            this.Chart1.Click += new System.EventHandler(this.Chart1_Click);
            // 
            // chart2
            // 
            this.chart2.BorderlineColor = System.Drawing.Color.DimGray;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart2.BorderSkin.BackSecondaryColor = System.Drawing.Color.White;
            this.chart2.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Format = "ddd, MMM dd";
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.LabelStyle.Format = "C";
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.BackColor = System.Drawing.Color.LightGray;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "Default";
            chartArea2.ShadowOffset = 1;
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.White;
            legend2.BorderColor = System.Drawing.Color.Black;
            legend2.Enabled = false;
            legend2.Name = "Default";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(16, 48);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.ChartArea = "Default";
            series2.Legend = "Default";
            series2.Name = "Series1";
            dataPoint7.AxisLabel = "";
            dataPoint8.AxisLabel = "";
            dataPoint9.AxisLabel = "";
            dataPoint10.AxisLabel = "";
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.ShadowOffset = 1;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(360, 260);
            this.chart2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(692, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "For more information on this sample, Click the Overview tab at the top of this fr" +
                "ame.";
            // 
            // AutoFitAxesLabels
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chart2);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AutoFitAxesLabels";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.CustomLabels_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Chart1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void CustomLabels_Load(object sender, System.EventArgs e)
		{
		}

		private void Combo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		}

		private void checkBoxAutoFit_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateAutoFitChecked();
		}

		private void UpdateAutoFitChecked() 
		{
			checkBoxFontSize.Enabled = checkBoxAutoFit.Checked;
			checkBoxOffsetLabels.Enabled = checkBoxAutoFit.Checked;
			checkBoxWordWrap.Enabled = checkBoxAutoFit.Checked;
			labelAngle.Enabled = checkBoxAutoFit.Checked;
			comboBoInclination.Enabled = checkBoxAutoFit.Checked;

			// Enable/disable X axis labels automatic fitting
			Chart1.ChartAreas["Default"].AxisX.IsLabelAutoFit = checkBoxAutoFit.Checked;
		}

		private void checkBoxFontSize_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateAutoFitStyle();
		}

		private void checkBoxOffsetLabels_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateAutoFitStyle();
		}

		private void checkBoxWordWrap_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateAutoFitStyle();
		}

		private void comboBoInclination_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateAutoFitStyle();
		}

		private void UpdateAutoFitStyle()
		{
			// Set X axis auto fit style
			Chart1.ChartAreas["Default"].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
			if(checkBoxFontSize.Checked)
			{
				Chart1.ChartAreas["Default"].AxisX.LabelAutoFitStyle |= 
					LabelAutoFitStyles.DecreaseFont | LabelAutoFitStyles.IncreaseFont;
			}
			if(checkBoxOffsetLabels.Checked)
			{
				Chart1.ChartAreas["Default"].AxisX.LabelAutoFitStyle |= 
					LabelAutoFitStyles.StaggeredLabels;
			}
			if(checkBoxWordWrap.Checked)
			{
				Chart1.ChartAreas["Default"].AxisX.LabelAutoFitStyle |= 
					LabelAutoFitStyles.WordWrap;
			}
			if(comboBoInclination.SelectedIndex == 1)
			{
				Chart1.ChartAreas["Default"].AxisX.LabelAutoFitStyle |= 
					LabelAutoFitStyles.LabelsAngleStep30;
			}
			if(comboBoInclination.SelectedIndex == 2)
			{
				Chart1.ChartAreas["Default"].AxisX.LabelAutoFitStyle |= 
					LabelAutoFitStyles.LabelsAngleStep45;
			}
			if(comboBoInclination.SelectedIndex == 3)
			{
				Chart1.ChartAreas["Default"].AxisX.LabelAutoFitStyle |= 
					LabelAutoFitStyles.LabelsAngleStep90;
			}

		}
		
	}
}
