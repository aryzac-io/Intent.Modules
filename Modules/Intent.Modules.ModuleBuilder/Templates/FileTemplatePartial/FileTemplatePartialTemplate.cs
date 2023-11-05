// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.Templates.FileTemplatePartial
{
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.CSharp.Templates;
    using Intent.Metadata.Models;
    using Intent.ModuleBuilder.Api;
    using Intent.ModuleBuilder.Helpers;
    using System.Linq;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class FileTemplatePartialTemplate : CSharpTemplateBase<FileTemplateModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"using Intent.Metadata.Models;
using Intent.RoslynWeaver.Attributes;
using Intent.Engine;
using Intent.Templates;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
");
            
            #line 18 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetModelType() != null ? string.Format("using {0};", Model.GetModelType().ParentModule.ApiNamespace) : ""));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 22 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]\r\n    ");
            
            #line 25 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(IsFileBuilder ? "public" : "partial"));
            
            #line default
            #line hidden
            this.Write(" class ");
            
            #line 25 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 25 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetBaseType()));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        [IntentManaged(Mode.Fully)]\r\n        public const string Templat" +
                    "eId = \"");
            
            #line 28 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTemplateId()));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n");
            
            #line 30 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
  if (IsFileBuilder) { 
            
            #line default
            #line hidden
            this.Write("        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]\r\n");
            
            #line 32 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
  } else { 
            
            #line default
            #line hidden
            this.Write("        [IntentManaged(Mode.Merge, Signature = Mode.Fully)]\r\n");
            
            #line 34 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 35 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(IOutputTarget outputTarget, ");
            
            #line 35 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetModelType()));
            
            #line default
            #line hidden
            this.Write(" model");
            
            #line 35 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetModelType() == null ? " = null" : ""));
            
            #line default
            #line hidden
            this.Write(") : base(TemplateId, outputTarget, model)\r\n        {\r\n");
            
            #line 37 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
  if (Model.GetFileSettings().TemplatingMethod().IsIndentedFileBuilder()) { 
            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 38 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetFilePropertyName()));
            
            #line default
            #line hidden
            this.Write(" = new ");
            
            #line 38 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetBuilderType()));
            
            #line default
            #line hidden
            this.Write("($\"");
            
            #line 38 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDefaultName()));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 38 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetFileSettings().FileExtension()));
            
            #line default
            #line hidden
            this.Write(@""")
                .WithItems(items =>
                {
                    items.WithContent(""// Sample JSON:"");
                    items.WithContent(""{"");
                    items.WithItems(i =>
                    {
                        i.WithContent(""\""fieldName\"": \""value\"""");
                    });
                    items.WithContent(""}"");
                });
");
            
            #line 49 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
  } else if (Model.GetFileSettings().TemplatingMethod().IsDataFileBuilder()) { 
            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 50 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetFilePropertyName()));
            
            #line default
            #line hidden
            this.Write(" = new ");
            
            #line 50 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetBuilderType()));
            
            #line default
            #line hidden
            this.Write("($\"");
            
            #line 50 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDefaultName()));
            
            #line default
            #line hidden
            this.Write("\")\r\n                ");
            
            #line 51 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetWriterType()));
            
            #line default
            #line hidden
            this.Write("\r\n                .WithRootDictionary(this, dictionary =>\r\n                {\r\n   " +
                    "                 dictionary\r\n                        .WithValue(\"fieldName\", \"fi" +
                    "eldValue\")\r\n                    ;\r\n                });\r\n");
            
            #line 58 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 61 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
  if (IsFileBuilder) { 
            
            #line default
            #line hidden
            this.Write("        [IntentManaged(Mode.Fully)]\r\n        public I");
            
            #line 63 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetBuilderType()));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 63 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetFilePropertyName()));
            
            #line default
            #line hidden
            this.Write(" { get; }\r\n\r\n        [IntentManaged(Mode.Fully)]\r\n        public override ITempla" +
                    "teFileConfig GetTemplateFileConfig() => ");
            
            #line 66 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetFilePropertyName()));
            
            #line default
            #line hidden
            this.Write(".GetConfig();\r\n");
            
            #line 67 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
  } else { 
            
            #line default
            #line hidden
            this.Write("        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]\r\n        public override " +
                    "ITemplateFileConfig GetTemplateFileConfig()\r\n        {\r\n            return new T" +
                    "emplateFileConfig(\r\n                fileName: $\"");
            
            #line 72 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDefaultName()));
            
            #line default
            #line hidden
            this.Write("\",\r\n                fileExtension: \"");
            
            #line 73 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetFileSettings().FileExtension()));
            
            #line default
            #line hidden
            this.Write("\"\r\n            );\r\n        }\r\n");
            
            #line 76 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 78 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
  if (Model.GetFileSettings().OutputFileContent().IsBinary()) { 
            
            #line default
            #line hidden
            this.Write("        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]\r\n        public override " +
                    "byte[] RunBinaryTemplate()\r\n        {\r\n            throw new NotImplementedExcep" +
                    "tion(\"Implement custom template here\");\r\n        }\r\n");
            
            #line 84 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
  } else if (Model.GetFileSettings().TemplatingMethod().IsCustom()) { 
            
            #line default
            #line hidden
            this.Write("        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]\r\n        public override " +
                    "string TransformText()\r\n        {\r\n            throw new NotImplementedException" +
                    "(\"Implement custom template here\");\r\n        }\r\n");
            
            #line 90 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
  } else if (IsFileBuilder) { 
            
            #line default
            #line hidden
            this.Write("        [IntentManaged(Mode.Fully)]\r\n        public override string TransformText" +
                    "() => ");
            
            #line 92 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetFilePropertyName()));
            
            #line default
            #line hidden
            this.Write(".ToString();\r\n");
            
            #line 93 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\FileTemplatePartial\FileTemplatePartialTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
