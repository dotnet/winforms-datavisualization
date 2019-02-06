using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for EmptyPointAppearance.
	/// </summary>
	public class SavingAndCopyingImages : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Button Copy;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Label label2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SavingAndCopyingImages()
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 400);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 600);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1700);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1500);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 950);
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Copy = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
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
            this.label9.Size = new System.Drawing.Size(702, 37);
            this.label9.TabIndex = 2;
            this.label9.Text = "This sample shows how to save a chart as an image, and also demonstrates how to c" +
                "opy a chart image to the clipboard.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Copy);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Location = new System.Drawing.Point(432, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 1;
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.SystemColors.Control;
            this.Copy.Location = new System.Drawing.Point(48, 56);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(112, 23);
            this.Copy.TabIndex = 16;
            this.Copy.Text = "&Copy";
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.Control;
            this.Save.Location = new System.Drawing.Point(48, 16);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(112, 23);
            this.Save.TabIndex = 15;
            this.Save.Text = "&Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Chart1
            // 
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
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "#";
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(16, 53);
            this.Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "PieLabelStyle=Outside, PieDrawingStyle=SoftEdge";
            series1.Legend = "Default";
            series1.Name = "Default";
            dataPoint1.LegendText = "USA";
            dataPoint2.LegendText = "Canada";
            dataPoint3.LegendText = "France";
            dataPoint4.LegendText = "Japan";
            dataPoint5.LegendText = "Russia";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 0;
            this.Chart1.Click += new System.EventHandler(this.Chart1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(702, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "After copying the chart image to the clipboard, try pasting that image into anoth" +
                "er application.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SavingAndCopyingImages
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SavingAndCopyingImages";
            this.Size = new System.Drawing.Size(728, 408);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void EmptyPointAppearance_Load(object sender, System.EventArgs e)
		{ 
		}
	
		private void button1_Click(object sender, System.EventArgs e)
		{
			// Create a new save file dialog
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
 
			// Sets the current file name filter string, which determines 
			// the choices that appear in the "Save as file type" or 
			// "Files of type" box in the dialog box.
			saveFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|EMF (*.emf)|*.emf|PNG (*.png)|*.png|GIF (*.gif)|*.gif|TIFF (*.tif)|*.tif";
			saveFileDialog1.FilterIndex = 2 ;
			saveFileDialog1.RestoreDirectory = true ;
 
			// Set image file format
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				ChartImageFormat format = ChartImageFormat.Bmp;

				if( saveFileDialog1.FileName.EndsWith( "bmp" ) )
				{
					format = ChartImageFormat.Bmp;
				}
				else if( saveFileDialog1.FileName.EndsWith( "jpg" ) )
				{
					format = ChartImageFormat.Jpeg;
				}
				else if( saveFileDialog1.FileName.EndsWith( "emf" ) )
				{
					format = ChartImageFormat.Emf;
				}
				else if( saveFileDialog1.FileName.EndsWith( "gif" ) )
				{
					format = ChartImageFormat.Gif;
				}
				else if( saveFileDialog1.FileName.EndsWith( "png" ) )
				{
					format = ChartImageFormat.Png;
				}
				else if( saveFileDialog1.FileName.EndsWith( "tif" ) )
				{
					format = ChartImageFormat.Tiff;
				}

				// Save image
				Chart1.SaveImage( saveFileDialog1.FileName, format );
				
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			// create a memory stream to save the chart image    
			System.IO.MemoryStream stream = new System.IO.MemoryStream();     

			// save the chart image to the stream    
			Chart1.SaveImage(stream,System.Drawing.Imaging.ImageFormat.Bmp);     

			// create a bitmap using the stream    
			Bitmap bmp = new Bitmap(stream);     

			// save the bitmap to the clipboard    
			Clipboard.SetDataObject(bmp); 

		}

		private void Chart1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void Save_Click(object sender, System.EventArgs e)
		{
			// Create a new save file dialog
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
 
			// Sets the current file name filter string, which determines 
			// the choices that appear in the "Save as file type" or 
			// "Files of type" box in the dialog box.
			saveFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|EMF-Plus (*.emf)|*.emf|EMF-Dual (*.emf)|*.emf|EMF (*.emf)|*.emf|PNG (*.png)|*.png|GIF (*.gif)|*.gif|TIFF (*.tif)|*.tif";
			saveFileDialog1.FilterIndex = 2 ;
			saveFileDialog1.RestoreDirectory = true ;
 
			// Set image file format
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{

				ChartImageFormat format = ChartImageFormat.Bmp;

				if( saveFileDialog1.FileName.EndsWith( "bmp" ) )
				{
					format = ChartImageFormat.Bmp;
				}
				else if( saveFileDialog1.FileName.EndsWith( "jpg" ) )
				{
					format = ChartImageFormat.Jpeg;
				}
				else if( saveFileDialog1.FileName.EndsWith( "emf" ) && saveFileDialog1.FilterIndex == 3)
				{
					format = ChartImageFormat.EmfDual;
				}
				else if( saveFileDialog1.FileName.EndsWith( "emf" ) && saveFileDialog1.FilterIndex == 4 )
				{
					format = ChartImageFormat.EmfPlus;
				}
				else if( saveFileDialog1.FileName.EndsWith( "emf" ) )
				{
					format = ChartImageFormat.Emf;
				}
				else if( saveFileDialog1.FileName.EndsWith( "gif" ) )
				{
					format = ChartImageFormat.Gif;
				}
				else if( saveFileDialog1.FileName.EndsWith( "png" ) )
				{
					format = ChartImageFormat.Png;
				}
				else if( saveFileDialog1.FileName.EndsWith( "tif" ) )
				{
					format = ChartImageFormat.Tiff;
				}

				// Save image
				Chart1.SaveImage( saveFileDialog1.FileName, format );
			}
		}

		private void Copy_Click(object sender, System.EventArgs e)
		{
			// create a memory stream to save the chart image    
			System.IO.MemoryStream stream = new System.IO.MemoryStream();     

			// save the chart image to the stream    
			Chart1.SaveImage(stream,System.Drawing.Imaging.ImageFormat.Bmp);     

			// create a bitmap using the stream    
			Bitmap bmp = new Bitmap(stream);     

			// save the bitmap to the clipboard    
			Clipboard.SetDataObject(bmp); 
		}
	}
}
