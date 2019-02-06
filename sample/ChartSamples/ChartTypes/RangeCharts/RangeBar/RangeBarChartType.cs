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
	/// Summary description for RangeBarChartType.
	/// </summary>
	public class RangeBarChartType : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkBoxShow3D;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RangeBarChartType()
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
            this.checkBoxShow3D = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
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
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 80F;
            chartArea1.Position.Width = 87F;
            chartArea1.Position.X = 5F;
            chartArea1.Position.Y = 6F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            legend1.Position.Auto = false;
            legend1.Position.Height = 9.054053F;
            legend1.Position.Width = 36.26765F;
            legend1.Position.X = 54.46494F;
            legend1.Position.Y = 85F;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 48);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "PointWidth=0.7";
            series1.Legend = "Default";
            series1.Name = "Tasks";
            series1.YValuesPerPoint = 2;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.CustomProperties = "DrawSideBySide=false, PointWidth=0.2";
            series2.Legend = "Default";
            series2.Name = "Progress";
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 0;
            this.chart1.PostPaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.chart1_PostPaint);
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 26);
            this.labelSampleComment.TabIndex = 2;
            this.labelSampleComment.Text = "This sample demonstrates the Range Bar chart type in both 2D and 3D.";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxShow3D);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBoxShow3D
            // 
            this.checkBoxShow3D.Location = new System.Drawing.Point(48, 16);
            this.checkBoxShow3D.Name = "checkBoxShow3D";
            this.checkBoxShow3D.Size = new System.Drawing.Size(208, 24);
            this.checkBoxShow3D.TabIndex = 7;
            this.checkBoxShow3D.Text = "Display chart as 3&D";
            this.checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
            // 
            // RangeBarChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RangeBarChartType";
            this.Size = new System.Drawing.Size(728, 376);
            this.Load += new System.EventHandler(this.RangeBarChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void RangeBarChartType_Load(object sender, System.EventArgs e)
		{
			// Populate series data
			DateTime	currentData = DateTime.Now.Date;
			chart1.Series["Tasks"].Points.AddXY(1, currentData, currentData.AddDays(4));
			chart1.Series["Tasks"].Points.AddXY(2, currentData.AddDays(5), currentData.AddDays(7));
			chart1.Series["Tasks"].Points.AddXY(3, currentData.AddDays(8), currentData.AddDays(10));
			chart1.Series["Tasks"].Points.AddXY(1, currentData.AddDays(12), currentData.AddDays(15));
			chart1.Series["Tasks"].Points.AddXY(4, currentData.AddDays(17), currentData.AddDays(22));
			chart1.Series["Tasks"].Points.AddXY(2, currentData.AddDays(23), currentData.AddDays(27));

			chart1.Series["Progress"].Points.AddXY(1, currentData, currentData.AddDays(4));
			chart1.Series["Progress"].Points.AddXY(2, currentData.AddDays(5), currentData.AddDays(7));
			chart1.Series["Progress"].Points.AddXY(3, currentData.AddDays(8), currentData.AddDays(10));
			chart1.Series["Progress"].Points.AddXY(1, currentData.AddDays(12), currentData.AddDays(13));

			// Set axis labels
			chart1.Series["Tasks"].Points[0].AxisLabel = "Task 1";
			chart1.Series["Tasks"].Points[1].AxisLabel = "Task 2";
			chart1.Series["Tasks"].Points[2].AxisLabel = "Task 3";
			chart1.Series["Tasks"].Points[4].AxisLabel = "Task 4";

			// Set Range Bar chart type
			chart1.Series["Tasks"].ChartType = SeriesChartType.RangeBar;
			chart1.Series["Progress"].ChartType = SeriesChartType.RangeBar;

			// Set point width
			chart1.Series["Tasks"]["PointWidth"] = "0.7";
			chart1.Series["Progress"]["PointWidth"] = "0.2";

			// Set Y axis Minimum and Maximum
			chart1.ChartAreas["Default"].AxisY.Minimum = currentData.AddDays(-1).ToOADate();
			chart1.ChartAreas["Default"].AxisY.Maximum = currentData.AddDays(28).ToOADate();
			chart1.ChartAreas["Default"].AxisY.LabelStyle.Format = "MMM dd";
		}


		private void chart1_PostPaint(object sender, System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e)
		{
			if(sender is ChartArea)
			{
				Series series = chart1.Series["Tasks"];
				// Take Graphics object from chart
				Graphics graph = e.ChartGraphics.Graphics;

				for(int i = 0; i < series.Points.Count; i++)
				{
					if((i+1) < series.Points.Count && i != 1 && i != 3)
					{
						double p1X, p2X, p1Y, p2Y;
						
						p1X = series.Points[i].XValue;
						p2X = series.Points[i+1].XValue;
						p1Y = series.Points[i].YValues[1];
						p2Y = series.Points[i+1].YValues[0];

						float pixelX1 = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.Y,p1Y);
						float pixelY1 = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X,p1X);
						float pixelX2 = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.Y,p2Y);
						float pixelY2 = (float)e.ChartGraphics.GetPositionFromAxis("Default",AxisName.X,p2X);

						PointF point1 = PointF.Empty;
						PointF point2 = PointF.Empty;
						PointF point3 = PointF.Empty;

						point1.X = pixelX1;
						point1.Y = pixelY1;
						point2.X = pixelX2;
						point2.Y = pixelY2;

						// make the middle right-angle point
						point3.X = pixelX2;
						point3.Y = pixelY1;

						// If 3D, we need to transform the 3D points into 2D points
						if(checkBoxShow3D.Checked)
						{							
							// Get Z position for this series, and then add half of series depth so that
							//   custom drawing occurs at the front of the data points
							float ZPosition = chart1.ChartAreas["Default"].GetSeriesZPosition(series);
							ZPosition = ZPosition + (float)0.5*(chart1.ChartAreas["Default"].GetSeriesDepth(series));
							// Create 3D points for the 2D points
							Point3D[] My3DPoint = new Point3D[3];								
							My3DPoint[0] = new Point3D(point1.X,point1.Y,ZPosition);
							My3DPoint[1] = new Point3D(point2.X,point2.Y,ZPosition);
							My3DPoint[2] = new Point3D(point3.X,point3.Y,ZPosition);								
							// Transform so that new 2D points has new X and Y values that take into account the Z position
							chart1.ChartAreas["Default"].TransformPoints(My3DPoint);
							point1 = My3DPoint[0].PointF;
							point2 = My3DPoint[1].PointF;
							point3 = My3DPoint[2].PointF;								
						}

						// Convert relative coordinates to absolute coordinates.
						point1 = e.ChartGraphics.GetAbsolutePoint(point1);
						point2 = e.ChartGraphics.GetAbsolutePoint(point2);
						point3 = e.ChartGraphics.GetAbsolutePoint(point3);

						// Draw connection line
						graph.DrawLine(new Pen(Color.Black,2), point1,point3);
						graph.DrawLine(new Pen(Color.Black,2), point3,point2);

						DrawArrow(graph, Color.Black, point2, point3, 22.5);
					}
				}
				
			}
		
		}			
		
		/// <summary>
		/// This Method will draw an arrow head on at the end of a line segment
		/// as defined by two points, p1 and p2
		/// </summary>
		private void DrawArrow(Graphics graph, Color brushcolor, PointF p1, PointF p2, double angle_deg)
		{
			// using the two points, p1 and p2, we must first calculate the two
			// other points to use for the triangular arrow.  The provided angle
			// must be in degrees and be converted to radians.

			double rad = angle_deg * Math.PI / 180;

			// to simplify calcuations find dx and dy for points p1 and p2
			double dx = p1.X-p2.X;
			double dy = p1.Y-p2.Y;

			double c = Math.Sqrt((Math.Pow(dx,2) + Math.Pow(dy,2)));

			// to create an approximately 7px arrow, we need c to be 70 and a line_legnth of 0.1
			// There are instances where c will be less causing the 10% scale to be such that
			// the arrow head will be invisible. Similarly, when c is really large the arrow 
			// head can be huge.
			double pixels = 12;
			double line_length = (1 / ( c / pixels));

			PointF arrow_segment1 = Point.Empty;
			PointF arrow_segment2 = Point.Empty;

			arrow_segment1.X = p1.X - (float)((dx*Math.Cos(rad) - dy*Math.Sin(rad))* line_length);
			arrow_segment1.Y = p1.Y - (float)((dy*Math.Cos(rad) + dx*Math.Sin(rad))* line_length);

			arrow_segment2.X = p1.X - (float)((dx*Math.Cos(-rad) - dy*Math.Sin(-rad))* line_length);
			arrow_segment2.Y = p1.Y - (float)((dy*Math.Cos(-rad) + dx*Math.Sin(-rad))* line_length);

			PointF[] arrowhead =	{
										p1,
										arrow_segment1,
										arrow_segment2
									};

			SolidBrush brush = new SolidBrush(brushcolor);
			graph.FillPolygon(brush, arrowhead);

		}

		private void checkBoxShow3D_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBoxShow3D.Checked)
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = true;
				chart1.Series["Progress"]["DrawSideBySide"] = "true";
			}
			else{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = false;
				chart1.Series["Progress"]["DrawSideBySide"] = "false";
			}
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

	}
}
