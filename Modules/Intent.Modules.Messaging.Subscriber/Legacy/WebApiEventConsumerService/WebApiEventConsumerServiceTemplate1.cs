﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Messaging.Subscriber.Legacy.WebApiEventConsumerService
{
    using Intent.SoftwareFactory.Templates;
    using Intent.SoftwareFactory.MetaModels.Application;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class WebApiEventConsumerServiceTemplate : IntentRoslynProjectItemTemplateBase<SubscribingModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            
            #line 14 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"




            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing Syste" +
                    "m.Net;\r\nusing System.Net.Http;\r\nusing System.Transactions;\r\nusing System.Web.Htt" +
                    "p;\r\nusing Intent.Esb.Client.Consuming;\r\nusing Intent.Framework.EntityFramework;");
            
            #line 26 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DeclareUsings()));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 27 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\nnamespace ");
            
            #line 29 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [RoutePrefix(\"api/eventConsumer\")]\r\n    public class MessageConsumingSer" +
                    "viceController : ApiController\r\n    {\r\n        private readonly MessageDispatche" +
                    "r _messageDispatcher;\r\n        private readonly IDbContextFactory _dbContextFact" +
                    "ory;");
            
            #line 35 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DeclarePrivateVariables()));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n        public MessageConsumingServiceController(MessageDispatcher messageDis" +
                    "patcher\r\n            , IDbContextFactory dbContextFactory");
            
            #line 38 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConstructorParams()));
            
            #line default
            #line hidden
            this.Write("\r\n            )\r\n        {\r\n            _messageDispatcher = messageDispatcher;\r\n" +
                    "            _dbContextFactory = dbContextFactory;");
            
            #line 42 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConstructorInit()));
            
            #line default
            #line hidden
            this.Write("\r\n        }\r\n\r\n        public class MessagePayload\r\n        {\r\n            public" +
                    " string Content { get; set; }\r\n        }\r\n\r\n        [AcceptVerbs(\"POST\")]\r\n     " +
                    "   [Route(\"consumeMessage\")]\r\n");
            
            #line 52 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
	if (Model.Security.RequiresAuthentication)
	{ 
            
            #line default
            #line hidden
            this.Write("\t\t[Authorize");
            
            #line 54 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((Model.Security.RequiredRoles.Any()) ? "(Roles = \"" + Model.Security.RequiredRoles.First() + "\")" : ""));
            
            #line default
            #line hidden
            this.Write("]\r\n");
            
            #line 55 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
	} 
            
            #line default
            #line hidden
            this.Write("        public void ConsumeMessage(MessagePayload payload)\r\n        {");
            
            #line 57 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BeginOperation()));
            
            #line default
            #line hidden
            this.Write("\r\n            TransactionOptions tso = new TransactionOptions();\r\n            tso" +
                    ".IsolationLevel = IsolationLevel.");
            
            #line 59 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.TransactionOptions.IsolationLevel));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 60 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
	if (Model.TransactionOptions.TimeoutInSeconds != null)
    { 
            
            #line default
            #line hidden
            this.Write("\t\t\ttso.Timeout = TimeSpan.FromSeconds(");
            
            #line 62 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.TransactionOptions.TimeoutInSeconds));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 63 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
	} 
            
            #line default
            #line hidden
            this.Write("            try\r\n            {\r\n                using (var dbScope = new DbContex" +
                    "tScope(_dbContextFactory))\r\n                {");
            
            #line 67 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BeforeTransaction()));
            
            #line default
            #line hidden
            this.Write("\r\n                    using (TransactionScope ts = new TransactionScope(Transacti" +
                    "onScopeOption.Required, tso, TransactionScopeAsyncFlowOption.Enabled))\r\n        " +
                    "            {");
            
            #line 69 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BeforeCallToAppLayer()));
            
            #line default
            #line hidden
            this.Write("\r\n                        _messageDispatcher.Dispatch(payload.Content);\r\n        " +
                    "                dbScope.SaveChanges();");
            
            #line 71 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AfterCallToAppLayer()));
            
            #line default
            #line hidden
            this.Write("\r\n                        ts.Complete();\r\n                    }\r\n                " +
                    "}");
            
            #line 74 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AfterTransaction()));
            
            #line default
            #line hidden
            this.Write("\r\n            }\r\n            catch (Exception e) \r\n            {");
            
            #line 77 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OnExceptionCaught()));
            
            #line default
            #line hidden
            this.Write("\r\n            }\r\n        }\r\n\r\n");
            
            #line 81 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
	if (Model.Security.RequiresAuthentication)
	{ 
            
            #line default
            #line hidden
            this.Write("\t\t[Authorize");
            
            #line 83 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((Model.Security.RequiredRoles.Any()) ? "(Roles = \"" + Model.Security.RequiredRoles.First() + "\")" : ""));
            
            #line default
            #line hidden
            this.Write("]\r\n");
            
            #line 84 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Messaging.Subscriber\Legacy\WebApiEventConsumerService\WebApiEventConsumerServiceTemplate.tt"
	} 
            
            #line default
            #line hidden
            this.Write("        [AcceptVerbs(\"Get\")]\r\n        [Route(\"serviceIsRunning\")]\r\n        public" +
                    " bool ServiceIsRunning()\r\n        {\r\n            return true;\r\n        }\r\n    }\r" +
                    "\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}