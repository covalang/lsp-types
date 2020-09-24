﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    //
    // Summary:
    //     Class representing a set of changes to a single text document.
    [DataContract]
    public class TextDocumentEdit
    {
        public TextDocumentEdit() { }

        //
        // Summary:
        //     Gets or sets a document identifier indication which document to apply the edits
        //     to.
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Always)]
        public VersionedTextDocumentIdentifier TextDocument { get; set; }
        //
        // Summary:
        //     Gets or sets the array of edits to be applied to the document.
        [DataMember(Name = "edits")]
        [JsonProperty(Required = Required.Always)]
        public TextEdit[] Edits { get; set; }
    }
}
