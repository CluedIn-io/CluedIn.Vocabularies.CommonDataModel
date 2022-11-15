using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PriceDiscPurchaseRecalculationPolicyEntityVocabulary : SimpleVocabulary
    {
        public PriceDiscPurchaseRecalculationPolicyEntityVocabulary()
        {
            VocabularyName = "Price Disc Purchase Recalculation Policy Entity";
            KeyPrefix = "commonDataModel.pricediscpurchaserecalculationpolicyentity";
            KeySeparator = ".";
            Grouping = "/PriceDiscPurchaseRecalculationPolicyEntity";

            AddGroup("PriceDiscPurchaseRecalculationPolicyEntity Details", group =>
            {
                TradeAgreementSourceType = group.Add(new VocabularyKey(nameof(TradeAgreementSourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TradeAgreementSourceType { get; private set; }
    }
}