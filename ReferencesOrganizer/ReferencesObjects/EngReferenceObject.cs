namespace ReferencesOrganizer.ReferencesObjects
{
    internal class EngReferenceObject : ILinkSource, ISortedElement
    {
        public string Name { get; set; }

        public string Link { get; set; }

        public int? PageNumber { get; set; }

        public SortOrderEnum SortOrder { get; init; } = SortOrderEnum.EngRef;

        public override string ToString()
        {
            return $"{Name} [Электронный ресурс]. Режим доступа: {Link}. Дата обращения --.--.----.";
        }
    }
}
