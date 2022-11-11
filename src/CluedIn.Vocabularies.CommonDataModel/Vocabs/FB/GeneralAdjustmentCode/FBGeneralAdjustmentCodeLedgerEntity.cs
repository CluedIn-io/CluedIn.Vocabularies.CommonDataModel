using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FBGeneralAdjustmentCodeLedgerEntityVocabulary : SimpleVocabulary
    {
        public FBGeneralAdjustmentCodeLedgerEntityVocabulary()
        {
            VocabularyName = "FBGeneralAdjustmentCodeLedgerEntity";
            KeyPrefix = "commonDataModel.fbgeneraladjustmentcodeledgerentity";
            KeySeparator = ".";
            Grouping = "/FBGeneralAdjustmentCodeLedgerEntity";

            AddGroup("FBGeneralAdjustmentCodeLedgerEntity Details", group =>
            {
                FBGeneralAdjustmentCodeRecId = group.Add(new VocabularyKey(nameof(FBGeneralAdjustmentCodeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FBGeneralAdjustmentCodeIdentification = group.Add(new VocabularyKey(nameof(FBGeneralAdjustmentCodeIdentification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCode = group.Add(new VocabularyKey(nameof(TaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimension = group.Add(new VocabularyKey(nameof(LedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FBGeneralAdjustmentCodeRecId { get; private set; }
        public VocabularyKey FBGeneralAdjustmentCodeIdentification { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey TaxCode { get; private set; }
        public VocabularyKey LedgerDimension { get; private set; }
        public VocabularyKey LedgerDimensionDisplayValue { get; private set; }


    }
}