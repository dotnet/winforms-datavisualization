using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Utilities;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for PieCollected.
	/// </summary>
	public class PieCollected : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.ComboBox comboBoxCollectedThreshold;
		private System.Windows.Forms.TextBox textBoxCollectedLabel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxCollectedColor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBoxCollectPieSlices;
		private System.Windows.Forms.CheckBox checkBoxShowExploded;
		private System.Windows.Forms.ComboBox comboBoxChartType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxCollectedLegend;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PieCollected()
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 39);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 18);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 15);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 12);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 4.5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3.2000000476837158);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 1);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSampleComment = new System.Windows.Forms.Label();
            this.comboBoxCollectedThreshold = new System.Windows.Forms.ComboBox();
            this.textBoxCollectedLabel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCollectedColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxCollectPieSlices = new System.Windows.Forms.CheckBox();
            this.checkBoxShowExploded = new System.Windows.Forms.CheckBox();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCollectedLegend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.PointGapDepth = 900;
            chartArea1.Area3DStyle.Rotation = 162;
            chartArea1.Area3DStyle.WallWidth = 25;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorTickMark.Enabled = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Area1";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.IsSoftShadows = false;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            legend1.IsEquallySpacedItems = true;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 61);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.ChartArea = "Area1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DoughnutRadius=25, PieDrawingStyle=Concave, CollectedLabel=Other, MinimumRelative" +
                "PieSize=20";
            series1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            series1.Label = "#PERCENT{P1}";
            series1.Legend = "Default";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            dataPoint1.CustomProperties = "OriginalPointIndex=0";
            dataPoint1.IsValueShownAsLabel = false;
            dataPoint1.LegendText = "RUS";
            dataPoint2.CustomProperties = "OriginalPointIndex=1";
            dataPoint2.IsValueShownAsLabel = false;
            dataPoint2.LegendText = "CAN";
            dataPoint3.CustomProperties = "OriginalPointIndex=2";
            dataPoint3.IsValueShownAsLabel = false;
            dataPoint3.LegendText = "USA";
            dataPoint4.CustomProperties = "OriginalPointIndex=3";
            dataPoint4.LegendText = "PRC";
            dataPoint5.CustomProperties = "OriginalPointIndex=5";
            dataPoint5.LegendText = "DEN";
            dataPoint6.LegendText = "AUS";
            dataPoint7.CustomProperties = "OriginalPointIndex=4";
            dataPoint7.LegendText = "IND";
            dataPoint8.LegendText = "ARG";
            dataPoint9.LegendText = "FRA";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 45);
            this.labelSampleComment.TabIndex = 0;
            this.labelSampleComment.Text = "This sample demonstrates how to group many small segments of a pie or doughnut ch" +
                "art into one collected slice to improve chart readability.";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxCollectedThreshold
            // 
            this.comboBoxCollectedThreshold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCollectedThreshold.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCollectedThreshold.ItemHeight = 14;
            this.comboBoxCollectedThreshold.Items.AddRange(new object[] {
            "5",
            "8",
            "12",
            "15"});
            this.comboBoxCollectedThreshold.Location = new System.Drawing.Point(184, 40);
            this.comboBoxCollectedThreshold.Name = "comboBoxCollectedThreshold";
            this.comboBoxCollectedThreshold.Size = new System.Drawing.Size(104, 22);
            this.comboBoxCollectedThreshold.TabIndex = 2;
            this.comboBoxCollectedThreshold.SelectedIndexChanged += new System.EventHandler(this.comboBoxCollectedThreshold_SelectedIndexChanged);
            // 
            // textBoxCollectedLabel
            // 
            this.textBoxCollectedLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCollectedLabel.Location = new System.Drawing.Point(184, 104);
            this.textBoxCollectedLabel.MaxLength = 12;
            this.textBoxCollectedLabel.Name = "textBoxCollectedLabel";
            this.textBoxCollectedLabel.Size = new System.Drawing.Size(104, 22);
            this.textBoxCollectedLabel.TabIndex = 4;
            this.textBoxCollectedLabel.TextChanged += new System.EventHandler(this.textBoxCollectedLabel_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Collected &Label:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Collected &Color:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxCollectedColor
            // 
            this.comboBoxCollectedColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCollectedColor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCollectedColor.ItemHeight = 14;
            this.comboBoxCollectedColor.Items.AddRange(new object[] {
            "Green",
            "Gold",
            "Gray",
            "Magenta"});
            this.comboBoxCollectedColor.Location = new System.Drawing.Point(184, 72);
            this.comboBoxCollectedColor.Name = "comboBoxCollectedColor";
            this.comboBoxCollectedColor.Size = new System.Drawing.Size(104, 22);
            this.comboBoxCollectedColor.TabIndex = 3;
            this.comboBoxCollectedColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxCollectedColor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Collected &Threshold (in %):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxCollectPieSlices
            // 
            this.checkBoxCollectPieSlices.BackColor = System.Drawing.Color.White;
            this.checkBoxCollectPieSlices.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCollectPieSlices.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCollectPieSlices.Location = new System.Drawing.Point(38, 8);
            this.checkBoxCollectPieSlices.Name = "checkBoxCollectPieSlices";
            this.checkBoxCollectPieSlices.Size = new System.Drawing.Size(160, 24);
            this.checkBoxCollectPieSlices.TabIndex = 1;
            this.checkBoxCollectPieSlices.Text = "Collect &Pie Slices:     ";
            this.checkBoxCollectPieSlices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCollectPieSlices.UseVisualStyleBackColor = false;
            this.checkBoxCollectPieSlices.CheckedChanged += new System.EventHandler(this.checkBoxCollectPieSlices_CheckedChanged);
            // 
            // checkBoxShowExploded
            // 
            this.checkBoxShowExploded.BackColor = System.Drawing.Color.White;
            this.checkBoxShowExploded.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowExploded.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowExploded.Location = new System.Drawing.Point(62, 165);
            this.checkBoxShowExploded.Name = "checkBoxShowExploded";
            this.checkBoxShowExploded.Size = new System.Drawing.Size(136, 24);
            this.checkBoxShowExploded.TabIndex = 6;
            this.checkBoxShowExploded.Text = "&Show Exploded: ";
            this.checkBoxShowExploded.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowExploded.UseVisualStyleBackColor = false;
            this.checkBoxShowExploded.CheckedChanged += new System.EventHandler(this.checkBoxcollectSmallSegments_CheckedChanged);
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChartType.ItemHeight = 14;
            this.comboBoxChartType.Items.AddRange(new object[] {
            "Pie",
            "Doughnut"});
            this.comboBoxChartType.Location = new System.Drawing.Point(184, 195);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(104, 22);
            this.comboBoxChartType.TabIndex = 7;
            this.comboBoxChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chart &Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxCollectedLegend);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxCollectedThreshold);
            this.panel1.Controls.Add(this.textBoxCollectedLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxCollectedColor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBoxCollectPieSlices);
            this.panel1.Controls.Add(this.checkBoxShowExploded);
            this.panel1.Controls.Add(this.comboBoxChartType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(432, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 0;
            // 
            // textBoxCollectedLegend
            // 
            this.textBoxCollectedLegend.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCollectedLegend.Location = new System.Drawing.Point(184, 136);
            this.textBoxCollectedLegend.MaxLength = 12;
            this.textBoxCollectedLegend.Name = "textBoxCollectedLegend";
            this.textBoxCollectedLegend.Size = new System.Drawing.Size(104, 22);
            this.textBoxCollectedLegend.TabIndex = 5;
            this.textBoxCollectedLegend.TextChanged += new System.EventHandler(this.textBoxCollectedLegend_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Collected &Legend Text:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PieCollected
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PieCollected";
            this.Size = new System.Drawing.Size(728, 368);
            this.Load += new System.EventHandler(this.PieChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			Series series1 = chart1.Series[0];

			if (this.checkBoxCollectPieSlices.Checked) 
			{
				comboBoxChartType.Enabled = true;
				comboBoxCollectedColor.Enabled = true;
				comboBoxCollectedThreshold.Enabled = true;
				textBoxCollectedLabel.Enabled = true;
				textBoxCollectedLegend.Enabled = true;
				checkBoxCollectPieSlices.Enabled = true;
				checkBoxCollectPieSlices.Enabled = true;
				checkBoxShowExploded.Enabled = true;

				// Set the threshold under which all points will be collected
				series1["CollectedThreshold"] = comboBoxCollectedThreshold.GetItemText(comboBoxCollectedThreshold.SelectedItem);
				
				// Set the label of the collected pie slice
				series1["CollectedLabel"] = textBoxCollectedLabel.Text;
				
				// Set the legend text of the collected pie slice
				series1["CollectedLegendText"] = textBoxCollectedLegend.Text;

				// Set the collected pie slice to be exploded
				series1["CollectedSliceExploded"]= checkBoxShowExploded.Checked.ToString();

				// Set collected color
				series1["CollectedColor"] = comboBoxCollectedColor.GetItemText(comboBoxCollectedColor.SelectedItem);

				// Set chart type
				series1.ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), comboBoxChartType.Text, true );

			}

			else 
			{
				series1["CollectedThreshold"] = "0";
				comboBoxChartType.Enabled = false;
				comboBoxCollectedColor.Enabled = false;
				comboBoxCollectedThreshold.Enabled = false;
				textBoxCollectedLabel.Enabled = false;
				textBoxCollectedLegend.Enabled = false;
				checkBoxShowExploded.Enabled = false;
			}
		}

		private void PieChartType_Load(object sender, System.EventArgs e)
		{
			// Set series font
			chart1.Series[0].Font = new Font("Trebuchet MS", 8, FontStyle.Bold);
            
			// Set current selection
			checkBoxCollectPieSlices.Checked = false;
			comboBoxChartType.SelectedIndex = 0;
			comboBoxCollectedColor.SelectedIndex = 0;
			comboBoxCollectedThreshold.SelectedIndex = 0;
			textBoxCollectedLabel.Text = "Other";
			textBoxCollectedLegend.Text = "Other";

			chart1.Series[0]["CollectedToolTip"] = "Other";

			// Update chart
			UpdateChartSettings();
		}

		private void comboBoxChartType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxcollectSmallSegments_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxCollectedColor_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void textBoxCollectedLabel_TextChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void comboBoxCollectedThreshold_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void textBoxCollectedLegend_TextChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxCollectPieSlices_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}
	}
}
