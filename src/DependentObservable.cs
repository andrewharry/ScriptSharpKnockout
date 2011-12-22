// DependentObservable.cs
// Script#/Libraries/Knockout
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;
using System.Collections;

namespace KnockoutApi {

    /// <summary>
    /// Represents an object containing a value dependent on other observable values.
    /// 'DependentObservable' was renamed to 'Computed' in version 2.0 (DependentObservable is still supported)
    /// </summary>
    /// <typeparam name="T">The type of the contained value.</typeparam>
    [Imported]
    [IgnoreNamespace]
    public sealed class DependentObservable<T> : Computed<T> { 
    }
}
