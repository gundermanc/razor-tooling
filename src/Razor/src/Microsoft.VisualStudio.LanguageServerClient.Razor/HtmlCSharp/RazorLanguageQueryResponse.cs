﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.VisualStudio.LanguageServer.Protocol;

namespace Microsoft.VisualStudio.LanguageServerClient.Razor.HtmlCSharp
{
    internal class RazorLanguageQueryResponse
    {
        public RazorLanguageKind Kind { get; set; }

        public int PositionIndex { get; set; }

        public Position Position { get; set; }

        public long HostDocumentVersion { get; set; }
    }
}
