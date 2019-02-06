// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	Design-time editor for the enumerations with Flags attribute.
//				Editor displays the drop down list with check marks.
//


using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.DataVisualization.Charting;

namespace System.Windows.Forms.Design.DataVisualization.Charting
{
    /// <summary>
    /// UI type editor for the enumerations with Flags attribute
    /// </summary>
    internal class FlagsEnumUITypeEditor : System.Drawing.Design.UITypeEditor 
	{
		#region Constructor

		/// <summary>
		/// Enumeration type.
		/// </summary>
		private	Type	_enumType = null;

		#endregion

		#region Editor methods and properties

		private IWindowsFormsEditorService	_edSvc = null;

		/// <summary>
		/// Display a drop down list with check boxes.
		/// </summary>
		/// <param name="context">Editing context.</param>
		/// <param name="provider">Provider.</param>
		/// <param name="value">Value to edit.</param>
		/// <returns>Result</returns>
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) 
		{
			if (context != null && context.Instance != null && provider != null) 
			{
				_edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
				if (_edSvc != null) 
				{
					// Get enum type
					if(value != null)
					{
						this._enumType = value.GetType();
					}
					else if(context != null && context.PropertyDescriptor != null)
					{
						this._enumType = context.PropertyDescriptor.PropertyType;
					}

					if(this._enumType != null)
					{
						// Create control for editing
						FlagsEnumCheckedListBox control = new FlagsEnumCheckedListBox(value, this._enumType);

						// Show drop down control
						_edSvc.DropDownControl(control);

						// Get new enumeration value
						value = control.GetNewValue();
					}
				}
			}

			return value;
		}

		/// <summary>
		/// Gets editing style.
		/// </summary>
		/// <param name="context">Editing context.</param>
		/// <returns>Editor style.</returns>
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context) 
		{
			if (context != null && context.Instance != null) 
			{
				return UITypeEditorEditStyle.DropDown;
			}
			return base.GetEditStyle(context);
		}
	
		#endregion
	}

	/// <summary>
	/// Checked list box, which is used for the UI type editing.
	/// </summary>
	internal class FlagsEnumCheckedListBox : CheckedListBox
	{
		#region Control fields

		// Enumeration object to edit
		private	object		_editValue = null;

		// Enumeration type to edit
		private	Type		_editType = null;

		#endregion

		#region Control constructor

		/// <summary>
		/// Public constructor.
		/// </summary>
		/// <param name="editValue">Value to edit.</param>
		/// <param name="editType">Typpe to edit.</param>
		public FlagsEnumCheckedListBox(object editValue, Type editType)
		{
			// Set editable value
			this._editValue = editValue;
			this._editType = editType;

			// Set control border style
			this.BorderStyle = System.Windows.Forms.BorderStyle.None;

			// Fill enum items list
			this.FillList();
		}

		#endregion

		#region Control methods

		/// <summary>
		/// Fills checked list items
		/// </summary>
		private void FillList()
		{
			// Check if editable object is of type Enum
			if(!(this._editType.IsEnum))
			{
                throw (new ArgumentException(SR.ExceptionEditorUITypeEditorInapplicable));
			}

			// Check underlying type
			if(Enum.GetUnderlyingType(this._editType) != typeof(Int32))
			{
                throw (new ArgumentException(SR.ExceptionEditorUITypeEditorInt32ApplicableOnly));
			}

			// Convert enumeration value to Int32
			Int32	editValueInt32 = 0;
			if(_editValue != null)
			{
				editValueInt32 = (Int32)_editValue;
			}

			// Fill list with all possible values in the enumeration
			foreach(object enumValue in Enum.GetValues(this._editType))
			{
				// Add items into list except the enum value zero
				Int32	currentValueInt32 = (Int32)enumValue;
				if(currentValueInt32 != 0)
				{
					bool isChecked = (editValueInt32 & currentValueInt32) == currentValueInt32;
					this.Items.Add(Enum.GetName(this._editType, enumValue), isChecked);
				}
			}
		}

		/// <summary>
		/// Gets new enumeration value.
		/// </summary>
		/// <returns>New enum value.</returns>
		public object GetNewValue()
		{
			// Update enumeration flags
			Int32	editValueInt32 = 0;
			foreach(object checkedItem in this.CheckedItems)
			{
				Int32	currentValueInt32 = (Int32)Enum.Parse(this._editType, (string)checkedItem);
				editValueInt32 = editValueInt32 | currentValueInt32;
			}

			// Return enumeration value
			return Enum.ToObject(this._editType, editValueInt32);
		}

		#endregion
	}
}

