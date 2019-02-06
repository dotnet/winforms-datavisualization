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
	/// Summary description for UsingToolTips.
	/// </summary>
	public class DynamicChartCreation : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Label label1;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DynamicChartCreation()
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label9.Location = new System.Drawing.Point(8, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(696, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to create a chart dynamically at run time.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(405, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 248);
            this.panel1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(64, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Border Size:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(64, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Border Color:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(64, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hatch Style:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(64, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gradient:";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(64, 426);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 5;
            this.label15.Text = "Border Size:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label1.Location = new System.Drawing.Point(16, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "For ease of use, add the chart at design time.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DynamicChartCreation
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Name = "DynamicChartCreation";
            this.Size = new System.Drawing.Size(728, 400);
            this.Load += new System.EventHandler(this.DynamicChartCreation_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void DynamicChartCreation_Load(object sender, System.EventArgs e)
		{
			// Create a Chart
			Chart1 = new Chart();

			// Create Chart Area
			ChartArea chartArea1 = new ChartArea();

			// Add Chart Area to the Chart
			Chart1.ChartAreas.Add(chartArea1);

			// Create a data series
			Series series1 = new Series();
			Series series2 = new Series();

			// Add data points to the first series
			series1.Points.Add(34);
			series1.Points.Add(24);
			series1.Points.Add(32);
			series1.Points.Add(28);
			series1.Points.Add(44);

			// Add data points to the second series
			series2.Points.Add(14);
			series2.Points.Add(44);
			series2.Points.Add(24);
			series2.Points.Add(32);
			series2.Points.Add(28);

			// Add series to the chart
			Chart1.Series.Add(series1);
			Chart1.Series.Add(series2);

			// Set chart control location
			Chart1.Location = new System.Drawing.Point(16, 48);

			// Set Chart control size
			Chart1.Size = new System.Drawing.Size(360, 260);

			// Add chart control to the form
			this.Controls.AddRange(new System.Windows.Forms.Control[] { this.Chart1 });
					
		}
		
	}
}
