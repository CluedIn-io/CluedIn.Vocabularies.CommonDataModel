using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxationCodeSetupEntityVocabulary : SimpleVocabulary
    {
        public TaxationCodeSetupEntityVocabulary()
        {
            VocabularyName = "Taxation Code Setup Entity";
            KeyPrefix = "commonDataModel.taxationcodesetupentity";
            KeySeparator = ".";
            Grouping = "/TaxationCodeSetupEntity";

            AddGroup("TaxationCodeSetupEntity Details", group =>
            {
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Mandatory = group.Add(new VocabularyKey(nameof(Mandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TaxType { get; private set; }
        public VocabularyKey Mandatory { get; private set; }
    }
}