// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.Templates.TemplateDecoratorRegistration
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.CSharp.Templates;
    using Intent.Templates;
    using Intent.Metadata.Models;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\TemplateDecoratorRegistration\TemplateDecoratorRegistrationTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class TemplateDecoratorRegistrationTemplate : CSharpTemplateBase<Intent.ModuleBuilder.Api.TemplateDecoratorModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System.ComponentModel;\r\nusing Intent.Engine;\r\nusing Intent.Modules.Common.R" +
                    "egistrations;\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 16 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\TemplateDecoratorRegistration\TemplateDecoratorRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [Description(");
            
            #line 18 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\TemplateDecoratorRegistration\TemplateDecoratorRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDecoratorTypeName()));
            
            #line default
            #line hidden
            this.Write(".Identifier)]\r\n    public class ");
            
            #line 19 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\TemplateDecoratorRegistration\TemplateDecoratorRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : DecoratorRegistration<");
            
            #line 19 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\TemplateDecoratorRegistration\TemplateDecoratorRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTemplateTypeName()));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 19 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\TemplateDecoratorRegistration\TemplateDecoratorRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDecoratorContractTypeName()));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n        public override ");
            
            #line 21 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\TemplateDecoratorRegistration\TemplateDecoratorRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDecoratorContractTypeName()));
            
            #line default
            #line hidden
            this.Write(" CreateDecoratorInstance(");
            
            #line 21 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\TemplateDecoratorRegistration\TemplateDecoratorRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTemplateTypeName()));
            
            #line default
            #line hidden
            this.Write(" template, IApplication application)\r\n        {\r\n            return new ");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\TemplateDecoratorRegistration\TemplateDecoratorRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDecoratorTypeName()));
            
            #line default
            #line hidden
            this.Write("(template);\r\n        }\r\n\r\n        public override string DecoratorId => ");
            
            #line 26 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\TemplateDecoratorRegistration\TemplateDecoratorRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDecoratorTypeName()));
            
            #line default
            #line hidden
            this.Write(".Identifier;\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}