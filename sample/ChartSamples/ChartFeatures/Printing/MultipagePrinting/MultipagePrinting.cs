using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartSamples
{
    
    using ScrollType = System.Windows.Forms.DataVisualization.Charting.ScrollType;

	/// <summary>
	/// Summary description for MultipagePrinting.
	/// </summary>
	public class MultipagePrinting : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonPrintPreview;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MultipagePrinting()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize combo boxes
		
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSampleComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPrintPreview = new System.Windows.Forms.Button();
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
            chartArea2.Area3DStyle.Inclination = 15;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Perspective = 10;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LabelStyle.Format = "MMM d";
            chartArea2.AxisX.LabelStyle.Interval = 1;
            chartArea2.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.Interval = 1;
            chartArea2.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorTickMark.Interval = 1;
            chartArea2.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BackColor = System.Drawing.Color.OldLace;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "Default";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.DockedToChartArea = "Default";
            legend2.Enabled = false;
            legend2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Default";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(16, 65);
            this.chart1.Name = "chart1";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Default";
            series2.Name = "Price";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValuesPerPoint = 4;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 14);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 43);
            this.labelSampleComment.TabIndex = 0;
            this.labelSampleComment.Text = "This sample shows how to print chart data on multiple pages. The series is popula" +
                "ted with price data for an eight-month period, and each printed page displays tw" +
                "o months of data.";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPrintPreview);
            this.panel1.Location = new System.Drawing.Point(432, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // buttonPrintPreview
            // 
            this.buttonPrintPreview.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPrintPreview.Location = new System.Drawing.Point(48, 8);
            this.buttonPrintPreview.Name = "buttonPrintPreview";
            this.buttonPrintPreview.Size = new System.Drawing.Size(120, 23);
            this.buttonPrintPreview.TabIndex = 0;
            this.buttonPrintPreview.Text = "Print &Preview";
            this.buttonPrintPreview.UseVisualStyleBackColor = false;
            this.buttonPrintPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // MultipagePrinting
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MultipagePrinting";
            this.Size = new System.Drawing.Size(728, 376);
            this.Load += new System.EventHandler(this.MultipagePrinting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void MultipagePrinting_Load(object sender, System.EventArgs e)
		{
			// Fill chart with data
			FillData();
		}

		/// <summary>
		/// Random Stock Data Generator
		/// </summary>
		private void FillData()
		{
			Random rand;
			// Use a number to calculate a starting value for 
			// the pseudo-random number sequence
			rand = new Random();
			
			// The number of days for stock data
			int period = 240;

			// The first High value
			double high = rand.NextDouble() * 40;

			// The first Close value
			double close = high - rand.NextDouble();

			// The first Low value
			double low = close - rand.NextDouble();

			// The first Open value
			double open = ( high - low ) * rand.NextDouble() + low;

			// The first Volume value
			double volume = 100 + 15 * rand.NextDouble();
						
			// The first day X and Y values
			chart1.Series["Price"].Points.AddXY(DateTime.Parse("1/2/2002"), high);
			chart1.Series["Price"].Points[0].YValues[1] = low;

			// The Open value is not used.
			chart1.Series["Price"].Points[0].YValues[2] = open;
			chart1.Series["Price"].Points[0].YValues[3] = close;
			
			// Days loop
			for( int day = 1; day <= period; day++ )
			{
			
				// Calculate High, Low and Close values
				high = chart1.Series["Price"].Points[day-1].YValues[2]+rand.NextDouble();
				close = high - rand.NextDouble();
				low = close - rand.NextDouble();
				open = ( high - low ) * rand.NextDouble() + low;
				
				// The low cannot be less than yesterday close value.
				if( low > chart1.Series["Price"].Points[day-1].YValues[2])
					low = chart1.Series["Price"].Points[day-1].YValues[2];
							
				// Set data points values
				chart1.Series["Price"].Points.AddXY(day, high);
				chart1.Series["Price"].Points[day].XValue = chart1.Series["Price"].Points[day-1].XValue+1;
				chart1.Series["Price"].Points[day].YValues[1] = low;
				chart1.Series["Price"].Points[day].YValues[2] = open;
				chart1.Series["Price"].Points[day].YValues[3] = close;
			}
		}

		private void buttonPreview_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Set new print document with custom page printing event handler
				chart1.Printing.PrintDocument = new PrintDocument();
				chart1.Printing.PrintDocument.PrintPage += new PrintPageEventHandler(pd_PrintPage);

				// Set Low printer resolution
				foreach(PrinterResolution pr in chart1.Printing.PrintDocument.PrinterSettings.PrinterResolutions)
				{
					if(pr.Kind == PrinterResolutionKind.Low)
					{
						chart1.Printing.PrintDocument.DefaultPageSettings.PrinterResolution = pr;
						break;
					}
				}

				// Print preview chart
				chart1.Printing.PrintPreview();
			}
			catch(Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Chart Control for .NET Framework", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Page index
		private	int printingPageIndex = 0;

		/// <summary>
		/// Handles PrintPage event of the document.
		/// </summary>
		/// <param name="sender">Sender object.</param>
		/// <param name="ev">Event parameters.</param>
		private void pd_PrintPage(object sender, PrintPageEventArgs ev) 
		{
			// Print more pages
			ev.HasMorePages = true;

			// Calculate chart position rectangle
			Rectangle	chartPosition = new Rectangle(ev.MarginBounds.X, ev.MarginBounds.Y, chart1.Size.Width, chart1.Size.Height);

			// Align chart position on the page
			float	chartWidthScale = ((float)ev.MarginBounds.Width) / ((float)chartPosition.Width);
			float	chartHeightScale = ((float)ev.MarginBounds.Height) / ((float)chartPosition.Height);
			chartPosition.Width = (int)(chartPosition.Width * Math.Min(chartWidthScale, chartHeightScale));
			chartPosition.Height = (int)(chartPosition.Height * Math.Min(chartWidthScale, chartHeightScale));

			// Check if chart view was already set
			if(double.IsNaN(chart1.ChartAreas["Default"].AxisX.ScaleView.Position))
			{
				// Reset page index
				printingPageIndex = 0;

				// Set view
				chart1.ChartAreas["Default"].AxisX.ScaleView.Position = chart1.ChartAreas["Default"].AxisX.Minimum;
				chart1.ChartAreas["Default"].AxisX.ScaleView.Size = 2;
				chart1.ChartAreas["Default"].AxisX.ScaleView.SizeType = DateTimeIntervalType.Months;
			}

			// Set chart title
			++printingPageIndex;
			chart1.Text = "Chart Page Number " + printingPageIndex.ToString();

			// Draw chart on the printer graphisc
			chart1.Printing.PrintPaint(ev.Graphics, chartPosition);

			// Scroll to the next view (2 months)
			double	currentPosition = chart1.ChartAreas["Default"].AxisX.ScaleView.Position;
			chart1.ChartAreas["Default"].AxisX.ScaleView.Scroll(System.Windows.Forms.DataVisualization.Charting.ScrollType.LargeIncrement);
			
			// Check if position was scrolled
			if(currentPosition >= (chart1.ChartAreas["Default"].AxisX.ScaleView.Position - 1.0))
			{
				// No more pages
				ev.HasMorePages = false;

				// Restore view state
				chart1.ChartAreas["Default"].AxisX.ScaleView.Position = double.NaN;
				chart1.ChartAreas["Default"].AxisX.ScaleView.Size = double.NaN;

				// Remove chart title
				chart1.Text = "";
			}
		}
	}
}
