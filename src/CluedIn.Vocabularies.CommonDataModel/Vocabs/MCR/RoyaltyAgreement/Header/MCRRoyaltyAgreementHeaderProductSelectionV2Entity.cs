using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRRoyaltyAgreementHeaderProductSelectionV2EntityVocabulary : SimpleVocabulary
    {
        public MCRRoyaltyAgreementHeaderProductSelectionV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRRoyaltyAgreementHeaderProductSelectionV2Entity";
            KeyPrefix = "commonDataModel.mcrroyaltyagreementheaderproductselectionv2entity";
            KeySeparator = ".";
            Grouping = "/MCRRoyaltyAgreementHeaderProductSelectionV2Entity";

            AddGroup("Common Data Model MCRRoyaltyAgreementHeaderProductSelectionV2Entity Details", group =>
            {
                RoyaltyAgreementId = group.Add(new VocabularyKey(nameof(RoyaltyAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualifyingSiteId = group.Add(new VocabularyKey(nameof(QualifyingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualifyingWarehouseId = group.Add(new VocabularyKey(nameof(QualifyingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultVendorAccountNumber = group.Add(new VocabularyKey(nameof(DefaultVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RoyaltyAgreementId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey SalesUnitSymbol { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey QualifyingSiteId { get; private set; }
        public VocabularyKey QualifyingWarehouseId { get; private set; }
        public VocabularyKey DefaultVendorAccountNumber { get; private set; }


    }
}