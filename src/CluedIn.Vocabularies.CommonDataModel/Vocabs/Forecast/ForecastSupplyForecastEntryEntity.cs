using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ForecastSupplyForecastEntryEntityVocabulary : SimpleVocabulary
    {
        public ForecastSupplyForecastEntryEntityVocabulary()
        {
            VocabularyName = "ForecastSupplyForecastEntryEntity";
            KeyPrefix = "commonDataModel.forecastsupplyforecastentryentity";
            KeySeparator = ".";
            Grouping = "/ForecastSupplyForecastEntryEntity";

            AddGroup("ForecastSupplyForecastEntryEntity Details", group =>
            {
                ForecastAllocationMethod = group.Add(new VocabularyKey(nameof(ForecastAllocationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastedAmount = group.Add(new VocabularyKey(nameof(ForecastedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PricingCurrencyCode = group.Add(new VocabularyKey(nameof(PricingCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountAmount = group.Add(new VocabularyKey(nameof(DiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercentage = group.Add(new VocabularyKey(nameof(DiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastedInventoryQuantity = group.Add(new VocabularyKey(nameof(ForecastedInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductAllocationKeyId = group.Add(new VocabularyKey(nameof(ProductAllocationKeyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMId = group.Add(new VocabularyKey(nameof(BOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteId = group.Add(new VocabularyKey(nameof(RouteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastModelId = group.Add(new VocabularyKey(nameof(ForecastModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ForecastedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchWeightUnitSymbol = group.Add(new VocabularyKey(nameof(CatchWeightUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePriceQuantity = group.Add(new VocabularyKey(nameof(PurchasePriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastedUnitPrice = group.Add(new VocabularyKey(nameof(ForecastedUnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastedQuantity = group.Add(new VocabularyKey(nameof(ForecastedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityUnitSymbol = group.Add(new VocabularyKey(nameof(QuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastStartDate = group.Add(new VocabularyKey(nameof(ForecastStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorGroupId = group.Add(new VocabularyKey(nameof(VendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductBatchNumber = group.Add(new VocabularyKey(nameof(ProductBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingWarehouseId = group.Add(new VocabularyKey(nameof(ReceivingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingSiteId = group.Add(new VocabularyKey(nameof(ReceivingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastEntryNumber = group.Add(new VocabularyKey(nameof(ForecastEntryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ForecastAllocationMethod { get; private set; }
        public VocabularyKey ForecastedAmount { get; private set; }
        public VocabularyKey PricingCurrencyCode { get; private set; }
        public VocabularyKey DiscountAmount { get; private set; }
        public VocabularyKey DiscountPercentage { get; private set; }
        public VocabularyKey ForecastedInventoryQuantity { get; private set; }
        public VocabularyKey ProductAllocationKeyId { get; private set; }
        public VocabularyKey BOMId { get; private set; }
        public VocabularyKey ProductGroupId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey RouteId { get; private set; }
        public VocabularyKey ForecastModelId { get; private set; }
        public VocabularyKey ForecastedCatchWeightQuantity { get; private set; }
        public VocabularyKey CatchWeightUnitSymbol { get; private set; }
        public VocabularyKey PurchasePriceQuantity { get; private set; }
        public VocabularyKey ForecastedUnitPrice { get; private set; }
        public VocabularyKey ForecastedQuantity { get; private set; }
        public VocabularyKey QuantityUnitSymbol { get; private set; }
        public VocabularyKey ForecastStartDate { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey VendorGroupId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductBatchNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ReceivingWarehouseId { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey ReceivingSiteId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey InventoryStatusId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ForecastEntryNumber { get; private set; }


    }
}