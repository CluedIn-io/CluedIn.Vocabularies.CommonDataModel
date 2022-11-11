using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInventoryLinkedItemEntityVocabulary : SimpleVocabulary
    {
        public RetailInventoryLinkedItemEntityVocabulary()
        {
            VocabularyName = "RetailInventoryLinkedItemEntity";
            KeyPrefix = "commonDataModel.retailinventorylinkeditementity";
            KeySeparator = ".";
            Grouping = "/RetailInventoryLinkedItemEntity";

            AddGroup("RetailInventoryLinkedItemEntity Details", group =>
            {
                Blocked = group.Add(new VocabularyKey(nameof(Blocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedItemId = group.Add(new VocabularyKey(nameof(LinkedItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasureSymbol = group.Add(new VocabularyKey(nameof(UnitOfMeasureSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Blocked { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey LinkedItemId { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey UnitOfMeasureSymbol { get; private set; }


    }
}