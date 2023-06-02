using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiMetadataPackageExtensions", Version = "1.0")]

namespace Intent.Modelers.Services.Api
{
    public static class ApiMetadataPackageExtensions
    {
        public static IList<ServicesPackageModel> GetServicesPackageModels(this IDesigner designer)
        {
            return designer.GetPackagesOfType(ServicesPackageModel.SpecializationTypeId)
                .Select(x => new ServicesPackageModel(x))
                .ToList();
        }

        public static bool IsServicesPackageModel(this IPackage package)
        {
            return package?.SpecializationTypeId == ServicesPackageModel.SpecializationTypeId;
        }


    }
}