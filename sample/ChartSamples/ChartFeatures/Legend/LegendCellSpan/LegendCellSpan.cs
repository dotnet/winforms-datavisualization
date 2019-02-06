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
	/// Summary description for LegendCellSpan.
	/// </summary>
	public class LegendCellSpan : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;

		public LegendCellSpan()
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
			System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell1 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.Margins margins1 = new System.Windows.Forms.DataVisualization.Charting.Margins();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell2 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell3 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell4 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem3 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell5 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell6 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem4 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell7 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.Margins margins2 = new System.Windows.Forms.DataVisualization.Charting.Margins();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell8 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem5 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell9 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell10 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem6 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell11 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell12 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 14);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 10);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 16);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 13);
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 11);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7);
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 4);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 14);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 9);
			this.label9 = new System.Windows.Forms.Label();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(702, 32);
			this.label9.TabIndex = 0;
			this.label9.Text = "This sample demonstrates the cell span feature of the legend.";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chart2
			// 
			this.chart2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(211)), ((System.Byte)(223)), ((System.Byte)(240)));
			this.chart2.BackSecondaryColor = System.Drawing.Color.White;
			this.chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			this.chart2.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			this.chart2.BorderlineWidth = 2;
			this.chart2.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Enable3D = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LabelStyle.Format = "MMM dd";
			chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.LabelAutoFitMaxFontSize = 7;
			chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(165)), ((System.Byte)(191)), ((System.Byte)(228)));
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			this.chart2.ChartAreas.Add(chartArea1);
			legend1.Alignment = System.Drawing.StringAlignment.Center;
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legendCell1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell1.CellSpan = 2;
			margins1.Bottom = 15;
			margins1.Left = 15;
			margins1.Right = 15;
			legendCell1.Margins = margins1;
			legendCell1.Name = "Cell1";
			legendCell1.Text = "North America";
			legendCell2.Name = "Cell2";
			legendItem1.Cells.Add(legendCell1);
			legendItem1.Cells.Add(legendCell2);
			legendItem1.Name = "North America";
			legendItem2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			legendCell3.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell3.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
			legendCell3.Name = "Cell1";
			legendCell3.SeriesSymbolSize = new System.Drawing.Size(200, 50);
			legendCell4.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell4.Name = "Cell2";
			legendCell4.SeriesSymbolSize = new System.Drawing.Size(200, 100);
			legendCell4.Text = "Country 1";
			legendItem2.Cells.Add(legendCell3);
			legendItem2.Cells.Add(legendCell4);
			legendItem2.Color = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(65)), ((System.Byte)(140)), ((System.Byte)(240)));
			legendItem2.Name = "LightBlue";
			legendItem3.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			legendCell5.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell5.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
			legendCell5.Name = "Cell1";
			legendCell5.SeriesSymbolSize = new System.Drawing.Size(200, 50);
			legendCell6.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell6.Name = "Cell2";
			legendCell6.Text = "Country 2";
			legendItem3.Cells.Add(legendCell5);
			legendItem3.Cells.Add(legendCell6);
			legendItem3.Color = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(252)), ((System.Byte)(180)), ((System.Byte)(65)));
			legendItem3.Name = "Gold";
			legendCell7.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell7.CellSpan = 2;
			legendCell7.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			margins2.Bottom = 15;
			margins2.Left = 15;
			margins2.Right = 15;
			margins2.Top = 200;
			legendCell7.Margins = margins2;
			legendCell7.Name = "Cell1";
			legendCell7.Text = "South America";
			legendCell8.Name = "Cell2";
			legendItem4.Cells.Add(legendCell7);
			legendItem4.Cells.Add(legendCell8);
			legendItem4.Name = "South America";
			legendItem5.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			legendCell9.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell9.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
			legendCell9.Name = "Cell1";
			legendCell9.SeriesSymbolSize = new System.Drawing.Size(200, 50);
			legendCell10.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell10.Name = "Cell2";
			legendCell10.Text = "Country 3";
			legendItem5.Cells.Add(legendCell9);
			legendItem5.Cells.Add(legendCell10);
			legendItem5.Color = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(64)), ((System.Byte)(10)));
			legendItem5.Name = "Red";
			legendItem6.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			legendCell11.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell11.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
			legendCell11.Name = "Cell1";
			legendCell11.SeriesSymbolSize = new System.Drawing.Size(200, 50);
			legendCell12.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			legendCell12.Name = "Cell2";
			legendCell12.Text = "Country 4";
			legendItem6.Cells.Add(legendCell11);
			legendItem6.Cells.Add(legendCell12);
			legendItem6.Color = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			legendItem6.Name = "DarkBlue";
			legend1.CustomItems.Add(legendItem1);
			legend1.CustomItems.Add(legendItem2);
			legend1.CustomItems.Add(legendItem3);
			legend1.CustomItems.Add(legendItem4);
			legend1.CustomItems.Add(legendItem5);
			legend1.CustomItems.Add(legendItem6);
			legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.chart2.Legends.Add(legend1);
			this.chart2.Location = new System.Drawing.Point(16, 56);
			this.chart2.Name = "chart2";
			this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartArea = "Default";
			series1.ChartType = SeriesChartType.StackedBar;
			series1.CustomProperties = "DrawingStyle=Cylinder";
			series1.Name = "B-1";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			series1.IsVisibleInLegend = false;
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series2.ChartArea = "Default";
            series2.ChartType = SeriesChartType.StackedBar;
			series2.CustomProperties = "DrawingStyle=Cylinder";
			series2.Name = "A-1";
			series2.Points.Add(dataPoint6);
			series2.Points.Add(dataPoint7);
			series2.Points.Add(dataPoint8);
			series2.Points.Add(dataPoint9);
			series2.Points.Add(dataPoint10);
			series2.IsVisibleInLegend = false;
			series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series3.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series3.ChartArea = "Default";
			series3.ChartType = SeriesChartType.StackedBar;
			series3.CustomProperties = "DrawingStyle=Cylinder";
			series3.Name = "A-2";
			series3.Points.Add(dataPoint11);
			series3.Points.Add(dataPoint12);
			series3.Points.Add(dataPoint13);
			series3.Points.Add(dataPoint14);
			series3.Points.Add(dataPoint15);
			series3.IsVisibleInLegend = false;
			series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series4.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series4.ChartArea = "Default";
            series4.ChartType = SeriesChartType.StackedBar;
			series4.Color = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series4.CustomProperties = "DrawingStyle=Cylinder";
			series4.Name = "B-2";
			series4.Points.Add(dataPoint16);
			series4.Points.Add(dataPoint17);
			series4.Points.Add(dataPoint18);
			series4.Points.Add(dataPoint19);
			series4.Points.Add(dataPoint20);
			series4.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			series4.IsVisibleInLegend = false;
			series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			this.chart2.Series.Add(series1);
			this.chart2.Series.Add(series2);
			this.chart2.Series.Add(series3);
			this.chart2.Series.Add(series4);
			this.chart2.Size = new System.Drawing.Size(412, 296);
			this.chart2.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(432, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 296);
			this.panel1.TabIndex = 2;
			// 
			// LegendCellSpan
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.chart2,
																		  this.label9});
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "LegendCellSpan";
			this.Size = new System.Drawing.Size(728, 392);
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

	}
}
