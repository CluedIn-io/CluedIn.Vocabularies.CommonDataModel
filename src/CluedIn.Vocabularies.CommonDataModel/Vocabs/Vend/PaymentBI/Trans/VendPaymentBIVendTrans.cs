using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendPaymentBIVendTransVocabulary : SimpleVocabulary
    {
        public VendPaymentBIVendTransVocabulary()
        {
            VocabularyName = "VendPaymentBIVendTrans";
            KeyPrefix = "commonDataModel.vendpaymentbivendtrans";
            KeySeparator = ".";
            Grouping = "/VendPaymentBIVendTrans";

            AddGroup("VendPaymentBIVendTrans Details", group =>
            {
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountMST = group.Add(new VocabularyKey(nameof(AmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransType = group.Add(new VocabularyKey(nameof(TransType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Closed = group.Add(new VocabularyKey(nameof(Closed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DueDate = group.Add(new VocabularyKey(nameof(DueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastSettleDate = group.Add(new VocabularyKey(nameof(LastSettleDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountCur = group.Add(new VocabularyKey(nameof(AmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceReleaseDate = group.Add(new VocabularyKey(nameof(InvoiceReleaseDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountNum { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey Invoice { get; private set; }
        public VocabularyKey AmountMST { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey TransType { get; private set; }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey Closed { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey LastSettleDate { get; private set; }
        public VocabularyKey AmountCur { get; private set; }
        public VocabularyKey InvoiceReleaseDate { get; private set; }


    }
}