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
	/// Summary description for Cylinder3D.
	/// </summary>
	public class Cylinder3D : System.Windows.Forms.UserControl
	{
		private	Point	mouseDownPoint = Point.Empty;
		private	int		origRotation = 0;
		private	int		origInclination = 0;

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radioButtonColumn;
		private System.Windows.Forms.RadioButton radioButtonBar;
		private System.Windows.Forms.CheckBox checkClustered;
		private System.Windows.Forms.NumericUpDown numericUpDownPointGapDepth;
		private System.Windows.Forms.NumericUpDown numericUpDownPointDepth;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Cylinder3D()
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 9);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7.5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5.6999998092651367);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8.5);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 9);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 4);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSampleComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownPointGapDepth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPointDepth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkClustered = new System.Windows.Forms.CheckBox();
            this.radioButtonColumn = new System.Windows.Forms.RadioButton();
            this.radioButtonBar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointGapDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointDepth)).BeginInit();
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
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Hand;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 53);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.Points.Add(dataPoint15);
            series3.Points.Add(dataPoint16);
            series3.Points.Add(dataPoint17);
            series3.Points.Add(dataPoint18);
            series3.Points.Add(dataPoint19);
            series3.Points.Add(dataPoint20);
            series3.Points.Add(dataPoint21);
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 1;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "3D Cylinder";
            this.chart1.Titles.Add(title1);
            this.chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseUp);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseDown);
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 37);
            this.labelSampleComment.TabIndex = 0;
            this.labelSampleComment.Text = "This sample demonstrates how to display 3D Bar and Column charts as cylinders. Cy" +
                "linders may be applied to an entire data series or to specific points within a s" +
                "eries. ";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownPointGapDepth);
            this.panel1.Controls.Add(this.numericUpDownPointDepth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkClustered);
            this.panel1.Controls.Add(this.radioButtonColumn);
            this.panel1.Controls.Add(this.radioButtonBar);
            this.panel1.Location = new System.Drawing.Point(432, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 280);
            this.panel1.TabIndex = 2;
            // 
            // numericUpDownPointGapDepth
            // 
            this.numericUpDownPointGapDepth.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownPointGapDepth.Location = new System.Drawing.Point(168, 136);
            this.numericUpDownPointGapDepth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPointGapDepth.Name = "numericUpDownPointGapDepth";
            this.numericUpDownPointGapDepth.Size = new System.Drawing.Size(56, 22);
            this.numericUpDownPointGapDepth.TabIndex = 6;
            this.numericUpDownPointGapDepth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPointGapDepth.ValueChanged += new System.EventHandler(this.numericUpDownPointGapDepth_ValueChanged);
            // 
            // numericUpDownPointDepth
            // 
            this.numericUpDownPointDepth.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownPointDepth.Location = new System.Drawing.Point(168, 104);
            this.numericUpDownPointDepth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPointDepth.Name = "numericUpDownPointDepth";
            this.numericUpDownPointDepth.Size = new System.Drawing.Size(56, 22);
            this.numericUpDownPointDepth.TabIndex = 4;
            this.numericUpDownPointDepth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPointDepth.ValueChanged += new System.EventHandler(this.numericUpDownPointDepth_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "&Gap Depth:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Point &Depth:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkClustered
            // 
            this.checkClustered.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkClustered.Checked = true;
            this.checkClustered.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkClustered.Location = new System.Drawing.Point(45, 72);
            this.checkClustered.Name = "checkClustered";
            this.checkClustered.Size = new System.Drawing.Size(136, 24);
            this.checkClustered.TabIndex = 2;
            this.checkClustered.Text = "C&lustered:";
            this.checkClustered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkClustered.CheckedChanged += new System.EventHandler(this.checkClustered_CheckedChanged);
            // 
            // radioButtonColumn
            // 
            this.radioButtonColumn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonColumn.Checked = true;
            this.radioButtonColumn.Location = new System.Drawing.Point(13, 40);
            this.radioButtonColumn.Name = "radioButtonColumn";
            this.radioButtonColumn.Size = new System.Drawing.Size(168, 24);
            this.radioButtonColumn.TabIndex = 1;
            this.radioButtonColumn.TabStop = true;
            this.radioButtonColumn.Text = "3D &Column Cylinder:";
            this.radioButtonColumn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonColumn.CheckedChanged += new System.EventHandler(this.radioButtonColumn_CheckedChanged);
            // 
            // radioButtonBar
            // 
            this.radioButtonBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonBar.Location = new System.Drawing.Point(29, 8);
            this.radioButtonBar.Name = "radioButtonBar";
            this.radioButtonBar.Size = new System.Drawing.Size(152, 24);
            this.radioButtonBar.TabIndex = 0;
            this.radioButtonBar.Text = "3D &Bar Cylinder:";
            this.radioButtonBar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonBar.CheckedChanged += new System.EventHandler(this.radioButtonBar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click on the chart and drag the mouse to rotate the chart.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cylinder3D
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Cylinder3D";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.Cylinder3D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointGapDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointDepth)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Set Cylinder drawing style attribute
			chart1.Series["Default"]["DrawingStyle"] = "Cylinder";
			chart1.Series["Series2"]["DrawingStyle"] = "Cylinder";
			chart1.Series["Series3"]["DrawingStyle"] = "Cylinder";

			if(radioButtonBar.Checked)
			{
				// Set chart type to Bar
				chart1.Series["Default"].ChartType = SeriesChartType.Bar;
				chart1.Series["Series2"].ChartType = SeriesChartType.Bar;
				chart1.Series["Series3"].ChartType = SeriesChartType.Bar;
			}
			else
			{
				// Set chart type to Column
				chart1.Series["Default"].ChartType = SeriesChartType.Column;
				chart1.Series["Series2"].ChartType = SeriesChartType.Column;
				chart1.Series["Series3"].ChartType = SeriesChartType.Column;
			}

			// Disable/enable clustered series
			chart1.ChartAreas["Default"].Area3DStyle.IsClustered = checkClustered.Checked;

			// Set point depth
			chart1.ChartAreas["Default"].Area3DStyle.PointDepth = (int)numericUpDownPointDepth.Value;
			chart1.ChartAreas["Default"].Area3DStyle.PointGapDepth = (int)numericUpDownPointGapDepth.Value;
		}

		private void radioButtonBar_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void radioButtonColumn_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkClustered_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void numericUpDownPointDepth_ValueChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void numericUpDownPointGapDepth_ValueChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void chart1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			chart1.Cursor = Cursors.NoMove2D;	
			mouseDownPoint = new Point(e.X, e.Y);
			origRotation = this.chart1.ChartAreas[0].Area3DStyle.Rotation;
			origInclination = this.chart1.ChartAreas[0].Area3DStyle.Inclination;
		}

		private void chart1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			chart1.Cursor = Cursors.Hand;	
			mouseDownPoint = Point.Empty;
		}

		private void chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(!mouseDownPoint.IsEmpty)
			{
				int		RotationDelta = (mouseDownPoint.X - e.X);
				int		Rotation = origRotation;
				for(int i = 0; i != RotationDelta; )
				{
					if(RotationDelta > 0)
					{
						if(Rotation >= 180)
						{
							Rotation = -180;
						}
						++Rotation;
					}
					else
					{
						if(Rotation <= -180)
						{
							Rotation = 180;
						}
						--Rotation;
					}

					i += (RotationDelta > 0) ? 1 : -1;
				}
				this.chart1.ChartAreas[0].Area3DStyle.Rotation = Rotation;

				int		InclinationDelta = (e.Y - mouseDownPoint.Y);
				int		Inclination = origInclination;
				for(int i = 0; i != InclinationDelta; )
				{
					if(InclinationDelta > 0)
					{
						if(Inclination >= 90)
						{
							Inclination = -90;
						}
						++Inclination;
					}
					else
					{
						if(Inclination <= -90)
						{
							Inclination = 90;
						}
						--Inclination;
					}

					i += (InclinationDelta > 0) ? 1 : -1;
				}
				this.chart1.ChartAreas[0].Area3DStyle.Inclination = Inclination;

				this.chart1.Invalidate();
				this.chart1.Update();
			}
		}

		private void Cylinder3D_Load(object sender, System.EventArgs e)
		{
			// Set Cylinder drawing style attribute
			chart1.Series["Default"]["DrawingStyle"] = "Cylinder";
			chart1.Series["Series2"]["DrawingStyle"] = "Cylinder";
			chart1.Series["Series3"]["DrawingStyle"] = "Cylinder";
		}

	}
}
