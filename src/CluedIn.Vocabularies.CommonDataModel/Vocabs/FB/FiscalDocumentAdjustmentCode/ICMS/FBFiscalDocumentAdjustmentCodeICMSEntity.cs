using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FBFiscalDocumentAdjustmentCodeICMSEntityVocabulary : SimpleVocabulary
    {
        public FBFiscalDocumentAdjustmentCodeICMSEntityVocabulary()
        {
            VocabularyName = "FBFiscalDocumentAdjustmentCodeICMSEntity";
            KeyPrefix = "commonDataModel.fbfiscaldocumentadjustmentcodeicmsentity";
            KeySeparator = ".";
            Grouping = "/FBFiscalDocumentAdjustmentCodeICMSEntity";

            AddGroup("FBFiscalDocumentAdjustmentCodeICMSEntity Details", group =>
            {
                AdjustmentCode = group.Add(new VocabularyKey(nameof(AdjustmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Table52 = group.Add(new VocabularyKey(nameof(Table52), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Classification = group.Add(new VocabularyKey(nameof(Classification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssessmentType = group.Add(new VocabularyKey(nameof(AssessmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Responsibility = group.Add(new VocabularyKey(nameof(Responsibility), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxPaymentType = group.Add(new VocabularyKey(nameof(TaxPaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceTax = group.Add(new VocabularyKey(nameof(SourceTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OccurrenceCode = group.Add(new VocabularyKey(nameof(OccurrenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpedAdjustmentCode = group.Add(new VocabularyKey(nameof(SpedAdjustmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GIAAdjustmentCode = group.Add(new VocabularyKey(nameof(GIAAdjustmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPovertyFund = group.Add(new VocabularyKey(nameof(IsPovertyFund), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFromDate = group.Add(new VocabularyKey(nameof(ValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidToDate = group.Add(new VocabularyKey(nameof(ValidToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OtherDebit = group.Add(new VocabularyKey(nameof(OtherDebit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceitaCode = group.Add(new VocabularyKey(nameof(ReceitaCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeOfBenefitCode = group.Add(new VocabularyKey(nameof(TypeOfBenefitCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AdjustmentCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey TaxType { get; private set; }
        public VocabularyKey Table52 { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey Classification { get; private set; }
        public VocabularyKey AssessmentType { get; private set; }
        public VocabularyKey Responsibility { get; private set; }
        public VocabularyKey TaxPaymentType { get; private set; }
        public VocabularyKey SourceTax { get; private set; }
        public VocabularyKey OccurrenceCode { get; private set; }
        public VocabularyKey SpedAdjustmentCode { get; private set; }
        public VocabularyKey GIAAdjustmentCode { get; private set; }
        public VocabularyKey IsPovertyFund { get; private set; }
        public VocabularyKey ValidFromDate { get; private set; }
        public VocabularyKey ValidToDate { get; private set; }
        public VocabularyKey OtherDebit { get; private set; }
        public VocabularyKey ReceitaCode { get; private set; }
        public VocabularyKey TypeOfBenefitCode { get; private set; }


    }
}