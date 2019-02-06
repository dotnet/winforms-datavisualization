//=================================================================
//  File:		SixSigma.cs
//
//  Namespace:	System.Windows.Forms.DataVisualization.Charting.Utilities
//
//	Classes:	SixSigma
//
//  Purpose:	To create SixSigma charts.
//
//===================================================================
// Chart Control for .NET Framework
// Copyright © Microsoft Corporation, all rights reserved
//===================================================================
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;

namespace System.Windows.Forms.DataVisualization.Charting.Utilities
{
    /// <summary>
    /// SixSigma is a utility that includes useful functions related to the Six Sigma strategy.
    /// This utility mainly focuses on those parts of the strategy that involve charting, and producing
    /// those charts.
    /// </summary>
    public class SixSigma
    {
        #region Members
        /// <summary>
        /// sBar holds a value if an schart has been created. sBar is used for a XBAR chart.
        /// </summary>
        private float mysBar = 0;

        /// <summary>
        /// rBar holds a value if an rchart has been created. rBar is used for a XBAR chart.
        /// </summary>
        private float myrBar = 0;

        /// <summary>
        /// Holds the n value passed into sChart or rChart for use by XBAR.
        /// </summary>
        private int mynValue = 0;

        private bool myAutoFitLines;
        private bool myShowLineLabels;
        private Color myLineColor;
        private Color myForeColor;
        private Font myFont;
        #endregion

        #region Properties
        /// <summary>
        /// Controls whether the AxisY will have an automatic Maximum set so that the chart will always
        /// contain the UCL annotation. If left to false, it is up to the user to set a maximum AxisY value
        /// such that all annotations appear on the graph.
        /// </summary>
        public bool AutoFitLines
        {
            get { return myAutoFitLines; }
            set { myAutoFitLines = value; }
        }

        /// <summary>
        /// Controls whether text is added to the lines to label what they are.
        /// </summary>
        public bool ShowLineLabels
        {
            get { return myShowLineLabels; }
            set { myShowLineLabels = value; }
        }

        /// <summary>
        /// Specifies the colour of the line annotations added to each chart.
        /// </summary>
        public Color LineColor
        {
            get { return myLineColor; }
            set { myLineColor = value; }
        }

        /// <summary>
        /// Specifies the colour of the text that will label the lines.
        /// </summary>
        public Color ForeColor
        {
            get { return myForeColor; }
            set { myForeColor = value; }
        }

        /// <summary>
        /// Specifies the font of the text that will label the lines.
        /// </summary>
        public Font Font
        {
            get { return myFont; }
            set { myFont = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SixSigma()
        {
            myAutoFitLines = false;
            myShowLineLabels = false;
            myLineColor = Color.Red;
            myForeColor = Color.Red;
            myFont = new Font("Arial", 8);
        }
        #endregion

        #region Chart Creation Methods
        /// <summary>
        /// Creates a C-Chart with lines indicating cBar, UCL and LCL. A C-Chart is a measure of the number of
        /// non-conformities per unit, where unit is a fixed rate.
        /// </summary>
        /// <param name="subgroup">An array holding the subgroups. Must aline with the nonconform array.</param>
        /// <param name="nonconform">An array holding the non-conformity data associated with the subgroups. Must aline with the subgroups.</param>
        /// <param name="output">The chart which will have the created series added to it.</param>
        /// <returns>Series which has been created and added to the output chart.</returns>
        public Series cChart(float[] subgroup, float[] nonconform, Chart output)
        {
            //Assure the input all have the same number of items.
            if (subgroup.Length != nonconform.Length)
                throw new ArgumentException("Input arrays must all be the same length.", "subgroup, nonconform");

            //c holds the total number of items (subgroups).
            int c = subgroup.Length;

            //Declare and initialize cBar, LCL and UCL.
            float cbar = 0;
            float LCL = 0;
            float UCL = 0;

            //Calculate cbar.
            for (int i = 0; i < c; i++)
            {
                cbar += (float)(nonconform[i]);
            }
            cbar /= c;

            //Calculate UCL and LCL.
            UCL = (float)(cbar + 3 * System.Math.Sqrt(cbar));
            LCL = (float)(cbar - 3 * System.Math.Sqrt(cbar));

            //If LCL is less than zero, then it should be zero.
            if (LCL < 0)
                LCL = 0;

            //Create the series for the cchart data.
            Series cseries = new Series("cseries");
            //Graph subgroups vs. non-conformities.
            for (int i = 0; i < c; i++)
                cseries.Points.AddXY(subgroup[i], nonconform[i]);

            //Set the series type to a line.
            cseries.ChartType = SeriesChartType.Line;

            //Add the series to the chart.
            output.Series.Add(cseries);

            //Add the lines to the graph as annotations.
            //cBar line.
            addLineAnnotation(output.ChartAreas[cseries.ChartArea].AxisX, output.ChartAreas[cseries.ChartArea].AxisY,
                cseries.Points[0].XValue, cbar, cseries.Points[c - 1].XValue, 0, output);

            //UCL line.
            addLineAnnotation(output.ChartAreas[cseries.ChartArea].AxisX, output.ChartAreas[cseries.ChartArea].AxisY,
                cseries.Points[0].XValue, UCL, cseries.Points[c - 1].XValue, 0, output);

            //LCL line.
            addLineAnnotation(output.ChartAreas[cseries.ChartArea].AxisX, output.ChartAreas[cseries.ChartArea].AxisY,
                cseries.Points[0].XValue, LCL, cseries.Points[c - 1].XValue, 0, output);

            //Add Text Annotations (line labels) if the user desired.
            if (myShowLineLabels)
            {
                addTextAnnotation("CBAR", output.ChartAreas[cseries.ChartArea].AxisX, output.ChartAreas[cseries.ChartArea].AxisY,
                    cseries.Points[0].XValue, cbar, output);

                addTextAnnotation("UCL", output.ChartAreas[cseries.ChartArea].AxisX, output.ChartAreas[cseries.ChartArea].AxisY,
                    cseries.Points[0].XValue, UCL, output);

                addTextAnnotation("LCL", output.ChartAreas[cseries.ChartArea].AxisX, output.ChartAreas[cseries.ChartArea].AxisY,
                    cseries.Points[0].XValue, LCL, output);
            }

            //Scale the chart if the user has requested it.
            FitChart(UCL, cseries.ChartArea, output);

            //Return the series.
            return cseries;
        }

        /// <summary>
        /// Creates a P-Chart with lines indicating pBar, UCL and LCL. A P-Chart is the same as an NP-Chart except
        /// with a variable number of items in each subgroup.
        /// </summary>
        /// <param name="subgroup">An array holding the subgroups. Must aline with the nonconform array and the number tested.</param>
        /// <param name="nonconform">An array holding the non-conformity data associated with the subgroups. Must aline with the subgroups and the number tested.</param>
        /// <param name="numbertested">An array holding the number of items in each subgroup. Must aline with the subgroups and the nonconform array.</param>
        /// <param name="output">The chart which will have the created series added to it.</param>
        /// <returns>Series which has been created and added to the output chart.</returns>
        public Series pChart(float[] subgroup, float[] nonconform, float[] numbertested, Chart output)
        {
            //Assure the input all have the same number of items.
            if ((subgroup.Length != nonconform.Length) || (subgroup.Length != numbertested.Length) || (nonconform.Length != numbertested.Length))
                throw new ArgumentException("Input arrays must all be the same length.", "subgroup, nonconform, numbertested");

            //c holds the total number of items (subgroups).
            int c = subgroup.Length;

            //Declare and initialize phat, UCL, LCL and pBar.
            float[] phat = new float[c];
            float[] UCL = new float[c];
            float[] LCL = new float[c];
            float pbar = 0;

            //Calculate phat(i).
            for (int i = 0; i < c; i++)
                phat[i] = nonconform[i] / numbertested[i];

            //Calculate pbar.
            for (int i = 0; i < c; i++)
            {
                pbar += phat[i];
            }
            pbar /= c;

            //Calculate UCL and LCL.
            for (int i = 0; i < c; i++)
            {
                UCL[i] = (float)(pbar + 3 * System.Math.Sqrt((pbar * (1 - pbar)) / numbertested[i]));
                LCL[i] = (float)(pbar - 3 * System.Math.Sqrt((pbar * (1 - pbar)) / numbertested[i]));
            }

            //Create the series for the pchart data.
            Series pseries = new Series("pseries");
            //Graph subgroup vs. proportion.
            for (int i = 0; i < c; i++)
                pseries.Points.AddXY(subgroup[i], phat[i]);

            //Set the series type to a line.
            pseries.ChartType = SeriesChartType.Line;

            //Add the series to the chart.
            output.Series.Add(pseries);

            //Add the lines to the graph as annotations.
            //PBAR line.
            addLineAnnotation(output.ChartAreas[pseries.ChartArea].AxisX, output.ChartAreas[pseries.ChartArea].AxisY,
                pseries.Points[0].XValue, pbar, pseries.Points[c - 1].XValue, 0, output);

            //Add the UCL and LCL line segments as individual line annotations.
            for (int i = 0; i < c - 1; i++)
            {
                //UCL line.
                addLineAnnotation(output.ChartAreas[pseries.ChartArea].AxisX, output.ChartAreas[pseries.ChartArea].AxisY,
                    subgroup[i], UCL[i], subgroup[i + 1] - subgroup[i], UCL[i + 1] - UCL[i], output);

                //LCL line.
                addLineAnnotation(output.ChartAreas[pseries.ChartArea].AxisX, output.ChartAreas[pseries.ChartArea].AxisY,
                    subgroup[i], LCL[i], subgroup[i + 1] - subgroup[i], LCL[i + 1] - LCL[i], output);
            }

            //Add Text Annotations (line labels) if the user desired.
            if (myShowLineLabels)
            {
                addTextAnnotation("PBAR", output.ChartAreas[pseries.ChartArea].AxisX, output.ChartAreas[pseries.ChartArea].AxisY,
                    pseries.Points[0].XValue, pbar, output);

                addTextAnnotation("UCL", output.ChartAreas[pseries.ChartArea].AxisX, output.ChartAreas[pseries.ChartArea].AxisY,
                    pseries.Points[0].XValue, UCL[0], output);

                addTextAnnotation("LCL", output.ChartAreas[pseries.ChartArea].AxisX, output.ChartAreas[pseries.ChartArea].AxisY,
                    pseries.Points[0].XValue, LCL[0], output);
            }

            //Find the maximum UCL value and store the index of it.
            int maxUCL = 0;
            for (int i = 1; i < c; i++)
                if (UCL[maxUCL] < UCL[i])
                    maxUCL = i;

            //Scale the chart if the user has requested it.
            FitChart(UCL[maxUCL], pseries.ChartArea, output);

            //Return the series.
            return pseries;
        }

        /// <summary>
        /// Creates an NP-Chart with lines indicating CL, UCL and LCL. An NP chart is the same as a P-chart except
        /// that the number of items in each subgroup is the same.
        /// </summary>
        /// <param name="subgroup">An array holding the subgroups. Must aline with the nonconform array.</param>
        /// <param name="nonconform">An array holding the non-conformity data associated with the subgroups. Must aline with the subgroups.</param>
        /// <param name="numbertested">An array holding the number of items in each subgroup. Must aline with the subgroups and the nonconform array.</param>
        /// <param name="output">The chart which will have the created series added to it.</param>
        /// <returns>Series which has been created and added to the output chart.</returns>
        public Series npChart(float[] subgroup, float[] nonconform, int numbertested, Chart output)
        {
            //Assure the input all have the same number of items.
            if (subgroup.Length != nonconform.Length)
                throw new ArgumentException("Input arrays must all be the same length.", "subgroup, nonconform, numbertested");

            //c holds the total number of items (subgroups).
            int c = subgroup.Length;

            //Declare and initialize UCL, LCL and pBar.
            float UCL = 0;
            float LCL = 0;
            float pbar = 0;

            //Calculate pbar.
            for (int i = 0; i < c; i++)
            {
                pbar += nonconform[i];
            }
            pbar /= (c * numbertested);

            //Calculate UCL and LCL.
            UCL = (float)(numbertested * pbar + 3 * System.Math.Sqrt(numbertested * pbar * (1 - pbar)));
            LCL = (float)(numbertested * pbar - 3 * System.Math.Sqrt(numbertested * pbar * (1 - pbar)));

            //If LCL is less than zero, then it should be zero.
            if (LCL < 0)
                LCL = 0;

            //Create the npseries
            Series npseries = new Series("npseries");
            //Graph subgroup vs. non-conforming values.
            for (int i = 0; i < c; i++)
                npseries.Points.AddXY(subgroup[i], nonconform[i]);

            //Set the type to line series.
            npseries.ChartType = SeriesChartType.Line;

            //Add the series to the chart.
            output.Series.Add(npseries);

            //Add the lines to the graph as annotations.
            //CL line.
            addLineAnnotation(output.ChartAreas[npseries.ChartArea].AxisX, output.ChartAreas[npseries.ChartArea].AxisY,
                npseries.Points[0].XValue, pbar * 100, npseries.Points[c - 1].XValue, 0, output);

            //UCL line.
            addLineAnnotation(output.ChartAreas[npseries.ChartArea].AxisX, output.ChartAreas[npseries.ChartArea].AxisY,
                npseries.Points[0].XValue, UCL, npseries.Points[c - 1].XValue, 0, output);

            //LCL line.
            addLineAnnotation(output.ChartAreas[npseries.ChartArea].AxisX, output.ChartAreas[npseries.ChartArea].AxisY,
                npseries.Points[0].XValue, LCL, npseries.Points[c - 1].XValue, 0, output);

            //Add Text Annotations (line labels) if the user desired.
            if (myShowLineLabels)
            {
                addTextAnnotation("PBAR", output.ChartAreas[npseries.ChartArea].AxisX, output.ChartAreas[npseries.ChartArea].AxisY,
                    npseries.Points[0].XValue, pbar * 100, output);

                addTextAnnotation("UCL", output.ChartAreas[npseries.ChartArea].AxisX, output.ChartAreas[npseries.ChartArea].AxisY,
                    npseries.Points[0].XValue, UCL, output);

                addTextAnnotation("LCL", output.ChartAreas[npseries.ChartArea].AxisX, output.ChartAreas[npseries.ChartArea].AxisY,
                    npseries.Points[0].XValue, LCL, output);
            }

            //Scale the chart if the user has requested it.
            FitChart(UCL, npseries.ChartArea, output);

            //Return the series.
            return npseries;
        }

        /// <summary>
        /// Creates a U-Chart with UBar, UCL and LCL lines. A U-Chart is used when the desired chart
        /// is that of the number of non-conformities per inspection unit, where the inspection unit is variable size.
        /// </summary>
        /// <param name="subgroup">An array holding the subgroups. Must aline with the nonconform array.</param>
        /// <param name="nonconform">An array holding the non-conformity data associated with the subgroups. Must aline with the subgroups.</param>
        /// <param name="numbertested">The number of items in each subgroup.</param>
        /// <param name="output">The chart which will have the created series added to it.</param>
        /// <returns>Series which has been created and added to the output chart.</returns>
        public Series uChart(float[] subgroup, float[] nonconform, float[] numbertested, Chart output)
        {
            //Assure the input all have the same number of items.
            if ((subgroup.Length != nonconform.Length) || (subgroup.Length != numbertested.Length) || (nonconform.Length != numbertested.Length))
                throw new ArgumentException("Input arrays must all be the same length.", "subgroup, nonconform, numbertested");

            //c holds the total number of items (subgroups).
            int c = subgroup.Length;

            //Declare and initialize UCL, LCL and uBar.
            float[] UCL = new float[c];
            float[] LCL = new float[c];
            float ubar = 0;

            //Initialize temporary variables to hold temp sums for the ubar calculation
            float sumNumerator = 0;
            float sumDenominator = 0;

            //Calculate ubar.
            for (int i = 0; i < c; i++)
            {
                sumNumerator += nonconform[i];
                sumDenominator += numbertested[i];
            }
            ubar = sumNumerator / sumDenominator;

            //Calculate the Yvalues
            float[] yvalues = new float[c];
            for (int i = 0; i < c; i++)
                yvalues[i] = nonconform[i] / numbertested[i];

            //Calculate UCL and LCL.
            for (int i = 0; i < c; i++)
            {
                UCL[i] = (float)(ubar + 3 * System.Math.Sqrt(ubar / numbertested[i]));
                LCL[i] = (float)(ubar - 3 * System.Math.Sqrt(ubar / numbertested[i]));
            }

            //Create the series for the pchart data.
            Series useries = new Series("useries");
            //Graph subgroup vs. proportion.
            for (int i = 0; i < c; i++)
                useries.Points.AddXY(subgroup[i], yvalues[i]);

            //Set the series type to a line.
            useries.ChartType = SeriesChartType.Line;

            //Add the series to the chart.
            output.Series.Add(useries);

            //Add the lines to the graph as annotations.
            //UBAR line.
            addLineAnnotation(output.ChartAreas[useries.ChartArea].AxisX, output.ChartAreas[useries.ChartArea].AxisY,
                useries.Points[0].XValue, ubar, useries.Points[c - 1].XValue, 0, output);

            //Add the UCL and LCL line segments as individual line annotations.
            for (int i = 0; i < c - 1; i++)
            {
                //UCL line.
                addLineAnnotation(output.ChartAreas[useries.ChartArea].AxisX, output.ChartAreas[useries.ChartArea].AxisY,
                    subgroup[i], UCL[i], subgroup[i + 1] - subgroup[i], UCL[i + 1] - UCL[i], output);

                //LCL line.
                addLineAnnotation(output.ChartAreas[useries.ChartArea].AxisX, output.ChartAreas[useries.ChartArea].AxisY,
                    subgroup[i], LCL[i], subgroup[i + 1] - subgroup[i], LCL[i + 1] - LCL[i], output);
            }

            //Add Text Annotations (line labels) if the user desired.
            if (myShowLineLabels)
            {
                addTextAnnotation("UBAR", output.ChartAreas[useries.ChartArea].AxisX, output.ChartAreas[useries.ChartArea].AxisY,
                    useries.Points[0].XValue, ubar, output);

                addTextAnnotation("UCL", output.ChartAreas[useries.ChartArea].AxisX, output.ChartAreas[useries.ChartArea].AxisY,
                    useries.Points[0].XValue, UCL[0], output);

                addTextAnnotation("LCL", output.ChartAreas[useries.ChartArea].AxisX, output.ChartAreas[useries.ChartArea].AxisY,
                    useries.Points[0].XValue, LCL[0], output);
            }

            //Find the maximum UCL value and store the index of it.
            int maxUCL = 0;
            for (int i = 1; i < c; i++)
                if (UCL[maxUCL] < UCL[i])
                    maxUCL = i;

            //Scale the chart if the user has requested it.
            FitChart(UCL[maxUCL], useries.ChartArea, output);

            //Return the series.
            return useries;
        }

        /// <summary>
        /// Creates a Run Chart of the data and adds an average line. A run chart is a plot of the data without
        /// manipulation along with a line indicating where the average of the points is.
        /// </summary>
        /// <param name="subgroup">An array holding the subgroups. Must aline with the data array.</param>
        /// <param name="data">An array holding the data. Must aline with the subgroup array.</param>
        /// <param name="output">The chart which will have the created series added to it.</param>
        /// <returns>Series which has been created and added to the output chart.</returns>
        public Series runChart(float[] subgroup, float[] data, Chart output)
        {
            //Assure the input all have the same number of items.
            if (subgroup.Length != data.Length)
                throw new ArgumentException("Input arrays must all be the same length.", "subgroup, data");

            //c holds the total number of items (subgroups).
            int c = subgroup.Length;

            //Declare and initialize a variable to hold the average.
            float average = 0;

            //Create the series for the runchart data.
            Series runseries = new Series("runseries");
            //Graph subgroups vs. data.
            for (int i = 0; i < c; i++)
                runseries.Points.AddXY(subgroup[i], data[i]);

            //Set the series type to a line.
            runseries.ChartType = SeriesChartType.Line;

            //Add the series to the chart.
            output.Series.Add(runseries);

            //Calculate the average.
            average = (float)output.DataManipulator.Statistics.Mean("runseries");

            //Add the lines to the graph as annotations.
            //average line.
            addLineAnnotation(output.ChartAreas[runseries.ChartArea].AxisX, output.ChartAreas[runseries.ChartArea].AxisY,
                runseries.Points[0].XValue, average, runseries.Points[c - 1].XValue, 0, output);

            //Return the series.
            return runseries;
        }

        /// <summary>
        /// Creates an S-Chart of prepared data that can be evaluated. If the data is deemed to be in statistical control
        /// an XBAR chart can be created via XBARChart function.
        /// </summary>
        /// <param name="subgroup">An array holding the subgroups. Must aline with the data array. There must be at least 20 subgroups.</param>
        /// <param name="data">Array holding the Standard Deviation of each subgroup.</param>
        /// <param name="n">Number of measurements per subgroup. Must be between 2 and 9.</param>
        /// <param name="processStdDev">Variable returning the process standard deviation estimation.</param>
        /// <param name="output">The chart which will have the created series added to it.</param>
        /// <returns>Series which has been created and added to the output chart.</returns>
        public Series sChart(float[] subgroup, float[] data, int n, out float processStdDev, Chart output)
        {
            //Assure the input all have the same number of items.
            if (subgroup.Length != data.Length)
                throw new ArgumentException("Input arrays must all be the same length.", "subgroup, data");

            //Assure there are at least 20 subgroups
            if (subgroup.Length < 20)
                throw new ArgumentOutOfRangeException("There must be at least 20 subgroups.", "subgroup");

            //Assure n is between 2 and 9
            if (n < 2 || n > 9)
                throw new ArgumentOutOfRangeException("n must be between 1 and 9.", "n");

            //c holds the total number of items (subgroups).
            int c = subgroup.Length;

            //Declare and initialize a variable to hold sbar, UCL and LCL.
            float sbar = 0;
            float UCL = 0;
            float LCL = 0;

            //Declare the constants needed for calculations.
            float[] B3 ={ 0, 0, 0, 0, 0.03F, 0.118F, 0.185F, 0.239F };
            float[] B4 ={ 3.267F, 2.568F, 2.266F, 2.089F, 1.970F, 1.882F, 1.815F, 1.761F };
            float[] C4 ={ 0.7979F, 0.8862F, 0.9213F, 0.9400F, 0.9515F, 0.9594F, 0.9650F, 0.9693F };
            
            //Calculate sbar which is the center line of the standard deviation of each subgroup.
            for (int i = 0; i < c; i++)
                sbar += data[i];
            sbar /= c;

            //Calculate UCL and LCL.
            //It is n-2 as the number is between 2 and 9, but the array starts at 0.
            UCL = B4[n - 2] * sbar;
            LCL = B3[n - 2] * sbar;

            //If LCL is less than zero, then it should be zero.
            if (LCL < 0)
                LCL = 0;

            //Create the series for the sChart data.
            Series sseries = new Series("sseries");
            //Graph subgroups vs. data.
            for (int i = 0; i < c; i++)
                sseries.Points.AddXY(subgroup[i], data[i]);

            //Set the series type to a line.
            sseries.ChartType = SeriesChartType.Line;

            //Add the series to the chart.
            output.Series.Add(sseries);

            //Add the lines to the graph as annotations.
            //sbar line.
            addLineAnnotation(output.ChartAreas[sseries.ChartArea].AxisX, output.ChartAreas[sseries.ChartArea].AxisY,
                sseries.Points[0].XValue, sbar, sseries.Points[c - 1].XValue, 0, output);

            //UCL line.
            addLineAnnotation(output.ChartAreas[sseries.ChartArea].AxisX, output.ChartAreas[sseries.ChartArea].AxisY,
                sseries.Points[0].XValue, UCL, sseries.Points[c - 1].XValue, 0, output);

            //LCL line.
            addLineAnnotation(output.ChartAreas[sseries.ChartArea].AxisX, output.ChartAreas[sseries.ChartArea].AxisY,
                sseries.Points[0].XValue, LCL, sseries.Points[c - 1].XValue, 0, output);

            //Add Text Annotations (line labels) if the user desired.
            if (myShowLineLabels)
            {
                addTextAnnotation("SBAR", output.ChartAreas[sseries.ChartArea].AxisX, output.ChartAreas[sseries.ChartArea].AxisY,
                    sseries.Points[0].XValue, sbar, output);

                addTextAnnotation("UCL", output.ChartAreas[sseries.ChartArea].AxisX, output.ChartAreas[sseries.ChartArea].AxisY,
                    sseries.Points[0].XValue, UCL, output);

                addTextAnnotation("LCL", output.ChartAreas[sseries.ChartArea].AxisX, output.ChartAreas[sseries.ChartArea].AxisY,
                    sseries.Points[0].XValue, LCL, output);
            }

            //Scale the chart if the user has requested it.
            FitChart(UCL, sseries.ChartArea, output);

            //Calculate process standard deviation.
            processStdDev = (float)((sbar / C4[n - 2]) * System.Math.Sqrt(1 - System.Math.Pow(C4[n - 2], 2)));

            //Set the sBar class variable and clear rBar.
            this.mysBar = sbar;
            this.myrBar = 0;

            //Store the n value for use by XBAR.
            this.mynValue = n;

            //Return the series.
            return sseries;
        }

        /// <summary>
        /// Creates an R-Chart of prepared data that can be evaluated. If the data is deemed to be in statistical control
        /// an XBAR chart can be created via XBARChart function.
        /// </summary>
        /// <param name="subgroup">An array holding the subgroups. Must aline with the data array. There must be at least 20 subgroups.</param>
        /// <param name="data">Array holding the Range (biggest value - smallest value) of each subgroup.</param>
        /// <param name="n">Number of measurements per subgroup. Must be between 2 and 9.</param>
        /// <param name="processStdDev">Variable returning the process standard deviation estimation.</param>
        /// <param name="output">The chart which will have the created series added to it.</param>
        /// <returns>Series which has been created and added to the output chart.</returns>
        public Series rChart(float[] subgroup, float[] data, int n, out float processStdDev, Chart output)
        {
            //Assure the input all have the same number of items.
            if (subgroup.Length != data.Length)
                throw new ArgumentException("Input arrays must all be the same length.", "subgroup, data");

            //Assure there are at least 20 subgroups
            if (subgroup.Length < 20)
                throw new ArgumentOutOfRangeException("There must be at least 20 subgroups.", "subgroup");

            //Assure n is between 2 and 9
            if (n < 2 || n > 9)
                throw new ArgumentOutOfRangeException("n must be between 1 and 9.", "n");

            //c holds the total number of items (subgroups).
            int c = subgroup.Length;

            //Declare and initialize a variable to hold sbar, UCL and LCL.
            float rbar = 0;
            float UCL = 0;
            float LCL = 0;

            //Declare the constants needed for calculations.
            float[] D3 ={ 0, 0, 0, 0, 0, 0.076F, 0.136F, 0.184F };
            float[] D4 ={ 3.267F, 2.574F, 2.282F, 2.114F, 2.004F, 1.924F, 1.864F, 1.816F };
            float[] D2 ={ 1.128F, 1.693F, 2.059F, 2.326F, 2.534F, 2.704F, 2.847F, 2.970F };

            //Calculate rbar which is the center line of the range of each subgroup.
            for (int i = 0; i < c; i++)
                rbar += data[i];
            rbar /= c;

            //Calculate UCL and LCL.
            //It is n-2 as the number is between 2 and 9, but the array starts at 0.
            UCL = D4[n - 2] * rbar;
            LCL = D3[n - 2] * rbar;

            //If LCL is less than zero, then it should be zero.
            if (LCL < 0)
                LCL = 0;

            //Create the series for the sChart data.
            Series rseries = new Series("rseries");
            //Graph subgroups vs. data.
            for (int i = 0; i < c; i++)
                rseries.Points.AddXY(subgroup[i], data[i]);

            //Set the series type to a line.
            rseries.ChartType = SeriesChartType.Line;

            //Add the series to the chart.
            output.Series.Add(rseries);

            //Add the lines to the graph as annotations.
            //sbar line.
            addLineAnnotation(output.ChartAreas[rseries.ChartArea].AxisX, output.ChartAreas[rseries.ChartArea].AxisY,
                rseries.Points[0].XValue, rbar, rseries.Points[c - 1].XValue, 0, output);

            //UCL line.
            addLineAnnotation(output.ChartAreas[rseries.ChartArea].AxisX, output.ChartAreas[rseries.ChartArea].AxisY,
                rseries.Points[0].XValue, UCL, rseries.Points[c - 1].XValue, 0, output);

            //LCL line.
            addLineAnnotation(output.ChartAreas[rseries.ChartArea].AxisX, output.ChartAreas[rseries.ChartArea].AxisY,
                rseries.Points[0].XValue, LCL, rseries.Points[c - 1].XValue, 0, output);

            //Add Text Annotations (line labels) if the user desired.
            if (myShowLineLabels)
            {
                addTextAnnotation("RBAR", output.ChartAreas[rseries.ChartArea].AxisX, output.ChartAreas[rseries.ChartArea].AxisY,
                    rseries.Points[0].XValue, rbar, output);

                addTextAnnotation("UCL", output.ChartAreas[rseries.ChartArea].AxisX, output.ChartAreas[rseries.ChartArea].AxisY,
                    rseries.Points[0].XValue, UCL, output);

                addTextAnnotation("LCL", output.ChartAreas[rseries.ChartArea].AxisX, output.ChartAreas[rseries.ChartArea].AxisY,
                    rseries.Points[0].XValue, LCL, output);
            }

            //Scale the chart if the user has requested it.
            FitChart(UCL, rseries.ChartArea, output);

            //Calculate process standard deviation.
            processStdDev = (float)(rbar / D2[n - 2]);

            //Set the rBar class variable and clear sBar.
            this.myrBar = rbar;
            this.mysBar = 0;

            //Store the n value for use by XBAR.
            this.mynValue = n;

            //Return the series.
            return rseries;
        }

        /// <summary>
        /// Creates an XBAR chart of the prepared data. sChart or rChart must have already been called to create a XBAR chart.
        /// </summary>
        /// <param name="subgroup">An array holding the subgroups. Must aline with the data array.</param>
        /// <param name="data">Array holding the Mean of each subgroup. Must aline with the subgroup array.</param>
        /// <param name="output">The chart which will have the created series added to it.</param>
        /// <returns>Series which has been created and added to the output chart.</returns>
        public Series XBARChart(float[] subgroup, float[] data, Chart output)
        {
            //Call the private function with no MRBAR to graph a separate XBAR chart.
            return XBARChartImplementation(subgroup, data, output, 0);
        }

        /// <summary>
        /// Creates an Individuals Chart of the data and places the MRBar, XBAR, UCL and LCL upon it.
        /// </summary>
        /// <param name="subgroup">An array holding the subgroups. Must aline with the data array.</param>
        /// <param name="data">An array holding the data. Must aline with the subgroup array.</param>
        /// <param name="processStdDev">Variable returning the process standard deviation estimation.</param>
        /// <param name="output">The chart which will have the created series added to it.</param>
        /// <returns>Series which has been created and added to the output chart.</returns>
        public Series individualsChart(float[] subgroup, float[] data, out float processStdDev, Chart output)
        {
            //Assure the input all have the same number of items.
            if (subgroup.Length != data.Length)
                throw new ArgumentException("Input arrays must all be the same length.", "subgroup, data");

            //c holds the total number of items (subgroups).
            int c = subgroup.Length;

            //Declare and initialize MRBAR.
            float mrbar = 0;

            //Calculate cbar.
            for (int i = 0; i < c-1; i++)
            {
                mrbar += (float)System.Math.Abs(data[i + 1] - data[i]);
            }
            mrbar /= c - 1;

            //Calculate the process standard deviation.
            processStdDev = (float)(mrbar / 1.128);

            //Return the series
            return XBARChartImplementation(subgroup, data, output, mrbar);
        }

        /// <summary>
        /// Creates an XBAR chart of the prepared data. This function contains the implementation for the public function with one extra
        /// parameter for MRBAR. If MRBAR is specified, then only one chart is created with all the values.
        /// </summary>
        /// <param name="subgroup">An array holding the subgroups. Must aline with the data array.</param>
        /// <param name="data">Array holding the Mean of each subgroup. Must aline with the subgroup array.</param>
        /// <param name="output">The chart which will have the created series added to it.</param>
        /// <param name="mrbar">The value of MRBAR if it has been calculated by Individuals Chart.</param>
        /// <returns>Series which has been created and added to the output chart.</returns>
        private Series XBARChartImplementation(float[] subgroup, float[] data, Chart output, float mrbar)
        {
            //Assure the input all have the same number of items.
            if (subgroup.Length != data.Length)
                throw new ArgumentException("Input arrays must all be the same length.", "subgroup, nonconform, numbertested");

            //Assure that either rBar or sBar have a value, and n has a value. If MRBAR has been specified, do not check.
            if (mrbar == 0)
                if ((this.myrBar == 0 && this.mysBar == 0) || (this.mynValue < 2 || this.mynValue > 9))
                    throw new ArgumentException("sChart or rChart must be called before XBAR.");

            //c holds the total number of items (subgroups).
            int c = subgroup.Length;

            //Declare and initialize a variable to hold sbar, UCL and LCL.
            float xbar = 0;
            float UCL = 0;
            float LCL = 0;

            //Declare the constants needed for calculations.
            float[] A2 ={ 1.880F, 1.023F, 0.729F, 0.577F, 0.483F, 0.419F, 0.373F, 0.337F };
            float[] A3 ={ 2.659F, 1.954F, 1.628F, 1.427F, 1.287F, 1.182F, 1.099F, 1.032F };

            //Calculate xbar, which is the mean of all the subgroup means.
            for (int i = 0; i < c; i++)
                xbar += data[i];
            xbar /= c;

            //Calculate UCL and LCL.
            //Switch based on if we're calculating from a rChart or a sChart, or if a MRBAR was given.
            //It is n-2 as the number is between 2 and 9, but the array starts at 0
            if (mrbar != 0)
            {
                UCL = (float)(xbar + 2.66 * mrbar);
                LCL = (float)(xbar - 2.66 * mrbar);
            }
            else if (this.mysBar != 0)
            {
                UCL = xbar + A3[this.mynValue - 2] * this.mysBar;
                LCL = xbar - A3[this.mynValue - 2] * this.mysBar;
            }
            else if (this.myrBar != 0)
            {
                UCL = xbar + A2[this.mynValue - 2] * this.myrBar;
                LCL = xbar - A2[this.mynValue - 2] * this.myrBar;
            }

            //If LCL is less than zero, then it should be zero.
            if (LCL < 0)
                LCL = 0;

            //Create the series for the xbar data.
            Series xbarseries = new Series("xbarseries");
            //Graph subgroups vs. data.
            for (int i = 0; i < c; i++)
                xbarseries.Points.AddXY(subgroup[i], data[i]);

            //Set the series type to a line.
            xbarseries.ChartType = SeriesChartType.Line;

            //Add the series to the chart.
            output.Series.Add(xbarseries);

            //Add the lines to the graph as annotations.
            //xbar line.
            addLineAnnotation(output.ChartAreas[xbarseries.ChartArea].AxisX, output.ChartAreas[xbarseries.ChartArea].AxisY,
                xbarseries.Points[0].XValue, xbar, xbarseries.Points[c - 1].XValue, 0, output);

            //UCL line.
            addLineAnnotation(output.ChartAreas[xbarseries.ChartArea].AxisX, output.ChartAreas[xbarseries.ChartArea].AxisY,
                xbarseries.Points[0].XValue, UCL, xbarseries.Points[c - 1].XValue, 0, output);

            //LCL line.
            addLineAnnotation(output.ChartAreas[xbarseries.ChartArea].AxisX, output.ChartAreas[xbarseries.ChartArea].AxisY,
                xbarseries.Points[0].XValue, LCL, xbarseries.Points[c - 1].XValue, 0, output);

            //MBAR line if it has been specified
            if (mrbar != 0)
                addLineAnnotation(output.ChartAreas[xbarseries.ChartArea].AxisX, output.ChartAreas[xbarseries.ChartArea].AxisY,
                    xbarseries.Points[0].XValue, mrbar, xbarseries.Points[c - 1].XValue, 0, output);

            //Add Text Annotations (line labels) if the user desired.
            if (myShowLineLabels)
            {
                addTextAnnotation("XBAR", output.ChartAreas[xbarseries.ChartArea].AxisX, output.ChartAreas[xbarseries.ChartArea].AxisY,
                    xbarseries.Points[0].XValue, xbar, output);

                addTextAnnotation("UCL", output.ChartAreas[xbarseries.ChartArea].AxisX, output.ChartAreas[xbarseries.ChartArea].AxisY,
                    xbarseries.Points[0].XValue, UCL, output);

                addTextAnnotation("LCL", output.ChartAreas[xbarseries.ChartArea].AxisX, output.ChartAreas[xbarseries.ChartArea].AxisY,
                    xbarseries.Points[0].XValue, LCL, output);

                if (mrbar!=0)
                    addTextAnnotation("MRBAR", output.ChartAreas[xbarseries.ChartArea].AxisX, output.ChartAreas[xbarseries.ChartArea].AxisY,
                        xbarseries.Points[0].XValue, mrbar, output);
            }

            //Scale the chart if the user has requested it.
            FitChart(UCL, xbarseries.ChartArea, output);
            
            //Return the series.
            return xbarseries;
        }
        #endregion

        #region Math Methods
        /// <summary>
        /// Calculates the mean of an array of numbers.
        /// </summary>
        /// <param name="data">The input array of items of which the mean will be calculated.</param>
        /// <returns>The mean of the data.</returns>
        public float Mean(float[] data)
        {
            //Create a temporary variable to hold the sum.
            float sum = 0;

            //Calculate the sum of the data items.
            for (int i = 0; i < data.Length; i++)
                sum += data[i];

            //Divide them by the total number of items.
            sum /= data.Length;

            //Return the mean.
            return sum;
        }

        /// <summary>
        /// Calculates the range of an array of numbers.
        /// </summary>
        /// <param name="data">The input array of items of which the range will be calculated.</param>
        /// <returns>The range of the data.</returns>
        public float Range(float[] data)
        {
            //Create two variables: one to hold the index of the largest value and one to hold the index of the smallest value.
            int maxIndex = 0;
            int minIndex = 0;

            //Find the largest and smallest values in the array.
            for (int i = 1; i < data.Length; i++)
            {
                if (data[maxIndex] < data[i])
                    maxIndex = i;
                if (data[minIndex] > data[i])
                    minIndex = i;
            }

            //Return the Range.
            return (data[maxIndex] - data[minIndex]);
        }

        /// <summary>
        /// Calculates the standard deviation of an array of numbers.
        /// </summary>
        /// <param name="data">The input array of items of which the standard deviation will be calculated.</param>
        /// <returns>The standard deviation of the data.</returns>
        public float StandardDeviation(float[] data)
        {
            //Create two variables: one to hold the sum of the deviations, and one to hold the mean of the data.
            float sumdeviation = 0;
            float mean = 0;

            //Calculate the mean.
            mean = Mean(data);

            //Calculate the sum of the squared deviations.
            for (int i = 0; i < data.Length; i++)
                sumdeviation += (float)System.Math.Pow(data[i] - mean, 2);

            //Return the standard deviation.
            return (float)System.Math.Sqrt(sumdeviation / (data.Length - 1));
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Scales the chart so that the UCL line will always be within the chart.
        /// </summary>
        /// <param name="UCL">The maximum UCL value.</param>
        /// <param name="ChartArea">The name of the chart area we are plotting to.</param>
        /// <param name="output">The chart which contains the chart area.</param>
        private void FitChart(float UCL, string ChartArea, Chart output)
        {
            //Check to see if scaling is enabled.
            if (myAutoFitLines)
            {
                //Force the chartarea to recalculate the axis values so that we can find the Y-axis maximum.
                output.ChartAreas[ChartArea].RecalculateAxesScale();

                //Check if UCL is outside the maximum Y value.
                if (UCL > (float)output.ChartAreas[ChartArea].AxisY.Maximum)
                    //If so set the Y-axis maximum to be the UCL value.
                    output.ChartAreas[ChartArea].AxisY.Maximum = UCL;
            }
        }

        /// <summary>
        /// Function to add a line annotation to the desired chart in the format which is followed by
        /// all the line annotations in this add-on.
        /// </summary>
        /// <param name="AxisX">X-Axis that the line annotation is to use for co-ordinates.</param>
        /// <param name="AxisY">Y-Axis that the line annotation is to use for co-ordinates.</param>
        /// <param name="X">X value for the start of the line.</param>
        /// <param name="Y">Y value for the start of the line.</param>
        /// <param name="Width">Width of the line.</param>
        /// <param name="Height">Height of the line.</param>
        /// <param name="output">The chart that the line annotation is being added to.</param>
        private void addLineAnnotation(Axis AxisX, Axis AxisY, double X, double Y, double Width, double Height, Chart output)
        {
            //Create a new line annotation.
            LineAnnotation lineAnnotation = new LineAnnotation();

            //Set each property to the parameters passed in.
            lineAnnotation.AxisX = AxisX;
            lineAnnotation.AxisY = AxisY;
            lineAnnotation.Y = Y;
            lineAnnotation.X = X;
            lineAnnotation.Height = Height;
            lineAnnotation.Width = Width;

            //Turn off relative size to get graph-oriented co-ordinates and set the line color.
            lineAnnotation.IsSizeAlwaysRelative = false;
            lineAnnotation.LineColor = myLineColor;

            //Add the annotation to the chart.
            output.Annotations.Add(lineAnnotation);
        }

        /// <summary>
        /// Function to add text as an annotation to the chart.
        /// </summary>
        /// <param name="text">The text that we wish to display.</param>
        /// <param name="AxisX">X-Axis that the text annotation is to use for co-ordinates.</param>
        /// <param name="AxisY">Y-Axis that the text annotation is to use for co-ordinates.</param>
        /// <param name="X">X value for the start of the text.</param>
        /// <param name="Y">Y value for the start of the text.</param>
        /// <param name="output">The chart that the line annotation is being added to.</param>
        private void addTextAnnotation(string text, Axis AxisX, Axis AxisY, double X, double Y, Chart output)
        {
            //Create a new line annotation.
            TextAnnotation textAnnotation = new TextAnnotation();

            //Set each property to the parameters passed in.
            textAnnotation.AxisX = AxisX;
            textAnnotation.AxisY = AxisY;
            textAnnotation.Y = Y;
            textAnnotation.X = X;
            textAnnotation.Text = text;

            //Turn off relative size to get graph-oriented co-ordinates and set the aesthetic properties.
            textAnnotation.IsSizeAlwaysRelative = false;
            textAnnotation.ForeColor = myForeColor;
            textAnnotation.Font = myFont;

            //Add the annotation to the chart.
            output.Annotations.Add(textAnnotation);
        }
        #endregion
    }
}
