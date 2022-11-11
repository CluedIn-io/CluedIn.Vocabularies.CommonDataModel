using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalDocumentTaxTransEntityVocabulary : SimpleVocabulary
    {
        public FiscalDocumentTaxTransEntityVocabulary()
        {
            VocabularyName = "FiscalDocumentTaxTransEntity";
            KeyPrefix = "commonDataModel.fiscaldocumenttaxtransentity";
            KeySeparator = ".";
            Grouping = "/FiscalDocumentTaxTransEntity";

            AddGroup("FiscalDocumentTaxTransEntity Details", group =>
            {
                FiscalDocumentDirection = group.Add(new VocabularyKey(nameof(FiscalDocumentDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentFiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalDocumentFiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentLine = group.Add(new VocabularyKey(nameof(FiscalDocumentLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentLineNumber = group.Add(new VocabularyKey(nameof(FiscalDocumentLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentNumber = group.Add(new VocabularyKey(nameof(FiscalDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentSeries = group.Add(new VocabularyKey(nameof(FiscalDocumentSeries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentStatus = group.Add(new VocabularyKey(nameof(FiscalDocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentThirdPartyCNPJorCPF = group.Add(new VocabularyKey(nameof(FiscalDocumentThirdPartyCNPJorCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentVoucher = group.Add(new VocabularyKey(nameof(FiscalDocumentVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalValue = group.Add(new VocabularyKey(nameof(FiscalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncludedTax = group.Add(new VocabularyKey(nameof(IncludedTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetainedTax = group.Add(new VocabularyKey(nameof(RetainedTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmount = group.Add(new VocabularyKey(nameof(TaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmountOther = group.Add(new VocabularyKey(nameof(TaxAmountOther), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationCode = group.Add(new VocabularyKey(nameof(TaxationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationOrigin = group.Add(new VocabularyKey(nameof(TaxationOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxBaseAmount = group.Add(new VocabularyKey(nameof(TaxBaseAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxBaseAmountExempt = group.Add(new VocabularyKey(nameof(TaxBaseAmountExempt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxBaseAmountOther = group.Add(new VocabularyKey(nameof(TaxBaseAmountOther), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptCode = group.Add(new VocabularyKey(nameof(TaxExemptCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxNonRecoverablePct = group.Add(new VocabularyKey(nameof(TaxNonRecoverablePct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxPovertyFundAmount = group.Add(new VocabularyKey(nameof(TaxPovertyFundAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxPovertyFundPercentage = group.Add(new VocabularyKey(nameof(TaxPovertyFundPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxReductionPct = group.Add(new VocabularyKey(nameof(TaxReductionPct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxSubstitutionMarkupPct = group.Add(new VocabularyKey(nameof(TaxSubstitutionMarkupPct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxValue = group.Add(new VocabularyKey(nameof(TaxValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FiscalDocumentDirection { get; private set; }
        public VocabularyKey FiscalDocumentFiscalEstablishmentId { get; private set; }
        public VocabularyKey FiscalDocumentLine { get; private set; }
        public VocabularyKey FiscalDocumentLineNumber { get; private set; }
        public VocabularyKey FiscalDocumentNumber { get; private set; }
        public VocabularyKey FiscalDocumentSeries { get; private set; }
        public VocabularyKey FiscalDocumentStatus { get; private set; }
        public VocabularyKey FiscalDocumentThirdPartyCNPJorCPF { get; private set; }
        public VocabularyKey FiscalDocumentVoucher { get; private set; }
        public VocabularyKey FiscalValue { get; private set; }
        public VocabularyKey IncludedTax { get; private set; }
        public VocabularyKey RetainedTax { get; private set; }
        public VocabularyKey TaxAmount { get; private set; }
        public VocabularyKey TaxAmountOther { get; private set; }
        public VocabularyKey TaxationCode { get; private set; }
        public VocabularyKey TaxationOrigin { get; private set; }
        public VocabularyKey TaxBaseAmount { get; private set; }
        public VocabularyKey TaxBaseAmountExempt { get; private set; }
        public VocabularyKey TaxBaseAmountOther { get; private set; }
        public VocabularyKey TaxExemptCode { get; private set; }
        public VocabularyKey TaxNonRecoverablePct { get; private set; }
        public VocabularyKey TaxPovertyFundAmount { get; private set; }
        public VocabularyKey TaxPovertyFundPercentage { get; private set; }
        public VocabularyKey TaxReductionPct { get; private set; }
        public VocabularyKey TaxSubstitutionMarkupPct { get; private set; }
        public VocabularyKey TaxValue { get; private set; }
        public VocabularyKey Type { get; private set; }


    }
}