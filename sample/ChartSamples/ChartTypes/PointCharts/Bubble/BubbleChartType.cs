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
	/// Summary description for BubbleChartType.
	/// </summary>
	public class BubbleChartType : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxShape;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxMaxSize;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxMaxScale;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBoxMinScale;
		private System.Windows.Forms.CheckBox checkBoxShowSizeInLabel;
        private System.Windows.Forms.CheckBox checkBoxShow3D;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BubbleChartType()
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "15,8");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "18,14");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "15,8");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "16,13");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "14,11");
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "9,15");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "8,14");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "12,10");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "9,14");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, "7,12");
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSampleComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this.checkBoxShowSizeInLabel = new System.Windows.Forms.CheckBox();
            this.comboBoxMinScale = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMaxScale = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMaxSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 63);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.YValuesPerPoint = 2;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series2.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Bubble Chart";
            this.chart1.Titles.Add(title1);
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 0);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 56);
            this.labelSampleComment.TabIndex = 2;
            this.labelSampleComment.Text = "This sample displays a Bubble chart that uses different shapes, including an imag" +
                "e, for the bubble. It demonstrates how to control the maximum bubble size and sc" +
                "ale as well as how to enable 3D.";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxShow3D);
            this.panel1.Controls.Add(this.checkBoxShowSizeInLabel);
            this.panel1.Controls.Add(this.comboBoxMinScale);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxMaxScale);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxMaxSize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxShape);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(432, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 280);
            this.panel1.TabIndex = 1;
            // 
            // checkBoxShow3D
            // 
            this.checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShow3D.Location = new System.Drawing.Point(13, 170);
            this.checkBoxShow3D.Name = "checkBoxShow3D";
            this.checkBoxShow3D.Size = new System.Drawing.Size(168, 24);
            this.checkBoxShow3D.TabIndex = 9;
            this.checkBoxShow3D.Text = "Display chart as 3&D:";
            this.checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
            // 
            // checkBoxShowSizeInLabel
            // 
            this.checkBoxShowSizeInLabel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowSizeInLabel.Location = new System.Drawing.Point(-27, 138);
            this.checkBoxShowSizeInLabel.Name = "checkBoxShowSizeInLabel";
            this.checkBoxShowSizeInLabel.Size = new System.Drawing.Size(208, 24);
            this.checkBoxShowSizeInLabel.TabIndex = 8;
            this.checkBoxShowSizeInLabel.Text = "Show Size in &Labels:";
            this.checkBoxShowSizeInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowSizeInLabel.CheckedChanged += new System.EventHandler(this.checkBoxShowSizeInLabel_CheckedChanged);
            // 
            // comboBoxMinScale
            // 
            this.comboBoxMinScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinScale.Items.AddRange(new object[] {
            "Auto",
            "-4",
            "0",
            "4"});
            this.comboBoxMinScale.Location = new System.Drawing.Point(168, 104);
            this.comboBoxMinScale.Name = "comboBoxMinScale";
            this.comboBoxMinScale.Size = new System.Drawing.Size(120, 22);
            this.comboBoxMinScale.TabIndex = 7;
            this.comboBoxMinScale.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaxScale_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bubble Size M&in. Scale:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMaxScale
            // 
            this.comboBoxMaxScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaxScale.Items.AddRange(new object[] {
            "Auto",
            "20",
            "25",
            "30",
            "40"});
            this.comboBoxMaxScale.Location = new System.Drawing.Point(168, 72);
            this.comboBoxMaxScale.Name = "comboBoxMaxScale";
            this.comboBoxMaxScale.Size = new System.Drawing.Size(120, 22);
            this.comboBoxMaxScale.TabIndex = 5;
            this.comboBoxMaxScale.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaxScale_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bubble Size Ma&x. Scale:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMaxSize
            // 
            this.comboBoxMaxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaxSize.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25"});
            this.comboBoxMaxSize.Location = new System.Drawing.Point(168, 40);
            this.comboBoxMaxSize.Name = "comboBoxMaxSize";
            this.comboBoxMaxSize.Size = new System.Drawing.Size(120, 22);
            this.comboBoxMaxSize.TabIndex = 3;
            this.comboBoxMaxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaxScale_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Max. Bubble Size:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShape.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Diamond",
            "Triangle",
            "Cross",
            "Image"});
            this.comboBoxShape.Location = new System.Drawing.Point(168, 8);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(120, 22);
            this.comboBoxShape.TabIndex = 1;
            this.comboBoxShape.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaxScale_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bubble &Shape:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BubbleChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BubbleChartType";
            this.Size = new System.Drawing.Size(728, 392);
            this.Load += new System.EventHandler(this.BubbleChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Set bubble series shape to image
			if(comboBoxShape.Text == "Image")
			{
				// Get image path
				MainForm mainForm = (MainForm)this.ParentForm;
                string imageFileName = mainForm.CurrentSamplePath;
				imageFileName += "\\Face.bmp";
				
				chart1.Series["Default"].MarkerImage = imageFileName;
				chart1.Series["Default"].MarkerImageTransparentColor = Color.White;
				chart1.Series["Default"].MarkerStyle = MarkerStyle.None;
			}

			// Set "bubble" series shape
			else
			{
				chart1.Series["Default"].MarkerImage = "";
				chart1.Series["Default"].MarkerStyle = (MarkerStyle)MarkerStyle.Parse(typeof(MarkerStyle), comboBoxShape.Text);
			}

			// Set max bubble size
			chart1.Series["Default"]["BubbleMaxSize"] = comboBoxMaxSize.Text;

			// Show Y value or bubble sise as point labels
			chart1.Series["Default"].IsValueShownAsLabel = true;
			if(checkBoxShowSizeInLabel.Checked)
			{
				chart1.Series["Default"]["BubbleUseSizeForLabel"] = "true";
			}
			else
			{
				chart1.Series["Default"]["BubbleUseSizeForLabel"] = "false";
			}

			// Set scale for the bubble size
			if(comboBoxMinScale.Text != "Auto")
			{
				chart1.Series["Default"]["BubbleScaleMin"] = comboBoxMinScale.Text;
			}
			else
			{
				chart1.Series["Default"].DeleteCustomProperty("BubbleScaleMin");
			}

			if(comboBoxMaxScale.Text != "Auto")
			{
				chart1.Series["Default"]["BubbleScaleMax"] = comboBoxMaxScale.Text;
			}
			else
			{
				chart1.Series["Default"].DeleteCustomProperty("BubbleScaleMax");
			}

			if(checkBoxShow3D.Checked)
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = true;
			}
			else
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = false;
			}

		}

		private void BubbleChartType_Load(object sender, System.EventArgs e)
		{
			comboBoxShape.SelectedIndex = 0;
			comboBoxMaxSize.SelectedIndex = 2;
			comboBoxMaxScale.SelectedIndex = 0;
			comboBoxMinScale.SelectedIndex = 0;
		}

		private void comboBoxMaxScale_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxShowSizeInLabel_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void checkBoxShow3D_CheckedChanged(object sender, System.EventArgs e)
		{
			comboBoxShape.Items.Clear();
			if(checkBoxShow3D.Checked)
			{
				comboBoxShape.Items.Add("Circle");
				comboBoxShape.Items.Add("Square");
			}
			else
			{
				comboBoxShape.Items.Add("Circle");
				comboBoxShape.Items.Add("Square");
				comboBoxShape.Items.Add("Diamond");
				comboBoxShape.Items.Add("Triangle");
				comboBoxShape.Items.Add("Cross");
				comboBoxShape.Items.Add("Image");
			}
			comboBoxShape.SelectedIndex = 0;

			UpdateChartSettings();
		}
	}
}
