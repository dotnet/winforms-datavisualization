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
	/// Summary description for PrimarySecondaryAxis.
	/// </summary>
	public class PrimarySecondaryAxis : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.ComboBox Criterion;
		private System.Windows.Forms.CheckBox SecondaryYCheck;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PrimarySecondaryAxis()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			this.Criterion.SelectedIndex = 0;	

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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5400);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3200);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2700);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Criterion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SecondaryYCheck = new System.Windows.Forms.CheckBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Criterion
            // 
            this.Criterion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Criterion.Items.AddRange(new object[] {
            "Range",
            "Max. Weight",
            "Wing Span",
            "Passengers"});
            this.Criterion.Location = new System.Drawing.Point(168, 2);
            this.Criterion.Name = "Criterion";
            this.Criterion.Size = new System.Drawing.Size(121, 22);
            this.Criterion.TabIndex = 1;
            this.Criterion.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(29, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Aircraft &Data:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to use two different scales for the primary and seco" +
                "ndary Y axes.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SecondaryYCheck);
            this.panel1.Controls.Add(this.Criterion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(432, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // SecondaryYCheck
            // 
            this.SecondaryYCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SecondaryYCheck.Checked = true;
            this.SecondaryYCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SecondaryYCheck.Location = new System.Drawing.Point(18, 30);
            this.SecondaryYCheck.Name = "SecondaryYCheck";
            this.SecondaryYCheck.Size = new System.Drawing.Size(164, 24);
            this.SecondaryYCheck.TabIndex = 2;
            this.SecondaryYCheck.Text = "Secondary &Y Axis:";
            this.SecondaryYCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SecondaryYCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
            // 
            // Chart1
            // 
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
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX2.IsLabelAutoFit = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
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
            this.Chart1.Location = new System.Drawing.Point(16, 56);
            this.Chart1.Name = "Chart1";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Default";
            series1.Name = "Default";
            dataPoint1.AxisLabel = "Plane 1";
            dataPoint1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            dataPoint1.BorderWidth = 2;
            dataPoint2.AxisLabel = "Plane 2";
            dataPoint2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            dataPoint2.BorderWidth = 2;
            dataPoint3.AxisLabel = "Plane 3";
            dataPoint3.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            dataPoint3.BorderWidth = 2;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(412, 360);
            this.Chart1.TabIndex = 1;
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Aircraft";
            this.Chart1.Titles.Add(title1);
            // 
            // PrimarySecondaryAxis
            // 
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PrimarySecondaryAxis";
            this.Size = new System.Drawing.Size(728, 432);
            //this.Load += new System.EventHandler(this.PrimarySecondaryAxis_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


/*		private void PrimarySecondaryAxis_Load(object sender, System.EventArgs e)
		{ 
			MainForm mainForm = (MainForm)this.ParentForm;
            Chart1.Series["Default"].Points[0].BackImage = mainForm.CurrentSamplePath + "\\a.png";
			Chart1.Series["Default"].Points[1].BackImage = mainForm.CurrentSamplePath + "\\b2.png";
			Chart1.Series["Default"].Points[2].BackImage = mainForm.CurrentSamplePath + "\\b1.png";
		
		}
*/
		private void ControlChange(object sender, System.EventArgs e)
		{
			string strSelection = "Range";
			if(this.Criterion.SelectedIndex >= 0)
			{
				strSelection = this.Criterion.SelectedItem.ToString();
			}

			// Enable secondary Y axis
			if( SecondaryYCheck.Checked )
				Chart1.ChartAreas["Default"].AxisY2.Enabled = AxisEnabled.True;
			else
				Chart1.ChartAreas["Default"].AxisY2.Enabled = AxisEnabled.False;

			// Set a characteristic of a plane.
			switch( strSelection )
			{
					// Aircraft range
				case "Range":
					// Set Y values
					Chart1.Series["Default"].Points[2].YValues[0] = 5955;
					Chart1.Series["Default"].Points[1].YValues[0] = 7260;
					Chart1.Series["Default"].Points[0].YValues[0] = 8000;

					// Set maximum values for Y axes.
					Chart1.ChartAreas["Default"].AxisY.Maximum = 12000;
					Chart1.ChartAreas["Default"].AxisY2.Maximum = 22224;

					// Set titles for Y axes
					Chart1.ChartAreas["Default"].AxisY.Title = "In Nautical miles";
					Chart1.ChartAreas["Default"].AxisY2.Title = "In Kilometers";

					break;
					// The number of passengers.
				case "Passengers":
					// Set Y values
					Chart1.Series["Default"].Points[2].YValues[0] = 368;
					Chart1.Series["Default"].Points[1].YValues[0] = 416;
					Chart1.Series["Default"].Points[0].YValues[0] = 555;

					// Set maximum values for Y axes.
					Chart1.ChartAreas["Default"].AxisY.Maximum = 800;
					Chart1.ChartAreas["Default"].AxisY2.Maximum = 800;

					// Set titles for Y axes
					Chart1.ChartAreas["Default"].AxisY.Title = "";
					Chart1.ChartAreas["Default"].AxisY2.Title = "";

					break;
					// The maximum take of weight.
				case "Max. Weight":
					// Set Y values
					Chart1.Series["Default"].Points[2].YValues[0] = 660;
					Chart1.Series["Default"].Points[1].YValues[0] = 875;
					Chart1.Series["Default"].Points[0].YValues[0] = 1235;

					// Set maximum values for Y axes.
					Chart1.ChartAreas["Default"].AxisY.Maximum = 1500;
					Chart1.ChartAreas["Default"].AxisY2.Maximum = 680;

					// Set titles for Y axes
					Chart1.ChartAreas["Default"].AxisY.Title = "In lb x 1000";
					Chart1.ChartAreas["Default"].AxisY2.Title = "In Tones";

					break;
					// The wing span
				case "Wing Span":
					// Set Y values
					Chart1.Series["Default"].Points[2].YValues[0] = 199;
					Chart1.Series["Default"].Points[1].YValues[0] = 211;
					Chart1.Series["Default"].Points[0].YValues[0] = 261;

					// Set maximum values for Y axes.
					Chart1.ChartAreas["Default"].AxisY.Maximum = 400;
					Chart1.ChartAreas["Default"].AxisY2.Maximum = 121.8;

					// Set titles for Y axes
					Chart1.ChartAreas["Default"].AxisY.Title = "In ft";
					Chart1.ChartAreas["Default"].AxisY2.Title = "In meters";

					break;
			}

		}


	}
}
