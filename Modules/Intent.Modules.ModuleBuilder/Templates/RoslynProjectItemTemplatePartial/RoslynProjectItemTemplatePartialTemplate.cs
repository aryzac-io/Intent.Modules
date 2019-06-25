// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.Templates.RoslynProjectItemTemplatePartial
{
    using Intent.Modules.Common.Templates;
    using Intent.Metadata.Models;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\RoslynProjectItemTemplatePartial\RoslynProjectItemTemplatePartialTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class RoslynProjectItemTemplatePartialTemplate : IntentRoslynProjectItemTemplateBase<IElement>
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
            
            #line 14 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\RoslynProjectItemTemplatePartial\RoslynProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n[assembly: DefaultIntentManaged(Mode.Merge)]\r\n\r\nnamespace ");
            
            #line 17 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\RoslynProjectItemTemplatePartial\RoslynProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\t[IntentManaged(Mode.Merge)]\r\n    partial class ");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\RoslynProjectItemTemplatePartial\RoslynProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : IntentRoslynProjectItemTemplateBase<");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\RoslynProjectItemTemplatePartial\RoslynProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetModelType()));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n        public const string TemplateId = \"");
            
            #line 22 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\RoslynProjectItemTemplatePartial\RoslynProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTemplateId()));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n        public ");
            
            #line 24 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\RoslynProjectItemTemplatePartial\RoslynProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(IProject project, ");
            
            #line 24 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\RoslynProjectItemTemplatePartial\RoslynProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetModelType()));
            
            #line default
            #line hidden
            this.Write(@" model) : base(TemplateId, project, model)
        {
        }

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetadata(Id, ""1.0""));
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        protected override RoslynDefaultFileMetadata DefineRoslynDefaultFileMetadata()
        {
            return new RoslynDefaultFileMetadata(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: """);
            
            #line 38 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\RoslynProjectItemTemplatePartial\RoslynProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetRegistrationType() == RegistrationType.FilePerModel ? "${Model.Name}" : Model.Name.Replace("Template", "")));
            
            #line default
            #line hidden
            this.Write("\",\r\n                fileExtension: \"cs\",\r\n                defaultLocationInProjec" +
                    "t: \"");
            
            #line 40 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\RoslynProjectItemTemplatePartial\RoslynProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetRegistrationType() == RegistrationType.FilePerModel ? Model.Name.Replace("Template", "") : ""));
            
            #line default
            #line hidden
            this.Write("\",\r\n                className: \"");
            
            #line 41 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\RoslynProjectItemTemplatePartial\RoslynProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetRegistrationType() == RegistrationType.FilePerModel ? "${Model.Name}" : Model.Name.Replace("Template", "")));
            
            #line default
            #line hidden
            this.Write("\",\r\n                @namespace: \"${Project.Name}");
            
            #line 42 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\RoslynProjectItemTemplatePartial\RoslynProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetRegistrationType() == RegistrationType.FilePerModel ? "." + Model.Name.Replace("Template", "") : ""));
            
            #line default
            #line hidden
            this.Write("\"\r\n            );\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
