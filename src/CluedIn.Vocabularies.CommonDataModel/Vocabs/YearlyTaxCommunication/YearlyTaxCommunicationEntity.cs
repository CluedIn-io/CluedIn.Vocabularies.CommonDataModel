using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class YearlyTaxCommunicationEntityVocabulary : SimpleVocabulary
    {
        public YearlyTaxCommunicationEntityVocabulary()
        {
            VocabularyName = "YearlyTaxCommunicationEntity";
            KeyPrefix = "commonDataModel.yearlytaxcommunicationentity";
            KeySeparator = ".";
            Grouping = "/YearlyTaxCommunicationEntity";

            AddGroup("YearlyTaxCommunicationEntity Details", group =>
            {
                ATECOFINCode = group.Add(new VocabularyKey(nameof(ATECOFINCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateOfExport = group.Add(new VocabularyKey(nameof(DateOfExport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Exported = group.Add(new VocabularyKey(nameof(Exported), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExportFileName = group.Add(new VocabularyKey(nameof(ExportFileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCommunicationID = group.Add(new VocabularyKey(nameof(TaxCommunicationID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Years = group.Add(new VocabularyKey(nameof(Years), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ATECOFINCode { get; private set; }
        public VocabularyKey DateOfExport { get; private set; }
        public VocabularyKey Exported { get; private set; }
        public VocabularyKey ExportFileName { get; private set; }
        public VocabularyKey TaxCommunicationID { get; private set; }
        public VocabularyKey Years { get; private set; }


    }
}