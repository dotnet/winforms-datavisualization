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
	/// Summary description for PyramidChartType.
	/// </summary>
	public class PyramidChartType : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBoxShow3D;
		private System.Windows.Forms.ComboBox comboBoxLabelsStyle;
		private System.Windows.Forms.ComboBox comboBoxLabelsPlacement;
		private System.Windows.Forms.Label labelOutsideLabelsPlacement;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDownGap;
		private System.Windows.Forms.NumericUpDown numericUpDownMinHeight;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDownAngle;
		private System.Windows.Forms.Label labelAngle;
		private System.Windows.Forms.ComboBox comboBox3DDrawingStyle;
		private System.Windows.Forms.Label label3DDrawingStyle;
		private System.Windows.Forms.ComboBox comboBoxValueType;
		private System.Windows.Forms.Label label1;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PyramidChartType()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

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
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 216.19999694824219);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 125.80000305175781);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 2.5999999046325684);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 97.300003051757812);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 45.700000762939453);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 25.299999237060547);
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.labelSampleComment = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBoxValueType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox3DDrawingStyle = new System.Windows.Forms.ComboBox();
			this.label3DDrawingStyle = new System.Windows.Forms.Label();
			this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
			this.labelAngle = new System.Windows.Forms.Label();
			this.numericUpDownMinHeight = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDownGap = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxLabelsPlacement = new System.Windows.Forms.ComboBox();
			this.labelOutsideLabelsPlacement = new System.Windows.Forms.Label();
			this.checkBoxShow3D = new System.Windows.Forms.CheckBox();
			this.comboBoxLabelsStyle = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownGap)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(211)), ((System.Byte)(223)), ((System.Byte)(240)));
			this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			this.chart1.BorderlineWidth = 2;
			this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Enable3D = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BackColor = System.Drawing.Color.Transparent;
			chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BorderWidth = 0;
			chartArea1.Name = "Default";
			chartArea1.Position.Auto = false;
			chartArea1.Position.Height = 82F;
			chartArea1.Position.Width = 88.77716F;
			chartArea1.Position.X = 5.089137F;
			chartArea1.Position.Y = 10F;
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Enabled = false;
			legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.Name = "Default";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(16, 40);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartType = SeriesChartType.Pyramid;
			series1.Color = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(65)), ((System.Byte)(140)), ((System.Byte)(240)));
			series1.CustomProperties = "PyramidPointGap=2, FunnelMinPointHeight=1";
			series1.LabelFormat = "F1";
			series1.Name = "Default";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			series1.Points.Add(dataPoint6);
			series1.IsValueShownAsLabel = true;
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(412, 296);
			this.chart1.TabIndex = 0;
			title1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
			title1.Position.Auto = false;
			title1.Position.Height = 6.470197F;
			title1.Position.Width = 88.77716F;
			title1.Position.Y = 4F;
			title1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(32)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			title1.ShadowOffset = 3;
			title1.Text = "Pyramid Chart";
			this.chart1.Titles.Add(title1);
			// 
			// labelSampleComment
			// 
			this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelSampleComment.Location = new System.Drawing.Point(16, 8);
			this.labelSampleComment.Name = "labelSampleComment";
			this.labelSampleComment.Size = new System.Drawing.Size(702, 24);
			this.labelSampleComment.TabIndex = 2;
			this.labelSampleComment.Text = "A Pyramid chart is used to display data that adds up to 100%.";
			this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.comboBoxValueType,
																				 this.label1,
																				 this.comboBox3DDrawingStyle,
																				 this.label3DDrawingStyle,
																				 this.numericUpDownAngle,
																				 this.labelAngle,
																				 this.numericUpDownMinHeight,
																				 this.label4,
																				 this.numericUpDownGap,
																				 this.label3,
																				 this.comboBoxLabelsPlacement,
																				 this.labelOutsideLabelsPlacement,
																				 this.checkBoxShow3D,
																				 this.comboBoxLabelsStyle,
																				 this.label2});
			this.panel1.Location = new System.Drawing.Point(432, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(304, 288);
			this.panel1.TabIndex = 0;
			// 
			// comboBoxValueType
			// 
			this.comboBoxValueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxValueType.Items.AddRange(new object[] {
																   "Linear",
																   "Surface"});
			this.comboBoxValueType.Location = new System.Drawing.Point(168, 232);
			this.comboBoxValueType.Name = "comboBoxValueType";
			this.comboBoxValueType.Size = new System.Drawing.Size(136, 22);
			this.comboBoxValueType.TabIndex = 16;
			this.comboBoxValueType.SelectedIndexChanged += new System.EventHandler(this.comboBoxValueType_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(20, 232);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 23);
			this.label1.TabIndex = 15;
			this.label1.Text = "&Value Type:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBox3DDrawingStyle
			// 
			this.comboBox3DDrawingStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3DDrawingStyle.Items.AddRange(new object[] {
																		"SquareBase",
																		"CircularBase"});
			this.comboBox3DDrawingStyle.Location = new System.Drawing.Point(168, 200);
			this.comboBox3DDrawingStyle.Name = "comboBox3DDrawingStyle";
			this.comboBox3DDrawingStyle.Size = new System.Drawing.Size(136, 22);
			this.comboBox3DDrawingStyle.TabIndex = 14;
			this.comboBox3DDrawingStyle.SelectedIndexChanged += new System.EventHandler(this.comboBox3DDrawingStyle_SelectedIndexChanged);
			// 
			// label3DDrawingStyle
			// 
			this.label3DDrawingStyle.Location = new System.Drawing.Point(20, 200);
			this.label3DDrawingStyle.Name = "label3DDrawingStyle";
			this.label3DDrawingStyle.Size = new System.Drawing.Size(144, 23);
			this.label3DDrawingStyle.TabIndex = 13;
			this.label3DDrawingStyle.Text = "&Drawing Style:";
			this.label3DDrawingStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDownAngle
			// 
			this.numericUpDownAngle.Location = new System.Drawing.Point(168, 168);
			this.numericUpDownAngle.Maximum = new System.Decimal(new int[] {
																			   10,
																			   0,
																			   0,
																			   0});
			this.numericUpDownAngle.Minimum = new System.Decimal(new int[] {
																			   10,
																			   0,
																			   0,
																			   -2147483648});
			this.numericUpDownAngle.Name = "numericUpDownAngle";
			this.numericUpDownAngle.Size = new System.Drawing.Size(136, 22);
			this.numericUpDownAngle.TabIndex = 12;
			this.numericUpDownAngle.Value = new System.Decimal(new int[] {
																			 5,
																			 0,
																			 0,
																			 0});
			this.numericUpDownAngle.ValueChanged += new System.EventHandler(this.numericUpDownAngle_ValueChanged);
			// 
			// labelAngle
			// 
			this.labelAngle.Location = new System.Drawing.Point(20, 168);
			this.labelAngle.Name = "labelAngle";
			this.labelAngle.Size = new System.Drawing.Size(144, 23);
			this.labelAngle.TabIndex = 11;
			this.labelAngle.Text = "Rotation &Angle:";
			this.labelAngle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDownMinHeight
			// 
			this.numericUpDownMinHeight.Location = new System.Drawing.Point(168, 104);
			this.numericUpDownMinHeight.Maximum = new System.Decimal(new int[] {
																				   10,
																				   0,
																				   0,
																				   0});
			this.numericUpDownMinHeight.Name = "numericUpDownMinHeight";
			this.numericUpDownMinHeight.Size = new System.Drawing.Size(136, 22);
			this.numericUpDownMinHeight.TabIndex = 9;
			this.numericUpDownMinHeight.ValueChanged += new System.EventHandler(this.numericUpDownMinHeight_ValueChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(20, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "&Min. Point Height:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDownGap
			// 
			this.numericUpDownGap.Location = new System.Drawing.Point(168, 72);
			this.numericUpDownGap.Maximum = new System.Decimal(new int[] {
																			 5,
																			 0,
																			 0,
																			 0});
			this.numericUpDownGap.Name = "numericUpDownGap";
			this.numericUpDownGap.Size = new System.Drawing.Size(136, 22);
			this.numericUpDownGap.TabIndex = 7;
			this.numericUpDownGap.Value = new System.Decimal(new int[] {
																		   2,
																		   0,
																		   0,
																		   0});
			this.numericUpDownGap.ValueChanged += new System.EventHandler(this.numericUpDownGap_ValueChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(20, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Points &Gap:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxLabelsPlacement
			// 
			this.comboBoxLabelsPlacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLabelsPlacement.Items.AddRange(new object[] {
																		 "Right",
																		 "Left"});
			this.comboBoxLabelsPlacement.Location = new System.Drawing.Point(168, 40);
			this.comboBoxLabelsPlacement.Name = "comboBoxLabelsPlacement";
			this.comboBoxLabelsPlacement.Size = new System.Drawing.Size(136, 22);
			this.comboBoxLabelsPlacement.TabIndex = 5;
			this.comboBoxLabelsPlacement.SelectedIndexChanged += new System.EventHandler(this.comboBoxLabelsPlacement_SelectedIndexChanged);
			// 
			// labelOutsideLabelsPlacement
			// 
			this.labelOutsideLabelsPlacement.Location = new System.Drawing.Point(20, 40);
			this.labelOutsideLabelsPlacement.Name = "labelOutsideLabelsPlacement";
			this.labelOutsideLabelsPlacement.Size = new System.Drawing.Size(144, 23);
			this.labelOutsideLabelsPlacement.TabIndex = 4;
			this.labelOutsideLabelsPlacement.Text = "Labels &Placement:";
			this.labelOutsideLabelsPlacement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// checkBoxShow3D
			// 
			this.checkBoxShow3D.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShow3D.Checked = true;
			this.checkBoxShow3D.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxShow3D.Location = new System.Drawing.Point(6, 136);
			this.checkBoxShow3D.Name = "checkBoxShow3D";
			this.checkBoxShow3D.Size = new System.Drawing.Size(176, 24);
			this.checkBoxShow3D.TabIndex = 10;
			this.checkBoxShow3D.Text = "Display chart as &3D:";
			this.checkBoxShow3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShow3D.CheckedChanged += new System.EventHandler(this.checkBoxShow3D_CheckedChanged);
			// 
			// comboBoxLabelsStyle
			// 
			this.comboBoxLabelsStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLabelsStyle.Items.AddRange(new object[] {
																	 "OutsideInColumn",
																	 "Outside",
																	 "Inside",
																	 "Disabled"});
			this.comboBoxLabelsStyle.Location = new System.Drawing.Point(168, 8);
			this.comboBoxLabelsStyle.Name = "comboBoxLabelsStyle";
			this.comboBoxLabelsStyle.Size = new System.Drawing.Size(136, 22);
			this.comboBoxLabelsStyle.TabIndex = 3;
			this.comboBoxLabelsStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxLabelsStyle_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(20, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "&Labels Style:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// PyramidChartType
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.labelSampleComment,
																		  this.chart1});
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "PyramidChartType";
			this.Size = new System.Drawing.Size(736, 360);
			this.Load += new System.EventHandler(this.PieChartType_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownGap)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			// Bind chart data
			double[]	yValues = new double[] { 216.1, 125.8, 2.6, 97.3, 45.7, 25.3 };
			chart1.Series["Default"].Points.DataBindY( yValues );

			// Set pyramid data point labels style
			chart1.Series["Default"]["PyramidLabelStyle"] = (string)comboBoxLabelsStyle.SelectedItem;

			// Set labels placement
			if(comboBoxLabelsStyle.SelectedIndex == 0 ||
				comboBoxLabelsStyle.SelectedIndex == 1)
			{
				chart1.Series["Default"]["PyramidOutsideLabelPlacement"] = (string)comboBoxLabelsPlacement.SelectedItem;
			}
			else
			{
				chart1.Series["Default"]["PyramidInsideLabelAlignment"] = (string)comboBoxLabelsPlacement.SelectedItem;
			}

			// Set gap between points
			chart1.Series["Default"]["PyramidPointGap"] = numericUpDownGap.Value.ToString();

			// Set minimum point height
			chart1.Series["Default"]["PyramidMinPointHeight"] = numericUpDownMinHeight.Value.ToString();
			
			// Set 3D mode
			chart1.ChartAreas["Default"].Area3DStyle.Enable3D = checkBoxShow3D.Checked;

			// Set 3D angle
			chart1.Series["Default"]["Pyramid3DRotationAngle"] = numericUpDownAngle.Value.ToString();

			// Set 3D drawing style
			chart1.Series["Default"]["Pyramid3DDrawingStyle"] = (string)comboBox3DDrawingStyle.SelectedItem;

			// Set value type
			chart1.Series["Default"]["PyramidValueType"] = (string)comboBoxValueType.SelectedItem;

			// Disable/Enable controls
			numericUpDownAngle.Enabled = checkBoxShow3D.Checked;
			labelAngle.Enabled = checkBoxShow3D.Checked;
			comboBox3DDrawingStyle.Enabled = checkBoxShow3D.Checked;
			label3DDrawingStyle.Enabled = checkBoxShow3D.Checked;
			comboBoxLabelsPlacement.Enabled = comboBoxLabelsStyle.SelectedIndex != 3;
			labelOutsideLabelsPlacement.Enabled = comboBoxLabelsStyle.SelectedIndex != 3;

			chart1.Invalidate();
		}

		private void PieChartType_Load(object sender, System.EventArgs e)
		{
			// Set selection
			comboBoxLabelsStyle.SelectedIndex = 0;
			comboBoxLabelsPlacement.SelectedIndex = 0;
			comboBox3DDrawingStyle.SelectedIndex = 0;
			comboBoxValueType.SelectedIndex = 0;

			UpdateChartSettings();	
		}

		private void comboBoxFunnelStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void comboBoxLabelsStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			comboBoxLabelsPlacement.Items.Clear();
			if(comboBoxLabelsStyle.SelectedIndex == 0 ||
				comboBoxLabelsStyle.SelectedIndex == 1)
			{
				comboBoxLabelsPlacement.Items.Add("Right");
				comboBoxLabelsPlacement.Items.Add("Left");
			}
			else
			{
				comboBoxLabelsPlacement.Items.Add("Center");
				comboBoxLabelsPlacement.Items.Add("Top");
				comboBoxLabelsPlacement.Items.Add("Bottom");
			}
			comboBoxLabelsPlacement.SelectedIndex = 0;
			UpdateChartSettings();	
		}

		private void comboBoxLabelsPlacement_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void numericUpDownGap_ValueChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void numericUpDownMinHeight_ValueChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void checkBoxShow3D_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void numericUpDownAngle_ValueChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void comboBox3DDrawingStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();	
		}

		private void comboBoxValueType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();	
		}
	}
}
