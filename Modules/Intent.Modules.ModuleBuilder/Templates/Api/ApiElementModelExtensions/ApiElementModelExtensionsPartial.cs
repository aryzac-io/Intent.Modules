using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using Intent.Modules.ModuleBuilder.Api;
using Intent.Modules.ModuleBuilder.Helpers;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("ModuleBuilder.CSharp.Templates.CSharpTemplatePartial", Version = "1.0")]

namespace Intent.Modules.ModuleBuilder.Templates.Api.ApiElementModelExtensions
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class ApiElementModelExtensions : IntentRoslynProjectItemTemplateBase<ExtensionModel>
    {

        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "ModuleBuilder.Templates.Api.ApiElementModelExtensions";

        public ApiElementModelExtensions(IProject project, ExtensionModel model) : base(TemplateId, project, model)
        {
        }

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetadata(Id, "1.0"));
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        protected override RoslynDefaultFileMetadata DefineRoslynDefaultFileMetadata()
        {
            return new RoslynDefaultFileMetadata(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: $"{Model.Type.ApiClassName}Extensions",
                fileExtension: "cs",
                defaultLocationInProject: "Api/Extensions",
                className: $"{Model.Type.ApiClassName}Extensions",
                @namespace: new IntentModuleModel(Model.StereotypeDefinitions.First().Package).ApiNamespace
            );
        }

        public string ModelClassName => Model.Type.ApiClassName;
    }

    public class ExtensionModel
    {
        public IEnumerable<IStereotypeDefinition> StereotypeDefinitions { get; }
        public ExtensionModelType Type { get; set; }

        public ExtensionModel(ExtensionModelType type, IEnumerable<IStereotypeDefinition> stereotypeDefinitions)
        {
            StereotypeDefinitions = stereotypeDefinitions;
            Type = type;
        }

        //public ElementSettingsModel Type { get; }

        //public ExtensionModel(ElementSettingsModel element, IEnumerable<IStereotypeDefinition> stereotypeDefinitions)
        //{
        //    StereotypeDefinitions = stereotypeDefinitions;
        //    Type = element;
        //}
    }

    public class ExtensionModelType
    {
        private readonly IElement _element;
        public string Name => _element.Name;
        public string ApiNamespace => new IntentModuleModel(_element.Package).GetModuleSettings().APINamespace();
        public string ApiClassName => $"{Name.ToCSharpIdentifier()}Model";

        public ExtensionModelType(IElement element)
        {
            _element = element;
        }
    }
}