//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:7.0.11
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModuleBuilders.Templates.TypeScript.TypeScriptFilePerModelT4 {
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.TypeScript.Templates;
    using Intent.Templates;
    using Intent.Metadata.Models;
    using Intent.Modelers.Domain.Api;
    using System;
    
    
    public partial class TypeScriptFilePerModelT4Template : TypeScriptTemplateBase<Intent.Modelers.Domain.Api.ClassModel> {
        
        public override string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 11 ""
            this.Write("\r\nexport class ");
            
            #line default
            #line hidden
            
            #line 12 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( ClassName ));
            
            #line default
            #line hidden
            
            #line 12 ""
            this.Write(" {\r\n\r\n}");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public override void Initialize() {
            base.Initialize();
        }
    }
}