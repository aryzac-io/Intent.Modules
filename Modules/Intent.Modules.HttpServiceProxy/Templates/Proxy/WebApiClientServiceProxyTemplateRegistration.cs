﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Intent.Modelers.Services.Api;
using Intent.Modules.Common;
using Intent.Modules.Common.Registrations;
using Intent.SoftwareFactory;
using Intent.Engine;
using Intent.Templates;


namespace Intent.Modules.HttpServiceProxy.Templates.Proxy
{
    [Description(WebApiClientServiceProxyTemplate.IDENTIFIER)]
    public class WebApiClientServiceProxyTemplateRegistration : ModelTemplateRegistrationBase<IServiceModel>
    {
        private readonly IMetadataManager _metadataManager;

        public WebApiClientServiceProxyTemplateRegistration(IMetadataManager metadataManager)
        {
            _metadataManager = metadataManager;
        }

        public override string TemplateId => WebApiClientServiceProxyTemplate.IDENTIFIER;

        public override ITemplate CreateTemplateInstance(IProject project, IServiceModel model)
        {
            return new WebApiClientServiceProxyTemplate(project, model);
        }

        public override IEnumerable<IServiceModel> GetModels(IApplication application)
        {
            var results = _metadataManager.GetMetadata<IServiceModel>("Services")
                .Where(x => x.GetStereotypeProperty("Consumers", "CommaSeperatedList", "").Split(',').Any(y => y.Trim().Equals(application.ApplicationName, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            return results;
        }
    }
}

