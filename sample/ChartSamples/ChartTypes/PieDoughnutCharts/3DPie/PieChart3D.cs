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
	/// Summary description for PieChart3D.
	/// </summary>
	public class PieChart3D : System.Windows.Forms.UserControl
	{
		# region Fields

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxChartType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxLabelStyle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxExploded;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.CheckBox ShowLegend;
		private System.Windows.Forms.ComboBox comboBoxRadius;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBoxShow3D;
		private System.Windows.Forms.CheckBox checkBoxRotate;
        private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxPieDrawingStyle;
		private int angle = 0;

		#endregion

		# region Constructor

		public PieChart3D()
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

		#endregion

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 65.62);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 75.54);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 60.45);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 55.73);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 70.42);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSampleComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPieDrawingStyle = new System.Windows.Forms.ComboBox();
            this.checkBoxRotate = new System.Windows.Forms.CheckBox();
            this.checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this.comboBoxRadius = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowLegend = new System.Windows.Forms.CheckBox();
            this.comboBoxExploded = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLabelStyle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 0;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 40);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DoughnutRadius=60, PieLabelStyle=Disabled, PieDrawingStyle=SoftEdge";
            series1.Legend = "Default";
            series1.Name = "Default";
            dataPoint1.CustomProperties = "Exploded=false";
            dataPoint1.Label = "France";
            dataPoint2.CustomProperties = "Exploded=false";
            dataPoint2.Label = "Canada";
            dataPoint3.CustomProperties = "Exploded=false";
            dataPoint3.Label = "UK";
            dataPoint4.CustomProperties = "Exploded=false";
            dataPoint4.Label = "USA";
            dataPoint5.CustomProperties = "Exploded=false";
            dataPoint5.Label = "Italy";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Doughnut Chart";
            this.chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 26);
            this.labelSampleComment.TabIndex = 2;
            this.labelSampleComment.Text = "This sample demonstrates the Pie and Doughnut chart types in both 2D and 3D.";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBoxPieDrawingStyle);
            this.panel1.Controls.Add(this.checkBoxRotate);
            this.panel1.Controls.Add(this.checkBoxShow3D);
            this.panel1.Controls.Add(this.comboBoxRadius);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ShowLegend);
            this.panel1.Controls.Add(this.comboBoxExploded);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxLabelStyle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxChartType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(432, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(49, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "&Drawing Style:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxPieDrawingStyle
            // 
            this.comboBoxPieDrawingStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPieDrawingStyle.Items.AddRange(new object[] {
            "Default",
            "SoftEdge",
            "Concave"});
            this.comboBoxPieDrawingStyle.Location = new System.Drawing.Point(167, 229);
            this.comboBoxPieDrawingStyle.Name = "comboBoxPieDrawingStyle";
            this.comboBoxPieDrawingStyle.Size = new System.Drawing.Size(112, 22);
            this.comboBoxPieDrawingStyle.TabIndex = 13;
            this.comboBoxPieDrawingStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrawingStyle_SelectedIndexChanged);
            // 
            // checkBoxRotate
            // 
            this.checkBoxRotate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRotate.Location = new System.Drawing.Point(13, 166);
            this.checkBoxRotate.Name = "checkBoxRotate";
            this.checkBoxRotate.Size = new System.Drawing.Size(168, 24);
            this.checkBoxRotate.TabIndex = 12;
            this.checkBoxRotate.Text = "Rotate C&hart:";
            this.checkBoxRotate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxShow3D
            // 
            this.checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShow3D.Location = new System.Drawing.Point(14, 197);
            this.checkBoxShow3D.Name = "checkBoxShow3D";
            this.checkBoxShow3D.Size = new System.Drawing.Size(168, 24);
            this.checkBoxShow3D.TabIndex = 11;
            this.checkBoxShow3D.Text = "Display &chart as 3D:";
            this.checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
            // 
            // comboBoxRadius
            // 
            this.comboBoxRadius.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRadius.Items.AddRange(new object[] {
            "20",
            "30",
            "40",
            "50",
            "60",
            "70"});
            this.comboBoxRadius.Location = new System.Drawing.Point(168, 104);
            this.comboBoxRadius.Name = "comboBoxRadius";
            this.comboBoxRadius.Size = new System.Drawing.Size(112, 22);
            this.comboBoxRadius.TabIndex = 3;
            this.comboBoxRadius.SelectedIndexChanged += new System.EventHandler(this.comboBoxRadius_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doughnut &Radius (%):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShowLegend
            // 
            this.ShowLegend.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowLegend.Checked = true;
            this.ShowLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowLegend.Location = new System.Drawing.Point(21, 136);
            this.ShowLegend.Name = "ShowLegend";
            this.ShowLegend.Size = new System.Drawing.Size(160, 24);
            this.ShowLegend.TabIndex = 4;
            this.ShowLegend.Text = "Show &Legend:";
            this.ShowLegend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowLegend.CheckedChanged += new System.EventHandler(this.ShowLegend_CheckedChanged);
            // 
            // comboBoxExploded
            // 
            this.comboBoxExploded.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExploded.Items.AddRange(new object[] {
            "None",
            "France",
            "Canada",
            "UK",
            "USA",
            "Italy"});
            this.comboBoxExploded.Location = new System.Drawing.Point(168, 72);
            this.comboBoxExploded.Name = "comboBoxExploded";
            this.comboBoxExploded.Size = new System.Drawing.Size(112, 22);
            this.comboBoxExploded.TabIndex = 2;
            this.comboBoxExploded.SelectedIndexChanged += new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "&Exploded Point:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxLabelStyle
            // 
            this.comboBoxLabelStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLabelStyle.Items.AddRange(new object[] {
            "Inside",
            "Outside",
            "Disabled"});
            this.comboBoxLabelStyle.Location = new System.Drawing.Point(168, 40);
            this.comboBoxLabelStyle.Name = "comboBoxLabelStyle";
            this.comboBoxLabelStyle.Size = new System.Drawing.Size(112, 22);
            this.comboBoxLabelStyle.TabIndex = 1;
            this.comboBoxLabelStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Label &Style:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType.Items.AddRange(new object[] {
            "Pie",
            "Doughnut"});
            this.comboBoxChartType.Location = new System.Drawing.Point(168, 8);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(112, 22);
            this.comboBoxChartType.TabIndex = 0;
            this.comboBoxChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxExploded_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chart &Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PieChart3D
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PieChart3D";
            this.Size = new System.Drawing.Size(728, 440);
            this.Load += new System.EventHandler(this.PieChart3D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			chart1.Legends[0].Enabled = ShowLegend.Checked;	

			// Set chart type and title
			chart1.Series["Default"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), comboBoxChartType.Text, true );
			chart1.Titles[0].Text = comboBoxChartType.Text + " Chart";

			// Set labels style
			chart1.Series["Default"]["PieLabelStyle"] = comboBoxLabelStyle.Text;

			// Set Doughnut hole size
			chart1.Series["Default"]["DoughnutRadius"] = comboBoxRadius.Text;

			// Disable Doughnut hole size control for Pie chart
			comboBoxRadius.Enabled = (comboBoxChartType.Text != "Pie");

			// Explode selected country
			foreach(DataPoint point in chart1.Series["Default"].Points)
			{
				point["Exploded"] = "false";
				if(point.AxisLabel == comboBoxExploded.Text)
				{
					point["Exploded"] = "true";
				}
			}

			// Enable 3D
			chart1.ChartAreas[0].Area3DStyle.Enable3D = checkBoxShow3D.Checked;

			// Pie drawing style
			if (this.checkBoxShow3D.Checked)
				this.comboBoxPieDrawingStyle.Enabled = false;
			
			else
				this.comboBoxPieDrawingStyle.Enabled = true;
		}

		private void PieChart3D_Load(object sender, System.EventArgs e)
		{
			// Populate series data
			double[]	yValues = {65.62, 75.54, 60.45, 55.73, 70.42};
			string[]	xValues = {"France", "Canada", "UK", "USA", "Italy"};
			chart1.Series["Default"].Points.DataBindXY(xValues, yValues);		

			// Set selection
			comboBoxChartType.SelectedIndex = 1;
			this.comboBoxPieDrawingStyle.SelectedIndex = 1;
			comboBoxLabelStyle.SelectedIndex = 0;
			comboBoxExploded.SelectedIndex = 0;
			comboBoxRadius.SelectedIndex = 4;
			chart1.Legends[0].Enabled = ShowLegend.Checked;
		}

		private void comboBoxExploded_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if(checkBoxRotate.Checked)
			{
				angle += 1;
				if(angle >= 360)
				{
					angle = 0;
				}
				chart1.Series["Default"]["PieStartAngle"] = angle.ToString();		
			}
		}

		private void ShowLegend_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void comboBoxRadius_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void LabelLineSizeBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxShow3D_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();			
		}

		private void comboBoxDrawingStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			chart1.Series[0]["PieDrawingStyle"] = this.comboBoxPieDrawingStyle.SelectedItem.ToString();
		}
	}
}
