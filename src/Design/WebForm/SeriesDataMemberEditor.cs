//-------------------------------------------------------------
// <copyright company=’Microsoft Corporation’>
//   Copyright © Microsoft Corporation. All Rights Reserved.
// </copyright>
//-------------------------------------------------------------
// @owner=alexgor, deliant
//=================================================================
//  File:		SeriesDataMemberEditor.cs
//
//  Namespace:	Design.DataVisualization.Charting
//
//	Classes:	SeriesDataFieldValueAxisUITypeEditor, SeriesDataFieldYCheckedListBox
//
//  Purpose:	Design-time editor for Y data source members of the series.
//
//	Reviewed:	
//
//===================================================================

using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Reflection;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;

using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.Design;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.DataVisualization.Charting.Data;
using System.Drawing.Design;
using System.Text;
using System.Web.UI.Design.WebControls;

namespace System.Web.UI.Design.DataVisualization.Charting
{

#if RS_DEADCODE
    #region DummyTypeDescriptorContext Class

    internal class DummyTypeDescriptorContext : ITypeDescriptorContext
    {

    #region Fields
        
        ITypeDescriptorContext context = null;
        object instance = null;

        #endregion

    #region Constructor

        internal DummyTypeDescriptorContext(ITypeDescriptorContext context, object instance)
        {
            this.context = context;
            this.instance = instance;
        }

        #endregion 

    #region ITypeDescriptorContext Members

        IContainer ITypeDescriptorContext.Container
        {
            get { return this.context.Container; }
        }

        object ITypeDescriptorContext.Instance
        {
            get { return this.instance; }
        }

        void ITypeDescriptorContext.OnComponentChanged()
        {
            this.context.OnComponentChanged();
        }

        bool ITypeDescriptorContext.OnComponentChanging()
        {
            return this.context.OnComponentChanging();
        }

        PropertyDescriptor ITypeDescriptorContext.PropertyDescriptor
        {
            get { return this.context.PropertyDescriptor; }
        }

        #endregion

    #region IServiceProvider Members

        object IServiceProvider.GetService(Type serviceType)
        {
            return this.context.GetService( serviceType);
        }

        #endregion
    }

    #endregion //DummyTypeDescriptorContext Class
#endif //RS_DEADCODE


    #region SeriesDataFieldYUITypeEditor

#if !SMART_CLIENT

    /// <summary>
    /// UI type editor for the Y data source members of the series.
    /// </summary>
    internal class SeriesDataFieldValueAxisUITypeEditor : SeriesDataSourceMemberValueAxisUITypeEditor
    {

        #region Editor methods and properties


        internal override SeriesDataSourceMemberYCheckedListBox GetDropDownControl(Chart chart, ITypeDescriptorContext context, object value, bool flag)
        {
            return new SeriesDataFieldYCheckedListBox(chart, context, value, flag);
        }

        #endregion //Editor methods and properties
    }

    /// <summary>
    /// Checked list box, which is used for the series Y dats source member UI type editing.
    /// </summary>
    internal class SeriesDataFieldYCheckedListBox : SeriesDataSourceMemberYCheckedListBox
    {

        private ITypeDescriptorContext _context = null;
        #region Control constructor

        /// <summary>
        /// Public constructor.
        /// </summary>
        /// <param name="chart">Chart control.</param>
        /// <param name="context">Instance of control.</param>
        /// <param name="editValue">Value to edit.</param>
        /// <param name="usedForYValue">Indicates that editor was used for the Y values members.</param>
        public SeriesDataFieldYCheckedListBox(Chart chart, ITypeDescriptorContext context, object editValue, bool usedForYValue)
            : base(chart, editValue, usedForYValue)
        {
            this._context = context;
            this.AutoSize = false;
        }

        #endregion

        #region Control methods

        internal override ArrayList GetMemberNames()
        {
            SeriesDataFieldYConvertor convertor = new SeriesDataFieldYConvertor();
            TypeConverter.StandardValuesCollection values = convertor.GetStandardValues(this._context);
            return new ArrayList(values);
        }

        #endregion
    }
#endif //!SMART_CLIENT
    #endregion SeriesDataFieldYUITypeEditor
}

