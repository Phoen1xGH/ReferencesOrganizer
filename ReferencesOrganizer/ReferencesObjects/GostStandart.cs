namespace ReferencesOrganizer.ReferencesObjects
{
    internal class GostStandart : IReferenceObject, ISortedElement
    {
        public string Title { get; set; }
        public string Name { get; set; }

        public int? PageNumber { get; set; }

        public SortOrderEnum SortOrder { get; init; } = SortOrderEnum.Gost;

        public override string ToString()
        {
            return $"{Title} \"{Name}\"";
        }
    }
}
