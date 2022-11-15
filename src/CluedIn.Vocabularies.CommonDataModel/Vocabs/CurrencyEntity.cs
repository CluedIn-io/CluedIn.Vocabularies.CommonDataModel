using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CurrencyEntityVocabulary : SimpleVocabulary
    {
        public CurrencyEntityVocabulary()
        {
            VocabularyName = "Currency Entity";
            KeyPrefix = "commonDataModel.currencyentity";
            KeySeparator = ".";
            Grouping = "/CurrencyEntity";

            AddGroup("CurrencyEntity Details", group =>
            {
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralRoundingRule = group.Add(new VocabularyKey(nameof(GeneralRoundingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyGender = group.Add(new VocabularyKey(nameof(CurrencyGender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceCurrencyForTriangulation = group.Add(new VocabularyKey(nameof(ReferenceCurrencyForTriangulation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingRuleFixedAssetDepreciation = group.Add(new VocabularyKey(nameof(RoundingRuleFixedAssetDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingMethodFixedAssetDepreciation = group.Add(new VocabularyKey(nameof(RoundingMethodFixedAssetDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingMethodPrices = group.Add(new VocabularyKey(nameof(RoundingMethodPrices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingMethodPurchaseOrders = group.Add(new VocabularyKey(nameof(RoundingMethodPurchaseOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingMethodSalesOrders = group.Add(new VocabularyKey(nameof(RoundingMethodSalesOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingRulePrices = group.Add(new VocabularyKey(nameof(RoundingRulePrices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingRulePurchaseOrders = group.Add(new VocabularyKey(nameof(RoundingRulePurchaseOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingRuleSalesOrders = group.Add(new VocabularyKey(nameof(RoundingRuleSalesOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Symbol = group.Add(new VocabularyKey(nameof(Symbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey GeneralRoundingRule { get; private set; }
        public VocabularyKey CurrencyGender { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReferenceCurrencyForTriangulation { get; private set; }
        public VocabularyKey RoundingRuleFixedAssetDepreciation { get; private set; }
        public VocabularyKey RoundingMethodFixedAssetDepreciation { get; private set; }
        public VocabularyKey RoundingMethodPrices { get; private set; }
        public VocabularyKey RoundingMethodPurchaseOrders { get; private set; }
        public VocabularyKey RoundingMethodSalesOrders { get; private set; }
        public VocabularyKey RoundingRulePrices { get; private set; }
        public VocabularyKey RoundingRulePurchaseOrders { get; private set; }
        public VocabularyKey RoundingRuleSalesOrders { get; private set; }
        public VocabularyKey Symbol { get; private set; }
    }
}