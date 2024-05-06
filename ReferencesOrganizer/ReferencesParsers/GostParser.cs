using ReferencesOrganizer.ReferencesObjects;

namespace ReferencesOrganizer.ReferencesParsers
{
    internal static class GostParser
    {
        public static GostStandart Parse(string sourceString)
        {
            var title = sourceString.Substring(0, sourceString.IndexOf("–"));
            var name = sourceString.Substring(sourceString.IndexOf("«") + 1)[..^1];

            return new GostStandart
            {
                Title = title.Trim(),
                Name = name.Trim()
            };
        }
    }
}
