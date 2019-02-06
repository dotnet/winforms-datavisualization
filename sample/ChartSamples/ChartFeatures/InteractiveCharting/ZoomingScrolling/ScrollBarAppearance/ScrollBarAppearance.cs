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
	/// Summary description for ScrollBarAppearance.
	/// </summary>
	public class ScrollBarAppearance : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxSize;
		private System.Windows.Forms.ComboBox comboBoxBackColor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxButtonsColor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxLineColor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBoxResetButton;
		private System.Windows.Forms.CheckBox checkBoxSmallScrollButton;
		private System.Windows.Forms.CheckBox checkBoxInside;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ScrollBarAppearance()
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
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.labelSampleComment = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkBoxInside = new System.Windows.Forms.CheckBox();
			this.comboBoxLineColor = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxButtonsColor = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxBackColor = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBoxSmallScrollButton = new System.Windows.Forms.CheckBox();
			this.checkBoxResetButton = new System.Windows.Forms.CheckBox();
			this.comboBoxSize = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.chart1.BackSecondaryColor = System.Drawing.Color.White;
			this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			this.chart1.BorderlineWidth = 2;
			this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.IsMarginVisible = false;
			chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
			chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BackColor = System.Drawing.Color.Gainsboro;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea1.CursorX.SelectionColor = System.Drawing.Color.LightBlue;
			chartArea1.CursorX.IsUserEnabled = true;
			chartArea1.CursorX.IsUserSelectionEnabled = true;
			chartArea1.Name = "Default";
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Enabled = false;
			legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(16, 48);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartType = SeriesChartType.Area;
			series1.Name = "Default";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(412, 296);
			this.chart1.TabIndex = 1;
			title1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
			title1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(32)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			title1.ShadowOffset = 3;
			title1.Text = "ScrollBar Appearance";
			this.chart1.Titles.Add(title1);
			this.chart1.Click += new System.EventHandler(this.chart1_Click);
			// 
			// labelSampleComment
			// 
			this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelSampleComment.Location = new System.Drawing.Point(16, 8);
			this.labelSampleComment.Name = "labelSampleComment";
			this.labelSampleComment.Size = new System.Drawing.Size(702, 34);
			this.labelSampleComment.TabIndex = 0;
			this.labelSampleComment.Text = "This sample demonstrates how to set the appearance of a scrollbar.";
			this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.checkBoxInside,
																				 this.comboBoxLineColor,
																				 this.label4,
																				 this.comboBoxButtonsColor,
																				 this.label3,
																				 this.comboBoxBackColor,
																				 this.label2,
																				 this.checkBoxSmallScrollButton,
																				 this.checkBoxResetButton,
																				 this.comboBoxSize,
																				 this.label1});
			this.panel1.Location = new System.Drawing.Point(432, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 288);
			this.panel1.TabIndex = 0;
			// 
			// checkBoxInside
			// 
			this.checkBoxInside.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxInside.Checked = true;
			this.checkBoxInside.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxInside.Location = new System.Drawing.Point(-10, 104);
			this.checkBoxInside.Name = "checkBoxInside";
			this.checkBoxInside.Size = new System.Drawing.Size(192, 24);
			this.checkBoxInside.TabIndex = 4;
			this.checkBoxInside.Text = "Scrollbars &Inside:";
			this.checkBoxInside.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxInside.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// comboBoxLineColor
			// 
			this.comboBoxLineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLineColor.Items.AddRange(new object[] {
																   "Default"});
			this.comboBoxLineColor.Location = new System.Drawing.Point(168, 200);
			this.comboBoxLineColor.Name = "comboBoxLineColor";
			this.comboBoxLineColor.TabIndex = 10;
			this.comboBoxLineColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxBackColor_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(52, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "&Line Color:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxButtonsColor
			// 
			this.comboBoxButtonsColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxButtonsColor.Items.AddRange(new object[] {
																	  "Default"});
			this.comboBoxButtonsColor.Location = new System.Drawing.Point(168, 168);
			this.comboBoxButtonsColor.Name = "comboBoxButtonsColor";
			this.comboBoxButtonsColor.TabIndex = 8;
			this.comboBoxButtonsColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxBackColor_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(52, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Buttons &Color:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxBackColor
			// 
			this.comboBoxBackColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBackColor.Items.AddRange(new object[] {
																   "Default"});
			this.comboBoxBackColor.Location = new System.Drawing.Point(168, 136);
			this.comboBoxBackColor.Name = "comboBoxBackColor";
			this.comboBoxBackColor.TabIndex = 6;
			this.comboBoxBackColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxBackColor_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(60, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "&Back Color:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// checkBoxSmallScrollButton
			// 
			this.checkBoxSmallScrollButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxSmallScrollButton.Checked = true;
			this.checkBoxSmallScrollButton.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSmallScrollButton.Location = new System.Drawing.Point(-10, 72);
			this.checkBoxSmallScrollButton.Name = "checkBoxSmallScrollButton";
			this.checkBoxSmallScrollButton.Size = new System.Drawing.Size(192, 24);
			this.checkBoxSmallScrollButton.TabIndex = 3;
			this.checkBoxSmallScrollButton.Text = "Show S&mallScroll Button:";
			this.checkBoxSmallScrollButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxSmallScrollButton.CheckedChanged += new System.EventHandler(this.checkBoxResetButton_CheckedChanged);
			// 
			// checkBoxResetButton
			// 
			this.checkBoxResetButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxResetButton.Checked = true;
			this.checkBoxResetButton.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxResetButton.Location = new System.Drawing.Point(-10, 40);
			this.checkBoxResetButton.Name = "checkBoxResetButton";
			this.checkBoxResetButton.Size = new System.Drawing.Size(192, 24);
			this.checkBoxResetButton.TabIndex = 2;
			this.checkBoxResetButton.Text = "Show &Reset Button:";
			this.checkBoxResetButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxResetButton.CheckedChanged += new System.EventHandler(this.checkBoxResetButton_CheckedChanged);
			// 
			// comboBoxSize
			// 
			this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSize.Items.AddRange(new object[] {
															  "5",
															  "10",
															  "15",
															  "20"});
			this.comboBoxSize.Location = new System.Drawing.Point(168, 8);
			this.comboBoxSize.Name = "comboBoxSize";
			this.comboBoxSize.TabIndex = 1;
			this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(85, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Size:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ScrollBarAppearance
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.labelSampleComment,
																		  this.chart1});
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "ScrollBarAppearance";
			this.Size = new System.Drawing.Size(728, 360);
			this.Load += new System.EventHandler(this.ZoomingExtents_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ZoomingExtents_Load(object sender, System.EventArgs e)
		{
			// Fill combo boxes with known colors
			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				this.comboBoxBackColor.Items.Add(colorName);
				this.comboBoxButtonsColor.Items.Add(colorName);
				this.comboBoxLineColor.Items.Add(colorName);
			}
			this.comboBoxSize.SelectedIndex = 1;
			this.comboBoxBackColor.SelectedIndex = 0;
			this.comboBoxButtonsColor.SelectedIndex = 0;
			this.comboBoxLineColor.SelectedIndex = 0;


			// Set original view
			chart1.ChartAreas["Default"].AxisX.ScaleView.Position = 10;
			chart1.ChartAreas["Default"].AxisX.ScaleView.Size = 20;

			// Fill chart with random data
			Random		random = new Random();
			for(int pointIndex = 0; pointIndex < 49; pointIndex++)
			{
				chart1.Series["Default"].Points.AddY(random.Next(0, 100));
			}
		}

		private void comboBoxBackColor_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void checkBoxResetButton_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxSize_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void UpdateChartSettings()
		{
			// Set scrollbar size
			if(comboBoxSize.Text != String.Empty)
			{
				chart1.ChartAreas["Default"].AxisX.ScrollBar.Size = int.Parse(comboBoxSize.Text);
			}

			// Do not show buttons with size 5
			checkBoxResetButton.Enabled = true;
			checkBoxSmallScrollButton.Enabled = true;
			if(chart1.ChartAreas["Default"].AxisX.ScrollBar.Size == 5)
			{
				checkBoxResetButton.Checked = false;
				checkBoxSmallScrollButton.Checked = false;
				checkBoxResetButton.Enabled = false;
				checkBoxSmallScrollButton.Enabled = false;
			}

			// Position of Scrollbars
			chart1.ChartAreas["Default"].AxisX.ScrollBar.IsPositionedInside = checkBoxInside.Checked;

			// Set scrollbar buttons
			chart1.ChartAreas["Default"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.None;
			if(checkBoxResetButton.Checked && checkBoxSmallScrollButton.Checked)
			{
                chart1.ChartAreas["Default"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
			}
			else if(checkBoxResetButton.Checked)
			{
                chart1.ChartAreas["Default"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.ResetZoom;
			}
			else if(checkBoxSmallScrollButton.Checked)
			{
                chart1.ChartAreas["Default"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
			}

			// Set scrollbar colors
			chart1.ChartAreas["Default"].AxisX.ScrollBar.BackColor = Color.White;
			chart1.ChartAreas["Default"].AxisX.ScrollBar.ButtonColor = Color.FromArgb(224, 224, 224);
			chart1.ChartAreas["Default"].AxisX.ScrollBar.LineColor = Color.Black;
			if(comboBoxBackColor.Text != String.Empty && comboBoxBackColor.Text != "Default")
			{
				chart1.ChartAreas["Default"].AxisX.ScrollBar.BackColor = Color.FromName(comboBoxBackColor.Text);
			}
			if(comboBoxLineColor.Text != String.Empty && comboBoxLineColor.Text != "Default")
			{
				chart1.ChartAreas["Default"].AxisX.ScrollBar.LineColor = Color.FromName(comboBoxLineColor.Text);
			}
			if(comboBoxButtonsColor.Text != String.Empty && comboBoxButtonsColor.Text != "Default")
			{
				chart1.ChartAreas["Default"].AxisX.ScrollBar.ButtonColor = Color.FromName(comboBoxButtonsColor.Text);
			}
		}

		private void chart1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

	}
}
