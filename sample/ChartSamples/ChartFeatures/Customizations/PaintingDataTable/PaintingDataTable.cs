using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Utilities;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for PaintingDataTable.
	/// </summary>
	public class PaintingDataTable : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox ShowTitle;
		private System.Windows.Forms.ComboBox FontSize;
		private System.Windows.Forms.ComboBox BorderColor;
		private System.Windows.Forms.ComboBox TableColor;
		private System.Windows.Forms.ComboBox RotateAxisLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox DataTable1;
		private System.Windows.Forms.CheckBox IsPositionedInside;
		private System.Windows.Forms.CheckBox EnableScrollBar;

		private ChartDataTableHelper TableHelper = null;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PaintingDataTable()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			DataTable1.Checked = true;
			ShowTitle.Checked = true;
			FontSize.SelectedIndex = 0;
			BorderColor.SelectedIndex = 1;
			TableColor.SelectedIndex = 2;
			RotateAxisLabel.SelectedIndex = 0;

			chart1.ChartAreas["Default"].AxisX.TitleFont = new Font("Arial", 8);
			
            if(DataTable1.Checked && TableHelper == null)
			{
				TableHelper = new ChartDataTableHelper();
				TableHelper.Initialize(chart1);//, ShowTotals.Checked);
				TableHelper.TableColor = Color.FromName(this.TableColor.SelectedText);
				TableHelper.BorderColor = Color.FromName(this.BorderColor.SelectedText);
			}

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7, 7);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8, 9);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9, 9);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(11, 9);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(12, 3);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 8);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 4);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5, 7);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6, 0.5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9, 1);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint22 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10, 7);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint23 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(11, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint24 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(12, 8);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ShowTitle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RotateAxisLabel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FontSize = new System.Windows.Forms.ComboBox();
            this.TableColor = new System.Windows.Forms.ComboBox();
            this.BorderColor = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EnableScrollBar = new System.Windows.Forms.CheckBox();
            this.IsPositionedInside = new System.Windows.Forms.CheckBox();
            this.DataTable1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
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
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Interval = 1;
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Interval = 1;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0.5;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Interval = 1;
            chartArea1.AxisX.MajorTickMark.IntervalOffset = 0.5;
            chartArea1.AxisX.ScaleView.Size = 5;
            chartArea1.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.Title = "This is the X Axis";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Arial", 8F);
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.CursorX.IntervalOffset = 0.5;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.DockedToChartArea = "Default";
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 53);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Series1";
            dataPoint2.AxisLabel = "";
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
            series1.Points.Add(dataPoint12);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.Points.Add(dataPoint15);
            series2.Points.Add(dataPoint16);
            series2.Points.Add(dataPoint17);
            series2.Points.Add(dataPoint18);
            series2.Points.Add(dataPoint19);
            series2.Points.Add(dataPoint20);
            series2.Points.Add(dataPoint21);
            series2.Points.Add(dataPoint22);
            series2.Points.Add(dataPoint23);
            series2.Points.Add(dataPoint24);
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 1;
            // 
            // ShowTitle
            // 
            this.ShowTitle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowTitle.Location = new System.Drawing.Point(5, 37);
            this.ShowTitle.Name = "ShowTitle";
            this.ShowTitle.Size = new System.Drawing.Size(176, 24);
            this.ShowTitle.TabIndex = 1;
            this.ShowTitle.Text = "Show Axis T&itle:";
            this.ShowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowTitle.Click += new System.EventHandler(this.ShowTitle_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Rotate Labels:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title Si&ze:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RotateAxisLabel
            // 
            this.RotateAxisLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RotateAxisLabel.Items.AddRange(new object[] {
            "0",
            "30",
            "45",
            "60",
            "90"});
            this.RotateAxisLabel.Location = new System.Drawing.Point(168, 124);
            this.RotateAxisLabel.Name = "RotateAxisLabel";
            this.RotateAxisLabel.Size = new System.Drawing.Size(64, 22);
            this.RotateAxisLabel.TabIndex = 5;
            this.RotateAxisLabel.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(27, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Table C&olor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Table &Border:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FontSize
            // 
            this.FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "18"});
            this.FontSize.Location = new System.Drawing.Point(168, 150);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(64, 22);
            this.FontSize.TabIndex = 7;
            this.FontSize.SelectionChangeCommitted += new System.EventHandler(this.FontSize_SelectionChangeCommitted);
            // 
            // TableColor
            // 
            this.TableColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableColor.Items.AddRange(new object[] {
            "Control",
            "Yellow",
            "OldLace",
            "White",
            "Transparent"});
            this.TableColor.Location = new System.Drawing.Point(168, 176);
            this.TableColor.Name = "TableColor";
            this.TableColor.Size = new System.Drawing.Size(120, 22);
            this.TableColor.TabIndex = 9;
            this.TableColor.SelectedIndexChanged += new System.EventHandler(this.TableColor_SelectedIndexChanged);
            // 
            // BorderColor
            // 
            this.BorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorderColor.Items.AddRange(new object[] {
            "Control",
            "Black",
            "Red",
            "Yellow",
            "DimGray",
            "White",
            "Transparent"});
            this.BorderColor.Location = new System.Drawing.Point(168, 202);
            this.BorderColor.Name = "BorderColor";
            this.BorderColor.Size = new System.Drawing.Size(121, 22);
            this.BorderColor.TabIndex = 11;
            this.BorderColor.SelectedIndexChanged += new System.EventHandler(this.BorderColor_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EnableScrollBar);
            this.panel1.Controls.Add(this.IsPositionedInside);
            this.panel1.Controls.Add(this.DataTable1);
            this.panel1.Controls.Add(this.RotateAxisLabel);
            this.panel1.Controls.Add(this.ShowTitle);
            this.panel1.Controls.Add(this.FontSize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BorderColor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TableColor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(432, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // EnableScrollBar
            // 
            this.EnableScrollBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EnableScrollBar.Checked = true;
            this.EnableScrollBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableScrollBar.Location = new System.Drawing.Point(5, 66);
            this.EnableScrollBar.Name = "EnableScrollBar";
            this.EnableScrollBar.Size = new System.Drawing.Size(176, 24);
            this.EnableScrollBar.TabIndex = 2;
            this.EnableScrollBar.Text = "Enable &ScrollBar:";
            this.EnableScrollBar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EnableScrollBar.CheckedChanged += new System.EventHandler(this.EnableScrollBar_CheckedChanged);
            // 
            // IsPositionedInside
            // 
            this.IsPositionedInside.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsPositionedInside.Location = new System.Drawing.Point(13, 95);
            this.IsPositionedInside.Name = "IsPositionedInside";
            this.IsPositionedInside.Size = new System.Drawing.Size(168, 24);
            this.IsPositionedInside.TabIndex = 3;
            this.IsPositionedInside.Text = "ScrollBar I&nside:";
            this.IsPositionedInside.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsPositionedInside.CheckedChanged += new System.EventHandler(this.IsPositionedInside_CheckedChanged);
            // 
            // DataTable1
            // 
            this.DataTable1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DataTable1.Location = new System.Drawing.Point(5, 8);
            this.DataTable1.Name = "DataTable1";
            this.DataTable1.Size = new System.Drawing.Size(176, 24);
            this.DataTable1.TabIndex = 0;
            this.DataTable1.Text = "Show Data &Table:";
            this.DataTable1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DataTable1.CheckedChanged += new System.EventHandler(this.DataTable1_CheckedChanged_1);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 37);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to draw a custom data table using the PrePaint and P" +
                "ostPaint events.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaintingDataTable
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PaintingDataTable";
            this.Size = new System.Drawing.Size(728, 376);
            this.Load += new System.EventHandler(this.PaintingDataTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion


		private void PaintingDataTable_Load(object sender, System.EventArgs e)
		{
		
		}


		private void FontSize_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			chart1.ChartAreas["Default"].AxisX.TitleFont = new Font("Arial", float.Parse(FontSize.SelectedItem.ToString()));
		}

		private void TableColor_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			TableHelper.TableColor = Color.FromName(this.TableColor.SelectedItem.ToString());
			chart1.Invalidate();		
		}

		private void BorderColor_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			TableHelper.BorderColor = Color.FromName(this.BorderColor.SelectedItem.ToString());
			chart1.Invalidate();		
		}

		private void comboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			chart1.ChartAreas["Default"].AxisX.LabelStyle.Angle = int.Parse(RotateAxisLabel.SelectedItem.ToString());
		}

		private void ShowTitle_Click(object sender, System.EventArgs e)
		{
			if(ShowTitle.Checked)
				chart1.ChartAreas["Default"].AxisX.Title = "This is the X Axis";
			else
				chart1.ChartAreas["Default"].AxisX.Title = "";
		}


		private void DataTable1_CheckedChanged_1(object sender, System.EventArgs e)
		{
			if(TableHelper == null)
			{
				TableHelper = new ChartDataTableHelper();
				TableHelper.Initialize(chart1);//, ShowTotals.Checked);
				TableHelper.TableColor = Color.FromName(this.TableColor.SelectedText);
				TableHelper.BorderColor = Color.FromName(this.BorderColor.SelectedText);
			}

			if(DataTable1.Checked)
				TableHelper.AddDataTable("Default");
			else
				TableHelper.RemoveDataTable("Default");

		}


		private void RemoveDataTable(string ChartAreaName)
		{
			TableHelper.RemoveDataTable(ChartAreaName);
		}


		private void IsPositionedInside_CheckedChanged(object sender, System.EventArgs e)
		{
			chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = IsPositionedInside.Checked;
		}

		private void EnableScrollBar_CheckedChanged(object sender, System.EventArgs e)
		{
			chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = EnableScrollBar.Checked;
		}


	}
}


