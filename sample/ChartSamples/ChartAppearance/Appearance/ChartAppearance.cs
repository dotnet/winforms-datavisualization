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
	/// Summary description for ChartAppearance.
	/// </summary>
	public class ChartAppearance : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox HatchStyle;
		private System.Windows.Forms.ComboBox Gradient;
		private System.Windows.Forms.ComboBox BorderDashStyle;
		private System.Windows.Forms.ComboBox BorderColor;
		private System.Windows.Forms.ComboBox BorderSizeCom;
		private System.Windows.Forms.ComboBox ForeColorCom;
		private System.Windows.Forms.ComboBox BackColorCom;
		private System.Windows.Forms.CheckBox ShowImageCheck;
		private System.Windows.Forms.ComboBox ImageMode;
		private System.Windows.Forms.ComboBox ImageAlign;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label17;
		private	bool		loadingData = false;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ChartAppearance()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Add Hatch styles to control.
			foreach(string colorName in Enum.GetNames(typeof(ChartHatchStyle)))
			{
				HatchStyle.Items.Add(colorName);
			}
		
			// Add Chart Gradient types to control.
			foreach(string colorName in Enum.GetNames(typeof(GradientStyle)))
			{
				Gradient.Items.Add(colorName);
			}

			// Add Chart Line styles to control.
			foreach(string colorName in Enum.GetNames(typeof(ChartDashStyle)))
			{
				BorderDashStyle.Items.Add(colorName);
			}

			
			// Add Chart Image Mode styles to control.
			foreach(string imageMode in Enum.GetNames(typeof(ChartImageWrapMode)))
			{
				ImageMode.Items.Add(imageMode);
			}
			ImageMode.SelectedIndex = 5;

			// Add Chart Image Align styles to control.
			foreach(string imageAlign in Enum.GetNames(typeof(ChartImageAlignmentStyle)))
			{
				ImageAlign.Items.Add(imageAlign);
			}
			ImageAlign.SelectedIndex = 2;
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImageMode = new System.Windows.Forms.ComboBox();
            this.ImageAlign = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ShowImageCheck = new System.Windows.Forms.CheckBox();
            this.BorderDashStyle = new System.Windows.Forms.ComboBox();
            this.BorderSizeCom = new System.Windows.Forms.ComboBox();
            this.BorderColor = new System.Windows.Forms.ComboBox();
            this.HatchStyle = new System.Windows.Forms.ComboBox();
            this.Gradient = new System.Windows.Forms.ComboBox();
            this.ForeColorCom = new System.Windows.Forms.ComboBox();
            this.BackColorCom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(696, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to set a chart\'s background appearance.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImageMode);
            this.panel1.Controls.Add(this.ImageAlign);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.ShowImageCheck);
            this.panel1.Controls.Add(this.BorderDashStyle);
            this.panel1.Controls.Add(this.BorderSizeCom);
            this.panel1.Controls.Add(this.BorderColor);
            this.panel1.Controls.Add(this.HatchStyle);
            this.panel1.Controls.Add(this.Gradient);
            this.panel1.Controls.Add(this.ForeColorCom);
            this.panel1.Controls.Add(this.BackColorCom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // ImageMode
            // 
            this.ImageMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImageMode.Location = new System.Drawing.Point(168, 232);
            this.ImageMode.Name = "ImageMode";
            this.ImageMode.Size = new System.Drawing.Size(120, 22);
            this.ImageMode.TabIndex = 16;
            this.ImageMode.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // ImageAlign
            // 
            this.ImageAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImageAlign.Location = new System.Drawing.Point(168, 256);
            this.ImageAlign.Name = "ImageAlign";
            this.ImageAlign.Size = new System.Drawing.Size(120, 22);
            this.ImageAlign.TabIndex = 18;
            this.ImageAlign.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(66, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "Image &Mode:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(66, 256);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 17;
            this.label17.Text = "Image &Align:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShowImageCheck
            // 
            this.ShowImageCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowImageCheck.Location = new System.Drawing.Point(64, 208);
            this.ShowImageCheck.Name = "ShowImageCheck";
            this.ShowImageCheck.Size = new System.Drawing.Size(120, 24);
            this.ShowImageCheck.TabIndex = 14;
            this.ShowImageCheck.Text = "Show &Image: ";
            this.ShowImageCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowImageCheck.Click += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // BorderDashStyle
            // 
            this.BorderDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorderDashStyle.Location = new System.Drawing.Point(168, 168);
            this.BorderDashStyle.Name = "BorderDashStyle";
            this.BorderDashStyle.Size = new System.Drawing.Size(120, 22);
            this.BorderDashStyle.TabIndex = 13;
            this.BorderDashStyle.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // BorderSizeCom
            // 
            this.BorderSizeCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorderSizeCom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.BorderSizeCom.Location = new System.Drawing.Point(168, 144);
            this.BorderSizeCom.Name = "BorderSizeCom";
            this.BorderSizeCom.Size = new System.Drawing.Size(120, 22);
            this.BorderSizeCom.TabIndex = 11;
            this.BorderSizeCom.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // BorderColor
            // 
            this.BorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorderColor.Items.AddRange(new object[] {
            "MidnightBlue",
            "Red",
            "Green",
            "Blue",
            "Gray"});
            this.BorderColor.Location = new System.Drawing.Point(168, 120);
            this.BorderColor.Name = "BorderColor";
            this.BorderColor.Size = new System.Drawing.Size(120, 22);
            this.BorderColor.TabIndex = 9;
            this.BorderColor.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // HatchStyle
            // 
            this.HatchStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HatchStyle.Location = new System.Drawing.Point(168, 56);
            this.HatchStyle.Name = "HatchStyle";
            this.HatchStyle.Size = new System.Drawing.Size(120, 22);
            this.HatchStyle.TabIndex = 5;
            this.HatchStyle.SelectedIndexChanged += new System.EventHandler(this.HatchStyle_SelectedIndexChanged);
            // 
            // Gradient
            // 
            this.Gradient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gradient.Location = new System.Drawing.Point(168, 32);
            this.Gradient.Name = "Gradient";
            this.Gradient.Size = new System.Drawing.Size(120, 22);
            this.Gradient.TabIndex = 3;
            this.Gradient.SelectedIndexChanged += new System.EventHandler(this.Gradient_SelectedIndexChanged);
            // 
            // ForeColorCom
            // 
            this.ForeColorCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ForeColorCom.Items.AddRange(new object[] {
            "SkyBlue",
            "Yellow",
            "Coral",
            "Teal",
            "Gainsboro"});
            this.ForeColorCom.Location = new System.Drawing.Point(168, 80);
            this.ForeColorCom.Name = "ForeColorCom";
            this.ForeColorCom.Size = new System.Drawing.Size(120, 22);
            this.ForeColorCom.TabIndex = 7;
            this.ForeColorCom.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // BackColorCom
            // 
            this.BackColorCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BackColorCom.Items.AddRange(new object[] {
            "White",
            "AliceBlue",
            "Linen",
            "Pink",
            "Lime",
            "WhiteSmoke"});
            this.BackColorCom.Location = new System.Drawing.Point(168, 8);
            this.BackColorCom.Name = "BackColorCom";
            this.BackColorCom.Size = new System.Drawing.Size(120, 22);
            this.BackColorCom.TabIndex = 1;
            this.BackColorCom.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(66, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Border S&tyle:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Secondary Back C&olor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(66, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Border &Size:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(66, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "&Back Color:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(66, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 2;
            this.label13.Text = "&Gradient:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(66, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 8;
            this.label14.Text = "Border &Color:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(66, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 4;
            this.label16.Text = "&Hatch Style:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.Area3DStyle.Rotation = 5;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.Interval = 1;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
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
            title1.Position.Width = 80F;
            title1.Position.X = 4F;
            title1.Position.Y = 4F;
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Chart Control for .NET Framework";
            this.Chart1.Titles.Add(title1);
            // 
            // ChartAppearance
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChartAppearance";
            this.Size = new System.Drawing.Size(728, 352);
            this.Load += new System.EventHandler(this.ChartAppearance_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void ChartAppearance_Load(object sender, System.EventArgs e)
		{
			BackColorCom.SelectedIndex = 0;
			Gradient.SelectedIndex = 0;
			ForeColorCom.SelectedIndex = 2;
			BorderColor.SelectedIndex = 0;
			HatchStyle.SelectedIndex = 0;
			BorderSizeCom.SelectedIndex = 1;
			BorderDashStyle.SelectedIndex = 5;
			
			ChartAppearanceChange();
		}

		private void ChartAppearanceChange()
		{
			// Enable/disable appearance controls
			ForeColorCom.Enabled = (HatchStyle.SelectedIndex != 0 || Gradient.SelectedIndex != 0);
			BorderColor.Enabled = (BorderDashStyle.SelectedIndex != 0);
			BorderSizeCom.Enabled = (BorderDashStyle.SelectedIndex != 0);

			// Set Back Color
			Chart1.BackColor = Color.FromName(BackColorCom.GetItemText(BackColorCom.SelectedItem));

			// Set Back Gradient End Color
			Chart1.BackSecondaryColor = Color.FromName(ForeColorCom.GetItemText(ForeColorCom.SelectedItem));

			// Set Gradient Type
			if( Gradient.SelectedItem != null )
				Chart1.BackGradientStyle = (GradientStyle)GradientStyle.Parse(typeof(GradientStyle), Gradient.GetItemText(Gradient.SelectedItem));

			// Set Gradient Type
			if( HatchStyle.SelectedItem != null )
				Chart1.BackHatchStyle = (ChartHatchStyle)ChartHatchStyle.Parse(typeof(ChartHatchStyle), HatchStyle.GetItemText(HatchStyle.SelectedItem));

			// Set background image
			if(!ShowImageCheck.Checked)
			{
				Chart1.BackImage = "";
				ImageAlign.Enabled = false;
				ImageMode.Enabled = false;
			}
			else
			{
				ImageMode.Enabled = true;
				ImageAlign.Enabled = (ImageMode.SelectedIndex == 5);

				// Set chart image
				MainForm mainForm = (MainForm)this.ParentForm;
                string imageFileName = mainForm.CurrentSamplePath;
				imageFileName += "\\Flag.gif";
				Chart1.BackImage = imageFileName;
				Chart1.BackImageTransparentColor = Color.Red;

				// Set Image Mode
				if( ImageMode.SelectedItem != null )
					Chart1.BackImageWrapMode = (ChartImageWrapMode)ChartImageWrapMode.Parse(typeof(ChartImageWrapMode), ImageMode.SelectedItem.ToString());

				// Set Image Alignment
				if( ImageAlign.SelectedItem != null )
					Chart1.BackImageAlignment = (ChartImageAlignmentStyle)ChartImageAlignmentStyle.Parse(typeof(ChartImageAlignmentStyle), ImageAlign.SelectedItem.ToString());
			}

			// Set Border Width
			if( BorderSizeCom.SelectedItem != null )
				Chart1.BorderWidth = int.Parse(BorderSizeCom.GetItemText(BorderSizeCom.SelectedItem));

			// Set Border Style
			if( BorderDashStyle.SelectedItem != null )
				Chart1.BorderDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), BorderDashStyle.GetItemText(BorderDashStyle.SelectedItem));

			// Set Border Color
			Chart1.BorderColor = Color.FromName(BorderColor.GetItemText(BorderColor.SelectedItem));
		}

		private void Combo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			ChartAppearanceChange();
		}

		private void Gradient_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(!loadingData)
			{
				// Reset Hatching style
				loadingData = true;
				HatchStyle.SelectedIndex = 0;
				loadingData = false;

				ChartAppearanceChange();
			}
		}

		private void HatchStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(!loadingData)
			{
				// Reset Gradient style
				loadingData = true;
				Gradient.SelectedIndex = 0;
				loadingData = false;

				ChartAppearanceChange();
			}
		}
	}
}
