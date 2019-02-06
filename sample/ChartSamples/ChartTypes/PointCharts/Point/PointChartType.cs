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
	/// Summary description for PointChartType.
	/// </summary>
	public class PointChartType : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboMarkerSize;
		private System.Windows.Forms.ComboBox comboBoxMarkerShape;
		private System.Windows.Forms.ComboBox comboBoxLabelPosition;
		private System.Windows.Forms.CheckBox checkBoxShow3D;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PointChartType()
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSampleComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this.comboMarkerSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMarkerShape = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLabelPosition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
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
            this.chart1.Location = new System.Drawing.Point(16, 56);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            series1.Legend = "Default";
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            series1.ShadowOffset = 1;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            series2.Legend = "Default";
            series2.MarkerSize = 10;
            series2.Name = "Series2";
            series2.ShadowOffset = 1;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
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
            this.labelSampleComment.Text = "This sample displays a Point chart. Try setting different marker sizes, shapes an" +
                "d point label positions.";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxShow3D);
            this.panel1.Controls.Add(this.comboMarkerSize);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxMarkerShape);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxLabelPosition);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(432, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // checkBoxShow3D
            // 
            this.checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShow3D.Location = new System.Drawing.Point(13, 104);
            this.checkBoxShow3D.Name = "checkBoxShow3D";
            this.checkBoxShow3D.Size = new System.Drawing.Size(168, 24);
            this.checkBoxShow3D.TabIndex = 6;
            this.checkBoxShow3D.Text = "Display chart as 3&D:";
            this.checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
            // 
            // comboMarkerSize
            // 
            this.comboMarkerSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarkerSize.Items.AddRange(new object[] {
            "5",
            "7",
            "10",
            "12",
            "18"});
            this.comboMarkerSize.Location = new System.Drawing.Point(168, 72);
            this.comboMarkerSize.Name = "comboMarkerSize";
            this.comboMarkerSize.Size = new System.Drawing.Size(120, 22);
            this.comboMarkerSize.TabIndex = 5;
            this.comboMarkerSize.SelectedIndexChanged += new System.EventHandler(this.comboMarkerSize_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marker Si&ze:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMarkerShape
            // 
            this.comboBoxMarkerShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarkerShape.Items.AddRange(new object[] {
            "Circle & Square",
            "Diamond & Triangle",
            "Cross & Star"});
            this.comboBoxMarkerShape.Location = new System.Drawing.Point(168, 40);
            this.comboBoxMarkerShape.Name = "comboBoxMarkerShape";
            this.comboBoxMarkerShape.Size = new System.Drawing.Size(120, 22);
            this.comboBoxMarkerShape.TabIndex = 3;
            this.comboBoxMarkerShape.SelectedIndexChanged += new System.EventHandler(this.comboMarkerSize_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marker &Shape:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxLabelPosition
            // 
            this.comboBoxLabelPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLabelPosition.Items.AddRange(new object[] {
            "None",
            "TopLeft",
            "Top",
            "TopRight",
            "Right",
            "BottomRight",
            "Bottom",
            "BottomLeft",
            "Left",
            "Center"});
            this.comboBoxLabelPosition.Location = new System.Drawing.Point(168, 8);
            this.comboBoxLabelPosition.Name = "comboBoxLabelPosition";
            this.comboBoxLabelPosition.Size = new System.Drawing.Size(120, 22);
            this.comboBoxLabelPosition.TabIndex = 1;
            this.comboBoxLabelPosition.SelectedIndexChanged += new System.EventHandler(this.comboMarkerSize_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Label &Position:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PointChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PointChartType";
            this.Size = new System.Drawing.Size(728, 368);
            this.Load += new System.EventHandler(this.PointChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Set point chart type
			chart1.Series["Series1"].ChartType = SeriesChartType.Point;
			chart1.Series["Series2"].ChartType = SeriesChartType.Point;

			// Enable data points labels
			if(comboBoxLabelPosition.Text != "None")
			{
				chart1.Series["Series1"].IsValueShownAsLabel = true;
				chart1.Series["Series2"].IsValueShownAsLabel = true;
				chart1.Series["Series1"]["LabelStyle"] = comboBoxLabelPosition.Text;
				chart1.Series["Series2"]["LabelStyle"] = comboBoxLabelPosition.Text;
			}
			else
			{
				chart1.Series["Series1"].IsValueShownAsLabel = false;
				chart1.Series["Series2"].IsValueShownAsLabel = false;
			}


			// Set marker size
			chart1.Series["Series1"].MarkerSize = int.Parse(comboMarkerSize.Text);
			chart1.Series["Series2"].MarkerSize = int.Parse(comboMarkerSize.Text);

			// Set marker shape
			if(comboBoxMarkerShape.SelectedIndex == 1)	
			{
				chart1.Series["Series1"].MarkerStyle = MarkerStyle.Diamond;
				chart1.Series["Series2"].MarkerStyle = MarkerStyle.Triangle;
				chart1.Series["Series2"].MarkerImage = "";
			}
			else if(comboBoxMarkerShape.SelectedIndex == 2)	
			{


				chart1.Series["Series1"].MarkerStyle = MarkerStyle.Cross;
                chart1.Series["Series2"].MarkerStyle = MarkerStyle.Star5;
			}
			else
			{
				chart1.Series["Series1"].MarkerStyle = MarkerStyle.Circle;
				chart1.Series["Series2"].MarkerStyle = MarkerStyle.Square;
			}


			// Set X and Y axis scale
			chart1.ChartAreas["Default"].AxisY.Maximum = 100.0;
			chart1.ChartAreas["Default"].AxisY.Minimum = 0.0;
		}	
			
		private void PointChartType_Load(object sender, System.EventArgs e)
		{
			// Populate series data with random data
			Random	random = new Random();
			for(int pointIndex = 0; pointIndex < 10; pointIndex++)
			{
				chart1.Series["Series1"].Points.AddY(random.Next(5, 60));
				chart1.Series["Series2"].Points.AddY(random.Next(50, 95));
			}

			// Set selected items
			comboMarkerSize.SelectedIndex = 1;
			comboBoxMarkerShape.SelectedIndex = 0;
			comboBoxLabelPosition.SelectedIndex = 0;
		}

		private void comboMarkerSize_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void checkBoxShow3D_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBoxShow3D.Checked)
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = true;
				chart1.ChartAreas["Default"].Area3DStyle.LightStyle = LightStyle.Realistic;				
			}
			else
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = false;				
			}
		}

	}
}
