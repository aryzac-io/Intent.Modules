// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Angular.Templates.Module.AngularModuleTemplate
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.TypeScript.Templates;
    using Intent.Modules.Angular.Api;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Angular\Templates\Module\AngularModuleTemplate\AngularModuleTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class AngularModuleTemplate : TypeScriptTemplateBase<ModuleModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("import { NgModule } from \'@angular/core\';\r\nimport { CommonModule } from \'@angular" +
                    "/common\';\r\n\r\n@NgModule({\r\n  declarations: [],\r\n  imports: [\r\n    CommonModule,\r\n" +
                    "    ");
            
            #line 16 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Angular\Templates\Module\AngularModuleTemplate\AngularModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(RoutingModuleClassName));
            
            #line default
            #line hidden
            this.Write("\r\n  ]\r\n})\r\nexport class ");
            
            #line 19 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Angular\Templates\Module\AngularModuleTemplate\AngularModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" { }\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
