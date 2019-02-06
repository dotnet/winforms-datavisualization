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
	/// Summary description for LegendCustomPosition.
	/// </summary>
	public class LegendCustomPosition : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown XEdit;
		private System.Windows.Forms.NumericUpDown YEdit;
		private System.Windows.Forms.NumericUpDown WidthEdit;
		private System.Windows.Forms.NumericUpDown HeightEdit;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private bool suppressChanges = false;

		public LegendCustomPosition()
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 600);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 400);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 200);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 560);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 300);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 550);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 580);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 300);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 425);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 400);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 500);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 500);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 350);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 300);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 520);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LegendCustomPosition));
            this.label9 = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeightEdit = new System.Windows.Forms.NumericUpDown();
            this.WidthEdit = new System.Windows.Forms.NumericUpDown();
            this.YEdit = new System.Windows.Forms.NumericUpDown();
            this.XEdit = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(702, 40);
            this.label9.TabIndex = 0;
            this.label9.Text = "This sample demonstrates how to position the legend by setting the coordinates of" +
                " its width and height, relative to the top left corner. ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 62.58395F;
            chartArea1.Position.Width = 88.77716F;
            chartArea1.Position.X = 5.089137F;
            chartArea1.Position.Y = 18.3307F;
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Default";
            legend1.Position.Auto = false;
            legend1.Position.Height = 9.511945F;
            legend1.Position.Width = 59F;
            legend1.Position.X = 6.966655F;
            legend1.Position.Y = 82.79218F;
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(16, 56);
            this.Chart1.Name = "Chart1";
            series1.ChartArea = "Default";
            series1.Legend = "Default";
            series1.Name = "Default";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "Default";
            series2.Legend = "Default";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series3.ChartArea = "Default";
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
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Legend Positioning";
            this.Chart1.Titles.Add(title1);
            this.Chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Chart1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HeightEdit);
            this.panel1.Controls.Add(this.WidthEdit);
            this.panel1.Controls.Add(this.YEdit);
            this.panel1.Controls.Add(this.XEdit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(432, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 296);
            this.panel1.TabIndex = 2;
            // 
            // HeightEdit
            // 
            this.HeightEdit.Location = new System.Drawing.Point(168, 104);
            this.HeightEdit.Name = "HeightEdit";
            this.HeightEdit.Size = new System.Drawing.Size(80, 22);
            this.HeightEdit.TabIndex = 7;
            this.HeightEdit.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.HeightEdit.ValueChanged += new System.EventHandler(this.Controls_ValueChanged);
            // 
            // WidthEdit
            // 
            this.WidthEdit.Location = new System.Drawing.Point(168, 72);
            this.WidthEdit.Name = "WidthEdit";
            this.WidthEdit.Size = new System.Drawing.Size(80, 22);
            this.WidthEdit.TabIndex = 5;
            this.WidthEdit.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.WidthEdit.ValueChanged += new System.EventHandler(this.Controls_ValueChanged);
            // 
            // YEdit
            // 
            this.YEdit.Location = new System.Drawing.Point(168, 40);
            this.YEdit.Name = "YEdit";
            this.YEdit.Size = new System.Drawing.Size(80, 22);
            this.YEdit.TabIndex = 3;
            this.YEdit.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.YEdit.ValueChanged += new System.EventHandler(this.Controls_ValueChanged);
            // 
            // XEdit
            // 
            this.XEdit.Location = new System.Drawing.Point(168, 8);
            this.XEdit.Name = "XEdit";
            this.XEdit.Size = new System.Drawing.Size(80, 22);
            this.XEdit.TabIndex = 1;
            this.XEdit.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.XEdit.ValueChanged += new System.EventHandler(this.Controls_ValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "&Height:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Width:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Y:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "&X:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LegendCustomPosition
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LegendCustomPosition";
            this.Size = new System.Drawing.Size(728, 480);
            this.Load += new System.EventHandler(this.LegendCustomPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HeightEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XEdit)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void LegendCustomPosition_Load(object sender, System.EventArgs e)
		{
			this.AdjustLegendControls();
		}

		private void Chart1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.X != 0 && e.Y != 0)
			{
                ElementPosition position = Chart1.Legends[0].Position;
				// Conver pixels to percentage coordinates and set legend position
                position.X = e.X * 100F / ((float)(Chart1.Size.Width - 1));
                position.Y = e.Y * 100F / ((float)(Chart1.Size.Height - 1)); 
	
				AdjustLegendControls();

				Chart1.Invalidate();
			}
		}

		private void AdjustLegendControls()
		{
			try
			{
				this.suppressChanges = true;

                ElementPosition position = Chart1.Legends[0].Position;

                if (position.X > 47)
                    position.Width = 60;

                if (position.Y > 91)
                    position.Height = 9;

                XEdit.Value = (decimal)position.X;
                YEdit.Value = (decimal)position.Y;
                WidthEdit.Value = (decimal)position.Width;
                HeightEdit.Value = (decimal)position.Height;
			}
			finally
			{
				this.suppressChanges = false;
			}
		}

		private void Controls_ValueChanged(object sender, System.EventArgs e)
		{
			if ( this.suppressChanges )
			{
				return;
			}

            ElementPosition position = Chart1.Legends[0].Position;
            position.X = (float)XEdit.Value;
            position.Y = (float)YEdit.Value;
            position.Width = (float)WidthEdit.Value;
            position.Height = (float)HeightEdit.Value;

			this.AdjustLegendControls();

			Chart1.Invalidate();

		}

//		private void Edit_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
//		{
//			if((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == 46 )
//			{
//				string editText = ((TextBox)(sender)).Text;
//				if(e.KeyChar != 8)
//				{
//					TextBox textBox = (TextBox)sender;
//					int selStart = textBox.SelectionStart;
//					int selLength = textBox.SelectionLength;
//	
//					if(selLength > 0)
//					{
//						editText = editText.Remove(selStart, selLength);
//						textBox.Text = editText;
//						textBox.SelectionLength = 0;
//						textBox.SelectionStart = selStart;
//					}
//
//
//					editText = editText.Insert(selStart,e.KeyChar.ToString());
//
//					try
//					{
//						double newValue = double.Parse(editText);
//						if(newValue <= 100 && newValue >= 0)
//						{
//							e.Handled = false;
//						}
//						else
//							e.Handled = true;
//					}
//					catch(Exception )
//					{
//						e.Handled = true;
//					}
//				}
//				else
//					e.Handled = false;
//			}
//			else
//			{
//				e.Handled = true;
//			}
//		
//		}
//
//		private void XEdit_TextChanged(object sender, System.EventArgs e)
//		{
//			if(XEdit.Text != "")
//				Chart1.Legends[0].Position.X = float.Parse(XEdit.Text);
//			else
//				Chart1.Legends[0].Position.X = 0;
//
//			AdjustLegendControls();
//		}
//
//		private void YEdit_TextChanged(object sender, System.EventArgs e)
//		{
//			if(YEdit.Text != "")
//				Chart1.Legends[0].Position.Y = float.Parse(YEdit.Text);
//			else
//				Chart1.Legends[0].Position.Y = 0;
//
//			AdjustLegendControls();
//		}
//
//		private void WidthEdit_TextChanged(object sender, System.EventArgs e)
//		{
//			if(WidthEdit.Text != "")
//				Chart1.Legends[0].Position.Width = float.Parse(WidthEdit.Text);
//			else
//				Chart1.Legends[0].Position.Width = 21;
//
//			AdjustLegendControls();
//		}
//
//		private void HeightEdit_TextChanged(object sender, System.EventArgs e)
//		{
//			if(HeightEdit.Text != "")
//				Chart1.Legends[0].Position.Height = float.Parse(HeightEdit.Text);
//			else
//				Chart1.Legends[0].Position.Height = 9;
//
//			AdjustLegendControls();
//		}

	}
}
