// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

//
// Description:
//   Provides an internal way to get the baml reader from a markup extension.
//   This was created for internal use, by the resource reference code, as a
//   quick fix.  It should be replaced by a public API to do the resource
//   lookup in the parser stack.
//

namespace System.Windows.Markup
{
    internal interface IHaveResources
    {
        ResourceDictionary Resources { get; set; }
    }
}
