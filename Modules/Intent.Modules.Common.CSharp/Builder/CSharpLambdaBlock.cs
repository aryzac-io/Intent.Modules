﻿using System.Collections.Generic;

namespace Intent.Modules.Common.CSharp.Builder;

public class CSharpLambdaBlock : CSharpStatement, IHasCSharpStatements
{
    private bool _withSemicolon;

    public CSharpLambdaBlock(string invocation) : base(invocation)
    {
        BeforeSeparator = CSharpCodeSeparatorType.EmptyLines;
        AfterSeparator = CSharpCodeSeparatorType.EmptyLines;
    }

    public List<CSharpStatement> Statements { get; } = new();

    public CSharpLambdaBlock WithSemicolon()
    {
        _withSemicolon = true;
        return this;
    }

    public override string GetText(string indentation)
    {
        return @$"{base.GetText(indentation)} =>
{indentation}{RelativeIndentation}{{{Statements.ConcatCode($"{indentation}{RelativeIndentation}    ")}
{indentation}{RelativeIndentation}}}{(_withSemicolon ? ";" : "")}";
    }
}