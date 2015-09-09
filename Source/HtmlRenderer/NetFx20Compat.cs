using System;
using System.Collections.Generic;
using System.Text;

namespace TheArtOfDev.HtmlRenderer
{
    internal static class Platform
    {
        public const StringComparison DefaultStringComparison = StringComparison.InvariantCultureIgnoreCase;
        public static readonly StringComparer DefaultStringComparer = StringComparer.InvariantCultureIgnoreCase;

        public static string[] GetSegments(Uri uri)
        {
            return uri.Segments;
        }
    }
}
