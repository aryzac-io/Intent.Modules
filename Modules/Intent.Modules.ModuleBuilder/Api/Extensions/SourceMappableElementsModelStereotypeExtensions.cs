using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementModelExtensions", Version = "1.0")]

namespace Intent.ModuleBuilder.Api
{
    public static class SourceMappableElementsModelStereotypeExtensions
    {
        public static MappingEndSettings GetMappingEndSettings(this SourceMappableElementsModel model)
        {
            var stereotype = model.GetStereotype("c5fe657f-bf6f-4027-8bec-67290cc6dde2");
            return stereotype != null ? new MappingEndSettings(stereotype) : null;
        }


        public static bool HasMappingEndSettings(this SourceMappableElementsModel model)
        {
            return model.HasStereotype("c5fe657f-bf6f-4027-8bec-67290cc6dde2");
        }

        public static bool TryGetMappingEndSettings(this SourceMappableElementsModel model, out MappingEndSettings stereotype)
        {
            if (!HasMappingEndSettings(model))
            {
                stereotype = null;
                return false;
            }

            stereotype = new MappingEndSettings(model.GetStereotype("c5fe657f-bf6f-4027-8bec-67290cc6dde2"));
            return true;
        }

        public class MappingEndSettings
        {
            private IStereotype _stereotype;

            public MappingEndSettings(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string Name => _stereotype.Name;

            public string RootElementFunction()
            {
                return _stereotype.GetProperty<string>("Root Element Function");
            }

        }

    }
}