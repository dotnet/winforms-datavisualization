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
	/// Summary description for BasicPopulatingData.
	/// </summary>
	public class BasicPopulatingData : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BasicPopulatingData()
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label6,
																				 this.label5,
																				 this.label4,
																				 this.label3,
																				 this.label15});
			this.panel1.Location = new System.Drawing.Point(400, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(304, 248);
			this.panel1.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(64, 403);
			this.label6.Name = "label6";
			this.label6.TabIndex = 5;
			this.label6.Text = "Border Size:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(64, 380);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "Border Color:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(64, 357);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "Hatch Style:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(64, 334);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Gradient:";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(64, 426);
			this.label15.Name = "label15";
			this.label15.TabIndex = 5;
			this.label15.Text = "Border Size:";
			// 
			// Chart1
			// 
			this.Chart1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Chart1.BackSecondaryColor = System.Drawing.Color.White;
			this.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			this.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			this.Chart1.BorderlineWidth = 2;
			this.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;;
			chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;;
			chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.Name = "Data Binding";
			chartArea1.Position.Auto = false;
			chartArea1.Position.Height = 68.80695F;
			chartArea1.Position.Width = 45F;
			chartArea1.Position.X = 51F;
			chartArea1.Position.Y = 19.50579F;
			chartArea2.BackColor = System.Drawing.Color.WhiteSmoke;
			chartArea2.BackSecondaryColor = System.Drawing.Color.White;
			chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea2.Name = "Adding Points";
			chartArea2.Position.Auto = false;
			chartArea2.Position.Height = 68.80695F;
			chartArea2.Position.Width = 45F;
			chartArea2.Position.X = 3F;
			chartArea2.Position.Y = 19.50579F;
			this.Chart1.ChartAreas.Add(chartArea1);
			this.Chart1.ChartAreas.Add(chartArea2);
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Enabled = false;
			legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.Chart1.Legends.Add(legend1);
			this.Chart1.Location = new System.Drawing.Point(16, 40);
			this.Chart1.Name = "Chart1";
			this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.ChartArea = "Data Binding";
            series1.ChartType = SeriesChartType.Pie;
			series1.CustomProperties = "LabelsRadialLineSize=1, PieDrawingStyle=Concave, LabelStyle=outside";
			series1.Name = "ByArray";
			series2.ChartArea = "Adding Points";
            series2.ChartType = SeriesChartType.Pie;
			series2.CustomProperties = "LabelsRadialLineSize=1, PieDrawingStyle=Concave, LabelStyle=outside";
			series2.Name = "ByPoint";
			this.Chart1.Series.Add(series1);
			this.Chart1.Series.Add(series2);
			this.Chart1.Size = new System.Drawing.Size(360, 260);
			this.Chart1.TabIndex = 0;
			title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			title1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			title1.Name = "Default Title";
			title1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(32)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			title1.ShadowOffset = 3;
			title1.Text = "Chart Control for .NET Framework";
			this.Chart1.Titles.Add(title1);
            this.Chart1.PostPaint += new EventHandler<ChartPaintEventArgs>(Chart1_PostPaint);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 11.25F);
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(624, 24);
			this.label1.TabIndex = 20;
			this.label1.Text = "This sample demonstrates how to populate a chart with data.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 11.25F);
			this.label2.Location = new System.Drawing.Point(16, 312);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(688, 72);
			this.label2.TabIndex = 21;
			this.label2.Text = "Two arrays are used: one for X values and one for Y values.  The chart on the lef" +
				"t uses the AddXY method to add data points to the chart, while the chart on the " +
				"right uses the DataBindXY method to bind data to an array.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BasicPopulatingData
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label2,
																		  this.Chart1,
																		  this.panel1,
																		  this.label1});
			this.Name = "BasicPopulatingData";
			this.Size = new System.Drawing.Size(728, 400);
			this.Load += new System.EventHandler(this.BasicPopulatingData_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void BasicPopulatingData_Load(object sender, System.EventArgs e)
		{
			// initialize an array of doubles
			double [] yval = { 5,6,4,6,3};

			// initialize an array of string
			string [] xval = { "A", "B", "C", "D", "E"};

			// bind the double array to the Y axis points of the Default data series
			Chart1.Series["ByArray"].Points.DataBindXY(xval,yval);

			// now iterate through the arrays to apply the points individually
			for(int i = 0; i < 5; i++)
			{
				Chart1.Series["ByPoint"].Points.AddXY(xval[i], yval[i]);
			}
		}

		private void Chart1_PostPaint(object sender, System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e)
		{
			// Painting series object
			if(sender is System.Windows.Forms.DataVisualization.Charting.ChartArea)
			{
				ChartArea area = (ChartArea)sender;

				
				StringFormat	format = new StringFormat();
				format.Alignment = StringAlignment.Center;

				
				RectangleF rect = new RectangleF(	area.Position.X, 
													area.Position.Y,
													area.Position.Width,
													6);

				rect = e.ChartGraphics.GetAbsoluteRectangle(rect);
				e.ChartGraphics.Graphics.DrawString(area.Name,
										new Font("Arial", 10), 
										Brushes.Black, 
										rect, 
										format);

			}
		
		}
		
		
	}
}
