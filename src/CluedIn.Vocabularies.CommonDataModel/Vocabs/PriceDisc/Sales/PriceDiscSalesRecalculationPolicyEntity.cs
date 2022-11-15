using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PriceDiscSalesRecalculationPolicyEntityVocabulary : SimpleVocabulary
    {
        public PriceDiscSalesRecalculationPolicyEntityVocabulary()
        {
            VocabularyName = "Price Disc Sales Recalculation Policy Entity";
            KeyPrefix = "commonDataModel.pricediscsalesrecalculationpolicyentity";
            KeySeparator = ".";
            Grouping = "/PriceDiscSalesRecalculationPolicyEntity";

            AddGroup("PriceDiscSalesRecalculationPolicyEntity Details", group =>
            {
                TradeAgreementSourceType = group.Add(new VocabularyKey(nameof(TradeAgreementSourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TradeAgreementSourceType { get; private set; }
    }
}