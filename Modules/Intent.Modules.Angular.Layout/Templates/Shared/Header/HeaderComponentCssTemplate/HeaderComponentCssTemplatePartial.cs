using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;
using Intent.Modules.Angular.Layout.Api;


[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.ProjectItemTemplate.Partial", Version = "1.0")]

namespace Intent.Modules.Angular.Layout.Templates.Shared.Header.HeaderComponentCssTemplate
{
    [IntentManaged(Mode.Merge)]
    partial class HeaderComponentCssTemplate : IntentProjectItemTemplateBase<object>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Angular.Layout.Templates.Shared.Header.HeaderComponentCssTemplate";

        public HeaderComponentCssTemplate(IProject project, object model) : base(TemplateId, project, model)
        {
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public override ITemplateFileConfig DefineDefaultFileMetadata()
        {
            return new DefaultFileMetadata(
                overwriteBehaviour: OverwriteBehaviour.Always,
                codeGenType: CodeGenType.Basic,
                fileName: "header.component",
                fileExtension: "css",
                defaultLocationInProject: "ClientApp/src/app/shared/header"
            );
        }
    }
}