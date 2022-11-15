using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CatVendorProductCandidateTranslationEntityVocabulary : SimpleVocabulary
    {
        public CatVendorProductCandidateTranslationEntityVocabulary()
        {
            VocabularyName = "Cat Vendor Product Candidate Translation Entity";
            KeyPrefix = "commonDataModel.catvendorproductcandidatetranslationentity";
            KeySeparator = ".";
            Grouping = "/CatVendorProductCandidateTranslationEntity";

            AddGroup("CatVendorProductCandidateTranslationEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCandidate = group.Add(new VocabularyKey(nameof(ProductCandidate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorCatalogMaintenanceRequestUploadDateTime = group.Add(new VocabularyKey(nameof(VendorCatalogMaintenanceRequestUploadDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCandidateStyleId = group.Add(new VocabularyKey(nameof(ProductCandidateStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCandidateProductNumber = group.Add(new VocabularyKey(nameof(ProductCandidateProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCandidateSizeId = group.Add(new VocabularyKey(nameof(ProductCandidateSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCandidateProductSubtype = group.Add(new VocabularyKey(nameof(ProductCandidateProductSubtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCandidateConfigurationId = group.Add(new VocabularyKey(nameof(ProductCandidateConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCandidateColorId = group.Add(new VocabularyKey(nameof(ProductCandidateColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatalogMaintenanceRequestRecId = group.Add(new VocabularyKey(nameof(CatalogMaintenanceRequestRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCandidateRecId = group.Add(new VocabularyKey(nameof(ProductCandidateRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ProductCandidate { get; private set; }
        public VocabularyKey VendorCatalogMaintenanceRequestUploadDateTime { get; private set; }
        public VocabularyKey ProductCandidateStyleId { get; private set; }
        public VocabularyKey ProductCandidateProductNumber { get; private set; }
        public VocabularyKey ProductCandidateSizeId { get; private set; }
        public VocabularyKey ProductCandidateProductSubtype { get; private set; }
        public VocabularyKey ProductCandidateConfigurationId { get; private set; }
        public VocabularyKey ProductCandidateColorId { get; private set; }
        public VocabularyKey CatalogMaintenanceRequestRecId { get; private set; }
        public VocabularyKey ProductCandidateRecId { get; private set; }
    }
}