using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendPaymentBITransactionToAccountingExchRateVocabulary : SimpleVocabulary
    {
        public VendPaymentBITransactionToAccountingExchRateVocabulary()
        {
            VocabularyName = "Common Data Model VendPaymentBITransactionToAccountingExchRate";
            KeyPrefix = "commonDataModel.vendpaymentbitransactiontoaccountingexchrate";
            KeySeparator = ".";
            Grouping = "/VendPaymentBITransactionToAccountingExchRate";

            AddGroup("Common Data Model VendPaymentBITransactionToAccountingExchRate Details", group =>
            {
                CrossRate = group.Add(new VocabularyKey(nameof(CrossRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromCurrencyCode = group.Add(new VocabularyKey(nameof(FromCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToCurrencyCode = group.Add(new VocabularyKey(nameof(ToCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CrossRate { get; private set; }
public VocabularyKey FromCurrencyCode { get; private set; }
public VocabularyKey Company { get; private set; }
public VocabularyKey ToCurrencyCode { get; private set; }


    }
}