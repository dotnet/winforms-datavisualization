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
	/// Summary description for StackedChartType.
	/// </summary>
	public class StackedChartType : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxChartType;
		private System.Windows.Forms.CheckBox checkBoxHundredPercent;
		private System.Windows.Forms.CheckBox checkBoxShowLabels;
		private System.Windows.Forms.CheckBox checkBoxShowMargin;
		private System.Windows.Forms.CheckBox checkBoxShow3D;
		private System.Windows.Forms.CheckBox checkBoxGrouped;
		private System.Windows.Forms.Label label2;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public StackedChartType()
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSampleComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxGrouped = new System.Windows.Forms.CheckBox();
            this.checkBoxShow3D = new System.Windows.Forms.CheckBox();
            this.checkBoxShowMargin = new System.Windows.Forms.CheckBox();
            this.checkBoxShowLabels = new System.Windows.Forms.CheckBox();
            this.checkBoxHundredPercent = new System.Windows.Forms.CheckBox();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 92F;
            chartArea1.Position.Width = 92F;
            chartArea1.Position.X = 2F;
            chartArea1.Position.Y = 3F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 53);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.Legend = "Default";
            series1.Name = "Series1";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Default";
            series2.Name = "Series2";
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.Legend = "Default";
            series3.Name = "Series3";
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series4.ChartArea = "Default";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            series4.Legend = "Default";
            series4.Name = "Series4";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 1;
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 37);
            this.labelSampleComment.TabIndex = 0;
            this.labelSampleComment.Text = "This sample demonstrates Stacked Area, Stacked Bar, Stacked Column, 100% Stacked " +
                "Area, 100% Stacked Bar, and 100% Stacked Column chart types.";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxGrouped);
            this.panel1.Controls.Add(this.checkBoxShow3D);
            this.panel1.Controls.Add(this.checkBoxShowMargin);
            this.panel1.Controls.Add(this.checkBoxShowLabels);
            this.panel1.Controls.Add(this.checkBoxHundredPercent);
            this.panel1.Controls.Add(this.comboBoxChartType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(432, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // checkBoxGrouped
            // 
            this.checkBoxGrouped.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxGrouped.Location = new System.Drawing.Point(88, 176);
            this.checkBoxGrouped.Name = "checkBoxGrouped";
            this.checkBoxGrouped.Size = new System.Drawing.Size(96, 24);
            this.checkBoxGrouped.TabIndex = 6;
            this.checkBoxGrouped.Text = "&Grouped:";
            this.checkBoxGrouped.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxGrouped.CheckedChanged += new System.EventHandler(this.checkBoxGrouped_CheckedChanged);
            // 
            // checkBoxShow3D
            // 
            this.checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShow3D.Location = new System.Drawing.Point(15, 144);
            this.checkBoxShow3D.Name = "checkBoxShow3D";
            this.checkBoxShow3D.Size = new System.Drawing.Size(168, 24);
            this.checkBoxShow3D.TabIndex = 5;
            this.checkBoxShow3D.Text = "Display chart as 3&D:";
            this.checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
            // 
            // checkBoxShowMargin
            // 
            this.checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowMargin.Checked = true;
            this.checkBoxShowMargin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowMargin.Location = new System.Drawing.Point(15, 112);
            this.checkBoxShowMargin.Name = "checkBoxShowMargin";
            this.checkBoxShowMargin.Size = new System.Drawing.Size(168, 24);
            this.checkBoxShowMargin.TabIndex = 4;
            this.checkBoxShowMargin.Text = "Show X Axis &Margin:";
            this.checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowMargin.CheckedChanged += new System.EventHandler(this.checkBoxShowLabels_CheckedChanged_1);
            // 
            // checkBoxShowLabels
            // 
            this.checkBoxShowLabels.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowLabels.Location = new System.Drawing.Point(15, 80);
            this.checkBoxShowLabels.Name = "checkBoxShowLabels";
            this.checkBoxShowLabels.Size = new System.Drawing.Size(168, 24);
            this.checkBoxShowLabels.TabIndex = 3;
            this.checkBoxShowLabels.Text = "Show Point &Labels:";
            this.checkBoxShowLabels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowLabels.CheckedChanged += new System.EventHandler(this.checkBoxShowLabels_CheckedChanged_1);
            // 
            // checkBoxHundredPercent
            // 
            this.checkBoxHundredPercent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxHundredPercent.Location = new System.Drawing.Point(15, 48);
            this.checkBoxHundredPercent.Name = "checkBoxHundredPercent";
            this.checkBoxHundredPercent.Size = new System.Drawing.Size(168, 24);
            this.checkBoxHundredPercent.TabIndex = 2;
            this.checkBoxHundredPercent.Text = "100% &Stacked:";
            this.checkBoxHundredPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxHundredPercent.CheckedChanged += new System.EventHandler(this.checkBoxShowLabels_CheckedChanged_1);
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType.Items.AddRange(new object[] {
            "StackedArea",
            "StackedBar",
            "StackedColumn"});
            this.comboBoxChartType.Location = new System.Drawing.Point(168, 16);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(121, 22);
            this.comboBoxChartType.TabIndex = 1;
            this.comboBoxChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(44, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chart Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(702, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "When using the Stacked bar or Stacked column types, you can group different serie" +
                "s into separate groups by setting the StackedGroupName custom attribute.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StackedChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StackedChartType";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.StackedChartType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Set chart type
			string	chartTypeName = comboBoxChartType.Text;
			if(checkBoxHundredPercent.Checked)
			{
				chartTypeName = chartTypeName + "100";
			}

			// Grouping cannot be done using stacked area charts
			if (chartTypeName == "StackedArea" || chartTypeName == "StackedArea100") 
				this.checkBoxGrouped.Enabled = false;

			else
				this.checkBoxGrouped.Enabled = true;

			chart1.Series["Series1"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), chartTypeName, true );
			chart1.Series["Series2"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), chartTypeName, true );
			chart1.Series["Series3"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), chartTypeName, true );
			chart1.Series["Series4"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), chartTypeName, true );

			// Show point labels
			chart1.Series["Series1"].IsValueShownAsLabel = checkBoxShowLabels.Checked;
			chart1.Series["Series2"].IsValueShownAsLabel = checkBoxShowLabels.Checked;
			chart1.Series["Series3"].IsValueShownAsLabel = checkBoxShowLabels.Checked;
			chart1.Series["Series4"].IsValueShownAsLabel = checkBoxShowLabels.Checked;

			// Enable/Disable margin
			chart1.ChartAreas["Default"].AxisX.IsMarginVisible = checkBoxShowMargin.Checked;
		}

		private void StackedChartType_Load(object sender, System.EventArgs e)
		{
			// Populate series data
			Random	random = new Random();
			for(int pointIndex = 0; pointIndex < 10; pointIndex++)
			{
				chart1.Series["Series1"].Points.AddY(random.Next(75, 170));
				chart1.Series["Series2"].Points.AddY(random.Next(35, 125));
				chart1.Series["Series3"].Points.AddY(random.Next(45, 140));
				chart1.Series["Series4"].Points.AddY(random.Next(25, 110));
			}

			// Set selection
			comboBoxChartType.SelectedIndex = 2;
		}

		private void checkBoxShowLabels_CheckedChanged_1(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxChartType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();		
		}

		private void checkBoxShow3D_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBoxShow3D.Checked){
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = true;
				chart1.ChartAreas["Default"].Area3DStyle.LightStyle = LightStyle.Simplistic;		
			}

			else
			{
				chart1.ChartAreas["Default"].Area3DStyle.Enable3D = false;				
			}
		}

		private void checkBoxGrouped_CheckedChanged(object sender, System.EventArgs e)
		{
			if (checkBoxGrouped.Checked) 
			{
				chart1.Series["Series1"]["StackedGroupName"] = "Group1";
				chart1.Series["Series2"]["StackedGroupName"] = "Group1";
				chart1.Series["Series3"]["StackedGroupName"] = "Group2";
				chart1.Series["Series4"]["StackedGroupName"] = "Group2";

				chart1.ResetAutoValues();
				chart1.Invalidate();
			}

			else 
			{
				foreach (Series series in chart1.Series) 
				{
					series["StackedGroupName"] = "";
				}

				chart1.ResetAutoValues();
				chart1.Invalidate();

			}
		
		}
	}
}
