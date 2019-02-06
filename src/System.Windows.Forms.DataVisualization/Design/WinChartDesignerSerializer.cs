// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	Windows forms chart control designer class.
//


using System.ComponentModel.Design.Serialization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Utilities;

namespace System.Windows.Forms.Design.DataVisualization.Charting
{
    /// <summary>
    /// Windows forms chart control designer class.
    /// </summary>
    internal class ChartWinDesignerSerializer : CodeDomSerializer
	{
		#region Methods

		/// <summary>
		/// Serializes the specified object into a CodeDOM object.
		/// </summary>
		/// <param name="manager">A serialization manager interface that is used during the deserialization process.</param>
		/// <param name="value">The object to serialize.</param>
		/// <returns>A CodeDOM object representing the object that has been serialized.</returns>
		public override object Serialize(IDesignerSerializationManager manager, object value)
		{
			// Set serialization flag
			bool	oldSerializationFlag = false;
            SerializationStatus oldSerializationStatus = SerializationStatus.None;

            Chart chart = value as Chart;
			if(chart != null)
			{
                oldSerializationFlag = chart.serializing;
                oldSerializationStatus = chart.serializationStatus;

                chart.serializing = true;
                chart.serializationStatus = SerializationStatus.Saving;
			}

			// Serialize object using the base class serializer
			object	result = null;
			CodeDomSerializer baseSerializer = (CodeDomSerializer)manager.GetSerializer(typeof(Chart).BaseType, typeof(CodeDomSerializer));
			if(baseSerializer != null)
			{
				result = baseSerializer.Serialize(manager, value);

                System.CodeDom.CodeStatementCollection statements = result as System.CodeDom.CodeStatementCollection;

				// Sustom serialization of the DataSource property
                if (statements != null && chart != null) 
				{
					// Check if DataSource property is set 
					if(chart.DataSource != null && chart.DataSource is String && ((String)chart.DataSource) != "(none)")
					{
						// Add assignment statement for the DataSource property
						System.CodeDom.CodeExpression targetObject = 
							base.SerializeToExpression(manager, value);
						if (targetObject != null) 
						{
							System.CodeDom.CodeAssignStatement assignStatement = new System.CodeDom.CodeAssignStatement(
								new System.CodeDom.CodePropertyReferenceExpression (targetObject, "DataSource"),
								new System.CodeDom.CodePropertyReferenceExpression (new System.CodeDom.CodeThisReferenceExpression(), (String)chart.DataSource));
							statements.Add(assignStatement);
						}
					}
				}
			}

			// Clear serialization flag
			if(chart != null)
			{
                chart.serializing = oldSerializationFlag;
                chart.serializationStatus = oldSerializationStatus;
			}

			return result;
		}

		/// <summary>
		/// Deserializes the specified serialized CodeDOM object into an object.
		/// </summary>
		/// <param name="manager">A serialization manager interface that is used during the deserialization process.</param>
		/// <param name="codeObject">A serialized CodeDOM object to deserialize.</param>
		/// <returns>The deserialized CodeDOM object.</returns>
		public override object Deserialize(IDesignerSerializationManager manager,object codeObject)
		{
			CodeDomSerializer baseSerializer = (CodeDomSerializer)manager.GetSerializer(typeof(Chart).BaseType, typeof(CodeDomSerializer));
			if(baseSerializer != null)
			{
				return baseSerializer.Deserialize(manager, codeObject);
			}

			return null;
		}

		#endregion
	}
}

