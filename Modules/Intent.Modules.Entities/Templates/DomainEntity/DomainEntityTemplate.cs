﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Entities.Templates.DomainEntity
{
    using Intent.MetaModel.Domain;
    using Intent.SoftwareFactory.Templates;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class DomainEntityTemplate : Intent.SoftwareFactory.Templates.IntentRoslynProjectItemTemplateBase<IClass>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing Intent.CodeGen;\r\n");
            
            #line 16 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 20 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 22 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassAnnotations(Model)));
            
            #line default
            #line hidden
            this.Write("\r\n    public ");
            
            #line 23 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.IsAbstract ? "abstract " : ""));
            
            #line default
            #line hidden
            this.Write("partial class ");
            
            #line 23 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 23 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetBaseClass(Model)));
            
            #line default
            #line hidden
            this.Write(", I");
            
            #line 23 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            
            #line 23 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetInterfaces(Model)));
            
            #line default
            #line hidden
            this.Write("\r\n    {");
            
            #line 24 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConstructorAnnotations(Model)));
            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic ");
            
            #line 25 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 25 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConstructorParameters(Model)));
            
            #line default
            #line hidden
            this.Write(") \r\n\t\t{\r\n");
            
            #line 27 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConstructorBody(Model)));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t}\r\n");
            
            #line 29 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassOtherConstructors(Model)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 30 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
  foreach (var attribute in Model.Attributes)
    {
		string attributeType = Types.Get(attribute.Type);

            
            #line default
            #line hidden
            
            #line 34 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertyFieldAnnotations(attribute)));
            
            #line default
            #line hidden
            this.Write("\r\n        private ");
            
            #line 35 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attributeType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 35 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 36 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertyAnnotations(attribute)));
            
            #line default
            #line hidden
            this.Write("\r\n        public ");
            
            #line 37 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attributeType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 37 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(" \r\n        {\r\n            get { return ");
            
            #line 39 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write("; }\r\n            set\r\n            {\r\n");
            
            #line 42 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertySetterBefore(attribute)));
            
            #line default
            #line hidden
            
            #line 42 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
		
		if (attributeType == "date")
		{
			if (!attribute.IsNullable)
			{
            
            #line default
            #line hidden
            this.Write("                ");
            
            #line 47 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write(" = value.Date;\r\n");
            
            #line 48 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
			}
			else
			{
            
            #line default
            #line hidden
            this.Write("                ");
            
            #line 51 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write(" = (value == null) ? value : value.Value.Date;\r\n");
            
            #line 52 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
			}
		}
		else
		{
            
            #line default
            #line hidden
            this.Write("                ");
            
            #line 56 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Name.ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write(" = value;\r\n");
            
            #line 57 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
		}

            
            #line default
            #line hidden
            
            #line 58 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertySetterAfter(attribute)));
            
            #line default
            #line hidden
            this.Write("            }\r\n        }\r\n");
            
            #line 60 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
  }
	foreach (var associatedClass in Model.AssociatedClasses)
    {

            
            #line default
            #line hidden
            
            #line 63 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
 	
		if (!associatedClass.IsNavigable) 
		{
			continue;
        }

            
            #line default
            #line hidden
            this.Write("\t\tprivate ");
            
            #line 69 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associatedClass.Type()));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 69 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associatedClass.Name().ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 70 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertyAnnotations(associatedClass)));
            
            #line default
            #line hidden
            this.Write("\r\n        public virtual ");
            
            #line 71 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associatedClass.Type()));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 71 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associatedClass.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            get\r\n            {\r\n");
            
            #line 75 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
		string associatedClassReturn;
		if (associatedClass.Multiplicity == Multiplicity.Many)
		{
			associatedClassReturn = String.Format("{0} ?? ({0} = new List<{1}>())", associatedClass.Name().ToPrivateMember(), associatedClass.Class.Name + "");
		}
		else
		{
			associatedClassReturn = associatedClass.Name().ToPrivateMember();
		}

            
            #line default
            #line hidden
            this.Write("                return ");
            
            #line 85 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associatedClassReturn));
            
            #line default
            #line hidden
            this.Write(";\r\n            }\r\n            set\r\n            {    \r\n                ");
            
            #line 89 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associatedClass.Name().ToPrivateMember()));
            
            #line default
            #line hidden
            this.Write(" = value;\r\n            }\r\n        }\r\n");
            
            #line 92 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
    }
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 94 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
  foreach (var operation in Model.Operations)
    {
        string returnType = operation.ReturnType != null ? Types.Get( operation.ReturnType.Type) : "void";
        string parameterDefinitions = operation.Parameters.Any() ? operation.Parameters.Select(x => Types.Get(x.Type) + " " + x.Name.ToCamelCase()).Aggregate((x, y) => x + ", " + y) : "";
		if (!operation.IsAbstract)
		{
            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 100 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(returnType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 100 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 100 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterDefinitions));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            throw new NotImplementedException(\"Replace with your im" +
                    "plementation...\");\r\n        }\r\n");
            
            #line 104 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
		}
		else
		{ 
            
            #line default
            #line hidden
            this.Write("        public abstract ");
            
            #line 107 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(returnType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 107 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 107 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterDefinitions));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 108 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Entities\Templates\DomainEntity\DomainEntityTemplate.tt"
		}
    }

            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        private global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost hostValue;
        /// <summary>
        /// The current host for the text templating engine
        /// </summary>
        public virtual global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost Host
        {
            get
            {
                return this.hostValue;
            }
            set
            {
                this.hostValue = value;
            }
        }
    }
    
    #line default
    #line hidden
}
