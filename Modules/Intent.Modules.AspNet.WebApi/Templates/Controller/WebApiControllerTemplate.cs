﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.AspNet.WebApi.Templates.Controller
{
    using Intent.Modules.Common.Templates;
    using Intent.Modelers.Services.Api;
    using Intent.Modules.Application.Contracts;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class WebApiControllerTemplate : IntentRoslynProjectItemTemplateBase<IServiceModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            this.Write(" \r\nusing System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing Sy" +
                    "stem.Net;\r\nusing System.Threading.Tasks;\r\nusing System.Transactions;\r\nusing Syst" +
                    "em.Web;\r\nusing System.Web.Http;\r\nusing System.Web.Http.Description;\r\n");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 27 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [RoutePrefix(\"api/");
            
            #line 29 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToLower()));
            
            #line default
            #line hidden
            this.Write("\")]\r\n    public class ");
            
            #line 30 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : ApiController\r\n    {\r\n        private readonly ");
            
            #line 32 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetServiceInterfaceName()));
            
            #line default
            #line hidden
            this.Write(" _appService;");
            
            #line 32 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DeclarePrivateVariables()));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n        public ");
            
            #line 34 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" (");
            
            #line 34 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetServiceInterfaceName()));
            
            #line default
            #line hidden
            this.Write(" appService");
            
            #line 34 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConstructorParams()));
            
            #line default
            #line hidden
            this.Write("\r\n            )\r\n        {\r\n            _appService = appService ?? throw new Arg" +
                    "umentNullException(nameof(appService));");
            
            #line 37 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConstructorInit()));
            
            #line default
            #line hidden
            this.Write("\r\n        }\r\n");
            
            #line 39 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"

    foreach (var operation in Model.Operations)
    {
        if (RequiresPayloadObject(operation))
        {

            
            #line default
            #line hidden
            this.Write("\r\n        public class ");
            
            #line 46 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetPayloadObjectTypeName(operation)));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n");
            
            #line 48 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"

            foreach (var parameter in operation.Parameters.Where(IsFromBody))
            {

            
            #line default
            #line hidden
            this.Write("                public ");
            
            #line 52 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(parameter.Type)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 52 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 53 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"

            } // foreach (var parameter in operation.Parameters.Where(IsFromBody))

            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 57 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"

        } // if (RequiresPayloadObject(operation))

            
            #line default
            #line hidden
            this.Write("\r\n        [AcceptVerbs(\"");
            
            #line 61 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetHttpVerb(operation).ToString().ToUpper()));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        ");
            
            #line 62 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetSecurityAttribute(operation)));
            
            #line default
            #line hidden
            this.Write("\r\n        [Route(\"");
            
            #line 63 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetRoute(operation)));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        [ResponseType(");
            
            #line 64 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Format("typeof({0})", operation.ReturnType != null ? GetOperationReturnType(operation) : "void")));
            
            #line default
            #line hidden
            this.Write(")]\r\n        public ");
            
            #line 65 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.IsAsync() ? "async Task<IHttpActionResult>" : "IHttpActionResult"));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 65 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 65 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetOperationParameters(operation)));
            
            #line default
            #line hidden
            this.Write(")\r\n        {");
            
            #line 66 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BeginOperation(operation)));
            
            #line default
            #line hidden
            
            #line 66 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"

            if (operation.ReturnType != null)
            { 
            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 69 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetOperationReturnType(operation)));
            
            #line default
            #line hidden
            this.Write(" result = default(");
            
            #line 69 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetOperationReturnType(operation)));
            
            #line default
            #line hidden
            this.Write(");");
            
            #line 69 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"

            } /* if (operation.ReturnType != null) */ 
            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 71 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BeforeTransaction(operation)));
            
            #line default
            #line hidden
            this.Write("\r\n            ");
            
            #line 72 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BeforeCallToAppLayer(operation)));
            
            #line default
            #line hidden
            
            #line 72 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"

        if (operation.ReturnType != null)
        { 

            
            #line default
            #line hidden
            this.Write("                var appServiceResult = ");
            
            #line 75 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.IsAsync() ? "await " : ""));
            
            #line default
            #line hidden
            this.Write("_appService.");
            
            #line 75 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 75 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetOperationCallParameters(operation)));
            
            #line default
            #line hidden
            this.Write(");\r\n                result = appServiceResult;\r\n");
            
            #line 77 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
      }
        else
        { 

            
            #line default
            #line hidden
            this.Write("                ");
            
            #line 80 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.IsAsync() ? "await " : ""));
            
            #line default
            #line hidden
            this.Write("_appService.");
            
            #line 80 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 80 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetOperationCallParameters(operation)));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 81 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
      
        }

            
            #line default
            #line hidden
            
            #line 83 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AfterCallToAppLayer(operation)));
            
            #line default
            #line hidden
            
            #line 83 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AfterTransaction(operation)));
            
            #line default
            #line hidden
            
            #line 83 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"

        if (!string.IsNullOrEmpty(OverrideReturnStatement(Model, operation)))
        { 
            
            #line default
            #line hidden
            this.Write("            \r\n            ");
            
            #line 87 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OverrideReturnStatement(Model, operation)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 88 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
      }
        else if (operation.ReturnType != null)
        { 
            
            #line default
            #line hidden
            this.Write("            \r\n            return Ok(result);\r\n");
            
            #line 93 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
      } else { 
            
            #line default
            #line hidden
            this.Write("            \r\n            return StatusCode(HttpStatusCode.NoContent);\r\n");
            
            #line 96 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
      } 
            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 98 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
    } // foreach (var operation in Model.Operations)

        // Source code of base class: http://aspnetwebstack.codeplex.com/SourceControl/latest#src/System.Web.Http/ApiController.cs
        // As dispose is not virtual, looking at the source code, this looks like a better hook in point

            
            #line default
            #line hidden
            this.Write("\r\n        protected override void Dispose(bool disposing)\r\n        {\r\n           " +
                    " base.Dispose(disposing);\r\n\r\n            //dispose all resources\r\n            _a" +
                    "ppService.Dispose();");
            
            #line 109 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OnDispose()));
            
            #line default
            #line hidden
            this.Write("\r\n        }\r\n");
            
            #line 111 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AspNet.WebApi\Templates\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassMethods()));
            
            #line default
            #line hidden
            this.Write("\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
