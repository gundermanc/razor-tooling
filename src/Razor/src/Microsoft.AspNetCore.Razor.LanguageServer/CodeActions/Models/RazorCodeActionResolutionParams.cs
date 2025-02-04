﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

#nullable disable

using Newtonsoft.Json;

namespace Microsoft.AspNetCore.Razor.LanguageServer.CodeActions.Models
{
    [JsonObject]
    internal class RazorCodeActionResolutionParams
    {
        [JsonProperty(PropertyName = "action", Required = Required.Always)]
        public string Action { get; set; }

        [JsonProperty(PropertyName = "language", Required = Required.Always)]
        public string Language { get; set; }

        [JsonProperty(PropertyName = "data", Required = Required.Always)]
        public object Data { get; set; }
    }
}
