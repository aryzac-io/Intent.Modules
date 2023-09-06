// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.Templates.Api.ApiAssociationModel
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.CSharp.Templates;
    using Intent.Templates;
    using Intent.Metadata.Models;
    using Intent.ModuleBuilder.Api;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class ApiAssociationModelTemplate : CSharpTemplateBase<Intent.ModuleBuilder.Api.AssociationSettingsModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing Int" +
                    "ent.Metadata.Models;\r\nusing Intent.Modules.Common;\r\n\r\n[assembly: DefaultIntentMa" +
                    "naged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [IntentManaged(Mode.Fully, Signature = Mode.Fully)]\r\n    public class ");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : IMetadataModel\r\n    {\r\n        public const string SpecializationType = \"");
            
            #line 25 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("\";\r\n        public const string SpecializationTypeId = \"");
            
            #line 26 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Id));
            
            #line default
            #line hidden
            this.Write("\";\r\n        protected readonly IAssociation _association;\r\n        protected ");
            
            #line 28 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationSourceEndClassName));
            
            #line default
            #line hidden
            this.Write(" _sourceEnd;\r\n        protected ");
            
            #line 29 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationTargetEndClassName));
            
            #line default
            #line hidden
            this.Write(" _targetEnd;\r\n\r\n        public ");
            
            #line 31 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@"(IAssociation association, string requiredType = SpecializationType)
        {
            if (!requiredType.Equals(association.SpecializationType, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new Exception($""Cannot create a '{GetType().Name}' from association with specialization type '{association.SpecializationType}'. Must be of type '{SpecializationType}'"");
            }
            _association = association;
        }

        public static ");
            
            #line 40 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" CreateFromEnd(IAssociationEnd associationEnd)\r\n        {\r\n            var associ" +
                    "ation = new ");
            
            #line 42 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(associationEnd.Association);\r\n            return association;\r\n        }\r\n\r\n    " +
                    "    public string Id => _association.Id;\r\n        \r\n        public ");
            
            #line 48 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationSourceEndClassName));
            
            #line default
            #line hidden
            this.Write(" SourceEnd => _sourceEnd ?? (_sourceEnd = new ");
            
            #line 48 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationSourceEndClassName));
            
            #line default
            #line hidden
            this.Write("(_association.SourceEnd, this));\r\n\r\n        public ");
            
            #line 50 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationTargetEndClassName));
            
            #line default
            #line hidden
            this.Write(" TargetEnd => _targetEnd ?? (_targetEnd = new ");
            
            #line 50 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationTargetEndClassName));
            
            #line default
            #line hidden
            this.Write("(_association.TargetEnd, this));\r\n\r\n        public IAssociation InternalAssociati" +
                    "on => _association;\r\n        \r\n        public override string ToString()\r\n      " +
                    "  {\r\n            return _association.ToString();\r\n        }\r\n\r\n        public bo" +
                    "ol Equals(");
            
            #line 59 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@" other)
        {
            return Equals(_association, other?._association);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((");
            
            #line 69 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(")obj);\r\n        }\r\n\r\n        public override int GetHashCode()\r\n        {\r\n      " +
                    "      return (_association != null ? _association.GetHashCode() : 0);\r\n        }" +
                    "\r\n    }\r\n\r\n    [IntentManaged(Mode.Fully)]\r\n    public class ");
            
            #line 79 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationSourceEndClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 79 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        public const string SpecializationTypeId = \"");
            
            #line 81 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.SourceEnd.Id));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n        public ");
            
            #line 83 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationSourceEndClassName));
            
            #line default
            #line hidden
            this.Write("(IAssociationEnd associationEnd, ");
            
            #line 83 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" association) : base(associationEnd, association)\r\n        {\r\n        }\r\n");
            
            #line 86 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
 if (Model.TargetEnd.MenuOptions?.MappingOptions.Any() != true && Model.SourceEnd.MenuOptions?.MappingOptions.Any() == true) { 
            
            #line default
            #line hidden
            this.Write("        \r\n        public IEnumerable<IElementToElementMapping> Mappings => _assoc" +
                    "iationEnd.Mappings;\r\n");
            
            #line 89 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("    }\r\n\r\n    [IntentManaged(Mode.Fully)]\r\n    public class ");
            
            #line 93 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationTargetEndClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 93 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        public const string SpecializationTypeId = \"");
            
            #line 95 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.TargetEnd.Id));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n        public ");
            
            #line 97 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationTargetEndClassName));
            
            #line default
            #line hidden
            this.Write("(IAssociationEnd associationEnd, ");
            
            #line 97 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" association) : base(associationEnd, association)\r\n        {\r\n        }\r\n");
            
            #line 100 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
 if (Model.TargetEnd.MenuOptions?.MappingOptions.Any() == true && Model.SourceEnd.MenuOptions?.MappingOptions.Any() != true) { 
            
            #line default
            #line hidden
            this.Write("        \r\n        public IEnumerable<IElementToElementMapping> Mappings => _assoc" +
                    "iationEnd.Mappings;\r\n");
            
            #line 103 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("    }\r\n\r\n    [IntentManaged(Mode.Fully)]\r\n    public class ");
            
            #line 107 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write(" : ITypeReference, IMetadataModel, IHasName, IHasStereotypes, IElementWrapper\r\n  " +
                    "  {\r\n        protected readonly IAssociationEnd _associationEnd;\r\n        privat" +
                    "e readonly ");
            
            #line 110 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" _association;\r\n\r\n        public ");
            
            #line 112 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write("(IAssociationEnd associationEnd, ");
            
            #line 112 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" association)\r\n        {\r\n            _associationEnd = associationEnd;\r\n        " +
                    "    _association = association;\r\n        }\r\n\r\n        public static ");
            
            #line 118 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write(" Create(IAssociationEnd associationEnd)\r\n        {\r\n            var association =" +
                    " new ");
            
            #line 120 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(associationEnd.Association);\r\n            return association.TargetEnd.Id == ass" +
                    "ociationEnd.Id ? (");
            
            #line 121 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write(@") association.TargetEnd : association.SourceEnd;
        }

        public string Id => _associationEnd.Id;
        public string SpecializationType => _associationEnd.SpecializationType;
        public string SpecializationTypeId => _associationEnd.SpecializationTypeId;
        public string Name => _associationEnd.Name;
        public ");
            
            #line 128 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@" Association => _association;
        public IElement InternalElement => _associationEnd;
        public IAssociationEnd InternalAssociationEnd => _associationEnd;
        public IAssociation InternalAssociation => _association.InternalAssociation;
        public bool IsNavigable => _associationEnd.IsNavigable;
        public bool IsNullable => _associationEnd.TypeReference.IsNullable;
        public bool IsCollection => _associationEnd.TypeReference.IsCollection;
        public ICanBeReferencedType Element => _associationEnd.TypeReference.Element;
        public IEnumerable<ITypeReference> GenericTypeParameters => _associationEnd.TypeReference.GenericTypeParameters;
        public ITypeReference TypeReference => this;
        public IPackage Package => Element?.Package;
        public string Comment => _associationEnd.Comment;
        public IEnumerable<IStereotype> Stereotypes => _associationEnd.Stereotypes;
");
            
            #line 141 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
 if (Model.TargetEnd.MenuOptions?.MappingOptions.Any() == true && Model.SourceEnd.MenuOptions?.MappingOptions.Any() == true) { 
            
            #line default
            #line hidden
            this.Write("        public IEnumerable<IElementToElementMapping> Mappings => _associationEnd." +
                    "Mappings;\r\n");
            
            #line 143 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n        public ");
            
            #line 145 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write(" OtherEnd()\r\n        {\r\n            return this.Equals(_association.SourceEnd) ? " +
                    "(");
            
            #line 147 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write(")_association.TargetEnd : (");
            
            #line 147 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write(@")_association.SourceEnd;
        }

        public bool IsTargetEnd()
        {
            return _associationEnd.IsTargetEnd();
        }

        public bool IsSourceEnd()
        {
            return _associationEnd.IsSourceEnd();
        }
        
        public override string ToString()
        {
            return _associationEnd.ToString();
        }

        public bool Equals(");
            
            #line 165 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write(@" other)
        {
            return Equals(_associationEnd, other._associationEnd);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((");
            
            #line 175 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write(")obj);\r\n        }\r\n\r\n        public override int GetHashCode()\r\n        {\r\n      " +
                    "      return (_associationEnd != null ? _associationEnd.GetHashCode() : 0);\r\n   " +
                    "     }\r\n    }\r\n\r\n    [IntentManaged(Mode.Fully)]\r\n    public static class ");
            
            #line 185 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write("Extensions\r\n    {\r\n        public static bool Is");
            
            #line 187 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write("(this ICanBeReferencedType type)\r\n        {\r\n            return Is");
            
            #line 189 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationTargetEndClassName));
            
            #line default
            #line hidden
            this.Write("(type) || Is");
            
            #line 189 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationSourceEndClassName));
            
            #line default
            #line hidden
            this.Write("(type);\r\n        }\r\n\r\n        public static ");
            
            #line 192 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write(" As");
            
            #line 192 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write("(this ICanBeReferencedType type)\r\n        {\r\n            return (");
            
            #line 194 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write(") type.As");
            
            #line 194 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationTargetEndClassName));
            
            #line default
            #line hidden
            this.Write("() ?? (");
            
            #line 194 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationEndClassName));
            
            #line default
            #line hidden
            this.Write(")type.As");
            
            #line 194 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationSourceEndClassName));
            
            #line default
            #line hidden
            this.Write("();\r\n        }\r\n\r\n        public static bool Is");
            
            #line 197 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationTargetEndClassName));
            
            #line default
            #line hidden
            this.Write("(this ICanBeReferencedType type)\r\n        {\r\n            return type != null && t" +
                    "ype is IAssociationEnd associationEnd && associationEnd.SpecializationTypeId == " +
                    "");
            
            #line 199 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationTargetEndClassName));
            
            #line default
            #line hidden
            this.Write(".SpecializationTypeId;\r\n        }\r\n\r\n        public static ");
            
            #line 202 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationTargetEndClassName));
            
            #line default
            #line hidden
            this.Write(" As");
            
            #line 202 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationTargetEndClassName));
            
            #line default
            #line hidden
            this.Write("(this ICanBeReferencedType type)\r\n        {\r\n            return type.Is");
            
            #line 204 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationTargetEndClassName));
            
            #line default
            #line hidden
            this.Write("() ? new ");
            
            #line 204 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(((IAssociationEnd)type).Association).TargetEnd : null;\r\n        }\r\n\r\n        pub" +
                    "lic static bool Is");
            
            #line 207 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationSourceEndClassName));
            
            #line default
            #line hidden
            this.Write("(this ICanBeReferencedType type)\r\n        {\r\n            return type != null && t" +
                    "ype is IAssociationEnd associationEnd && associationEnd.SpecializationTypeId == " +
                    "");
            
            #line 209 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationSourceEndClassName));
            
            #line default
            #line hidden
            this.Write(".SpecializationTypeId;\r\n        }\r\n\r\n        public static ");
            
            #line 212 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationSourceEndClassName));
            
            #line default
            #line hidden
            this.Write(" As");
            
            #line 212 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationSourceEndClassName));
            
            #line default
            #line hidden
            this.Write("(this ICanBeReferencedType type)\r\n        {\r\n            return type.Is");
            
            #line 214 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AssociationSourceEndClassName));
            
            #line default
            #line hidden
            this.Write("() ? new ");
            
            #line 214 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiAssociationModel\ApiAssociationModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(((IAssociationEnd)type).Association).SourceEnd : null;\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
