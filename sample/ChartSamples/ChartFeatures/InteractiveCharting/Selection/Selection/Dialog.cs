using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Dialog : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		internal System.Windows.Forms.DataVisualization.Charting.Chart ChartRef;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox YValue;
		private System.Windows.Forms.ComboBox MarkerBorderColor;
		private System.Windows.Forms.ComboBox BorderColor;
		private System.Windows.Forms.ComboBox MarkerColor;
		private System.Windows.Forms.TextBox Label;
        private System.Windows.Forms.ComboBox PointColor;
		internal int pointIndex;

		public Dialog()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Add Colors to controls.
			foreach(String colorName in KnownColor.GetNames(typeof(KnownColor)))
			{
				this.PointColor.Items.Add(colorName);
				this.MarkerColor.Items.Add(colorName);
				this.MarkerBorderColor.Items.Add(colorName);
				this.BorderColor.Items.Add(colorName);
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.YValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MarkerBorderColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.TextBox();
            this.MarkerColor = new System.Windows.Forms.ComboBox();
            this.BorderColor = new System.Windows.Forms.ComboBox();
            this.PointColor = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // YValue
            // 
            this.YValue.Location = new System.Drawing.Point(208, 8);
            this.YValue.Name = "YValue";
            this.YValue.Size = new System.Drawing.Size(152, 20);
            this.YValue.TabIndex = 0;
            this.YValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YValue_KeyPress);
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Y Value:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MarkerBorderColor
            // 
            this.MarkerBorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarkerBorderColor.Location = new System.Drawing.Point(208, 158);
            this.MarkerBorderColor.Name = "MarkerBorderColor";
            this.MarkerBorderColor.Size = new System.Drawing.Size(152, 21);
            this.MarkerBorderColor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Point Color:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Point Border Color:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(8, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data Point Label:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(8, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data Point Marker Color:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(8, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data Point Marker Border Color:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Label);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.MarkerColor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BorderColor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PointColor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.YValue);
            this.panel1.Controls.Add(this.MarkerBorderColor);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 224);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "&OK";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label
            // 
            this.Label.Location = new System.Drawing.Point(208, 99);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(152, 20);
            this.Label.TabIndex = 3;
            this.Label.Text = "textBox2";
            // 
            // MarkerColor
            // 
            this.MarkerColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarkerColor.Location = new System.Drawing.Point(208, 128);
            this.MarkerColor.Name = "MarkerColor";
            this.MarkerColor.Size = new System.Drawing.Size(152, 21);
            this.MarkerColor.TabIndex = 4;
            // 
            // BorderColor
            // 
            this.BorderColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorderColor.Location = new System.Drawing.Point(208, 68);
            this.BorderColor.Name = "BorderColor";
            this.BorderColor.Size = new System.Drawing.Size(152, 21);
            this.BorderColor.TabIndex = 2;
            // 
            // PointColor
            // 
            this.PointColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PointColor.Location = new System.Drawing.Point(208, 38);
            this.PointColor.Name = "PointColor";
            this.PointColor.Size = new System.Drawing.Size(152, 21);
            this.PointColor.TabIndex = 1;
            // 
            // Dialog
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(392, 237);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog";
            this.Text = "Data Point";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Dialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion


		private void Dialog_Load(object sender, System.EventArgs e)
		{
			YValue.Text = ChartRef.Series[0].Points[pointIndex].YValues[0].ToString();
			Label.Text = ChartRef.Series[0].Points[pointIndex].Label;
			PointColor.SelectedIndex = PointColor.FindString( ChartRef.Series[0].Points[pointIndex].Color.Name );
			MarkerColor.SelectedIndex = MarkerColor.FindString( ChartRef.Series[0].Points[pointIndex].MarkerColor.Name );
			BorderColor.SelectedIndex = BorderColor.FindString( ChartRef.Series[0].Points[pointIndex].BorderColor.Name );
			MarkerBorderColor.SelectedIndex = MarkerBorderColor.FindString( ChartRef.Series[0].Points[pointIndex].MarkerBorderColor.Name );
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				double newValue = double.Parse( YValue.Text );
				if(newValue > 0)
					ChartRef.Series[0].Points[pointIndex].YValues[0] = newValue;
				else
					ChartRef.Series[0].Points[pointIndex].YValues[0] = 0.5;
			}
			catch
			{
				
			}

			ChartRef.Series[0].Points[pointIndex].Label = Label.Text;

			ChartRef.Series[0].Points[pointIndex].Color = Color.FromName(PointColor.SelectedItem.ToString());
			ChartRef.Series[0].Points[pointIndex].BorderColor = Color.FromName(BorderColor.SelectedItem.ToString());
			ChartRef.Series[0].Points[pointIndex].MarkerColor = Color.FromName(MarkerColor.SelectedItem.ToString());
			ChartRef.Series[0].Points[pointIndex].MarkerBorderColor = Color.FromName(MarkerBorderColor.SelectedItem.ToString());

			ChartRef.Invalidate();

			this.Close();
		}

		private void YValue_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == 46  || e.KeyChar == '.')
			{
				string editText = ((TextBox)(sender)).Text;
				if(e.KeyChar != 8)
				{
					TextBox textBox = (TextBox)sender;
					int selStart = textBox.SelectionStart;
					int selLength = textBox.SelectionLength;
	
					if(selLength > 0)
					{
						editText = editText.Remove(selStart, selLength);
						textBox.Text = editText;
						textBox.SelectionLength = 0;
						textBox.SelectionStart = selStart;
					}


					editText = editText.Insert(selStart,e.KeyChar.ToString());

					try
					{
						double newValue = double.Parse(editText);
						if(newValue <= 10 && newValue >= 0)
						{
							e.Handled = false;
						}
						else
							e.Handled = true;
					}
					catch(Exception )
					{
						e.Handled = true;
					}
				}
				else
					e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		
		}
	}
}
