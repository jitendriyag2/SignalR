﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNetCore.Sockets.HttpServer
{
    [Flags]
    public enum ConnectionOptions
    {
        None = 0,
        Close = 1,
        KeepAlive = 2,
        Upgrade = 4
    }
}
