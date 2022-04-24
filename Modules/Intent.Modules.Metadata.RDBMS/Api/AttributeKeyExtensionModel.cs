using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modelers.Domain.Api;
using Intent.Modules.Common;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementExtensionModel", Version = "1.0")]

namespace Intent.Metadata.RDBMS.Api
{
    [IntentManaged(Mode.Fully, Signature = Mode.Fully)]
    public class AttributeKeyExtensionModel : AttributeModel
    {
        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        public AttributeKeyExtensionModel(IElement element) : base(element)
        {
        }

    }
}