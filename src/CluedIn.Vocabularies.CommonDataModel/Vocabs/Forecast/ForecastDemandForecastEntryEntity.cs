using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ForecastDemandForecastEntryEntityVocabulary : SimpleVocabulary
    {
        public ForecastDemandForecastEntryEntityVocabulary()
        {
            VocabularyName = "Common Data Model ForecastDemandForecastEntryEntity";
            KeyPrefix = "commonDataModel.forecastdemandforecastentryentity";
            KeySeparator = ".";
            Grouping = "/ForecastDemandForecastEntryEntity";

            AddGroup("Common Data Model ForecastDemandForecastEntryEntity Details", group =>
            {
                ForecastModelId = group.Add(new VocabularyKey(nameof(ForecastModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastStartDate = group.Add(new VocabularyKey(nameof(ForecastStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastAllocationMethod = group.Add(new VocabularyKey(nameof(ForecastAllocationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastedQuantity = group.Add(new VocabularyKey(nameof(ForecastedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastedUnitPrice = group.Add(new VocabularyKey(nameof(ForecastedUnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastedRevenue = group.Add(new VocabularyKey(nameof(ForecastedRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityUnitSymbol = group.Add(new VocabularyKey(nameof(QuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PricingCurrencyCode = group.Add(new VocabularyKey(nameof(PricingCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveringSiteId = group.Add(new VocabularyKey(nameof(DeliveringSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveringWarehouseId = group.Add(new VocabularyKey(nameof(DeliveringWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerGroupId = group.Add(new VocabularyKey(nameof(CustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductAllocationKeyId = group.Add(new VocabularyKey(nameof(ProductAllocationKeyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastEntryNumber = group.Add(new VocabularyKey(nameof(ForecastEntryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ForecastedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastedUnitCost = group.Add(new VocabularyKey(nameof(ForecastedUnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ForecastModelId { get; private set; }
        public VocabularyKey ForecastStartDate { get; private set; }
        public VocabularyKey ForecastAllocationMethod { get; private set; }
        public VocabularyKey ForecastedQuantity { get; private set; }
        public VocabularyKey ForecastedUnitPrice { get; private set; }
        public VocabularyKey ForecastedRevenue { get; private set; }
        public VocabularyKey QuantityUnitSymbol { get; private set; }
        public VocabularyKey PricingCurrencyCode { get; private set; }
        public VocabularyKey DeliveringSiteId { get; private set; }
        public VocabularyKey DeliveringWarehouseId { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey CustomerGroupId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey InventoryStatusId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ProductAllocationKeyId { get; private set; }
        public VocabularyKey ForecastEntryNumber { get; private set; }
        public VocabularyKey ForecastedCatchWeightQuantity { get; private set; }
        public VocabularyKey ForecastedUnitCost { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey Dimension { get; private set; }


    }
}