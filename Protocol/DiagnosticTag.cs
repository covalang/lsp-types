﻿namespace LspTypes
{
    //
    // Summary:
    //     Diagnostic tag enum. Additional metadata about the type of a diagnostic
    public enum DiagnosticTag
    {
        // Unused or unnecessary code.
        // Clients are allowed to render diagnostics with this tag faded out instead of having
        // an error squiggle.
        Unnecessary = 1,
        // Deprecated or obsolete code.
        // Clients are allowed to rendered diagnostics with this tag strike through.
        Deprecated = 2
    }
}
