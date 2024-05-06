namespace ReferencesOrganizer.ReferencesObjects
{
    internal class RuReferenceObject : ILinkSource, ISortedElement
    {
        public string Name { get; set; }

        public string Link { get; set; }

        public int? PageNumber { get; set; }

        public SortOrderEnum SortOrder { get; init; } = SortOrderEnum.RuRef;

        public override string ToString()
        {
            return $"{Name} [Электронный ресурс]. Режим доступа: {Link}. Дата обращения --.--.----.";
        }
    }
}
