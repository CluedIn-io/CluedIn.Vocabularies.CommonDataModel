using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInfocodeTranslationEntityVocabulary : SimpleVocabulary
    {
        public RetailInfocodeTranslationEntityVocabulary()
        {
            VocabularyName = "RetailInfocodeTranslationEntity";
            KeyPrefix = "commonDataModel.retailinfocodetranslationentity";
            KeySeparator = ".";
            Grouping = "/RetailInfocodeTranslationEntity";

            AddGroup("RetailInfocodeTranslationEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Prompt = group.Add(new VocabularyKey(nameof(Prompt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailInfocodeTable_infocodeId = group.Add(new VocabularyKey(nameof(RetailInfocodeTable_infocodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey Prompt { get; private set; }
        public VocabularyKey RetailInfocodeTable_infocodeId { get; private set; }


    }
}