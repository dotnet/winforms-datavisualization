# region Used Namespaces
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
#endregion

namespace ChartSamples
{
	/// <summary>
	/// Summary description for AligningChartingAreas.
	/// </summary>
	public class AligningChartingAreas : System.Windows.Forms.UserControl
    {
        # region Fields
        private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox AlignmentCombo;
		private System.Windows.Forms.CheckBox checkBoxShowChartArea1;
		private System.Windows.Forms.CheckBox checkBoxShowChartArea2;
		private System.Windows.Forms.Label label1;
        
        /// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        #endregion

        # region Constructor

        public AligningChartingAreas()
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

        #endregion

        #region Component Designer generated code
        /// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7);
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 4);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxShowChartArea2 = new System.Windows.Forms.CheckBox();
            this.checkBoxShowChartArea1 = new System.Windows.Forms.CheckBox();
            this.AlignmentCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 43);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample shows how to align multiple chart areas when more than one chart area" +
                " is visible.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxShowChartArea2);
            this.panel1.Controls.Add(this.checkBoxShowChartArea1);
            this.panel1.Controls.Add(this.AlignmentCombo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(432, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // checkBoxShowChartArea2
            // 
            this.checkBoxShowChartArea2.Checked = true;
            this.checkBoxShowChartArea2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowChartArea2.Location = new System.Drawing.Point(6, 47);
            this.checkBoxShowChartArea2.Name = "checkBoxShowChartArea2";
            this.checkBoxShowChartArea2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxShowChartArea2.Size = new System.Drawing.Size(160, 24);
            this.checkBoxShowChartArea2.TabIndex = 9;
            this.checkBoxShowChartArea2.Text = "Show Chart Area 2";
            this.checkBoxShowChartArea2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxShowChartArea1
            // 
            this.checkBoxShowChartArea1.Checked = true;
            this.checkBoxShowChartArea1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowChartArea1.Location = new System.Drawing.Point(6, 15);
            this.checkBoxShowChartArea1.Name = "checkBoxShowChartArea1";
            this.checkBoxShowChartArea1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxShowChartArea1.Size = new System.Drawing.Size(160, 24);
            this.checkBoxShowChartArea1.TabIndex = 8;
            this.checkBoxShowChartArea1.Text = "Show Chart Area 1";
            this.checkBoxShowChartArea1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AlignmentCombo
            // 
            this.AlignmentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlignmentCombo.Items.AddRange(new object[] {
            "Horizontally",
            "Vertically"});
            this.AlignmentCombo.Location = new System.Drawing.Point(150, 80);
            this.AlignmentCombo.Name = "AlignmentCombo";
            this.AlignmentCombo.Size = new System.Drawing.Size(136, 22);
            this.AlignmentCombo.TabIndex = 1;
            this.AlignmentCombo.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(64, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Shadow Offset:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(64, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Border Style:";
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
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(95, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "&Align:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            this.Chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.Chart1.BorderlineWidth = 2;
            this.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea3.Area3DStyle.IsClustered = true;
            chartArea3.Area3DStyle.Perspective = 10;
            chartArea3.Area3DStyle.IsRightAngleAxes = false;
            chartArea3.Area3DStyle.WallWidth = 0;
            chartArea3.Area3DStyle.Inclination = 15;
            chartArea3.Area3DStyle.Rotation = 10;
            chartArea3.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisX.LabelStyle.Format = "dd MMM";
            chartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisY.LineWidth = 2;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea3.BackSecondaryColor = System.Drawing.Color.White;
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.Name = "Default";
            chartArea3.ShadowColor = System.Drawing.Color.Transparent;
            chartArea4.AlignWithChartArea = "Default";
            chartArea4.Area3DStyle.IsClustered = true;
            chartArea4.Area3DStyle.Perspective = 10;
            chartArea4.Area3DStyle.IsRightAngleAxes = false;
            chartArea4.Area3DStyle.WallWidth = 0;
            chartArea4.Area3DStyle.Inclination = 15;
            chartArea4.Area3DStyle.Rotation = 10;
            chartArea4.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea4.AxisX.LabelStyle.Format = "dd MMM";
            chartArea4.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea4.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.AxisY.LineWidth = 2;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.AxisY2.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea4.AxisY2.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea4.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.AxisY2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea4.BackSecondaryColor = System.Drawing.Color.White;
            chartArea4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.Name = "Chart Area 2";
            chartArea4.ShadowColor = System.Drawing.Color.Transparent;
            this.Chart1.ChartAreas.Add(chartArea3);
            this.Chart1.ChartAreas.Add(chartArea4);
            legend2.IsTextAutoFit = false;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Enabled = false;
            legend2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend2.Name = "Default";
            this.Chart1.Legends.Add(legend2);
            this.Chart1.Location = new System.Drawing.Point(14, 46);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Name = "Series1";
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series4.BorderWidth = 2;
            series4.ChartArea = "Chart Area 2";
            series4.ChartType = SeriesChartType.Spline;
            series4.Name = "Series2";
            series4.Points.Add(dataPoint16);
            series4.Points.Add(dataPoint17);
            series4.Points.Add(dataPoint18);
            series4.Points.Add(dataPoint19);
            series4.Points.Add(dataPoint20);
            series4.ShadowOffset = 1;
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.Chart1.Series.Add(series3);
            this.Chart1.Series.Add(series4);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "In order to horizontally align the chart areas, the position of both chart areas " +
                "must be set. In addition, by setting the AlignmentOrientation property, we are able " +
                "to align the inner plotting areas.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AligningChartingAreas
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AligningChartingAreas";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.Alignment_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        # region Event Handler

        private void Alignment_Load(object sender, System.EventArgs e)
        {
            AlignmentCombo.SelectedIndex = 0;

            Alignment();
        }

        private void Combo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Alignment();
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
        }

        #endregion

        # region Methods

        private void Alignment()
        {
            if (AlignmentCombo.SelectedItem == null)
                return;

            // Vertical Alignment
            if (AlignmentCombo.GetItemText(AlignmentCombo.SelectedItem) == "Vertically")
            {
                // Set the chart area alignmnet.  This will cause the axes to align vertically.
                Chart1.ChartAreas["Chart Area 2"].AlignmentOrientation = AreaAlignmentOrientations.Vertical;

                // Disable X Axis Labels for the first chart area.
                Chart1.ChartAreas["Default"].AxisX.LabelStyle.Enabled = false;
                Chart1.ChartAreas["Default"].AxisX.MajorTickMark.Enabled = false;

                // Enable Y axis for the second chart area
                Chart1.ChartAreas["Chart Area 2"].AxisY.LabelStyle.Enabled = true;
                Chart1.ChartAreas["Chart Area 2"].AxisY.MajorTickMark.Enabled = true;

                // Disable Y axis for the second chart area
                Chart1.ChartAreas["Chart Area 2"].AxisY.Enabled = AxisEnabled.True;

                // Enable Y2 axis for the second chart area
                Chart1.ChartAreas["Chart Area 2"].AxisY2.Enabled = AxisEnabled.False;

                // Disable End labels for Y axes.
                Chart1.ChartAreas["Default"].AxisY.LabelStyle.IsEndLabelVisible = false;
                Chart1.ChartAreas["Chart Area 2"].AxisY.LabelStyle.IsEndLabelVisible = false;

                // Set the chart area position for the first chart area.
                Chart1.ChartAreas["Default"].Position.X = 5;
                Chart1.ChartAreas["Default"].Position.Y = 10;
                Chart1.ChartAreas["Default"].Position.Width = 85;
                Chart1.ChartAreas["Default"].Position.Height = 40;

                // Set the chart area position for the second chart area.
                Chart1.ChartAreas["Chart Area 2"].Position.X = 5;
                Chart1.ChartAreas["Chart Area 2"].Position.Y = 50;
                Chart1.ChartAreas["Chart Area 2"].Position.Width = 85;
                Chart1.ChartAreas["Chart Area 2"].Position.Height = 40;
            }
            // Horizontal Alignment
            else
            {
                // Set the chart area alignmnet.  This will cause the axes to align horizontally.
                Chart1.ChartAreas["Chart Area 2"].AlignmentOrientation = AreaAlignmentOrientations.Horizontal;

                // Disable Y axis for the second chart area
                Chart1.ChartAreas["Chart Area 2"].AxisY.LabelStyle.Enabled = false;
                Chart1.ChartAreas["Chart Area 2"].AxisY.MajorTickMark.Enabled = false;


                // Disable X Axis Labels for the first chart area.
                Chart1.ChartAreas["Default"].AxisX.LabelStyle.Enabled = true;

                // Enable Y2 axis for the second chart area
                Chart1.ChartAreas["Chart Area 2"].AxisY2.Enabled = AxisEnabled.True;

                // Set axis maximum for Y axes 
                Chart1.ChartAreas["Default"].AxisY.Maximum = 10;
                Chart1.ChartAreas["Chart Area 2"].AxisY.Maximum = 10;

                // Disable end labels for X axes
                Chart1.ChartAreas["Default"].AxisX.LabelStyle.IsEndLabelVisible = false;
                Chart1.ChartAreas["Default"].AxisY.LabelStyle.IsEndLabelVisible = true;
                Chart1.ChartAreas["Chart Area 2"].AxisX.LabelStyle.IsEndLabelVisible = false;

                // Set the chart area position for the first chart area.
                Chart1.ChartAreas["Default"].Position.X = 5;
                Chart1.ChartAreas["Default"].Position.Y = 10;
                Chart1.ChartAreas["Default"].Position.Width = 45;
                Chart1.ChartAreas["Default"].Position.Height = 80;

                // Set the chart area position for the second chart area.
                Chart1.ChartAreas["Chart Area 2"].Position.X = 50;
                Chart1.ChartAreas["Chart Area 2"].Position.Y = 10;
                Chart1.ChartAreas["Chart Area 2"].Position.Width = 45;
                Chart1.ChartAreas["Chart Area 2"].Position.Height = 80;
            }
        }

        private void UpdateChartSettings() 
		{
			// If both chart areas are specified, align the chart areas
			if ((checkBoxShowChartArea2.Checked) && (checkBoxShowChartArea1.Checked))
			{
				this.AlignmentCombo.Enabled = true;
				Chart1.ChartAreas["Default"].Visible = true;
				Chart1.ChartAreas["Chart Area 2"].Visible = true;
				this.Alignment();
			}

			// If Chart Area 1 checked, Chart Area 2 unchecked
			else if ((!checkBoxShowChartArea2.Checked) &&(checkBoxShowChartArea1.Checked))
			{
				this.AlignmentCombo.Enabled = false;

				Chart1.ChartAreas["Chart Area 2"].Visible = false;
				
				Chart1.ChartAreas["Default"].Visible = true;
				Chart1.ChartAreas["Default"].Position.Auto = true;
				Chart1.ChartAreas["Default"].InnerPlotPosition.Auto = true;

				// Enable X Axis Labels for the first chart area.
				Chart1.ChartAreas["Default"].AxisX.LabelStyle.Enabled = true;
				Chart1.ChartAreas["Default"].AxisX.MajorTickMark.Enabled = true;
			}

			// If Chart Area 1 unchecked, Chart Area 2 checked
			else if ((checkBoxShowChartArea2.Checked) &&(!checkBoxShowChartArea1.Checked))
			{
				this.AlignmentCombo.Enabled = false;

				Chart1.ChartAreas["Default"].Visible = false;

				Chart1.ChartAreas["Chart Area 2"].Visible = true;
				Chart1.ChartAreas["Chart Area 2"].Position.Auto = true;
				Chart1.ChartAreas["Chart Area 2"].InnerPlotPosition.Auto = true;
			}

			// If both chart areas unchecked
			else if ((!checkBoxShowChartArea2.Checked) &&(!checkBoxShowChartArea1.Checked))
			{
				this.AlignmentCombo.Enabled = false;

				Chart1.ChartAreas["Default"].Visible = false;
				Chart1.ChartAreas["Chart Area 2"].Visible = false;
			}
        }

        #endregion
    }
}
