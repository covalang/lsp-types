﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    //
    // Summary:
    //     Class which represents a position within a text document.
    [DataContract]
    public class TextDocumentPositionParams
    {
        public TextDocumentPositionParams() { }

        //
        // Summary:
        //     Gets or sets the value which identifies the document.
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Always)]
        public TextDocumentIdentifier TextDocument { get; set; }
        //
        // Summary:
        //     Gets or sets the value which indicates the position within the document.
        [DataMember(Name = "position")]
        [JsonProperty(Required = Required.Always)]
        public Position Position { get; set; }
    }
}
