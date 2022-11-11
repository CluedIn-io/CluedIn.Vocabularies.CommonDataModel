using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxAllowedExemptCodesForIPIEntityVocabulary : SimpleVocabulary
    {
        public TaxAllowedExemptCodesForIPIEntityVocabulary()
        {
            VocabularyName = "TaxAllowedExemptCodesForIPIEntity";
            KeyPrefix = "commonDataModel.taxallowedexemptcodesforipientity";
            KeySeparator = ".";
            Grouping = "/TaxAllowedExemptCodesForIPIEntity";

            AddGroup("TaxAllowedExemptCodesForIPIEntity Details", group =>
            {
                ExemptCode = group.Add(new VocabularyKey(nameof(ExemptCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationCode = group.Add(new VocabularyKey(nameof(TaxationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalValue = group.Add(new VocabularyKey(nameof(FiscalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationCodeRecId = group.Add(new VocabularyKey(nameof(TaxationCodeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ExemptCode { get; private set; }
        public VocabularyKey TaxationCode { get; private set; }
        public VocabularyKey FiscalValue { get; private set; }
        public VocabularyKey TaxationCodeRecId { get; private set; }


    }
}