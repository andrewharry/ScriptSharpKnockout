// DependentObservableOptions.cs
// Script#/Libraries/Knockout
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;

namespace KnockoutApi {

    /// <summary>
    /// Provides advanced options for defining a dependent observable.
    /// 'DependentObservable' was renamed to 'Computed' in version 2.0 (DependentObservable is still supported)
    /// </summary>
    /// <typeparam name="T">The type of the observable value.</typeparam>
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class DependentObservableOptions<T>: ComputedOptions<T> {
    }
}
