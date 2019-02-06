//=================================================================
//  File:		FIRFilters.cs
//
//  Namespace:	System.Windows.Forms.DataVisualization.Charting.Utilities
//
//	Classes:	FIRFilters, FFT
//
//  Purpose:	Used to perform digital filters on charts
//
//===================================================================
// Chart Control for .NET Framework
// Copyright © Microsoft Corporation, all rights reserved
//===================================================================

using System;
//using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace System.Windows.Forms.DataVisualization.Charting.Utilities
{
    /// <summary>
    /// Helper class which implements the filtering functions. Currently Low Pass, High Pass and
    /// Band Pass are implemented.
    /// </summary>
    class FIRFilters
    {
        #region Members
        /// <summary>
        /// The number of samples is the same as the number of points
        /// </summary>
        private int mySamples;

        /// <summary>
        /// Holds the coefficient from the window function
        /// </summary>
        private float[] myCoeff;

        /// <summary>
        /// Holds the series which has the input data
        /// </summary>
        private Series myInputSeries;

        /// <summary>
        /// Holds the series which we are outputting to
        /// </summary>
        private Series myFilterSeries;

        /// <summary>
        /// FFT algorithm object
        /// </summary>
        private FFT myFFT;

        /// <summary>
        /// Holds the current algorithm selected. Enumeration type is drawn from the FFT object.
        /// </summary>
        public FFT.Algorithm CurrentAlgorithm;

        private float myFreqFrom;
        private float myFreqTo;
        private float myAttenuation;
        private float myBand;
        private float myAlpha;
        private int myTaps;
        private int myOrder;
        #endregion

        #region Properties
        /// <summary>
        /// The starting passband frequency, must be lower than ending frequency.
        /// </summary>
        public float FreqFrom
        {
            get { return myFreqFrom; }
            set { myFreqFrom = value; }
        }

        /// <summary>
        /// The ending passband frequency, must be higher than starting frequency.
        /// </summary>
        public float FreqTo
        {
            get { return myFreqTo; }
            set { myFreqTo = value; }
        }

        /// <summary>
        /// Stopband attenuation
        /// </summary>
        public float StopBandAttenuation
        {
            get { return myAttenuation; }
            set {
                    myAttenuation = value;
                    this.myFFT.StopBandAttenuation = myAttenuation;
                }
        }

        /// <summary>
        /// Transition band
        /// </summary>
        public float TransitionBand
        {
            get { return myBand; }
            set {
                    myBand = value;
                    this.myFFT.TransitionBand = myBand;
                }
        }

        /// <summary>
        /// Alpha value used for the Kaiser algorithm.
        /// </summary>
        public float Alpha
        {
            get { return myAlpha; }
            set {
                    myAlpha = value;
                    this.myFFT.Alpha = myAlpha;
                }
        }

        /// <summary>
        /// Number of taps to be used. Taps is the number of samples processed at any one time.
        /// </summary>
        public int Taps
        {
            get { return myTaps; }
            set { myTaps = value; }
        }

        /// <summary>
        /// Filter order. Must be an even number.
        /// </summary>
        public int Order
        {
            get { return myOrder; }
            set
            {
                //Assure value is even
                if ((value % 2) == 0)
                {
                    myOrder = value;
                    this.myFFT.Order = myOrder;
                }
                else
                    throw new ArgumentOutOfRangeException("Order", "Filter order must be an even number.");
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Main constructor. Resets all settings within the FFT algorithm object.
        /// </summary>
        public FIRFilters()
        {
            //Create a new FFT object
            this.myFFT = new FFT();

            //Default algorithm to Kaiser
            this.CurrentAlgorithm = FFT.Algorithm.Kaiser;

            //Default taps to 35
            this.myTaps = 35;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Performs a low pass filter. Output series will be cleared before being
        /// output to. If passband start and end frequencies are left at 0, defaults are used.
        /// </summary>
        /// <param name="iseries">Input series that contains input data. Input Y-Values must be contained in YValues[0] or unexpected output will occur</param>
        /// <param name="oseries">Output series to which filter will be written. Output Y-Values are written to YValues[0]</param>
        public void LowPassFilter(Series iseries, Series oseries)
        {
            //If no start and end frequencies are specified, default low pass frequency range to:
            //0 - 1000hz
            if (this.myFreqFrom == 0.0f && this.myFreqTo == 0.0f)
            {
                this.myFFT.FreqFrom = 0.0f;
                this.myFFT.FreqTo = 1000.0f;
            }
            else
            {
                this.myFFT.FreqFrom = this.myFreqFrom;
                this.myFFT.FreqTo = this.myFreqTo;
            }

            //Generate the actual coefficients
            this.myCoeff = this.myFFT.GenerateCoefficients(FFT.FilterType.LowPass, CurrentAlgorithm);

            //Filter the series based on the coefficients generated
            Filter(iseries, oseries);
        }

        /// <summary>
        /// Performs a high pass filter. Output series will be cleared before being
        /// output to. If passband start and end frequencies are left at 0, defaults are used.
        /// </summary>
        /// <param name="iseries">Input series that contains input data. Input Y-Values must be contained in YValues[0] or unexpected output will occur</param>
        /// <param name="oseries">Output series to which filter will be written. Output Y-Values are written to YValues[0]</param>
        public void HighPassFilter(Series iseries, Series oseries)
        {
            //If no start and end frequencies are specified, default high pass frequency range to:
            //2000 - 4000hz
            if (this.myFreqFrom == 0.0f && this.myFreqTo == 0.0f)
            {
                this.myFFT.FreqFrom = 2000.0f;
                this.myFFT.FreqTo = 4000.0f;
            }
            else
            {
                this.myFFT.FreqFrom = this.myFreqFrom;
                this.myFFT.FreqTo = this.myFreqTo;
            }

            //Generate the actual coefficients
            this.myCoeff = this.myFFT.GenerateCoefficients(FFT.FilterType.HighPass, CurrentAlgorithm);

            //Filter the series based on the coefficients generated
            Filter(iseries, oseries);
        }

        /// <summary>
        /// Performs a band pass filter. Output series will be cleared before being
        /// output to. If passband start and end frequencies are left at 0, defaults are used.
        /// </summary>
        /// <param name="iseries">Input series that contains input data. Input Y-Values must be contained in YValues[0] or unexpected output will occur</param>
        /// <param name="oseries">Output series to which filter will be written. Output Y-Values are written to YValues[0]</param>
        public void BandPassFilter(Series iseries, Series oseries)
        {
            //If no start and end frequencies are specified, default band pass frequency range to:
            //1000 - 1000hz
            if (this.myFreqFrom == 0.0f && this.myFreqTo == 0.0f)
            {
                this.myFFT.FreqFrom = 1000.0f;
                this.myFFT.FreqTo = 1000.0f;
            }
            else
            {
                this.myFFT.FreqFrom = this.myFreqFrom;
                this.myFFT.FreqTo = this.myFreqTo;
            }

            //Generate the actual coefficients
            this.myCoeff = this.myFFT.GenerateCoefficients(FFT.FilterType.BandPass, CurrentAlgorithm);

            //Filter the series based on the coefficients generated
            Filter(iseries, oseries);
        }
        #endregion

        #region Initialization
        /// <summary>
        /// Initializes the FIRFilters object by setting the input and output series members for use
        /// by the filter.
        /// </summary>
        /// <param name="iseries">Input series that contains input data</param>
        /// <param name="oseries">Output series to which filter will be written</param>
        private void SetIOSeries(Series iseries, Series oseries)
        {
            this.myInputSeries = iseries;
            this.myFilterSeries = oseries;

            //Samples is the number of points contained in the input
            this.mySamples = myInputSeries.Points.Count;
        }
        #endregion

        #region Filter
        /// <summary>
        /// Performs the actual filter. Coefficients should have already be generated by the calling
        /// function, this function merely applies them and physically adds the points to the output series.
        /// </summary>
        /// <param name="iseries">Input series that contains input data</param>
        /// <param name="oseries">Output series to which filter will be written</param>
        private void Filter(Series iseries, Series oseries)
        {
            float[] x = new float[myTaps];
            float y;

            //Set the series
            SetIOSeries(iseries, oseries);

            //Clear series
            myFilterSeries.Points.Clear();

            //Initialize x
            for (int i = 1; i < myTaps; i++)
                x[i] = 0.0f;

            //Loop through every data point
            for (int i = 0; i < mySamples; i++)
            {
                //Initialize y
                y = 0.0f;

                //Obtain the data value (Y value) at the specified X value (i)
                x[0] = Convert.ToSingle(myInputSeries.Points[i].YValues[0]);

                //Loop through from 0 to number of taps and calculate the sum
                try
                {
                    for (int j = 0; j < myTaps; j++)
                        y = y + (x[j] * myCoeff[j]);
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message + " Check filter order.");
                    throw;
                }

                //Shift all x values by 1 to the right
                for (int j = myTaps - 1; j > 0; j--)
                    x[j] = x[j - 1];

                //Add the y value to the output series at the current x value
                myFilterSeries.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(i, y));
            }
        }
        #endregion
    }
}
