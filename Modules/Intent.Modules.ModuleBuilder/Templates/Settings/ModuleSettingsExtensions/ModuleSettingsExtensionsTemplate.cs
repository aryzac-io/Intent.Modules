// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.Templates.Settings.ModuleSettingsExtensions
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
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class ModuleSettingsExtensionsTemplate : CSharpTemplateBase<IList<Intent.ModuleBuilder.Api.ModuleSettingsConfigurationModel>>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing Intent.Configuration;\r\nusing Intent.Engine;\r\n\r\n[assembly: De" +
                    "faultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 17 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public static class ");
            
            #line 19 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("\r\n    {");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"

    foreach(var settingsGroup in Model) { 
            
            #line default
            #line hidden
            this.Write("\r\n        public static ");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(settingsGroup.Name.ToCSharpIdentifier().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(" Get");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(settingsGroup.Name.ToCSharpIdentifier().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("(this IApplicationSettingsProvider settings)\r\n        {\r\n            return new ");
            
            #line 25 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(settingsGroup.Name.ToCSharpIdentifier().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("(settings.GetGroup(\"");
            
            #line 25 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(settingsGroup.Id));
            
            #line default
            #line hidden
            this.Write("\"));\r\n        }\r\n");
            
            #line 27 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("    }\r\n");
            
            #line 29 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
  foreach(var settingsGroup in Model) { 
            
            #line default
            #line hidden
            this.Write("\r\n    public class ");
            
            #line 31 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(settingsGroup.Name.ToCSharpIdentifier().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        private readonly IGroupSettings _groupSettings;\r\n\r\n        publi" +
                    "c ");
            
            #line 35 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(settingsGroup.Name.ToCSharpIdentifier().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("(IGroupSettings groupSettings)\r\n        {\r\n            _groupSettings = groupSett" +
                    "ings;\r\n        }\r\n");
            
            #line 39 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"

        foreach(var settingsField in settingsGroup.Fields)
        {
            switch (settingsField.GetFieldConfiguration().ControlType().AsEnum())
            {
                case ModuleSettingsFieldConfigurationModelStereotypeExtensions.FieldConfiguration.ControlTypeOptionsEnum.TextBox:
                case ModuleSettingsFieldConfigurationModelStereotypeExtensions.FieldConfiguration.ControlTypeOptionsEnum.TextArea:
                case ModuleSettingsFieldConfigurationModelStereotypeExtensions.FieldConfiguration.ControlTypeOptionsEnum.Number:

            
            #line default
            #line hidden
            this.Write("\r\n        public string ");
            
            #line 49 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(settingsField.Name.ToCSharpIdentifier().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("() => _groupSettings.GetSetting(\"");
            
            #line 49 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(settingsField.Id));
            
            #line default
            #line hidden
            this.Write("\")?.Value;\r\n");
            
            #line 50 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
                    break;
                case ModuleSettingsFieldConfigurationModelStereotypeExtensions.FieldConfiguration.ControlTypeOptionsEnum.Checkbox:
                case ModuleSettingsFieldConfigurationModelStereotypeExtensions.FieldConfiguration.ControlTypeOptionsEnum.Switch:

            
            #line default
            #line hidden
            this.Write("\r\n        public bool ");
            
            #line 55 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(settingsField.Name.ToCSharpIdentifier().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("() => bool.TryParse(_groupSettings.GetSetting(\"");
            
            #line 55 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(settingsField.Id));
            
            #line default
            #line hidden
            this.Write("\")?.Value.ToPascalCase(), out var result) && result;\r\n");
            
            #line 56 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
                    break;
                case ModuleSettingsFieldConfigurationModelStereotypeExtensions.FieldConfiguration.ControlTypeOptionsEnum.Select:
                    var optionsClassName = $"{settingsField.Name.ToCSharpIdentifier().ToPascalCase()}Options";
                    var optionsEnumName = $"{optionsClassName}Enum";

            
            #line default
            #line hidden
            this.Write("\r\n        public ");
            
            #line 62 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(optionsClassName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 62 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(settingsField.Name.ToCSharpIdentifier().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("() => new ");
            
            #line 62 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(optionsClassName));
            
            #line default
            #line hidden
            this.Write("(_groupSettings.GetSetting(\"");
            
            #line 62 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(settingsField.Id));
            
            #line default
            #line hidden
            this.Write("\")?.Value);\r\n\r\n        public class ");
            
            #line 64 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(optionsClassName));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            public readonly string Value;\r\n\r\n            public ");
            
            #line 68 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(optionsClassName));
            
            #line default
            #line hidden
            this.Write("(string value)\r\n            {\r\n                Value = value;\r\n            }\r\n\r\n " +
                    "           public ");
            
            #line 73 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(optionsEnumName));
            
            #line default
            #line hidden
            this.Write(" AsEnum()\r\n            {\r\n                return Value switch\r\n                {\r" +
                    "\n");
            
            #line 77 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"

                    foreach (var option in settingsField.Options)
                    {

            
            #line default
            #line hidden
            this.Write("                    \"");
            
            #line 81 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(option.Value));
            
            #line default
            #line hidden
            this.Write("\" => ");
            
            #line 81 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(optionsEnumName));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 81 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(option.Name.ToCSharpIdentifier().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 82 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"

                    }

            
            #line default
            #line hidden
            this.Write("                    _ => throw new ArgumentOutOfRangeException(nameof(Value), $\"{" +
                    "Value} is out of range\")\r\n                };\r\n            }\r\n");
            
            #line 88 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"

                    foreach (var option in settingsField.Options)
                    {

            
            #line default
            #line hidden
            this.Write("\r\n            public bool Is");
            
            #line 93 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(option.Name.ToCSharpIdentifier().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("()\r\n            {\r\n                return Value == \"");
            
            #line 95 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(option.Value));
            
            #line default
            #line hidden
            this.Write("\";\r\n            }\r\n");
            
            #line 97 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"

                    }

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n        public enum ");
            
            #line 102 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(optionsEnumName));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n");
            
            #line 104 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"

                    foreach (var option in settingsField.Options)
                    {

            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 108 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(option.Name.ToCSharpIdentifier().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 109 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"

                    }

            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 113 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
                    break;
                case ModuleSettingsFieldConfigurationModelStereotypeExtensions.FieldConfiguration.ControlTypeOptionsEnum.MultiSelect:
            
            #line default
            #line hidden
            
            #line 115 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            } 
            
            #line default
            #line hidden
            
            #line 119 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
      } 
            
            #line default
            #line hidden
            this.Write("    }\r\n");
            
            #line 121 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Settings\ModuleSettingsExtensions\ModuleSettingsExtensionsTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
