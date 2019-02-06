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
	/// Summary description for AxisAppearance.
	/// </summary>
	public class LabelsFormatting : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox IsEndLabelVisible;
		private System.Windows.Forms.ComboBox XAxisFormat;
		private System.Windows.Forms.ComboBox YAxisFormat;
		private System.Windows.Forms.ComboBox SeriesPointFormat;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LabelsFormatting()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize combo boxes
			XAxisFormat.SelectedIndex = 0;
			YAxisFormat.SelectedIndex = 0;
			SeriesPointFormat.SelectedIndex = 4;
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IsEndLabelVisible = new System.Windows.Forms.CheckBox();
            this.SeriesPointFormat = new System.Windows.Forms.ComboBox();
            this.YAxisFormat = new System.Windows.Forms.ComboBox();
            this.XAxisFormat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 45);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to format axes and data point labels. Data point lab" +
                "els can be set for an entire series or for an individual data point.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IsEndLabelVisible);
            this.panel1.Controls.Add(this.SeriesPointFormat);
            this.panel1.Controls.Add(this.YAxisFormat);
            this.panel1.Controls.Add(this.XAxisFormat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(432, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // IsEndLabelVisible
            // 
            this.IsEndLabelVisible.Location = new System.Drawing.Point(48, 148);
            this.IsEndLabelVisible.Name = "IsEndLabelVisible";
            this.IsEndLabelVisible.Size = new System.Drawing.Size(192, 24);
            this.IsEndLabelVisible.TabIndex = 6;
            this.IsEndLabelVisible.Text = "Show X &Axis End Labels";
            this.IsEndLabelVisible.CheckedChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // SeriesPointFormat
            // 
            this.SeriesPointFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeriesPointFormat.Items.AddRange(new object[] {
            "Currency",
            "Currency Rounded",
            "Scientific",
            "Scientific  Rounded",
            "Percent",
            "Percent Rounded"});
            this.SeriesPointFormat.Location = new System.Drawing.Point(48, 116);
            this.SeriesPointFormat.Name = "SeriesPointFormat";
            this.SeriesPointFormat.Size = new System.Drawing.Size(172, 22);
            this.SeriesPointFormat.TabIndex = 5;
            this.SeriesPointFormat.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // YAxisFormat
            // 
            this.YAxisFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YAxisFormat.Items.AddRange(new object[] {
            "Currency",
            "Currency Rounded",
            "Scientific",
            "Scientific  Rounded",
            "Percent",
            "Percent Rounded"});
            this.YAxisFormat.Location = new System.Drawing.Point(48, 72);
            this.YAxisFormat.Name = "YAxisFormat";
            this.YAxisFormat.Size = new System.Drawing.Size(172, 22);
            this.YAxisFormat.TabIndex = 3;
            this.YAxisFormat.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // XAxisFormat
            // 
            this.XAxisFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XAxisFormat.Items.AddRange(new object[] {
            "Short Date",
            "Month Day",
            "Month Year",
            "Week Day",
            "Long Date",
            "General Date/Time"});
            this.XAxisFormat.Location = new System.Drawing.Point(48, 24);
            this.XAxisFormat.Name = "XAxisFormat";
            this.XAxisFormat.Size = new System.Drawing.Size(172, 22);
            this.XAxisFormat.TabIndex = 1;
            this.XAxisFormat.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(44, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "&Series Points Labels Format:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(48, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Y Axis Labels Format:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(48, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "&X Axis Labels Format:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(64, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Border Size:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(64, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Border Color:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(64, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hatch Style:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(64, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gradient:";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(64, 426);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 5;
            this.label15.Text = "Border Size:";
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.Chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.Chart1.BorderlineWidth = 2;
            this.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
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
            this.Chart1.Location = new System.Drawing.Point(16, 63);
            this.Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Default";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series1.MarkerSize = 9;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.ShadowOffset = 1;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 1;
            // 
            // LabelsFormatting
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LabelsFormatting";
            this.Size = new System.Drawing.Size(728, 368);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Combo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Labels();
		}

		private void Labels()
		{
			// Populate series data
			Random		random = new Random(7259);
			DateTime	dateCurrent = DateTime.Now.Date;
			Chart1.Series["Series1"].Points.Clear();
			for(int pointIndex = 0; pointIndex < 7; pointIndex++)
			{
				Chart1.Series["Series1"].Points.AddXY(dateCurrent.AddDays(pointIndex), random.Next(2000, 9000)/100.0);
			}

			Chart1.ChartAreas["Default"].BackColor = Color.White;
			
			// Disable end labels for the X axis
			if(!IsEndLabelVisible.Checked)
			{
				Chart1.ChartAreas["Default"].AxisX.LabelStyle.IsEndLabelVisible = false;
			}
			else
			{
				Chart1.ChartAreas["Default"].AxisX.LabelStyle.IsEndLabelVisible = true;
			}

			// Set X axis labels format
			Chart1.ChartAreas["Default"].AxisX.LabelStyle.Format = GetDateItem(XAxisFormat.SelectedIndex);

			// Set Y axis labels format
			Chart1.ChartAreas["Default"].AxisY.LabelStyle.Format = GetNumItem(YAxisFormat.SelectedIndex);

			// Set series point labels format
			Chart1.Series["Series1"].LabelFormat = GetNumItem(SeriesPointFormat.SelectedIndex);

			// Set series point labels color
			Chart1.Series["Series1"].Color = Color.Navy;
		}

		private string GetDateItem( int item )
		{
			string format;
			switch( item )
			{
				case 0:
					format = "d";
					break;
				case 1:
					format = "M";
					break;
				case 2:
					format = "Y";
					break;
				case 3:
					format = "ddd,d";
					break;
				case 4:
					format = "D";
					break;
				case 5:
					format = "G";
					break;
				default: 
					format = "";
					break;
			}

			return format;
		}

		private string GetNumItem( int item )
		{
			string format;
			switch( item )
			{
				case 0:
					format = "C";
					break;
				case 1:
					format = "C0";
					break;
				case 2:
					format = "E";
					break;
				case 3:
					format = "E0";
					break;
				case 4:
					format = "P";
					break;
				case 5:
					format = "P0";
					break;
				default: 
					format = "";
					break;
			}

			return format;
		}

	}
}
