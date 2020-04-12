﻿using System;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modelers.Domain.Api;
using Intent.Modules.Application.Contracts;
using Intent.Engine;
using Intent.Modelers.Services.Api;
using Intent.Modules.Common.Templates;
using IClass = Intent.Modelers.Domain.Api.IClass;

namespace Intent.Modules.Convention.ServiceImplementations.MethodImplementationStrategies
{
    public class GetByIdImplementationStrategy : IImplementationStrategy
    {
        public bool Match(IMetadataManager metadataManager, Engine.IApplication application, IClass domainModel, OperationModel operationModel)
        {
            if (operationModel.Parameters.Count() != 1)
            {
                return false;
            }

            if (!operationModel.Parameters.Any(p => string.Equals(p.Name, "id", StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }

            if (operationModel?.TypeReference?.IsCollection ?? false)
            {
                return false;
            }

            var lowerDomainName = domainModel.Name.ToLower();
            var lowerOperationName = operationModel.Name.ToLower();
            return new[]
            {
                "get",
                $"get{lowerDomainName}",
                "find",
                "findbyid",
                $"find{lowerDomainName}",
                $"find{lowerDomainName}byid",
                lowerDomainName
            }
            .Contains(lowerOperationName);
        }

        public string GetImplementation(IMetadataManager metadataManager, Engine.IApplication application, IClass domainModel, OperationModel operationModel)
        {
            return $@"var element ={ (operationModel.IsAsync() ? " await" : "") } {domainModel.Name.ToPrivateMember()}Repository.FindById{ (operationModel.IsAsync() ? "Async" : "") }({operationModel.Parameters.First().Name.ToCamelCase()});
            return element.MapTo{domainModel.Name.ToPascalCase()}DTO();";
        }
    }
}
