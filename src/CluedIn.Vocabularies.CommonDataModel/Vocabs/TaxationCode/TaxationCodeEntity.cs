using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxationCodeEntityVocabulary : SimpleVocabulary
    {
        public TaxationCodeEntityVocabulary()
        {
            VocabularyName = "TaxationCodeEntity";
            KeyPrefix = "commonDataModel.taxationcodeentity";
            KeySeparator = ".";
            Grouping = "/TaxationCodeEntity";

            AddGroup("TaxationCodeEntity Details", group =>
            {
                SpedCode = group.Add(new VocabularyKey(nameof(SpedCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalValue = group.Add(new VocabularyKey(nameof(FiscalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InputCode = group.Add(new VocabularyKey(nameof(InputCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutputCode = group.Add(new VocabularyKey(nameof(OutputCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationCode = group.Add(new VocabularyKey(nameof(TaxationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SpedCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey FiscalValue { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey InputCode { get; private set; }
        public VocabularyKey OutputCode { get; private set; }
        public VocabularyKey TaxationCode { get; private set; }
        public VocabularyKey TaxType { get; private set; }
        public VocabularyKey ToDate { get; private set; }


    }
}