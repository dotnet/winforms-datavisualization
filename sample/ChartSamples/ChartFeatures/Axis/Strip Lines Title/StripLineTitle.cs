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
	/// Summary description for StripLineTitle.
	/// </summary>
	public class StripLineTitle : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.ComboBox FontSize;
		private System.Windows.Forms.CheckBox ItalicCheck;
		private System.Windows.Forms.TextBox Title;
		private System.Windows.Forms.CheckBox BoldCheck;
		private System.Windows.Forms.CheckBox UnderlineCheck;
		private System.Windows.Forms.CheckBox StrikeoutCheck;
		private System.Windows.Forms.ComboBox FontColorCombo;
		private System.Windows.Forms.ComboBox TheFont;
		private System.Windows.Forms.ComboBox TitlePosition;
		private System.Windows.Forms.CheckBox AntiAliasingCheck;
		private System.Windows.Forms.ComboBox TitleLinePosition;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public StripLineTitle()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			
			foreach(String AlignmentName in Enum.GetNames(typeof(StringAlignment)))
			{
				this.TitlePosition.Items.Add(AlignmentName);
				this.TitleLinePosition.Items.Add(AlignmentName);
			}
			this.TitlePosition.SelectedIndex = 0;
			this.TitleLinePosition.SelectedIndex = 0;
			
			// Add Chart Line styles to control.
			foreach(FontFamily fontName in FontFamily.Families)
			{
				this.TheFont.Items.Add(fontName.Name);
			}
			this.TheFont.SelectedIndex = 0; // "Arial"

			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				this.FontColorCombo.Items.Add(colorName);
			}
			this.FontColorCombo.SelectedIndex = 9;	// "Control Text"

			this.FontSize.SelectedIndex = 1;	// 10 point
			this.BoldCheck.Checked = true;

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
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 400);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 200);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 700);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 300);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5, 450);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 200);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 300);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 350);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 80);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5, 400);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1, 500);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2, 120);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3, 300);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4, 50);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5, 130);
            this.TheFont = new System.Windows.Forms.ComboBox();
            this.FontColorCombo = new System.Windows.Forms.ComboBox();
            this.TitlePosition = new System.Windows.Forms.ComboBox();
            this.FontSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleLinePosition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StrikeoutCheck = new System.Windows.Forms.CheckBox();
            this.UnderlineCheck = new System.Windows.Forms.CheckBox();
            this.BoldCheck = new System.Windows.Forms.CheckBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.ItalicCheck = new System.Windows.Forms.CheckBox();
            this.AntiAliasingCheck = new System.Windows.Forms.CheckBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // TheFont
            // 
            this.TheFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TheFont.Location = new System.Drawing.Point(168, 104);
            this.TheFont.Name = "TheFont";
            this.TheFont.Size = new System.Drawing.Size(116, 22);
            this.TheFont.TabIndex = 7;
            this.TheFont.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
            // 
            // FontColorCombo
            // 
            this.FontColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontColorCombo.Location = new System.Drawing.Point(168, 168);
            this.FontColorCombo.Name = "FontColorCombo";
            this.FontColorCombo.Size = new System.Drawing.Size(116, 22);
            this.FontColorCombo.TabIndex = 11;
            this.FontColorCombo.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
            // 
            // TitlePosition
            // 
            this.TitlePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TitlePosition.Location = new System.Drawing.Point(168, 40);
            this.TitlePosition.Name = "TitlePosition";
            this.TitlePosition.Size = new System.Drawing.Size(116, 22);
            this.TitlePosition.TabIndex = 3;
            this.TitlePosition.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
            // 
            // FontSize
            // 
            this.FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16"});
            this.FontSize.Location = new System.Drawing.Point(168, 136);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(116, 22);
            this.FontSize.TabIndex = 9;
            this.FontSize.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "&Font:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Horizontal &Alignment:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(20, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Font &Color:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Font &Size:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to set a StripLine object\'s title.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TitleLinePosition);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StrikeoutCheck);
            this.panel1.Controls.Add(this.UnderlineCheck);
            this.panel1.Controls.Add(this.BoldCheck);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.ItalicCheck);
            this.panel1.Controls.Add(this.TitlePosition);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TheFont);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.FontSize);
            this.panel1.Controls.Add(this.FontColorCombo);
            this.panel1.Controls.Add(this.AntiAliasingCheck);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 360);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title &Text:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TitleLinePosition
            // 
            this.TitleLinePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TitleLinePosition.Location = new System.Drawing.Point(168, 72);
            this.TitleLinePosition.Name = "TitleLinePosition";
            this.TitleLinePosition.Size = new System.Drawing.Size(116, 22);
            this.TitleLinePosition.TabIndex = 5;
            this.TitleLinePosition.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Vertical Alignment:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StrikeoutCheck
            // 
            this.StrikeoutCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StrikeoutCheck.Location = new System.Drawing.Point(19, 296);
            this.StrikeoutCheck.Name = "StrikeoutCheck";
            this.StrikeoutCheck.Size = new System.Drawing.Size(162, 24);
            this.StrikeoutCheck.TabIndex = 15;
            this.StrikeoutCheck.Text = "S&trikeout:";
            this.StrikeoutCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StrikeoutCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
            // 
            // UnderlineCheck
            // 
            this.UnderlineCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnderlineCheck.Location = new System.Drawing.Point(19, 264);
            this.UnderlineCheck.Name = "UnderlineCheck";
            this.UnderlineCheck.Size = new System.Drawing.Size(162, 24);
            this.UnderlineCheck.TabIndex = 14;
            this.UnderlineCheck.Text = "&Underline:";
            this.UnderlineCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnderlineCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
            // 
            // BoldCheck
            // 
            this.BoldCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BoldCheck.Location = new System.Drawing.Point(19, 232);
            this.BoldCheck.Name = "BoldCheck";
            this.BoldCheck.Size = new System.Drawing.Size(162, 24);
            this.BoldCheck.TabIndex = 13;
            this.BoldCheck.Text = "&Bold:";
            this.BoldCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BoldCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(168, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(116, 22);
            this.Title.TabIndex = 1;
            this.Title.Text = "Strip Line Title";
            this.Title.TextChanged += new System.EventHandler(this.ControlChange);
            // 
            // ItalicCheck
            // 
            this.ItalicCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ItalicCheck.Location = new System.Drawing.Point(19, 200);
            this.ItalicCheck.Name = "ItalicCheck";
            this.ItalicCheck.Size = new System.Drawing.Size(162, 24);
            this.ItalicCheck.TabIndex = 12;
            this.ItalicCheck.Text = "&Italic:";
            this.ItalicCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ItalicCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
            // 
            // AntiAliasingCheck
            // 
            this.AntiAliasingCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AntiAliasingCheck.Checked = true;
            this.AntiAliasingCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AntiAliasingCheck.Location = new System.Drawing.Point(16, 328);
            this.AntiAliasingCheck.Name = "AntiAliasingCheck";
            this.AntiAliasingCheck.Size = new System.Drawing.Size(162, 24);
            this.AntiAliasingCheck.TabIndex = 16;
            this.AntiAliasingCheck.Text = "Anti Alia&sing:";
            this.AntiAliasingCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AntiAliasingCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            this.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            this.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.Chart1.BorderlineWidth = 2;
            this.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 5;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stripLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            stripLine1.Interval = 3;
            stripLine1.IntervalOffset = 0.5;
            stripLine1.StripWidth = 2;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.OldLace;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Name = "Default";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(16, 48);
            this.Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderWidth = 3;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series3.BorderWidth = 3;
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Default";
            series3.Name = "Series3";
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            this.Chart1.Series.Add(series1);
            this.Chart1.Series.Add(series2);
            this.Chart1.Series.Add(series3);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 1;
            // 
            // StripLineTitle
            // 
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StripLineTitle";
            this.Size = new System.Drawing.Size(728, 480);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void StripLineTitle_Load(object sender, System.EventArgs e)
		{ 
		
		}

		private void ControlChange(object sender, System.EventArgs e)
		{
			if(this.TitlePosition.SelectedIndex >= 0)
			{
				string strAlign = this.TitlePosition.SelectedItem.ToString();
				StringAlignment align = (StringAlignment) Enum.Parse(typeof(StringAlignment), strAlign, true);
				Chart1.ChartAreas["Default"].AxisX.StripLines[0].TextAlignment = align;
			}
			
			if(this.TitleLinePosition.SelectedIndex >= 0)
			{
				string strAlign = this.TitleLinePosition.SelectedItem.ToString();
				StringAlignment align = (StringAlignment) Enum.Parse(typeof(StringAlignment), strAlign, true);
				Chart1.ChartAreas["Default"].AxisX.StripLines[0].TextLineAlignment = align;
			}

			// Set selected axis
			Chart1.ChartAreas["Default"].AxisX.StripLines[0].Text = Title.Text;

			if( AntiAliasingCheck.Checked )
				Chart1.AntiAliasing = AntiAliasingStyles.All;
			else
				Chart1.AntiAliasing = AntiAliasingStyles.Graphics;


			// Set Font style.
			FontStyle fontStyle = FontStyle.Regular;
			if( ItalicCheck.Checked )
				fontStyle = (FontStyle)FontStyle.Italic;
			if( BoldCheck.Checked )
				fontStyle |= (FontStyle)FontStyle.Bold;
			if( UnderlineCheck.Checked )
				fontStyle |= (FontStyle)FontStyle.Underline;
			if( StrikeoutCheck.Checked )
				fontStyle |= (FontStyle)FontStyle.Strikeout;


			// Set Title font
			if(this.TheFont.SelectedIndex >= 0 && this.FontSize.SelectedIndex >= 0)
			{
				string font = this.TheFont.SelectedItem.ToString();
				float fontpoint = float.Parse(this.FontSize.SelectedItem.ToString());
				try
				{
					Chart1.ChartAreas["Default"].AxisX.StripLines[0].Font = new Font(font, fontpoint, fontStyle);
				}
				catch
				{
					Chart1.ChartAreas["Default"].AxisX.StripLines[0].Font = new Font("Arial", fontpoint, fontStyle);
				}
			}

			// Set Title color
			if(this.FontColorCombo.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].AxisX.StripLines[0].ForeColor = Color.FromName(this.FontColorCombo.SelectedItem.ToString());
			}
		}

	}
}
