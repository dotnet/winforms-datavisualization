// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace System.Windows.Forms.DataVisualization.Charting
{
    /// <summary>
    /// IChartElement is implemented by both ChartElements and ChartElementCollection to provide a unified access to Parent/Common elements. 
    /// </summary>
    internal interface IChartElement
    {
        //Properties
        IChartElement Parent { get; set; }
        CommonElements Common { get; }

        //Methods
        void Invalidate();
    }


    /// <summary>
    /// Named controller interface allows ChartNamedElements to check the uniqueness of their names 
    /// </summary>
    internal interface INameController
    {

        /// <summary>
        /// Determines whether is the name us unique.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>
        /// 	<c>true</c> if is the name us unique; otherwise, <c>false</c>.
        /// </returns>
        bool IsUniqueName(string name);
        /// <summary>
        /// Gets or sets a value indicating whether this instance is in edit mode by collecrtion editor.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance the colection is editing; otherwise, <c>false</c>.
        /// </value>
        bool IsColectionEditing { get; set; }
        /// <summary>
        /// Does the snapshot of collection items.
        /// </summary>
        /// <param name="save">if set to <c>true</c> collection items will be saved.</param>
        /// <param name="changingCallback">The changing callback.</param>
        /// <param name="changedCallback">The changed callback.</param>
        void DoSnapshot(bool save,
            EventHandler<NameReferenceChangedEventArgs> changingCallback,
            EventHandler<NameReferenceChangedEventArgs> changedCallback);
        /// <summary>
        /// Gets the snapshot of saved collection items.
        /// </summary>
        /// <value>The snapshot.</value>
        IList Snapshot {get;}
        /// <summary>
        /// Raises the <see cref="E:NameReferenceChanged"/> event.
        /// </summary>
        /// <param name="e">The <see cref="NameReferenceChangedEventArgs"/> instance containing the event data.</param>
        void OnNameReferenceChanged(NameReferenceChangedEventArgs e);
        /// <summary>
        /// Raises the <see cref="E:NameReferenceChanging"/> event.
        /// </summary>
        /// <param name="e">The <see cref="NameReferenceChangedEventArgs"/> instance containing the event data.</param>
        void OnNameReferenceChanging(NameReferenceChangedEventArgs e);
    }

}
