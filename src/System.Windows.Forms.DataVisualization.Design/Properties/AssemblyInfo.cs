﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using System;

#pragma warning disable 0436
// The same auto generated class AssemblyRef exists in this assembly but in System.Web.DataVisualization as well. Suppress warning.
// TODO: This is attribute is temporary added until the build engine starts to support RefAsmGenKeepOption in csproj 
// in order to generate asmmeta file with all internals.
// See bug 741422 for details.
[assembly: InternalsVisibleTo("System.Windows.Forms.DataVisualization.Design")]
#pragma warning restore 0436

[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
    Justification="This is a false positive. There are at least 15 types in the namespace System.Windows.Forms.Design.DataVisualization.Charting, yet FxCop "
    + "emits this warning with 50% certainty. Also note, the web design project has just as many types, with no warning emitted",
    Scope="namespace",
    Target="System.Windows.Forms.Design.DataVisualization.Charting")]

#if VS_BUILD
[assembly: AssemblyVersion(System.Windows.Forms.DataVisualization.Charting.Editors.Version)]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
#endif //VS_BUILD