using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendPaymentBIInvoicesPaidVocabulary : SimpleVocabulary
    {
        public VendPaymentBIInvoicesPaidVocabulary()
        {
            VocabularyName = "Common Data Model VendPaymentBIInvoicesPaid";
            KeyPrefix = "commonDataModel.vendpaymentbiinvoicespaid";
            KeySeparator = ".";
            Grouping = "/VendPaymentBIInvoicesPaid";

            AddGroup("Common Data Model VendPaymentBIInvoicesPaid Details", group =>
            {
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingCurrency = group.Add(new VocabularyKey(nameof(AccountingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SystemCurrencyCode = group.Add(new VocabularyKey(nameof(SystemCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountTakenCur = group.Add(new VocabularyKey(nameof(DiscountTakenCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountLostCur = group.Add(new VocabularyKey(nameof(DiscountLostCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountTakenMST = group.Add(new VocabularyKey(nameof(DiscountTakenMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountLostMST = group.Add(new VocabularyKey(nameof(DiscountLostMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LastSettleDate = group.Add(new VocabularyKey(nameof(LastSettleDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountPaidLateCur = group.Add(new VocabularyKey(nameof(AmountPaidLateCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountPaidLateMST = group.Add(new VocabularyKey(nameof(AmountPaidLateMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountPaidOnTimeCur = group.Add(new VocabularyKey(nameof(AmountPaidOnTimeCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountPaidOnTimeMST = group.Add(new VocabularyKey(nameof(AmountPaidOnTimeMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountNum { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Invoice { get; private set; }
public VocabularyKey DocumentDate { get; private set; }
public VocabularyKey TransDate { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey AccountingCurrency { get; private set; }
public VocabularyKey SystemCurrencyCode { get; private set; }
public VocabularyKey Company { get; private set; }
public VocabularyKey DiscountTakenCur { get; private set; }
public VocabularyKey DiscountLostCur { get; private set; }
public VocabularyKey DiscountTakenMST { get; private set; }
public VocabularyKey DiscountLostMST { get; private set; }
public VocabularyKey LastSettleDate { get; private set; }
public VocabularyKey AmountPaidLateCur { get; private set; }
public VocabularyKey AmountPaidLateMST { get; private set; }
public VocabularyKey AmountPaidOnTimeCur { get; private set; }
public VocabularyKey AmountPaidOnTimeMST { get; private set; }


    }
}