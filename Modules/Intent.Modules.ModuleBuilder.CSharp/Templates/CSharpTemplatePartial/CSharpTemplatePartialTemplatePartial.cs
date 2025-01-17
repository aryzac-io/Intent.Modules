using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.ModuleBuilder.Api;
using Intent.ModuleBuilder.CSharp.Api;
using Intent.Modules.Common;
using Intent.Modules.Common.CSharp.Templates;
using Intent.Modules.Common.Templates;
using Intent.Modules.Common.Types.Api;
using Intent.Modules.Common.VisualStudio;
using Intent.Modules.ModuleBuilder.Templates.IModSpec;
using Intent.Modules.ModuleBuilder.Templates.TemplateDecoratorContract;
using Intent.Modules.ModuleBuilder.Templates.TemplateExtensions;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.CSharp.Templates.CSharpTemplatePartial", Version = "1.0")]

namespace Intent.Modules.ModuleBuilder.CSharp.Templates.CSharpTemplatePartial
{
    [IntentManaged(Mode.Merge)]
    partial class CSharpTemplatePartialTemplate : CSharpTemplateBase<CSharpTemplateModel>, IModuleBuilderTemplate
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Intent.ModuleBuilder.CSharp.Templates.CSharpTemplatePartial";

        [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
        public CSharpTemplatePartialTemplate(IOutputTarget outputTarget, CSharpTemplateModel model) : base(TemplateId, outputTarget, model)
        {
            AddNugetDependency(IntentNugetPackages.IntentModulesCommonCSharp);
        }

        public string TemplateName => $"{Model.Name.ToCSharpIdentifier().RemoveSuffix("Template")}Template";
        //public IList<string> OutputFolder => Model.GetParentFolders().Select(x => x.Name).Concat(new[] { Model.Name }).ToList();
        //public string FolderPath => string.Join("/", OutputFolder);
        //public string FolderNamespace => string.Join(".", OutputFolder);

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        protected override CSharpFileConfig DefineFileConfig()
        {
            return new CSharpFileConfig(
                className: $"{TemplateName}",
                @namespace: $"{this.GetNamespace(additionalFolders: Model.Name.ToCSharpIdentifier().RemoveSuffix("Template"))}",
                relativeLocation: $"{this.GetFolderPath(additionalFolders: Model.Name.ToCSharpIdentifier().RemoveSuffix("Template"))}",
                fileName: $"{TemplateName}Partial");
        }

        public override void BeforeTemplateExecution()
        {
            ExecutionContext.EventDispatcher.Publish(new TemplateRegistrationRequiredEvent(this));

            ExecutionContext.EventDispatcher.Publish(new ModuleDependencyRequiredEvent(
                moduleId: "Intent.Common.CSharp",
                moduleVersion: "3.3.25"));
            if (Model.GetDesigner() != null)
            {
                ExecutionContext.EventDispatcher.Publish(new ModuleDependencyRequiredEvent(
                    moduleId: Model.GetDesigner().ParentModule.Name,
                    moduleVersion: Model.GetDesigner().ParentModule.Version));
            }
            if (Model.GetModelType() != null)
            {
                ExecutionContext.EventDispatcher.Publish(new ModuleDependencyRequiredEvent(
                    moduleId: Model.GetModelType().ParentModule.Name,
                    moduleVersion: Model.GetModelType().ParentModule.Version));
            }
        }

        private string GetAccessModifier()
        {
            if (Model.GetCSharpTemplateSettings()?.TemplatingMethod()?.IsCSharpFileBuilder() == true
                || Model.GetCSharpTemplateSettings()?.TemplatingMethod()?.IsCustom() == true)
            {
                return "public partial ";
            }
            return "partial ";
        }

        string IModuleBuilderTemplate.GetModelType()
        {
            return Model.GetModelName();
        }

        string IModuleBuilderTemplate.GetRole()
        {
            return GetRole();
        }

        public string TemplateType()
        {
            return "C# Template";
        }

        public string GetDefaultLocation()
        {
            return Model.GetLocation();
        }

        private string GetRole()
        {
            return Model.GetRole();
        }

        public string GetTemplateId()
        {
            return $"{Model.GetModule().Name}.{string.Join(".", Model.GetParentFolderNames().Concat(new[] { Model.Name }))}";
        }

        private IEnumerable<string> GetBaseTypes()
        {
            if (Model.DecoratorContract != null)
            {
                yield return $"CSharpTemplateBase<{GetModelType()}, {GetTypeName(TemplateDecoratorContractTemplate.TemplateId, Model.DecoratorContract)}>";
            }
            else
            {
                yield return $"CSharpTemplateBase<{GetModelType()}>";
            }

            if (Model.GetCSharpTemplateSettings().TemplatingMethod().IsCSharpFileBuilder())
            {
                yield return nameof(ICSharpFileBuilderTemplate);
            }
        }

        private string GetModelType()
        {
            return NormalizeNamespace(Model.GetModelName());
        }

        private bool IsForInterface()
        {
            return Model.Name.RemoveSuffix("Template").EndsWith("Interface");
        }

        private string GetClassName()
        {
            return $"{(IsForInterface() ? "I" : "")}{(Model.IsFilePerModelTemplateRegistration() ? $"{{Model.Name}}" : Model.Name.RemoveSuffix("Template", "Interface"))}";
        }
    }
}