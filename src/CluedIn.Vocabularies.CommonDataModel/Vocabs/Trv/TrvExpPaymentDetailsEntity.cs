using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvExpPaymentDetailsEntityVocabulary : SimpleVocabulary
    {
        public TrvExpPaymentDetailsEntityVocabulary()
        {
            VocabularyName = "Trv Exp Payment Details Entity";
            KeyPrefix = "commonDataModel.trvexppaymentdetailsentity";
            KeySeparator = ".";
            Grouping = "/TrvExpPaymentDetailsEntity";

            AddGroup("TrvExpPaymentDetailsEntity Details", group =>
            {
                InvoiceId = group.Add(new VocabularyKey(nameof(InvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrvExpTable = group.Add(new VocabularyKey(nameof(TrvExpTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrvExpTrans = group.Add(new VocabularyKey(nameof(TrvExpTrans), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckNum = group.Add(new VocabularyKey(nameof(CheckNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentDate = group.Add(new VocabularyKey(nameof(PaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentVoucher = group.Add(new VocabularyKey(nameof(PaymentVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentStatus = group.Add(new VocabularyKey(nameof(PaymentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SentDataToExternalDate = group.Add(new VocabularyKey(nameof(SentDataToExternalDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpNumber = group.Add(new VocabularyKey(nameof(ExpNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrvExpTable_LegalEntity = group.Add(new VocabularyKey(nameof(TrvExpTable_LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpTransNumber = group.Add(new VocabularyKey(nameof(ExpTransNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey InvoiceId { get; private set; }
        public VocabularyKey TrvExpTable { get; private set; }
        public VocabularyKey TrvExpTrans { get; private set; }
        public VocabularyKey CheckNum { get; private set; }
        public VocabularyKey PaymentDate { get; private set; }
        public VocabularyKey PaymentVoucher { get; private set; }
        public VocabularyKey PaymentStatus { get; private set; }
        public VocabularyKey SentDataToExternalDate { get; private set; }
        public VocabularyKey ExpNumber { get; private set; }
        public VocabularyKey TrvExpTable_LegalEntity { get; private set; }
        public VocabularyKey ExpTransNumber { get; private set; }
    }
}