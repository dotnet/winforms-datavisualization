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
	/// Summary description for AnnotationAnchoring.
	/// </summary>
	public class AnnotationPositionChanging : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.CheckBox SnapToDataPoint;
		private System.Windows.Forms.Button ResetPosition;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label AnchorXLocation;
		private System.Windows.Forms.Label AnchorX;
		private System.Windows.Forms.Label AnchorY;
		private System.Windows.Forms.Label label2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AnnotationPositionChanging()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			UpdateAnnotationPosition(Chart1.Annotations[0]);

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
            System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation calloutAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 700);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 400);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 200);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 450);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5, 300);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6, 756);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7, 398);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8, 467);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9, 612);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10, 356);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(11, 678);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnnotationPositionChanging));
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AnchorY = new System.Windows.Forms.Label();
            this.AnchorX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnchorXLocation = new System.Windows.Forms.Label();
            this.ResetPosition = new System.Windows.Forms.Button();
            this.SnapToDataPoint = new System.Windows.Forms.CheckBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 1;
            this.label9.Text = "This sample demonstrates the AnnotationPositionChanging event. ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AnchorY);
            this.panel1.Controls.Add(this.AnchorX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AnchorXLocation);
            this.panel1.Controls.Add(this.ResetPosition);
            this.panel1.Controls.Add(this.SnapToDataPoint);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 19;
            // 
            // AnchorY
            // 
            this.AnchorY.ForeColor = System.Drawing.Color.Red;
            this.AnchorY.Location = new System.Drawing.Point(168, 80);
            this.AnchorY.Name = "AnchorY";
            this.AnchorY.Size = new System.Drawing.Size(72, 23);
            this.AnchorY.TabIndex = 8;
            this.AnchorY.Text = "label4";
            this.AnchorY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnchorX
            // 
            this.AnchorX.ForeColor = System.Drawing.Color.Red;
            this.AnchorX.Location = new System.Drawing.Point(168, 48);
            this.AnchorX.Name = "AnchorX";
            this.AnchorX.Size = new System.Drawing.Size(72, 23);
            this.AnchorX.TabIndex = 7;
            this.AnchorX.Text = "label4";
            this.AnchorX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Anchor Position Y:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AnchorXLocation
            // 
            this.AnchorXLocation.Location = new System.Drawing.Point(16, 48);
            this.AnchorXLocation.Name = "AnchorXLocation";
            this.AnchorXLocation.Size = new System.Drawing.Size(144, 23);
            this.AnchorXLocation.TabIndex = 3;
            this.AnchorXLocation.Text = "Anchor Position X:";
            this.AnchorXLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResetPosition
            // 
            this.ResetPosition.BackColor = System.Drawing.SystemColors.Control;
            this.ResetPosition.Location = new System.Drawing.Point(64, 120);
            this.ResetPosition.Name = "ResetPosition";
            this.ResetPosition.Size = new System.Drawing.Size(136, 23);
            this.ResetPosition.TabIndex = 2;
            this.ResetPosition.Text = "&Reset Position";
            this.ResetPosition.UseVisualStyleBackColor = false;
            this.ResetPosition.Click += new System.EventHandler(this.ResetPosition_Click);
            // 
            // SnapToDataPoint
            // 
            this.SnapToDataPoint.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SnapToDataPoint.Checked = true;
            this.SnapToDataPoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SnapToDataPoint.Location = new System.Drawing.Point(11, 16);
            this.SnapToDataPoint.Name = "SnapToDataPoint";
            this.SnapToDataPoint.Size = new System.Drawing.Size(168, 24);
            this.SnapToDataPoint.TabIndex = 0;
            this.SnapToDataPoint.Text = "&Snap to DataPoint";
            this.SnapToDataPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Chart1
            // 
            calloutAnnotation1.AllowAnchorMoving = true;
            calloutAnnotation1.AllowSelecting = true;
            calloutAnnotation1.AnchorDataPointName = "Default\\r2";
            calloutAnnotation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            calloutAnnotation1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            calloutAnnotation1.Name = "Callout1";
            calloutAnnotation1.Text = "Select this Annotation Object\\nand move the Anchor point";
            calloutAnnotation1.ToolTip = "Don\'t forget to move the anchor point";
            this.Chart1.Annotations.Add(calloutAnnotation1);
            this.Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            this.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            this.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.Chart1.BorderlineWidth = 2;
            this.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 67F;
            chartArea1.InnerPlotPosition.Width = 80F;
            chartArea1.InnerPlotPosition.X = 12F;
            chartArea1.InnerPlotPosition.Y = 22F;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 95F;
            chartArea1.Position.Width = 99F;
            chartArea1.Position.X = 1F;
            chartArea1.Position.Y = 1F;
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
            series1.Name = "Default";
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
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Position Changed Event";
            this.Chart1.Titles.Add(title1);
            this.Chart1.AnnotationPositionChanged += new System.EventHandler(this.Chart1_AnnotationPositionChanged);
            this.Chart1.AnnotationSelectionChanged += new System.EventHandler(this.Chart1_AnnotationSelectionChanged);
            this.Chart1.AnnotationPositionChanging += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.AnnotationPositionChangingEventArgs>(this.Chart1_AnnotationPositionChanging);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(702, 57);
            this.label2.TabIndex = 20;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnnotationPositionChanging
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AnnotationPositionChanging";
            this.Size = new System.Drawing.Size(728, 480);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void Chart1_AnnotationPositionChanging(object sender, System.Windows.Forms.DataVisualization.Charting.AnnotationPositionChangingEventArgs e)
		{
			if(SnapToDataPoint.Checked)
			{
				// get the annotation object from the AnnotationPositionChangingEventArgs
				Annotation annotation = e.Annotation;

				if(!float.IsNaN(e.NewAnchorLocation.X))
				{
					// get the nearest point to the new location
					PointF point = FindNearestDataPoint(e.NewAnchorLocation.X, e.NewAnchorLocation.Y);

					annotation.AnchorDataPoint = Chart1.Series[0].Points[(int)point.X - 1];
					e.NewAnchorLocationX= point.X;
					e.NewAnchorLocationY = point.Y;
				}
			}
			else
			{
				if(!float.IsNaN(e.NewAnchorLocation.X) && e.NewAnchorLocation.X > Chart1.ChartAreas[0].AxisX.Maximum)
				{
					e.NewAnchorLocationX = (float)(Chart1.ChartAreas[0].AxisX.Maximum);
				}
				else if(!float.IsNaN(e.NewAnchorLocation.X) && e.NewAnchorLocation.X < Chart1.ChartAreas[0].AxisX.Minimum)
				{
					e.NewAnchorLocationX = 0;
				}

				if(!float.IsNaN(e.NewAnchorLocation.X) && e.NewAnchorLocation.Y > Chart1.ChartAreas[0].AxisY.Maximum)
				{
					e.NewAnchorLocationY = (float)(Chart1.ChartAreas[0].AxisY.Maximum);
				}
				else if(!float.IsNaN(e.NewAnchorLocation.Y) && e.NewAnchorLocation.Y < 1)
				{
					e.NewAnchorLocationY = 1;
				}

			}
		}

		private PointF FindNearestDataPoint(double X, double Y)
		{
			// get the int portion of the X value
            int curIndex = (int)Math.Round(X);

			// if curIndex is less than 1 curIndex is set to 1
			curIndex = (int)Math.Max(curIndex, 1);

			// if curIndex is greater than 11 curIndex is set to 11 (X Value of max point in series)
			curIndex = (int)Math.Min(curIndex, 11);

			// return the point value of the nearest point
			return new PointF(curIndex, (float)Chart1.Series[0].Points[curIndex-1].YValues[0]);
		}

		private void Chart1_AnnotationPositionChanged(object sender, System.EventArgs e)
		{
			Annotation annotation = (Annotation) sender;
			UpdateAnnotationPosition(annotation);
		}


		private void UpdateAnnotationPosition(Annotation annotation)
		{
			// update the UI for the new positions...

			if(SnapToDataPoint.Checked)
			{
				AnchorX.Text = annotation.AnchorDataPoint.XValue.ToString("#.#");
				AnchorY.Text = annotation.AnchorDataPoint.YValues[0].ToString("#.#");
			}
			else
			{
				AnchorX.Text = annotation.AnchorX.ToString("#.#");
				AnchorY.Text = annotation.AnchorY.ToString("#.#");
			}

			if(AnchorX.Text == "NaN")
				AnchorX.Text = "Auto";

			if(AnchorY.Text == "NaN")
				AnchorY.Text = "Auto";

		}

		private void ResetPosition_Click(object sender, System.EventArgs e)
		{
			Chart1.Annotations[0].AnchorX = double.NaN;
			Chart1.Annotations[0].AnchorY = double.NaN;
			Chart1.Annotations[0].AnchorDataPoint = Chart1.Series[0].Points[2];

			UpdateAnnotationPosition(Chart1.Annotations[0]);

			Chart1.Invalidate();
		}

        private void Chart1_AnnotationSelectionChanged(object sender, EventArgs e)
        {

        }

	}
}
