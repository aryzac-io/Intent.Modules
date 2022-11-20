using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.Modules.Common.Types.Api;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementModel", Version = "1.0")]

namespace Intent.Modelers.AWS.DynamoDB.Api
{
    [IntentManaged(Mode.Fully, Signature = Mode.Fully)]
    public class DynamoDBModel : IMetadataModel, IHasStereotypes, IHasName, IHasFolder
    {
        public const string SpecializationType = "DynamoDB";
        public const string SpecializationTypeId = "a7dae3ec-2063-434b-be58-3f86434f2340";
        protected readonly IElement _element;

        [IntentManaged(Mode.Fully)]
        public DynamoDBModel(IElement element, string requiredType = SpecializationType)
        {
            if (!requiredType.Equals(element.SpecializationType, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new Exception($"Cannot create a '{GetType().Name}' from element with specialization type '{element.SpecializationType}'. Must be of type '{SpecializationType}'");
            }
            _element = element;
            Folder = _element.ParentElement?.SpecializationTypeId == FolderModel.SpecializationTypeId ? new FolderModel(_element.ParentElement) : null;
        }

        public string Id => _element.Id;

        public string Name => _element.Name;

        public string Comment => _element.Comment;

        public IEnumerable<IStereotype> Stereotypes => _element.Stereotypes;

        public FolderModel Folder { get; }

        public IElement InternalElement => _element;

        public IList<DynamoDBTableModel> Tables => _element.ChildElements
            .GetElementsOfType(DynamoDBTableModel.SpecializationTypeId)
            .Select(x => new DynamoDBTableModel(x))
            .ToList();

        public override string ToString()
        {
            return _element.ToString();
        }

        public bool Equals(DynamoDBModel other)
        {
            return Equals(_element, other?._element);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((DynamoDBModel)obj);
        }

        public override int GetHashCode()
        {
            return (_element != null ? _element.GetHashCode() : 0);
        }
    }

    [IntentManaged(Mode.Fully)]
    public static class DynamoDBModelExtensions
    {

        public static bool IsDynamoDBModel(this ICanBeReferencedType type)
        {
            return type != null && type is IElement element && element.SpecializationTypeId == DynamoDBModel.SpecializationTypeId;
        }

        public static DynamoDBModel AsDynamoDBModel(this ICanBeReferencedType type)
        {
            return type.IsDynamoDBModel() ? new DynamoDBModel((IElement)type) : null;
        }
    }
}