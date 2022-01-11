using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PriceDiscPurchaseRecalculationPolicyEntityVocabulary : SimpleVocabulary
    {
        public PriceDiscPurchaseRecalculationPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model PriceDiscPurchaseRecalculationPolicyEntity";
            KeyPrefix = "commonDataModel.pricediscpurchaserecalculationpolicyentity";
            KeySeparator = ".";
            Grouping = "/PriceDiscPurchaseRecalculationPolicyEntity";

            AddGroup("Common Data Model PriceDiscPurchaseRecalculationPolicyEntity Details", group =>
            {
                TradeAgreementSourceType = group.Add(new VocabularyKey(nameof(TradeAgreementSourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TradeAgreementSourceType { get; private set; }


    }
}