//-------------------------------------------------------------
// <copyright company=’Microsoft Corporation’>
//   Copyright © Microsoft Corporation. All Rights Reserved.
// </copyright>
//-------------------------------------------------------------
// @owner=alexgor, deliant
//=================================================================
//  File:		ChartControlDesigner200.cs
//
//  Namespace:	DataVisualization.Charting.Design
//
//	Classes:	ChartWebDesigner
//
//  Purpose:    Implementis ControlDesigner for chart on .Net Framework 2.0.
//
//	Reviewed:	--
//
//===================================================================

using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.Design;
using System.Web.UI.Design.WebControls;
using System.Web.UI.DataVisualization.Charting.Data;
using System.Web.UI.DataVisualization.Charting.Utilities;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.Configuration;
using System.Web.UI.DataVisualization.Charting;
using System.Diagnostics;
using System.Collections.Generic;
using System.CodeDom;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml;



namespace System.Web.UI.Design.DataVisualization.Charting
{
    /// <summary>
    /// Implementis ControlDesigner for chart on .Net Framework 2.0.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
    internal class ChartWebDesigner : DataBoundControlDesigner
    {
        #region Fields


        /// <summary>
        /// Reference to the control designer.
        /// </summary>
        static internal ChartWebDesigner controlDesigner = null;


        /// <summary>
        /// Chart design-time error message.
        /// </summary>
        private const string _errorDesignTimeHtml =
            "<table cellpadding=4 cellspacing=0 width=\"{2}\" height=\"{3}\" style=\"width:{2};height{3};font-family:Tahoma;font-size:8pt;color:buttontext;background-color:buttonface;border: solid 1px;border-top-color:buttonhighlight;border-left-color:buttonhighlight;border-bottom-color:buttonshadow;border-right-color:buttonshadow\">" +
            "<tr><td align=\"center\"><span style=\"font-weight:bold\">{1}</span><br/>{0}</td></tr>" +
            "</table>";
        
        /// <summary>
        /// Contains application flags table 
        /// </summary>
        private static Hashtable _appFlags = new Hashtable();

        /// <summary>
        /// Contains string form _appFlags table
        /// </summary>
        private static class AppFlags
        {
            internal const string ConfigChecked = "config";
            internal const string ConfigWarningMessageShown = "message";
        }
        /// <summary>
        /// Chart image is rendered in the GetDesigntimeHtml() and need to be persisted until the OnPaint()
        /// </summary>
        private System.Drawing.Image _chartImage = null;

        /// <summary>
        /// The timer forces the Invalidate after Undo/Redo operations.
        /// </summary>
        private Timer _invalidateTimer = new Timer();

        /// <summary>
        /// Indicates if chart have to be dump in a file once;
        /// </summary>
        private bool chartInFileOnce = true;

        /// <summary>
        /// Contains strings for web.config sections and habdler verbs
        /// </summary>
        private static class CgfSectionStrings
        {
            internal const string SystemWeb = "system.web";
            internal const string IIS7_SystemWebServer = "system.webServer";
            internal const string IIS7_Handlers = "handlers";
            internal const string HandlerVerbs = "GET,HEAD,POST";
            
            // Added IIS7 integrate mode validation flag.
            // 182898 IIS Express : Runtime error in ConfigurationValidationModule when trying to F5 on a web form with chart control using IIS Express as the server
            // 3395	  Chart HTTP Handler is not registered correctly and causes issues with IIS7 Integrated mode
            internal const string IIS7_Validation = "validation";
            internal const string IIS7_ValidationFlag = "validateIntegratedModeConfiguration";
        }
        

        #endregion

        #region Methods


        #region Initialize
        /// <summary>
        /// Prepares the designer to view, edit, and design the specified component. 
        /// </summary>
        /// <param name="component">The component for this designer.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Mobility", "CA1601:DoNotUseTimersThatPreventPowerStateChanges", Justification = "The timer is used for forcing the Invalidate method. It is used only once per operation.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "This is fallback capture if by any reason saving in web.config fails.")]
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            base.SetViewFlags(ViewFlags.CustomPaint, true);
            try
            {
                this.AddChartHttpHandler();
            }
            catch (Exception e)
            {
                if (!GetAppFlag(AppFlags.ConfigWarningMessageShown))
                {
                    MessageBox.Show(
                        SR.ExceptionWebConfigUpdateFailed(e.Message),
                        SR.MessageChartTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, DesignerMessageBoxDialog.GetMessageBoxOptions());
                    SetAppFlag(AppFlags.ConfigWarningMessageShown, true);
                }
            }
            IServiceContainer svc = component.Site as IServiceContainer;
            if (svc != null)
            {
                svc.AddService(typeof(IDesignerMessageBoxDialog), new DesignerMessageBoxDialog());
            }
            _invalidateTimer.Interval = 200;
            _invalidateTimer.Tick += new EventHandler(InvalidateTimer_Tick);
        }
        
        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="T:System.Web.UI.Design.WebControls.DataBoundControlDesigner"/> object and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_invalidateTimer != null)
                {
                    _invalidateTimer.Dispose();
                    _invalidateTimer = null;
                }
                if (_chartImage != null)
                {
                    _chartImage.Dispose();
                    _chartImage = null;
                }
            }
            base.Dispose(disposing);
        }
        /// <summary>
        /// Returns a boolean flag on application level.
        /// </summary>
        /// <param name="flagName">The flag name</param>
        /// <returns>The flag result</returns>
        private bool GetAppFlag(string flagName)
        {
            IWebApplication application = this.GetService(typeof(IWebApplication)) as IWebApplication;
            if (application != null && _appFlags[application.RootProjectItem.PhysicalPath + "@" + flagName] != null)
            {
                return (bool)_appFlags[application.RootProjectItem.PhysicalPath + "@" + flagName];
            }
            return false;
        }
        /// <summary>
        /// Sets a boolean flag on application level
        /// </summary>
        /// <param name="flagName">The flag name</param>
        /// <param name="value">The flag value</param>
        private void SetAppFlag(string flagName, bool value)
        {
            IWebApplication application = this.GetService(typeof(IWebApplication)) as IWebApplication;
            if (application != null)
            {
                lock (_appFlags.SyncRoot)
                {
                    _appFlags[application.RootProjectItem.PhysicalPath + "@" + flagName] = value;
                }
            }
        }
        
        /// <summary>
        /// Adds the chart HTTP handler in web.config.
        /// </summary>
        private void AddChartHttpHandler()
        {
            if (GetAppFlag(AppFlags.ConfigChecked))
            {
                return;
            }
            IWebApplication application = this.GetService(typeof(IWebApplication)) as IWebApplication;
            if (application != null)
            {
                System.Configuration.Configuration config = application.OpenWebConfiguration(false);
                if (config != null)
                {
                    bool updateConfig = false;
                    SystemWebSectionGroup webSectionGroup = config.GetSectionGroup(CgfSectionStrings.SystemWeb) as SystemWebSectionGroup;
                    if (webSectionGroup != null)
                    {
                        HttpHandlersSection httpHandlersSection = webSectionGroup.HttpHandlers;
                        if (httpHandlersSection != null)
                        {
                            bool found = false;
                            HttpHandlerAction newAction = new HttpHandlerAction(ChartHttpHandler.ChartHttpHandlerName, typeof(ChartHttpHandler).AssemblyQualifiedName, CgfSectionStrings.HandlerVerbs, false);
                            for (int i = 0; i < httpHandlersSection.Handlers.Count; i++)
                            {
                                HttpHandlerAction action = httpHandlersSection.Handlers[i];
                                if (String.Compare(action.Path, newAction.Path, StringComparison.OrdinalIgnoreCase) == 0)
                                {
                                    if (String.Compare(action.Type, newAction.Type, StringComparison.OrdinalIgnoreCase) != 0)
                                    {
                                        httpHandlersSection.Handlers.Remove(action);
                                        break;
                                    }
                                    else
                                    {
                                        found = true;
                                        break;
                                    }
                                }
                            }
                            if (!found)
                            {
                                httpHandlersSection.Handlers.Add(newAction);
                                updateConfig = true;
                            }
                        }

                        PagesSection pageSection = webSectionGroup.Pages;
                        if (pageSection != null)
                        {
                            TagPrefixInfo newInfo = new TagPrefixInfo("asp", typeof(Chart).Namespace, typeof(Chart).Assembly.FullName, null, null);
                            bool found = false;
                            for (int i = 0; i < pageSection.Controls.Count; i++)
                            {
                                TagPrefixInfo tagPrefix = pageSection.Controls[i];
                                if (String.Compare(tagPrefix.Namespace, newInfo.Namespace, StringComparison.OrdinalIgnoreCase) == 0)
                                {
                                    if (String.Compare(tagPrefix.Assembly, newInfo.Assembly, StringComparison.OrdinalIgnoreCase) != 0)
                                    {
                                        pageSection.Controls.Remove(tagPrefix);
                                        break;
                                    }
                                    else
                                    {
                                        found = true;
                                        break;
                                    }
                                }
                            }
                            if (!found)
                            {
                                pageSection.Controls.Add(newInfo);
                                updateConfig = true;
                            }

                        }
                    }

                    if (UpdateIIS7Config(config))
                    {
                        updateConfig = true;
                    }
                    
                    if (config.AppSettings.Settings[ChartHttpHandler.ChartHttpHandlerAppSection] == null)
                    {
                        config.AppSettings.Settings.Add(ChartHttpHandler.ChartHttpHandlerAppSection, ChartHttpHandler.DefaultConfigSettings);
                        updateConfig = true;
                    }
                    if (updateConfig)
                    {
                        config.Save(ConfigurationSaveMode.Modified);
                    }
                }
            }
            SetAppFlag(AppFlags.ConfigChecked, true);
        }


        private static bool UpdateIIS7Config(System.Configuration.Configuration config)
        {
            bool needsSave = false;
            ConfigurationSection serverSection = config.GetSection(CgfSectionStrings.IIS7_SystemWebServer);
            if (serverSection != null && serverSection.SectionInformation != null)
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlDocumentFragment docFragment = xmlDocument.CreateDocumentFragment();

                string rawXml = serverSection.SectionInformation.GetRawXml();
                if (!string.IsNullOrEmpty(rawXml))
                {
                    docFragment.InnerXml = rawXml;
                }

                XmlNode webServerNode = docFragment.SelectSingleNode(CgfSectionStrings.IIS7_SystemWebServer);
                if (webServerNode == null)
                {
                    webServerNode = xmlDocument.CreateElement(CgfSectionStrings.IIS7_SystemWebServer);
                    docFragment.AppendChild(webServerNode);
                }

                XmlNode validation = webServerNode.SelectSingleNode(CgfSectionStrings.IIS7_Validation);
                if (validation == null)
                {
                    validation = xmlDocument.CreateElement(CgfSectionStrings.IIS7_Validation);
                    webServerNode.AppendChild(validation);
                }
                
                if (validation.Attributes.GetNamedItem(CgfSectionStrings.IIS7_ValidationFlag) == null)
                {
                    AppendAttributeNode(xmlDocument, validation, CgfSectionStrings.IIS7_ValidationFlag, "false");
                    needsSave = true;
                }

                XmlNode handlers = webServerNode.SelectSingleNode(CgfSectionStrings.IIS7_Handlers);

                if (handlers == null)
                {
                    handlers = xmlDocument.CreateElement(CgfSectionStrings.IIS7_Handlers);
                    webServerNode.AppendChild(handlers);
                }

                if (handlers != null)
                {
                    if (handlers.SelectSingleNode("add[@type=\"" + typeof(ChartHttpHandler).AssemblyQualifiedName + "\"]") == null)
                    {
                        if (handlers.SelectSingleNode("remove[@name=\"ChartImageHandler\"]") == null)
                        {
                            XmlNode xmlNoder = xmlDocument.CreateElement("remove");
                            AppendAttributeNode(xmlDocument, xmlNoder, "name", "ChartImageHandler");
                            XmlNode xmlNoder1 = handlers.SelectSingleNode("add[1]");
                            if (xmlNoder1 != null)
                            {
                                handlers.InsertBefore(xmlNoder, xmlNoder1);
                            }
                            else
                            {
                                handlers.AppendChild(xmlNoder);
                            }
                        }

                        XmlNode xmlNodeToRemove = handlers.SelectSingleNode("add[@name=\"ChartImageHandler\"]");
                        if (xmlNodeToRemove != null)
                        {
                            handlers.RemoveChild(xmlNodeToRemove);
                        }

                        XmlNode xmlNode = xmlDocument.CreateElement("add");

                        AppendAttributeNode(xmlDocument, xmlNode, "name", "ChartImageHandler");
                        AppendAttributeNode(xmlDocument, xmlNode, "preCondition", "integratedMode");
                        AppendAttributeNode(xmlDocument, xmlNode, "verb", "GET,HEAD,POST");
                        AppendAttributeNode(xmlDocument, xmlNode, "path", ChartHttpHandler.ChartHttpHandlerName);
                        AppendAttributeNode(xmlDocument, xmlNode, "type", typeof(ChartHttpHandler).AssemblyQualifiedName);
                        handlers.AppendChild(xmlNode);
                        needsSave = true;
                    }
                }
                if (needsSave)
                {
                    serverSection.SectionInformation.SetRawXml(docFragment.InnerXml);
                }
            }
            return needsSave;
        }

        private static void AppendAttributeNode(XmlDocument xmlDocument, XmlNode xmlNode, string name, string value)
        {
            XmlAttribute attrib = xmlDocument.CreateAttribute(name);
            attrib.Value = value;
            xmlNode.Attributes.Append(attrib);
        }


        #endregion //Initialize

        #region Shadowing

        /// <summary>
        /// Changing PaletteCustomColors' type from Color[] to ColorExtended[] (Shadowing PaletteCustomColors)
        /// </summary>
        /// <param name="properties">The properties of the class.</param>
        protected override void PostFilterProperties(IDictionary properties)
        {
            // Call base class first
            base.PostFilterProperties(properties);

            // Shadow PaletteCustomColors
            if (properties.Contains("PaletteCustomColors"))
            {
                PropertyDescriptor oldPaletteCustomColorsProperty = (PropertyDescriptor)properties["PaletteCustomColors"];

                ColorExtendedArrayPropertyDescriptor newPaletteCustomColorsProperty =
                    new ColorExtendedArrayPropertyDescriptor(oldPaletteCustomColorsProperty);

                properties["PaletteCustomColors"] = newPaletteCustomColorsProperty;
            }
        }

        #endregion

        #region HTML Generation

        /// <summary>
        /// Used to track changes of the datasource property
        /// </summary>
        private String _oldDataSource = null;

        /// <summary>
        /// Persist inner HTML of the control
        /// </summary>
        /// <returns>Inner HTML text.</returns>
        public override string GetPersistenceContent()
        {
            // Set persisting flag
            Chart control = (Chart)Component;
            bool oldSerializingFlag = control.serializing;
            SerializationStatus oldSerializationStatus = control.serializationStatus;
            control.serializing = true;
            control.serializationStatus = SerializationStatus.Saving;
            String result = base.GetPersistenceContent();
            control.serializing = oldSerializingFlag;
            control.serializationStatus = oldSerializationStatus;
            return result;
        }

        /// <summary>
        /// Persist inner HTML of the control
        /// </summary>
        /// <returns>Inner HTML text.</returns>
        [Obsolete]
        public override string GetPersistInnerHtml()
        {
            // Set persisting flag
            Chart control = (Chart)Component;
            bool oldSerializingFlag = control.serializing;
            SerializationStatus oldSerializationStatus = control.serializationStatus;
            control.serializing = true;
            control.serializationStatus = SerializationStatus.Saving;
            String result = base.GetPersistInnerHtml();
            control.serializing = oldSerializingFlag;
            control.serializationStatus = oldSerializationStatus;
            return result;
        }

        /// <summary>
        /// Displays the chart in design time as HTML image tag
        /// </summary>
        /// <returns>Design time HTML representation of the chart</returns>
        private string GetDesignTimeHtmlInternal()
        {
            // Component is the instance of the component or control that
            // this designer object is associated with. This property is 
            // inherited from System.ComponentModel.ComponentDesigner.
            Chart control = (Chart)Component;
            ChartWebDesigner.controlDesigner = this;
            
            // If designer is rudimentary, like user control (ascx) there is no view.
            // Let chart to handle rendering in temporary file.
            if (this.RootDesigner == null || this.RootDesigner.IsDesignerViewLocked || this.RootDesigner.Component is MasterPage)
            {
                return base.GetDesignTimeHtml();
            }

#pragma warning disable 0618
            // DT: I did not found yet a method which returns phisical location to the project. 
            IWebFormsDocumentService service = (IWebFormsDocumentService)this.GetService(typeof(IWebFormsDocumentService));
            if (service != null)
            {
                control.webFormDocumentURL = service.DocumentUrl;
            }
#pragma warning restore 0618

            // Dispose the previous chart image
            if (_chartImage != null)
            {
                _chartImage.Dispose();
                _chartImage = null;
            }
            // Render new chart image
            using (MemoryStream stream = new MemoryStream())
            {
                // Emf is rendered in the design time as Bmp
                ChartImageType imageType = control.ImageType;
                if (control.ImageType == ChartImageType.Emf)
                    control.ImageType = ChartImageType.Bmp;
                
                control.SaveImage(stream);

                _chartImage = System.Drawing.Image.FromStream(stream);

                // Restore the original image type
                control.ImageType = imageType;
            }

            if (chartInFileOnce)
            {
                chartInFileOnce = false;
                return base.GetDesignTimeHtml();
            }

            // Render Chart as image tag during design mode
            StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            HtmlTextWriter htmlWriter = new HtmlTextWriter(stringWriter);            
            System.Web.UI.WebControls.Image httpImage = new System.Web.UI.WebControls.Image();
            httpImage.ImageUrl = "about:blank";
            httpImage.Width = control.Width;
            httpImage.Height = control.Height;
            
            // Copy the style of the control to the styles of the image
            foreach (string key in control.Style.Keys)
            {
                if (String.Compare(key, "Position", StringComparison.OrdinalIgnoreCase) == 0
                    || String.Compare(key, "Left", StringComparison.OrdinalIgnoreCase) == 0
                    || String.Compare(key, "Top", StringComparison.OrdinalIgnoreCase) == 0
                )
                {
                    httpImage.Style[key] = control.Style[key];
                }
            }
            httpImage.Style[HtmlTextWriterStyle.BackgroundColor] = "white";
            httpImage.RenderControl(htmlWriter);
            httpImage.Dispose();

            return HttpUtility.UrlDecode(stringWriter.ToString());
        }

        protected override string GetErrorDesignTimeHtml(Exception e)
        {
            Chart control = (Chart)Component;

            return String.Format(
                CultureInfo.InvariantCulture,
                _errorDesignTimeHtml,
                SR.ExceptionChartPreviewNotAvailable,
                control.ID,
                control.Width.ToString(),
                control.Height.ToString()
                );
        }

        /// <summary>
        /// Gets the HTML that is used to represent the control at design time. 
        /// </summary>
        /// <returns>The HTML that is used to represent the control at design time. </returns>
        public override string GetDesignTimeHtml()
        {
            string designTimeHtml = this.GetDesignTimeHtmlInternal();
            
            // During undo/redo operations the GetDesignTimeHtml() method is called but the OnPaint() doesn't happen.
            // As a result the design surface is not updated and chart picture shows the old chart.
            // Invalidate() or setting the dirty flag doesn't change anything because during the rendering the VS.NET web designer blocks those.
            // So every time we render the html we need to Start() the _invalidateTimer. During normal operations the timer is turned off by the OnPaint()
            // But if the OnPaint() didn't happen the timer ticks once and forces the Invalidate() of the control.
            if (!_invalidateTimer.Enabled)
                this._invalidateTimer.Start();

            return designTimeHtml;
        }


        /// <summary>
        /// Called when the control designer draws the associated control on the design surface, if the <see cref="F:System.Web.UI.Design.ViewFlags.CustomPaint"/> value is true.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs"/> object that specifies the graphics and rectangle boundaries used to draw the control.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            _invalidateTimer.Stop();
            if (_chartImage != null)
            {
                e.Graphics.DrawImageUnscaled(_chartImage, e.ClipRectangle.Location);
            }

        }

        /// <summary>
        /// Enforces the control refresh during the undo/redo operations
        /// </summary>
        private void InvalidateTimer_Tick(object sender, EventArgs e)
        {
            _invalidateTimer.Stop();
            this.Invalidate();
        }

    
        /// <summary>
        /// Called when the data source of the associated BaseDataBoundControl object changes. 
        /// </summary>
        /// <param name="forceUpdateView">true to force the update of design-time markup; otherwise, false.</param>
        protected override void OnDataSourceChanged(bool forceUpdateView)
        {
            if (!this.RootDesigner.IsLoading)
            {
                if (_oldDataSource != null)
                {
                    // Clear all members of data source
                    Chart chartControl = this.Component as Chart;
                    if (chartControl != null && String.Compare(chartControl.DataSourceID, _oldDataSource, StringComparison.OrdinalIgnoreCase) != 0)
                    {
                        // Clear all value members properies in the series
                        foreach (Series series in chartControl.Series)
                        {
                            series.XValueMember = String.Empty;
                            series.YValueMembers = String.Empty;
                        }
                    }
                    this.UpdateDesignTimeHtml();
                }
                _oldDataSource = this.DataSourceID;
            }
            base.OnDataSourceChanged(forceUpdateView);
        }

        /// <summary>
        /// Set Dirty Flag
        /// </summary>
        internal void SetDirtyFlag()
        {
            this.SetDirtyFlag(false);
        }

        /// <summary>
        /// Set Dirty Flag
        /// </summary>
        internal void SetDirtyFlag(bool raiseComponentChanged)
        {
            // Mark control as dirty
            if (this.Tag != null)
            {
                this.Tag.SetDirty(true);
            }

            // Fire component changed event if required
            if (raiseComponentChanged)
            {
                this.RaiseComponentChanged(null, null, null);
            }

            this.Invalidate();
        }


        #endregion //HTML Generation

        #region GetDataSource

        /// <summary>
        /// Gets selected data source object.
        /// </summary>
        public object GetDataSource()
        {
            object selectedDataSource = null;
            string dataSource = null;

            DataBinding binding = DataBindings["DataSource"];
            if (binding != null)
            {
                dataSource = binding.Expression;
            }

            if (dataSource != null)
            {
                ISite componentSite = Component.Site;
                if (componentSite != null)
                {
                    IContainer container = (IContainer)componentSite.GetService(typeof(IContainer));

                    if (container != null)
                    {
                        selectedDataSource = container.Components[dataSource];
                        if (!ChartImage.IsValidDataSource(selectedDataSource))
                        {
                            selectedDataSource = null;
                        }
                    }
                }
            }

            return selectedDataSource;
        }

        #endregion //GetDataSource

        #region ActionList
        
        ChartActionList _actionLists;
        /// <summary>
        /// Gets the connected action list 
        /// </summary>
        private ChartActionList ActionList
        {
            get
            {
                if (this._actionLists == null)
                {
                    this._actionLists = new ChartActionList(this);
                }
                return (ChartActionList)this._actionLists;
            }
        }
        
        /// <summary>
        /// Gets the design-time action lists supported by the component 
        /// associated with the designer. 
        /// </summary>
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                DesignerActionListCollection collection1 = new DesignerActionListCollection();
                collection1.AddRange(base.ActionLists);
                collection1.Add(this.ActionList);
                return collection1;
            }
        }

        #endregion
        #endregion //Methods

    }

}

