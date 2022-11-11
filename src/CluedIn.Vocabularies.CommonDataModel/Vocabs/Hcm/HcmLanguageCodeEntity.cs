using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmLanguageCodeEntityVocabulary : SimpleVocabulary
    {
        public HcmLanguageCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmLanguageCodeEntity";
            KeyPrefix = "commonDataModel.hcmlanguagecodeentity";
            KeySeparator = ".";
            Grouping = "/HcmLanguageCodeEntity";

            AddGroup("Common Data Model HcmLanguageCodeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageCodeId = group.Add(new VocabularyKey(nameof(LanguageCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey LanguageCodeId { get; private set; }


    }
}