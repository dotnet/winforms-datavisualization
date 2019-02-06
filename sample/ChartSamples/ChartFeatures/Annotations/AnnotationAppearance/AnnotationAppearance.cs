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
	/// Summary description for AnnotationAppearance.
	/// </summary>
	public class AnnotationAppearance : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.ComboBox LineColor;
		private System.Windows.Forms.ComboBox LineDashStyle;
		private System.Windows.Forms.ComboBox FontName;
		private System.Windows.Forms.ComboBox FontSize;
		private System.Windows.Forms.Label FontLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox FontColorCombo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox FontStyle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox AnnotationBackColor;
		private System.Windows.Forms.ComboBox Shadow;
		private System.Windows.Forms.Label label2;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AnnotationAppearance()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			
			
			// Add Border styles to control.
			foreach(string lineName in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)))
			{
				this.LineDashStyle.Items.Add(lineName);
			}

			this.LineDashStyle.SelectedIndex = 5;
			this.Shadow.SelectedIndex = 2;
			this.FontSize.SelectedIndex = 0;
			this.FontName.SelectedIndex = 3;
			this.AnnotationBackColor.SelectedIndex = 0;
			this.FontStyle.SelectedIndex = 0;
			this.FontColorCombo.SelectedIndex = 0;
			this.LineColor.SelectedIndex = 1;

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
            System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation calloutAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.CalloutAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 700);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 600);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 800);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 450);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 700);
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 450);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 300);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 500);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 400);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 600);
            this.LineColor = new System.Windows.Forms.ComboBox();
            this.LineDashStyle = new System.Windows.Forms.ComboBox();
            this.Shadow = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnnotationBackColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FontStyle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FontColorCombo = new System.Windows.Forms.ComboBox();
            this.FontLabel = new System.Windows.Forms.Label();
            this.FontSize = new System.Windows.Forms.ComboBox();
            this.FontName = new System.Windows.Forms.ComboBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // LineColor
            // 
            this.LineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LineColor.Items.AddRange(new object[] {
            "Black",
            "DimGray",
            "Gainsboro",
            "Blue",
            "Red",
            "Magenta",
            "Purple",
            "Orange"});
            this.LineColor.Location = new System.Drawing.Point(168, 40);
            this.LineColor.Name = "LineColor";
            this.LineColor.Size = new System.Drawing.Size(121, 22);
            this.LineColor.TabIndex = 3;
            this.LineColor.SelectedIndexChanged += new System.EventHandler(this.LineColor_SelectedIndexChanged);
            // 
            // LineDashStyle
            // 
            this.LineDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LineDashStyle.Location = new System.Drawing.Point(168, 8);
            this.LineDashStyle.Name = "LineDashStyle";
            this.LineDashStyle.Size = new System.Drawing.Size(121, 22);
            this.LineDashStyle.TabIndex = 1;
            this.LineDashStyle.SelectedIndexChanged += new System.EventHandler(this.LineDashStyle_SelectedIndexChanged);
            // 
            // Shadow
            // 
            this.Shadow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Shadow.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.Shadow.Location = new System.Drawing.Point(168, 72);
            this.Shadow.Name = "Shadow";
            this.Shadow.Size = new System.Drawing.Size(121, 22);
            this.Shadow.TabIndex = 5;
            this.Shadow.SelectedIndexChanged += new System.EventHandler(this.Shadow_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(-16, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Line &Style:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(-16, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Line &Color:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(-16, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "&Shadow:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to set the appearance properties of an Annotation ob" +
                "ject. ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AnnotationBackColor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FontStyle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.FontColorCombo);
            this.panel1.Controls.Add(this.FontLabel);
            this.panel1.Controls.Add(this.FontSize);
            this.panel1.Controls.Add(this.FontName);
            this.panel1.Controls.Add(this.LineDashStyle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Shadow);
            this.panel1.Controls.Add(this.LineColor);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "F&ont Size:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-16, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "&Back Color:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AnnotationBackColor
            // 
            this.AnnotationBackColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnnotationBackColor.Items.AddRange(new object[] {
            "LightYellow",
            "White",
            "Yellow",
            "Gainsboro",
            "Silver",
            "BurlyWood"});
            this.AnnotationBackColor.Location = new System.Drawing.Point(168, 232);
            this.AnnotationBackColor.Name = "AnnotationBackColor";
            this.AnnotationBackColor.Size = new System.Drawing.Size(121, 22);
            this.AnnotationBackColor.TabIndex = 15;
            this.AnnotationBackColor.SelectedIndexChanged += new System.EventHandler(this.BackColor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(-16, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Font St&yle:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FontStyle
            // 
            this.FontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontStyle.Items.AddRange(new object[] {
            "Default",
            "Shadow",
            "Emboss",
            "Embed",
            "Frame"});
            this.FontStyle.Location = new System.Drawing.Point(168, 200);
            this.FontStyle.Name = "FontStyle";
            this.FontStyle.Size = new System.Drawing.Size(121, 22);
            this.FontStyle.TabIndex = 13;
            this.FontStyle.SelectedIndexChanged += new System.EventHandler(this.FontStyle_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(-16, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fo&nt Color:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FontColorCombo
            // 
            this.FontColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontColorCombo.Items.AddRange(new object[] {
            "Black",
            "DimGray",
            "Gainsboro",
            "Blue",
            "Red",
            "Magenta",
            "Purple",
            "Orange"});
            this.FontColorCombo.Location = new System.Drawing.Point(168, 168);
            this.FontColorCombo.Name = "FontColorCombo";
            this.FontColorCombo.Size = new System.Drawing.Size(121, 22);
            this.FontColorCombo.TabIndex = 11;
            this.FontColorCombo.SelectedIndexChanged += new System.EventHandler(this.FontColorCombo_SelectedIndexChanged);
            // 
            // FontLabel
            // 
            this.FontLabel.Location = new System.Drawing.Point(-16, 104);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(176, 23);
            this.FontLabel.TabIndex = 6;
            this.FontLabel.Text = "&Font:";
            this.FontLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FontSize
            // 
            this.FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14"});
            this.FontSize.Location = new System.Drawing.Point(168, 136);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(56, 22);
            this.FontSize.TabIndex = 9;
            this.FontSize.SelectedIndexChanged += new System.EventHandler(this.FontSize_SelectedIndexChanged);
            // 
            // FontName
            // 
            this.FontName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontName.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Arial",
            "Times New Roman",
            "Tahoma"});
            this.FontName.Location = new System.Drawing.Point(168, 104);
            this.FontName.Name = "FontName";
            this.FontName.Size = new System.Drawing.Size(121, 22);
            this.FontName.TabIndex = 7;
            this.FontName.SelectedIndexChanged += new System.EventHandler(this.FontName_SelectedIndexChanged);
            // 
            // Chart1
            // 
            calloutAnnotation2.AnchorDataPointName = "Default\\r0";
            calloutAnnotation2.AnchorOffsetX = 5;
            calloutAnnotation2.AnchorOffsetY = 7;
            calloutAnnotation2.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.CalloutStyle.Cloud;
            calloutAnnotation2.Name = "CloudAnnotation";
            calloutAnnotation2.Text = "Set my Appearance";
            this.Chart1.Annotations.Add(calloutAnnotation2);
            this.Chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            this.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.Chart1.BorderlineWidth = 2;
            this.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.Inclination = 15;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Perspective = 10;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.Name = "Default";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.Chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Enabled = false;
            legend2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Default";
            this.Chart1.Legends.Add(legend2);
            this.Chart1.Location = new System.Drawing.Point(16, 48);
            this.Chart1.Name = "Chart1";
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartArea = "Default";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series3.Legend = "Default";
            series3.Name = "Default";
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            series3.Points.Add(dataPoint15);
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series4.ChartArea = "Default";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series4.Legend = "Default";
            series4.Name = "Series2";
            series4.Points.Add(dataPoint16);
            series4.Points.Add(dataPoint17);
            series4.Points.Add(dataPoint18);
            series4.Points.Add(dataPoint19);
            series4.Points.Add(dataPoint20);
            this.Chart1.Series.Add(series3);
            this.Chart1.Series.Add(series4);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 1;
            // 
            // AnnotationAppearance
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AnnotationAppearance";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.AnnotationAppearance_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void LineDashStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Chart1.Annotations[0].LineDashStyle = 
				(ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), LineDashStyle.SelectedItem.ToString());
		
		}


		private void LineColor_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Chart1.Annotations[0].LineColor = Color.FromName(LineColor.SelectedItem.ToString());
		}


		private void AnnotationAppearance_Load(object sender, System.EventArgs e)
		{
		
		}

		private void label7_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label5_Click(object sender, System.EventArgs e)
		{
		
		}

		private void FontName_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(FontSize.SelectedItem != null)
				Chart1.Annotations[0].Font = new Font(FontName.SelectedItem.ToString(), float.Parse(FontSize.SelectedItem.ToString()));
		}

		private void FontSize_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(FontName.SelectedItem != null)
				Chart1.Annotations[0].Font = new Font(FontName.SelectedItem.ToString(), float.Parse(FontSize.SelectedItem.ToString()));
		}

		private void FontColorCombo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Chart1.Annotations[0].ForeColor = Color.FromName(FontColorCombo.SelectedItem.ToString());
		}

		private void FontStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Chart1.Annotations[0].TextStyle = 
				(TextStyle)TextStyle.Parse(	typeof(TextStyle), FontStyle.SelectedItem.ToString());
		}

		private void BackColor_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Chart1.Annotations[0].BackColor = Color.FromName(AnnotationBackColor.SelectedItem.ToString());
		
		}

		private void Shadow_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Chart1.Annotations[0].ShadowOffset = int.Parse(Shadow.SelectedItem.ToString());
		
		}


	}
}
