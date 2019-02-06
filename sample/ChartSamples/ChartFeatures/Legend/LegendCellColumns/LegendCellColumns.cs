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
	/// Summary description for LegendCellColumns.
	/// </summary>
	public class LegendCellColumns : System.Windows.Forms.UserControl
	{
		#region Fields

		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.CheckBox chk_showTotal;
		private System.Windows.Forms.CheckBox chk_showAvg;
		
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		LegendCellColumn avgColumn = new LegendCellColumn();
		LegendCellColumn totalColumn = new LegendCellColumn();
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		LegendCellColumn minColumn = new LegendCellColumn();
		Random random = new Random();

		#endregion

		# region Constructor

		public LegendCellColumns()
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

		#endregion

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle axisScaleBreakStyle1 = new System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle();
			System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle axisScaleBreakStyle2 = new System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle();
			System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle axisScaleBreakStyle3 = new System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle();
			System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle axisScaleBreakStyle4 = new System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 3);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 5);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 6);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 7);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5, 8);
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 8);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 7);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 2);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 6);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5, 3);
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 4);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 7);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 9);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 12);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5, 3);
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 7.1999998092651367);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 8);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 8);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 9);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5, 9);
			this.label9 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.chk_showAvg = new System.Windows.Forms.CheckBox();
			this.chk_showTotal = new System.Windows.Forms.CheckBox();
			this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(702, 34);
			this.label9.TabIndex = 0;
			this.label9.Text = "This sample demonstrates how to work with cell columns to create multi-column leg" +
				"ends.";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.button1,
																				 this.checkBox1,
																				 this.chk_showAvg,
																				 this.chk_showTotal});
			this.panel1.Location = new System.Drawing.Point(432, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 296);
			this.panel1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(88, 120);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(168, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Generate Random Data";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(14, 80);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(168, 24);
			this.checkBox1.TabIndex = 9;
			this.checkBox1.Text = "Show &Minimum:";
			this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// chk_showAvg
			// 
			this.chk_showAvg.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chk_showAvg.Checked = true;
			this.chk_showAvg.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_showAvg.Location = new System.Drawing.Point(13, 12);
			this.chk_showAvg.Name = "chk_showAvg";
			this.chk_showAvg.Size = new System.Drawing.Size(168, 24);
			this.chk_showAvg.TabIndex = 8;
			this.chk_showAvg.Text = "Show &Average:";
			this.chk_showAvg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chk_showAvg.CheckedChanged += new System.EventHandler(this.chk_showAvg_CheckedChanged);
			// 
			// chk_showTotal
			// 
			this.chk_showTotal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chk_showTotal.Checked = true;
			this.chk_showTotal.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_showTotal.Location = new System.Drawing.Point(14, 47);
			this.chk_showTotal.Name = "chk_showTotal";
			this.chk_showTotal.Size = new System.Drawing.Size(168, 24);
			this.chk_showTotal.TabIndex = 7;
			this.chk_showTotal.Text = "Show &Total:";
			this.chk_showTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chk_showTotal.CheckedChanged += new System.EventHandler(this.chk_showTotal_CheckedChanged);
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
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Enable3D = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.PointGapDepth = 0;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LabelStyle.Interval = 1;
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.Interval = 1;
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorTickMark.Enabled = false;
			chartArea1.AxisX.MajorTickMark.Interval = 1;
			axisScaleBreakStyle1.Enabled = false;
			chartArea1.AxisX.ScaleBreakStyle = axisScaleBreakStyle1;
			axisScaleBreakStyle2.Enabled = false;
			chartArea1.AxisX2.ScaleBreakStyle = axisScaleBreakStyle2;
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorTickMark.Enabled = false;
			axisScaleBreakStyle3.Enabled = false;
			chartArea1.AxisY.ScaleBreakStyle = axisScaleBreakStyle3;
			axisScaleBreakStyle4.Enabled = false;
			chartArea1.AxisY2.ScaleBreakStyle = axisScaleBreakStyle4;
			chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			this.Chart1.ChartAreas.Add(chartArea1);
			legend1.Alignment = System.Drawing.StringAlignment.Center;
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
			legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.Chart1.Legends.Add(legend1);
			this.Chart1.Location = new System.Drawing.Point(16, 64);
			this.Chart1.Name = "Chart1";
			this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
            series1.ChartType = SeriesChartType.StackedArea;
			series1.Color = System.Drawing.Color.FromArgb(((System.Byte)(5)), ((System.Byte)(100)), ((System.Byte)(146)));
			series1.CustomProperties = "DrawingStyle=Cylinder, StackGroupName=Group1";
			series1.Name = "Bob";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
            series2.ChartType = SeriesChartType.StackedArea;
			series2.Color = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(180)), ((System.Byte)(65)));
			series2.CustomProperties = "DrawingStyle=Cylinder, StackGroupName=Group2";
			series2.Name = "John";
			series2.Points.Add(dataPoint6);
			series2.Points.Add(dataPoint7);
			series2.Points.Add(dataPoint8);
			series2.Points.Add(dataPoint9);
			series2.Points.Add(dataPoint10);
			series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series3.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
            series3.ChartType = SeriesChartType.StackedArea;
			series3.Color = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(64)), ((System.Byte)(10)));
			series3.CustomProperties = "DrawingStyle=Cylinder, StackGroupName=Group2";
			series3.Name = "Nehra";
			series3.Points.Add(dataPoint11);
			series3.Points.Add(dataPoint12);
			series3.Points.Add(dataPoint13);
			series3.Points.Add(dataPoint14);
			series3.Points.Add(dataPoint15);
			series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series4.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
            series4.ChartType = SeriesChartType.StackedArea;
			series4.Color = System.Drawing.Color.FromArgb(((System.Byte)(65)), ((System.Byte)(140)), ((System.Byte)(240)));
			series4.CustomProperties = "DrawingStyle=Cylinder, StackGroupName=Group1";
			series4.Name = "Mike";
			series4.Points.Add(dataPoint16);
			series4.Points.Add(dataPoint17);
			series4.Points.Add(dataPoint18);
			series4.Points.Add(dataPoint19);
			series4.Points.Add(dataPoint20);
			series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			this.Chart1.Series.Add(series1);
			this.Chart1.Series.Add(series2);
			this.Chart1.Series.Add(series3);
			this.Chart1.Series.Add(series4);
			this.Chart1.Size = new System.Drawing.Size(412, 296);
			this.Chart1.TabIndex = 1;
			this.Chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
			// 
			// LegendCellColumns
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.Chart1,
																		  this.panel1,
																		  this.label9});
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "LegendCellColumns";
			this.Size = new System.Drawing.Size(728, 480);
			this.Load += new System.EventHandler(this.LegendCellColumns_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Methods

		private void InitializeCellColumns() 
		{
			// Add first cell column
			LegendCellColumn firstColumn = new LegendCellColumn();
			firstColumn.ColumnType = LegendCellColumnType.SeriesSymbol;
			firstColumn.HeaderText = "Color";
			firstColumn.HeaderBackColor = Color.WhiteSmoke;
			this.Chart1.Legends["Default"].CellColumns.Add(firstColumn);

			// Add second cell column
			LegendCellColumn secondColumn = new LegendCellColumn();
			secondColumn.ColumnType = LegendCellColumnType.Text;
			secondColumn.HeaderText = "Name";
			secondColumn.Text = "#LEGENDTEXT";
			secondColumn.HeaderBackColor = Color.WhiteSmoke;
			this.Chart1.Legends["Default"].CellColumns.Add(secondColumn);

			// Add header separator of type line
			this.Chart1.Legends["Default"].HeaderSeparator = LegendSeparatorStyle.Line;
			this.Chart1.Legends["Default"].HeaderSeparatorColor = Color.FromArgb(64,64,64,64);
			
			// Add item column separator of type line
			this.Chart1.Legends["Default"].ItemColumnSeparator = LegendSeparatorStyle.Line;
			this.Chart1.Legends["Default"].ItemColumnSeparatorColor = Color.FromArgb(64,64,64,64);

			// Set AVG cell column attributes
			avgColumn.Text = "#AVG{N2}";
			avgColumn.HeaderText = "Avg";
			avgColumn.Name = "AvgColumn";
			avgColumn.HeaderBackColor = Color.WhiteSmoke;

			this.Chart1.Legends["Default"].CellColumns.Add(avgColumn);
			
			// Set Total cell column attributes
			totalColumn.Text = "#TOTAL{N1}";
			totalColumn.HeaderText = "Total";
			totalColumn.Name = "TotalColumn";
			totalColumn.HeaderBackColor = Color.WhiteSmoke;

			this.Chart1.Legends["Default"].CellColumns.Add(totalColumn);

			// Set Min cell column attributes
			minColumn.Text = "#MIN{N1}";
			minColumn.HeaderText = "Min";
			minColumn.Name = "MinColumn";
			minColumn.HeaderBackColor = Color.WhiteSmoke;

			this.Chart1.Legends["Default"].CellColumns.Add(minColumn);
		}

		// Fill chart data
		public void FillData(Chart chart, string seriesName) 
		{		
			double yValue = 10;
			for(int pointIndex = 0; pointIndex < 5; pointIndex++)
			{
				yValue = Math.Abs(yValue + ( random.NextDouble() * 10.0 - 5.0 )); 
				chart.Series[seriesName].Points.AddY(yValue);
			}
		}

		#endregion

		#region UI Handlers

		private void LegendCellColumns_Load(object sender, System.EventArgs e)
		{			
			// Set up the default appearance of the legend
			InitializeCellColumns();
		}

		private void chk_showAvg_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.chk_showAvg.Checked) 
			{
				this.Chart1.Legends["Default"].CellColumns.Add(avgColumn);		
			}

			else 
			{
				LegendCellColumn cellColumn = this.Chart1.Legends["Default"].CellColumns.FindByName("AvgColumn");
				this.Chart1.Legends["Default"].CellColumns.Remove(cellColumn);
			}		
		}

		private void chk_showTotal_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.chk_showTotal.Checked) 
			{
				this.Chart1.Legends["Default"].CellColumns.Add(totalColumn);		
			}

			else 
			{
				LegendCellColumn cellColumn = this.Chart1.Legends["Default"].CellColumns.FindByName("TotalColumn");
				this.Chart1.Legends["Default"].CellColumns.Remove(cellColumn);
			}			
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.checkBox1.Checked) 
			{
				this.Chart1.Legends["Default"].CellColumns.Add(minColumn);		
			}

			else 
			{
				LegendCellColumn minColumn = this.Chart1.Legends["Default"].CellColumns.FindByName("MinColumn");
				this.Chart1.Legends["Default"].CellColumns.Remove(minColumn);
			}	
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			foreach(Series series in Chart1.Series) 
			{
				series.Points.Clear();	
				string seriesName = series.Name;
				FillData(Chart1,seriesName);
			}

			this.Chart1.ResetAutoValues();
			this.Chart1.Invalidate();
		}

		
		#endregion

	}
}