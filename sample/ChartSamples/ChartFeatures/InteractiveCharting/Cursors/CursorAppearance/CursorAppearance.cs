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
	/// Summary description for CursorAppearance.
	/// </summary>
	public class CursorAppearance : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox SelectionColor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox XLineDashStyle;
		private System.Windows.Forms.ComboBox XLineSize;
		private System.Windows.Forms.ComboBox XLineColor;
		private System.Windows.Forms.ComboBox YLineDashStyle;
		private System.Windows.Forms.ComboBox YLineSize;
		private System.Windows.Forms.ComboBox YLineColor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CursorAppearance()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.YLineDashStyle = new System.Windows.Forms.ComboBox();
            this.YLineSize = new System.Windows.Forms.ComboBox();
            this.YLineColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectionColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.XLineDashStyle = new System.Windows.Forms.ComboBox();
            this.XLineSize = new System.Windows.Forms.ComboBox();
            this.XLineColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
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
            this.label9.Size = new System.Drawing.Size(702, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to set the appearance properties of axis cursors.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.YLineDashStyle);
            this.panel1.Controls.Add(this.YLineSize);
            this.panel1.Controls.Add(this.YLineColor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SelectionColor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.XLineDashStyle);
            this.panel1.Controls.Add(this.XLineSize);
            this.panel1.Controls.Add(this.XLineColor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 0;
            // 
            // YLineDashStyle
            // 
            this.YLineDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YLineDashStyle.Location = new System.Drawing.Point(168, 184);
            this.YLineDashStyle.Name = "YLineDashStyle";
            this.YLineDashStyle.Size = new System.Drawing.Size(120, 22);
            this.YLineDashStyle.TabIndex = 16;
            this.YLineDashStyle.SelectedIndexChanged += new System.EventHandler(this.YControl_SelectedIndexChanged);
            // 
            // YLineSize
            // 
            this.YLineSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YLineSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.YLineSize.Location = new System.Drawing.Point(168, 152);
            this.YLineSize.Name = "YLineSize";
            this.YLineSize.Size = new System.Drawing.Size(120, 22);
            this.YLineSize.TabIndex = 14;
            this.YLineSize.SelectedIndexChanged += new System.EventHandler(this.YControl_SelectedIndexChanged);
            // 
            // YLineColor
            // 
            this.YLineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YLineColor.Items.AddRange(new object[] {
            ""});
            this.YLineColor.Location = new System.Drawing.Point(168, 120);
            this.YLineColor.Name = "YLineColor";
            this.YLineColor.Size = new System.Drawing.Size(120, 22);
            this.YLineColor.TabIndex = 12;
            this.YLineColor.SelectedIndexChanged += new System.EventHandler(this.YControl_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Y Cursor Line Sty&le:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Y Cursor Line S&ize:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y Cursor Line C&olor:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SelectionColor
            // 
            this.SelectionColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectionColor.Items.AddRange(new object[] {
            ""});
            this.SelectionColor.Location = new System.Drawing.Point(168, 232);
            this.SelectionColor.Name = "SelectionColor";
            this.SelectionColor.Size = new System.Drawing.Size(120, 22);
            this.SelectionColor.TabIndex = 10;
            this.SelectionColor.SelectedIndexChanged += new System.EventHandler(this.SelectionColor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selection C&olor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // XLineDashStyle
            // 
            this.XLineDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XLineDashStyle.Location = new System.Drawing.Point(168, 72);
            this.XLineDashStyle.Name = "XLineDashStyle";
            this.XLineDashStyle.Size = new System.Drawing.Size(120, 22);
            this.XLineDashStyle.TabIndex = 7;
            this.XLineDashStyle.SelectedIndexChanged += new System.EventHandler(this.XControl_SelectedIndexChanged);
            // 
            // XLineSize
            // 
            this.XLineSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XLineSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.XLineSize.Location = new System.Drawing.Point(168, 40);
            this.XLineSize.Name = "XLineSize";
            this.XLineSize.Size = new System.Drawing.Size(120, 22);
            this.XLineSize.TabIndex = 5;
            this.XLineSize.SelectedIndexChanged += new System.EventHandler(this.XControl_SelectedIndexChanged);
            // 
            // XLineColor
            // 
            this.XLineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XLineColor.Items.AddRange(new object[] {
            ""});
            this.XLineColor.Location = new System.Drawing.Point(168, 8);
            this.XLineColor.Name = "XLineColor";
            this.XLineColor.Size = new System.Drawing.Size(120, 22);
            this.XLineColor.TabIndex = 3;
            this.XLineColor.SelectedIndexChanged += new System.EventHandler(this.XControl_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "X Cursor Line St&yle:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(24, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "X Cursor Line &Size:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(24, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "X Cursor Line &Color:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.AliceBlue;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.ScrollBar.BackColor = System.Drawing.Color.AliceBlue;
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.SelectionColor = System.Drawing.SystemColors.Highlight;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.CursorY.SelectionColor = System.Drawing.SystemColors.Highlight;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 75F;
            chartArea1.InnerPlotPosition.Width = 86.32634F;
            chartArea1.InnerPlotPosition.X = 11.21863F;
            chartArea1.InnerPlotPosition.Y = 3.96004F;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 85F;
            chartArea1.Position.Width = 81.46518F;
            chartArea1.Position.X = 9.267409F;
            chartArea1.Position.Y = 10F;
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
            series1.BorderWidth = 2;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.ShadowOffset = 1;
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(702, 48);
            this.label11.TabIndex = 3;
            this.label11.Text = "Each axis has its own associated cursor. If selection is enabled, the user can se" +
                "lect and zoom in on the data view by left-clicking and dragging the mouse.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CursorAppearance
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CursorAppearance";
            this.Size = new System.Drawing.Size(728, 427);
            this.Load += new System.EventHandler(this.CursorAppearance_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void CursorAppearance_Load(object sender, System.EventArgs e)
		{
			
			foreach(string lineName in Enum.GetNames(typeof(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)))
			{
				this.XLineDashStyle.Items.Add(lineName);
				this.YLineDashStyle.Items.Add(lineName);
			}
			this.XLineDashStyle.SelectedIndex = 5;
			this.YLineDashStyle.SelectedIndex = 5;

			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				this.XLineColor.Items.Add(colorName);
				this.YLineColor.Items.Add(colorName);
				this.SelectionColor.Items.Add(colorName);
			}
			
			this.XLineSize.SelectedIndex = 0;
			this.XLineColor.SelectedIndex = this.XLineColor.Items.IndexOf("Black");

			this.YLineSize.SelectedIndex = 0;
			this.YLineColor.SelectedIndex = this.XLineColor.Items.IndexOf("Black");
			

			this.SelectionColor.SelectedIndex = this.XLineColor.Items.IndexOf("Highlight");

            Axis axisX = Chart1.ChartAreas["Default"].AxisX;

            CustomLabel label = null;

            label = axisX.CustomLabels.Add(Math.PI - Math.PI / 5, Math.PI + Math.PI / 5, "pi");
			label.GridTicks = GridTickTypes.All;

            label = axisX.CustomLabels.Add(2 * Math.PI - Math.PI / 5, 2 * Math.PI + Math.PI / 5, "2pi");
            label.GridTicks = GridTickTypes.All;

            label = axisX.CustomLabels.Add(3 * Math.PI - Math.PI / 5, 3 * Math.PI + Math.PI / 5, "3pi");
            label.GridTicks = GridTickTypes.All;


			double t;
			for(t = 0; t <= (7 * Math.PI / 2); t += Math.PI/6)
			{
				double ch1 = Math.Sin(t);
				Chart1.Series["Default"].Points.AddXY(t, ch1);
			}

			Chart1.ChartAreas["Default"].CursorX.Position = Math.PI / 2;
			Chart1.ChartAreas["Default"].CursorY.Position = -1.0;


		}
		


		private void XControl_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DataVisualization.Charting.Cursor cursor = Chart1.ChartAreas["Default"].CursorX;
		
			if(XLineSize.SelectedIndex >= 0)
			{
				cursor.LineWidth = int.Parse(XLineSize.SelectedItem.ToString());
			}
			if(XLineDashStyle.SelectedIndex >= 0)
			{
				cursor.LineDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), XLineDashStyle.SelectedItem.ToString());
			}
			if(XLineColor.SelectedIndex >= 0)
			{
				cursor.LineColor = Color.FromName(XLineColor.SelectedItem.ToString());
			}
		}

		private void YControl_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DataVisualization.Charting.Cursor cursor = Chart1.ChartAreas["Default"].CursorY;
		
			if(YLineSize.SelectedIndex >= 0)
			{
				cursor.LineWidth = int.Parse(YLineSize.SelectedItem.ToString());
			}
			if(YLineDashStyle.SelectedIndex >= 0)
			{
				cursor.LineDashStyle = (ChartDashStyle)ChartDashStyle.Parse(typeof(ChartDashStyle), YLineDashStyle.SelectedItem.ToString());
			}
			if(YLineColor.SelectedIndex >= 0)
			{
				cursor.LineColor = Color.FromName(YLineColor.SelectedItem.ToString());
			}
		}

		private void SelectionColor_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(SelectionColor.SelectedIndex >= 0)
			{
				Chart1.ChartAreas["Default"].CursorX.SelectionColor = Color.FromName(SelectionColor.SelectedItem.ToString());	
				Chart1.ChartAreas["Default"].CursorY.SelectionColor = Color.FromName(SelectionColor.SelectedItem.ToString());	
			}
		
		}

	
	}
}
