using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing.Design;
using System.Drawing;
#if WINFORMS_CONTROL
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.ChartTypes;
using System.Web.UI.Design;
namespace System.Windows.Forms.Design.DataVisualization.Charting
{
#else
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.DataVisualization.Charting.ChartTypes;
namespace System.Web.UI.Design.DataVisualization.Charting
{
#endif

    #region ChartActionList class

    /// <summary>
    /// Defines a list of items used to create a DesignerActionPanel.
    /// Extends Dundas Chart design time functionality in VS 2005
    /// </summary>
    internal class ChartActionList :
        DesignerActionList,
        IServiceProvider,
        IWindowsFormsEditorService,
        ICustomTypeDescriptor,
        IChartElement
    {

        #region Fields

#if !WINFORMS_CONTROL

        private ChartWebDesigner chartDesigner;

#else

        private ChartWinDesigner chartDesigner;

#endif //!WINFORMS_CONTROL

        #endregion //Fields

        #region Constructors

#if !WINFORMS_CONTROL
        /// <summary>
        /// Creates new instance of ChartActionList with specified parameters
        /// </summary>
        /// <param name="chartDesigner">Parent Chart Designer</param>
        public ChartActionList(ChartWebDesigner chartDesigner)
            : base(chartDesigner.Component)
        {
            this.chartDesigner = chartDesigner;
        }
#else

    /// <summary>
    /// Creates new instance of ChartActionList with specified parameters
    /// </summary>
    /// <param name="chartDesigner">Parent Chart Designer</param>
        public ChartActionList(ChartWinDesigner chartDesigner)
        : base(chartDesigner.Component)
    {
        this.chartDesigner = chartDesigner;
    }

#endif //!WINFORMS_CONTROL

        #endregion //Constructors

        #region Methods



        /// <summary>
        /// Returns the collection of DesignerActionItem objects contained in the list. 
        /// </summary>
        /// <returns>Collection of DesignerActionItem objects contained in the list</returns>
        public override DesignerActionItemCollection GetSortedActionItems()
        {

            DesignerActionItemCollection items = new DesignerActionItemCollection();


            //Refresh custom properties and get the property collection
            TypeDescriptor.Refresh(this);

            PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(this);
            List<String> headers = new List<string>();
            foreach (PropertyDescriptor pd in pdc)
            {
                ActionPropertyDescriptor ds = pd as ActionPropertyDescriptor;
                if (ds != null )
                {
                    if (ds.Instance == this)
                    {
                        items.Add(new DesignerActionPropertyItem(
                                    ds.Name,
                                    SR.ActionListSeriesChartType,
                                    "Series",
                                    SR.DescriptionAttributeSeries_Type
                                ));
                    }
                    else  if (ds.IsBrowsable)
                    {
                        string header = TypeDescriptor.GetProperties(ds.Instance)["Name"].GetValue(ds.Instance).ToString();
                        if (!headers.Contains(header))
                        {
                            headers.Add(header);
                            items.Add(new DesignerActionHeaderItem(SR.ActionListSeriesDataGroup(header)));
                        }
                        DesignerActionPropertyItem item =
                            new DesignerActionPropertyItem(
                                        ds.Name,
                                        ds.Name.Contains("X") ? SR.ActionListSeriesXValueMember : SR.ActionListSeriesYValueMembers,
                                        header,
                                        ds.Description
                                    );
                        items.Add(item);
                    }
                }
            }
            
            foreach (DesignerVerb verb in this.chartDesigner.Verbs)
            {
                items.Add(new DesignerActionVerbItem(this, verb, "Actions"));
            }

            return items;
        }
        
        /// <summary>
        /// Chart type used to draw the series.
        /// </summary>
        [
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode"), 
        DefaultValue(SeriesChartType.Column),
        Editor(typeof(ChartTypeEditor), typeof(UITypeEditor))
        ]
        public SeriesChartType ChartTypeImpl
        {
            get
            {
                if (Chart.Series.Count > 0)
                {
                    return Chart.Series[0].ChartType;
                }
                return SeriesChartType.Column;
            }
            set
            {
                foreach (Series series in Chart.Series)
                {
                    TypeDescriptor.GetProperties(series, true)["ChartType"].SetValue(series, value);
                }
            }
        }

        /// <summary>
        /// Determines whether chart type property is browsable.
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if chart type is browsable; otherwise, <c>false</c>.
        /// </returns>
        internal bool IsBrowsableChartType()
        {
            bool result = false;
            if (Chart.Series.Count > 0)
            {
                result = true;
                SeriesChartType firstChartType = Chart.Series[0].ChartType;
                for (int i = 1; i < Chart.Series.Count; i++)
                {
                    if (Chart.Series[i].ChartType != firstChartType)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }

#if !WINFORMS_CONTROL
        /// <summary>
        /// Returns the parent designer
        /// </summary>
        /// <returns>The chart designer</returns>
        internal ChartWebDesigner GetDesigner()
        {
            return this.chartDesigner;
        }
#else
    /// <summary>
    /// Returns the parent designer
    /// </summary>
    /// <returns>The chart designer</returns>
        internal ChartWinDesigner GetDesigner()
    {
        return this.chartDesigner;
    }

#endif //!WINFORMS_CONTROL

        /// <summary>
        /// Gets or sets a value indicating whether the DesignerActionPanel should automatically be displayed when it is created
        /// </summary>
        public override bool AutoShow
        {
            get
            {
                return true;
            }
            set
            {

            }
        }

        #endregion //Methods

        #region IChartElement Members

        //Properties
        IChartElement IChartElement.Parent 
        {
            get
            {
                return (IChartElement)Chart.GetService(typeof(ChartImage));
            }
            set
            {
            }
        }
        
        CommonElements IChartElement.Common 
        {
            get
            {
                return ((IChartElement)this).Parent.Common;
            }
        }

        //Methods
        void IChartElement.Invalidate()
        {
        }
        #endregion //IChartElement Members

        #region IServiceProvider Members
        /// <summary>
        /// Gets the service object of the specified type. 
        /// </summary>
        /// <param name="serviceType">An object that specifies the type of service object to get. </param>
        /// <returns>A service object of type serviceType. -or- null if there is no service object of type serviceType. </returns>
        object IServiceProvider.GetService(Type serviceType)
        {
            if (serviceType == typeof(System.Windows.Forms.Design.IWindowsFormsEditorService))
            {
                return this;
            }
            if (serviceType == typeof(Chart))
            {
                return this.Chart;
            }
            return base.GetService(serviceType);
        }

        #endregion

        #region IWindowsFormsEditorService Members
        /// <summary>
        /// Closes any previously opened drop down control area
        /// </summary>
        void IWindowsFormsEditorService.CloseDropDown()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Displays the specified control in a drop down area below a value field of the property grid that provides this service. 
        /// </summary>
        /// <param name="control"></param>
        void IWindowsFormsEditorService.DropDownControl(System.Windows.Forms.Control control)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Shows the specified Form. 
        /// </summary>
        /// <param name="dialog"></param>
        /// <returns></returns>
        DialogResult IWindowsFormsEditorService.ShowDialog(Form dialog)
        {
            return dialog.ShowDialog();
        }

        #endregion

        #region ICustomTypeDescriptor Members

        /// <summary>
        /// Returns collection of properties of this object.
        /// </summary>
        /// <returns>Collection of properties descriptors.</returns>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
        {
            // Fill collection with properties descriptors
            PropertyDescriptorCollection propDescriptors = TypeDescriptor.GetProperties(this, true);

            PropertyDescriptorCollection newPropDescriptors = new PropertyDescriptorCollection(null);

            if (IsBrowsableChartType())
            {
                PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(this, true);
                newPropDescriptors.Add(new ActionPropertyDescriptor(this, pdc.Find("ChartTypeImpl", true), this));
            }
            bool hasDataSource = false;
#if WINFORMS_CONTROL  
            hasDataSource = this.GetDesigner().GetControlDataSource() != null || this.Chart.DataSource != null;
#else
            hasDataSource = (this.Chart.DataSourceObject != null || this.Chart.DataSource != null);
#endif
            if (this.Chart.Series.Count > 0 && hasDataSource)
            {
                foreach (Series series in this.Chart.Series)
                {
                    PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(series, true);
                    newPropDescriptors.Add(new ActionPropertyDescriptor(series, pdc.Find("XValueMember", true), this));
                    newPropDescriptors.Add(new ActionPropertyDescriptor(series, pdc.Find("YValueMembers", true), this));
                }
            }

            for (int i = 0; i < propDescriptors.Count; i++)
            {
                newPropDescriptors.Add(propDescriptors[i]);
            }
            return newPropDescriptors;
        }

        private static void FilterMembers(IList members, Attribute[] attributes)
        {
            for (int num1 = members.Count - 1; num1 >= 0; num1--)
            {
                for (int num2 = 0; num2 < attributes.Length; num2++)
                {
                    if (ShouldHideMember((MemberDescriptor)members[num1], attributes[num2]))
                    {
                        members.RemoveAt(num1);
                        break;
                    }
                }
            }
        }

        private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute)
        {
            if ((member == null) || (attribute == null))
            {
                return true;
            }
            Attribute attribute1 = member.Attributes[attribute.GetType()];
            if (attribute1 == null)
            {
                return !attribute.IsDefaultAttribute();
            }
            return !attribute.Match(attribute1);
        }

        /// <summary>
        /// Returns collection of properties of this object.
        /// </summary>
        /// <param name="attributes">Attributes for filtering.</param>
        /// <returns>Collection of properties descriptors.</returns>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
        {
            PropertyDescriptorCollection result = ((ICustomTypeDescriptor)this).GetProperties();
            if (attributes != null)
            {
                FilterMembers(result, attributes);
            }
            return result;
        }

        /// <summary>
        /// Gets object class name.
        /// </summary>
        /// <returns>Object class name.</returns>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        String ICustomTypeDescriptor.GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        /// <summary>
        /// Gets object attributes.
        /// </summary>
        /// <returns>Object attributes</returns>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        System.ComponentModel.AttributeCollection ICustomTypeDescriptor.GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        /// <summary>
        /// Gets object component name.
        /// </summary>
        /// <returns>Object component name.</returns>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        String ICustomTypeDescriptor.GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this, true);
        }

        /// <summary>
        /// Gets object converter.
        /// </summary>
        /// <returns>Object converter.</returns>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        TypeConverter ICustomTypeDescriptor.GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        /// <summary>
        /// Gets object default event.
        /// </summary>
        /// <returns>Object default event.</returns>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        /// <summary>
        /// Gets object default property.
        /// </summary>
        /// <returns>Object default property.</returns>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        /// <summary>
        /// Gets object editor.
        /// </summary>
        /// <param name="editorBaseType">Editor base type.</param>
        /// <returns>object editor.</returns>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
        {
                        
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        /// <summary>
        /// Gets object events.
        /// </summary>
        /// <param name="attributes">Filtering attributes.</param>
        /// <returns>Object events.</returns>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        /// <summary>
        /// Gets object events.
        /// </summary>
        /// <returns>Object events.</returns>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        /// <summary>
        /// Get property owner.
        /// </summary>
        /// <param name="pd">Property descriptor.</param>
        /// <returns>Property owner.</returns>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
        {
            ActionPropertyDescriptor apd = pd as ActionPropertyDescriptor;
            if (apd != null)
            {
                return apd.GetPropertyOwner();
            }
            return this;
        }

        #endregion

        #region Chart Reflection Methods And Properties

        /// <summary>
        /// Gets the chart object
        /// </summary>
        internal Chart Chart
        {
            get
            {
                return this.Component as Chart;
            }
        }

#if WINFORMS_CONTROL    
        /// <summary>
        /// Tracks object changes in transaction in order to record undo operations
        /// </summary>
        /// <param name="component">component which is about to change</param>
        /// <param name="callback">Method delegate which make the changed</param>
        /// <param name="context">context needed to make changes</param>
        /// <param name="description">Transaction name</param>
        /// <param name="member">Property descriptor</param>
    internal void InvokeTransactedChange(object component, TransactedChangeCallback callback, object context, string description, MemberDescriptor member)
    {
        IServiceProvider serviceProvider = this;
        if (component == null)
        {
            throw new ArgumentNullException("component");
        }
        if (callback == null)
        {
            throw new ArgumentNullException("callback");
        }
        IDesignerHost host1 = (IDesignerHost)serviceProvider.GetService(typeof(IDesignerHost));
        using (DesignerTransaction transaction1 = host1.CreateTransaction(description))
        {
            IComponentChangeService service1 = (IComponentChangeService)serviceProvider.GetService(typeof(IComponentChangeService));
            if (service1 != null)
            {
                try
                {
                    service1.OnComponentChanging(component, member);
                }
                catch (CheckoutException exception1)
                {
                    if (exception1 != CheckoutException.Canceled)
                    {
                        throw;
                    }
                    return;
                }
            }
            if (!callback(context))
            {
                return;
            }
            if (service1 != null)
            {
                service1.OnComponentChanged(component, member, null, null);
            }
            transaction1.Commit();
        }
    }

#endif //WINFORMS_CONTROL

        #endregion //Chart Mirror Methods And Properties

        #region TypeDescriptorContextImpl Embeded Class
        /// <summary>
        /// Custom TypeDescriptorContextImpl to replace or generate ITypeDescriptorContext
        /// for UIEditors.
        /// Provides contextual information about a component, such as its container and type descriptor.
        /// </summary>
        internal class TypeDescriptorContextImpl : ITypeDescriptorContext
        {
            #region Fields
            //Parent ChartActionList
            private ChartActionList designer;
            //Property desctiptor which will use this context in design time activities
            private PropertyDescriptor propDescriptor;
            #endregion //Fields

            #region Constructor
            /// <summary>
            /// Initializes new instance of TypeDescriptorContextImpl with specified parameters
            /// </summary>
            /// <param name="designer">The parent ChartActionList</param>
            /// <param name="propDescriptor">The target PropertyDescriptor</param>
            public TypeDescriptorContextImpl(ChartActionList designer, PropertyDescriptor propDescriptor)
            {
                this.designer = designer;
                this.propDescriptor = propDescriptor;
            }

            #endregion //Constructor

            #region Methods

            /// <summary>
            /// Returns the ComponentChangeService 
            /// </summary>
            private IComponentChangeService ComponentChangeService
            {
                get
                {
                    return (IComponentChangeService)this.GetService(typeof(IComponentChangeService));
                }
            }

            /// <summary>
            /// Returns a service by specified type
            /// </summary>
            /// <param name="serviceType"></param>
            /// <returns></returns>
            public object GetService(System.Type serviceType)
            {
                return ((IServiceProvider)this.designer).GetService(serviceType);
            }

            /// <summary>
            /// Gets the container representing this TypeDescriptor request.
            /// </summary>
            IContainer ITypeDescriptorContext.Container
            {
                get
                {
                    return designer.Component.Site.Container;
                }
            }

            /// <summary>
            /// Gets the object that is connected with this type descriptor request.
            /// </summary>
            public object Instance
            {
                get
                {

                    return designer.Component;
                }
            }

            /// <summary>
            /// Gets the PropertyDescriptor that is associated with the given context item
            /// </summary>
            public System.ComponentModel.PropertyDescriptor PropertyDescriptor
            {
                get
                {
                    return propDescriptor;
                }
            }

            /// <summary>
            /// Raises the ComponentChanged event. 
            /// </summary>
            void ITypeDescriptorContext.OnComponentChanged()
            {
                if (this.ComponentChangeService != null)
                {
                    this.ComponentChangeService.OnComponentChanged(this.Instance,
                    this.PropertyDescriptor, null, null);
                }
            }

            /// <summary>
            /// Raises the ComponentChanging event. 
            /// </summary>
            /// <returns>true if this object can be changed; otherwise, false. </returns>
            bool ITypeDescriptorContext.OnComponentChanging()
            {
                if (this.ComponentChangeService != null)
                {
                    try
                    {
                        this.ComponentChangeService.OnComponentChanging(this.Instance,
                            this.PropertyDescriptor);
                    }
                    catch (CheckoutException e)
                    {
                        if (e == CheckoutException.Canceled)
                            return false;
                        //throw e;
                    }
                }
                return true;
            }

            #endregion //Methods
        }

        #endregion TypeDescriptorContextImpl Class
    }

    #endregion //ChartActionList class

    #region ActionPropertyDescriptor Class

    /// <summary>
    /// Property descriptor with ability to dynamically change attributes 
    /// of the base property descriptor object. Used to expose chart properties to
    /// the design time action list. Note that action list accept and 
    /// visualize edit property items only on hist own properties.
    /// See DesignerActionPropertyItem.  The ChartActiolList implements 
    /// ICustomTypeDescriptor which deploy specified chart properties
    /// trought this ActionPropertyDescriptor.
    /// </summary>
    internal class ActionPropertyDescriptor : PropertyDescriptor
    {

        #region Fields

        // Reference to the base property descriptor
        private PropertyDescriptor basePropertyDescriptor = null;
        // Reference to the original object which this propery is bound to.
        private object target = null;
        // Parent ChartActionList object
        private ChartActionList actionList;

        #endregion // Fields

        #region Constructor

        /// <summary>
        /// Constructor of the dynamic property descriptor.
        /// Initializes new instance of ActionPropertyDescriptor based on specified
        /// parameters
        /// </summary>
        /// <param name="target">The original object which this propery is bound to</param>
        /// <param name="basePropertyDescriptor">Base property descriptor.</param>
        /// <param name="actionList">Parent ChartActionList object</param>
        internal ActionPropertyDescriptor(object target,
            PropertyDescriptor basePropertyDescriptor,
            ChartActionList actionList)
            : base(basePropertyDescriptor)
        {
            this.basePropertyDescriptor = basePropertyDescriptor;
            this.target = target;
            this.actionList = actionList;
        }

        #endregion // Constructor

        #region Properties

        /// <summary>
        /// Gets the type of the component this property is bound to.
        /// </summary>
        public override Type ComponentType
        {
            get
            {
                return basePropertyDescriptor.ComponentType;
            }
        }

        /// <summary>
        /// Gets the name that can be displayed in a window, such as a Properties window.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                string result = this.basePropertyDescriptor.DisplayName;
                if (result.StartsWith("ChartType", StringComparison.OrdinalIgnoreCase))
                {
                    return SR.ActionListSeriesChartType;
                }
                return result;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this property is browsable.
        /// The folowing code evaluates the object (Instance) state  
        /// and returns properly Browsable state
        /// to achieve visible/unvisible edit item into action list.
        /// </summary>
        public override bool IsBrowsable
        {
            get
            {
                if (this.Instance is Series)
                {
                    if (this.Name.StartsWith("ValueMember", StringComparison.OrdinalIgnoreCase))
                    {
                        // read possible values through property type converter
                        TypeConverter.StandardValuesCollection values =
                            this.Converter.GetStandardValues(
                                new ChartActionList.TypeDescriptorContextImpl(this.ActionList, this)
                            );

                        if (values.Count == 1)
                        {
                            return !values[0].ToString().Contains("(none)");
                        }
                        return values.Count > 0;
                    }
                }
                return this.basePropertyDescriptor.IsBrowsable;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this property is read-only.
        /// </summary>
        public override bool IsReadOnly
        {
            get
            {
                return this.basePropertyDescriptor.IsReadOnly;
            }
        }

        /// <summary>
        /// Gets the type of the property.
        /// </summary>
        public override Type PropertyType
        {
            get
            {
                return this.basePropertyDescriptor.PropertyType;
            }
        }

        /// <summary>
        /// Gets the current object instance which this property descriptor is bound to.
        /// </summary>
        internal object Instance
        {
            get
            {
                return this.target;
            }
        }

        /// <summary>
        /// Gets the parent ChartActionList which deploys this descriptor
        /// </summary>
        internal ChartActionList ActionList
        {
            get
            {
                return this.actionList;
            }
        }

        

        #endregion // Properties

        #region Methods

        /// <summary>
        /// Returns the property editor. This methos replaces the original editor in some cases 
        /// in order to mantain properly the ObjectContext which is used by original editor.
        /// Rreplaces all editors which support painting and data member editors.
        /// </summary>
        /// <param name="editorBaseType"></param>
        /// <returns>The property editor or null</returns>
        public override object GetEditor(Type editorBaseType)
        {
            // bypass value editor with checkboxes for YValuesPerPoint == 1
            if (this.Instance is Series)
            {
                if (this.Name.StartsWith("YValueMember", StringComparison.OrdinalIgnoreCase))
                {
                    ChartTypeRegistry registry = this.ActionList.Chart.GetService(typeof(ChartTypeRegistry)) as ChartTypeRegistry;
                    if (registry != null)
                    {
                        IChartType type = registry.GetChartType(((Series)this.target).ChartTypeName);
                        if (type != null && type.YValuesPerPoint < 2)
                        {
                            return null;
                        }
                    }
                }
            }
            if (this.Instance is ChartActionList && this.Name.StartsWith("ChartType", StringComparison.OrdinalIgnoreCase))
            {
                return new UITypeEditorProxy((UITypeEditor)base.GetEditor(editorBaseType), this, this.Instance);
            }
            return base.GetEditor(editorBaseType);
        }

        /// <summary>
        /// Returns an object that contains the property described by the specified property descriptor. 
        /// </summary>
        /// <returns></returns>
        internal object GetPropertyOwner()
        {
            return this.Instance;
        }

        /// <summary>
        /// Returns whether resetting an object changes its value.
        /// </summary>
        /// <param name="component">The component to test for reset capability.</param>
        /// <returns>true if resetting the component changes its value; otherwise, false.</returns>
        public override bool CanResetValue(object component)
        {
            return basePropertyDescriptor.CanResetValue(this.target);
        }

        /// <summary>
        /// Gets the current value of the property on a component.
        /// </summary>
        /// <param name="component">The component with the property for which to retrieve the value.</param>
        /// <returns>The value of a property for a given component.</returns>
        public override object GetValue(object component)
        {
            return this.basePropertyDescriptor.GetValue(this.target);
        }

        /// <summary>
        /// Resets the value for this property of the component to the default value.
        /// </summary>
        /// <param name="component">The component with the property value that is to be reset to the default value.</param>
        public override void ResetValue(object component)
        {
            this.basePropertyDescriptor.ResetValue(this.target);
        }

        /// <summary>
        /// Determines a value indicating whether the value of this property needs to be persisted.
        /// </summary>
        /// <param name="component">The component with the property to be examined for persistence.</param>
        /// <returns>True if the property should be persisted; otherwise, false.</returns>
        public override bool ShouldSerializeValue(object component)
        {
            return this.basePropertyDescriptor.ShouldSerializeValue(this.target);
        }


        private bool PropertyChangeCallBack(object context)
        {
            this.basePropertyDescriptor.SetValue(this.target, context);
            return true;
        }

#if WINFORMS_CONTROL
        /// <summary>
        /// Sets the value of the component to a different value.
        /// </summary>
        /// <param name="component">The component with the property value that is to be set.</param>
        /// <param name="value">The new value.</param>
        public override void SetValue(object component, object value)
        {
            System.Windows.Forms.Cursor cursor1 = System.Windows.Forms.Cursor.Current;
            try
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                this.ActionList.InvokeTransactedChange(this.Instance, new TransactedChangeCallback(this.PropertyChangeCallBack), value, "Change " + this.DisplayName, this);
            }
            finally
            {
                System.Windows.Forms.Cursor.Current = cursor1;
            }

        }

#else
        /// <summary>
        /// Sets the value of the component to a different value.
        /// </summary>
        /// <param name="component">The component with the property value that is to be set.</param>
        /// <param name="value">The new value.</param>
        public override void SetValue(object component, object value)
        {
            System.Windows.Forms.Cursor cursor1 = System.Windows.Forms.Cursor.Current;
            try
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                ControlDesigner.InvokeTransactedChange(this.ActionList.Component, new TransactedChangeCallback(this.PropertyChangeCallBack), value, String.Format(CultureInfo.CurrentCulture, "{0} Change", this.DisplayName));
                this.ActionList.GetDesigner().SetDirtyFlag(true);
            }
            finally
            {
                System.Windows.Forms.Cursor.Current = cursor1;
            }

        }

#endif //WINFORMS_CONTROL

        #endregion // Methods

    }

    #endregion  // CommandPropertyDescriptor Class

    #region UITypeEditorProxy

    /// <summary>
    /// Because the action list feature does not support owner draw list boxes 
    /// which is supported by property editor 
    /// (see UITypeEditor.GetPaintValueSupported() with enums)
    /// this is a replacement of original UITypeEditor which emulate property editor behavior 
    /// in GetPaintValueSupported() part and lefts the original editor to do the rest.
    /// </summary>
    internal class UITypeEditorProxy : UITypeEditor, ITypeDescriptorContext, IDisposable
    {

        #region Fields
        /// <summary>
        /// Instance to the original UITypeEditor
        /// </summary>
        private UITypeEditor targetEditor;
        /// <summary>
        /// The parent ActionPropertyDescriptor
        /// </summary>
        private PropertyDescriptor actionPropDesc;
        /// <summary>
        /// ListBox for visualization
        /// </summary>
        private ListBox listBox = new ListBox();
        /// <summary>
        /// The IWindowsFormsEditorService which display the list box
        /// </summary>
        IWindowsFormsEditorService edSvc;

        private object instance;

        #endregion //Fields

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the System.Drawing.Design.UITypeEditor class.
        /// </summary>
        public UITypeEditorProxy()
            : base()
        {
            listBox.DrawItem += new DrawItemEventHandler(listBox_DrawItem);
            listBox.DrawMode = DrawMode.OwnerDrawFixed;
            listBox.BorderStyle = BorderStyle.None;
            listBox.Click += new EventHandler(listBox_Click);
            listBox.KeyPress += new KeyPressEventHandler(listBox_KeyPress);
            listBox.Font = new Font("MS Shell Dlg", 8);
            listBox.ItemHeight = this.listBox.Font.Height + 2;
            listBox.IntegralHeight = false;
        }



        /// <summary>
        /// Initializes a new instance of the System.Drawing.Design.UITypeEditor class with
        /// specified UITypeEditor and PropertyDescriptor
        /// </summary>
        /// <param name="targetEditor">The target editor.</param>
        /// <param name="actionPropDesc">The action prop desc.</param>
        /// <param name="instance">The instance.</param>
        public UITypeEditorProxy(UITypeEditor targetEditor, PropertyDescriptor actionPropDesc, object instance)
            : this()
        {
            this.actionPropDesc = actionPropDesc;
            this.targetEditor = targetEditor;
            this.instance = instance;
        }


        #endregion //Constructors

        #region Methods

        /// <summary>
        /// Occurs when a key is pressed while the control has focus.
        /// Closes the list box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Provides data for the KeyPress event.</param>
        private void listBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13 && edSvc != null)
            {
                edSvc.CloseDropDown();
            }
        }


        /// <summary>
        /// Occurs when the control is clicked.Closes the list box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e"></param>
        private void listBox_Click(object sender, EventArgs e)
        {
            if (edSvc != null)
            {
                edSvc.CloseDropDown();
            }
        }

        /// <summary>
        /// Occurs when a visual aspect of an owner-drawn ListBox changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            using (Bitmap bmp = new Bitmap(16, e.Bounds.Height - 2))
            {
                string textToPrint = this.listBox.Items[e.Index].ToString();
                object valueToPrint = Enum.Parse(this.actionPropDesc.PropertyType, textToPrint);
                // Draw text item
                using (Brush brush = new SolidBrush(this.listBox.ForeColor))
                {
                    StringFormat fmt = new StringFormat();
                    fmt.LineAlignment = StringAlignment.Center;
                    Rectangle r = e.Bounds;
                    r.Offset(18, 0);
                    r.Width -= 18;
                    // Draw the current item text based on the current Font and the custom brush settings.
                    e.Graphics.DrawString(textToPrint, e.Font, brush, r, fmt);
                }
                // call default PaintValue
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(e.BackColor);
                    Rectangle r = new Rectangle(0, 0, 16, e.Bounds.Height - 2);
                    this.PaintValue(new PaintValueEventArgs(null, valueToPrint, g, r));
                    r = e.Bounds;
                    r.Width = 16;
                    r.Height -= 2;
                    r.Offset(1, 1);
                    e.Graphics.DrawImageUnscaled(bmp, r);
                    e.Graphics.DrawRectangle(Pens.Gray, r);

                }
            }
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        /// <summary>
        /// Gets a value indicating whether drop-down editors should be resizable by the user.
        /// </summary>
        /// <returns>
        /// true, if drop-down editors are resizable; otherwise, false. 
        /// </returns>
        public override bool IsDropDownResizable
        {
            get
            {
                return this.targetEditor.IsDropDownResizable;
            }
        }
        /// <summary>
        /// Edits the specified object's value using the editor style indicated by
        /// System.Drawing.Design.UITypeEditor.GetEditStyle().
        /// </summary>
        /// <param name="context">
        ///    An System.ComponentModel.ITypeDescriptorContext that can be used to gain
        ///    additional context information. 
        /// </param>
        /// <param name="provider">
        /// An System.IServiceProvider that this editor can use to obtain services. 
        /// </param>
        /// <param name="value">
        /// The object to edit. 
        /// </param>
        /// <returns>The new value of the object. If the value of the object hasn't changed, this should return the same object it was passed.</returns>
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if (value == null || context == null || context.Instance == null || context.PropertyDescriptor == null)
                return value;

            // Uses the IWindowsFormsEditorService to display a 
            // drop-down UI in the Properties window.
            edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null)
            {

                this.listBox.Items.Clear();
                this.listBox.Items.AddRange(Enum.GetNames(context.PropertyDescriptor.PropertyType));
                this.listBox.SelectedIndex = this.listBox.Items.IndexOf(value.ToString());
                this.listBox.ItemHeight = this.listBox.Font.Height + 2;
                this.listBox.Height = Math.Min(12, this.listBox.Items.Count) * this.listBox.ItemHeight;

                edSvc.DropDownControl(listBox);

                string textToPrint = this.listBox.SelectedItem.ToString();
                value = Enum.Parse(this.actionPropDesc.PropertyType, textToPrint);
                edSvc = null;
            }
            return value;
        }

        /// <summary>
        /// Gets the editor style used by the System.Drawing.Design.UITypeEditor.EditValue(System.IServiceProvider,System.Object) method.
        /// </summary>
        /// <param name="context">An System.ComponentModel.ITypeDescriptorContext that can be used to gain additional context information. </param>
        /// <returns>
        /// A System.Drawing.Design.UITypeEditorEditStyle value that indicates the style
        /// of editor used by
        /// System.Drawing.Design.UITypeEditor.EditValue(System.IServiceProvider,System.Object).
        /// If the System.Drawing.Design.UITypeEditor does not support this method, then
        /// System.Drawing.Design.UITypeEditor.GetEditStyle() will return
        /// System.Drawing.Design.UITypeEditorEditStyle.None.
        /// </returns>
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }
        /// <summary>
        /// Indicates whether the specified context supports painting a representation of an object's value within the specified context.
        /// </summary>
        /// <param name="context">An System.ComponentModel.ITypeDescriptorContext that can be used to gain additional context information. </param>
        /// <returns>
        /// true if System.Drawing.Design.UITypeEditor.PaintValue(System.Object,System.Drawing.Graphics,System.Drawing.Rectangle) is implemented; otherwise, false.
        /// </returns>
        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return this.targetEditor.GetPaintValueSupported(this);
        }

        /// <summary>
        /// Paints a representation of the value of an object using the specified System.Drawing.Design.PaintValueEventArgs.
        /// </summary>
        /// <param name="e">A System.Drawing.Design.PaintValueEventArgs that indicates what to paint and where to paint it. </param>
        public override void PaintValue(PaintValueEventArgs e)
        {
            PaintValueEventArgs newe = new PaintValueEventArgs(this, e.Value, e.Graphics, e.Bounds);
            this.targetEditor.PaintValue(newe);
        }

        #endregion //Methods

        #region ITypeDescriptorContext Members

        /// <summary>
        /// Gets the container representing this TypeDescriptor request.
        /// </summary>
        IContainer ITypeDescriptorContext.Container
        {
            get
            {
                return null;
            }
        }
        /// <summary>
        /// Gets the instance of the object that is connected with this TypeDescriptor request.
        /// </summary>
        object ITypeDescriptorContext.Instance
        {
            get
            {
                return this.instance;
            }
        }
        /// <summary>
        /// Raises the ComponentChanged event.
        /// </summary>
        void ITypeDescriptorContext.OnComponentChanged()
        {
            ;
        }
        /// <summary>
        /// Returns a value indicating whether this object can be changed.
        /// </summary>
        /// <returns></returns>
        bool ITypeDescriptorContext.OnComponentChanging()
        {
            return true;
        }
        /// <summary>
        /// Gets the PropertyDescriptor that describes the given context item.
        /// </summary>
        PropertyDescriptor ITypeDescriptorContext.PropertyDescriptor
        {
            get
            {
                return this.actionPropDesc;
            }
        }

        #endregion

        #region IServiceProvider Members
        /// <summary>
        /// Gets the service object of the specified type.
        /// </summary>
        /// <param name="serviceType">An object that specifies the type of service object to get.</param>
        /// <returns>A service object of type serviceType. -or- null</returns>
        object IServiceProvider.GetService(Type serviceType)
        {
            if (this.instance is IServiceProvider)
            {
                return ((IServiceProvider)this.instance).GetService(serviceType);
            }
            return null;
        }

        #endregion


        #region IDisposable Members

        public void Dispose()
        {
            if (this.listBox != null)
            {
                this.listBox.Dispose();
                this.listBox = null;
            }
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    #endregion //UITypeEditorProxy
    
    #region DesignerActionVerbItem class
    /// <summary>
    /// The DesignerActionVerbItem is used to convert DesignerVerbs to DesignerActionVerbItem
    /// </summary>
    internal class DesignerActionVerbItem : DesignerActionMethodItem
    {
        //The verb to emulate
        private DesignerVerb verb;

        /// <summary>
        /// Initializes new instance of DesignerActionVerbItem using specified parameters
        /// </summary>
        /// <param name="list">The parent DesignerActionList</param>
        /// <param name="verb">The verb to emulate</param>
        /// <param name="category">Category which is used for DesignerActionItem</param>
        internal DesignerActionVerbItem(DesignerActionList list, DesignerVerb verb, string category)
            : base(list, string.Empty, verb.Text, category)
        {
            this.verb = verb;
        }

        /// <summary>
        /// Programmatically executes the method associated with the DesignerActionMethodItem. 
        /// </summary>
        public override void Invoke()
        {
            this.verb.Invoke();
        }
    }

    #endregion //DesignerActionVerbItem class

}
