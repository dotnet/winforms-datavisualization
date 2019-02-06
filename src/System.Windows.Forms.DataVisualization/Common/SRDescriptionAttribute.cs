// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace System.Windows.Forms.DataVisualization.Charting
{
    [AttributeUsage(AttributeTargets.All)]
    internal sealed class SRDescriptionAttribute : DescriptionAttribute
    {
        // Fields
        private bool replaced;

        // Methods
        public SRDescriptionAttribute(string description)
            : base(description)
        {
        }

        // Properties
        public override string Description
        {
            get
            {
                if (!this.replaced)
                {
                    this.replaced = true;
                    base.DescriptionValue = SR.Keys.GetString(base.Description);
                }
                return base.Description;
            }
        }
    }

 

}
