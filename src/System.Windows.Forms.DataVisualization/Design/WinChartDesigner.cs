// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	Windows forms chart control designer class.
//


using Microsoft.Win32;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms.DataVisualization.Charting;

namespace System.Windows.Forms.Design.DataVisualization.Charting
{


    /// <summary>
    /// Chart windows forms control designer
    /// </summary>
    internal class ChartWinDesigner : ControlDesigner
    {
        #region Fields

        // Reference to the chart designer
        static internal ChartWinDesigner controlDesigner = null;

        #endregion

        #region Methods

        /// <summary>
        /// Intialize designer.
        /// </summary>
        /// <param name="component">Component.</param>
        public override void Initialize(IComponent component)
        {

            // remove default verbs from the action list. 
            // should be called before initialization.
            IServiceContainer svc = component.Site as IServiceContainer;
            //if (svc != null)
            //{
            //    if (this.GetService(typeof(DesignerCommandSet)) == null)
            //    {
            //        svc.AddService(typeof(DesignerCommandSet), new DesignerCommandSet());
            //    }
            //    svc.AddService(typeof(IDesignerMessageBoxDialog), new DesignerMessageBoxDialog());
            //}
            base.Initialize(component);

            // Set reference to the designer
            ChartWinDesigner.controlDesigner = this;

            SystemEvents.UserPreferenceChanged += new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
        }

        protected override void OnMouseDragBegin(int x, int y)
        {
            base.OnMouseDragBegin(x, y);
            ChartWinDesigner.controlDesigner = this;
        }



        /// <summary>
        /// Set default values for properties of the component.
        /// NOTE: Replaces obsolete method: OnSetComponentDefaults()
        /// </summary>
        /// <param name="defaultValues">Default values property bags.</param>
        public override void InitializeNewComponent(IDictionary defaultValues)
        {
            if (Control != null && Control is Chart)
            {
                Chart chart = (Chart)Control;
                // If control is not initialized
                if (chart.ChartAreas.Count == 0 &&
                    chart.Series.Count == 0)
                {
                    // Add Default chart area
                    chart.ChartAreas.Add(new ChartArea());

                    // Add Default series
                    chart.Series.Add(new Series());

                    chart.Legends.Add(new Legend());
                }
            }
            base.InitializeNewComponent(defaultValues);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //Free managed resources
                SystemEvents.UserPreferenceChanged -= SystemEvents_UserPreferenceChanged;
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// User changed Windows preferences
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">Event arguments.</param>
        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            // If user changed system colors, make Chart repaint itself.
            if (e.Category == UserPreferenceCategory.Color)
                Control.Invalidate();
        }
        

        #endregion

        #region Data Binding

        /// <summary>
        /// Data source was changed.
        /// </summary>
        /// <param name="chartControl">Reference to the chart control.</param>
        internal static void OnDataSourceChanged(Chart chartControl)
        {
            if (chartControl != null)
            {
                // Clear all value members properies in the series
                foreach (Series series in chartControl.Series)
                {
                    series.XValueMember = String.Empty;
                    series.YValueMembers = String.Empty;
                }
            }
        }
        
        /// <summary>
        /// Gets selected data source object.
        /// </summary>
        public object GetControlDataSource()
        {
            object selectedDataSource = null;
            if (this.Control != null && this.Control is Chart)
            {
                selectedDataSource = this.GetControlDataSource((Chart)this.Control);
            }

            return selectedDataSource;
        }

        /// <summary>
        /// Gets selected data source object.
        /// </summary>
        /// <param name="chart">Chart control.</param>
        /// <returns>Data source.</returns>
        internal object GetControlDataSource(Chart chart)
        {
            object selectedDataSource = null;
            if (chart != null)
            {
                if (chart.DataSource != null)
                {
                    object dataSourceObject = chart.DataSource;
                    string fieldName = dataSourceObject as string;
                    if (fieldName != null && this.Component != null)
                    {
                        dataSourceObject = null;
                        ISite componentSite = this.Component.Site;
                        if (componentSite != null)
                        {
                            IContainer container = (IContainer)componentSite.GetService(typeof(IContainer));
                            if (container != null)
                            {
                                dataSourceObject = container.Components[fieldName];
                            }
                        }
                    }
                    if (dataSourceObject != null && ChartImage.IsValidDataSource(dataSourceObject))
                    {
                        selectedDataSource = dataSourceObject;
                    }
                }
            }

            return selectedDataSource;
        }

        #endregion //DataBinding

    }
}

