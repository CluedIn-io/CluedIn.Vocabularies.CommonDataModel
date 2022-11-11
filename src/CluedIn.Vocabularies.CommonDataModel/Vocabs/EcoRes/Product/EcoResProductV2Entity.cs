using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductV2EntityVocabulary : SimpleVocabulary
    {
        public EcoResProductV2EntityVocabulary()
        {
            VocabularyName = "EcoResProductV2Entity";
            KeyPrefix = "commonDataModel.ecoresproductv2entity";
            KeySeparator = ".";
            Grouping = "/EcoResProductV2Entity";

            AddGroup("EcoResProductV2Entity Details", group =>
            {
                ProductType = group.Add(new VocabularyKey(nameof(ProductType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSubType = group.Add(new VocabularyKey(nameof(ProductSubType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceType = group.Add(new VocabularyKey(nameof(ServiceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSearchName = group.Add(new VocabularyKey(nameof(ProductSearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCatchWeightProduct = group.Add(new VocabularyKey(nameof(IsCatchWeightProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDimensionGroupName = group.Add(new VocabularyKey(nameof(ProductDimensionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDimensionGroupRecId = group.Add(new VocabularyKey(nameof(ProductDimensionGroupRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StorageDimensionGroupName = group.Add(new VocabularyKey(nameof(StorageDimensionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StorageDimensionGroupRecId = group.Add(new VocabularyKey(nameof(StorageDimensionGroupRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrackingDimensionGroupName = group.Add(new VocabularyKey(nameof(TrackingDimensionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrackingDimensionGroupRecId = group.Add(new VocabularyKey(nameof(TrackingDimensionGroupRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VariantConfigurationTechnology = group.Add(new VocabularyKey(nameof(VariantConfigurationTechnology), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreIdenticalConfigurationsAllowed = group.Add(new VocabularyKey(nameof(AreIdenticalConfigurationsAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAutomaticVariantGenerationEnabled = group.Add(new VocabularyKey(nameof(IsAutomaticVariantGenerationEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductVariantUnitConversionEnabled = group.Add(new VocabularyKey(nameof(IsProductVariantUnitConversionEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailProductCategoryName = group.Add(new VocabularyKey(nameof(RetailProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailCategoryRecId = group.Add(new VocabularyKey(nameof(RetailCategoryRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorGroupId = group.Add(new VocabularyKey(nameof(ProductColorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeGroupId = group.Add(new VocabularyKey(nameof(ProductSizeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleGroupId = group.Add(new VocabularyKey(nameof(ProductStyleGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductKit = group.Add(new VocabularyKey(nameof(IsProductKit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                STCCCode = group.Add(new VocabularyKey(nameof(STCCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HarmonizedSystemCode = group.Add(new VocabularyKey(nameof(HarmonizedSystemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NMFCCode = group.Add(new VocabularyKey(nameof(NMFCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVariantNameNomenclatureName = group.Add(new VocabularyKey(nameof(ProductVariantNameNomenclatureName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVariantNumberNomenclatureName = group.Add(new VocabularyKey(nameof(ProductVariantNumberNomenclatureName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantyDurationTime = group.Add(new VocabularyKey(nameof(WarrantyDurationTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantyDurationTimeUnit = group.Add(new VocabularyKey(nameof(WarrantyDurationTimeUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngChgProductTypeName = group.Add(new VocabularyKey(nameof(EngChgProductTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngChgProductOwnerId = group.Add(new VocabularyKey(nameof(EngChgProductOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductType { get; private set; }
        public VocabularyKey ProductSubType { get; private set; }
        public VocabularyKey ServiceType { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ProductSearchName { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }
        public VocabularyKey IsCatchWeightProduct { get; private set; }
        public VocabularyKey ProductDimensionGroupName { get; private set; }
        public VocabularyKey ProductDimensionGroupRecId { get; private set; }
        public VocabularyKey StorageDimensionGroupName { get; private set; }
        public VocabularyKey StorageDimensionGroupRecId { get; private set; }
        public VocabularyKey TrackingDimensionGroupName { get; private set; }
        public VocabularyKey TrackingDimensionGroupRecId { get; private set; }
        public VocabularyKey VariantConfigurationTechnology { get; private set; }
        public VocabularyKey AreIdenticalConfigurationsAllowed { get; private set; }
        public VocabularyKey IsAutomaticVariantGenerationEnabled { get; private set; }
        public VocabularyKey IsProductVariantUnitConversionEnabled { get; private set; }
        public VocabularyKey RetailProductCategoryName { get; private set; }
        public VocabularyKey RetailCategoryRecId { get; private set; }
        public VocabularyKey ProductColorGroupId { get; private set; }
        public VocabularyKey ProductSizeGroupId { get; private set; }
        public VocabularyKey ProductStyleGroupId { get; private set; }
        public VocabularyKey IsProductKit { get; private set; }
        public VocabularyKey STCCCode { get; private set; }
        public VocabularyKey HarmonizedSystemCode { get; private set; }
        public VocabularyKey NMFCCode { get; private set; }
        public VocabularyKey ProductVariantNameNomenclatureName { get; private set; }
        public VocabularyKey ProductVariantNumberNomenclatureName { get; private set; }
        public VocabularyKey WarrantyDurationTime { get; private set; }
        public VocabularyKey WarrantyDurationTimeUnit { get; private set; }
        public VocabularyKey EngChgProductTypeName { get; private set; }
        public VocabularyKey EngChgProductOwnerId { get; private set; }


    }
}