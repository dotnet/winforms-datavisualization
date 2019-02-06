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
	public class AxisTitle : System.Windows.Forms.UserControl
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
		private System.Windows.Forms.ComboBox AxisPosition;
		private System.Windows.Forms.Label label1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AxisTitle()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			this.AxisPosition.Items.Add("Axis X");
			this.AxisPosition.Items.Add("Axis Y");
			this.AxisPosition.Items.Add("Axis X2");
			this.AxisPosition.Items.Add("Axis Y2");
			this.AxisPosition.SelectedIndex = 0;	// X Axis
			
			// Add Chart Line styles to control.
			foreach(FontFamily fontName in FontFamily.Families)
			{
				this.TheFont.Items.Add(fontName.Name);
			}
			
			this.TheFont.SelectedIndex = this.TheFont.Items.IndexOf("Trebuchet MS"); // "Verdana"
			if ( this.TheFont.SelectedIndex == -1)
			{
				this.TheFont.SelectedIndex = 0; // "Arial"
			}
			
			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				this.FontColorCombo.Items.Add(colorName);
			}
			this.FontColorCombo.SelectedIndex = 9;	// "Control Text"

			this.FontSize.SelectedIndex = this.FontSize.Items.IndexOf("12");
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
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel3 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel4 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
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
            this.TheFont = new System.Windows.Forms.ComboBox();
            this.FontColorCombo = new System.Windows.Forms.ComboBox();
            this.AxisPosition = new System.Windows.Forms.ComboBox();
            this.FontSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.StrikeoutCheck = new System.Windows.Forms.CheckBox();
            this.UnderlineCheck = new System.Windows.Forms.CheckBox();
            this.BoldCheck = new System.Windows.Forms.CheckBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.ItalicCheck = new System.Windows.Forms.CheckBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // TheFont
            // 
            this.TheFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TheFont.Location = new System.Drawing.Point(167, 72);
            this.TheFont.Name = "TheFont";
            this.TheFont.Size = new System.Drawing.Size(121, 22);
            this.TheFont.TabIndex = 5;
            this.TheFont.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
            // 
            // FontColorCombo
            // 
            this.FontColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontColorCombo.Location = new System.Drawing.Point(167, 136);
            this.FontColorCombo.Name = "FontColorCombo";
            this.FontColorCombo.Size = new System.Drawing.Size(121, 22);
            this.FontColorCombo.TabIndex = 9;
            this.FontColorCombo.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
            // 
            // AxisPosition
            // 
            this.AxisPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AxisPosition.Location = new System.Drawing.Point(167, 40);
            this.AxisPosition.Name = "AxisPosition";
            this.AxisPosition.Size = new System.Drawing.Size(121, 22);
            this.AxisPosition.TabIndex = 3;
            this.AxisPosition.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
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
            this.FontSize.Location = new System.Drawing.Point(167, 104);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(121, 22);
            this.FontSize.TabIndex = 7;
            this.FontSize.SelectedIndexChanged += new System.EventHandler(this.ControlChange);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "&Font:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "&Axis:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Font &Color:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "&Font Size:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to set the appearance of the axis title.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StrikeoutCheck);
            this.panel1.Controls.Add(this.UnderlineCheck);
            this.panel1.Controls.Add(this.BoldCheck);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.ItalicCheck);
            this.panel1.Controls.Add(this.AxisPosition);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TheFont);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.FontSize);
            this.panel1.Controls.Add(this.FontColorCombo);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 296);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title &Text:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StrikeoutCheck
            // 
            this.StrikeoutCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StrikeoutCheck.Location = new System.Drawing.Point(11, 264);
            this.StrikeoutCheck.Name = "StrikeoutCheck";
            this.StrikeoutCheck.Size = new System.Drawing.Size(169, 24);
            this.StrikeoutCheck.TabIndex = 13;
            this.StrikeoutCheck.Text = "&Strikeout:";
            this.StrikeoutCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StrikeoutCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
            // 
            // UnderlineCheck
            // 
            this.UnderlineCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnderlineCheck.Location = new System.Drawing.Point(11, 232);
            this.UnderlineCheck.Name = "UnderlineCheck";
            this.UnderlineCheck.Size = new System.Drawing.Size(169, 24);
            this.UnderlineCheck.TabIndex = 12;
            this.UnderlineCheck.Text = "&Underline:";
            this.UnderlineCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnderlineCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
            // 
            // BoldCheck
            // 
            this.BoldCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BoldCheck.Location = new System.Drawing.Point(11, 200);
            this.BoldCheck.Name = "BoldCheck";
            this.BoldCheck.Size = new System.Drawing.Size(169, 24);
            this.BoldCheck.TabIndex = 11;
            this.BoldCheck.Text = "&Bold:";
            this.BoldCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BoldCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(168, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(120, 22);
            this.Title.TabIndex = 1;
            this.Title.Text = "Axis Title";
            this.Title.TextChanged += new System.EventHandler(this.ControlChange);
            // 
            // ItalicCheck
            // 
            this.ItalicCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ItalicCheck.Location = new System.Drawing.Point(11, 168);
            this.ItalicCheck.Name = "ItalicCheck";
            this.ItalicCheck.Size = new System.Drawing.Size(169, 24);
            this.ItalicCheck.TabIndex = 10;
            this.ItalicCheck.Text = "&Italic:";
            this.ItalicCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ItalicCheck.CheckedChanged += new System.EventHandler(this.ControlChange);
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
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
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 5;
            chartArea1.Area3DStyle.WallWidth = 0;
            customLabel1.FromPosition = 0.5;
            customLabel1.Text = "John";
            customLabel1.ToPosition = 1.5;
            customLabel2.FromPosition = 1.5;
            customLabel2.Text = "Mary";
            customLabel2.ToPosition = 2.5;
            customLabel3.FromPosition = 2.5;
            customLabel3.Text = "Jeff";
            customLabel3.ToPosition = 3.5;
            customLabel4.FromPosition = 3.5;
            customLabel4.Text = "Bob";
            customLabel4.ToPosition = 4.5;
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.CustomLabels.Add(customLabel2);
            chartArea1.AxisX.CustomLabels.Add(customLabel3);
            chartArea1.AxisX.CustomLabels.Add(customLabel4);
            chartArea1.AxisX.Interval = 1;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX2.IsLabelAutoFit = false;
            chartArea1.AxisX2.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 75F;
            chartArea1.Position.Width = 90F;
            chartArea1.Position.X = 2F;
            chartArea1.Position.Y = 13F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            legend1.Position.Auto = false;
            legend1.Position.Height = 5F;
            legend1.Position.Width = 40F;
            legend1.Position.X = 5F;
            legend1.Position.Y = 85F;
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(16, 48);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.Legend = "Legend2";
            series1.Name = "Series2";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.ChartArea = "Default";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.Legend = "Default";
            series2.Name = "Series3";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
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
            this.Chart1.TabIndex = 1;
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.Position.Auto = false;
            title1.Position.Height = 8.738057F;
            title1.Position.Width = 55F;
            title1.Position.X = 4F;
            title1.Position.Y = 4F;
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Chart Control for .NET Framework";
            title1.Visible = false;
            this.Chart1.Titles.Add(title1);
            // 
            // AxisTitle
            // 
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AxisTitle";
            this.Size = new System.Drawing.Size(728, 480);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void AxisTitle_Load(object sender, System.EventArgs e)
		{ 
		
		}

		private void ControlChange(object sender, System.EventArgs e)
		{
			int axis = 0;
			
			foreach( Axis item in Chart1.ChartAreas["Default"].Axes)
			{
				item.Title = String.Empty;
			}

			if(this.AxisPosition.SelectedIndex >= 0)
			{
				string strAxis = this.AxisPosition.SelectedItem.ToString();
				if(strAxis == "Axis X")
					axis = 0;
				if(strAxis == "Axis Y")
					axis = 1;
				if(strAxis == "Axis X2")
					axis = 2;
				if(strAxis == "Axis Y2")
					axis = 3;
			}
			// Set selected axis
			Chart1.ChartAreas["Default"].Axes[axis].Title = Title.Text;

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
					Chart1.ChartAreas["Default"].Axes[axis].TitleFont = new Font(font, fontpoint, fontStyle);
				}
				catch
				{
					Chart1.ChartAreas["Default"].Axes[axis].TitleFont = new Font("Arial", fontpoint, fontStyle);
				}
			}

			// Set Title color
			if(this.FontColorCombo.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].Axes[axis].TitleForeColor = Color.FromName(this.FontColorCombo.SelectedItem.ToString());
			}
		}

	}
}
