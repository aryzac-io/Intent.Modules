using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.ModuleBuilder.Api;
using Intent.Modules.Common;
using Intent.Modules.Common.Registrations;
using Intent.Modules.ModuleBuilder.Dart.Api;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.TemplateRegistration.FilePerModel", Version = "1.0")]

namespace Intent.Modules.ModuleBuilder.Dart.Templates.Templates.DartTemplateT4
{
    [IntentManaged(Mode.Merge, Body = Mode.Merge, Signature = Mode.Fully)]
    public class DartTemplateT4TemplateRegistration : FilePerModelTemplateRegistration<DartFileTemplateModel>
    {
        private readonly IMetadataManager _metadataManager;

        public DartTemplateT4TemplateRegistration(IMetadataManager metadataManager)
        {
            _metadataManager = metadataManager;
        }

        public override string TemplateId => DartTemplateT4Template.TemplateId;

        public override ITemplate CreateTemplateInstance(IOutputTarget outputTarget, DartFileTemplateModel model)
        {
            return new DartTemplateT4Template(outputTarget, model);
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public override IEnumerable<DartFileTemplateModel> GetModels(IApplication application)
        {
            return _metadataManager.ModuleBuilder(application).GetDartFileTemplateModels()
                .Where(x => !x.TryGetDartTemplateSettings(out var templateSettings) || templateSettings.TemplatingMethod().IsT4Template())
                .ToList();
            //return _metadataManager.ModuleBuilder(application).GetDartFileTemplateModels();
        }
    }
}