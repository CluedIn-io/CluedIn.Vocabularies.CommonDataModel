using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSInventoryReservationHierarchyEntityVocabulary : SimpleVocabulary
    {
        public WHSInventoryReservationHierarchyEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSInventoryReservationHierarchyEntity";
            KeyPrefix = "commonDataModel.whsinventoryreservationhierarchyentity";
            KeySeparator = ".";
            Grouping = "/WHSInventoryReservationHierarchyEntity";

            AddGroup("Common Data Model WHSInventoryReservationHierarchyEntity Details", group =>
            {
                HierarchyDescription = group.Add(new VocabularyKey(nameof(HierarchyDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyName = group.Add(new VocabularyKey(nameof(HierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey HierarchyDescription { get; private set; }
        public VocabularyKey HierarchyName { get; private set; }


    }
}