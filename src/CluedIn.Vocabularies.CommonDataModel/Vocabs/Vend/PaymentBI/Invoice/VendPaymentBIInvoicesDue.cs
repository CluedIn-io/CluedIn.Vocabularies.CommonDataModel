using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendPaymentBIInvoicesDueVocabulary : SimpleVocabulary
    {
        public VendPaymentBIInvoicesDueVocabulary()
        {
            VocabularyName = "Common Data Model VendPaymentBIInvoicesDue";
            KeyPrefix = "commonDataModel.vendpaymentbiinvoicesdue";
            KeySeparator = ".";
            Grouping = "/VendPaymentBIInvoicesDue";

            AddGroup("Common Data Model VendPaymentBIInvoicesDue Details", group =>
            {
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DueDate = group.Add(new VocabularyKey(nameof(DueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountCur = group.Add(new VocabularyKey(nameof(AmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscAmountCur = group.Add(new VocabularyKey(nameof(CashDiscAmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountMST = group.Add(new VocabularyKey(nameof(AmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscAmountMST = group.Add(new VocabularyKey(nameof(CashDiscAmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingCurrency = group.Add(new VocabularyKey(nameof(AccountingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemCurrencyCode = group.Add(new VocabularyKey(nameof(SystemCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscDate = group.Add(new VocabularyKey(nameof(CashDiscDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentHoldDate = group.Add(new VocabularyKey(nameof(PaymentHoldDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorHold = group.Add(new VocabularyKey(nameof(VendorHold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorHoldReason = group.Add(new VocabularyKey(nameof(VendorHoldReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReleaseDateComment = group.Add(new VocabularyKey(nameof(ReleaseDateComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrentDate = group.Add(new VocabularyKey(nameof(CurrentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountNum { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Invoice { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey AmountCur { get; private set; }
        public VocabularyKey CashDiscAmountCur { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey AmountMST { get; private set; }
        public VocabularyKey CashDiscAmountMST { get; private set; }
        public VocabularyKey AccountingCurrency { get; private set; }
        public VocabularyKey SystemCurrencyCode { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey CashDiscDate { get; private set; }
        public VocabularyKey PaymentHoldDate { get; private set; }
        public VocabularyKey VendorHold { get; private set; }
        public VocabularyKey VendorHoldReason { get; private set; }
        public VocabularyKey ReleaseDateComment { get; private set; }
        public VocabularyKey CurrentDate { get; private set; }


    }
}