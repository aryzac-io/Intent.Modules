﻿using System.Linq;
using System.Text;
using Intent.MetaModel.Domain;
using Intent.Modules.Entities.Templates.DomainEntity;
using Intent.Modules.Entities.Templates;
using Intent.SoftwareFactory.Templates;

namespace Intent.Modules.Entities.DDD.Decorators
{
    public class DDDEntityDecorator : DomainEntityDecoratorBase
    {
        public const string Identifier = "Intent.Entities.DDD.EntityDecorator";
        
        public override string Constructors(IClass @class)
        {
            var associatedClass = @class.AssociatedClasses.Where(x => x.IsNavigable).ToList();
            if (!@class.Attributes.Any() && !@class.AssociatedClasses.Any())
            {
                return base.Constructors(@class);
            }

            var sb = new StringBuilder();
            sb.AppendLine($"        [IntentInitialGen]");
            sb.Append($"        public {@class.Name}(");
            foreach (var attribute in @class.Attributes)
            {
                sb.Append($"{Template.Types.Get(attribute.Type)} {attribute.Name.ToCamelCase()}{(associatedClass.Any() || attribute != @class.Attributes.Last() ? ", " : "")}");
            }
            foreach (var associationEnd in associatedClass)
            {
                sb.Append($"{Template.NormalizeNamespace(Template.Types.Get(associationEnd))} {associationEnd.Name().ToCamelCase()}{(associationEnd != @class.AssociatedClasses.Last() ? ", " : "")}");
            }
            sb.Append(")");
            sb.AppendLine("        {");
            foreach (var attribute in @class.Attributes)
            {
                sb.AppendLine($"            {attribute.Name.ToPascalCase()} = {attribute.Name.ToCamelCase()};");
            }
            foreach (var associationEnd in associatedClass)
            {
                sb.AppendLine($"            {associationEnd.Name()} = {associationEnd.Name().ToCamelCase()};");
            }
            sb.AppendLine("        }");
            return sb.ToString();
        }
    }
}