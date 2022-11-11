using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendPaymentBIVendorCustomerBalanceEntityVocabulary : SimpleVocabulary
    {
        public VendPaymentBIVendorCustomerBalanceEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendPaymentBIVendorCustomerBalanceEntity";
            KeyPrefix = "commonDataModel.vendpaymentbivendorcustomerbalanceentity";
            KeySeparator = ".";
            Grouping = "/VendPaymentBIVendorCustomerBalanceEntity";

            AddGroup("Common Data Model VendPaymentBIVendorCustomerBalanceEntity Details", group =>
            {
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustAmountCur = group.Add(new VocabularyKey(nameof(CustAmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendAmountCur = group.Add(new VocabularyKey(nameof(VendAmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustAmountMST = group.Add(new VocabularyKey(nameof(CustAmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendAmountMST = group.Add(new VocabularyKey(nameof(VendAmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingCurrency = group.Add(new VocabularyKey(nameof(AccountingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustAmountSystem = group.Add(new VocabularyKey(nameof(CustAmountSystem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendAmountSystem = group.Add(new VocabularyKey(nameof(VendAmountSystem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemCurrencyCode = group.Add(new VocabularyKey(nameof(SystemCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustAccountNum = group.Add(new VocabularyKey(nameof(CustAccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyName = group.Add(new VocabularyKey(nameof(PartyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountNum { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Invoice { get; private set; }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey CustAmountCur { get; private set; }
        public VocabularyKey VendAmountCur { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CustAmountMST { get; private set; }
        public VocabularyKey VendAmountMST { get; private set; }
        public VocabularyKey AccountingCurrency { get; private set; }
        public VocabularyKey CustAmountSystem { get; private set; }
        public VocabularyKey VendAmountSystem { get; private set; }
        public VocabularyKey SystemCurrencyCode { get; private set; }
        public VocabularyKey CustAccountNum { get; private set; }
        public VocabularyKey PartyName { get; private set; }
        public VocabularyKey Company { get; private set; }


    }
}