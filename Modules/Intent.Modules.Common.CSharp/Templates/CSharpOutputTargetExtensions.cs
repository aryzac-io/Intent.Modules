﻿using System.Linq;
using Intent.Engine;
using Intent.Modules.Common.Templates;

namespace Intent.Modules.Common.CSharp.Templates
{
    public static class CSharpOutputTargetExtensions
    {
        /// <summary>
        /// Returns a namespace string based on the full path from the <paramref name="target"/>. This will include folders and C# projects.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string GetNamespace(this IOutputTarget target)
        {
            return string.Join(".", target.GetTargetPath()
                .Where(x => !x.Metadata.ContainsKey("Namespace Provider") ||
                            x.Metadata["Namespace Provider"] as bool? == true)
                .Select(x => x.Name.ToCSharpNamespace()));
        }
    }
}