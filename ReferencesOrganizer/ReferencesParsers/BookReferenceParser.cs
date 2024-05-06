using ReferencesOrganizer.ReferencesObjects;

namespace ReferencesOrganizer.ReferencesParsers
{
    internal static class BookReferenceParser
    {
        public static BookReferenceObject Parse(string sourceString)
        {
            string[] parts = sourceString.Split('|');

            var name = parts[0];

            int? page = parts.Length > 1 ? int.Parse(parts[1]) : null;

            return new BookReferenceObject
            {
                Name = name.Trim(),
                PageNumber = page,
                FullSource = sourceString.Trim(),
            };
        }
    }
}
