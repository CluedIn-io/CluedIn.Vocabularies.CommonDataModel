using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductMasterEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductMasterEntityVocabulary()
        {
            VocabularyName = "Eco Res Product Master Entity";
            KeyPrefix = "commonDataModel.ecoresproductmasterentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductMasterEntity";

            AddGroup("EcoResProductMasterEntity Details", group =>
            {
                ProductType = group.Add(new VocabularyKey(nameof(ProductType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSearchName = group.Add(new VocabularyKey(nameof(ProductSearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCatchWeightProduct = group.Add(new VocabularyKey(nameof(IsCatchWeightProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDimensionGroupName = group.Add(new VocabularyKey(nameof(ProductDimensionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StorageDimensionGroupName = group.Add(new VocabularyKey(nameof(StorageDimensionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrackingDimensionGroupName = group.Add(new VocabularyKey(nameof(TrackingDimensionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VariantConfigurationTechnology = group.Add(new VocabularyKey(nameof(VariantConfigurationTechnology), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreIdenticalConfigurationsAllowed = group.Add(new VocabularyKey(nameof(AreIdenticalConfigurationsAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAutomaticVariantGenerationEnabled = group.Add(new VocabularyKey(nameof(IsAutomaticVariantGenerationEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductVariantUnitConversionEnabled = group.Add(new VocabularyKey(nameof(IsProductVariantUnitConversionEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailProductCategoryName = group.Add(new VocabularyKey(nameof(RetailProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorGroupId = group.Add(new VocabularyKey(nameof(ProductColorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeGroupId = group.Add(new VocabularyKey(nameof(ProductSizeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleGroupId = group.Add(new VocabularyKey(nameof(ProductStyleGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductKit = group.Add(new VocabularyKey(nameof(IsProductKit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                STCCCode = group.Add(new VocabularyKey(nameof(STCCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HarmonizedSystemCode = group.Add(new VocabularyKey(nameof(HarmonizedSystemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NMFCCode = group.Add(new VocabularyKey(nameof(NMFCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProductType { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ProductSearchName { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }
        public VocabularyKey IsCatchWeightProduct { get; private set; }
        public VocabularyKey ProductDimensionGroupName { get; private set; }
        public VocabularyKey StorageDimensionGroupName { get; private set; }
        public VocabularyKey TrackingDimensionGroupName { get; private set; }
        public VocabularyKey VariantConfigurationTechnology { get; private set; }
        public VocabularyKey AreIdenticalConfigurationsAllowed { get; private set; }
        public VocabularyKey IsAutomaticVariantGenerationEnabled { get; private set; }
        public VocabularyKey IsProductVariantUnitConversionEnabled { get; private set; }
        public VocabularyKey RetailProductCategoryName { get; private set; }
        public VocabularyKey ProductColorGroupId { get; private set; }
        public VocabularyKey ProductSizeGroupId { get; private set; }
        public VocabularyKey ProductStyleGroupId { get; private set; }
        public VocabularyKey IsProductKit { get; private set; }
        public VocabularyKey STCCCode { get; private set; }
        public VocabularyKey HarmonizedSystemCode { get; private set; }
        public VocabularyKey NMFCCode { get; private set; }
    }
}