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
	/// Summary description for PrePostPaint.
	/// </summary>
	public class PrePostPaint : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox ConnectionLine;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PrePostPaint()
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label9 = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ConnectionLine = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 43);
            this.label9.TabIndex = 2;
            this.label9.Text = "This sample demonstrates how to draw custom items using the PrePaint and PostPain" +
                "t events.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            chartArea2.Area3DStyle.Inclination = 15;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Perspective = 10;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "Default";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.Chart1.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Enabled = false;
            legend2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Default";
            this.Chart1.Legends.Add(legend2);
            this.Chart1.Location = new System.Drawing.Point(16, 65);
            this.Chart1.Name = "Chart1";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.BorderWidth = 3;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Default";
            series2.MarkerColor = System.Drawing.Color.AliceBlue;
            series2.MarkerSize = 8;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series2.Name = "Default";
            series2.ShadowColor = System.Drawing.Color.Black;
            series2.ShadowOffset = 2;
            this.Chart1.Series.Add(series2);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 0;
            title2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title2.Name = "Title1";
            title2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title2.ShadowOffset = 3;
            title2.Text = "PrePaint and PostPaint Events";
            this.Chart1.Titles.Add(title2);
            this.Chart1.PostPaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.Chart1_PostPaint);
            this.Chart1.PrePaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.Chart1_PrePaint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ConnectionLine);
            this.panel1.Location = new System.Drawing.Point(432, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(88, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Random Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConnectionLine
            // 
            this.ConnectionLine.Checked = true;
            this.ConnectionLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConnectionLine.Location = new System.Drawing.Point(48, 16);
            this.ConnectionLine.Name = "ConnectionLine";
            this.ConnectionLine.Size = new System.Drawing.Size(232, 32);
            this.ConnectionLine.TabIndex = 0;
            this.ConnectionLine.Text = "Show Max-Min &Connection Line";
            this.ConnectionLine.CheckedChanged += new System.EventHandler(this.ConnectionLine_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data points with the maximum and minimum Y values are highlighted. Horizontal and" +
                " connection lines are also drawn in this sample.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PrePostPaint
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PrePostPaint";
            this.Size = new System.Drawing.Size(728, 440);
            this.Load += new System.EventHandler(this.PrePostPaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion


		private void PrePostPaint_Load(object sender, System.EventArgs e)
		{
			// Populate series data with random data
			Random	random = new Random();
			for(int pointIndex = 0; pointIndex < 25; pointIndex++)
			{
				Chart1.Series["Default"].Points.AddXY(pointIndex, random.Next(5, 60));
			}

		}

		private void FindMaxMin( out double max, out double min, out double xMax, out double xMin )
		{

			max = double.MinValue;
			min = double.MaxValue;

			xMax = 0;
			xMin = 0;

			// Find Minimum and Maximum Y values and corresponding X positions
			foreach( DataPoint point in Chart1.Series["Default"].Points )
			{
				if( point.YValues[0] > max )
				{
					max = point.YValues[0];
					xMax = point.XValue;
				}

				if( point.YValues[0] < min )
				{
					min = point.YValues[0];
					xMin = point.XValue;
				}
			}
		}

		private void Chart1_PostPaint(object sender, System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e)
		{
			if(e.ChartElement is ChartArea)
			{
				ChartArea area = (ChartArea)e.ChartElement;
				if(area.Name == "Default")
				{
					// If Connection line is not checked return
					if( !ConnectionLine.Checked )
						return;

					double max;
					double min;
					double xMax;
					double xMin;

					// Find Minimum and Maximum values
					FindMaxMin( out max, out min, out xMax, out xMin );

					// Take Graphics object from chart
					Graphics graph = e.ChartGraphics.Graphics;

					// Convert X and Y values to screen position
					float pixelYMax = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.Y,max);
					float pixelXMax = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X,xMax);
					float pixelYMin = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.Y,min);
					float pixelXMin = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X,xMin);

					PointF point1 = PointF.Empty;
					PointF point2 = PointF.Empty;

					// Set Maximum and minimum points
					point1.X = pixelXMax;
					point1.Y = pixelYMax;
					point2.X = pixelXMin;
					point2.Y = pixelYMin;

					// Convert relative coordinates to absolute coordinates.
					point1 = e.ChartGraphics.GetAbsolutePoint(point1);
					point2 = e.ChartGraphics.GetAbsolutePoint(point2);

					// Draw connection line
					graph.DrawLine(new Pen(Color.FromArgb(26, 59, 105), 2), point1,point2);
				}
			}
		
		}

		private void Chart1_PrePaint(object sender, System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e)
		{
			if(e.ChartElement is ChartArea)
			{
				ChartArea area = (ChartArea)e.ChartElement;
				if(area.Name == "Default")
				{
					double max;
					double min;
					double xMax;
					double xMin;

					// Find Minimum and Maximum values
					FindMaxMin( out max, out min, out xMax, out xMin );
					
					// Take Graphics object from chart
					Graphics graph = e.ChartGraphics.Graphics;

					// Convert X and Y values to screen position
					float pixelYMax = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.Y,max);
					float pixelXMax = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X,xMax);
					float pixelYMin = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.Y,min);
					float pixelXMin = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X,xMin);

					float XMin = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X, area.AxisX.Minimum);
					float XMax = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X, area.AxisX.Maximum);

					// Specify with of triangle
					float width = 3;

					// Set Maximum points
					PointF [] points = new PointF[3];
					points[0].X = pixelXMax - width;
					points[0].Y = pixelYMax - width - 2;
					points[1].X = pixelXMax + width;
					points[1].Y = pixelYMax - width - 2;
					points[2].X = pixelXMax;
					points[2].Y = pixelYMax - 1;

					// Convert relative coordinates to absolute coordinates.
					points[0] = e.ChartGraphics.GetAbsolutePoint(points[0]);
					points[1] = e.ChartGraphics.GetAbsolutePoint(points[1]);
					points[2] = e.ChartGraphics.GetAbsolutePoint(points[2]);

					// Draw Maximum trangle
					Pen darkPen = new Pen(Color.FromArgb(26, 59, 105), 1);
					graph.FillPolygon(new SolidBrush(Color.FromArgb(220, 252, 180, 65)), points);
					graph.DrawPolygon(darkPen, points);
					
					points[0].X = XMin;
					points[1].X = XMax;
					points[0].Y = points[1].Y = pixelYMax;

					// Convert relative coordinates to absolute coordinates.
					points[0] = e.ChartGraphics.GetAbsolutePoint(points[0]);
					points[1] = e.ChartGraphics.GetAbsolutePoint(points[1]);

					graph.DrawLine(darkPen, points[0], points[1]);

					// Set Minimum points
					points = new PointF[3];
					points[0].X = pixelXMin - width;
					points[0].Y = pixelYMin + width + 2;
					points[1].X = pixelXMin + width;
					points[1].Y = pixelYMin + width + 2;
					points[2].X = pixelXMin;
					points[2].Y = pixelYMin + 1;

					// Convert relative coordinates to absolute coordinates.
					points[0] = e.ChartGraphics.GetAbsolutePoint(points[0]);
					points[1] = e.ChartGraphics.GetAbsolutePoint(points[1]);
					points[2] = e.ChartGraphics.GetAbsolutePoint(points[2]);

					// Draw Minimum trangle
					graph.FillPolygon(new SolidBrush(Color.FromArgb(220, 224, 64, 10)), points);
					graph.DrawPolygon(darkPen, points);
					points[0].X = XMin;
					points[1].X = XMax;
					points[0].Y = points[1].Y = pixelYMin;

					// Convert relative coordinates to absolute coordinates.
					points[0] = e.ChartGraphics.GetAbsolutePoint(points[0]);
					points[1] = e.ChartGraphics.GetAbsolutePoint(points[1]);

					graph.DrawLine(darkPen, points[0], points[1]);

				}
			}
		}

		private void ConnectionLine_CheckedChanged(object sender, System.EventArgs e)
		{
			Chart1.Invalidate();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Chart1.Series["Default"].Points.Clear();
			PrePostPaint_Load(sender, e);
			Chart1.Invalidate();
		}

	}
}
