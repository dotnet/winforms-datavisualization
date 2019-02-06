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
	public class UsingMarkers : System.Windows.Forms.UserControl
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
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox ApplyToPoint;
		private System.Windows.Forms.ComboBox Shape;
		private System.Windows.Forms.ComboBox MarkerSize;
		private System.Windows.Forms.ComboBox MarkerColor;
		private System.Windows.Forms.ComboBox MarkerBorderColor;
		private System.Windows.Forms.Label label12;
		#endregion
		private System.Windows.Forms.NumericUpDown MarkerBorderWidth;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public UsingMarkers()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize Combo Boxes
			this.Shape.SelectedIndex = 0;
			this.MarkerSize.SelectedIndex = 0;
			this.MarkerColor.SelectedIndex = 0;
			this.MarkerBorderColor.SelectedIndex = 1;
			this.MarkerBorderWidth.Value = 1;
			this.ApplyToPoint.Checked = true;			
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MarkerBorderWidth = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.MarkerBorderColor = new System.Windows.Forms.ComboBox();
            this.MarkerColor = new System.Windows.Forms.ComboBox();
            this.MarkerSize = new System.Windows.Forms.ComboBox();
            this.Shape = new System.Windows.Forms.ComboBox();
            this.ApplyToPoint = new System.Windows.Forms.CheckBox();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarkerBorderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 43);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample shows how to set marker appearance properties. Note that these proper" +
                "ties can be applied to all data points in a series or to a single data point.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MarkerBorderWidth);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.MarkerBorderColor);
            this.panel1.Controls.Add(this.MarkerColor);
            this.panel1.Controls.Add(this.MarkerSize);
            this.panel1.Controls.Add(this.Shape);
            this.panel1.Controls.Add(this.ApplyToPoint);
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
            this.panel1.Location = new System.Drawing.Point(432, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 296);
            this.panel1.TabIndex = 2;
            // 
            // MarkerBorderWidth
            // 
            this.MarkerBorderWidth.Location = new System.Drawing.Point(168, 136);
            this.MarkerBorderWidth.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MarkerBorderWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MarkerBorderWidth.Name = "MarkerBorderWidth";
            this.MarkerBorderWidth.Size = new System.Drawing.Size(72, 22);
            this.MarkerBorderWidth.TabIndex = 14;
            this.MarkerBorderWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MarkerBorderWidth.ValueChanged += new System.EventHandler(this.MarkerBorderWidth_ValueChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(9, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "Marker Border &Width:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MarkerBorderColor
            // 
            this.MarkerBorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarkerBorderColor.Items.AddRange(new object[] {
            "White",
            "Blue",
            "Green",
            "Yellow",
            "Magenta",
            "Brown"});
            this.MarkerBorderColor.Location = new System.Drawing.Point(168, 104);
            this.MarkerBorderColor.Name = "MarkerBorderColor";
            this.MarkerBorderColor.Size = new System.Drawing.Size(121, 22);
            this.MarkerBorderColor.TabIndex = 7;
            this.MarkerBorderColor.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // MarkerColor
            // 
            this.MarkerColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarkerColor.Items.AddRange(new object[] {
            "White",
            "Blue",
            "Green",
            "Yellow",
            "Magenta",
            "Brown"});
            this.MarkerColor.Location = new System.Drawing.Point(168, 72);
            this.MarkerColor.Name = "MarkerColor";
            this.MarkerColor.Size = new System.Drawing.Size(121, 22);
            this.MarkerColor.TabIndex = 5;
            this.MarkerColor.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // MarkerSize
            // 
            this.MarkerSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarkerSize.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.MarkerSize.Location = new System.Drawing.Point(168, 40);
            this.MarkerSize.Name = "MarkerSize";
            this.MarkerSize.Size = new System.Drawing.Size(121, 22);
            this.MarkerSize.TabIndex = 3;
            this.MarkerSize.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // Shape
            // 
            this.Shape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Shape.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Diamond",
            "Triangle",
            "Cross",
            "Image",
            "Star10",
            "Star4",
            "Star5",
            "Star6"});
            this.Shape.Location = new System.Drawing.Point(168, 8);
            this.Shape.Name = "Shape";
            this.Shape.Size = new System.Drawing.Size(121, 22);
            this.Shape.TabIndex = 1;
            this.Shape.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // ApplyToPoint
            // 
            this.ApplyToPoint.Location = new System.Drawing.Point(32, 168);
            this.ApplyToPoint.Name = "ApplyToPoint";
            this.ApplyToPoint.Size = new System.Drawing.Size(232, 24);
            this.ApplyToPoint.TabIndex = 8;
            this.ApplyToPoint.Text = "&Apply to the Third Point Only";
            this.ApplyToPoint.CheckedChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(20, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "Marker &Border Color:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(20, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Marker &Color:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marker &Size:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marker &Shape:";
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
            this.label6.TabIndex = 12;
            this.label6.Text = "Border Size:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(64, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Border Color:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(64, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hatch Style:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(64, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 9;
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
            chartArea1.BackColor = System.Drawing.Color.OldLace;
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
            this.Chart1.Location = new System.Drawing.Point(16, 65);
            this.Chart1.Name = "Chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Default";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.ShadowOffset = 1;
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(412, 306);
            this.Chart1.TabIndex = 1;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Using Markers";
            this.Chart1.Titles.Add(title1);
            this.Chart1.Click += new System.EventHandler(this.Chart1_Click);
            // 
            // UsingMarkers
            // 
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UsingMarkers";
            this.Size = new System.Drawing.Size(728, 384);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarkerBorderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Chart1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void Marker()
		{
			if( 
				this.Shape.SelectedItem == null ||
				this.MarkerSize.SelectedItem == null ||
				this.MarkerColor.SelectedItem == null ||
				this.MarkerBorderColor.SelectedItem == null
			)
				return;

			// Using markers
			MainForm mainForm = (MainForm)this.ParentForm;

			if( mainForm == null )
				return;

			string fileNameString = mainForm.applicationPath + "\\Images\\Face.bmp";

			// Set Marker shape to image
			if(Shape.GetItemText(Shape.SelectedItem) == "Image")
			{
				if(!ApplyToPoint.Checked)
				{
					Chart1.Series["Default"].MarkerImage = fileNameString;
					Chart1.Series["Default"].MarkerImageTransparentColor = Color.White;

					Chart1.Series["Default"].Points[2].DeleteCustomProperty("MarkerImage");
				}
				else
				{
					// Series
					Chart1.Series["Default"].MarkerImage = "";
					
					// Point
					Chart1.Series["Default"].Points[2].MarkerImage = fileNameString;
					Chart1.Series["Default"].Points[2].MarkerImageTransparentColor = Color.White;
				}

				// Disable color and size controls
				MarkerSize.Enabled = false;
				MarkerColor.Enabled = false;
				MarkerBorderColor.Enabled = false;
				MarkerBorderWidth.Enabled = false;
			}

			// Set "bubble" series shape
			else
			{
				if(!ApplyToPoint.Checked)
				{
					// Disable images
					Chart1.Series["Default"].MarkerImage = "";

					Chart1.Series["Default"].MarkerStyle = (MarkerStyle)MarkerStyle.Parse(typeof(MarkerStyle), Shape.GetItemText(Shape.SelectedItem));

					// Disable images
					Chart1.Series["Default"].Points[2].DeleteCustomProperty("MarkerImage");

					Chart1.Series["Default"].Points[2].DeleteCustomProperty("MarkerStyle");
				}
				else
				{
					// Disable images
					Chart1.Series["Default"].MarkerImage = "";

					Chart1.Series["Default"].MarkerStyle = (MarkerStyle)MarkerStyle.Parse(typeof(MarkerStyle), "Circle");

					// Disable images
					Chart1.Series["Default"].Points[2].MarkerImage = "";

					Chart1.Series["Default"].Points[2].MarkerStyle = (MarkerStyle)MarkerStyle.Parse(typeof(MarkerStyle), Shape.GetItemText(Shape.SelectedItem));
				}
            
				// Enable color and size controls
				MarkerSize.Enabled = true;
				MarkerColor.Enabled = true;
				MarkerBorderColor.Enabled = true;
				MarkerBorderWidth.Enabled = true;
			}

            
			if(!ApplyToPoint.Checked)
			{
				Chart1.Series["Default"].MarkerSize = Int32.Parse(MarkerSize.GetItemText(MarkerSize.SelectedItem));
				Chart1.Series["Default"].MarkerColor = Color.FromName(MarkerColor.GetItemText(MarkerColor.SelectedItem));
				Chart1.Series["Default"].MarkerBorderColor = Color.FromName(MarkerBorderColor.GetItemText(MarkerBorderColor.SelectedItem));
				Chart1.Series["Default"].MarkerBorderWidth = Int32.Parse(MarkerBorderWidth.Value.ToString());

				// Point
				Chart1.Series["Default"].Points[2].DeleteCustomProperty("MarkerSize");
				Chart1.Series["Default"].Points[2].DeleteCustomProperty("MarkerColor");
				Chart1.Series["Default"].Points[2].DeleteCustomProperty("MarkerBorderColor");
								Chart1.Series["Default"].Points[2].DeleteCustomProperty("MarkerBorderWidth");
			}
			else
			{
				// Series
				Chart1.Series["Default"].MarkerSize = 5;
				Chart1.Series["Default"].MarkerColor = Color.White;
				Chart1.Series["Default"].MarkerBorderColor = Color.Blue;
				Chart1.Series["Default"].MarkerBorderWidth = 1;

				// Point
				Chart1.Series["Default"].Points[2].MarkerSize = Int32.Parse(MarkerSize.GetItemText(MarkerSize.SelectedItem));
				Chart1.Series["Default"].Points[2].MarkerColor = Color.FromName(MarkerColor.GetItemText(MarkerColor.SelectedItem));
				Chart1.Series["Default"].Points[2].MarkerBorderColor = Color.FromName(MarkerBorderColor.GetItemText(MarkerBorderColor.SelectedItem));
				Chart1.Series["Default"].Points[2].MarkerBorderWidth = Int32.Parse(MarkerBorderWidth.Value.ToString());
			}
		}

		private void Combo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Marker();
		}

		private void MarkerBorderWidth_ValueChanged(object sender, System.EventArgs e)
		{
			Marker();		
		}

	}
}
