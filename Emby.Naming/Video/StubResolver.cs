using System;
using System.IO;
using Emby.Naming.Common;
using Jellyfin.Extensions;
using System.Linq;

namespace Emby.Naming.Video
{
    /// <summary>
    /// Resolve if file is stub (.disc).
    /// </summary>
    public static class StubResolver
    {
        /// <summary>
        /// Tries to resolve if file is stub (.disc).
        /// </summary>
        /// <param name="path">Path to file.</param>
        /// <param name="options">NamingOptions containing StubFileExtensions and StubTypes.</param>
        /// <param name="stubType">Stub type.</param>
        /// <returns>True if file is a stub.</returns>
        public static bool TryResolveFile(string path, NamingOptions options, out string? stubType)
        {
            stubType = default;

            if (string.IsNullOrEmpty(path))
            {
                return false;
            }

            var extension = Path.GetExtension(path);

            if (!options.StubFileExtensions.Contains(extension, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            path = Path.GetFileNameWithoutExtension(path);
            var token = Path.GetExtension(path).TrimStart('.');
            foreach (var rule in from rule in options.StubTypes
                                 where string.Equals(rule.Token, token, StringComparison.OrdinalIgnoreCase)
                                 select rule)
            {
                stubType = rule.StubType;
                return true;
            }

            return true;
        }
    }
}
