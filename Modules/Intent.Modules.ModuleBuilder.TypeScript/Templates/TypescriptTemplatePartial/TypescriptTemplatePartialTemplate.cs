//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:7.0.11
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intent.Modules.ModuleBuilder.TypeScript.Templates.TypescriptTemplatePartial {
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.CSharp.Templates;
    using Intent.Templates;
    using Intent.Metadata.Models;
    using Intent.ModuleBuilder.TypeScript.Api;
    using System;
    
    
    public partial class TypescriptTemplatePartialTemplate : CSharpTemplateBase<Intent.ModuleBuilder.TypeScript.Api.TypescriptFileTemplateModel> {
        
        public override string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 11 ""
            this.Write(@"using System;
using System.Collections.Generic;
using Intent.Engine;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using Intent.Modules.Common.TypeScript.Templates;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;
");
            
            #line default
            #line hidden
            
            #line 19 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.GetModelType() != null ? string.Format("using {0};", Model.GetModelType().ParentModule.ApiNamespace) : "" ));
            
            #line default
            #line hidden
            
            #line 19 ""
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Merge)]\r\n\r\nnamespace ");
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write("\r\n{\r\n\t[IntentManaged(Mode.Merge, Signature = Mode.Fully)]\r\n    ");
            
            #line default
            #line hidden
            
            #line 26 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( GetAccessModifier() ));
            
            #line default
            #line hidden
            
            #line 26 ""
            this.Write("class ");
            
            #line default
            #line hidden
            
            #line 26 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( ClassName ));
            
            #line default
            #line hidden
            
            #line 26 ""
            this.Write(" : ");
            
            #line default
            #line hidden
            
            #line 26 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( string.Join(", ", GetBaseTypes()) ));
            
            #line default
            #line hidden
            
            #line 26 ""
            this.Write("\r\n    {\r\n        [IntentManaged(Mode.Fully)]\r\n        public const string Templat" +
                    "eId = \"");
            
            #line default
            #line hidden
            
            #line 29 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( GetTemplateId() ));
            
            #line default
            #line hidden
            
            #line 29 ""
            this.Write("\";\r\n\r\n        [IntentManaged(Mode.Merge, Signature = Mode.Fully)]\r\n        public" +
                    " ");
            
            #line default
            #line hidden
            
            #line 32 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( ClassName ));
            
            #line default
            #line hidden
            
            #line 32 ""
            this.Write("(IOutputTarget outputTarget, ");
            
            #line default
            #line hidden
            
            #line 32 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( GetModelType() ));
            
            #line default
            #line hidden
            
            #line 32 ""
            this.Write(" model");
            
            #line default
            #line hidden
            
            #line 32 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.GetModelType() == null ? " = null" : ""));
            
            #line default
            #line hidden
            
            #line 32 ""
            this.Write(") : base(TemplateId, outputTarget, model)\r\n        {\r\n");
            
            #line default
            #line hidden
            
            #line 34 ""
  if (Model.GetTypeScriptTemplateSettings()?.TemplatingMethod().IsTypeScriptFileBuilder() == true) { 
            
            #line default
            #line hidden
            
            #line 35 ""
            this.Write("            TypescriptFile = new TypescriptFile(this.GetFolderPath())\r\n          " +
                    "      .AddClass($\"");
            
            #line default
            #line hidden
            
            #line 36 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( GetClassName() ));
            
            #line default
            #line hidden
            
            #line 36 ""
            this.Write(@""", @class =>
                {
                    @class.AddConstructor(ctor =>
                    {
                        ctor.AddParameter(""string"", ""exampleParam"", param =>
                        {
                            param.WithPrivateReadonlyFieldAssignment();
                        });
                    });
                });
");
            
            #line default
            #line hidden
            
            #line 46 ""
  } 
            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write("        }\r\n");
            
            #line default
            #line hidden
            
            #line 48 ""
  if (Model.GetTypeScriptTemplateSettings()?.TemplatingMethod().IsTypeScriptFileBuilder() == true) { 
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write("\r\n        [IntentManaged(Mode.Fully)]\r\n        public ");
            
            #line default
            #line hidden
            
            #line 51 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( UseType("Intent.Modules.Common.TypeScript.Builder.TypescriptFile") ));
            
            #line default
            #line hidden
            
            #line 51 ""
            this.Write(" TypescriptFile { get; }\r\n\r\n        [IntentManaged(Mode.Fully)]\r\n        public o" +
                    "verride ITemplateFileConfig GetTemplateFileConfig()\r\n        {\r\n            retu" +
                    "rn TypescriptFile.GetConfig($\"");
            
            #line default
            #line hidden
            
            #line 56 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( GetClassName() ));
            
            #line default
            #line hidden
            
            #line 56 ""
            this.Write("\");\r\n        }\r\n\r\n        [IntentManaged(Mode.Fully)]\r\n        public override st" +
                    "ring TransformText()\r\n        {\r\n            return TypescriptFile.ToString();\r\n" +
                    "        }\r\n");
            
            #line default
            #line hidden
            
            #line 64 ""
  } else { 
            
            #line default
            #line hidden
            
            #line 65 ""
            this.Write("\r\n        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]\r\n        public overrid" +
                    "e ITemplateFileConfig GetTemplateFileConfig()\r\n        {\r\n            return new" +
                    " TypeScriptFileConfig(\r\n                className: $\"");
            
            #line default
            #line hidden
            
            #line 70 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.IsFilePerModelTemplateRegistration() ? "{Model.Name}" : Model.Name.Replace("Template", "") ));
            
            #line default
            #line hidden
            
            #line 70 ""
            this.Write("\",\r\n                fileName: $\"");
            
            #line default
            #line hidden
            
            #line 71 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.IsFilePerModelTemplateRegistration() ? "{Model.Name.ToKebabCase()}" : Model.Name.Replace("Template", "").ToKebabCase() ));
            
            #line default
            #line hidden
            
            #line 71 ""
            this.Write("\"\r\n            );\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 74 ""
  } 
            
            #line default
            #line hidden
            
            #line 75 ""
  if (Model.GetTypeScriptTemplateSettings()?.TemplatingMethod().IsCustom() == true) { 
            
            #line default
            #line hidden
            
            #line 76 ""
            this.Write("\r\n        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]\r\n        public overrid" +
                    "e string TransformText()\r\n        {\r\n            throw new NotImplementedExcepti" +
                    "on(\"Implement custom template here\");\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 82 ""
  } 
            
            #line default
            #line hidden
            
            #line 83 ""
            this.Write("    }\r\n}");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public override void Initialize() {
            base.Initialize();
        }
    }
}
