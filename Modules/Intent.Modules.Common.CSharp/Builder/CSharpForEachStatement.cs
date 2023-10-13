﻿using System;

namespace Intent.Modules.Common.CSharp.Builder;

public class CSharpForEachStatement : CSharpStatementBlock
{

    public CSharpForEachStatement(string iterationVariable, string sourceCollection)
    {
        Text = $"foreach (var {iterationVariable} in {sourceCollection})";
        BeforeSeparator = CSharpCodeSeparatorType.EmptyLines;
    }

    public CSharpForEachStatement Await()
    {
        Text = "await " + Text;
        return this;
    }
}