using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CatVendorProductCandidateDefaultOrderSettingsEntityVocabulary : SimpleVocabulary
    {
        public CatVendorProductCandidateDefaultOrderSettingsEntityVocabulary()
        {
            VocabularyName = "Cat Vendor Product Candidate Default Order Settings Entity";
            KeyPrefix = "commonDataModel.catvendorproductcandidatedefaultordersettingsentity";
            KeySeparator = ".";
            Grouping = "/CatVendorProductCandidateDefaultOrderSettingsEntity";

            AddGroup("CatVendorProductCandidateDefaultOrderSettingsEntity Details", group =>
            {
                VendorProductCandidate = group.Add(new VocabularyKey(nameof(VendorProductCandidate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasure = group.Add(new VocabularyKey(nameof(UnitOfMeasure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderQuantityMultiples = group.Add(new VocabularyKey(nameof(OrderQuantityMultiples), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumOrderQuantity = group.Add(new VocabularyKey(nameof(MinimumOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StandardOrderQuantity = group.Add(new VocabularyKey(nameof(StandardOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumOrderQuantity = group.Add(new VocabularyKey(nameof(MaximumOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadTime = group.Add(new VocabularyKey(nameof(LeadTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatalogMaintenanceRequestRecId = group.Add(new VocabularyKey(nameof(CatalogMaintenanceRequestRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCandidateColorId = group.Add(new VocabularyKey(nameof(ProductCandidateColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCandidateConfigurationId = group.Add(new VocabularyKey(nameof(ProductCandidateConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCandidateProductSubtype = group.Add(new VocabularyKey(nameof(ProductCandidateProductSubtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCandidateSizeId = group.Add(new VocabularyKey(nameof(ProductCandidateSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCandidateStyleId = group.Add(new VocabularyKey(nameof(ProductCandidateStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCandidateProductNumber = group.Add(new VocabularyKey(nameof(ProductCandidateProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorCatalogMaintenanceRequestUploadDateTime = group.Add(new VocabularyKey(nameof(VendorCatalogMaintenanceRequestUploadDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey VendorProductCandidate { get; private set; }
        public VocabularyKey UnitOfMeasure { get; private set; }
        public VocabularyKey OrderQuantityMultiples { get; private set; }
        public VocabularyKey MinimumOrderQuantity { get; private set; }
        public VocabularyKey StandardOrderQuantity { get; private set; }
        public VocabularyKey MaximumOrderQuantity { get; private set; }
        public VocabularyKey LeadTime { get; private set; }
        public VocabularyKey CatalogMaintenanceRequestRecId { get; private set; }
        public VocabularyKey ProductCandidateColorId { get; private set; }
        public VocabularyKey ProductCandidateConfigurationId { get; private set; }
        public VocabularyKey ProductCandidateProductSubtype { get; private set; }
        public VocabularyKey ProductCandidateSizeId { get; private set; }
        public VocabularyKey ProductCandidateStyleId { get; private set; }
        public VocabularyKey ProductCandidateProductNumber { get; private set; }
        public VocabularyKey VendorCatalogMaintenanceRequestUploadDateTime { get; private set; }
        public VocabularyKey UnitSymbol { get; private set; }
    }
}