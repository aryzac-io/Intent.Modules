// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.Templates.Registration.SingleFileListModel
{
    using Intent.Modules.Common.Templates;
    using Intent.Metadata.Models;
    using Intent.Modules.ModuleBuilder.Api;
    using Intent.Modules.ModuleBuilder.Helpers;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileListModel\SingleFileListModelTemplateRegistrationTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class SingleFileListModelTemplateRegistrationTemplate : IntentRoslynProjectItemTemplateBase<TemplateRegistrationModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"
using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.Modules.Common.Registrations;
using Intent.RoslynWeaver.Attributes;
using Intent.Engine;
using Intent.Templates;
");
            
            #line 17 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileListModel\SingleFileListModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Format("using {0};", Model.GetModule().ApiNamespace)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 18 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileListModel\SingleFileListModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n[assembly: DefaultIntentManaged(Mode.Merge)]\r\n\r\nnamespace ");
            
            #line 21 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileListModel\SingleFileListModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [IntentManaged(Mode.Merge, Body = Mode.Merge, Signature = Mode.Fully)]\r\n" +
                    "    public class ");
            
            #line 24 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileListModel\SingleFileListModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : ListModelTemplateRegistrationBase<");
            
            #line 24 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileListModel\SingleFileListModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetModelType()));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n        private readonly IMetadataManager _metadataManager;\r\n\r\n        " +
                    "public ");
            
            #line 28 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileListModel\SingleFileListModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(IMetadataManager metadataManager)\r\n        {\r\n            _metadataManager = met" +
                    "adataManager;\r\n        }\r\n\r\n        public override string TemplateId =>  ");
            
            #line 33 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileListModel\SingleFileListModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTemplateNameForTemplateId()));
            
            #line default
            #line hidden
            this.Write(".TemplateId;\r\n\r\n        public override ITemplate CreateTemplateInstance(IProject" +
                    " project, IList<");
            
            #line 35 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileListModel\SingleFileListModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetModelType()));
            
            #line default
            #line hidden
            this.Write("> model)\r\n        {\r\n            return new ");
            
            #line 37 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileListModel\SingleFileListModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTemplateNameForTemplateId()));
            
            #line default
            #line hidden
            this.Write("(project, model);\r\n        }\r\n\r\n        [IntentManaged(Mode.Merge, Body = Mode.Ig" +
                    "nore, Signature = Mode.Fully)]\r\n        public override IList<");
            
            #line 41 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileListModel\SingleFileListModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetModelType()));
            
            #line default
            #line hidden
            this.Write("> GetModels(IApplication application)\r\n        {\r\n            return ");
            
            #line 43 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileListModel\SingleFileListModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetModelsMethod()));
            
            #line default
            #line hidden
            this.Write(".ToList();\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
