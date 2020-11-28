using System;
using System.Collections.Generic;
using Intent.Metadata.Models;
using Intent.RoslynWeaver.Attributes;

namespace Intent.Modules.Common.Types.Api
{
    public static class FolderExtensions
    {
        public static IList<FolderModel> GetFolderModels(this IHasFolder model)
        {
            List<FolderModel> result = new List<FolderModel>();

            var current = model.Folder;
            while (current != null)
            {
                result.Insert(0, current);
                current = current.Folder;
            }
            return result;
        }

        [Obsolete("Use GetFolderModels")]
        public static IList<FolderModel> GetFolderPath(this IHasFolder model, bool includePackage = false)
        {
            return GetFolderModels(model);
        }


        public static IStereotype GetStereotypeInFolders(this IHasFolder model, string stereotypeName)
        {
            var folder = model.Folder;
            while (folder != null)
            {
                if (folder.HasStereotype(stereotypeName))
                {
                    return folder.GetStereotype(stereotypeName);
                }
                folder = folder.Folder;
            }
            return null;
        }

    }
}