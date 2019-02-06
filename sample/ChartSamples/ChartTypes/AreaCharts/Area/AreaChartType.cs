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
	/// Summary description for AreaChartType.
	/// </summary>
	public class AreaChartType : System.Windows.Forms.UserControl
	{
		private Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButtonArea;
		private System.Windows.Forms.RadioButton radioButtonSplineArea;
		private System.Windows.Forms.CheckBox checkBoxShowMargin;
		private System.Windows.Forms.CheckBox checkBoxShowMarkers;
		private System.Windows.Forms.ComboBox comboBoxTension;
		private System.Windows.Forms.CheckBox checkBoxShow3D;
		private System.Windows.Forms.CheckBox checkBoxTransparent;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AreaChartType()
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
            this.checkBoxTransparent = new System.Windows.Forms.CheckBox();
            this.checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this.comboBoxTension = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxShowMarkers = new System.Windows.Forms.CheckBox();
            this.checkBoxShowMargin = new System.Windows.Forms.CheckBox();
            this.radioButtonSplineArea = new System.Windows.Forms.RadioButton();
            this.radioButtonArea = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
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
            this.chart1.Location = new System.Drawing.Point(16, 48);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.LabelFormat = "C";
            series1.Legend = "Default";
            series1.Name = "Default";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.LabelFormat = "C";
            series2.Legend = "Default";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 34);
            this.labelSampleComment.TabIndex = 0;
            this.labelSampleComment.Text = "This sample demonstrates Area and Spline Area charts.";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSampleComment.Click += new System.EventHandler(this.labelSampleComment_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxTransparent);
            this.panel1.Controls.Add(this.checkBoxShow3D);
            this.panel1.Controls.Add(this.comboBoxTension);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBoxShowMarkers);
            this.panel1.Controls.Add(this.checkBoxShowMargin);
            this.panel1.Controls.Add(this.radioButtonSplineArea);
            this.panel1.Controls.Add(this.radioButtonArea);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // checkBoxTransparent
            // 
            this.checkBoxTransparent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxTransparent.Location = new System.Drawing.Point(19, 168);
            this.checkBoxTransparent.Name = "checkBoxTransparent";
            this.checkBoxTransparent.Size = new System.Drawing.Size(216, 24);
            this.checkBoxTransparent.TabIndex = 6;
            this.checkBoxTransparent.Text = "Semi-&Transparent Colors:";
            this.checkBoxTransparent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxTransparent.CheckedChanged += new System.EventHandler(this.checkBoxTransparent_CheckedChanged);
            // 
            // checkBoxShow3D
            // 
            this.checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShow3D.Location = new System.Drawing.Point(51, 200);
            this.checkBoxShow3D.Name = "checkBoxShow3D";
            this.checkBoxShow3D.Size = new System.Drawing.Size(184, 24);
            this.checkBoxShow3D.TabIndex = 7;
            this.checkBoxShow3D.Text = "Display chart as 3&D:";
            this.checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
            // 
            // comboBoxTension
            // 
            this.comboBoxTension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTension.Items.AddRange(new object[] {
            "1.2",
            "0.8",
            "0.4",
            "0.2"});
            this.comboBoxTension.Location = new System.Drawing.Point(222, 70);
            this.comboBoxTension.Name = "comboBoxTension";
            this.comboBoxTension.Size = new System.Drawing.Size(64, 22);
            this.comboBoxTension.TabIndex = 3;
            this.comboBoxTension.SelectedIndexChanged += new System.EventHandler(this.comboBoxTension_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(105, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spline &Tension:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxShowMarkers
            // 
            this.checkBoxShowMarkers.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowMarkers.Location = new System.Drawing.Point(3, 104);
            this.checkBoxShowMarkers.Name = "checkBoxShowMarkers";
            this.checkBoxShowMarkers.Size = new System.Drawing.Size(232, 24);
            this.checkBoxShowMarkers.TabIndex = 4;
            this.checkBoxShowMarkers.Text = "Show Point &Markers and Labels:";
            this.checkBoxShowMarkers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowMarkers.CheckedChanged += new System.EventHandler(this.checkBoxShowMarkers_CheckedChanged);
            // 
            // checkBoxShowMargin
            // 
            this.checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowMargin.Location = new System.Drawing.Point(3, 136);
            this.checkBoxShowMargin.Name = "checkBoxShowMargin";
            this.checkBoxShowMargin.Size = new System.Drawing.Size(232, 24);
            this.checkBoxShowMargin.TabIndex = 5;
            this.checkBoxShowMargin.Text = "Show X Axis M&argin:";
            this.checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowMargin.CheckedChanged += new System.EventHandler(this.checkBoxShowMargin_CheckedChanged);
            // 
            // radioButtonSplineArea
            // 
            this.radioButtonSplineArea.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonSplineArea.Location = new System.Drawing.Point(48, 37);
            this.radioButtonSplineArea.Name = "radioButtonSplineArea";
            this.radioButtonSplineArea.Size = new System.Drawing.Size(184, 24);
            this.radioButtonSplineArea.TabIndex = 1;
            this.radioButtonSplineArea.Text = "&Spline Area Chart:";
            this.radioButtonSplineArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonSplineArea.CheckedChanged += new System.EventHandler(this.radioButtonSplineArea_CheckedChanged);
            // 
            // radioButtonArea
            // 
            this.radioButtonArea.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonArea.Checked = true;
            this.radioButtonArea.Location = new System.Drawing.Point(88, 8);
            this.radioButtonArea.Name = "radioButtonArea";
            this.radioButtonArea.Size = new System.Drawing.Size(144, 24);
            this.radioButtonArea.TabIndex = 0;
            this.radioButtonArea.TabStop = true;
            this.radioButtonArea.Text = "&Area Chart:";
            this.radioButtonArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonArea.CheckedChanged += new System.EventHandler(this.radioButtonArea_CheckedChanged);
            // 
            // AreaChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AreaChartType";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.AreaChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			if(radioButtonArea.Checked)
			{
				// Set chart type to Area
				chart1.Series["Default"].ChartType = SeriesChartType.Area;
				chart1.Series["Series2"].ChartType = SeriesChartType.Area;
				chart1.Series["Default"].DeleteCustomProperty("LineTension");
				chart1.Series["Series2"].DeleteCustomProperty("LineTension");
				comboBoxTension.Enabled = false;
			}
			else
			{
				// Set chart type to SplineArea and set line tension
				comboBoxTension.Enabled = true;
				chart1.Series["Default"].ChartType = SeriesChartType.SplineArea;
				chart1.Series["Default"]["LineTension"] = comboBoxTension.Text;
				chart1.Series["Series2"].ChartType = SeriesChartType.SplineArea;
				chart1.Series["Series2"]["LineTension"] = comboBoxTension.Text;
			}

			
			
			// Show solid or transparent color
			if(checkBoxTransparent.Checked==true)
			{
				chart1.Series["Default"].Color = Color.FromArgb(220, 65, 140, 240);
				chart1.Series["Series2"].Color = Color.FromArgb(220, 252, 180, 65);
			}
			else
			{
				if(checkBoxShow3D.Checked)
				{
					chart1.Series["Default"].Color = Color.FromArgb(255, 65, 140, 240);
					chart1.Series["Series2"].Color = Color.FromArgb(255, 252, 180, 65);
				}
				else
				{
					chart1.Series["Default"].Color = Color.FromArgb(255, 65, 140, 240);
					chart1.Series["Series2"].Color = Color.FromArgb(255, 252, 180, 65);
				}
			}
			
			// Enable points labels and markers
			if(checkBoxShowMarkers.Checked)
			{
				chart1.Series["Default"].IsValueShownAsLabel = true;
				chart1.Series["Default"].MarkerStyle = MarkerStyle.Circle;
				chart1.Series["Default"].MarkerColor = Color.Gold;
				chart1.Series["Series2"].IsValueShownAsLabel = true;
				chart1.Series["Series2"].MarkerStyle = MarkerStyle.Circle;
				chart1.Series["Series2"].MarkerColor = Color.Gold;
			}
			else
			{
				chart1.Series["Default"].IsValueShownAsLabel = false;
				chart1.Series["Default"].MarkerStyle = MarkerStyle.None;
				chart1.Series["Default"].MarkerColor = Color.Gold;
				chart1.Series["Series2"].IsValueShownAsLabel = false;
				chart1.Series["Series2"].MarkerStyle = MarkerStyle.None;
				chart1.Series["Series2"].MarkerColor = Color.Gold;
			}

			// Disable/enable X axis margin
			chart1.ChartAreas["Default"].AxisX.IsMarginVisible = checkBoxShowMargin.Checked;

			// Show 3D or 2D charts
			if(checkBoxShow3D.Checked==true)
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = true;
				chart1.Series["Default"].IsValueShownAsLabel = false;
				chart1.Series["Series2"].IsValueShownAsLabel = false;
				chart1.Series["Default"].MarkerStyle = MarkerStyle.None;
				chart1.Series["Series2"].MarkerStyle = MarkerStyle.None;
			}
			else
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = false;
			}

			if(checkBoxShowMarkers.Checked)
			{
				chart1.Series["Default"].IsValueShownAsLabel = true;
				chart1.Series["Series2"].IsValueShownAsLabel = true;
				chart1.Series["Default"].MarkerStyle = MarkerStyle.Circle;
				chart1.Series["Series2"].MarkerStyle = MarkerStyle.Circle;
			}

		}

		private void radioButtonArea_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void radioButtonSplineArea_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxShowMargin_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxShowMarkers_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxTension_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void AreaChartType_Load(object sender, System.EventArgs e)
		{
			comboBoxTension.SelectedIndex = 1;
			checkBoxTransparent.Checked = true;
			// Add data
			chart1.Series["Default"].Points.AddY(8.1);
			chart1.Series["Default"].Points.AddY(7.6);
			chart1.Series["Default"].Points.AddY(9.5);
			chart1.Series["Default"].Points.AddY(8.5);
			chart1.Series["Default"].Points.AddY(9.0);
			chart1.Series["Default"].Points.AddY(8.0);

			chart1.Series["Series2"].Points.AddY(2.3);
			chart1.Series["Series2"].Points.AddY(4.2);
			chart1.Series["Series2"].Points.AddY(3.6);
			chart1.Series["Series2"].Points.AddY(2.3);
			chart1.Series["Series2"].Points.AddY(1.6);
			chart1.Series["Series2"].Points.AddY(2.9);
		}

		private void checkBoxShow3D_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxTransparent_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void labelSampleComment_Click(object sender, System.EventArgs e)
		{
		
		}


	}
}
