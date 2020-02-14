﻿using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;

namespace Intent.Modelers.Domain.Api
{
    public class DomainMetadataProvider
    {
        private readonly IMetadataManager _metadataManager;

        public DomainMetadataProvider(IMetadataManager metadataManager)
        {
            _metadataManager = metadataManager;
        }

        public IEnumerable<IClass> GetClasses()
        {
            var cache = new Dictionary<string, Class>();
            var classes = _metadataManager.GetMetadata<IElement>("Domain").Where(x => x.IsClass()).ToList();
            var result = classes.Select(x => cache.ContainsKey(x.Id) ? cache[x.Id] : new Class(x, cache)).ToList();
            return result;
        }

        public IEnumerable<IClass> GetClasses(string applicationId)
        {
            return GetClasses().Where(x => x.Application.Id == applicationId);
        }

        public IEnumerable<IEnum> GetEnums()
        {
            var types = _metadataManager.GetMetadata<IElement>("Domain").Where(x => x.IsEnum()).ToList();
            return types.Select(x => new EnumModel(x)).ToList();
        }

        public IEnumerable<IEnum> GetEnums(string applicationId)
        {
            return GetEnums().Where(x => x.Application.Id == applicationId);
        }

        public IEnumerable<ITypeDefinition> GetTypeDefinitions()
        {
            var types = _metadataManager.GetMetadata<IElement>("Domain").Where(x => x.IsTypeDefinition()).ToList();
            return types.Select(x => new TypeDefinition(x)).ToList();
        }

        public IEnumerable<ITypeDefinition> GetTypeDefinitions(string applicationId)
        {
            return GetTypeDefinitions().Where(x => x.Application.Id == applicationId);
        }
    }

    public static class ElementExtensions
    {
        public static bool IsClass(this IElement x)
        {
            return "Class".Equals(x.SpecializationType, StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsEnum(this IElement x)
        {
            return "Enum".Equals(x.SpecializationType, StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsTypeDefinition(this IElement x)
        {
            return "Type-Definition".Equals(x.SpecializationType, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}