using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendPaymentBIInvoiceVocabulary : SimpleVocabulary
    {
        public VendPaymentBIInvoiceVocabulary()
        {
            VocabularyName = "Vend Payment BI Invoice";
            KeyPrefix = "commonDataModel.vendpaymentbiinvoice";
            KeySeparator = ".";
            Grouping = "/VendPaymentBIInvoice";

            AddGroup("VendPaymentBIInvoice Details", group =>
            {
                CashDisc = group.Add(new VocabularyKey(nameof(CashDisc), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerVoucher = group.Add(new VocabularyKey(nameof(LedgerVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAccount = group.Add(new VocabularyKey(nameof(InvoiceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CashDisc { get; private set; }
        public VocabularyKey LedgerVoucher { get; private set; }
        public VocabularyKey InvoiceAccount { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
    }
}