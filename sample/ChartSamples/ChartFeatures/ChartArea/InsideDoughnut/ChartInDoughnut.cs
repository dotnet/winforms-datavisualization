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
	/// Summary description for ChartInDataPoint.
	/// </summary>
	public class ChartInDoughnut : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.CheckBox Series2Checkbox;
		private System.Windows.Forms.CheckBox Series3Checkbox;
		private System.Timers.Timer RotateTimer;
		private System.Windows.Forms.CheckBox PsychCheckbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ChartInDoughnut()
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
                RotateTimer.Enabled = false;

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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 4);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3.5999999046325684);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 9);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 4);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartInDoughnut));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PsychCheckbox = new System.Windows.Forms.CheckBox();
            this.Series3Checkbox = new System.Windows.Forms.CheckBox();
            this.Series2Checkbox = new System.Windows.Forms.CheckBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RotateTimer = new System.Timers.Timer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PsychCheckbox);
            this.panel1.Controls.Add(this.Series3Checkbox);
            this.panel1.Controls.Add(this.Series2Checkbox);
            this.panel1.Location = new System.Drawing.Point(432, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // PsychCheckbox
            // 
            this.PsychCheckbox.Location = new System.Drawing.Point(48, 72);
            this.PsychCheckbox.Name = "PsychCheckbox";
            this.PsychCheckbox.Size = new System.Drawing.Size(200, 24);
            this.PsychCheckbox.TabIndex = 2;
            this.PsychCheckbox.Text = "&Psychedelic";
            this.PsychCheckbox.CheckedChanged += new System.EventHandler(this.PsychCheckbox_CheckedChanged);
            // 
            // Series3Checkbox
            // 
            this.Series3Checkbox.Location = new System.Drawing.Point(48, 40);
            this.Series3Checkbox.Name = "Series3Checkbox";
            this.Series3Checkbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Series3Checkbox.Size = new System.Drawing.Size(200, 24);
            this.Series3Checkbox.TabIndex = 1;
            this.Series3Checkbox.Text = "Show Series &3";
            this.Series3Checkbox.CheckedChanged += new System.EventHandler(this.Series2Checkbox_CheckedChanged);
            // 
            // Series2Checkbox
            // 
            this.Series2Checkbox.Location = new System.Drawing.Point(48, 8);
            this.Series2Checkbox.Name = "Series2Checkbox";
            this.Series2Checkbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Series2Checkbox.Size = new System.Drawing.Size(200, 24);
            this.Series2Checkbox.TabIndex = 0;
            this.Series2Checkbox.Text = "Show Series &2";
            this.Series2Checkbox.CheckedChanged += new System.EventHandler(this.Series2Checkbox_CheckedChanged);
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            this.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            this.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.Chart1.BorderlineWidth = 2;
            this.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            this.Chart1.IsSoftShadows = false;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(16, 68);
            this.Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.ShadowOffset = 2;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Enabled = false;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.ShadowOffset = 2;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.Enabled = false;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.ShadowOffset = 2;
            this.Chart1.Series.Add(series1);
            this.Chart1.Series.Add(series2);
            this.Chart1.Series.Add(series3);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 1;
            // 
            // RotateTimer
            // 
            this.RotateTimer.Enabled = true;
            this.RotateTimer.SynchronizingObject = this;
            this.RotateTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.RotateTimer_Elapsed);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "This sample demonstrates how to overlay chart areas to create a more complicated " +
                "chart type.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(702, 72);
            this.label2.TabIndex = 22;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // ChartInDoughnut
            // 
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChartInDoughnut";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.ChartInDataPoint_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateTimer)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void ChartInDataPoint_Load(object sender, System.EventArgs e)
		{
			CreateChartArea(0, "Area1", true);
			Chart1.Series["Series1"].ChartArea = "Area1";
			Chart1.Series["Series1"]["DoughnutRadius"] = "25";
			Chart1.Series["Series2"].IsValueShownAsLabel = false;
			Chart1.Series["Series2"].Label = "#PERCENT{P0}";
			Chart1.Series["Series3"].IsValueShownAsLabel = false;
			Chart1.Series["Series3"].Label = "#PERCENT{P0}";

 

			CreateChartArea(1, "Area2", false);
			CreateChartArea(2, "Area3", false);

			Series2Checkbox.Checked = false;
			Series3Checkbox.Checked = false;
			Series3Checkbox.Enabled = false;
			
			PsychCheckbox.Checked = false;
			RotateTimer.Enabled = false;


		}

		/// <summary>
		/// This method will create a ChartArea with a given name at a certain level
		/// </summary>
		private void CreateChartArea(int level, string AreaName, bool ShowBorder)
		{
			Chart1.ChartAreas.Add(AreaName);
			Chart1.ChartAreas[AreaName].BackColor = Color.Transparent;
			
			if(ShowBorder)
				Chart1.ChartAreas[AreaName].BorderWidth = 1;
			else
				Chart1.ChartAreas[AreaName].BorderWidth = 0;

			Chart1.ChartAreas[AreaName].InnerPlotPosition.Auto = false;
			Chart1.ChartAreas[AreaName].InnerPlotPosition.Height = 98;
			Chart1.ChartAreas[AreaName].InnerPlotPosition.Width = 98;
			Chart1.ChartAreas[AreaName].InnerPlotPosition.X = 1;
			Chart1.ChartAreas[AreaName].InnerPlotPosition.Y = 1;

			Chart1.ChartAreas[AreaName].Position.X = 2 + level * 14;
			Chart1.ChartAreas[AreaName].Position.Y = 2 + level * 14;
			Chart1.ChartAreas[AreaName].Position.Height = 94 - level * 28;
			Chart1.ChartAreas[AreaName].Position.Width = 94 - level * 28;

			Chart1.ChartAreas[AreaName].Area3DStyle.Enable3D = true;
			Chart1.ChartAreas[AreaName].Area3DStyle.Inclination = 0;
		}

		private void Series2Checkbox_CheckedChanged(object sender, System.EventArgs e)
		{
			Chart1.Series["Series1"].ChartArea = "Area1";
			Chart1.Series["Series2"].ChartArea = "Area2";
			Chart1.Series["Series3"].ChartArea = "Area3";
			if(Series2Checkbox.Checked)
			{
				Chart1.Series["Series2"]["DoughnutRadius"] = "37";
				Series3Checkbox.Enabled = true;
				Chart1.Series["Series2"].Enabled = true;
			}
			else
			{
				Series3Checkbox.Enabled = false;
				Chart1.Series["Series2"].Enabled = false;
			}

			if(Series2Checkbox.Checked && Series3Checkbox.Checked)
			{
				Chart1.Series["Series3"].Enabled = true;
				Chart1.Series["Series3"]["DoughnutRadius"] = "49";
			}
			else
			{
				Chart1.Series["Series3"].Enabled = false;
			}


		}

		private void RotateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			if(Chart1.ChartAreas["Area1"].Area3DStyle.Rotation < 180)
				Chart1.ChartAreas["Area1"].Area3DStyle.Rotation += 3;
			else
				Chart1.ChartAreas["Area1"].Area3DStyle.Rotation = -180;

			if(Chart1.ChartAreas["Area2"].Area3DStyle.Rotation > -180)
				Chart1.ChartAreas["Area2"].Area3DStyle.Rotation -= 2;
			else
				Chart1.ChartAreas["Area2"].Area3DStyle.Rotation = 180;

			if(Chart1.ChartAreas["Area3"].Area3DStyle.Rotation < 180)
				Chart1.ChartAreas["Area3"].Area3DStyle.Rotation += 1;
			else
				Chart1.ChartAreas["Area3"].Area3DStyle.Rotation = -180;
		}

		private void PsychCheckbox_CheckedChanged(object sender, System.EventArgs e)
		{
			RotateTimer.Enabled = PsychCheckbox.Checked;
		}


	}
}
