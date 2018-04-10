﻿// ----------------------------------------------------------------------
// <copyright file="StringCommandHandler.cs">
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
    using System.Threading;
    using System.Threading.Tasks;

    internal class StringCommandHandler : TaskCompletionCommandHandler<string>
    {
        public override bool CanHandleMessage(MessageIdentifier identifier) => identifier == MessageIdentifier.Binary;

        public override async Task HandleMessageAsync(MessageHeader header, LXWebSocket socket, CancellationToken cancellationToken)
        {
            var content = new byte[header.Length];
            await socket.ReceiveAtomicAsync(new ArraySegment<byte>(content), true, cancellationToken).ConfigureAwait(false);
            var s = LXWebSocket.Encoding.GetString(content);
            base.TrySetResult(s);
        }
    }
}
