using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FBFiscalDocumentAdjustmentCodeICMSTaxationCodesEntityVocabulary : SimpleVocabulary
    {
        public FBFiscalDocumentAdjustmentCodeICMSTaxationCodesEntityVocabulary()
        {
            VocabularyName = "Common Data Model FBFiscalDocumentAdjustmentCodeICMSTaxationCodesEntity";
            KeyPrefix = "commonDataModel.fbfiscaldocumentadjustmentcodeicmstaxationcodesentity";
            KeySeparator = ".";
            Grouping = "/FBFiscalDocumentAdjustmentCodeICMSTaxationCodesEntity";

            AddGroup("Common Data Model FBFiscalDocumentAdjustmentCodeICMSTaxationCodesEntity Details", group =>
            {
                SpedAdjustmentCode = group.Add(new VocabularyKey(nameof(SpedAdjustmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationCode = group.Add(new VocabularyKey(nameof(TaxationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SpedAdjustmentCode { get; private set; }
        public VocabularyKey TaxationCode { get; private set; }


    }
}