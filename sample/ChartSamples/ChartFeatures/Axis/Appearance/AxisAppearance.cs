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
	public class AxisAppearance : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.ComboBox LineColor;
		private System.Windows.Forms.ComboBox LineDashStyle;
		private System.Windows.Forms.ComboBox LineWidth;
		private System.Windows.Forms.ComboBox ArrowStyleCombo;
		private System.Windows.Forms.CheckBox AxisEnabledCheck;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxAxisTooltip;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AxisAppearance()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Add Chart Line styles to control.
            foreach (string arrowStyle in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle)))
			{
				this.ArrowStyleCombo.Items.Add(arrowStyle);
			}
            this.ArrowStyleCombo.SelectedIndex = 0;

			
			// Add Border styles to control.
			foreach(string lineName in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)))
			{
				this.LineDashStyle.Items.Add(lineName);
			}
			this.LineDashStyle.SelectedIndex = 5;

			// Add Colors to controls.
			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				this.LineColor.Items.Add(colorName);
			}

			this.LineColor.SelectedIndex = this.LineColor.Items.IndexOf("DarkBlue");

			this.LineWidth.SelectedIndex = 1;

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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 70);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 80);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 70);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 85);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 65);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 70);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 60);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 75);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 50);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 55);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 40);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 70);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ArrowStyleCombo = new System.Windows.Forms.ComboBox();
            this.LineColor = new System.Windows.Forms.ComboBox();
            this.LineDashStyle = new System.Windows.Forms.ComboBox();
            this.LineWidth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxAxisTooltip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AxisEnabledCheck = new System.Windows.Forms.CheckBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ArrowStyleCombo
            // 
            this.ArrowStyleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArrowStyleCombo.Location = new System.Drawing.Point(168, 128);
            this.ArrowStyleCombo.Name = "ArrowStyleCombo";
            this.ArrowStyleCombo.Size = new System.Drawing.Size(121, 22);
            this.ArrowStyleCombo.TabIndex = 8;
            this.ArrowStyleCombo.SelectedIndexChanged += new System.EventHandler(this.ArrowStyleCombo_SelectedIndexChanged);
            // 
            // LineColor
            // 
            this.LineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LineColor.Location = new System.Drawing.Point(168, 64);
            this.LineColor.Name = "LineColor";
            this.LineColor.Size = new System.Drawing.Size(121, 22);
            this.LineColor.TabIndex = 4;
            this.LineColor.SelectedIndexChanged += new System.EventHandler(this.LineColor_SelectedIndexChanged);
            // 
            // LineDashStyle
            // 
            this.LineDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LineDashStyle.Location = new System.Drawing.Point(168, 96);
            this.LineDashStyle.Name = "LineDashStyle";
            this.LineDashStyle.Size = new System.Drawing.Size(121, 22);
            this.LineDashStyle.TabIndex = 6;
            this.LineDashStyle.SelectedIndexChanged += new System.EventHandler(this.LineDashStyle_SelectedIndexChanged);
            // 
            // LineWidth
            // 
            this.LineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LineWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.LineWidth.Location = new System.Drawing.Point(168, 32);
            this.LineWidth.Name = "LineWidth";
            this.LineWidth.Size = new System.Drawing.Size(121, 22);
            this.LineWidth.TabIndex = 2;
            this.LineWidth.SelectedIndexChanged += new System.EventHandler(this.LineWidth_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "&Arrow Style:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Axis &Line Style:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Line &Color:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Line &Width:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 1;
            this.label9.Text = "This sample demonstrates how to set the appearance of axis lines.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxAxisTooltip);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AxisEnabledCheck);
            this.panel1.Controls.Add(this.LineDashStyle);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ArrowStyleCombo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.LineWidth);
            this.panel1.Controls.Add(this.LineColor);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 296);
            this.panel1.TabIndex = 0;
            // 
            // textBoxAxisTooltip
            // 
            this.textBoxAxisTooltip.Location = new System.Drawing.Point(168, 160);
            this.textBoxAxisTooltip.MaxLength = 15;
            this.textBoxAxisTooltip.Name = "textBoxAxisTooltip";
            this.textBoxAxisTooltip.Size = new System.Drawing.Size(120, 22);
            this.textBoxAxisTooltip.TabIndex = 10;
            this.textBoxAxisTooltip.Text = "Axis tooltip";
            this.textBoxAxisTooltip.TextChanged += new System.EventHandler(this.textBoxAxisTooltip_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Axis &Tooltip:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AxisEnabledCheck
            // 
            this.AxisEnabledCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AxisEnabledCheck.Checked = true;
            this.AxisEnabledCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AxisEnabledCheck.Location = new System.Drawing.Point(77, 4);
            this.AxisEnabledCheck.Name = "AxisEnabledCheck";
            this.AxisEnabledCheck.Size = new System.Drawing.Size(104, 24);
            this.AxisEnabledCheck.TabIndex = 0;
            this.AxisEnabledCheck.Text = "&Visible:";
            this.AxisEnabledCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AxisEnabledCheck.CheckedChanged += new System.EventHandler(this.Enabled_CheckedChanged);
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
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.IsLabelAutoFit = false;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.ToolTip = "Axis tooltip";
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.Chart1.Location = new System.Drawing.Point(16, 48);
            this.Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.Legend = "Legend2";
            series1.Name = "Series2";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartArea = "Default";
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.Legend = "Default";
            series2.Name = "Series3";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.CustomProperties = "DrawingStyle=Cylinder";
            series3.Legend = "Default";
            series3.Name = "Series4";
            series3.Points.Add(dataPoint9);
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            this.Chart1.Series.Add(series1);
            this.Chart1.Series.Add(series2);
            this.Chart1.Series.Add(series3);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 2;
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Chart Control for .NET Framework";
            this.Chart1.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note that each axis can have different visual attributes, including visibility. I" +
                "n this sample, changes are applied to the secondary Y axis.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AxisAppearance
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AxisAppearance";
            this.Size = new System.Drawing.Size(728, 424);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void LineWidth_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Chart1.ChartAreas["Default"].AxisY2.LineWidth = int.Parse(LineWidth.SelectedItem.ToString());
		}

		private void LineDashStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Chart1.ChartAreas["Default"].AxisY2.LineDashStyle = 
				(ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), LineDashStyle.SelectedItem.ToString());
		
			LineWidth.Enabled = (LineDashStyle.SelectedIndex != 0);
			LineColor.Enabled = (LineDashStyle.SelectedIndex != 0);
		}

        private AxisArrowStyle FindStyle(string inputStyle)
        {
            foreach (AxisArrowStyle style in Enum.GetValues(typeof(System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle)))
            {
                if (inputStyle.ToLower() == style.ToString().ToLower())
                    return style;
            }
            return AxisArrowStyle.None;
        }
 
		private void ArrowStyleCombo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Chart1.ChartAreas["Default"].AxisY2.ArrowStyle = 
				FindStyle(ArrowStyleCombo.SelectedItem.ToString());
		}

		private void LineColor_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Chart1.ChartAreas["Default"].AxisY2.LineColor = Color.FromName(LineColor.SelectedItem.ToString());
		}

		private void Enabled_CheckedChanged(object sender, System.EventArgs e)
		{
			if(AxisEnabledCheck.Checked)
				Chart1.ChartAreas["Default"].AxisY2.Enabled = AxisEnabled.True;
			else
				Chart1.ChartAreas["Default"].AxisY2.Enabled = AxisEnabled.False;

			LineWidth.Enabled = AxisEnabledCheck.Checked;
			LineDashStyle.Enabled = AxisEnabledCheck.Checked;
			ArrowStyleCombo.Enabled = AxisEnabledCheck.Checked;
			LineColor.Enabled = AxisEnabledCheck.Checked;
		}

		private void textBoxAxisTooltip_TextChanged(object sender, System.EventArgs e)
		{
			Chart1.ChartAreas["Default"].AxisY2.ToolTip = this.textBoxAxisTooltip.Text;
		}

	}
}
