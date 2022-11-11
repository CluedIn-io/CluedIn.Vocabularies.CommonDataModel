using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesRebateAgreementProductSelectionV2EntityVocabulary : SimpleVocabulary
    {
        public SalesRebateAgreementProductSelectionV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesRebateAgreementProductSelectionV2Entity";
            KeyPrefix = "commonDataModel.salesrebateagreementproductselectionv2entity";
            KeySeparator = ".";
            Grouping = "/SalesRebateAgreementProductSelectionV2Entity";

            AddGroup("Common Data Model SalesRebateAgreementProductSelectionV2Entity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateAgreementRefRecId = group.Add(new VocabularyKey(nameof(RebateAgreementRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductUnitSymbol = group.Add(new VocabularyKey(nameof(ProductUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualifyingSiteId = group.Add(new VocabularyKey(nameof(QualifyingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualifyingWarehouseId = group.Add(new VocabularyKey(nameof(QualifyingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateAgreementId = group.Add(new VocabularyKey(nameof(RebateAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey RebateAgreementRefRecId { get; private set; }
        public VocabularyKey ProductUnitSymbol { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey QualifyingSiteId { get; private set; }
        public VocabularyKey QualifyingWarehouseId { get; private set; }
        public VocabularyKey RebateAgreementId { get; private set; }


    }
}