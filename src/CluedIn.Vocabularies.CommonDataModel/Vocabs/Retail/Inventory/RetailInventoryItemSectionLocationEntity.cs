using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInventoryItemSectionLocationEntityVocabulary : SimpleVocabulary
    {
        public RetailInventoryItemSectionLocationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailInventoryItemSectionLocationEntity";
            KeyPrefix = "commonDataModel.retailinventoryitemsectionlocationentity";
            KeySeparator = ".";
            Grouping = "/RetailInventoryItemSectionLocationEntity";

            AddGroup("Common Data Model RetailInventoryItemSectionLocationEntity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SectionNumber = group.Add(new VocabularyKey(nameof(SectionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShelfNumber = group.Add(new VocabularyKey(nameof(ShelfNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShowsSalesStatistics = group.Add(new VocabularyKey(nameof(ShowsSalesStatistics), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StoreNumber = group.Add(new VocabularyKey(nameof(StoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey SectionNumber { get; private set; }
        public VocabularyKey ShelfNumber { get; private set; }
        public VocabularyKey ShowsSalesStatistics { get; private set; }
        public VocabularyKey StoreNumber { get; private set; }


    }
}