﻿// ----------------------------------------------------------------------
// <copyright file="StringsWorkaround.cs">
//     Copyright (c) The Loxone.NET Authors.  All rights reserved.
// </copyright>
// <license>
//     Use of this source code is governed by the MIT license that can be
//     found in the LICENSE.txt file.
// </license>
// ----------------------------------------------------------------------

namespace Loxone.Client
{
    // https://github.com/dotnet/roslyn-project-system/issues/747

    internal static class Strings
    {
        public const string ColorConverter_InvalidFormat = "The color must be specified in format '#RRGGBB'.";
        public const string HexConverter_BadFormat = "Hex string format is invalid.";
        public const string MiniserverCommandException_MessageFmt = "Miniserver command failed with status code {0}.";
        public const string MiniserverConnection_MustBeSetBeforeOpenFmt = "Property '{0}' must be set before opening the connection.";
        public const string MiniserverTransportException_Message = "Message received from Miniserver has invalid format.";
        public const string Uuid_ArgMustBeUuid = "Argument must be of type Uuid";
        public const string UuidConverter_UnexpectedValue = "Unexpected value when converting UUID.";
    }
}
