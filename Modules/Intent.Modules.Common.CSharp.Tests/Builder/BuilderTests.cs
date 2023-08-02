﻿using System.Threading.Tasks;
using Intent.Modules.Common.CSharp.Builder;
using Xunit;
using VerifyXunit;

namespace Intent.Modules.Common.CSharp.Tests.Builder;

[UsesVerify]
public class BuilderTests
{
    [Fact]
    public async Task ClassConstructorTest()
    {
        var fileBuilder = new CSharpFile("Testing.Namespace", "Classes")
            .AddUsing("System")
            .AddClass("TestClass", @class =>
            {
                @class.AddConstructor(ctor => ctor.Static());
                @class.AddConstructor(ctor => ctor.Private());
                @class.AddConstructor(ctor =>
                {
                    ctor.Protected();
                    ctor.AddParameter("string", "field1", param => param.IntroduceField());
                });
                @class.AddConstructor(ctor =>
                {
                    ctor.AddParameter("string", "field2", param => param.IntroduceField());
                    ctor.AddParameter("string", "field3", param => param.IntroduceReadonlyField());
                    ctor.AddParameter("string", "property", param => param.IntroduceProperty(p => p.ReadOnly()));
                });
            })
            .CompleteBuild();
        await Verifier.Verify(fileBuilder.ToString());
    }
    
    [Fact]
    public async Task ConstructorCalls()
    {
        var fileBuilder = new CSharpFile("Testing.Namespace", "Classes")
            .AddUsing("System")
            .AddClass("ConcreteClass", @class =>
            {
                @class.WithBaseType("MyBaseClass");
                @class.AddConstructor(ctor => ctor
                    .CallsBase());
                @class.AddConstructor(ctor => ctor
                    .AddParameter("bool", "enabled")
                    .CallsThis());
                @class.AddConstructor(ctor => ctor
                    .AddParameter("string", "value")
                    .CallsThis(t => t.AddArgument("value").AddArgument("1")));
                @class.AddConstructor(ctor => ctor
                    .AddParameter("string", "value")
                    .AddParameter("int", "otherValue")
                    .CallsBase(b => b.AddArgument("value").AddArgument("otherValue")));
            })
            .CompleteBuild();
        await Verifier.Verify(fileBuilder.ToString());
    }

    [Fact]
    public async Task ClassTest()
    {
        var fileBuilder = new CSharpFile("Testing.Namespace", "Classes")
            .AddUsing("System")
            .AddClass("BaseClass", @class =>
            {
                @class.Abstract();
            })
            .AddClass("ConcreteClass", @class =>
            {
                @class.ImplementsInterface("ISomeService");
                @class.WithBaseType("BaseClass");
                @class.AddMethod("void", "Method", method =>
                {
                    method.IsExplicitImplementationFor("ISomeService");
                });
            })
            .AddClass("StaticClass", @class =>
            {
                @class.Static();
                
                @class.AddMethod("void", "StaticMethod", method => method.Static());
                @class.AddProperty("int", "StaticProperty", prop => prop.Static());
                @class.AddField("string", "_staticField", field => field.Static().WithAssignment(@"""123"""));
            })
            .CompleteBuild();
        await Verifier.Verify(fileBuilder.ToString());
    }

    [Fact]
    public async Task InterfaceTest()
    {
        var fileBuilder = new CSharpFile("Namespace", "Interfaces")
            .AddUsing("System")
            .AddInterface("IInterface", @interface => @interface
                .WithComments("// Comment")
                .AddMethod("void", "Method")
                .AddMethod("void", "Static", method =>
                {
                    method.Static();
                })
                .AddProperty("object", "GetterExpression", property =>
                {
                    property.WithoutSetter()
                        .Getter.WithExpressionImplementation("new object()");
                })
            )
            .CompleteBuild();

        await Verifier.Verify(fileBuilder.ToString());
    }

    [Fact]
    public async Task GenericsTest()
    {
        var fileBuilder = new CSharpFile("Namespace", "Class")
            .AddUsing("System")
            .AddClass("Class", @class =>
            {
                @class.AddGenericParameter("T", out var t);
                @class.AddMethod("void", "GenericMethod", method => method
                    .AddGenericParameter(t)
                    .AddGenericParameter("U", out var u)
                    .AddGenericTypeConstraint(u, c => c.AddType("class")));
            })
            .AddInterface("Interface", @interface =>
            {
                @interface.AddGenericParameter("T", out var t);
                @interface.AddMethod("void", "GenericMethod", method => method
                    .AddGenericParameter(t)
                    .AddGenericParameter("U", out var u)
                    .AddGenericTypeConstraint(u, c => c.AddType("class")));
            })
            .AddClass("DerivedClass", @class =>
            {
                @class.WithBaseType("BaseType", new[] { "GenericTypeParameter1", "GenericTypeParameter2" });
                @class.AddConstructor();
            })
            .CompleteBuild();

        await Verifier.Verify(fileBuilder.ToString());
    }

    [Fact]
    public async Task StatementBlocks()
    {
        var fileBuilder = new CSharpFile("Testing.Namespace", "Classes")
            .AddClass("TestClass", @class =>
            {
                @class.AddMethod("void", "TestMethod", method =>
                {
                    method.AddParameter("int", "value");

                    // GPT: These "IfStatement" lines is how you implement "if" statements.
                    method.AddIfStatement("value == 0", c => c
                        .AddStatement("throw new InvalidArgumentException();"));
                    method.AddElseIfStatement("value == 1", c => c
                        .AddStatement("return 1;"));
                    method.AddElseStatement(c => c
                        .AddStatement("return 2;"));

                    // GPT: This statement is how you would instantiate an object "SomeObject" using
                    // property initializers.
                    method.AddStatement("// Object Init", s => s.SeparatedFromPrevious())
                        .AddObjectInitializerBlock("var obj = new SomeObject", c => c
                            .AddInitStatement("LambdaProp", new CSharpLambdaBlock("x")
                                .AddStatement("return x + 1;"))
                            .AddInitStatement("StringProp", "\"My string\"")
                            .WithSemicolon());

                    // GPT: This statement is how you would instantiate an object "Dictionary<string, string>" using
                    // its key-value pair initialization.
                    method.AddObjectInitializerBlock("var dict = new Dictionary<string, string>", c => c
                        .AddKeyAndValue(@"""key1""", @"""value 1""")
                        .AddKeyAndValue(@"""key2""", @"""value 2""")
                        .WithSemicolon());

                    // GPT: This statement is how you make a "using" scope.
                    method.AddUsingBlock("var scope = service.GetScope()", block => block
                        .AddStatement("scope.Dispose();"));

                    // GPT: Normally you do not have to use this but please take note that it is possible.
                    method.AddStatement("// New Scope")
                        .AddStatement(new CSharpStatementBlock());

                    // GPT: This statement is how you would use a "foreach" statement.
                    method.AddForEachStatement("i", "Enumerable.Range(1, 10)", c => c
                        .AddStatement("Console.Write(i);").SeparatedFromPrevious());

                    // GPT: The next few statements are for try/catch statements.
                    method.AddTryBlock(block => block.AddStatement("DoSomethingRisky();"));
                    method.AddCatchBlock("OutOfMemoryException", "ex", block => block.AddStatement("// What to do?"));
                    method.AddCatchBlock(block => block.AddStatement("// Catch All"));
                    method.AddFinallyBlock(block => block.AddStatement("DoFinallyStuff();"));

                    // GPT: This is a more advanced example where you want to span an "if" condition expression
                    // across multiple lines in a neat way.
                    method.AddIfStatement(@"
    !string.IsNullOrWhiteSpace(configuration[""KeyVault:TenantId""]) &&
	!string.IsNullOrWhiteSpace(configuration[""KeyVault:ClientId""]) &&
	!string.IsNullOrWhiteSpace(configuration[""KeyVault:Secret""])", block => block.AddStatement("// If statement body"));

                    // GPT: This statement allows you to write out comments across multiple lines.
                    method.AddStatement(new CSharpStatementBlock(@"// block expression line 1
// block expression line 2
// block expression line 3"));
                });
            })
            .CompleteBuild();
        await Verifier.Verify(fileBuilder.ToString());
    }

    [Fact]
    public async Task Inheritance()
    {
        var fileBuilder = new CSharpFile("Testing.Namespace", "Classes")
            .AddUsing("System")
            .AddClass("BaseClass", @class =>
            {
                @class.Abstract();
                @class.AddMethod("void", "ImAbstractOverrideMe", method => method.Abstract());
                @class.AddMethod("void", "ImVirtualOverrideIsOptional", method => method.Virtual().AddStatement("throw new NotImplementedException();"));
            })
            .AddClass("ConcreteClass", @class =>
            {
                @class.WithBaseType("BaseClass");
                @class.AddMethod("void", "ImAbstractOverrideMe", method => method.Override().AddStatement("// Stuff"));
                @class.AddMethod("void", "ImVirtualOverrideIsOptional", method => method.Override().AddStatement("// More Stuff"));
            })
            .AddInterface("ISomeInterface", @interface =>
            {
                @interface.ImplementsInterfaces("ISomeOtherInterface");
            })
            .CompleteBuild();
        await Verifier.Verify(fileBuilder.ToString());
    }

    [Fact]
    public async Task MethodChainingTest()
    {
        // GPT: This is used for Fluent Interfaces.
        var fileBuilder = new CSharpFile("Testing.Namespace", "Classes")
            .AddUsing("System")
            .AddClass("TestClass", @class =>
            {
                @class.AddMethod("void", "MethodChainTest", method =>
                {
                    method.AddMethodChainStatement("services.AddOpenTelemetry()", main => main
                        .AddChainStatement(new CSharpInvocationStatement("ConfigureResource")
                            .AddArgument(new CSharpLambdaBlock("res")
                                .WithExpressionBody(new CSharpMethodChainStatement("res")
                                    .WithoutSemicolon()
                                    .AddChainStatement($@"AddService(""TestService"")")
                                    .AddChainStatement("AddTelemetrySdk()")
                                    .AddChainStatement("AddEnvironmentVariableDetector()")))
                            .WithoutSemicolon())
                        .AddChainStatement(new CSharpInvocationStatement("WithTracing")
                            .AddArgument(new CSharpLambdaBlock("trace")
                                .WithExpressionBody(new CSharpMethodChainStatement("trace")
                                    .WithoutSemicolon()
                                    .AddChainStatement("AddAspNetCoreInstrumentation()")))
                            .WithoutSemicolon())
                        .AddMetadata("telemetry-config", true));
                });
            })
            .CompleteBuild();
        await Verifier.Verify(fileBuilder.ToString());
    }

    [Fact]
    public async Task PrivateBackingPropertyWithBodyExpressionTest()
    {
        // GPT: Only use this way of declaring fields and properties when you want to make use
        // if there is a body lambda expression in the property with a backing field.
        var fileBuilder = new CSharpFile("Namespace", "Class")
            .AddUsing("System")
            .AddClass("Class", @class =>
            {
                @class.AddField("List<object>", "_backingField");

                @class.AddProperty("IReadOnlyCollection<object>", "Property", property =>
                {
                    property.Getter
                        .WithExpressionImplementation("_backingField.AsReadOnlyCollection()")
                        ;

                    property.Setter
                        .WithExpressionImplementation("_backingField = new List<object>(value)")
                        .Private()
                        ;
                });
            })
            .CompleteBuild();

        await Verifier.Verify(fileBuilder.ToString());
    }

    [Fact]
    public async Task ClassMethodExpressionBodyTest()
    {
        var fileBuilder = new CSharpFile("Namespace", "Class")
            .AddUsing("System")
            .AddClass("Class", @class =>
            {
                @class.AddMethod("string", "GetDateNow", method =>
                {
                    method.WithExpressionBody("DateTimeOffset.Now");
                });
                @class.AddMethod("IHostBuilder", "CreateHostBuilder", method =>
                {
                    method.AddParameter("string[]", "args");
                    method.WithExpressionBody(new CSharpMethodChainStatement("Host.CreateDefaultBuilder(args)")
                        .AddChainStatement(new CSharpInvocationStatement("UseSerilog")
                            .WithoutSemicolon()
                            .AddArgument(new CSharpLambdaBlock("(context, services, configuration)")
                                .WithExpressionBody(new CSharpMethodChainStatement("configuration")
                                    .AddChainStatement("ReadFrom.Configuration(context.Configuration)")
                                    .AddChainStatement("ReadFrom.Services(services)")
                                    .AddChainStatement("Enrich.FromLogContext()")
                                    .AddChainStatement("WriteTo.Console()"))))
                        .AddChainStatement(
                            new CSharpInvocationStatement("ConfigureWebHostDefaults")
                                .WithoutSemicolon()
                                .AddArgument(new CSharpLambdaBlock("webBuilder")
                                    .AddStatement("webBuilder.UseStartup<Startup>();"))));
                });
            })
            .CompleteBuild();

        await Verifier.Verify(fileBuilder.ToString());
    }

    [Fact]
    public async Task InvocationStatementTest()
    {
        var fileBuilder = new CSharpFile("Namespace", "Class")
            .AddUsing("System")
            .AddClass("Class", @class =>
            {
                @class.AddMethod("void", "MethodInvocationTypes", method =>
                {
                    method.AddInvocationStatement("TestMethodNoArgs");
                    method.AddInvocationStatement("TestMethodOneArg", m => m.AddArgument("one"));
                    method.AddInvocationStatement("TestMethodTwoArgs", m => m.AddArgument("one").AddArgument("two"));
                    method.AddInvocationStatement("TestMethodMultilineWithOneArg", m => m
                        .WithArgumentsOnNewLines()
                        .AddArgument("one"));
                    method.AddInvocationStatement("TestMethodMultilineArgs", m => m
                        .WithArgumentsOnNewLines()
                        .AddArgument("one")
                        .AddArgument("two")
                        .AddArgument("three"));
                    method.AddInvocationStatement("TestMethodWithMethodChainingArg", stmt => stmt
                        .AddArgument(new CSharpMethodChainStatement("fluentBuilder")
                            .AddChainStatement("FluentOpOne()")
                            .AddChainStatement("FluentOpTwo()")
                            .WithoutSemicolon()));
                    method.AddStatement(new CSharpMethodChainStatement(@"services.ConfigureComponent()")
                        .AddChainStatement(new CSharpInvocationStatement("ConfigureFeatures")
                            .WithoutSemicolon()
                            .AddArgument(@"""FeatureSet1""")
                            .AddArgument(new CSharpLambdaBlock("conf")
                                .WithExpressionBody(new CSharpMethodChainStatement("conf")
                                    .WithoutSemicolon()
                                    .AddChainStatement("SwitchFeatureOne(true)")
                                    .AddChainStatement("SwitchFeatureTwo(false)")))));
                });
            })
            .CompleteBuild();

        await Verifier.Verify(fileBuilder.ToString());
    }

    [Fact]
    public async Task MethodParametersTest()
    {
        var fileBuilder = new CSharpFile("Namespace", "Class")
            .AddUsing("System")
            .AddClass("Class", @class =>
            {
                @class.AddMethod("void", "NoParamMethod");
                @class.AddMethod("void", "SingleParamMethod", method => method
                    .AddParameter("string", "parm1")
                    .AddStatement("// Expect parameters on same line"));
                @class.AddMethod("void", "DoubleParamsMethod", method => method
                    .AddParameter("string", "parm1")
                    .AddParameter("string", "parm2")
                    .AddStatement("// Expect parameters on same line"));
                @class.AddMethod("void", "TripleParamsMethod", method => method
                    .AddParameter("string", "parm1")
                    .AddParameter("string", "parm2")
                    .AddParameter("string", "parm3")
                    .AddStatement("// Expect parameters on same line"));
                @class.AddMethod("void", "LongAndManyParamsMethod", method => method
                    .AddParameter("string", "firstParameter")
                    .AddParameter("string", "secondParameter")
                    .AddParameter("string", "thirdParameter")
                    .AddParameter("string", "fourthParameter")
                    .AddStatement("// Expect parameters to span over multiple lines"));
            })
            .CompleteBuild();

        await Verifier.Verify(fileBuilder.ToString());
    }

    [Fact]
    public async Task SwitchStatementTest()
    {
        var fileBuilder = new CSharpFile("Namespace", "Class")
            .AddUsing("System")
            .AddClass("Class", @class =>
            {
                @class.AddMethod("void", "SwitchBreakStatements",
                    method =>
                    {
                        method.AddParameter("Exception", "exception");
                        method.AddSwitchStatement("exception", stmt => stmt
                            .AddCase("ArgumentNullException")
                            .AddCase("NullReferenceException", block => block
                                .AddStatement(@"Console.WriteLine(""Null detected"");")
                                .WithBreak())
                            .AddCase("OutOfMemoryException", block => block
                                .AddStatement(@"Console.WriteLine(""No memory"");")
                                .WithBreak())
                            .AddDefault(block => block
                                .AddStatement(@"Console.WriteLine(exception.GetType().Name);")
                                .WithBreak()));
                    });
                @class.AddMethod("void", "SwitchContinueStatements",
                    method =>
                    {
                        method.AddParameter("IEnumerable<string>", "collection");
                        method.AddForEachStatement("item", "collection", stmt => stmt
                            .AddSwitchStatement("item", swtch => swtch
                                .AddCase(@"""Item1""", cs => cs.AddStatement(@"Console.WriteLine(""Item1"");")
                                    .WithContinue())
                                .AddCase(@"""Item2""", cs => cs.AddStatement(@"Console.WriteLine(""Item2"");")
                                    .WithContinue())));
                        method.AddStatement(@"Console.WriteLine(""Item X"");");
                    });
                @class.AddMethod("string", "SwitchReturnStatements",
                    method =>
                    {
                        method.AddParameter("IEnumerable<string>", "collection");
                        method.AddForEachStatement("item", "collection", stmt => stmt
                            .AddSwitchStatement("item", swtch => swtch
                                .AddCase(@"""Item1""", cs => cs
                                    .WithReturn(@"""Item1"""))
                                .AddCase(@"""Item2""", cs => cs
                                    .WithReturn(@"""Item2"""))));
                        method.AddStatement(@"return ""Item X"";");
                    });
            })
            .CompleteBuild();

        await Verifier.Verify(fileBuilder.ToString());
    }
    
    [Fact]
    public async Task StaticConfigureStyleFileBuilderTest()
    {
        var fileBuilder = new CSharpFile("Testing.Namespace", "Classes")
            .AddUsing("System")
            .AddUsing("Azure")
            .AddUsing("Azure.Messaging.EventGrid")
            .AddUsing("Azure.Messaging.ServiceBus")
            .AddUsing("Microsoft.EntityFrameworkCore")
            .AddUsing("Microsoft.Extensions.Configuration")
            .AddUsing("Microsoft.Extensions.DependencyInjection")
            .AddClass("DependencyInjection", @class =>
            {
                @class.Static()
                    .AddMethod("IServiceCollection", "AddInfrastructure", method => method
                        .Static()
                        .AddParameter("IServiceCollection", "services", param => param.WithThisModifier())
                        .AddParameter("IConfiguration", "configuration")
                        .AddStatement(new CSharpInvocationStatement("services.AddDbContext<ApplicationDbContext>")
                            .AddArgument(new CSharpLambdaBlock("(sp, options)")
                                .AddStatement(@"options.UseInMemoryDatabase(""DefaultConnection"");")
                                .AddStatement(@"options.UseLazyLoadingProxies();"))
                            .WithArgumentsOnNewLines())
                        .AddStatement(new CSharpInvocationStatement(@"services.AddScoped<IUnitOfWork>")
                            .AddArgument(new CSharpLambdaBlock("provider")
                                .WithExpressionBody(@"provider.GetService<ApplicationDbContext>()"))));

            })
            .CompleteBuild();
        await Verifier.Verify(fileBuilder.ToString());
    }
}