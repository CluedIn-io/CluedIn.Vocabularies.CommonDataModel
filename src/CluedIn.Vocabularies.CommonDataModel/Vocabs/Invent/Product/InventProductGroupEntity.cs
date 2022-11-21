using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventProductGroupEntityVocabulary : SimpleVocabulary
    {
        public InventProductGroupEntityVocabulary()
        {
            VocabularyName = "Invent Product Group Entity";
            KeyPrefix = "commonDataModel.inventproductgroupentity";
            KeySeparator = ".";
            Grouping = "/InventProductGroupEntity";

            AddGroup("InventProductGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultForecastAllocationKeyId = group.Add(new VocabularyKey(nameof(DefaultForecastAllocationKeyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultSalesSalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(DefaultSalesSalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPurchaseSalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(DefaultPurchaseSalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipmentPhysicalLoadTemplateId = group.Add(new VocabularyKey(nameof(ShipmentPhysicalLoadTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWarehouseFilterCodeRequired = group.Add(new VocabularyKey(nameof(IsWarehouseFilterCodeRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFilterCodeDeterminingWarehouseFilterGroup = group.Add(new VocabularyKey(nameof(IsFilterCodeDeterminingWarehouseFilterGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecDefaultRevenueRecognitionSchedule = group.Add(new VocabularyKey(nameof(RevRecDefaultRevenueRecognitionSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecExcludeFromCarveOut = group.Add(new VocabularyKey(nameof(RevRecExcludeFromCarveOut), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecMedianPrice = group.Add(new VocabularyKey(nameof(RevRecMedianPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecMedianPriceMaximumTolerance = group.Add(new VocabularyKey(nameof(RevRecMedianPriceMaximumTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecMedianPriceMinimumTolerance = group.Add(new VocabularyKey(nameof(RevRecMedianPriceMinimumTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecRevenueRecognitionEnabled = group.Add(new VocabularyKey(nameof(RevRecRevenueRecognitionEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevRecRevenueType = group.Add(new VocabularyKey(nameof(RevRecRevenueType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey DefaultForecastAllocationKeyId { get; private set; }
        public VocabularyKey DefaultSalesSalesTaxItemGroupCode { get; private set; }
        public VocabularyKey DefaultPurchaseSalesTaxItemGroupCode { get; private set; }
        public VocabularyKey ShipmentPhysicalLoadTemplateId { get; private set; }
        public VocabularyKey IsWarehouseFilterCodeRequired { get; private set; }
        public VocabularyKey IsFilterCodeDeterminingWarehouseFilterGroup { get; private set; }
        public VocabularyKey RevRecDefaultRevenueRecognitionSchedule { get; private set; }
        public VocabularyKey RevRecExcludeFromCarveOut { get; private set; }
        public VocabularyKey RevRecMedianPrice { get; private set; }
        public VocabularyKey RevRecMedianPriceMaximumTolerance { get; private set; }
        public VocabularyKey RevRecMedianPriceMinimumTolerance { get; private set; }
        public VocabularyKey RevRecRevenueRecognitionEnabled { get; private set; }
        public VocabularyKey RevRecRevenueType { get; private set; }
    }
}