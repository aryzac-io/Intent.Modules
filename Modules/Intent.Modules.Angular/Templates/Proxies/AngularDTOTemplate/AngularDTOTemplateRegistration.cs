using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modelers.Services;
using Intent.Modules.Angular.Api;
using Intent.Modules.Common;
using Intent.Modules.Common.Registrations;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;
using Intent.Modelers.Services.Api;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.TemplateRegistration.FilePerModel", Version = "1.0")]

namespace Intent.Modules.Angular.Templates.Proxies.AngularDTOTemplate
{
    [IntentManaged(Mode.Merge, Body = Mode.Merge, Signature = Mode.Fully)]
    public class AngularDTOTemplateRegistration : ModelTemplateRegistrationBase<DTOModel>
    {
        private readonly IMetadataManager _metadataManager;

        public AngularDTOTemplateRegistration(IMetadataManager metadataManager)
        {
            _metadataManager = metadataManager;
        }

        public override string TemplateId => AngularDTOTemplate.TemplateId;

        public override ITemplate CreateTemplateInstance(IProject project, DTOModel model)
        {
            return new AngularDTOTemplate(project, (ModuleDTOModel)model);
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public override IEnumerable<DTOModel> GetModels(IApplication application)
        {
            var dtoModels = new List<ModuleDTOModel>();
            foreach (var moduleModel in _metadataManager.GetModuleModels(application))
            {
                dtoModels.AddRange(moduleModel.GetDTOModels());
            }

            return dtoModels.Distinct().ToList();
        }


    }
}