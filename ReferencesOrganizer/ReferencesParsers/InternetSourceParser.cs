using ReferencesOrganizer.ReferencesObjects;

namespace ReferencesOrganizer.ReferencesParsers
{
    internal static class InternetSourceParser<T> where T : ILinkSource, new()
    {
        public static T Parse(string sourceString)
        {
            string[] parts = sourceString.Split('|');

            var name = parts[0];

            var link = parts[1];

            int? page = parts.Length > 2 ? int.Parse(parts[2]) : null;

            return new T
            {
                Name = name.Trim(),
                Link = link.Trim(),
                PageNumber = page,
            };
        }
    }
}
