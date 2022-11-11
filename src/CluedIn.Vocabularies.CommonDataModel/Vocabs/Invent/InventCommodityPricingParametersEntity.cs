using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventCommodityPricingParametersEntityVocabulary : SimpleVocabulary
    {
        public InventCommodityPricingParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventCommodityPricingParametersEntity";
            KeyPrefix = "commonDataModel.inventcommoditypricingparametersentity";
            KeySeparator = ".";
            Grouping = "/InventCommodityPricingParametersEntity";

            AddGroup("Common Data Model InventCommodityPricingParametersEntity Details", group =>
            {
                CommodityCostBasisTypeId = group.Add(new VocabularyKey(nameof(CommodityCostBasisTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommodityPricingTemplateId = group.Add(new VocabularyKey(nameof(CommodityPricingTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreBOMFormulaPriceCalculationsPreserved = group.Add(new VocabularyKey(nameof(AreBOMFormulaPriceCalculationsPreserved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeAgreementJournalNameId = group.Add(new VocabularyKey(nameof(TradeAgreementJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseReferenceDepthValue = group.Add(new VocabularyKey(nameof(BaseReferenceDepthValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialDimensionSetName = group.Add(new VocabularyKey(nameof(FinancialDimensionSetName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CommodityCostBasisTypeId { get; private set; }
        public VocabularyKey CommodityPricingTemplateId { get; private set; }
        public VocabularyKey AreBOMFormulaPriceCalculationsPreserved { get; private set; }
        public VocabularyKey TradeAgreementJournalNameId { get; private set; }
        public VocabularyKey BaseReferenceDepthValue { get; private set; }
        public VocabularyKey FinancialDimensionSetName { get; private set; }


    }
}