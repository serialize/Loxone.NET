// ----------------------------------------------------------------------
// <copyright file="ValueStateEventArgs.cs">
//     Copyright (c) The Loxone.NET Authors.  All rights reserved.
// </copyright>
// <license>
//     Use of this source code is governed by the MIT license that can be
//     found in the LICENSE.txt file.
// </license>
// ----------------------------------------------------------------------

namespace Loxone.Client.Transport
{
    using System;
    using System.Collections.Generic;

    public static class ReadOnlyCollection
    {
        public static IReadOnlyCollection<TResult> Empty<TResult>()
        {
            return EmptyReadOnlyCollection<TResult>.Instance;
        }

        private static class EmptyReadOnlyCollection<TElement>
        {
            static volatile TElement[] _instance;

            public static IReadOnlyCollection<TElement> Instance
            {
                get { return _instance ?? (_instance = new TElement[0]); }
            }
        }
    }
}