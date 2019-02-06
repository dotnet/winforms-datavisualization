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
	/// Summary description for LabelsOverlapping.
	/// </summary>
	public class SmartLabels : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkBoxPreventOverlap;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox AllowOutsidePlotArea;
		private System.Windows.Forms.ComboBox CalloutLineAnchorCap;
		private System.Windows.Forms.ComboBox CalloutLineAnchorColor;
		private System.Windows.Forms.ComboBox CalloutLineAnchorWidth;
		private System.Windows.Forms.ComboBox CalloutStyle;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox NumOfPoints;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox Aligned;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SmartLabels()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			FillData();

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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSampleComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Aligned = new System.Windows.Forms.CheckBox();
            this.NumOfPoints = new System.Windows.Forms.ComboBox();
            this.CalloutStyle = new System.Windows.Forms.ComboBox();
            this.CalloutLineAnchorWidth = new System.Windows.Forms.ComboBox();
            this.CalloutLineAnchorColor = new System.Windows.Forms.ComboBox();
            this.CalloutLineAnchorCap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AllowOutsidePlotArea = new System.Windows.Forms.ComboBox();
            this.checkBoxPreventOverlap = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 60);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "P0";
            series1.Legend = "Default";
            series1.MarkerSize = 6;
            series1.Name = "Default";
            series1.ShadowOffset = 1;
            series1.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 1;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 14);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 36);
            this.labelSampleComment.TabIndex = 0;
            this.labelSampleComment.Text = "This sample demonstrates how to use smart labels to avoid overlaps by repositioni" +
                "ng or hiding point labels.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Aligned);
            this.panel1.Controls.Add(this.NumOfPoints);
            this.panel1.Controls.Add(this.CalloutStyle);
            this.panel1.Controls.Add(this.CalloutLineAnchorWidth);
            this.panel1.Controls.Add(this.CalloutLineAnchorColor);
            this.panel1.Controls.Add(this.CalloutLineAnchorCap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AllowOutsidePlotArea);
            this.panel1.Controls.Add(this.checkBoxPreventOverlap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(424, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 292);
            this.panel1.TabIndex = 0;
            // 
            // Aligned
            // 
            this.Aligned.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Aligned.Location = new System.Drawing.Point(22, 36);
            this.Aligned.Name = "Aligned";
            this.Aligned.Size = new System.Drawing.Size(168, 24);
            this.Aligned.TabIndex = 1;
            this.Aligned.Text = "&Similar Point Values:";
            this.Aligned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Aligned.CheckedChanged += new System.EventHandler(this.Aligned_CheckedChanged);
            // 
            // NumOfPoints
            // 
            this.NumOfPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumOfPoints.Items.AddRange(new object[] {
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.NumOfPoints.Location = new System.Drawing.Point(176, 64);
            this.NumOfPoints.Name = "NumOfPoints";
            this.NumOfPoints.Size = new System.Drawing.Size(121, 22);
            this.NumOfPoints.TabIndex = 3;
            this.NumOfPoints.SelectedIndexChanged += new System.EventHandler(this.NumOfPoints_SelectedIndexChanged);
            // 
            // CalloutStyle
            // 
            this.CalloutStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CalloutStyle.Items.AddRange(new object[] {
            "None",
            "Box",
            "Underlined"});
            this.CalloutStyle.Location = new System.Drawing.Point(176, 200);
            this.CalloutStyle.Name = "CalloutStyle";
            this.CalloutStyle.Size = new System.Drawing.Size(121, 22);
            this.CalloutStyle.TabIndex = 13;
            this.CalloutStyle.SelectedIndexChanged += new System.EventHandler(this.CalloutStyle_SelectedIndexChanged);
            // 
            // CalloutLineAnchorWidth
            // 
            this.CalloutLineAnchorWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CalloutLineAnchorWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CalloutLineAnchorWidth.Location = new System.Drawing.Point(176, 176);
            this.CalloutLineAnchorWidth.Name = "CalloutLineAnchorWidth";
            this.CalloutLineAnchorWidth.Size = new System.Drawing.Size(121, 22);
            this.CalloutLineAnchorWidth.TabIndex = 11;
            this.CalloutLineAnchorWidth.SelectedIndexChanged += new System.EventHandler(this.CalloutLineAnchorWidth_SelectedIndexChanged);
            // 
            // CalloutLineAnchorColor
            // 
            this.CalloutLineAnchorColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CalloutLineAnchorColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Yellow"});
            this.CalloutLineAnchorColor.Location = new System.Drawing.Point(176, 152);
            this.CalloutLineAnchorColor.Name = "CalloutLineAnchorColor";
            this.CalloutLineAnchorColor.Size = new System.Drawing.Size(121, 22);
            this.CalloutLineAnchorColor.TabIndex = 9;
            this.CalloutLineAnchorColor.SelectedIndexChanged += new System.EventHandler(this.CalloutLineAnchorColor_SelectedIndexChanged);
            // 
            // CalloutLineAnchorCap
            // 
            this.CalloutLineAnchorCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CalloutLineAnchorCap.Items.AddRange(new object[] {
            "None",
            "Arrow",
            "Diamond",
            "Square",
            "Round"});
            this.CalloutLineAnchorCap.Location = new System.Drawing.Point(176, 128);
            this.CalloutLineAnchorCap.Name = "CalloutLineAnchorCap";
            this.CalloutLineAnchorCap.Size = new System.Drawing.Size(121, 22);
            this.CalloutLineAnchorCap.TabIndex = 7;
            this.CalloutLineAnchorCap.SelectedIndexChanged += new System.EventHandler(this.CalloutLineAnchorCap_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Callout Line Anchor &Width:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Callout Line Anchor C&olor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Callout Line Anchor &Cap:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AllowOutsidePlotArea
            // 
            this.AllowOutsidePlotArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AllowOutsidePlotArea.Items.AddRange(new object[] {
            "No",
            "Yes",
            "Partial"});
            this.AllowOutsidePlotArea.Location = new System.Drawing.Point(176, 96);
            this.AllowOutsidePlotArea.Name = "AllowOutsidePlotArea";
            this.AllowOutsidePlotArea.Size = new System.Drawing.Size(121, 22);
            this.AllowOutsidePlotArea.TabIndex = 5;
            this.AllowOutsidePlotArea.SelectedIndexChanged += new System.EventHandler(this.AllowOutsidePlotArea_SelectedIndexChanged);
            // 
            // checkBoxPreventOverlap
            // 
            this.checkBoxPreventOverlap.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxPreventOverlap.Location = new System.Drawing.Point(18, 8);
            this.checkBoxPreventOverlap.Name = "checkBoxPreventOverlap";
            this.checkBoxPreventOverlap.Size = new System.Drawing.Size(172, 24);
            this.checkBoxPreventOverlap.TabIndex = 0;
            this.checkBoxPreventOverlap.Text = "&Smart Labels:";
            this.checkBoxPreventOverlap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxPreventOverlap.CheckedChanged += new System.EventHandler(this.checkBoxPreventOverlap_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Allow &Outside Plot Area:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Callout St&yle:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "&Number of Points:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SmartLabels
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Smart Labels";
            this.Size = new System.Drawing.Size(728, 376);
            this.Load += new System.EventHandler(this.SmartLabels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void checkBoxPreventOverlap_CheckedChanged(object sender, System.EventArgs e)
		{
			SetSmartLabels();
		}

		private void chart1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}

		/// <summary>
		/// Fill Data Points
		/// </summary>
		private void FillData()
		{
			// Remove all data points from collection.
			chart1.Series[0].Points.Clear();

			// Set initial number of data points.
			int numOfPoints = 50;

			// Get out from this method if all combo boxes 
			// are not initialized.
			if( this.NumOfPoints.Text != "" )
			{
				numOfPoints = int.Parse( this.NumOfPoints.Text );
			}
			
			// Initialize random nubers.
			Random rand = new Random( 2 );

			// Data points loop
			for( int index = 0; index <= numOfPoints; index++ )
			{
				// Filling algorithm for not aligned data points
				if( !this.Aligned.Checked )
				{
					chart1.Series[0].Points.Add( new DataPoint( 0, rand.NextDouble() * 50 ) );
				}
				// Filling algorithm for aligned data points
				else
				{
					if( index == 0 )
					{
						chart1.Series[0].Points.Add( new DataPoint( 0, rand.NextDouble() * 50 ) );
					}
					else
					{
						chart1.Series[0].Points.Add( new DataPoint( 0, chart1.Series[0].Points[index-1].YValues[0] + rand.NextDouble() * 4 - 2 ) );
					}
				}
			}
		}

		/// <summary>
		/// Initialize combo boxes
		/// </summary>
		private void SmartLabels_Load(object sender, System.EventArgs e)
		{
			this.AllowOutsidePlotArea.SelectedIndex = 0;
			this.CalloutLineAnchorCap.SelectedIndex = 0;
			this.CalloutLineAnchorColor.SelectedIndex = 0;
			this.CalloutLineAnchorWidth.SelectedIndex = 0;
			this.CalloutStyle.SelectedIndex = 0;
			this.NumOfPoints.SelectedIndex = 1;
		}

		/// <summary>
		/// Set values from combo boxes to the chart 
		/// smart labels properties.
		/// </summary>
		private void SetSmartLabels()
		{
			// Get out from this method if all combo boxes 
			// are not initialized.
			if( this.CalloutStyle.Text == "" )
			{
				return;
			}

			// Enable or disable Smart label combo boxes
			if( this.checkBoxPreventOverlap.Checked )
			{
				this.AllowOutsidePlotArea.Enabled = true;
                this.CalloutLineAnchorCap.Enabled = true;
				this.CalloutLineAnchorColor.Enabled = true;
				this.CalloutLineAnchorWidth.Enabled = true;
				this.CalloutStyle.Enabled = true;
			}
			else
			{
				this.AllowOutsidePlotArea.Enabled = false;
                this.CalloutLineAnchorCap.Enabled = false;
				this.CalloutLineAnchorColor.Enabled = false;
				this.CalloutLineAnchorWidth.Enabled = false;
				this.CalloutStyle.Enabled = false;
			}

			// Set values from combo boxes to the chart 
			// smart labels properties.
			chart1.Series["Default"].SmartLabelStyle.Enabled = this.checkBoxPreventOverlap.Checked;
			chart1.Series["Default"].SmartLabelStyle.AllowOutsidePlotArea = (LabelOutsidePlotAreaStyle) Enum.Parse( typeof(LabelOutsidePlotAreaStyle), this.AllowOutsidePlotArea.Text, true );
            chart1.Series["Default"].SmartLabelStyle.CalloutLineAnchorCapStyle = (LineAnchorCapStyle)Enum.Parse(typeof(LineAnchorCapStyle), this.CalloutLineAnchorCap.Text, true);
			chart1.Series["Default"].SmartLabelStyle.CalloutLineColor = Color.FromName( this.CalloutLineAnchorColor.Text );
			chart1.Series["Default"].SmartLabelStyle.CalloutLineWidth = int.Parse( this.CalloutLineAnchorWidth.Text );
			chart1.Series["Default"].SmartLabelStyle.CalloutStyle = (LabelCalloutStyle) Enum.Parse( typeof(LabelCalloutStyle), this.CalloutStyle.Text, true );
		
		}

		private void AllowOutsidePlotArea_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetSmartLabels();
		}

		private void CalloutLineAnchorCap_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetSmartLabels();
		}

		private void CalloutLineAnchorColor_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetSmartLabels();
		}

		private void CalloutLineAnchorWidth_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetSmartLabels();
		}

		private void CalloutStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetSmartLabels();
		}

		private void NumOfPoints_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			FillData();
			SetSmartLabels();
		}

		private void Aligned_CheckedChanged(object sender, System.EventArgs e)
		{
			FillData();
			SetSmartLabels();
		}
	}
}
