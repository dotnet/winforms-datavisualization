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
	/// Summary description for AxisTitle.
	/// </summary>
	public class LegendFont : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.ComboBox FontSize;
		private System.Windows.Forms.CheckBox ItalicCheck;
		private System.Windows.Forms.CheckBox BoldCheck;
		private System.Windows.Forms.CheckBox UnderlineCheck;
		private System.Windows.Forms.CheckBox StrikeoutCheck;
		private System.Windows.Forms.ComboBox FontColorCombo;
		private System.Windows.Forms.ComboBox TheFont;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LegendFont()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Add Chart Line styles to control.
			foreach(FontFamily fontName in FontFamily.Families)
			{
				this.TheFont.Items.Add(fontName.Name);
			}
			this.TheFont.SelectedIndex = this.TheFont.Items.IndexOf(this.Chart1.Legends[0].Font.Name);

			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				this.FontColorCombo.Items.Add(colorName);
			}
			this.FontColorCombo.SelectedIndex = 9;	// "Control Text"

			this.FontSize.SelectedIndex = 0;	// 8 point
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
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 400);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 200);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 700);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 300);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 450);
			this.TheFont = new System.Windows.Forms.ComboBox();
			this.FontColorCombo = new System.Windows.Forms.ComboBox();
			this.FontSize = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.StrikeoutCheck = new System.Windows.Forms.CheckBox();
			this.UnderlineCheck = new System.Windows.Forms.CheckBox();
			this.BoldCheck = new System.Windows.Forms.CheckBox();
			this.ItalicCheck = new System.Windows.Forms.CheckBox();
			this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// TheFont
			// 
			this.TheFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TheFont.Location = new System.Drawing.Point(168, 4);
			this.TheFont.Name = "TheFont";
			this.TheFont.TabIndex = 1;
			this.TheFont.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
			// 
			// FontColorCombo
			// 
			this.FontColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FontColorCombo.Location = new System.Drawing.Point(168, 72);
			this.FontColorCombo.Name = "FontColorCombo";
			this.FontColorCombo.TabIndex = 5;
			this.FontColorCombo.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
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
			this.FontSize.Location = new System.Drawing.Point(168, 40);
			this.FontSize.Name = "FontSize";
			this.FontSize.TabIndex = 3;
			this.FontSize.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 7);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(152, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "&Font:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(152, 16);
			this.label7.TabIndex = 4;
			this.label7.Text = "Font &Color:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(12, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(152, 16);
			this.label8.TabIndex = 2;
			this.label8.Text = "Font &Size:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(702, 34);
			this.label9.TabIndex = 0;
			this.label9.Text = "This sample demonstrates how to set the font and color of the legend\'s text.";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.StrikeoutCheck,
																				 this.UnderlineCheck,
																				 this.BoldCheck,
																				 this.ItalicCheck,
																				 this.label5,
																				 this.TheFont,
																				 this.label7,
																				 this.label8,
																				 this.FontSize,
																				 this.FontColorCombo});
			this.panel1.Location = new System.Drawing.Point(432, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 296);
			this.panel1.TabIndex = 0;
			// 
			// StrikeoutCheck
			// 
			this.StrikeoutCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.StrikeoutCheck.Location = new System.Drawing.Point(13, 200);
			this.StrikeoutCheck.Name = "StrikeoutCheck";
			this.StrikeoutCheck.Size = new System.Drawing.Size(168, 24);
			this.StrikeoutCheck.TabIndex = 9;
			this.StrikeoutCheck.Text = "&Strikeout:";
			this.StrikeoutCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.StrikeoutCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
			// 
			// UnderlineCheck
			// 
			this.UnderlineCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.UnderlineCheck.Location = new System.Drawing.Point(13, 168);
			this.UnderlineCheck.Name = "UnderlineCheck";
			this.UnderlineCheck.Size = new System.Drawing.Size(168, 24);
			this.UnderlineCheck.TabIndex = 8;
			this.UnderlineCheck.Text = "&Underline:";
			this.UnderlineCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.UnderlineCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
			// 
			// BoldCheck
			// 
			this.BoldCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BoldCheck.Location = new System.Drawing.Point(13, 136);
			this.BoldCheck.Name = "BoldCheck";
			this.BoldCheck.Size = new System.Drawing.Size(168, 24);
			this.BoldCheck.TabIndex = 7;
			this.BoldCheck.Text = "&Bold:";
			this.BoldCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BoldCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
			// 
			// ItalicCheck
			// 
			this.ItalicCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ItalicCheck.Location = new System.Drawing.Point(13, 104);
			this.ItalicCheck.Name = "ItalicCheck";
			this.ItalicCheck.Size = new System.Drawing.Size(168, 24);
			this.ItalicCheck.TabIndex = 6;
			this.ItalicCheck.Text = "&Italic:";
			this.ItalicCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ItalicCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
			// 
			// Chart1
			// 
			this.Chart1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(211)), ((System.Byte)(223)), ((System.Byte)(240)));
			this.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			this.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			this.Chart1.BorderlineWidth = 2;
			this.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			chartArea1.AxisX2.MajorGrid.Enabled = false;
			chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY2.MajorGrid.Enabled = false;
			chartArea1.BackColor = System.Drawing.Color.Transparent;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.Name = "Default";
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			this.Chart1.ChartAreas.Add(chartArea1);
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.Chart1.Legends.Add(legend1);
			this.Chart1.Location = new System.Drawing.Point(16, 48);
			this.Chart1.Name = "Chart1";
			this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartType = SeriesChartType.Pie;
			series1.Color = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(65)), ((System.Byte)(140)), ((System.Byte)(240)));
			series1.CustomProperties = "PieDrawingStyle=SoftEdge";
			series1.Name = "Default";
			dataPoint1.CustomProperties = "Exploded=true";
			dataPoint1.Label = "Canada";
			dataPoint2.Label = "Other";
			dataPoint3.Label = "Ireland";
			dataPoint4.Label = "England";
			dataPoint5.Label = "Australia";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series1.IsValueShownAsLabel = true;
			this.Chart1.Series.Add(series1);
			this.Chart1.Size = new System.Drawing.Size(412, 296);
			this.Chart1.TabIndex = 1;
			// 
			// LegendFont
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.Chart1,
																		  this.panel1,
																		  this.label9});
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "LegendFont";
			this.Size = new System.Drawing.Size(728, 480);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		private void LegendFont_Load(object sender, System.EventArgs e)
		{ 
		
		}

		private void ControlChange(object sender, System.EventArgs e)
		{
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
					Chart1.Legends["Default"].Font = new Font(font, fontpoint, fontStyle);
				}
				catch
				{
					Chart1.Legends["Default"].Font = new Font("Arial", fontpoint, fontStyle);
				}
			}

			// Set Title color
			if(this.FontColorCombo.SelectedIndex >= 0)
			{
				Chart1.Legends["Default"].ForeColor = Color.FromName(this.FontColorCombo.SelectedItem.ToString());
			}
		}

	}
}
