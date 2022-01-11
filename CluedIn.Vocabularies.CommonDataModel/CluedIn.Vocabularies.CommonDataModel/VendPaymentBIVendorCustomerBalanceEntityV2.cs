using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendPaymentBIVendorCustomerBalanceEntityV2Vocabulary : SimpleVocabulary
    {
        public VendPaymentBIVendorCustomerBalanceEntityV2Vocabulary()
        {
            VocabularyName = "Common Data Model VendPaymentBIVendorCustomerBalanceEntityV2";
            KeyPrefix = "commonDataModel.vendpaymentbivendorcustomerbalanceentityv2";
            KeySeparator = ".";
            Grouping = "/VendPaymentBIVendorCustomerBalanceEntityV2";

            AddGroup("Common Data Model VendPaymentBIVendorCustomerBalanceEntityV2 Details", group =>
            {
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Party = group.Add(new VocabularyKey(nameof(Party), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalCustAmountCur = group.Add(new VocabularyKey(nameof(TotalCustAmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalVendAmountCur = group.Add(new VocabularyKey(nameof(TotalVendAmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalCustAmountMST = group.Add(new VocabularyKey(nameof(TotalCustAmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalVendAmountMST = group.Add(new VocabularyKey(nameof(TotalVendAmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingCurrency = group.Add(new VocabularyKey(nameof(AccountingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalCustAmountSystem = group.Add(new VocabularyKey(nameof(TotalCustAmountSystem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalVendAmountSystem = group.Add(new VocabularyKey(nameof(TotalVendAmountSystem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SystemCurrencyCode = group.Add(new VocabularyKey(nameof(SystemCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustAccountNum = group.Add(new VocabularyKey(nameof(CustAccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PartyName = group.Add(new VocabularyKey(nameof(PartyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountNum { get; private set; }
public VocabularyKey Party { get; private set; }
public VocabularyKey TotalCustAmountCur { get; private set; }
public VocabularyKey TotalVendAmountCur { get; private set; }
public VocabularyKey TotalCustAmountMST { get; private set; }
public VocabularyKey TotalVendAmountMST { get; private set; }
public VocabularyKey AccountingCurrency { get; private set; }
public VocabularyKey TotalCustAmountSystem { get; private set; }
public VocabularyKey TotalVendAmountSystem { get; private set; }
public VocabularyKey SystemCurrencyCode { get; private set; }
public VocabularyKey CustAccountNum { get; private set; }
public VocabularyKey PartyName { get; private set; }
public VocabularyKey Company { get; private set; }


    }
}