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
	/// Summary description for KeyboardZoomScroll.
	/// </summary>
	public class KeyboardZoomScroll : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private double SelectionStart = double.NaN;
		private System.Windows.Forms.Label label1;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public KeyboardZoomScroll()
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyboardZoomScroll));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSampleComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Interval = 5;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Interval = 5;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Interval = 5;
            chartArea1.AxisX.ScaleView.MinSize = 2;
            chartArea1.AxisX.ScaleView.Position = 10;
            chartArea1.AxisX.ScaleView.Size = 20;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Tan;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 78F;
            chartArea1.InnerPlotPosition.Width = 90.95636F;
            chartArea1.InnerPlotPosition.X = 9.04364F;
            chartArea1.InnerPlotPosition.Y = 5.07246F;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 75F;
            chartArea1.Position.Width = 90F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 15F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 60);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Default";
            series1.Name = "Default";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Using Keyboard to Zoom and Scroll";
            this.chart1.Titles.Add(title1);
            this.chart1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chart1_KeyUp);
            this.chart1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chart1_KeyDown);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 14);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 34);
            this.labelSampleComment.TabIndex = 2;
            this.labelSampleComment.Text = "This sample demonstrates how to scroll, select data points, and zoom using the ke" +
                "yboard.";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(432, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // KeyboardZoomScroll
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KeyboardZoomScroll";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.KeyboardZoomScroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void KeyboardZoomScroll_Load(object sender, System.EventArgs e)
		{
			// Fill chart with random data
			Random	random = new Random();
			for(int pointIndex = 0; pointIndex < 75; pointIndex++)
			{
				chart1.Series["Default"].Points.AddY(random.Next(10, 100));
			}

			chart1.ChartAreas["Default"].CursorX.Position = 25;

			// Set focus
			chart1.Focus();
		}

		protected override bool ProcessDialogKey(Keys keyData)
		{
			// Avoid dialog processing of arrow keys
			if(keyData == Keys.Left || 
				keyData == Keys.Right)
			{
				return false;
			}
			return base.ProcessDialogKey(keyData);
		}

		private void chart1_Click(object sender, System.EventArgs e)
		{
			// Set input focus to the chart control
			chart1.Focus();
	
			// set the selection start variable to that of the current position
			this.SelectionStart = chart1.ChartAreas["Default"].CursorX.Position;
		}
		
		private void ProcessSelect(System.Windows.Forms.KeyEventArgs e)
		{
			// Process keyboard keys
			if(e.KeyCode == Keys.Right)
			{
				// make sure the selection start value is assigned
				if(this.SelectionStart == double.NaN)
					this.SelectionStart = chart1.ChartAreas["Default"].CursorX.Position;

				// set the new cursor position 
				chart1.ChartAreas["Default"].CursorX.Position += chart1.ChartAreas["Default"].CursorX.Interval;
			}
			else if(e.KeyCode == Keys.Left)
			{
				// make sure the selection start value is assigned
				if(this.SelectionStart == double.NaN)
					this.SelectionStart = chart1.ChartAreas["Default"].CursorX.Position;

				// set the new cursor position 
				chart1.ChartAreas["Default"].CursorX.Position -= chart1.ChartAreas["Default"].CursorX.Interval;
			}

			// if the cursor is outside the view, set the view
			// such that the cursor can be seen
			SetView();


			chart1.ChartAreas["Default"].CursorX.SelectionStart = this.SelectionStart;
			chart1.ChartAreas["Default"].CursorX.SelectionEnd = chart1.ChartAreas["Default"].CursorX.Position;
		}
		
		private void SetView()
		{
			// keep the cursor from leaving the max and min a axis points
			if(chart1.ChartAreas["Default"].CursorX.Position < 0)
				chart1.ChartAreas["Default"].CursorX.Position = 0;
			
			else if(chart1.ChartAreas["Default"].CursorX.Position > 75)
				chart1.ChartAreas["Default"].CursorX.Position = 75;


			// move the view to keep the cursor visible
			if(chart1.ChartAreas["Default"].CursorX.Position < chart1.ChartAreas["Default"].AxisX.ScaleView.Position)
				chart1.ChartAreas["Default"].AxisX.ScaleView.Position = chart1.ChartAreas["Default"].CursorX.Position;
		
			else if ((chart1.ChartAreas["Default"].CursorX.Position > 
				(chart1.ChartAreas["Default"].AxisX.ScaleView.Position+chart1.ChartAreas["Default"].AxisX.ScaleView.Size)))
			{
				chart1.ChartAreas["Default"].AxisX.ScaleView.Position = 
					(chart1.ChartAreas["Default"].CursorX.Position-chart1.ChartAreas["Default"].AxisX.ScaleView.Size);
			}
		}

		private void ProcessScroll(System.Windows.Forms.KeyEventArgs e)
		{
			// Process keyboard keys
			if(e.KeyCode == Keys.Right)
				// set the new cursor position 
				chart1.ChartAreas["Default"].CursorX.Position += chart1.ChartAreas["Default"].CursorX.Interval;

			else if(e.KeyCode == Keys.Left)
				// set the new cursor position 
				chart1.ChartAreas["Default"].CursorX.Position -= chart1.ChartAreas["Default"].CursorX.Interval;

			// if the cursor is outside the view, set the view
			// such that the cursor can be seen
			SetView();


			// set the selection start variable in case shift arrows are selected...
			this.SelectionStart = chart1.ChartAreas["Default"].CursorX.Position;

			//reset the old selection start and end
			chart1.ChartAreas["Default"].CursorX.SelectionStart = double.NaN;
			chart1.ChartAreas["Default"].CursorX.SelectionEnd = double.NaN;
		}

		private void chart1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if((e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Left)) 
			{
				// if the key event is shifted, process as a selection
				if(e.Shift)
					ProcessSelect(e);
				else // process as a scroll
					ProcessScroll(e);
			}

				// on enter, zoom the selection
			else if (e.KeyCode == Keys.Enter)
			{
				double start, end;
		
				if(chart1.ChartAreas["Default"].CursorX.SelectionStart > chart1.ChartAreas["Default"].CursorX.SelectionEnd)
				{
					start = chart1.ChartAreas["Default"].CursorX.SelectionEnd;
					end = chart1.ChartAreas["Default"].CursorX.SelectionStart;
				}
				else
				{
					end = chart1.ChartAreas["Default"].CursorX.SelectionEnd;
					start = chart1.ChartAreas["Default"].CursorX.SelectionStart;
				}

				// return if no selection actually made
				if(start == end)
					return;

				// zoom the selection
				chart1.ChartAreas["Default"].AxisX.ScaleView.Zoom( start,(end-start), DateTimeIntervalType.Number,true);

				// reset selection values
				this.SelectionStart = chart1.ChartAreas["Default"].CursorX.Position;
				chart1.ChartAreas["Default"].CursorX.SelectionStart = double.NaN;
				chart1.ChartAreas["Default"].CursorX.SelectionEnd = double.NaN;

			}

			else if (e.KeyCode == Keys.Back)
			{
				// reset zoom back to previous view state
				chart1.ChartAreas["Default"].AxisX.ScaleView.ZoomReset(1);
		
				// reset selection values
				this.SelectionStart = chart1.ChartAreas["Default"].CursorX.Position;
				chart1.ChartAreas["Default"].CursorX.SelectionStart = double.NaN;
				chart1.ChartAreas["Default"].CursorX.SelectionEnd = double.NaN;
			}

		}

		private void chart1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.Shift)
			{
				chart1_KeyDown(sender, e);
			}
		}
		
	}
}
