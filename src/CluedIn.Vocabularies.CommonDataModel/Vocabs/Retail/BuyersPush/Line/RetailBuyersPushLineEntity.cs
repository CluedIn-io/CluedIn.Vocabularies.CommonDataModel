using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailBuyersPushLineEntityVocabulary : SimpleVocabulary
    {
        public RetailBuyersPushLineEntityVocabulary()
        {
            VocabularyName = "RetailBuyersPushLineEntity";
            KeyPrefix = "commonDataModel.retailbuyerspushlineentity";
            KeySeparator = ".";
            Grouping = "/RetailBuyersPushLineEntity";

            AddGroup("RetailBuyersPushLineEntity Details", group =>
            {
                BuyersPushId = group.Add(new VocabularyKey(nameof(BuyersPushId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryDimensionId = group.Add(new VocabularyKey(nameof(InventoryDimensionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasureSymbol = group.Add(new VocabularyKey(nameof(UnitOfMeasureSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserSpecified = group.Add(new VocabularyKey(nameof(UserSpecified), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserSpecifiedQuantity = group.Add(new VocabularyKey(nameof(UserSpecifiedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BuyersPushId { get; private set; }
        public VocabularyKey InventoryDimensionId { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey UnitOfMeasureSymbol { get; private set; }
        public VocabularyKey UserSpecified { get; private set; }
        public VocabularyKey UserSpecifiedQuantity { get; private set; }


    }
}