using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using ChartSamples;

namespace ChartSamples
{
	/// <summary>
	/// Summary description for FinancialChartType.
	/// </summary>
	public class FinancialChartType : System.Windows.Forms.UserControl
	{
		private MemoryStream defaultViewStyleStream = new MemoryStream();

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxMarks;
		private System.Windows.Forms.CheckBox checkBoxCloseOnly;
		private System.Windows.Forms.ComboBox comboBoxChartType;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FinancialChartType()
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
			defaultViewStyleStream.Close();

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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.labelSampleComment = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkBoxCloseOnly = new System.Windows.Forms.CheckBox();
			this.comboBoxMarks = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxChartType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(211)), ((System.Byte)(223)), ((System.Byte)(240)));
			this.chart1.BackSecondaryColor = System.Drawing.Color.White;
			this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			this.chart1.BorderlineWidth = 2;
			this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.IsLabelAutoFit = false;
			chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.AxisY.IsStartedFromZero = false;
			chartArea1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(165)), ((System.Byte)(191)), ((System.Byte)(228)));
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea1.Name = "Price";
			chartArea1.Position.Auto = false;
			chartArea1.Position.Height = 42F;
			chartArea1.Position.Width = 88F;
			chartArea1.Position.X = 3F;
			chartArea1.Position.Y = 10F;
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			chartArea2.AlignWithChartArea = "Price";
			chartArea2.Area3DStyle.IsClustered = true;
			chartArea2.Area3DStyle.Perspective = 10;
			chartArea2.Area3DStyle.IsRightAngleAxes = false;
			chartArea2.Area3DStyle.WallWidth = 0;
			chartArea2.Area3DStyle.Inclination = 15;
			chartArea2.Area3DStyle.Rotation = 10;
			chartArea2.AxisX.IsLabelAutoFit = false;
			chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea2.AxisX.LabelStyle.IsEndLabelVisible = false;
			chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea2.AxisY.IsLabelAutoFit = false;
			chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea2.AxisY.IsStartedFromZero = false;
			chartArea2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(165)), ((System.Byte)(191)), ((System.Byte)(228)));
			chartArea2.BackSecondaryColor = System.Drawing.Color.White;
			chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea2.Name = "Volume";
			chartArea2.Position.Auto = false;
			chartArea2.Position.Height = 42F;
			chartArea2.Position.Width = 88F;
			chartArea2.Position.X = 3F;
			chartArea2.Position.Y = 51.84195F;
			chartArea2.ShadowColor = System.Drawing.Color.Transparent;
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.ChartAreas.Add(chartArea2);
			legend1.Alignment = System.Drawing.StringAlignment.Far;
			legend1.IsTextAutoFit = false;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
			legend1.IsDockedInsideChartArea = false;
			legend1.DockedToChartArea = "Price";
			legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
			legend1.Name = "Default";
			legend1.Position.Auto = false;
			legend1.Position.Height = 7.127659F;
			legend1.Position.Width = 38.19123F;
			legend1.Position.X = 55F;
			legend1.Position.Y = 5F;
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(16, 48);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
			series1.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series1.ChartArea = "Price";
			series1.ChartType = SeriesChartType.Stock;
			series1.Name = "Price";
			series1.IsVisibleInLegend = false;
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series1.YValuesPerPoint = 4;
			series2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(26)), ((System.Byte)(59)), ((System.Byte)(105)));
			series2.ChartArea = "Volume";
			series2.Color = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(64)), ((System.Byte)(10)));
			series2.Name = "Volume";
			series2.IsVisibleInLegend = false;
			series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			this.chart1.Series.Add(series1);
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(446, 296);
			this.chart1.TabIndex = 1;
			// 
			// labelSampleComment
			// 
			this.labelSampleComment.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelSampleComment.Location = new System.Drawing.Point(16, 8);
			this.labelSampleComment.Name = "labelSampleComment";
			this.labelSampleComment.Size = new System.Drawing.Size(702, 34);
			this.labelSampleComment.TabIndex = 0;
			this.labelSampleComment.Text = "This sample demonstrates the Stock and CandleStick chart types.";
			this.labelSampleComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.checkBoxCloseOnly,
																				 this.comboBoxMarks,
																				 this.label2,
																				 this.comboBoxChartType,
																				 this.label1});
			this.panel1.Location = new System.Drawing.Point(464, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(256, 288);
			this.panel1.TabIndex = 2;
			// 
			// checkBoxCloseOnly
			// 
			this.checkBoxCloseOnly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxCloseOnly.Location = new System.Drawing.Point(13, 72);
			this.checkBoxCloseOnly.Name = "checkBoxCloseOnly";
			this.checkBoxCloseOnly.Size = new System.Drawing.Size(144, 24);
			this.checkBoxCloseOnly.TabIndex = 4;
			this.checkBoxCloseOnly.Text = "&Close Price Only:";
			this.checkBoxCloseOnly.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxCloseOnly.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// comboBoxMarks
			// 
			this.comboBoxMarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMarks.Items.AddRange(new object[] {
															   "Line",
															   "Triangle"});
			this.comboBoxMarks.Location = new System.Drawing.Point(144, 40);
			this.comboBoxMarks.Name = "comboBoxMarks";
			this.comboBoxMarks.Size = new System.Drawing.Size(112, 22);
			this.comboBoxMarks.TabIndex = 3;
			this.comboBoxMarks.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarks_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "&Open Close Marks:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxChartType
			// 
			this.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxChartType.Items.AddRange(new object[] {
																   "Stock",
																   "CandleStick"});
			this.comboBoxChartType.Location = new System.Drawing.Point(144, 8);
			this.comboBoxChartType.Name = "comboBoxChartType";
			this.comboBoxChartType.Size = new System.Drawing.Size(112, 22);
			this.comboBoxChartType.TabIndex = 1;
			this.comboBoxChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarks_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chart &Type:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FinancialChartType
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.labelSampleComment,
																		  this.chart1});
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "FinancialChartType";
			this.Size = new System.Drawing.Size(728, 360);
			this.Load += new System.EventHandler(this.FinancialChartType_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void UpdateChartSettings()
		{
			chart1.BeginInit();

			comboBoxChartType.Enabled = true;
			comboBoxMarks.Enabled = true;
			checkBoxCloseOnly.Enabled = true;

			// Load default settings except of the chart's size
			defaultViewStyleStream.Seek(0, SeekOrigin.Begin);
			chart1.Serializer.SerializableContent = "*.*";
			chart1.Serializer.NonSerializableContent = "*.Size";
			chart1.Serializer.Load(defaultViewStyleStream);

			// Set series chart type
			chart1.Series["Price"].ChartType = (SeriesChartType) Enum.Parse( typeof(SeriesChartType), comboBoxChartType.Text, true );

			// Set stock chart attributes
			if(comboBoxChartType.Text == "Stock")
			{
				comboBoxMarks.Enabled = true;
				checkBoxCloseOnly.Enabled = true;
				chart1.Series["Price"]["OpenCloseStyle"] = comboBoxMarks.Text;
				if(checkBoxCloseOnly.Checked)
				{
					chart1.Series["Price"]["ShowOpenClose"] = "Close";
				}

				chart1.Series["Price"]["PointWidth"] = "1.0";
			}
			else
			{
				chart1.Series["Price"]["PointWidth"] = "0.8";
				comboBoxMarks.Enabled = false;
				checkBoxCloseOnly.Enabled = false;
			}

			chart1.Series["Volume"]["PointWidth"] = "0.5";

			chart1.EndInit();
		}


		private void SetMarkers()
		{
			// Get image path
			MainForm mainForm = (MainForm)this.ParentForm;
            string imagePath = mainForm.CurrentSamplePath;
			imagePath += "\\";

			// Randomly set dividend and split markers
			Random	random = new Random();
			
			for(int index = 0; index < 2; index ++)
			{
				
				int pointIndex = random.Next(0, chart1.Series["Price"].Points.Count);
				
				chart1.Series["Price"].Points[pointIndex].MarkerImage = imagePath + "DividentLegend.bmp";
				chart1.Series["Price"].Points[pointIndex].MarkerImageTransparentColor = Color.White;
				chart1.Series["Price"].Points[pointIndex].ToolTip = "#VALX{D}\n0.15 - dividend per share";

				pointIndex = random.Next(0, chart1.Series["Price"].Points.Count);
				
				chart1.Series["Price"].Points[pointIndex].MarkerImage = imagePath + "SplitLegend.bmp";

				chart1.Series["Price"].Points[pointIndex].MarkerImageTransparentColor = Color.White;
				chart1.Series["Price"].Points[pointIndex].ToolTip = "#VALX{D}\n2 for 1 split";
			}
		}

		private void FinancialChartType_Load(object sender, System.EventArgs e)
		{
			// Get image path
			MainForm mainForm = (MainForm) this.ParentForm;
            string imagePath = mainForm.CurrentSamplePath; 
			imagePath += "\\";

			// Add custom legend items
			LegendItem legendItem = new LegendItem(); 
			legendItem.Name = "Dividend";
			legendItem.ImageStyle = LegendImageStyle.Marker;
			legendItem.MarkerImageTransparentColor = Color.White;
			legendItem.MarkerImage = imagePath + "DividentLegend.bmp";
			chart1.Legends[0].CustomItems.Add(legendItem);

			legendItem = new LegendItem(); 
			legendItem.Name = "Split";
			legendItem.ImageStyle = LegendImageStyle.Marker;
			legendItem.MarkerImageTransparentColor = Color.White;
			legendItem.MarkerImage = imagePath + "SplitLegend.bmp";
            chart1.Legends[0].CustomItems.Add(legendItem);

			// Populate series data
			FillData();
			
			SetMarkers();

			// Save default appearance
			chart1.Serializer.Save(defaultViewStyleStream);

			comboBoxChartType.SelectedIndex = 0;
			comboBoxMarks.SelectedIndex = 0;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void radioButtonCGI_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		private void comboBoxMarks_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateChartSettings();
		}

		/// <summary>
		/// Random Stock Data Generator
		/// </summary>
		private void FillData()
		{
			Random rand;
			// Use a number to calculate a starting value for 
			// the pseudo-random number sequence
			rand = new Random();
			
			// The number of days for stock data
			int period = 60;

			// The first High value
			double high = rand.NextDouble() * 40;

			// The first Close value
			double close = high - rand.NextDouble();

			// The first Low value
			double low = close - rand.NextDouble();

			// The first Open value
			double open = ( high - low ) * rand.NextDouble() + low;

			// The first Volume value
			double volume = 100 + 15 * rand.NextDouble();
						
			// The first day X and Y values
			chart1.Series["Price"].Points.AddXY(DateTime.Parse("1/2/2002"), high);
			chart1.Series["Volume"].Points.AddXY(DateTime.Parse("1/2/2002"), volume);
			chart1.Series["Price"].Points[0].YValues[1] = low;

			// The Open value is not used.
			chart1.Series["Price"].Points[0].YValues[2] = open;
			chart1.Series["Price"].Points[0].YValues[3] = close;
			
			// Days loop
			for( int day = 1; day <= period; day++ )
			{
			
				// Calculate High, Low and Close values
				high = chart1.Series["Price"].Points[day-1].YValues[2]+rand.NextDouble();
				close = high - rand.NextDouble();
				low = close - rand.NextDouble();
				open = ( high - low ) * rand.NextDouble() + low;
				
				// Calculate volume
				volume = chart1.Series["Volume"].Points[day-1].YValues[0] + 10 * rand.NextDouble() - 5;

				// The low cannot be less than yesterday close value.
				if( low > chart1.Series["Price"].Points[day-1].YValues[2])
					low = chart1.Series["Price"].Points[day-1].YValues[2];
							
				// Set data points values
				chart1.Series["Price"].Points.AddXY(day, high);
				chart1.Series["Price"].Points[day].XValue = chart1.Series["Price"].Points[day-1].XValue+1;
				chart1.Series["Price"].Points[day].YValues[1] = low;
				chart1.Series["Price"].Points[day].YValues[2] = open;
				chart1.Series["Price"].Points[day].YValues[3] = close;

				// Set volume values
				chart1.Series["Volume"].Points.AddXY(day, volume);
				chart1.Series["Volume"].Points[day].XValue = chart1.Series["Volume"].Points[day-1].XValue+1;
			}
		}

	}
}
