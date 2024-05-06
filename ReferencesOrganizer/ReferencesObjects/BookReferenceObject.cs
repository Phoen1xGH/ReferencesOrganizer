namespace ReferencesOrganizer.ReferencesObjects
{
    internal class BookReferenceObject : IReferenceObject, ISortedElement
    {
        public string Name { get; set; }

        public string FullSource { get; set; }

        public int? PageNumber { get; set; }

        public SortOrderEnum SortOrder { get; init; } = SortOrderEnum.Book;

        public override string ToString()
        {
            if (FullSource.Contains("|"))
                return FullSource.Substring(0, FullSource.LastIndexOf("|"));

            return FullSource;
        }
    }
}
