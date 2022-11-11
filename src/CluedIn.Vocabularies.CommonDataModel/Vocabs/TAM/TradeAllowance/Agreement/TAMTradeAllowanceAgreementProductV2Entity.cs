using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMTradeAllowanceAgreementProductV2EntityVocabulary : SimpleVocabulary
    {
        public TAMTradeAllowanceAgreementProductV2EntityVocabulary()
        {
            VocabularyName = "TAMTradeAllowanceAgreementProductV2Entity";
            KeyPrefix = "commonDataModel.tamtradeallowanceagreementproductv2entity";
            KeySeparator = ".";
            Grouping = "/TAMTradeAllowanceAgreementProductV2Entity";

            AddGroup("TAMTradeAllowanceAgreementProductV2Entity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PromotionalProductUnitSymbol = group.Add(new VocabularyKey(nameof(PromotionalProductUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WeightingFactor = group.Add(new VocabularyKey(nameof(WeightingFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeAllowanceAgreementId = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey PromotionalProductUnitSymbol { get; private set; }
        public VocabularyKey WeightingFactor { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey TradeAllowanceAgreementId { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }


    }
}