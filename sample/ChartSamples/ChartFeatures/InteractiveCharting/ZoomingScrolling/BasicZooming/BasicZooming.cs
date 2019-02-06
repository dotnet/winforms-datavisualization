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
	/// Summary description for BasicZooming.
	/// </summary>
	public class BasicZooming : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonResetZoom;
		private System.Windows.Forms.CheckBox checkBoxZoomUI;
		private System.Windows.Forms.ComboBox comboBoxFrom;
		private System.Windows.Forms.ComboBox comboBoxTo;
		private System.Windows.Forms.CheckBox checkBoxShowMargin;
		private System.Windows.Forms.ComboBox comboBoxAxis;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBoxInside;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BasicZooming()
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonResetZoom = new System.Windows.Forms.Button();
            this.labelSampleComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxInside = new System.Windows.Forms.CheckBox();
            this.comboBoxAxis = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxShowMargin = new System.Windows.Forms.CheckBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.checkBoxZoomUI = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
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
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.ScrollBar.Size = 12;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisY.ScrollBar.Size = 12;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
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
            this.chart1.Location = new System.Drawing.Point(16, 51);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Default";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(412, 296);
            this.chart1.TabIndex = 1;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // buttonResetZoom
            // 
            this.buttonResetZoom.BackColor = System.Drawing.SystemColors.Control;
            this.buttonResetZoom.Location = new System.Drawing.Point(128, 208);
            this.buttonResetZoom.Name = "buttonResetZoom";
            this.buttonResetZoom.Size = new System.Drawing.Size(112, 23);
            this.buttonResetZoom.TabIndex = 8;
            this.buttonResetZoom.Text = "&Reset Zoom";
            this.buttonResetZoom.UseVisualStyleBackColor = false;
            this.buttonResetZoom.Click += new System.EventHandler(this.buttonResetZoom_Click);
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleComment.Location = new System.Drawing.Point(16, 8);
            this.labelSampleComment.Name = "labelSampleComment";
            this.labelSampleComment.Size = new System.Drawing.Size(702, 37);
            this.labelSampleComment.TabIndex = 0;
            this.labelSampleComment.Text = "This sample demonstrates how to zoom along the X and Y axis.";
            this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxInside);
            this.panel1.Controls.Add(this.comboBoxAxis);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBoxShowMargin);
            this.panel1.Controls.Add(this.comboBoxTo);
            this.panel1.Controls.Add(this.comboBoxFrom);
            this.panel1.Controls.Add(this.checkBoxZoomUI);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonResetZoom);
            this.panel1.Location = new System.Drawing.Point(432, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // checkBoxInside
            // 
            this.checkBoxInside.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxInside.Checked = true;
            this.checkBoxInside.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInside.Location = new System.Drawing.Point(14, 104);
            this.checkBoxInside.Name = "checkBoxInside";
            this.checkBoxInside.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxInside.Size = new System.Drawing.Size(168, 16);
            this.checkBoxInside.TabIndex = 9;
            this.checkBoxInside.Text = "Scrollbars &Inside:";
            this.checkBoxInside.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxInside.CheckedChanged += new System.EventHandler(this.checkBoxInside_CheckedChanged);
            // 
            // comboBoxAxis
            // 
            this.comboBoxAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAxis.Items.AddRange(new object[] {
            "X",
            "Y",
            "X and Y"});
            this.comboBoxAxis.Location = new System.Drawing.Point(168, 8);
            this.comboBoxAxis.Name = "comboBoxAxis";
            this.comboBoxAxis.Size = new System.Drawing.Size(112, 22);
            this.comboBoxAxis.TabIndex = 1;
            this.comboBoxAxis.SelectedIndexChanged += new System.EventHandler(this.comboBoxAxis_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Axis Used:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxShowMargin
            // 
            this.checkBoxShowMargin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowMargin.Checked = true;
            this.checkBoxShowMargin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowMargin.Location = new System.Drawing.Point(14, 136);
            this.checkBoxShowMargin.Name = "checkBoxShowMargin";
            this.checkBoxShowMargin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxShowMargin.Size = new System.Drawing.Size(168, 16);
            this.checkBoxShowMargin.TabIndex = 6;
            this.checkBoxShowMargin.Text = "Show Axis &Margin:";
            this.checkBoxShowMargin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowMargin.CheckedChanged += new System.EventHandler(this.checkBoxShowMargin_CheckedChanged);
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTo.Items.AddRange(new object[] {
            "35",
            "40",
            "50"});
            this.comboBoxTo.Location = new System.Drawing.Point(168, 72);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(112, 22);
            this.comboBoxTo.TabIndex = 5;
            this.comboBoxTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrom_SelectedIndexChanged);
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "10",
            "20",
            "30"});
            this.comboBoxFrom.Location = new System.Drawing.Point(168, 40);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(112, 22);
            this.comboBoxFrom.TabIndex = 3;
            this.comboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrom_SelectedIndexChanged);
            // 
            // checkBoxZoomUI
            // 
            this.checkBoxZoomUI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxZoomUI.Checked = true;
            this.checkBoxZoomUI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxZoomUI.Location = new System.Drawing.Point(14, 168);
            this.checkBoxZoomUI.Name = "checkBoxZoomUI";
            this.checkBoxZoomUI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxZoomUI.Size = new System.Drawing.Size(168, 16);
            this.checkBoxZoomUI.TabIndex = 7;
            this.checkBoxZoomUI.Text = "&Enable Zooming UI:";
            this.checkBoxZoomUI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxZoomUI.CheckedChanged += new System.EventHandler(this.checkBoxZoomUI_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(76, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zoom &To:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoom &From:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BasicZooming
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BasicZooming";
            this.Size = new System.Drawing.Size(728, 384);
            this.Load += new System.EventHandler(this.BasicZooming_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void BasicZooming_Load(object sender, System.EventArgs e)
		{
			comboBoxAxis.SelectedIndex = 0;

			// Enable range selection and zooming UI by default
			chart1.ChartAreas["Default"].CursorX.IsUserEnabled = true;
			chart1.ChartAreas["Default"].CursorX.IsUserSelectionEnabled = true;
			chart1.ChartAreas["Default"].AxisX.ScaleView.Zoomable = true;

			// Fill chart with random data
			Random	random = new Random();
			for(int pointIndex = 0; pointIndex < 49; pointIndex++)
			{
				chart1.Series["Default"].Points.AddY(random.Next(0, 100));
			}
		}

		private void checkBoxZoomUI_CheckedChanged(object sender, System.EventArgs e)
		{
			// Reset to default
			chart1.ChartAreas["Default"].CursorX.IsUserEnabled = false;
			chart1.ChartAreas["Default"].CursorX.IsUserSelectionEnabled = false;
			chart1.ChartAreas["Default"].AxisX.ScaleView.Zoomable = false;
			chart1.ChartAreas["Default"].CursorY.IsUserEnabled = false;
			chart1.ChartAreas["Default"].CursorY.IsUserSelectionEnabled = false;
			chart1.ChartAreas["Default"].AxisY.ScaleView.Zoomable = false;
		
			// Enable range selection and zooming UI
			if(comboBoxAxis.Text == "X" || comboBoxAxis.Text == "X and Y")
			{
				chart1.ChartAreas["Default"].CursorX.IsUserEnabled = checkBoxZoomUI.Checked;
				chart1.ChartAreas["Default"].CursorX.IsUserSelectionEnabled = checkBoxZoomUI.Checked;
				chart1.ChartAreas["Default"].AxisX.ScaleView.Zoomable = checkBoxZoomUI.Checked;
			}

			if(comboBoxAxis.Text == "Y" || comboBoxAxis.Text == "X and Y")
			{
				chart1.ChartAreas["Default"].CursorY.IsUserEnabled = checkBoxZoomUI.Checked;
				chart1.ChartAreas["Default"].CursorY.IsUserSelectionEnabled = checkBoxZoomUI.Checked;
				chart1.ChartAreas["Default"].AxisY.ScaleView.Zoomable = checkBoxZoomUI.Checked;
			}
		}

		private void buttonResetZoom_Click(object sender, System.EventArgs e)
		{
			if(comboBoxAxis.Text == "X" || comboBoxAxis.Text == "X and Y")
			{
				// Rese X axis zooming
				chart1.ChartAreas["Default"].AxisX.ScaleView.ZoomReset(0);
			}
			if(comboBoxAxis.Text == "Y" || comboBoxAxis.Text == "X and Y")
			{
				// Rese Y axis zooming
				chart1.ChartAreas["Default"].AxisY.ScaleView.ZoomReset(0);
			}
		}

		private void comboBoxFrom_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(comboBoxFrom.Text != String.Empty)
			{
				if(comboBoxTo.Text == String.Empty)
				{
					comboBoxTo.SelectedIndex = 0;
				}

				// Zoom into the axis
				if(comboBoxAxis.Text == "X" || comboBoxAxis.Text == "X and Y")
				{
					chart1.ChartAreas["Default"].AxisX.ScaleView.Zoom(double.Parse(comboBoxFrom.Text), double.Parse(comboBoxTo.Text));
				}
				if(comboBoxAxis.Text == "Y" || comboBoxAxis.Text == "X and Y")
				{
					chart1.ChartAreas["Default"].AxisY.ScaleView.Zoom(double.Parse(comboBoxFrom.Text), double.Parse(comboBoxTo.Text));
				}
			}
		}

		private void checkBoxShowMargin_CheckedChanged(object sender, System.EventArgs e)
		{
			chart1.ChartAreas["Default"].AxisX.IsMarginVisible = checkBoxShowMargin.Checked;
			chart1.ChartAreas["Default"].AxisY.IsMarginVisible = checkBoxShowMargin.Checked;
		}

		private void comboBoxAxis_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			comboBoxFrom_SelectedIndexChanged(chart1, null);
			checkBoxShowMargin_CheckedChanged(chart1, null);
			checkBoxZoomUI_CheckedChanged(chart1, null);
			checkBoxInside_CheckedChanged(chart1, null);
		}

		private void checkBoxInside_CheckedChanged(object sender, System.EventArgs e)
		{
			chart1.ChartAreas["Default"].AxisX.ScrollBar.IsPositionedInside = checkBoxInside.Checked;
			chart1.ChartAreas["Default"].AxisY.ScrollBar.IsPositionedInside = checkBoxInside.Checked;
		}

		private void chart1_Click(object sender, System.EventArgs e)
		{
		
		}

	}
}
