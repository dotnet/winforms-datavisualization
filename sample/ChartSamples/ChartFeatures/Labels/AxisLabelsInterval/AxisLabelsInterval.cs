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
	public class AxisLabelsInterval : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox PointsNumberList;
		private System.Windows.Forms.ComboBox XAxisIntervalList;
		private System.Windows.Forms.ComboBox YAxisIntervalList;
		private System.Windows.Forms.Label label8;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AxisLabelsInterval()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize combo boxes
			PointsNumberList.SelectedIndex = 0;
			XAxisIntervalList.SelectedIndex = 0;
			YAxisIntervalList.SelectedIndex = 0;
			
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
            this.YAxisIntervalList = new System.Windows.Forms.ComboBox();
            this.XAxisIntervalList = new System.Windows.Forms.ComboBox();
            this.PointsNumberList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.label9.Text = "This sample demonstrates how to set axis interval properties, which are applied t" +
                "o the axis\' labels, major grid lines, and tick marks. ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.YAxisIntervalList);
            this.panel1.Controls.Add(this.XAxisIntervalList);
            this.panel1.Controls.Add(this.PointsNumberList);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(432, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 288);
            this.panel1.TabIndex = 2;
            // 
            // YAxisIntervalList
            // 
            this.YAxisIntervalList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YAxisIntervalList.Items.AddRange(new object[] {
            "Auto",
            "100",
            "200",
            "250",
            "500"});
            this.YAxisIntervalList.Location = new System.Drawing.Point(168, 40);
            this.YAxisIntervalList.Name = "YAxisIntervalList";
            this.YAxisIntervalList.Size = new System.Drawing.Size(124, 22);
            this.YAxisIntervalList.TabIndex = 3;
            this.YAxisIntervalList.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // XAxisIntervalList
            // 
            this.XAxisIntervalList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XAxisIntervalList.Items.AddRange(new object[] {
            "Auto",
            "Every Week (Starting Sunday)",
            "Every Week (Starting Monday)",
            "Every 2 Weeks",
            "Every Month (Starting at 1st)",
            "Every Month (Starting at 15th)"});
            this.XAxisIntervalList.Location = new System.Drawing.Point(74, 104);
            this.XAxisIntervalList.Name = "XAxisIntervalList";
            this.XAxisIntervalList.Size = new System.Drawing.Size(216, 22);
            this.XAxisIntervalList.TabIndex = 5;
            this.XAxisIntervalList.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // PointsNumberList
            // 
            this.PointsNumberList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PointsNumberList.Items.AddRange(new object[] {
            "30",
            "50",
            "70"});
            this.PointsNumberList.Location = new System.Drawing.Point(168, 8);
            this.PointsNumberList.Name = "PointsNumberList";
            this.PointsNumberList.Size = new System.Drawing.Size(124, 22);
            this.PointsNumberList.TabIndex = 1;
            this.PointsNumberList.SelectedIndexChanged += new System.EventHandler(this.PointsNumberList_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "&Y Axis Interval:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "&X Axis Interval:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of &Days:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(64, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Border Size:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(64, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Border Color:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(64, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hatch Style:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(64, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
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
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "dd MMM";
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 82F;
            chartArea1.InnerPlotPosition.Width = 84.7138F;
            chartArea1.InnerPlotPosition.X = 8.2422F;
            chartArea1.InnerPlotPosition.Y = 2.99507F;
            chartArea1.Name = "Default";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 87.64407F;
            chartArea1.Position.Width = 89.43796F;
            chartArea1.Position.X = 4.824818F;
            chartArea1.Position.Y = 5.542373F;
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
            series1.ChartArea = "Default";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.CustomProperties = "DrawingStyle=Emboss, PointWidth=0.9";
            series1.Legend = "Default";
            series1.Name = "Series1";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(412, 296);
            this.Chart1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(702, 40);
            this.label8.TabIndex = 3;
            this.label8.Text = "Major and minor grid lines, tick marks, and label objects of an axis also have th" +
                "eir own interval related properties, which take precedence over the axis propert" +
                "ies.";
            // 
            // AxisLabelsInterval
            // 
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AxisLabelsInterval";
            this.Size = new System.Drawing.Size(728, 480);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		/// <summary>
		/// Sets interval properties for the axis. 
		/// Note that we use the Axis object's interval properties, and not the properties of its label,
		/// and major tick mark and grid line objects
		/// </summary>
		public void SetAxisInterval(Axis axis, double interval, DateTimeIntervalType intervalType)
		{
			SetAxisInterval(axis, interval, intervalType, 0, DateTimeIntervalType.Auto);
		}

		private void PointsNumberList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Populate series data
			Random		random = new Random();
			DateTime	dateCurrent = DateTime.Now.Date;
			Chart1.Series["Series1"].Points.Clear();
			for(int pointIndex = 0; pointIndex < int.Parse(PointsNumberList.GetItemText(PointsNumberList.SelectedItem)); pointIndex++)
			{
				Chart1.Series["Series1"].Points.AddXY(dateCurrent.AddDays(pointIndex), random.Next(100, 1000));
			}
			Chart1.Invalidate();
		}

		private void Combo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Intervals();
		}
		

		private void Intervals()
		{

			if( 
				PointsNumberList.SelectedItem == null ||
				XAxisIntervalList.SelectedItem == null ||
				YAxisIntervalList.SelectedItem == null
			)
			{
				return;
			}
			
			Chart1.BackColor = Color.White;

			// Set interval and interval type for the Y axis
			if(YAxisIntervalList.GetItemText(YAxisIntervalList.SelectedItem) != "Auto")
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisY, double.Parse(YAxisIntervalList.GetItemText(YAxisIntervalList.SelectedItem)), DateTimeIntervalType.Number);
			}
			else
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisY, Double.NaN, DateTimeIntervalType.Auto, Double.NaN, DateTimeIntervalType.Auto);
			}

			// Set interval and interval type for the X axis
			if(XAxisIntervalList.GetItemText(XAxisIntervalList.SelectedItem) == "Every Week (Starting Sunday)")
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisX, 1, DateTimeIntervalType.Weeks);
			}
			else if(XAxisIntervalList.GetItemText(XAxisIntervalList.SelectedItem) == "Every Week (Starting Monday)")
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisX, 1, DateTimeIntervalType.Weeks, 1, DateTimeIntervalType.Days);
			}
			else if(XAxisIntervalList.GetItemText(XAxisIntervalList.SelectedItem) == "Every 2 Weeks")
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisX, 2, DateTimeIntervalType.Weeks);
			}
			else if(XAxisIntervalList.GetItemText(XAxisIntervalList.SelectedItem) == "Every Month (Starting at 1st)")
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisX, 1, DateTimeIntervalType.Months);
			}
			else if(XAxisIntervalList.GetItemText(XAxisIntervalList.SelectedItem) == "Every Month (Starting at 15th)")
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisX, 1, DateTimeIntervalType.Months, 14, DateTimeIntervalType.Days);
			}
			else if(XAxisIntervalList.GetItemText(XAxisIntervalList.SelectedItem) == "Auto")
			{
				SetAxisInterval(Chart1.ChartAreas["Default"].AxisX, Double.NaN, DateTimeIntervalType.Auto, Double.NaN, DateTimeIntervalType.Auto);
			}

		}

		/// <summary>
		/// Sets interval properties for the axis. 
		/// Note that we use the Axis object's interval properties, and not the properties of its label,
		/// and major tick mark and grid line objects
		/// </summary>
		public void SetAxisInterval(Axis axis, double interval, DateTimeIntervalType intervalType, double intervalOffset, DateTimeIntervalType intervalOffsetType )
		{
			// Set interval-related properties
			axis.Interval = interval;
			axis.IntervalType = intervalType;
			axis.IntervalOffset = intervalOffset;
			axis.IntervalOffsetType = intervalOffsetType;
		}

		
	}
}
