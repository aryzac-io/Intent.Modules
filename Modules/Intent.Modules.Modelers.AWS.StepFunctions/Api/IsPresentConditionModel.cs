using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementModel", Version = "1.0")]

namespace Intent.Modelers.AWS.StepFunctions.Api
{
    [IntentManaged(Mode.Fully, Signature = Mode.Fully)]
    public class IsPresentConditionModel : IMetadataModel, IHasStereotypes, IHasName
    {
        public const string SpecializationType = "IsPresent Condition";
        public const string SpecializationTypeId = "0a3668ff-c732-4682-a1f9-39aba8c7acb0";
        protected readonly IElement _element;

        [IntentManaged(Mode.Fully)]
        public IsPresentConditionModel(IElement element, string requiredType = SpecializationType)
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

        public IElement InternalElement => _element;

        public override string ToString()
        {
            return _element.ToString();
        }

        public bool Equals(IsPresentConditionModel other)
        {
            return Equals(_element, other?._element);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((IsPresentConditionModel)obj);
        }

        public override int GetHashCode()
        {
            return (_element != null ? _element.GetHashCode() : 0);
        }
    }

    [IntentManaged(Mode.Fully)]
    public static class IsPresentConditionModelExtensions
    {

        public static bool IsIsPresentConditionModel(this ICanBeReferencedType type)
        {
            return type != null && type is IElement element && element.SpecializationTypeId == IsPresentConditionModel.SpecializationTypeId;
        }

        public static IsPresentConditionModel AsIsPresentConditionModel(this ICanBeReferencedType type)
        {
            return type.IsIsPresentConditionModel() ? new IsPresentConditionModel((IElement)type) : null;
        }
    }
}