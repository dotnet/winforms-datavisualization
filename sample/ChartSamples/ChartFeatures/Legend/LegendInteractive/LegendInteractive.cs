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
	/// Summary description for MovingAverages.
	/// </summary>
	public class LegendInteractive : System.Windows.Forms.UserControl
	{
		private	int		randomSeed = 0;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label labelSampleComment;
        private System.Windows.Forms.Panel panel1;
        private Button buttonRandomData;
        Random rand;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        public LegendInteractive()
		{
            rand = new Random(randomSeed);


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LegendInteractive));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem5 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell13 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell14 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell15 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem6 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell16 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell17 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell18 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem7 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell19 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell20 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell21 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem8 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell22 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell23 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell24 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint121 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 27);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint122 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -33);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint123 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -22);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint124 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 45);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint125 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 38);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint126 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint127 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -33);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint128 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint129 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 44);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint130 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -50);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint131 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint132 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 38);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint133 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 17);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint134 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -44);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint135 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint136 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 45);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint137 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -23);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint138 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -29);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint139 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 17);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint140 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -10);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint141 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -26);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint142 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 7);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint143 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -35);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint144 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 47);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint145 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 39);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint146 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -38);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint147 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 14);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint148 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -8);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint149 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -32);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint150 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 16);
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint151 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 44);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint152 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -36);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint153 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -23);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint154 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 14);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint155 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -37);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint156 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 19);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint157 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -41);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint158 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 4);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint159 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -13);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint160 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -26);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint161 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -16);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint162 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -20);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint163 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -40);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint164 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint165 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -46);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint166 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 41);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint167 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 8);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint168 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -36);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint169 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint170 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 43);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint171 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 45);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint172 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 19);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint173 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -21);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint174 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 20);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint175 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 15);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint176 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -30);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint177 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -49);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint178 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -20);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint179 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -45);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint180 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 26);
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint181 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 29);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint182 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 24);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint183 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -21);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint184 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -23);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint185 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -45);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint186 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -21);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint187 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 10);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint188 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -47);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint189 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 43);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint190 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 28);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint191 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 35);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint192 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 23);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint193 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 33);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint194 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -7);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint195 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -44);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint196 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 43);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint197 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -4);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint198 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 18);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint199 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 43);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint200 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 48);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint201 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 3);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint202 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 0);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint203 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 44);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint204 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -26);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint205 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 21);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint206 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -26);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint207 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 35);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint208 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint209 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 48);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint210 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 42);
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint211 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 17);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint212 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 29);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint213 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint214 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 10);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint215 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint216 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 9);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint217 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -49);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint218 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 32);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint219 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -9);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint220 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 25);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint221 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -20);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint222 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint223 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -30);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint224 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 19);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint225 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -43);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint226 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -29);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint227 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 36);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint228 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 35);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint229 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 14);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint230 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 22);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint231 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 23);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint232 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -17);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint233 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -13);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint234 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -43);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint235 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -27);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint236 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -21);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint237 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 29);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint238 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, -45);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint239 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 6);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint240 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 31);
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSampleComment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRandomData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.AccessibleDescription = null;
            this.chart1.AccessibleName = null;
            resources.ApplyResources(this.chart1, "chart1");
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.Inclination = 15;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.AxisX.IsInterlaced = true;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LabelStyle.IntervalOffset = 0;
            chartArea2.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.Interval = 0;
            chartArea2.AxisX.MajorGrid.IntervalOffset = 0;
            chartArea2.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorTickMark.Interval = 0;
            chartArea2.AxisX.MajorTickMark.IntervalOffset = 0;
            chartArea2.AxisX.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX2.LabelStyle.Interval = 0;
            chartArea2.AxisX2.LabelStyle.IntervalOffset = 0;
            chartArea2.AxisX2.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX2.MajorGrid.Interval = 0;
            chartArea2.AxisX2.MajorGrid.IntervalOffset = 0;
            chartArea2.AxisX2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX2.MajorTickMark.Interval = 0;
            chartArea2.AxisX2.MajorTickMark.IntervalOffset = 0;
            chartArea2.AxisX2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX2.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LabelStyle.Format = "0";
            chartArea2.AxisY.LabelStyle.Interval = 0;
            chartArea2.AxisY.LabelStyle.IntervalOffset = 0;
            chartArea2.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.Interval = 0;
            chartArea2.AxisY.MajorGrid.IntervalOffset = 0;
            chartArea2.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorTickMark.Interval = 0;
            chartArea2.AxisY.MajorTickMark.IntervalOffset = 0;
            chartArea2.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY2.LabelStyle.Interval = 0;
            chartArea2.AxisY2.LabelStyle.IntervalOffset = 0;
            chartArea2.AxisY2.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY2.MajorGrid.Interval = 0;
            chartArea2.AxisY2.MajorGrid.IntervalOffset = 0;
            chartArea2.AxisY2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY2.MajorTickMark.Interval = 0;
            chartArea2.AxisY2.MajorTickMark.IntervalOffset = 0;
            chartArea2.AxisY2.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisY2.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "Default";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            legendItem5.BorderColor = System.Drawing.Color.White;
            legendItem5.BorderWidth = 2;
            legendCell13.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.Image;
            legendCell13.ImageTransparentColor = System.Drawing.Color.Red;
            legendCell13.Name = "Cell1";
            legendCell14.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
            legendCell14.Name = "Cell2";
            legendCell15.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            legendCell15.Name = "Cell3";
            legendCell15.Text = "Series 1";
            legendItem5.Cells.Add(legendCell13);
            legendItem5.Cells.Add(legendCell14);
            legendItem5.Cells.Add(legendCell15);
            legendItem5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            legendItem5.Name = "Series 1";
            legendItem6.BorderColor = System.Drawing.Color.White;
            legendItem6.BorderWidth = 2;
            legendCell16.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.Image;
            legendCell16.ImageTransparentColor = System.Drawing.Color.Red;
            legendCell16.Name = "Cell1";
            legendCell17.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
            legendCell17.Name = "Cell2";
            legendCell18.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            legendCell18.Name = "Cell3";
            legendCell18.Text = "Series 2";
            legendItem6.Cells.Add(legendCell16);
            legendItem6.Cells.Add(legendCell17);
            legendItem6.Cells.Add(legendCell18);
            legendItem6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            legendItem6.Name = "Series 2";
            legendItem7.BorderColor = System.Drawing.Color.White;
            legendItem7.BorderWidth = 2;
            legendCell19.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.Image;
            legendCell19.ImageTransparentColor = System.Drawing.Color.Red;
            legendCell19.Name = "Cell1";
            legendCell20.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
            legendCell20.Name = "Cell2";
            legendCell21.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            legendCell21.Name = "Cell3";
            legendCell21.Text = "Series 3";
            legendItem7.Cells.Add(legendCell19);
            legendItem7.Cells.Add(legendCell20);
            legendItem7.Cells.Add(legendCell21);
            legendItem7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            legendItem7.Name = "Series 3";
            legendItem8.BorderColor = System.Drawing.Color.White;
            legendItem8.BorderWidth = 2;
            legendCell22.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.Image;
            legendCell22.ImageTransparentColor = System.Drawing.Color.Red;
            legendCell22.Name = "Cell1";
            legendCell23.CellType = System.Windows.Forms.DataVisualization.Charting.LegendCellType.SeriesSymbol;
            legendCell23.Name = "Cell2";
            legendCell24.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            legendCell24.Name = "Cell3";
            legendCell24.Text = "Series 4";
            legendItem8.Cells.Add(legendCell22);
            legendItem8.Cells.Add(legendCell23);
            legendItem8.Cells.Add(legendCell24);
            legendItem8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            legendItem8.Name = "Series 4";
            legend2.CustomItems.Add(legendItem5);
            legend2.CustomItems.Add(legendItem6);
            legend2.CustomItems.Add(legendItem7);
            legend2.CustomItems.Add(legendItem8);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend2.HeaderSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend2.IsTextAutoFit = false;
            legend2.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend2.Name = "Default";
            legend2.TitleSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart1.Legends.Add(legend2);
            this.chart1.Name = "chart1";
            series5.ChartArea = "Default";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series5.CustomProperties = "DrawingStyle=LightToDark";
            series5.IsVisibleInLegend = false;
            series5.Legend = "Default";
            series5.Name = "Series1";
            series5.Points.Add(dataPoint121);
            series5.Points.Add(dataPoint122);
            series5.Points.Add(dataPoint123);
            series5.Points.Add(dataPoint124);
            series5.Points.Add(dataPoint125);
            series5.Points.Add(dataPoint126);
            series5.Points.Add(dataPoint127);
            series5.Points.Add(dataPoint128);
            series5.Points.Add(dataPoint129);
            series5.Points.Add(dataPoint130);
            series5.Points.Add(dataPoint131);
            series5.Points.Add(dataPoint132);
            series5.Points.Add(dataPoint133);
            series5.Points.Add(dataPoint134);
            series5.Points.Add(dataPoint135);
            series5.Points.Add(dataPoint136);
            series5.Points.Add(dataPoint137);
            series5.Points.Add(dataPoint138);
            series5.Points.Add(dataPoint139);
            series5.Points.Add(dataPoint140);
            series5.Points.Add(dataPoint141);
            series5.Points.Add(dataPoint142);
            series5.Points.Add(dataPoint143);
            series5.Points.Add(dataPoint144);
            series5.Points.Add(dataPoint145);
            series5.Points.Add(dataPoint146);
            series5.Points.Add(dataPoint147);
            series5.Points.Add(dataPoint148);
            series5.Points.Add(dataPoint149);
            series5.Points.Add(dataPoint150);
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.ChartArea = "Default";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series6.CustomProperties = "DrawingStyle=LightToDark";
            series6.IsVisibleInLegend = false;
            series6.Legend = "Default";
            series6.MarkerBorderWidth = 2;
            series6.Name = "Series2";
            series6.Points.Add(dataPoint151);
            series6.Points.Add(dataPoint152);
            series6.Points.Add(dataPoint153);
            series6.Points.Add(dataPoint154);
            series6.Points.Add(dataPoint155);
            series6.Points.Add(dataPoint156);
            series6.Points.Add(dataPoint157);
            series6.Points.Add(dataPoint158);
            series6.Points.Add(dataPoint159);
            series6.Points.Add(dataPoint160);
            series6.Points.Add(dataPoint161);
            series6.Points.Add(dataPoint162);
            series6.Points.Add(dataPoint163);
            series6.Points.Add(dataPoint164);
            series6.Points.Add(dataPoint165);
            series6.Points.Add(dataPoint166);
            series6.Points.Add(dataPoint167);
            series6.Points.Add(dataPoint168);
            series6.Points.Add(dataPoint169);
            series6.Points.Add(dataPoint170);
            series6.Points.Add(dataPoint171);
            series6.Points.Add(dataPoint172);
            series6.Points.Add(dataPoint173);
            series6.Points.Add(dataPoint174);
            series6.Points.Add(dataPoint175);
            series6.Points.Add(dataPoint176);
            series6.Points.Add(dataPoint177);
            series6.Points.Add(dataPoint178);
            series6.Points.Add(dataPoint179);
            series6.Points.Add(dataPoint180);
            series7.ChartArea = "Default";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series7.CustomProperties = "DrawingStyle=LightToDark";
            series7.IsVisibleInLegend = false;
            series7.Legend = "Default";
            series7.Name = "Series3";
            series7.Points.Add(dataPoint181);
            series7.Points.Add(dataPoint182);
            series7.Points.Add(dataPoint183);
            series7.Points.Add(dataPoint184);
            series7.Points.Add(dataPoint185);
            series7.Points.Add(dataPoint186);
            series7.Points.Add(dataPoint187);
            series7.Points.Add(dataPoint188);
            series7.Points.Add(dataPoint189);
            series7.Points.Add(dataPoint190);
            series7.Points.Add(dataPoint191);
            series7.Points.Add(dataPoint192);
            series7.Points.Add(dataPoint193);
            series7.Points.Add(dataPoint194);
            series7.Points.Add(dataPoint195);
            series7.Points.Add(dataPoint196);
            series7.Points.Add(dataPoint197);
            series7.Points.Add(dataPoint198);
            series7.Points.Add(dataPoint199);
            series7.Points.Add(dataPoint200);
            series7.Points.Add(dataPoint201);
            series7.Points.Add(dataPoint202);
            series7.Points.Add(dataPoint203);
            series7.Points.Add(dataPoint204);
            series7.Points.Add(dataPoint205);
            series7.Points.Add(dataPoint206);
            series7.Points.Add(dataPoint207);
            series7.Points.Add(dataPoint208);
            series7.Points.Add(dataPoint209);
            series7.Points.Add(dataPoint210);
            series8.ChartArea = "Default";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series8.CustomProperties = "DrawingStyle=LightToDark";
            series8.IsVisibleInLegend = false;
            series8.Legend = "Default";
            series8.Name = "Series4";
            series8.Points.Add(dataPoint211);
            series8.Points.Add(dataPoint212);
            series8.Points.Add(dataPoint213);
            series8.Points.Add(dataPoint214);
            series8.Points.Add(dataPoint215);
            series8.Points.Add(dataPoint216);
            series8.Points.Add(dataPoint217);
            series8.Points.Add(dataPoint218);
            series8.Points.Add(dataPoint219);
            series8.Points.Add(dataPoint220);
            series8.Points.Add(dataPoint221);
            series8.Points.Add(dataPoint222);
            series8.Points.Add(dataPoint223);
            series8.Points.Add(dataPoint224);
            series8.Points.Add(dataPoint225);
            series8.Points.Add(dataPoint226);
            series8.Points.Add(dataPoint227);
            series8.Points.Add(dataPoint228);
            series8.Points.Add(dataPoint229);
            series8.Points.Add(dataPoint230);
            series8.Points.Add(dataPoint231);
            series8.Points.Add(dataPoint232);
            series8.Points.Add(dataPoint233);
            series8.Points.Add(dataPoint234);
            series8.Points.Add(dataPoint235);
            series8.Points.Add(dataPoint236);
            series8.Points.Add(dataPoint237);
            series8.Points.Add(dataPoint238);
            series8.Points.Add(dataPoint239);
            series8.Points.Add(dataPoint240);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.ShadowColor = System.Drawing.Color.Silver;
            title2.ShadowOffset = 2;
            title2.Text = "Interactive Legend";
            this.chart1.Titles.Add(title2);
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseDown);
            // 
            // labelSampleComment
            // 
            this.labelSampleComment.AccessibleDescription = null;
            this.labelSampleComment.AccessibleName = null;
            resources.ApplyResources(this.labelSampleComment, "labelSampleComment");
            this.labelSampleComment.Name = "labelSampleComment";
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = null;
            this.panel1.AccessibleName = null;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackgroundImage = null;
            this.panel1.Controls.Add(this.buttonRandomData);
            this.panel1.Font = null;
            this.panel1.Name = "panel1";
            // 
            // buttonRandomData
            // 
            this.buttonRandomData.AccessibleDescription = null;
            this.buttonRandomData.AccessibleName = null;
            resources.ApplyResources(this.buttonRandomData, "buttonRandomData");
            this.buttonRandomData.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRandomData.BackgroundImage = null;
            this.buttonRandomData.Font = null;
            this.buttonRandomData.Name = "buttonRandomData";
            this.buttonRandomData.UseVisualStyleBackColor = false;
            this.buttonRandomData.Click += new System.EventHandler(this.buttonRandomData_Click);
            // 
            // LegendInteractive
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = null;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSampleComment);
            this.Controls.Add(this.chart1);
            this.Name = "LegendInteractive";
            this.Load += new System.EventHandler(this.TemplateSampleControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void TemplateSampleControl_Load(object sender, System.EventArgs e)
		{
			// Generate rundom data
            // Generate rundom data
            GenerateRandomData(chart1.Series["Series1"]);
            GenerateRandomData(chart1.Series["Series2"]);
            GenerateRandomData(chart1.Series["Series3"]);
            GenerateRandomData(chart1.Series["Series4"]);

			// Set all cells image transp color to red
			for (int i = 1; i < 4; i++) 
			{
				chart1.Legends["Default"].CustomItems[i].Cells[0].ImageTransparentColor = Color.Red;
			}

			MainForm mainForm = (MainForm)this.ParentForm;
			
			// Set image for all custom items
			chart1.Legends["Default"].CustomItems[0].Cells[0].Image = mainForm.CurrentSamplePath + @"\chk_checked.png";
			chart1.Legends["Default"].CustomItems[1].Cells[0].Image = mainForm.CurrentSamplePath + @"\chk_checked.png";
			chart1.Legends["Default"].CustomItems[2].Cells[0].Image = mainForm.CurrentSamplePath + @"\chk_checked.png";
			chart1.Legends["Default"].CustomItems[3].Cells[0].Image = mainForm.CurrentSamplePath + @"\chk_checked.png";

			// Set tag property for all custom items to appropriate series
			chart1.Legends["Default"].CustomItems[0].Tag = chart1.Series["Series1"];
            chart1.Legends["Default"].CustomItems[1].Tag = chart1.Series["Series2"];
            chart1.Legends["Default"].CustomItems[2].Tag = chart1.Series["Series3"];
            chart1.Legends["Default"].CustomItems[3].Tag = chart1.Series["Series4"];			
		}

		# region Methods

		// Helper method for setting series appearance
		private void SetSeriesAppearance(string seriesName) 
		{
			chart1.Series[seriesName].ChartArea = "Default";
			chart1.Series[seriesName].ChartType = SeriesChartType.Line;
			chart1.Series[seriesName].BorderWidth = 2;
			chart1.Series[seriesName].ShadowOffset = 1;				
			chart1.Series[seriesName].IsVisibleInLegend = false;
		}

		/// <summary>
		/// This method calculates different Moving Averages.
		/// </summary>
		private void UpdateChart()
		{

			chart1.Invalidate();
		}

		/// <summary>
		/// This method generates random data.
		/// </summary>
		/// <param name="series"></param>
		private void GenerateRandomData( Series series )
		{
			

			// Generate 30 random y values.
			series.Points.Clear();
			for( int index = 0; index < 30; index++ )
			{
				// Generate the first point
				series.Points.AddXY(index+1,0);
				series.Points[index].YValues[0] = 10;

				// Use previous point to calculate a next one.
				if( index > 0 )
				{
					series.Points[index].YValues[0] = series.Points[index-1].YValues[0] + 4*rand.NextDouble() - 2;
				}
			}

			chart1.Invalidate();
		}
		#endregion

		# region UI Event Handlers




		private void buttonRandomData_Click(object sender, System.EventArgs e)
		{
			Random rand = new Random();
			randomSeed = rand.Next();

			// Generate rundom data
			GenerateRandomData(chart1.Series["Series1"] );
            GenerateRandomData(chart1.Series["Series2"]);
            GenerateRandomData(chart1.Series["Series3"]);
            GenerateRandomData(chart1.Series["Series4"]);

			// Calculate Moving Averages
			UpdateChart();
		}



		private void chart1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			HitTestResult result = chart1.HitTest(e.X, e.Y);
			if(result != null && result.Object != null)
			{					
				// When user hits the LegendItem
				if (result.Object is LegendItem) 
				{
					// Legend item result
					LegendItem legendItem = (LegendItem)result.Object;
					
					// series item selected
					Series selectedSeries = (Series)legendItem.Tag;

					if (selectedSeries !=null) 
					{

						MainForm mainForm = (MainForm)this.ParentForm;
			
						if (selectedSeries.Enabled) 
						{
							selectedSeries.Enabled = false;
							legendItem.Cells[0].Image = string.Format(mainForm.CurrentSamplePath + @"\chk_unchecked.png");
							legendItem.Cells[0].ImageTransparentColor = Color.Red;
						}

						else 
						{
							selectedSeries.Enabled = true;
							legendItem.Cells[0].Image = string.Format(mainForm.CurrentSamplePath + @"\chk_checked.png");
							legendItem.Cells[0].ImageTransparentColor = Color.Red;
						}
					}
				}
			}

			#endregion
		}
	}
}
