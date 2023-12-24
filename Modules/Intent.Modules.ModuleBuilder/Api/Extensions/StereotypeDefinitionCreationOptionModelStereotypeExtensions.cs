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
    public static class StereotypeDefinitionCreationOptionModelStereotypeExtensions
    {
        public static OptionSettings GetOptionSettings(this StereotypeDefinitionCreationOptionModel model)
        {
            var stereotype = model.GetStereotype("f4250b35-559d-4c0b-91ee-c3d7aa239814");
            return stereotype != null ? new OptionSettings(stereotype) : null;
        }

        public static bool HasOptionSettings(this StereotypeDefinitionCreationOptionModel model)
        {
            return model.HasStereotype("f4250b35-559d-4c0b-91ee-c3d7aa239814");
        }

        public static bool TryGetOptionSettings(this StereotypeDefinitionCreationOptionModel model, out OptionSettings stereotype)
        {
            if (!HasOptionSettings(model))
            {
                stereotype = null;
                return false;
            }

            stereotype = new OptionSettings(model.GetStereotype("f4250b35-559d-4c0b-91ee-c3d7aa239814"));
            return true;
        }


        public class OptionSettings
        {
            private IStereotype _stereotype;

            public OptionSettings(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string Name => _stereotype.Name;

            public string Shortcut()
            {
                return _stereotype.GetProperty<string>("Shortcut");
            }

            public string ShortcutMacOS()
            {
                return _stereotype.GetProperty<string>("Shortcut (macOS)");
            }

            public string DefaultName()
            {
                return _stereotype.GetProperty<string>("Default Name");
            }

            public int? TypeOrder()
            {
                return _stereotype.GetProperty<int?>("Type Order");
            }

            public bool AllowMultiple()
            {
                return _stereotype.GetProperty<bool>("Allow Multiple");
            }

            public string ApiModelName()
            {
                return _stereotype.GetProperty<string>("Api Model Name");
            }

            public string IsOptionVisibleFunction()
            {
                return _stereotype.GetProperty<string>("Is Option Visible Function");
            }

        }

    }
}