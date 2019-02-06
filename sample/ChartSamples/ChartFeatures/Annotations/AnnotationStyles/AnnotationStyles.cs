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
	/// Summary description for AnnotationStyles.
	/// </summary>
	public class AnnotationStyles : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.ComboBox AnnotationStyle;
		private System.Windows.Forms.ComboBox Annotation;
		private System.Windows.Forms.ComboBox AnnotationStyle1;
		private System.Windows.Forms.Label StyleLabel2;
		private System.Windows.Forms.Label StyleLabel1;
		private System.Windows.Forms.ComboBox AnnotationStyle2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AnnotationStyles()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			Annotation.SelectedIndex = 6;

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
            System.Windows.Forms.DataVisualization.Charting.PolylineAnnotation polylineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.PolylineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint annotationPathPoint1 = new System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint();
            System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint annotationPathPoint2 = new System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint();
            System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint annotationPathPoint3 = new System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint();
            System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint annotationPathPoint4 = new System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint();
            System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint annotationPathPoint5 = new System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 800);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 600);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 300);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 750);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 300);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 600);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 300);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 330);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 200);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 300);
            this.Annotation = new System.Windows.Forms.ComboBox();
            this.AnnotationStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AnnotationStyle2 = new System.Windows.Forms.ComboBox();
            this.StyleLabel1 = new System.Windows.Forms.Label();
            this.StyleLabel2 = new System.Windows.Forms.Label();
            this.AnnotationStyle1 = new System.Windows.Forms.ComboBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Annotation
            // 
            this.Annotation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Annotation.Items.AddRange(new object[] {
            "Line",
            "Vertical Line",
            "Horizontal Line",
            "Text",
            "Rectangle",
            "Ellipse",
            "Arrow",
            "Border3D",
            "Callout",
            "Polyline",
            "Polygon",
            "Image"});
            this.Annotation.Location = new System.Drawing.Point(168, 8);
            this.Annotation.Name = "Annotation";
            this.Annotation.Size = new System.Drawing.Size(121, 22);
            this.Annotation.TabIndex = 1;
            this.Annotation.SelectedIndexChanged += new System.EventHandler(this.Annotation_SelectedIndexChanged);
            // 
            // AnnotationStyle
            // 
            this.AnnotationStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnnotationStyle.Location = new System.Drawing.Point(168, 40);
            this.AnnotationStyle.Name = "AnnotationStyle";
            this.AnnotationStyle.Size = new System.Drawing.Size(121, 22);
            this.AnnotationStyle.TabIndex = 3;
            this.AnnotationStyle.SelectedIndexChanged += new System.EventHandler(this.AnnotationStyle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Annotation &Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Style:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 43);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to set the different styles of each annotation type." +
                " When using each type, you can further adjust the styles.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AnnotationStyle2);
            this.panel1.Controls.Add(this.StyleLabel1);
            this.panel1.Controls.Add(this.StyleLabel2);
            this.panel1.Controls.Add(this.AnnotationStyle1);
            this.panel1.Controls.Add(this.Annotation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AnnotationStyle);
            this.panel1.Location = new System.Drawing.Point(432, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 0;
            // 
            // AnnotationStyle2
            // 
            this.AnnotationStyle2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnnotationStyle2.Location = new System.Drawing.Point(168, 104);
            this.AnnotationStyle2.Name = "AnnotationStyle2";
            this.AnnotationStyle2.Size = new System.Drawing.Size(120, 22);
            this.AnnotationStyle2.TabIndex = 7;
            this.AnnotationStyle2.SelectedIndexChanged += new System.EventHandler(this.AnnotationStyle2_SelectedIndexChanged);
            // 
            // StyleLabel1
            // 
            this.StyleLabel1.Location = new System.Drawing.Point(40, 72);
            this.StyleLabel1.Name = "StyleLabel1";
            this.StyleLabel1.Size = new System.Drawing.Size(120, 20);
            this.StyleLabel1.TabIndex = 4;
            this.StyleLabel1.Text = "Start &Cap:";
            this.StyleLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StyleLabel2
            // 
            this.StyleLabel2.Location = new System.Drawing.Point(32, 106);
            this.StyleLabel2.Name = "StyleLabel2";
            this.StyleLabel2.Size = new System.Drawing.Size(128, 16);
            this.StyleLabel2.TabIndex = 6;
            this.StyleLabel2.Text = "&End Cap:";
            this.StyleLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AnnotationStyle1
            // 
            this.AnnotationStyle1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnnotationStyle1.Location = new System.Drawing.Point(168, 72);
            this.AnnotationStyle1.Name = "AnnotationStyle1";
            this.AnnotationStyle1.Size = new System.Drawing.Size(121, 22);
            this.AnnotationStyle1.TabIndex = 5;
            this.AnnotationStyle1.SelectedIndexChanged += new System.EventHandler(this.AnnotationStyle1_SelectedIndexChanged);
            // 
            // Chart1
            // 
            polylineAnnotation1.AnchorDataPointName = "Default\\r0";
            annotationPathPoint1.PointType = ((byte)(0));
            annotationPathPoint1.X = 10F;
            annotationPathPoint1.Y = 10F;
            annotationPathPoint2.X = 20F;
            annotationPathPoint2.Y = 20F;
            annotationPathPoint3.X = 30F;
            annotationPathPoint3.Y = 30F;
            annotationPathPoint4.X = 40F;
            annotationPathPoint4.Y = 10F;
            annotationPathPoint5.X = 10F;
            annotationPathPoint5.Y = 10F;
            polylineAnnotation1.GraphicsPathPoints.Add(annotationPathPoint1);
            polylineAnnotation1.GraphicsPathPoints.Add(annotationPathPoint2);
            polylineAnnotation1.GraphicsPathPoints.Add(annotationPathPoint3);
            polylineAnnotation1.GraphicsPathPoints.Add(annotationPathPoint4);
            polylineAnnotation1.GraphicsPathPoints.Add(annotationPathPoint5);
            polylineAnnotation1.Name = "Polyline1";
            this.Chart1.Annotations.Add(polylineAnnotation1);
            this.Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            this.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            this.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.Chart1.BorderlineWidth = 2;
            this.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 29;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
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
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 98F;
            chartArea1.Position.Width = 100F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(16, 65);
            this.Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.Chart1.Series.Add(series1);
            this.Chart1.Series.Add(series2);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 1;
            // 
            // AnnotationStyles
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AnnotationStyles";
            this.Size = new System.Drawing.Size(728, 480);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void Annotation_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Chart1.Annotations.Clear();
			
			AnnotationStyle.Items.Clear();
			AnnotationStyle.Enabled = false;

			AnnotationStyle1.Items.Clear();
			AnnotationStyle1.Enabled = false;
			AnnotationStyle2.Items.Clear();
			AnnotationStyle2.Visible = false;

			if(Annotation.SelectedItem.ToString() == "Line")
			{
				LineAnnotation annotation = new LineAnnotation();
				annotation.AnchorDataPoint = Chart1.Series[0].Points[1];
				annotation.Height = -25;
				annotation.Width = -25;
				annotation.LineWidth = 2;
				
				Chart1.Annotations.Add(annotation);

				SetLineControls(true);

			}
			else if(Annotation.SelectedItem.ToString() == "Vertical Line")
			{
				VerticalLineAnnotation annotation = new VerticalLineAnnotation();
				annotation.AnchorDataPoint = Chart1.Series[0].Points[1];
				annotation.Height = -25;
				annotation.LineWidth = 2;
				
				Chart1.Annotations.Add(annotation);

				SetLineControls(true);

			}
			else if(Annotation.SelectedItem.ToString() == "Horizontal Line")
			{
				HorizontalLineAnnotation annotation = new HorizontalLineAnnotation();
				annotation.AnchorDataPoint = Chart1.Series[0].Points[1];
				annotation.Width = -25;
				annotation.LineWidth = 2;
				
				Chart1.Annotations.Add(annotation);

				SetLineControls(true);
			}
			else if(Annotation.SelectedItem.ToString() == "Polyline")
			{
				PolylineAnnotation annotation = new PolylineAnnotation();
				annotation.AnchorDataPoint = Chart1.Series[0].Points[1];

				// explicitly set the relative height and width
				annotation.Height = 50;
				annotation.Width = 30;

				PointF [] points = new PointF[5];
				points[0].X = 0;
				points[0].Y = 0;				
				
				points[1].X = 100;
				points[1].Y = 0;
				
				points[2].X = 0;
				points[2].Y = 100;
				
				points[3].X = 100;
				points[3].Y = 100;
				
				points[4].X = 0;
				points[4].Y = 50;

				annotation.GraphicsPath.AddPolygon(points);
				
				Chart1.Annotations.Add(annotation);

				SetLineControls(false);
			}
			else if(Annotation.SelectedItem.ToString() == "Text")
			{
				TextAnnotation annotation = new TextAnnotation();
				annotation.AnchorDataPoint = Chart1.Series[0].Points[1];
				annotation.Text = "I am a TextAnnotation";
				annotation.ForeColor = Color.Black;
				annotation.Font = new Font("Arial", 12);;
				
				Chart1.Annotations.Add(annotation);
				SetTextControls();

			}
			else if(Annotation.SelectedItem.ToString() == "Rectangle")
			{
				RectangleAnnotation annotation = new RectangleAnnotation();
				annotation.AnchorDataPoint = Chart1.Series[0].Points[1];
				annotation.Text = "I am a\nRectangleAnnotation";
				annotation.ForeColor = Color.Black;
				annotation.Font = new Font("Arial", 12);;
				annotation.LineWidth = 2;
				
				Chart1.Annotations.Add(annotation);

				SetTextControls();
				SetColorLineControls();
				AnnotationStyle1.SelectedIndex = 2;
			}
			else if(Annotation.SelectedItem.ToString() == "Ellipse")
			{
				EllipseAnnotation annotation = new EllipseAnnotation();
				annotation.AnchorDataPoint = Chart1.Series[0].Points[1];
				annotation.Text = "I am an EllipseAnnotation";
				annotation.ForeColor = Color.Black;
				annotation.Font = new Font("Arial", 12);;
				annotation.LineWidth = 2;
				annotation.Height = 35;
				annotation.Width = 60;
				
				Chart1.Annotations.Add(annotation);

				SetTextControls();
				SetColorLineControls();
				AnnotationStyle1.SelectedIndex = 2;
				
			}
			else if(Annotation.SelectedItem.ToString() == "Arrow")
			{
				ArrowAnnotation annotation = new ArrowAnnotation();
				annotation.AnchorDataPoint = Chart1.Series[0].Points[1];
				annotation.Height = -25;
				annotation.Width = -25;
				annotation.LineWidth = 2;
				
				Chart1.Annotations.Add(annotation);

				SetArrowControls();

			}
			else if(Annotation.SelectedItem.ToString() == "Border3D")
			{
				Border3DAnnotation annotation = new Border3DAnnotation();
				annotation.AnchorDataPoint = Chart1.Series[0].Points[1];
				annotation.Text = "I am a Border3DAnnotation";
				annotation.ForeColor = Color.Black;
				annotation.Font = new Font("Arial", 12);
				annotation.Height = 40;
				annotation.Width = 50;
				
				Chart1.Annotations.Add(annotation);

				SetBorder3DControls();

			}
			else if(Annotation.SelectedItem.ToString() == "Callout")
			{
				CalloutAnnotation annotation = new CalloutAnnotation();
				annotation.AnchorDataPoint = Chart1.Series[0].Points[1];
				annotation.Text = "I am a\nCalloutAnnotation";
				annotation.ForeColor = Color.Black;
				annotation.Font = new Font("Arial", 10);;
				annotation.Height = 35;
				annotation.Width = 50;

				Chart1.Annotations.Add(annotation);

				SetCalloutControls();

			}
			else if(Annotation.SelectedItem.ToString() == "Polygon")
			{
				PolygonAnnotation annotation = new PolygonAnnotation();
				annotation.AnchorDataPoint = Chart1.Series[0].Points[1];
				
				// explicitly set the relative height and width
				annotation.Height = 50;
				annotation.Width = 30;

				annotation.BackColor = Color.FromArgb(128, Color.Orange);

				// define relative value points for a polygon
				PointF [] points = new PointF[5];
				points[0].X = 0;
				points[0].Y = 0;				
				
				points[1].X = 100;
				points[1].Y = 0;
				
				points[2].X = 100;
				points[2].Y = 100;
				
				points[3].X = 0;
				points[3].Y = 100;
				
				points[4].X = 50;
				points[4].Y = 50;

				annotation.GraphicsPath.AddPolygon(points);
				
				Chart1.Annotations.Add(annotation);

				SetColorControl();
				SetColorLineControls();

			}
			else if(Annotation.SelectedItem.ToString() == "Image")
			{
				if(Chart1.Images.IndexOf("MyBmp") < 0)
				{
					Bitmap Bmp = new Bitmap(200, 75);
					Graphics g = Graphics.FromImage(Bmp);
					g.FillRectangle(new SolidBrush(Color.Transparent), 0, 0, Bmp.Width, Bmp.Height);
					g.FillRectangle(new SolidBrush(Color.PaleGoldenrod), Bmp.Width/2, 0, Bmp.Width/2, Bmp.Height);
					g.FillRectangle(new SolidBrush(Color.PaleVioletRed), 0, 0, Bmp.Width/2, Bmp.Height);
					g.FillRectangle(new SolidBrush(Color.FromArgb(128, Color.DarkOrange)), 0, Bmp.Height/2, Bmp.Width, Bmp.Height/2);
					g.DrawString("I am an ImageAnnotation", new Font("Arial", 12), 
						new SolidBrush(Color.Black), 
						new Rectangle( 0, 0, Bmp.Width, Bmp.Height));
				
					g.Dispose();
                    
					Chart1.Images.Add(new NamedImage("MyBmp", Bmp));
				}

				ImageAnnotation annotation = new ImageAnnotation();
				annotation.AnchorDataPoint = Chart1.Series[0].Points[1];
				annotation.Image = "MyBmp";
				
				Chart1.Annotations.Add(annotation);
				StyleLabel1.Text = "";
				StyleLabel2.Text = "";
			}

			
		}

		private void SetCalloutControls()
		{
			foreach(string style in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.CalloutStyle)))
			{
				AnnotationStyle.Items.Add(style);
			}
			AnnotationStyle.SelectedIndex = 2;
			AnnotationStyle.Enabled = true;

			AnnotationStyle1.Items.Clear();
			AnnotationStyle1.Items.Add("Yellow");
			AnnotationStyle1.Items.Add("White");
			AnnotationStyle1.Items.Add("Gold");
			AnnotationStyle1.Items.Add("Brown");

			StyleLabel1.Text = "Back Color:";
			AnnotationStyle1.SelectedIndex = 2;
			AnnotationStyle1.Enabled = true;

			StyleLabel2.Text = "";
			AnnotationStyle2.Visible = false;
		}

		private void SetBorder3DControls()
		{
			foreach(string skinStyle in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle)))
			{
				AnnotationStyle.Items.Add(skinStyle);
			}
			AnnotationStyle.SelectedIndex = 1;
			AnnotationStyle.Enabled = true;

			AnnotationStyle1.Items.Clear();
			AnnotationStyle1.Items.Add("Yellow");
			AnnotationStyle1.Items.Add("White");
			AnnotationStyle1.Items.Add("Gold");
			AnnotationStyle1.Items.Add("Brown");

			StyleLabel1.Text = "Border Color:";
			AnnotationStyle1.SelectedIndex = 2;
			AnnotationStyle1.Enabled = true;

			StyleLabel2.Text = "";
			AnnotationStyle2.Visible = false;
		}


		private void SetArrowControls()
		{

			foreach(string arrow in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.ArrowStyle)))
			{
				AnnotationStyle.Items.Add(arrow);
			}
			AnnotationStyle.SelectedIndex = 0;
			AnnotationStyle.Enabled = true;

			for(int i = 1; i <= 10; i++)
				AnnotationStyle1.Items.Add(i.ToString());

			StyleLabel1.Text = "Arrow Si&ze:";
			AnnotationStyle1.SelectedIndex = 3;
			AnnotationStyle1.Enabled = true;

			StyleLabel2.Text = "";
			AnnotationStyle2.Visible = false;

		}

		private void SetColorLineControls()
		{
			AnnotationStyle1.Items.Clear();
			AnnotationStyle1.Items.Add("Yellow");
			AnnotationStyle1.Items.Add("White");
			AnnotationStyle1.Items.Add("Gold");
			AnnotationStyle1.Items.Add("Brown");

			StyleLabel1.Text = "Back C&olor:";
			AnnotationStyle1.SelectedIndex = 2;
			AnnotationStyle1.Enabled = true;

			foreach(string lineName in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)))
			{
				AnnotationStyle2.Items.Add(lineName);
			}

			StyleLabel2.Text = "Line St&yle:";
			AnnotationStyle2.SelectedIndex = 5;
			AnnotationStyle2.Visible = true;
		}

		private void SetTextControls()
		{
            //FIXFIX
			/*(foreach(string style in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.TextStyle)))
			{
				AnnotationStyle.Items.Add(style);
			}*/

			AnnotationStyle.SelectedIndex = 3;
			AnnotationStyle.Enabled = true;
			
			StyleLabel1.Text = "";
			StyleLabel2.Text = "";
		}

		private void SetColorControl()
		{
			AnnotationStyle.Items.Clear();
			AnnotationStyle.Items.Add("Yellow");
			AnnotationStyle.Items.Add("White");
			AnnotationStyle.Items.Add("Gold");
			AnnotationStyle.Items.Add("Brown");

			AnnotationStyle.SelectedIndex = 1;
			AnnotationStyle.Enabled = true;

		}


		private void SetLineControls(bool showAnchors)
		{
			foreach(string lineName in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)))
			{
				AnnotationStyle.Items.Add(lineName);
			}

			AnnotationStyle.SelectedIndex = 5;
			AnnotationStyle.Enabled = true;

			if(showAnchors)
			{
				foreach(string arrowStyle in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle)))
				{
					AnnotationStyle1.Items.Add(arrowStyle);
					AnnotationStyle2.Items.Add(arrowStyle);
				}

				AnnotationStyle1.SelectedIndex = 1;
				AnnotationStyle1.Enabled = true;
				AnnotationStyle2.SelectedIndex = 1;
				AnnotationStyle2.Visible = true;

				StyleLabel1.Text = "Start Cap:";
				StyleLabel2.Text = "End Cap:";
			}
		}


		private void AnnotationStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(Annotation.SelectedItem.ToString().ToLower().IndexOf("line") >= 0)
			{
				Chart1.Annotations[0].LineDashStyle = 
					(ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), AnnotationStyle.SelectedItem.ToString());

			}
			else if(Annotation.SelectedItem.ToString() == "Text" ||
							Annotation.SelectedItem.ToString() == "Rectangle" ||
							Annotation.SelectedItem.ToString() == "Ellipse"        )
			{
                //FIXFIX
                /*
				Chart1.Annotations[0].TextStyle = 
					(TextStyle)TextStyle.Parse(typeof(TextStyle), AnnotationStyle.SelectedItem.ToString());*/

			}
			else if(Annotation.SelectedItem.ToString() == "Arrow")
			{
				((ArrowAnnotation)Chart1.Annotations[0]).ArrowStyle = 
					(ArrowStyle)ArrowStyle.Parse(typeof(ArrowStyle), AnnotationStyle.SelectedItem.ToString());

			}
			else if(Annotation.SelectedItem.ToString() == "Border3D")
			{
				((Border3DAnnotation)Chart1.Annotations[0]).BorderSkin.SkinStyle = 
					(BorderSkinStyle)BorderSkinStyle.Parse(typeof(BorderSkinStyle), AnnotationStyle.SelectedItem.ToString());

			}
			else if(Annotation.SelectedItem.ToString() == "Callout")
			{
				((CalloutAnnotation)Chart1.Annotations[0]).CalloutStyle = 
					(CalloutStyle)CalloutStyle.Parse(typeof(CalloutStyle), AnnotationStyle.SelectedItem.ToString());

			}
			else if(Annotation.SelectedItem.ToString() == "Polygon")
			{
				PolygonAnnotation annotation = (PolygonAnnotation) Chart1.Annotations[0];

				annotation.BackColor = Color.FromArgb(128, Color.FromName(AnnotationStyle.SelectedItem.ToString()));
			}
			
		
		}



		private void AnnotationStyle1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(Annotation.SelectedItem.ToString() == "Line")
			{
				LineAnnotation annotation = (LineAnnotation) Chart1.Annotations[0];

				annotation.StartCap =
                    (LineAnchorCapStyle)LineAnchorCapStyle.Parse(typeof(LineAnchorCapStyle), AnnotationStyle1.SelectedItem.ToString());

			}
			else if(Annotation.SelectedItem.ToString() == "Vertical Line")
			{
				VerticalLineAnnotation annotation = (VerticalLineAnnotation) Chart1.Annotations[0];

				annotation.StartCap =
                    (LineAnchorCapStyle)LineAnchorCapStyle.Parse(typeof(LineAnchorCapStyle), AnnotationStyle1.SelectedItem.ToString());
			}
			else if(Annotation.SelectedItem.ToString() == "Horizontal Line")
			{
				HorizontalLineAnnotation annotation = (HorizontalLineAnnotation) Chart1.Annotations[0];

				annotation.StartCap =
                    (LineAnchorCapStyle)LineAnchorCapStyle.Parse(typeof(LineAnchorCapStyle), AnnotationStyle1.SelectedItem.ToString());
			}
			else if(Annotation.SelectedItem.ToString() == "Polyline")
			{
				PolylineAnnotation annotation = (PolylineAnnotation) Chart1.Annotations[0];

				annotation.StartCap =
                    (LineAnchorCapStyle)LineAnchorCapStyle.Parse(typeof(LineAnchorCapStyle), AnnotationStyle1.SelectedItem.ToString());
			}
			else if(Annotation.SelectedItem.ToString() == "Rectangle")
			{
				RectangleAnnotation annotation = (RectangleAnnotation) Chart1.Annotations[0];

				annotation.BackColor = Color.FromArgb(128, Color.FromName(AnnotationStyle1.SelectedItem.ToString()));
			}
			else if(Annotation.SelectedItem.ToString() == "Ellipse")
			{
				EllipseAnnotation annotation = (EllipseAnnotation) Chart1.Annotations[0];

				annotation.BackColor = Color.FromArgb(128, Color.FromName(AnnotationStyle1.SelectedItem.ToString()));
			}
			else if(Annotation.SelectedItem.ToString() == "Arrow")
			{
				ArrowAnnotation annotation = (ArrowAnnotation) Chart1.Annotations[0];

				if(AnnotationStyle1.SelectedItem.ToString() != "")
					annotation.ArrowSize = int.Parse(AnnotationStyle1.SelectedItem.ToString());
			}
			else if(Annotation.SelectedItem.ToString() == "Border3D")
			{
				Border3DAnnotation annotation = (Border3DAnnotation) Chart1.Annotations[0];

				annotation.BorderSkin.BackColor = Color.FromArgb(128, Color.FromName(AnnotationStyle1.SelectedItem.ToString()));
			}
			else if(Annotation.SelectedItem.ToString() == "Callout")
			{
				CalloutAnnotation annotation = (CalloutAnnotation) Chart1.Annotations[0];

				annotation.BackColor = Color.FromArgb(128, Color.FromName(AnnotationStyle1.SelectedItem.ToString()));
			}
			else if(Annotation.SelectedItem.ToString() == "Polygon")
			{
				PolygonAnnotation annotation = (PolygonAnnotation) Chart1.Annotations[0];

				annotation.LineColor = Color.FromName(AnnotationStyle1.SelectedItem.ToString());
			}
		
		}

		private void AnnotationStyle2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(Annotation.SelectedItem.ToString() == "Line")
			{
				LineAnnotation annotation = (LineAnnotation) Chart1.Annotations[0];

				annotation.EndCap =
                    (LineAnchorCapStyle)LineAnchorCapStyle.Parse(typeof(LineAnchorCapStyle), AnnotationStyle2.SelectedItem.ToString());

			}
			else if(Annotation.SelectedItem.ToString() == "Vertical Line")
			{
				VerticalLineAnnotation annotation = (VerticalLineAnnotation) Chart1.Annotations[0];

				annotation.EndCap =
                    (LineAnchorCapStyle)LineAnchorCapStyle.Parse(typeof(LineAnchorCapStyle), AnnotationStyle2.SelectedItem.ToString());
			}
			else if(Annotation.SelectedItem.ToString() == "Horizontal Line")
			{
				HorizontalLineAnnotation annotation = (HorizontalLineAnnotation) Chart1.Annotations[0];

				annotation.EndCap =
                    (LineAnchorCapStyle)LineAnchorCapStyle.Parse(typeof(LineAnchorCapStyle), AnnotationStyle2.SelectedItem.ToString());
			}
			else if(Annotation.SelectedItem.ToString() == "Polyline")
			{
				PolylineAnnotation annotation = (PolylineAnnotation) Chart1.Annotations[0];

				annotation.EndCap =
                    (LineAnchorCapStyle)LineAnchorCapStyle.Parse(typeof(LineAnchorCapStyle), AnnotationStyle2.SelectedItem.ToString());
			}
			else if(Annotation.SelectedItem.ToString() == "Rectangle")
			{
				RectangleAnnotation annotation = (RectangleAnnotation) Chart1.Annotations[0];

				annotation.LineDashStyle = 
					(ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), AnnotationStyle2.SelectedItem.ToString());
			}
			else if(Annotation.SelectedItem.ToString() == "Ellipse")
			{
				EllipseAnnotation annotation = (EllipseAnnotation) Chart1.Annotations[0];

				annotation.LineDashStyle = 
					(ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), AnnotationStyle2.SelectedItem.ToString());
			}
			else if(Annotation.SelectedItem.ToString() == "Polygon")
			{
				PolygonAnnotation annotation = (PolygonAnnotation) Chart1.Annotations[0];

				annotation.LineDashStyle = 
					(ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), AnnotationStyle2.SelectedItem.ToString());
			}


		
		}
	}
}


