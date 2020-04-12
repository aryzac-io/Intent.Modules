﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Intent.Modelers.Services;
using Intent.Modelers.Services.Api;
using Intent.Modules.Common;
using Intent.Modules.Common.Registrations;
using Intent.SoftwareFactory;
using Intent.Engine;
using Intent.Modules.Modelers.Services;
using Intent.Templates;

namespace Intent.Modules.Application.Contracts.Mappings.Templates.MappingProfile
{
    [Description("Intent Applications Contract Mapping Profile Template")]
    public class MappingProfileTemplateRegistrations : ListModelTemplateRegistrationBase<DTOModel>
    {
        private readonly ApiMetadataProvider _metadataManager;

        public MappingProfileTemplateRegistrations(ApiMetadataProvider metadataManager)
        {
            _metadataManager = metadataManager;

            FilterExpression = "model.MappedClass != null";
        }

        public override string TemplateId => MappingProfileTemplate.IDENTIFIER;

        public override ITemplate CreateTemplateInstance(IProject project, IList<DTOModel> models)
        {
            return new MappingProfileTemplate(project, models);
        }

        public override IList<DTOModel> GetModels(IApplication application)
        {
            return _metadataManager.GetDTOModels(application).ToList();
        }
    }
}
