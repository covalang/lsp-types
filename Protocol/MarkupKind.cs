﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace LspTypes
{
    //
    // Summary:
    //     Enum which represents the various formats of markup text.
    [DataContract]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MarkupKind
    {
        //
        // Summary:
        //     Markup type is plain text.
        [EnumMember(Value = "plaintext")]
        PlainText = 0,
        //
        // Summary:
        //     Markup type is Markdown.
        [EnumMember(Value = "markdown")]
        Markdown = 1
    }
}
