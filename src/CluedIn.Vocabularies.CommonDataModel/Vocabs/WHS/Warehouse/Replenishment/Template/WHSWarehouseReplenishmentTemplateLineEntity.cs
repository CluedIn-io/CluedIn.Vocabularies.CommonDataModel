using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseReplenishmentTemplateLineEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseReplenishmentTemplateLineEntityVocabulary()
        {
            VocabularyName = "WHSWarehouseReplenishmentTemplateLineEntity";
            KeyPrefix = "commonDataModel.whswarehousereplenishmenttemplatelineentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseReplenishmentTemplateLineEntity";

            AddGroup("WHSWarehouseReplenishmentTemplateLineEntity Details", group =>
            {
                WarehouseReplenishmentTemplateId = group.Add(new VocabularyKey(nameof(WarehouseReplenishmentTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentUnitSymbol = group.Add(new VocabularyKey(nameof(ReplenishmentUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseReplenishmentRequestTypeId = group.Add(new VocabularyKey(nameof(WarehouseReplenishmentRequestTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveCode = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkTemplateId = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumReplenishmentQuantity = group.Add(new VocabularyKey(nameof(MinimumReplenishmentQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumReplenishmentQuantity = group.Add(new VocabularyKey(nameof(MaximumReplenishmentQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentQuantityUnitSymbol = group.Add(new VocabularyKey(nameof(ReplenishmentQuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandIncrementRoundingMethod = group.Add(new VocabularyKey(nameof(DemandIncrementRoundingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillTemplateReplenishEmptyFixedLocations = group.Add(new VocabularyKey(nameof(WillTemplateReplenishEmptyFixedLocations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillTemplateReplenishOnlyFixedLocations = group.Add(new VocabularyKey(nameof(WillTemplateReplenishOnlyFixedLocations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApplicableDemandMethod = group.Add(new VocabularyKey(nameof(ApplicableDemandMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductQueryMode = group.Add(new VocabularyKey(nameof(ProductQueryMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductQuery = group.Add(new VocabularyKey(nameof(ProductQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationQuery = group.Add(new VocabularyKey(nameof(LocationQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVariantQuery = group.Add(new VocabularyKey(nameof(ProductVariantQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkTemplateWorkOrderType = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateWorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentStrategy = group.Add(new VocabularyKey(nameof(ReplenishmentStrategy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentThresholdScope = group.Add(new VocabularyKey(nameof(ReplenishmentThresholdScope), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZoneQuery = group.Add(new VocabularyKey(nameof(ZoneQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentWarehouseId = group.Add(new VocabularyKey(nameof(ReplenishmentWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WarehouseReplenishmentTemplateId { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey LineDescription { get; private set; }
        public VocabularyKey ReplenishmentUnitSymbol { get; private set; }
        public VocabularyKey WarehouseReplenishmentRequestTypeId { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveCode { get; private set; }
        public VocabularyKey WarehouseWorkTemplateId { get; private set; }
        public VocabularyKey MinimumReplenishmentQuantity { get; private set; }
        public VocabularyKey MaximumReplenishmentQuantity { get; private set; }
        public VocabularyKey ReplenishmentQuantityUnitSymbol { get; private set; }
        public VocabularyKey DemandIncrementRoundingMethod { get; private set; }
        public VocabularyKey WillTemplateReplenishEmptyFixedLocations { get; private set; }
        public VocabularyKey WillTemplateReplenishOnlyFixedLocations { get; private set; }
        public VocabularyKey ApplicableDemandMethod { get; private set; }
        public VocabularyKey ProductQueryMode { get; private set; }
        public VocabularyKey ProductQuery { get; private set; }
        public VocabularyKey LocationQuery { get; private set; }
        public VocabularyKey ProductVariantQuery { get; private set; }
        public VocabularyKey WarehouseWorkTemplateWorkOrderType { get; private set; }
        public VocabularyKey ReplenishmentStrategy { get; private set; }
        public VocabularyKey ReplenishmentThresholdScope { get; private set; }
        public VocabularyKey ZoneQuery { get; private set; }
        public VocabularyKey ReplenishmentWarehouseId { get; private set; }


    }
}