// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	Design-time support classes for Legend.
//


using System.ComponentModel;
using System.Windows.Forms.DataVisualization.Charting;

namespace System.Windows.Forms.Design.DataVisualization.Charting
{
    /// <summary>
    /// Designer editor for the custom legend items collection.
    /// </summary>
    internal class LegendItemCollectionEditor : ChartCollectionEditor
	{
		#region Editor methods

		/// <summary>
		/// Object constructor.
		/// </summary>
		public LegendItemCollectionEditor() : base(typeof(LegendItemsCollection))
		{
		}

		/// <summary>
		/// Edit object's value.
		/// </summary>
		/// <param name="context">Descriptor context.</param>
		/// <param name="provider">Service provider.</param>
		/// <param name="value">Calue.</param>
		/// <returns>Object.</returns>
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) 
		{
			return base.EditValue(context, provider, value);
		}

		#endregion
	}

	/// <summary>
	/// Designer editor for the legend collection.
	/// </summary>
	internal class LegendCollectionEditor : ChartCollectionEditor
	{
		#region Editor methods

		/// <summary>
		/// Object constructor.
		/// </summary>
		public LegendCollectionEditor() : base(typeof(LegendCollection))
		{
		}

		/// <summary>
		/// Create series instance in the editor 
		/// </summary>
		/// <param name="itemType">Item type.</param>
		/// <returns>Newly created item.</returns>
		protected override object CreateInstance(Type itemType)
		{
			if (Context != null && Context.Instance != null)
			{
				Chart	control = (Chart)Context.Instance;
				// Create legend with unique name
				int		countLegend = control.Legends.Count + 1;
				string	legendName = "Legend" + countLegend.ToString(System.Globalization.CultureInfo.InvariantCulture);

				// Check if this name already in use
				bool	legendFound = true;
				while(legendFound)
				{
					legendFound = false;
					foreach(Legend legend in control.Legends)
					{
						if(legend.Name == legendName)
						{
							legendFound = true;
						}
					}

					if(legendFound)
					{
						++countLegend;
						legendName = "Legend" + countLegend.ToString(System.Globalization.CultureInfo.InvariantCulture);
					}
				}

				// Create new legend
				Legend	newLegend = new Legend(legendName);
				return newLegend;
			}

			return base.CreateInstance(itemType);
		}

        #endregion
	}



	/// <summary>
	/// Designer editor for the legend column collection.
	/// </summary>
	internal class LegendCellColumnCollectionEditor : ChartCollectionEditor
	{
    #region Editor methods

		/// <summary>
		/// Object constructor.
		/// </summary>
		public LegendCellColumnCollectionEditor() : base(typeof(LegendCellColumnCollection))
		{
		}

		/// <summary>
		/// Create series instance in the editor 
		/// </summary>
		/// <param name="itemType">Item type.</param>
		/// <returns>Newly created item.</returns>
		protected override object CreateInstance(Type itemType)
		{
			if (Context != null && Context.Instance != null)
			{
			    Legend	legend = Context.Instance as Legend;
				if(legend != null)
				{
					int itemCount = legend.CellColumns.Count + 1;
					string itemName = "Column" + itemCount.ToString(System.Globalization.CultureInfo.InvariantCulture);

					// Check if this name already in use
					bool itemFound = true;
					while (itemFound)
					{
						itemFound = false;
						foreach (LegendCellColumn column in legend.CellColumns)
						{
							if (column.Name == itemName)
							{
								itemFound = true;
							}
						}

						if (itemFound)
						{
							++itemCount;
							itemName = "Column" + itemCount.ToString(System.Globalization.CultureInfo.InvariantCulture);
						}
					}

					// Create new legend column
					LegendCellColumn legendColumn = new LegendCellColumn();
					legendColumn.Name = itemName;
					return legendColumn;
				}
			}
			return base.CreateInstance(itemType);
		}

        #endregion
	}

		/// <summary>
		/// Designer editor for the legend cell collection.
		/// </summary>
		internal class LegendCellCollectionEditor : ChartCollectionEditor
		{
    #region Editor methods

			/// <summary>
			/// Object constructor.
			/// </summary>
			public LegendCellCollectionEditor() : base(typeof(LegendCellCollection))
			{
			}

			/// <summary>
			/// Create series instance in the editor 
			/// </summary>
			/// <param name="itemType">Item type.</param>
			/// <returns>Newly created item.</returns>
			protected override object CreateInstance(Type itemType)
			{
				if (Context != null && Context.Instance != null)
				{
			        LegendItem	legendItem = Context.Instance as LegendItem;
					if(legendItem != null)
					{
						int itemCount = legendItem.Cells.Count + 1;
						string itemName = "Cell" + itemCount.ToString(System.Globalization.CultureInfo.InvariantCulture);

						// Check if this name already in use
						bool itemFound = true;
						while (itemFound)
						{
							itemFound = false;
							foreach (LegendCell cell in legendItem.Cells)
							{
								if (cell.Name == itemName)
								{
									itemFound = true;
								}
							}

							if (itemFound)
							{
								++itemCount;
								itemName = "Cell" + itemCount.ToString(System.Globalization.CultureInfo.InvariantCulture);
							}
						}

						// Create new legend cell
						LegendCell legendCell = new LegendCell();
						legendCell.Name = itemName;
						return legendCell;
					}
				}
				return base.CreateInstance(itemType);
			}

        #endregion
		}

}
