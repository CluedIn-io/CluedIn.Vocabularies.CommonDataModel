using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMTradeAllowanceAgreementMerchandisingEventDiscountEntityVocabulary : SimpleVocabulary
    {
        public TAMTradeAllowanceAgreementMerchandisingEventDiscountEntityVocabulary()
        {
            VocabularyName = "Common Data Model TAMTradeAllowanceAgreementMerchandisingEventDiscountEntity";
            KeyPrefix = "commonDataModel.tamtradeallowanceagreementmerchandisingeventdiscountentity";
            KeySeparator = ".";
            Grouping = "/TAMTradeAllowanceAgreementMerchandisingEventDiscountEntity";

            AddGroup("Common Data Model TAMTradeAllowanceAgreementMerchandisingEventDiscountEntity Details", group =>
            {
                LIneDiscountAmount = group.Add(new VocabularyKey(nameof(LIneDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDiscountPercentage = group.Add(new VocabularyKey(nameof(LineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromQuantity = group.Add(new VocabularyKey(nameof(FromQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToQuantity = group.Add(new VocabularyKey(nameof(ToQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillAnalyticsIncludeDiscount = group.Add(new VocabularyKey(nameof(WillAnalyticsIncludeDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountLineNumber = group.Add(new VocabularyKey(nameof(DiscountLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TradeAllowanceAgreementMerchandisingEventId = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementMerchandisingEventId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TradeAllowanceAgreementId = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LIneDiscountAmount { get; private set; }
public VocabularyKey LineDiscountPercentage { get; private set; }
public VocabularyKey FromQuantity { get; private set; }
public VocabularyKey ToQuantity { get; private set; }
public VocabularyKey WillAnalyticsIncludeDiscount { get; private set; }
public VocabularyKey DiscountLineNumber { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }
public VocabularyKey TradeAllowanceAgreementMerchandisingEventId { get; private set; }
public VocabularyKey TradeAllowanceAgreementId { get; private set; }


    }
}