using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FBFiscalDocumentAdjustmentCodeLedgerEntityVocabulary : SimpleVocabulary
    {
        public FBFiscalDocumentAdjustmentCodeLedgerEntityVocabulary()
        {
            VocabularyName = "FB Fiscal Document Adjustment Code Ledger Entity";
            KeyPrefix = "commonDataModel.fbfiscaldocumentadjustmentcodeledgerentity";
            KeySeparator = ".";
            Grouping = "/FBFiscalDocumentAdjustmentCodeLedgerEntity";

            AddGroup("FBFiscalDocumentAdjustmentCodeLedgerEntity Details", group =>
            {
                FBFiscalDocumentAdjustmentCodeRecId = group.Add(new VocabularyKey(nameof(FBFiscalDocumentAdjustmentCodeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FBFiscalDocumentAdjustmentCodeIdentification = group.Add(new VocabularyKey(nameof(FBFiscalDocumentAdjustmentCodeIdentification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCode = group.Add(new VocabularyKey(nameof(TaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimension = group.Add(new VocabularyKey(nameof(LedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FBFiscalDocumentAdjustmentCodeRecId { get; private set; }
        public VocabularyKey FBFiscalDocumentAdjustmentCodeIdentification { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey TaxCode { get; private set; }
        public VocabularyKey LedgerDimension { get; private set; }
        public VocabularyKey LedgerDimensionDisplayValue { get; private set; }
    }
}