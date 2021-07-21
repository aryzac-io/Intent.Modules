// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.Templates.Api.ApiElementModelExtensions
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.CSharp.Templates;
    using Intent.Templates;
    using Intent.Metadata.Models;
    using Intent.ModuleBuilder.Api;
    using Intent.ModuleBuilder.Helpers;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ApiElementModelExtensionsTemplate : CSharpTemplateBase<ExtensionModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing Intent.Metadata.Models;\r\nusing Intent.Modules.Common;\r\n\r\n[as" +
                    "sembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 18 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public static class ");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n");
            
            #line 22 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
  foreach(var stereotypeDefinition in Model.StereotypeDefinitions) { 
            
            #line default
            #line hidden
            this.Write("        public static ");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stereotypeDefinition.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write(" Get");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stereotypeDefinition.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("(this ");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ModelClassName));
            
            #line default
            #line hidden
            this.Write(" model)\r\n        {\r\n            var stereotype = model.GetStereotype(\"");
            
            #line 25 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stereotypeDefinition.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n            return stereotype != null ? new ");
            
            #line 26 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stereotypeDefinition.Name.  ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("(stereotype) : null;\r\n        }\r\n\r\n        public static bool Has");
            
            #line 29 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stereotypeDefinition.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("(this ");
            
            #line 29 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ModelClassName));
            
            #line default
            #line hidden
            this.Write(" model)\r\n        {\r\n            return model.HasStereotype(\"");
            
            #line 31 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stereotypeDefinition.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n        }\r\n\r\n");
            
            #line 34 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write(" \r\n");
            
            #line 35 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
  foreach(var stereotypeDefinition in Model.StereotypeDefinitions) { 
            
            #line default
            #line hidden
            this.Write("        public class ");
            
            #line 36 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stereotypeDefinition.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            private IStereotype _stereotype;\r\n\r\n            public ");
            
            #line 40 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(stereotypeDefinition.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("(IStereotype stereotype)\r\n            {\r\n                _stereotype = stereotype" +
                    ";\r\n            }\r\n\r\n            public string Name => _stereotype.Name;\r\n\r\n");
            
            #line 47 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
      foreach(var property in stereotypeDefinition.Properties) { 
        switch (property.ControlType) {
            case StereotypePropertyControlType.TextBox:
            case StereotypePropertyControlType.TextArea:
            case StereotypePropertyControlType.Function:
            
            
            #line default
            #line hidden
            this.Write("            public string ");
            
            #line 53 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("() {\r\n                return _stereotype.GetProperty<string>(\"");
            
            #line 54 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n            }\r\n\r\n");
            
            #line 57 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
              break;
            case StereotypePropertyControlType.Number:
            
            #line default
            #line hidden
            this.Write("            public int? ");
            
            #line 59 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("() {\r\n                return _stereotype.GetProperty<int?>(\"");
            
            #line 60 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n            }\r\n\r\n");
            
            #line 63 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
              break;
            case StereotypePropertyControlType.Checkbox:
            
            #line default
            #line hidden
            this.Write("            public bool ");
            
            #line 65 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("() {\r\n                return _stereotype.GetProperty<bool>(\"");
            
            #line 66 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n            }\r\n\r\n");
            
            #line 69 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
              break;
            case StereotypePropertyControlType.Select:
            
            #line default
            #line hidden
            
            #line 71 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
              switch (property.OptionsSource) {
                    case StereotypePropertyOptionsSource.LookupElement:
                    case StereotypePropertyOptionsSource.LookupChildren:
                    case StereotypePropertyOptionsSource.NestedLookup:
            
            #line default
            #line hidden
            this.Write("            public IElement ");
            
            #line 75 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("() {\r\n");
            
            #line 76 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
                      if (property.LookupTypes.Count == 1 && false) { /* TODO */ 
            
            #line default
            #line hidden
            this.Write("                return new ");
            
            #line 77 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.LookupTypes.Single().ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("(_stereotype.GetProperty<IElement>(\"");
            
            #line 77 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\"));\r\n");
            
            #line 78 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
                      } else { 
            
            #line default
            #line hidden
            this.Write("                return _stereotype.GetProperty<IElement>(\"");
            
            #line 79 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n");
            
            #line 80 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
                      } 
            
            #line default
            #line hidden
            this.Write("            }\r\n\r\n");
            
            #line 83 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
                      break;
                case StereotypePropertyOptionsSource.Options:
            
            #line default
            #line hidden
            this.Write("            public ");
            
            #line 85 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("Options ");
            
            #line 85 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("() {\r\n                return new ");
            
            #line 86 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("Options(_stereotype.GetProperty<string>(\"");
            
            #line 86 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\"));\r\n            }\r\n\r\n");
            
            #line 89 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
                      break;
                    default:
                        throw new ArgumentOutOfRangeException(property.OptionsSource.ToString());
                } 
            
            #line default
            #line hidden
            
            #line 93 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
              break;
            case StereotypePropertyControlType.MultiSelect:
            
            #line default
            #line hidden
            
            #line 95 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
              switch (property.OptionsSource) {
                    case StereotypePropertyOptionsSource.LookupElement:
                    case StereotypePropertyOptionsSource.LookupChildren:
                    case StereotypePropertyOptionsSource.NestedLookup:
            
            #line default
            #line hidden
            this.Write("            public IElement[] ");
            
            #line 99 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("() {\r\n                return _stereotype.GetProperty<IElement[]>(\"");
            
            #line 100 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n            }\r\n\r\n");
            
            #line 103 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
                      break;
                case StereotypePropertyOptionsSource.Options:
            
            #line default
            #line hidden
            this.Write("            public ");
            
            #line 105 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("Options[] ");
            
            #line 105 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("() {\r\n                return _stereotype.GetProperty<string[]>(\"");
            
            #line 106 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\")?.Select(x => new ");
            
            #line 106 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("Options(x)).ToArray() ?? new ");
            
            #line 106 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("Options[0];\r\n            }\r\n\r\n");
            
            #line 109 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
                      break;
                    default:
                        throw new ArgumentOutOfRangeException(property.OptionsSource.ToString());
                } 
            
            #line default
            #line hidden
            
            #line 113 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
              break;
            case StereotypePropertyControlType.Icon:
            
            #line default
            #line hidden
            this.Write("            public IIconModel ");
            
            #line 115 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("() {\r\n                return _stereotype.GetProperty<IIconModel>(\"");
            
            #line 116 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n            }\r\n\r\n");
            
            #line 119 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
              break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        }
            
            #line default
            #line hidden
            
            #line 124 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
  foreach (var property in stereotypeDefinition.Properties.Where(x => x.ValueOptions.Any())) { 
            
            #line default
            #line hidden
            this.Write("            public class ");
            
            #line 125 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("Options\r\n            {\r\n                public readonly string Value;\r\n\r\n        " +
                    "        public ");
            
            #line 129 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("Options(string value)\r\n                {\r\n                    Value = value;\r\n   " +
                    "             }\r\n\r\n");
            
            #line 134 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
      foreach(var option in property.ValueOptions) { 
            
            #line default
            #line hidden
            this.Write("                public bool Is");
            
            #line 135 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(option.ToCSharpIdentifier()));
            
            #line default
            #line hidden
            this.Write("()\r\n                {\r\n                    return Value == \"");
            
            #line 137 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(option));
            
            #line default
            #line hidden
            this.Write("\";\r\n                }\r\n");
            
            #line 139 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
      } 
            
            #line default
            #line hidden
            this.Write("            }\r\n\r\n");
            
            #line 142 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 145 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModelExtensions\ApiElementModelExtensionsTemplate.tt"
  }
            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
