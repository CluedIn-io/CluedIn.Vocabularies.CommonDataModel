using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdReportVoucherEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdReportVoucherEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxWithholdReportVoucherEntity";
            KeyPrefix = "commonDataModel.taxwithholdreportvoucherentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdReportVoucherEntity";

            AddGroup("Common Data Model TaxWithholdReportVoucherEntity Details", group =>
            {
                PostedWithholdingTaxCorrections = group.Add(new VocabularyKey(nameof(PostedWithholdingTaxCorrections), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxPaymentVersion = group.Add(new VocabularyKey(nameof(WithholdingTaxPaymentVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceFromDate = group.Add(new VocabularyKey(nameof(ReferenceFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceToDate = group.Add(new VocabularyKey(nameof(ReferenceToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceSattlementPeriod = group.Add(new VocabularyKey(nameof(ReferenceSattlementPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PostedWithholdingTaxCorrections { get; private set; }
        public VocabularyKey WithholdingTaxPaymentVersion { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey ReferenceFromDate { get; private set; }
        public VocabularyKey ReferenceToDate { get; private set; }
        public VocabularyKey ReferenceSattlementPeriod { get; private set; }


    }
}