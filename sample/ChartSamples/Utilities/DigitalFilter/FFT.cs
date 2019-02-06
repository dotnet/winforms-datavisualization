//=================================================================
//  File:		FFT.cs
//
//  Namespace:	System.Windows.Forms.DataVisualization.Charting.Utilities
//
//	Classes:	FFT
//
//  Purpose:	Used for the fast fourier transformation algorithm
//
//===================================================================
// Chart Control for .NET Framework
// Copyright © Microsoft Corporation, all rights reserved
//===================================================================

using System;
//using System.Collections.Generic;
using System.Text;

namespace System.Windows.Forms.DataVisualization.Charting.Utilities
{
    /// <summary>
    /// Helper class which implements the various window functions for determination of the filter
    /// coefficients.
    /// </summary>
    class FFT
    {
        #region Members
        /// <summary>
        /// Filter type enumeration for identification of what type of filter we want coefficients
        /// for.
        /// </summary>
        public enum FilterType { HighPass, LowPass, BandPass };

        /// <summary>
        /// Algorithm enumeration for choice of algorithm
        /// </summary>
        public enum Algorithm { Kaiser, Hann, Hamming, Blackman, Rectangular };

        private float myRate;
        private float myFreqFrom;
        private float myFreqTo;
        private float myAttenuation;
        private float myBand;
        private float myAlpha;
        private int myOrder;

        /// <summary>
        /// Shannon sampling frequency
        /// </summary>
        private float myFS;
        #endregion

        #region Properties
        /// <summary>
        /// Sampling rate
        /// </summary>
        public float Rate
        {
            get { return myRate; }
            set
            {
                myRate = value;
                myFS = 0.5f * myRate;
            }
        }

        /// <summary>
        /// Starting frequency for passband. Must be lower than the ending frequency.
        /// </summary>
        public float FreqFrom
        {
            get { return myFreqFrom; }
            set { myFreqFrom = value; }
        }

        /// <summary>
        /// Ending frequency for passband. Must be higher than the starting frequency.
        /// </summary>
        public float FreqTo
        {
            get { return myFreqTo; }
            set { myFreqTo = value; }
        }

        /// <summary>
        /// Stopband attenuation.
        /// </summary>
        public float StopBandAttenuation
        {
            get { return myAttenuation; }
            set { myAttenuation = value; }
        }

        /// <summary>
        /// Transition band.
        /// </summary>
        public float TransitionBand
        {
            get { return myBand; }
            set { myBand = value; }
        }

        /// <summary>
        /// Alpha value used for the Kaiser algorithm.
        /// </summary>
        public float Alpha
        {
            get { return myAlpha; }
            set { myAlpha = value; }
        }

        /// <summary>
        /// Filter order. Must be an even number.
        /// </summary>
        public int Order
        {
            get { return myOrder; }
            set { myOrder = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Construct a FFT instance and initialize with default values.
        /// </summary>
        public FFT()
        {
            //default rate to 8000
            Rate = 8000;

            //default attenuation to 60db
            this.myAttenuation = 60;

            //default transition band to 500hz
            this.myBand = 500;

            //default order to 0 so that we'll know if it was changed by the user or not
            this.myOrder = 0;

            //default Alpha to 4
            this.myAlpha = 4;
        }
        #endregion

        #region Mathematical Functions
        /// <summary>
        /// Bessel is the zeroth order Bessel function which is used in the Kaiser window.
        /// This is a polynomial approximation of the zeroth order modified Bessel function found in:
        /// W.H. Press, B.P. Flannery, S.A. Teukolsky, and W.T. Vetterling.
        /// Numerical Recipes in C: The Art of Scientific Computing.
        /// Cambridge UP, 1988.
        /// P. 237
        /// </summary>
        /// <param name="x">Input number which the Bessel will be performed on</param>
        private float Bessel(float x)
        {
            double ax, ans;
            double y;

            ax = System.Math.Abs(x);
            if (ax < 3.75)
            {
                y = x / 3.75;
                y *= y;
                ans = 1.0 + y * (3.5156229 + y * (3.0899424 + y * (1.2067492
                    + y * (0.2659732 + y * (0.360768e-1 + y * 0.45813e-2)))));
            }
            else
            {
                y = 3.75 / ax;
                ans = (System.Math.Exp(ax) / System.Math.Sqrt(ax)) * (0.39894228 + y * (0.1328592e-1
                    + y * (0.225319e-2 + y * (-0.157565e-2 + y * (0.916281e-2
                    + y * (-0.2057706e-1 + y * (0.2635537e-1 + y * (-0.1647633e-1
                    + y * 0.392377e-2))))))));
            }

            return (float)ans;
        }
        #endregion

        #region Generate Coefficients
        /// <summary>
        /// Calculate the coefficients to be used by the filter function.
        /// </summary>
        /// <param name="filterType">Enum type which specifies the filter to be performed.</param>
        /// <param name="alg">Enum type which specifies which algorithm to be used for the window
        /// algorithm.</param>
        public float[] GenerateCoefficients(FilterType filterType, Algorithm alg)
        {
            //Calculate order if it hasn't been set
            if (this.myOrder == 0)
                this.myOrder = (int)(((this.myAttenuation - 7.95f) / (this.myBand * 14.36f / this.myFS) + 1.0f) * 2.0f) - 1;

            float[] window = new float[(this.myOrder / 2) + 1];
            float[] coEff = new float[this.myOrder + 1];
            float ps;
            float pe;
            const float PI = (float)System.Math.PI;
            int o2 = this.myOrder / 2;

            //Switch based on algorithm
            switch (alg)
            {
                case Algorithm.Kaiser:
                    //Kaiser Window function
                    for (int i = 1; i <= o2; i++)
                    {
                        window[i] = Bessel(this.myAlpha * (float)System.Math.Sqrt(1.0f - (float)System.Math.Pow((float)i / o2, 2))) / Bessel(this.myAlpha);
                    }

                    //Stopband attenuation and transition band should be set by the user
                    break;

                case Algorithm.Hann:
                    //Hann window function
                    for (int i = 1; i <= o2; i++)
                    {
                        window[i] = 0.5f + 0.5f * (float)System.Math.Cos((PI / (o2 + 1)) * i);
                    }

                    //Set the min stopband attenuation
                    this.StopBandAttenuation = 44.0f;

                    //Set the transition band
                    this.TransitionBand = 6.22f * this.myFS / this.myOrder;
                    break;

                case Algorithm.Hamming:
                    //Hamming window function
                    for (int i = 1; i <= o2; i++)
                    {
                        window[i] = 0.54f + 0.46f * (float)System.Math.Cos((PI / o2) * i);
                    }

                    //Set the min stopband attenuation
                    this.StopBandAttenuation = 53.0f;

                    //Set the transition band
                    this.TransitionBand = 6.64f * this.myFS / this.myOrder;
                    break;

                case Algorithm.Blackman:
                    //Blackman window function
                    for (int i = 1; i <= o2; i++)
                    {
                        window[i] = 0.42f + 0.5f * (float)Math.Cos((PI / o2) * i) + 0.08f * (float)Math.Cos(2.0f * (PI / o2) * i);
                    }

                    //Set the min stopband attenuation
                    this.StopBandAttenuation = 74.0f;

                    //Set the transition band
                    this.TransitionBand = 11.13f * this.myFS / this.myOrder;
                    break;

                case Algorithm.Rectangular:
                    //Rectangular window function
                    for (int i = 1; i <= o2; i++)
                    {
                        window[i] = 1.0f;
                    }

                    //Set the min stopband attenuation
                    this.StopBandAttenuation = 21.0f;

                    //Set the transition band
                    this.TransitionBand = 1.84f * this.myFS / this.myOrder;
                    break;

                default:
                    //Zero all values if nothing was set (error)
                    for (int i = 1; i <= o2; i++)
                    {
                        window[i] = 0.0f;
                    }
                    break;
            }

            //Switch based on filtertype
            switch (filterType)
            {
                case FilterType.BandPass:
                    pe = PI / 2 * (this.FreqTo - this.FreqFrom + this.myBand) / this.myFS;
                    ps = PI / 2 * (this.FreqFrom + this.FreqTo) / this.myFS;
                    break;

                case FilterType.LowPass:
                    pe = PI * (this.FreqTo + this.myBand / 2) / this.myFS;
                    ps = 0.0f;
                    break;

                case FilterType.HighPass:
                    pe = PI * (1.0f - (this.FreqFrom - this.myBand / 2) / this.myFS);
                    ps = PI;
                    break;

                default:
                    pe = 0.0f;
                    ps = 0.0f;
                    break;
            }

            //Set first coefficient value
            coEff[0] = pe / PI;

            //Calculate coefficientsw
            for (int i = 1; i <= o2; i++)
            {
                coEff[i] = window[i] * (float)System.Math.Sin(i * pe) * (float)System.Math.Cos(i * ps)  / (i * PI);
            }

            //Shift Impulse
            for (int i = o2 + 1; i <= this.myOrder; i++)
            {
                coEff[i] = coEff[i - o2];
            }
            for (int i = 0; i <= o2 - 1; i++)
            {
                coEff[i] = coEff[this.myOrder - i];
            }
            coEff[o2] = pe / PI;

            return coEff;
        }
        #endregion
    }
}
