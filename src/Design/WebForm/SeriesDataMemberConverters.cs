//-------------------------------------------------------------
// <copyright company=’Microsoft Corporation’>
//   Copyright © Microsoft Corporation. All Rights Reserved.
// </copyright>
//-------------------------------------------------------------
// @owner=alexgor, deliant
//=================================================================
//  File:		SeriesDataMemberConverters.cs
//
//  Namespace:	System.Web.UI.DataVisualization.Charting
//
//	Classes:	SeriesDataFieldXConverter, SeriesDataFieldYConverter
//
//  Purpose:	Converters for retrieving the fields of a datasource as x and y values for a series
//
//	Reviewed:	AG - August 7, 2002
//
//===================================================================

using System.ComponentModel;
using System.Web.UI.Design;
using System.ComponentModel.Design;
using System.Web.UI.Design.WebControls;
using System.Collections;
#if WINFORMS_CONTROL
	using System.Windows.Forms.DataVisualization.Charting;
#else
    using System.Web.UI.DataVisualization.Charting;
using System;
#endif


#if WINFORMS_CONTROL
namespace System.Windows.Forms.Design.DataVisualization.Charting
#else
namespace System.Web.UI.Design.DataVisualization.Charting
#endif
{

    #region SeriesDataFieldXConvertor Class

    internal class SeriesDataFieldXConvertor : System.Web.UI.Design.DataFieldConverter
    {
        internal SeriesDataFieldXConvertor()
            : base()
        {

        }

        private static IComponent GetComponent(ITypeDescriptorContext context)
        {
            return ConverterHelper.GetChartFromContext(context);
        }

        protected virtual bool IsApplicable(IDataSourceFieldSchema shema)
        {
            return true;
        }

        protected virtual bool IsApplicable(PropertyDescriptor descriptor)
        {
            return true;
        }

        private TypeConverter.StandardValuesCollection GetStandardValuesInternal(IComponent component)
        {
            object[] result = null;
            if (component != null)
            {
                ISite site = component.Site;
                if (site != null)
                {
                    IDesignerHost host = (IDesignerHost)site.GetService(typeof(IDesignerHost));
                    if (host != null)
                    {
                        DataBoundControlDesigner designer = host.GetDesigner(component) as DataBoundControlDesigner;
                        if (designer != null)
                        {
                            DesignerDataSourceView view = designer.DesignerView;
                            if (view != null)
                            {
                                IDataSourceViewSchema schema = null;
                                try
                                {
                                    schema = view.Schema;
                                }
                                finally
                                {
                                    if (schema != null)
                                    {
                                        IDataSourceFieldSchema[] schemaArray = schema.GetFields();
                                        if (schemaArray != null)
                                        {
                                            ArrayList list = new ArrayList();
                                            foreach (IDataSourceFieldSchema shema in schemaArray)
                                            {
                                                if (this.IsApplicable(shema))
                                                {
                                                    list.Add(shema.Name);
                                                }
                                            }
                                            result = list.ToArray();
                                        }
                                    }
                                }
                            }
                        }
                        if (((result == null) && (designer != null)) && (designer is IDataSourceProvider))
                        {
                            IDataSourceProvider provider = designer as IDataSourceProvider;
                            IEnumerable enumerable = null;
                            if (provider != null)
                            {
                                enumerable = provider.GetResolvedSelectedDataSource();
                            }
                            if (enumerable != null)
                            {
                                PropertyDescriptorCollection collection = DesignTimeData.GetDataFields(enumerable);
                                if (collection != null)
                                {
                                    ArrayList list = new ArrayList();
                                    foreach (PropertyDescriptor descriptor in collection)
                                    {
                                        if (this.IsApplicable(descriptor))
                                        {
                                            list.Add(descriptor.Name);
                                        }
                                    }
                                    result = list.ToArray();
                                }
                            }
                        }
                    }
                }
            }
            return new TypeConverter.StandardValuesCollection(result);
        }

        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return this.GetStandardValuesInternal(GetComponent(context));
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            if (GetComponent(context) != null)
            {
                return true;
            }
            return false;
        }
    }

    #endregion //SeriesDataFieldXConvertor Class

    #region SeriesDataFieldYConvertor Class

    internal class SeriesDataFieldYConvertor : SeriesDataFieldXConvertor
    {
        internal SeriesDataFieldYConvertor()
            : base()
        {

        }

        protected override bool IsApplicable(PropertyDescriptor descriptor)
        {
            return descriptor.PropertyType != typeof(string);
        }

        protected override bool IsApplicable(IDataSourceFieldSchema shema)
        {
            return shema.DataType != typeof(string);
        }

    }

    #endregion //SeriesDataFieldYConvertor Class
}
