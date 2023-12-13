using System;
using System.Collections.Generic;
using System.Linq;
using Intent.IArchitect.Agent.Persistence.Model.Common;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementModel", Version = "1.0")]

namespace Intent.ModuleBuilder.Api
{
    [IntentManaged(Mode.Fully, Signature = Mode.Fully)]
    public class MappableElementSettingsModel : IMetadataModel, IHasStereotypes, IHasName, IHasTypeReference
    {
        public const string SpecializationType = "Mappable Element Settings";
        public const string SpecializationTypeId = "62e5b1a9-0d36-4969-9d22-ce748155afbf";
        protected readonly IElement _element;

        [IntentManaged(Mode.Fully)]
        public MappableElementSettingsModel(IElement element, string requiredType = SpecializationType)
        {
            if (!requiredType.Equals(element.SpecializationType, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new Exception($"Cannot create a '{GetType().Name}' from element with specialization type '{element.SpecializationType}'. Must be of type '{SpecializationType}'");
            }
            _element = element;
        }

        public string Id => _element.Id;

        public string Name => _element.Name;

        public string Comment => _element.Comment;

        public IEnumerable<IStereotype> Stereotypes => _element.Stereotypes;

        public ITypeReference TypeReference => _element.TypeReference;

        public ITypeReference TargetType => TypeReference?.Element != null ? TypeReference : null;

        public IElement InternalElement => _element;

        public IList<MappableElementSettingsModel> ElementMappings => _element.ChildElements
            .GetElementsOfType(MappableElementSettingsModel.SpecializationTypeId)
            .Select(x => new MappableElementSettingsModel(x))
            .ToList();

        public override string ToString()
        {
            return _element.ToString();
        }

        public bool Equals(MappableElementSettingsModel other)
        {
            return Equals(_element, other?._element);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((MappableElementSettingsModel)obj);
        }

        public override int GetHashCode()
        {
            return (_element != null ? _element.GetHashCode() : 0);
        }

        [IntentManaged(Mode.Ignore)]
        public MappableElementSettingPersistable ToPersistable()
        {
            return new MappableElementSettingPersistable()
            {
                Id = Id,
                Name = Name,
                SpecializationType = TargetType.Element.Name,
                SpecializationTypeId = TargetType.Element.Id,
                Represents = Enum.TryParse<ElementMappingRepresentation>(this.GetMappingSettings().Represents().Value, out var represents) ? represents : ElementMappingRepresentation.Unknown,
                FilterFunction = this.GetMappingSettings().FilterFunction(),
                IsMappableFunction = this.GetMappingSettings().IsMappableFunction(),
                AllowMultipleMappings = this.GetMappingSettings().AllowMultipleMappings(),
                IsRequiredFunction = this.GetMappingSettings().IsRequiredFunction(),
                IsTraversable = !this.GetMappingSettings().TraversableMode().IsNotTraversable(),
                TraversableTypes = this.GetMappingSettings().TraversableTypes().Select(x => x.Id).ToList(),
                GetTraversableTypeFunction = this.GetMappingSettings().GetTraversableTypeFunction(),
                UseChildSettingsFrom = this.GetMappingSettings().UseChildMappingsFrom()?.Id,
                ChildSettings = ElementMappings.Select(x => x.ToPersistable()).ToList(),
                CanBeModified = this.GetMappingSettings().CanBeModified(),
                CreateNameFunction = this.GetMappingSettings().CreateNameFunction(),
            };
        }
    }

    [IntentManaged(Mode.Fully)]
    public static class MappableElementSettingsModelExtensions
    {

        public static bool IsMappableElementSettingsModel(this ICanBeReferencedType type)
        {
            return type != null && type is IElement element && element.SpecializationTypeId == MappableElementSettingsModel.SpecializationTypeId;
        }

        public static MappableElementSettingsModel AsMappableElementSettingsModel(this ICanBeReferencedType type)
        {
            return type.IsMappableElementSettingsModel() ? new MappableElementSettingsModel((IElement)type) : null;
        }
    }
}