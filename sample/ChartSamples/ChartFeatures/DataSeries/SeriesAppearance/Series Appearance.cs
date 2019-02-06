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
	public class SeriesAppearance : System.Windows.Forms.UserControl
	{

		private System.IO.MemoryStream defaultChartView = new System.IO.MemoryStream();
		private bool initializing = true;

		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox ColorCom;
		private System.Windows.Forms.ComboBox EndColorCom;
		private System.Windows.Forms.ComboBox GradientCom;
		private System.Windows.Forms.ComboBox HatchingCom;
		private System.Windows.Forms.ComboBox BorderColorCom;
		private System.Windows.Forms.ComboBox BorderSizeCom;
		private System.Windows.Forms.ComboBox BorderDashStyleCom;
		private System.Windows.Forms.ComboBox ShadowOffset;
		private System.Windows.Forms.CheckBox ThirdPoint;
		private System.Windows.Forms.Label label17;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SeriesAppearance()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			Chart1.Serializer.SerializableContent = "*.*";
			Chart1.Serializer.NonSerializableContent = "*.Size";

			// Add Hatch styles to control.
			foreach(string colorName in Enum.GetNames(typeof(ChartHatchStyle)))
			{
				HatchingCom.Items.Add(colorName);
			}
		
			// Add Chart Gradient types to control.
			foreach(string colorName in Enum.GetNames(typeof(GradientStyle)))
			{
				GradientCom.Items.Add(colorName);
			}

			// Add Chart Line styles to control.
			foreach(string colorName in Enum.GetNames(typeof(ChartDashStyle)))
			{
				BorderDashStyleCom.Items.Add(colorName);
			}

			HatchingCom.SelectedIndex = 0;
			GradientCom.SelectedIndex = 7;
			ColorCom.SelectedIndex = 0;
			EndColorCom.SelectedIndex = 2;
			BorderColorCom.SelectedIndex = 6;
			BorderSizeCom.SelectedIndex = 1;
			BorderDashStyleCom.SelectedIndex = 5;
			ShadowOffset.SelectedIndex = 0;
			ThirdPoint.Checked = false;

			this.initializing = false;
			this.AppearanceChange();
			
			// save current settings as default
			Chart1.Serializer.Save( defaultChartView );

		}

		private void AppearanceChange()
		{
			
			// suppress appearance settings during loading
			if ( this.initializing )
			{
				return;
			}

			// load default chart settings
			if ( defaultChartView.Length > 0) 
			{
				defaultChartView.Position = 0;
				Chart1.Serializer.Load( defaultChartView );
			}

			// Set Back Color
			Chart1.Series[0].Points[2].Color = Color.FromName(ColorCom.GetItemText(ColorCom.SelectedItem));

			// Set Back Gradient End Color
			Chart1.Series[0].Points[2].BackSecondaryColor = Color.FromName(EndColorCom.GetItemText(EndColorCom.SelectedItem));

			// Set Border Color
			Chart1.Series[0].Points[2].BorderColor = Color.FromName(BorderColorCom.GetItemText(BorderColorCom.SelectedItem));

			// Set Gradient Type
			if( GradientCom.SelectedItem != null )
				Chart1.Series[0].Points[2].BackGradientStyle = (GradientStyle)GradientStyle.Parse(typeof(GradientStyle), GradientCom.GetItemText(GradientCom.SelectedItem));

			// Set Gradient Type
			if( HatchingCom.SelectedItem != null )
				Chart1.Series[0].Points[2].BackHatchStyle = (ChartHatchStyle)ChartHatchStyle.Parse(typeof(ChartHatchStyle), HatchingCom.GetItemText(HatchingCom.SelectedItem));

			// Set Border Width
			if( BorderSizeCom.SelectedItem != null )
				Chart1.Series[0].Points[2].BorderWidth = int.Parse(BorderSizeCom.GetItemText(BorderSizeCom.SelectedItem));

			// Set Border Style
			if( BorderDashStyleCom.SelectedItem != null )
				Chart1.Series[0].Points[2].BorderDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), BorderDashStyleCom.GetItemText(BorderDashStyleCom.SelectedItem));

			if( !this.ThirdPoint.Checked )
			{
				
				// Set Back Color
				Chart1.Series[0].Color = Color.FromName(ColorCom.GetItemText(ColorCom.SelectedItem));

				// Set Back Gradient End Color
				Chart1.Series[0].BackSecondaryColor = Color.FromName(EndColorCom.GetItemText(EndColorCom.SelectedItem));

				// Set Border Color
				Chart1.Series[0].BorderColor = Color.FromName(BorderColorCom.GetItemText(BorderColorCom.SelectedItem));

				// Set Gradient Type
				if( GradientCom.SelectedItem != null )
					Chart1.Series[0].BackGradientStyle = (GradientStyle)GradientStyle.Parse(typeof(GradientStyle), GradientCom.GetItemText(GradientCom.SelectedItem));

				// Set Gradient Type
				if( HatchingCom.SelectedItem != null )
					Chart1.Series[0].BackHatchStyle = (ChartHatchStyle)ChartHatchStyle.Parse(typeof(ChartHatchStyle), HatchingCom.GetItemText(HatchingCom.SelectedItem));

				// Set Border Width
				if( BorderSizeCom.SelectedItem != null )
					Chart1.Series[0].BorderWidth = int.Parse(BorderSizeCom.GetItemText(BorderSizeCom.SelectedItem));

				// Set Border Style
				if( BorderDashStyleCom.SelectedItem != null )
					Chart1.Series[0].BorderDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), BorderDashStyleCom.GetItemText(BorderDashStyleCom.SelectedItem));

				// Set Shadow Offset
				if( ShadowOffset.SelectedItem != null )
					Chart1.Series[0].ShadowOffset = int.Parse(ShadowOffset.GetItemText(ShadowOffset.SelectedItem));
			}
			
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeriesAppearance));
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ThirdPoint = new System.Windows.Forms.CheckBox();
            this.ShadowOffset = new System.Windows.Forms.ComboBox();
            this.BorderDashStyleCom = new System.Windows.Forms.ComboBox();
            this.BorderSizeCom = new System.Windows.Forms.ComboBox();
            this.BorderColorCom = new System.Windows.Forms.ComboBox();
            this.HatchingCom = new System.Windows.Forms.ComboBox();
            this.GradientCom = new System.Windows.Forms.ComboBox();
            this.EndColorCom = new System.Windows.Forms.ComboBox();
            this.ColorCom = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to set the visual appearance of a series.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ThirdPoint);
            this.panel1.Controls.Add(this.ShadowOffset);
            this.panel1.Controls.Add(this.BorderDashStyleCom);
            this.panel1.Controls.Add(this.BorderSizeCom);
            this.panel1.Controls.Add(this.BorderColorCom);
            this.panel1.Controls.Add(this.HatchingCom);
            this.panel1.Controls.Add(this.GradientCom);
            this.panel1.Controls.Add(this.EndColorCom);
            this.panel1.Controls.Add(this.ColorCom);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 300);
            this.panel1.TabIndex = 2;
            // 
            // ThirdPoint
            // 
            this.ThirdPoint.Location = new System.Drawing.Point(68, 232);
            this.ThirdPoint.Name = "ThirdPoint";
            this.ThirdPoint.Size = new System.Drawing.Size(220, 32);
            this.ThirdPoint.TabIndex = 16;
            this.ThirdPoint.Text = "&Apply to the Third  Point Only";
            this.ThirdPoint.CheckedChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // ShadowOffset
            // 
            this.ShadowOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShadowOffset.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.ShadowOffset.Location = new System.Drawing.Point(168, 192);
            this.ShadowOffset.Name = "ShadowOffset";
            this.ShadowOffset.Size = new System.Drawing.Size(121, 22);
            this.ShadowOffset.TabIndex = 15;
            this.ShadowOffset.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // BorderDashStyleCom
            // 
            this.BorderDashStyleCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorderDashStyleCom.Location = new System.Drawing.Point(168, 168);
            this.BorderDashStyleCom.Name = "BorderDashStyleCom";
            this.BorderDashStyleCom.Size = new System.Drawing.Size(121, 22);
            this.BorderDashStyleCom.TabIndex = 13;
            this.BorderDashStyleCom.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // BorderSizeCom
            // 
            this.BorderSizeCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorderSizeCom.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.BorderSizeCom.Location = new System.Drawing.Point(168, 144);
            this.BorderSizeCom.Name = "BorderSizeCom";
            this.BorderSizeCom.Size = new System.Drawing.Size(121, 22);
            this.BorderSizeCom.TabIndex = 11;
            this.BorderSizeCom.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // BorderColorCom
            // 
            this.BorderColorCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorderColorCom.Items.AddRange(new object[] {
            "MediumSeaGreen",
            "Blue",
            "White",
            "Red",
            "Yellow",
            "Green",
            "Gray"});
            this.BorderColorCom.Location = new System.Drawing.Point(168, 120);
            this.BorderColorCom.Name = "BorderColorCom";
            this.BorderColorCom.Size = new System.Drawing.Size(121, 22);
            this.BorderColorCom.TabIndex = 9;
            this.BorderColorCom.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // HatchingCom
            // 
            this.HatchingCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HatchingCom.Location = new System.Drawing.Point(168, 80);
            this.HatchingCom.Name = "HatchingCom";
            this.HatchingCom.Size = new System.Drawing.Size(121, 22);
            this.HatchingCom.TabIndex = 7;
            this.HatchingCom.SelectedIndexChanged += new System.EventHandler(this.HatchingCom_SelectedIndexChanged);
            // 
            // GradientCom
            // 
            this.GradientCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GradientCom.Location = new System.Drawing.Point(168, 55);
            this.GradientCom.Name = "GradientCom";
            this.GradientCom.Size = new System.Drawing.Size(121, 22);
            this.GradientCom.TabIndex = 5;
            this.GradientCom.SelectedIndexChanged += new System.EventHandler(this.GradientCom_SelectedIndexChanged);
            // 
            // EndColorCom
            // 
            this.EndColorCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndColorCom.Items.AddRange(new object[] {
            "Tomato",
            "Navy",
            "SkyBlue"});
            this.EndColorCom.Location = new System.Drawing.Point(168, 29);
            this.EndColorCom.Name = "EndColorCom";
            this.EndColorCom.Size = new System.Drawing.Size(121, 22);
            this.EndColorCom.TabIndex = 3;
            this.EndColorCom.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // ColorCom
            // 
            this.ColorCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorCom.Items.AddRange(new object[] {
            "RoyalBlue",
            "Red",
            "Brown"});
            this.ColorCom.Location = new System.Drawing.Point(168, 4);
            this.ColorCom.Name = "ColorCom";
            this.ColorCom.Size = new System.Drawing.Size(121, 22);
            this.ColorCom.TabIndex = 1;
            this.ColorCom.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(26, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 23);
            this.label16.TabIndex = 6;
            this.label16.Text = "&Hatching:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(28, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 21);
            this.label14.TabIndex = 14;
            this.label14.Text = "Shadow &Offset:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(26, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 23);
            this.label13.TabIndex = 12;
            this.label13.Text = "Border St&yle:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(26, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 23);
            this.label12.TabIndex = 10;
            this.label12.Text = "Border &Size:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(26, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "&Border Color:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(26, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "&Gradient:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "&End Color:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Color:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            series1.Legend = "Default";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(412, 306);
            this.Chart1.TabIndex = 1;
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Chart Control for .NET Framework";
            this.Chart1.Titles.Add(title1);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 372);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(702, 60);
            this.label17.TabIndex = 20;
            this.label17.Text = resources.GetString("label17.Text");
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SeriesAppearance
            // 
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SeriesAppearance";
            this.Size = new System.Drawing.Size(728, 480);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void Combo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			AppearanceChange();		
		}

		private void HatchingCom_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Disable fore color control if gradient or hatching are not used
			if( HatchingCom.SelectedIndex != 0 )
			{
				GradientCom.Enabled = false;
				EndColorCom.Enabled = true;
			}
			else
			{
				GradientCom.Enabled = true;
				if( GradientCom.SelectedIndex != 0 )
					EndColorCom.Enabled = true;
				else
					EndColorCom.Enabled = false;
			}

			AppearanceChange();	
		}

		private void GradientCom_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Disable fore color control if gradient or hatching are not used
			if( GradientCom.SelectedIndex != 0 )
			{
				EndColorCom.Enabled = true;
			}
			else
			{
				EndColorCom.Enabled = false;
			}

			AppearanceChange();	
		
		}

		private void label12_Click(object sender, System.EventArgs e)
		{
		
		}

	}
}
