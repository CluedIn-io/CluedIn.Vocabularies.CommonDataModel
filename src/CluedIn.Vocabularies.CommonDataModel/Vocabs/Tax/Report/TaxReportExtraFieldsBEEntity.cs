using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxReportExtraFieldsBEEntityVocabulary : SimpleVocabulary
    {
        public TaxReportExtraFieldsBEEntityVocabulary()
        {
            VocabularyName = "TaxReportExtraFieldsBEEntity";
            KeyPrefix = "commonDataModel.taxreportextrafieldsbeentity";
            KeySeparator = ".";
            Grouping = "/TaxReportExtraFieldsBEEntity";

            AddGroup("TaxReportExtraFieldsBEEntity Details", group =>
            {
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentFormOrder = group.Add(new VocabularyKey(nameof(PaymentFormOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NihilAnnualListing = group.Add(new VocabularyKey(nameof(NihilAnnualListing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestsRepayments = group.Add(new VocabularyKey(nameof(RequestsRepayments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxPeriod = group.Add(new VocabularyKey(nameof(TaxPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATDisbursement = group.Add(new VocabularyKey(nameof(VATDisbursement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey PaymentFormOrder { get; private set; }
        public VocabularyKey NihilAnnualListing { get; private set; }
        public VocabularyKey RequestsRepayments { get; private set; }
        public VocabularyKey TaxPeriod { get; private set; }
        public VocabularyKey VATDisbursement { get; private set; }
        public VocabularyKey TransDate { get; private set; }


    }
}