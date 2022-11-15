using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailBuyersPushLineQuantityEntityVocabulary : SimpleVocabulary
    {
        public RetailBuyersPushLineQuantityEntityVocabulary()
        {
            VocabularyName = "Retail Buyers Push Line Quantity Entity";
            KeyPrefix = "commonDataModel.retailbuyerspushlinequantityentity";
            KeySeparator = ".";
            Grouping = "/RetailBuyersPushLineQuantityEntity";

            AddGroup("RetailBuyersPushLineQuantityEntity Details", group =>
            {
                BuyersPushId = group.Add(new VocabularyKey(nameof(BuyersPushId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTable = group.Add(new VocabularyKey(nameof(SalesTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLegalEntity = group.Add(new VocabularyKey(nameof(WarehouseLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesId = group.Add(new VocabularyKey(nameof(SalesId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BuyersPushId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey SalesTable { get; private set; }
        public VocabularyKey WarehouseLegalEntity { get; private set; }
        public VocabularyKey SalesId { get; private set; }
    }
}