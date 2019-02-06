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
	/// Summary description for StripIntervals.
	/// </summary>
	public class StripIntervals : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox StripWidth;
		private System.Windows.Forms.ComboBox IntervalOffset;
		private System.Windows.Forms.ComboBox IntervalType;
		private System.Windows.Forms.ComboBox IntervalOffsetType;
		private System.Windows.Forms.ComboBox StripWidthType;
        private System.Windows.Forms.ComboBox StripInterval;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public StripIntervals()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			
			FillData();

			this.StripWidth.SelectedIndex = 1;
			this.IntervalOffset.SelectedIndex = 0;
			this.IntervalType.SelectedIndex = 0;
			this.IntervalOffsetType.SelectedIndex = 0;
			this.StripWidthType.SelectedIndex = 0;
			this.StripInterval.SelectedIndex = 0;
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
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StripWidth = new System.Windows.Forms.ComboBox();
            this.IntervalOffset = new System.Windows.Forms.ComboBox();
            this.IntervalType = new System.Windows.Forms.ComboBox();
            this.IntervalOffsetType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.StripWidthType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StripInterval = new System.Windows.Forms.ComboBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // StripWidth
            // 
            this.StripWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StripWidth.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.StripWidth.Location = new System.Drawing.Point(168, 136);
            this.StripWidth.Name = "StripWidth";
            this.StripWidth.Size = new System.Drawing.Size(121, 22);
            this.StripWidth.TabIndex = 4;
            this.StripWidth.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
            // 
            // IntervalOffset
            // 
            this.IntervalOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IntervalOffset.Items.AddRange(new object[] {
            "1",
            "2"});
            this.IntervalOffset.Location = new System.Drawing.Point(168, 72);
            this.IntervalOffset.Name = "IntervalOffset";
            this.IntervalOffset.Size = new System.Drawing.Size(121, 22);
            this.IntervalOffset.TabIndex = 2;
            this.IntervalOffset.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
            // 
            // IntervalType
            // 
            this.IntervalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IntervalType.Items.AddRange(new object[] {
            "Weeks",
            "Months"});
            this.IntervalType.Location = new System.Drawing.Point(168, 40);
            this.IntervalType.Name = "IntervalType";
            this.IntervalType.Size = new System.Drawing.Size(121, 22);
            this.IntervalType.TabIndex = 1;
            this.IntervalType.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
            // 
            // IntervalOffsetType
            // 
            this.IntervalOffsetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IntervalOffsetType.Items.AddRange(new object[] {
            "Days",
            "Weeks"});
            this.IntervalOffsetType.Location = new System.Drawing.Point(168, 104);
            this.IntervalOffsetType.Name = "IntervalOffsetType";
            this.IntervalOffsetType.Size = new System.Drawing.Size(121, 22);
            this.IntervalOffsetType.TabIndex = 3;
            this.IntervalOffsetType.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Strip &Width:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Interval &Type:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(14, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "&Offset:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(14, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Offset T&ype:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 43);
            this.label9.TabIndex = 2;
            this.label9.Text = "This sample demonstrates how to set the offset, interval, strip width, and width " +
                "type of a StripLine object.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.StripWidthType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StripInterval);
            this.panel1.Controls.Add(this.IntervalType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.StripWidth);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.IntervalOffsetType);
            this.panel1.Controls.Add(this.IntervalOffset);
            this.panel1.Location = new System.Drawing.Point(432, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Width Ty&pe:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StripWidthType
            // 
            this.StripWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StripWidthType.Items.AddRange(new object[] {
            "Days",
            "Weeks"});
            this.StripWidthType.Location = new System.Drawing.Point(168, 168);
            this.StripWidthType.Name = "StripWidthType";
            this.StripWidthType.Size = new System.Drawing.Size(121, 22);
            this.StripWidthType.TabIndex = 5;
            this.StripWidthType.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "&Interval:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StripInterval
            // 
            this.StripInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StripInterval.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.StripInterval.Location = new System.Drawing.Point(168, 8);
            this.StripInterval.Name = "StripInterval";
            this.StripInterval.Size = new System.Drawing.Size(121, 22);
            this.StripInterval.TabIndex = 0;
            this.StripInterval.SelectedIndexChanged += new System.EventHandler(this.ControlSelectedIndexChanged);
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
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "d MMM";
            chartArea1.AxisX.LabelStyle.IsStaggered = true;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stripLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(241)))), ((int)(((byte)(185)))), ((int)(((byte)(168)))));
            stripLine1.Interval = 2;
            stripLine1.StripWidth = 1;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
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
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.ShadowOffset = 1;
            series1.YValuesPerPoint = 4;
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 1;
            // 
            // StripIntervals
            // 
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StripIntervals";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.StripIntervals_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void StripIntervals_Load(object sender, System.EventArgs e)
		{
		}

		private void ControlSelectedIndexChanged(object sender, System.EventArgs e)
		{

			if(this.StripWidth.SelectedIndex >= 0)
			{
				this.Chart1.ChartAreas[0].AxisX.StripLines[0].StripWidth = 
					int.Parse(this.StripWidth.SelectedItem.ToString());
			}

			if(this.StripWidthType.SelectedIndex >= 0)
			{
				switch( this.StripWidthType.SelectedItem.ToString())
				{
					case "Days":
						this.Chart1.ChartAreas[0].AxisX.StripLines[0].StripWidthType = DateTimeIntervalType.Days;
						break;
					case "Weeks":
						this.Chart1.ChartAreas[0].AxisX.StripLines[0].StripWidthType = DateTimeIntervalType.Weeks;
						break;
				}
			}


			if(this.IntervalOffset.SelectedIndex >= 0)
			{
				this.Chart1.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = 
					int.Parse(this.IntervalOffset.SelectedItem.ToString());
			}

			if(this.IntervalOffsetType.SelectedIndex >= 0)
			{
				switch( this.IntervalOffsetType.SelectedItem.ToString())
				{
					case "Days":
						this.Chart1.ChartAreas[0].AxisX.StripLines[0].IntervalOffsetType = DateTimeIntervalType.Days;
						break;
					case "Weeks":
						this.Chart1.ChartAreas[0].AxisX.StripLines[0].IntervalOffsetType = DateTimeIntervalType.Weeks;
						break;
				}
			}

			if(this.StripInterval.SelectedIndex >= 0)
			{
				this.Chart1.ChartAreas[0].AxisX.StripLines[0].Interval = 
					int.Parse(this.StripInterval.SelectedItem.ToString());
			}

			if(this.IntervalType.SelectedIndex >= 0)
			{
				switch( this.IntervalType.SelectedItem.ToString())
				{
					case "Weeks":
						this.Chart1.ChartAreas[0].AxisX.StripLines[0].IntervalType = DateTimeIntervalType.Weeks;
						break;
					case "Months":
						this.Chart1.ChartAreas[0].AxisX.StripLines[0].IntervalType = DateTimeIntervalType.Months;
						break;
				}
			}
		}

		private void FillData()
		{
			Random rand;
			// Use a number to calculate a starting value for 
			// the pseudo-random number sequence
			rand = new Random();
			
			// The number of days for stock data
			int period = 120;

			// The first High value
			double high = rand.NextDouble() * 40;

			// The first Close value
			double close = high - rand.NextDouble();

			// The first Low value
			double low = close - rand.NextDouble();

			// The first Open value
			double open = ( high - low ) * rand.NextDouble() + low;

			// The first day X and Y values
			Chart1.Series[0].Points.AddXY(DateTime.Parse("1/2/2002"), high);
			Chart1.Series[0].Points[0].YValues[1] = low;

			// The Open value is not used.
			Chart1.Series[0].Points[0].YValues[2] = open;
			Chart1.Series[0].Points[0].YValues[3] = close;
			
			// Days loop
			for( int day = 1; day <= period; day++ )
			{
			
				// Calculate High, Low and Close values
				high = Chart1.Series[0].Points[day-1].YValues[2]+rand.NextDouble();
				close = high - rand.NextDouble();
				low = close - rand.NextDouble();
				open = ( high - low ) * rand.NextDouble() + low;
				
				// The low cannot be less than yesterday close value.
				if( low > Chart1.Series[0].Points[day-1].YValues[2])
					low = Chart1.Series[0].Points[day-1].YValues[2];
							
				// Set data points values
				Chart1.Series[0].Points.AddXY(day, high);
				Chart1.Series[0].Points[day].XValue = Chart1.Series[0].Points[day-1].XValue+1;
				Chart1.Series[0].Points[day].YValues[1] = low;
				Chart1.Series[0].Points[day].YValues[2] = open;
				Chart1.Series[0].Points[day].YValues[3] = close;

			}
		}


	}
}
