using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResReleasedDistinctProductCDSEntityVocabulary : SimpleVocabulary
    {
        public EcoResReleasedDistinctProductCDSEntityVocabulary()
        {
            VocabularyName = "EcoResReleasedDistinctProductCDSEntity";
            KeyPrefix = "commonDataModel.ecoresreleaseddistinctproductcdsentity";
            KeySeparator = ".";
            Grouping = "/EcoResReleasedDistinctProductCDSEntity";

            AddGroup("EcoResReleasedDistinctProductCDSEntity Details", group =>
            {
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitDecimalPrecision = group.Add(new VocabularyKey(nameof(SalesUnitDecimalPrecision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductType = group.Add(new VocabularyKey(nameof(ProductType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceType = group.Add(new VocabularyKey(nameof(ServiceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStockedProduct = group.Add(new VocabularyKey(nameof(IsStockedProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitCost = group.Add(new VocabularyKey(nameof(UnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryUnitDecimalPrecision = group.Add(new VocabularyKey(nameof(InventoryUnitDecimalPrecision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryUnitSymbol = group.Add(new VocabularyKey(nameof(InventoryUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCatchWeightProduct = group.Add(new VocabularyKey(nameof(IsCatchWeightProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantyDurationTime = group.Add(new VocabularyKey(nameof(WarrantyDurationTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantyDurationTimeUnit = group.Add(new VocabularyKey(nameof(WarrantyDurationTimeUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantablePriceRangeBaseType = group.Add(new VocabularyKey(nameof(WarrantablePriceRangeBaseType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LowerWarrantablePriceRangeLimit = group.Add(new VocabularyKey(nameof(LowerWarrantablePriceRangeLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpperWarrantablePriceRangeLimit = group.Add(new VocabularyKey(nameof(UpperWarrantablePriceRangeLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldServiceProductType = group.Add(new VocabularyKey(nameof(FieldServiceProductType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey SalesUnitSymbol { get; private set; }
        public VocabularyKey SalesUnitDecimalPrecision { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }
        public VocabularyKey ProductType { get; private set; }
        public VocabularyKey ServiceType { get; private set; }
        public VocabularyKey IsStockedProduct { get; private set; }
        public VocabularyKey UnitCost { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey InventoryUnitDecimalPrecision { get; private set; }
        public VocabularyKey InventoryUnitSymbol { get; private set; }
        public VocabularyKey IsCatchWeightProduct { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey WarrantyDurationTime { get; private set; }
        public VocabularyKey WarrantyDurationTimeUnit { get; private set; }
        public VocabularyKey WarrantablePriceRangeBaseType { get; private set; }
        public VocabularyKey LowerWarrantablePriceRangeLimit { get; private set; }
        public VocabularyKey UpperWarrantablePriceRangeLimit { get; private set; }
        public VocabularyKey FieldServiceProductType { get; private set; }


    }
}