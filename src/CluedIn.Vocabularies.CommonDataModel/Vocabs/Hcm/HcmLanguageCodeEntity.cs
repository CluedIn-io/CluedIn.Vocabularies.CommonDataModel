using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmLanguageCodeEntityVocabulary : SimpleVocabulary
    {
        public HcmLanguageCodeEntityVocabulary()
        {
            VocabularyName = "Hcm Language Code Entity";
            KeyPrefix = "commonDataModel.hcmlanguagecodeentity";
            KeySeparator = ".";
            Grouping = "/HcmLanguageCodeEntity";

            AddGroup("HcmLanguageCodeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageCodeId = group.Add(new VocabularyKey(nameof(LanguageCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LanguageCodeId { get; private set; }
    }
}