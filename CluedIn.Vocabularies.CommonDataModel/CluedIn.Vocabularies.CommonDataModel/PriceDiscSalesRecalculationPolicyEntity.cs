using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PriceDiscSalesRecalculationPolicyEntityVocabulary : SimpleVocabulary
    {
        public PriceDiscSalesRecalculationPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model PriceDiscSalesRecalculationPolicyEntity";
            KeyPrefix = "commonDataModel.pricediscsalesrecalculationpolicyentity";
            KeySeparator = ".";
            Grouping = "/PriceDiscSalesRecalculationPolicyEntity";

            AddGroup("Common Data Model PriceDiscSalesRecalculationPolicyEntity Details", group =>
            {
                TradeAgreementSourceType = group.Add(new VocabularyKey(nameof(TradeAgreementSourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TradeAgreementSourceType { get; private set; }


    }
}