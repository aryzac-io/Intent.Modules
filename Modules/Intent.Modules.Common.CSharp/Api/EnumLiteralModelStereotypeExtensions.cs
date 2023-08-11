using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.Modules.Common.Types.Api;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementModelExtensions", Version = "1.0")]

namespace Intent.Modules.Common.CSharp.Api
{
    public static class EnumLiteralModelStereotypeExtensions
    {
        public static Description GetDescription(this EnumLiteralModel model)
        {
            var stereotype = model.GetStereotype("Description");
            return stereotype != null ? new Description(stereotype) : null;
        }


        public static bool HasDescription(this EnumLiteralModel model)
        {
            return model.HasStereotype("Description");
        }

        public static bool TryGetDescription(this EnumLiteralModel model, out Description stereotype)
        {
            if (!HasDescription(model))
            {
                stereotype = null;
                return false;
            }

            stereotype = new Description(model.GetStereotype("Description"));
            return true;
        }

        public class Description
        {
            private IStereotype _stereotype;

            public Description(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string Name => _stereotype.Name;

            public string Value()
            {
                return _stereotype.GetProperty<string>("Value");
            }

        }

    }
}