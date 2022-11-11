using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResReleasedProductCreationV2EntityVocabulary : SimpleVocabulary
    {
        public EcoResReleasedProductCreationV2EntityVocabulary()
        {
            VocabularyName = "EcoResReleasedProductCreationV2Entity";
            KeyPrefix = "commonDataModel.ecoresreleasedproductcreationv2entity";
            KeySeparator = ".";
            Grouping = "/EcoResReleasedProductCreationV2Entity";

            AddGroup("EcoResReleasedProductCreationV2Entity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductType = group.Add(new VocabularyKey(nameof(ProductType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSubType = group.Add(new VocabularyKey(nameof(ProductSubType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceType = group.Add(new VocabularyKey(nameof(ServiceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VariantConfigurationTechnology = group.Add(new VocabularyKey(nameof(VariantConfigurationTechnology), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSearchName = group.Add(new VocabularyKey(nameof(ProductSearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SearchName = group.Add(new VocabularyKey(nameof(SearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemModelGroupId = group.Add(new VocabularyKey(nameof(ItemModelGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDimensionGroupName = group.Add(new VocabularyKey(nameof(ProductDimensionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StorageDimensionGroupName = group.Add(new VocabularyKey(nameof(StorageDimensionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrackingDimensionGroupName = group.Add(new VocabularyKey(nameof(TrackingDimensionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCatchWeightProduct = group.Add(new VocabularyKey(nameof(IsCatchWeightProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductKit = group.Add(new VocabularyKey(nameof(IsProductKit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailProductCategoryname = group.Add(new VocabularyKey(nameof(RetailProductCategoryname), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryReservationHierarchyName = group.Add(new VocabularyKey(nameof(InventoryReservationHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMUnitSymbol = group.Add(new VocabularyKey(nameof(BOMUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryUnitSymbol = group.Add(new VocabularyKey(nameof(InventoryUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseUnitSymbol = group.Add(new VocabularyKey(nameof(PurchaseUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesSalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(SalesSalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseSalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(PurchaseSalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantyDurationTime = group.Add(new VocabularyKey(nameof(WarrantyDurationTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantyDurationTimeUnit = group.Add(new VocabularyKey(nameof(WarrantyDurationTimeUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantablePriceRangeBaseType = group.Add(new VocabularyKey(nameof(WarrantablePriceRangeBaseType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LowerWarrantablePriceRangeLimit = group.Add(new VocabularyKey(nameof(LowerWarrantablePriceRangeLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpperWarrantablePriceRangeLimit = group.Add(new VocabularyKey(nameof(UpperWarrantablePriceRangeLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ProductType { get; private set; }
        public VocabularyKey ProductSubType { get; private set; }
        public VocabularyKey ServiceType { get; private set; }
        public VocabularyKey VariantConfigurationTechnology { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ProductSearchName { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }
        public VocabularyKey SearchName { get; private set; }
        public VocabularyKey ProductGroupId { get; private set; }
        public VocabularyKey ItemModelGroupId { get; private set; }
        public VocabularyKey ProductDimensionGroupName { get; private set; }
        public VocabularyKey StorageDimensionGroupName { get; private set; }
        public VocabularyKey TrackingDimensionGroupName { get; private set; }
        public VocabularyKey IsCatchWeightProduct { get; private set; }
        public VocabularyKey IsProductKit { get; private set; }
        public VocabularyKey RetailProductCategoryname { get; private set; }
        public VocabularyKey InventoryReservationHierarchyName { get; private set; }
        public VocabularyKey BOMUnitSymbol { get; private set; }
        public VocabularyKey InventoryUnitSymbol { get; private set; }
        public VocabularyKey SalesUnitSymbol { get; private set; }
        public VocabularyKey PurchaseUnitSymbol { get; private set; }
        public VocabularyKey SalesSalesTaxItemGroupCode { get; private set; }
        public VocabularyKey PurchaseSalesTaxItemGroupCode { get; private set; }
        public VocabularyKey WarrantyDurationTime { get; private set; }
        public VocabularyKey WarrantyDurationTimeUnit { get; private set; }
        public VocabularyKey WarrantablePriceRangeBaseType { get; private set; }
        public VocabularyKey LowerWarrantablePriceRangeLimit { get; private set; }
        public VocabularyKey UpperWarrantablePriceRangeLimit { get; private set; }


    }
}