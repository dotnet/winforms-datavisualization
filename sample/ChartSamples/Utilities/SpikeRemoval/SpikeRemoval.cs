//=================================================================
//  File:		SpikeRemoval.cs
//
//  Namespace:	System.Windows.Forms.DataVisualization.Charting.Utilities
//
//  Classes:	SpikeRemoval
//
//  Purpose:	Removes spikes from data 
//              
//
//===================================================================
// Chart Control for .NET Framework
// Copyright © Microsoft Corporation, all rights reserved
//===================================================================

using System;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace System.Windows.Forms.DataVisualization.Charting.Utilities
{
    /// <summary>
    /// Spike removal is a utility used to remove high and low spikes from a graph. This means that the
    /// chart axis scaling will be changed so that data that was difficult to see and analyze will be easier
    /// to see after anomaly spikes have been removed.
    /// </summary>
    public class SpikeRemoval
    {
        #region Members
        private bool mySetCutoffLabels;
        private MarkerStyle myRemovedPointStyle;
        private float myMaximum;
        private float myMinimum;
        private int myRemovedPointSize;
        
        #endregion

        #region Properties
        /// <summary>
        /// Sets whether or not labels are set on each cut off point. If they are, they will show up on the chart and provide
        /// extra clarification if the tooltip is not enough.
        /// </summary>
        public bool SetCutoffLabels
        {
            get { return mySetCutoffLabels; }
            set { mySetCutoffLabels = value; }
        }

        /// <summary>
        /// Holds the style that is used for the marker of any deleted points.
        /// </summary>
        public MarkerStyle RemovedPointStyle
        {
            get { return myRemovedPointStyle; }
            set { myRemovedPointStyle = value; }
        }

        /// <summary>
        /// Holds the size that is used for the marker of any deleted points.
        /// </summary>
        public int RemovedPointSize
        {
            get { return myRemovedPointSize; }
            set { myRemovedPointSize = value; }
        }

        /// <summary>
        /// Contains the maximum value of the data after it has had the spikes removed. This value also has
        /// the tolerance factored in.
        /// </summary>
        public float Maximum
        {
            get { return myMaximum; }
        }

        /// <summary>
        /// Contains the minimum value of the data after it has had the spikes removed. This value also has
        /// the tolerance factored in.
        /// </summary>
        public float Minimum
        {
            get { return myMinimum; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SpikeRemoval()
        {
            //Default removed point style to a diamond.
            myRemovedPointStyle = MarkerStyle.Diamond;

            //Default labels to off.
            mySetCutoffLabels = false;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// RemoveSpikes will remove the high and low spikes off of a graph. The data within the series
        /// provided will be modified, and for best results, the chart containing it should have axis
        /// scaled automatically.
        /// </summary>
        /// <param name="dataseries">The series which contains the data to be analyzed and modified. It is assumed that
        /// Y-values are contained in YValues[0]. Cases contrary to this will produce unexpected results.</param>
        /// <param name="range">The percentage range of data to be kept. Anything that lies outside of the range
        /// will be considered a spike.</param>
        /// <param name="tolerance">The percentage a spike can be outside of the range but still included. The percentage
        /// is based on the maximum or minimum value in the range.</param>
        public void RemoveSpikes(Series dataseries, int range, int tolerance)
        {
            //Assure range and tolerance are a percentage.
            //Range is more strict in that at least 1% of the data must be included in the range, whereas it is
            //possible to have 0% tolerance.
            if ((range < 1 || range > 100))
                throw new ArgumentOutOfRangeException("range", "Range must be a percentage between 1 and 100");
            if ((tolerance < 0 || tolerance > 100))
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be a percentage between 0 and 100");
            
            //Data values and indices hold the y values and the indices of the points in arrays.
            float[] datavalues = new float[dataseries.Points.Count];
            int[] indices = new int[dataseries.Points.Count];

            //Percent and number hold the actual values calculated from the range.
            float percent = 0.0f;
            int number = 0;

            //Copy all y values into an array and store the indices.
            for (int i = 0; i < dataseries.Points.Count; i++)
            {
                datavalues[i] = (float)dataseries.Points[i].YValues[0];
                indices[i] = i;
            }

            //Sort the array and indices.
            Array.Sort(datavalues, indices);

            //Calculate the percent that has to come off each side of the data.
            //ie. With a range of 80%, 20% of the data is being cut off, and 10% is coming off each side.
            percent = ((100 - (float)range) / 2) / 100;

            //Calculate the actual number of points coming off of each side.
            //ie. With a percent of 10% and 100 data points, 10 points are coming off of each side.
            number = (int)System.Math.Round(dataseries.Points.Count * percent, 0);

            //Set the maximum and minimum values.
            myMinimum = (float)(dataseries.Points[indices[number]].YValues[0] - System.Math.Abs(dataseries.Points[indices[number]].YValues[0] * (((float)tolerance / 100))));
            myMaximum = (float)(dataseries.Points[indices[dataseries.Points.Count - number - 1]].YValues[0] + System.Math.Abs(dataseries.Points[indices[dataseries.Points.Count - number - 1]].YValues[0] * (((float)tolerance / 100))));

            //Cut the low spikes off.
            for (int i = 0; i < number; i++)
            {
                //Don't cut the spike if it's within the tolerance value.
                if (dataseries.Points[indices[i]].YValues[0] < (myMinimum))
                {
                    //Assign the tooltip to the point
                    dataseries.Points[indices[i]].ToolTip = "Value: " + dataseries.Points[indices[i]].YValues[0];
                    
                    //Assign the label to the point
                    if (mySetCutoffLabels)
                    {
                        dataseries.Points[indices[i]].Label = dataseries.Points[indices[i]].YValues[0].ToString();
                        dataseries.Points[indices[i]].LabelBorderColor = Color.Red;
                    }

                    //Reassign the value to the minimum number allowed
                    dataseries.Points[indices[i]].YValues[0] = myMinimum;

                    //Set the marker point style
                    dataseries.Points[indices[i]].MarkerStyle = myRemovedPointStyle;

                    //Set marker point size
                    dataseries.Points[indices[i]].MarkerSize = myRemovedPointSize;
                }
            }

            //Cut the high spikes off.
            for (int i = dataseries.Points.Count - number; i < dataseries.Points.Count; i++)
            {
                //Don't cut the spike if it's within the tolerance value.
                if (dataseries.Points[indices[i]].YValues[0] > (myMaximum))
                {
                    //Assign the tooltip to the point
                    dataseries.Points[indices[i]].ToolTip = "Value: " + dataseries.Points[indices[i]].YValues[0];

                    //Assign the label to the point
                    if (mySetCutoffLabels)
                    {
                        dataseries.Points[indices[i]].Label = dataseries.Points[indices[i]].YValues[0].ToString();
                        dataseries.Points[indices[i]].LabelBorderColor = Color.Red;
                    }

                    //Reassign the value to the maximum number allowed
                    dataseries.Points[indices[i]].YValues[0] = myMaximum;

                    //Set the marker point
                    dataseries.Points[indices[i]].MarkerStyle = myRemovedPointStyle;

                    //Set marker point size
                    dataseries.Points[indices[i]].MarkerSize = myRemovedPointSize;
                }
            }
        }
        #endregion
    }
}
