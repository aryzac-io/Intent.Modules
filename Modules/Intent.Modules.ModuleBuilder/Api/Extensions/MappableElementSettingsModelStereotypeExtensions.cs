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
    public static class MappableElementSettingsModelStereotypeExtensions
    {
        public static MappingSettings GetMappingSettings(this MappableElementSettingsModel model)
        {
            var stereotype = model.GetStereotype("Mapping Settings");
            return stereotype != null ? new MappingSettings(stereotype) : null;
        }


        public static bool HasMappingSettings(this MappableElementSettingsModel model)
        {
            return model.HasStereotype("Mapping Settings");
        }

        public static bool TryGetMappingSettings(this MappableElementSettingsModel model, out MappingSettings stereotype)
        {
            if (!HasMappingSettings(model))
            {
                stereotype = null;
                return false;
            }

            stereotype = new MappingSettings(model.GetStereotype("Mapping Settings"));
            return true;
        }

        public class MappingSettings
        {
            private IStereotype _stereotype;

            public MappingSettings(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string Name => _stereotype.Name;

            public RepresentsOptions Represents()
            {
                return new RepresentsOptions(_stereotype.GetProperty<string>("Represents"));
            }

            public bool CanBeModified()
            {
                return _stereotype.GetProperty<bool>("Can Be Modified");
            }

            public string CreateNameFunction()
            {
                return _stereotype.GetProperty<string>("Create Name Function");
            }

            public string FilterFunction()
            {
                return _stereotype.GetProperty<string>("Filter Function");
            }

            public string IsRequiredFunction()
            {
                return _stereotype.GetProperty<string>("Is Required Function");
            }

            public string IsMappableFunction()
            {
                return _stereotype.GetProperty<string>("Is Mappable Function");
            }

            public bool AllowMultipleMappings()
            {
                return _stereotype.GetProperty<bool>("Allow Multiple Mappings");
            }

            public TraversableModeOptions TraversableMode()
            {
                return new TraversableModeOptions(_stereotype.GetProperty<string>("Traversable Mode"));
            }

            public IElement[] TraversableTypes()
            {
                return _stereotype.GetProperty<IElement[]>("Traversable Types") ?? new IElement[0];
            }

            public string GetTraversableTypeFunction()
            {
                return _stereotype.GetProperty<string>("Get Traversable Type Function");
            }

            public IElement UseChildMappingsFrom()
            {
                return _stereotype.GetProperty<IElement>("Use Child Mappings From");
            }

            public class RepresentsOptions
            {
                public readonly string Value;

                public RepresentsOptions(string value)
                {
                    Value = value;
                }

                public RepresentsOptionsEnum AsEnum()
                {
                    switch (Value)
                    {
                        case "Data":
                            return RepresentsOptionsEnum.Data;
                        case "Invokable":
                            return RepresentsOptionsEnum.Invokable;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                public bool IsData()
                {
                    return Value == "Data";
                }
                public bool IsInvokable()
                {
                    return Value == "Invokable";
                }
            }

            public enum RepresentsOptionsEnum
            {
                Data,
                Invokable
            }

            public class TraversableModeOptions
            {
                public readonly string Value;

                public TraversableModeOptions(string value)
                {
                    Value = value;
                }

                public TraversableModeOptionsEnum AsEnum()
                {
                    switch (Value)
                    {
                        case "Not Traversable":
                            return TraversableModeOptionsEnum.NotTraversable;
                        case "Traverse Specific Types":
                            return TraversableModeOptionsEnum.TraverseSpecificTypes;
                        case "Traverse All Types":
                            return TraversableModeOptionsEnum.TraverseAllTypes;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                public bool IsNotTraversable()
                {
                    return Value == "Not Traversable";
                }
                public bool IsTraverseSpecificTypes()
                {
                    return Value == "Traverse Specific Types";
                }
                public bool IsTraverseAllTypes()
                {
                    return Value == "Traverse All Types";
                }
            }

            public enum TraversableModeOptionsEnum
            {
                NotTraversable,
                TraverseSpecificTypes,
                TraverseAllTypes
            }

        }

    }
}