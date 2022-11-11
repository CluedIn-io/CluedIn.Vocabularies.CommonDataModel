using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInformationSubcodeTranslationEntityVocabulary : SimpleVocabulary
    {
        public RetailInformationSubcodeTranslationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailInformationSubcodeTranslationEntity";
            KeyPrefix = "commonDataModel.retailinformationsubcodetranslationentity";
            KeySeparator = ".";
            Grouping = "/RetailInformationSubcodeTranslationEntity";

            AddGroup("Common Data Model RetailInformationSubcodeTranslationEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InfocodeId = group.Add(new VocabularyKey(nameof(InfocodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubcodeId = group.Add(new VocabularyKey(nameof(SubcodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InfoSubcodeRecId = group.Add(new VocabularyKey(nameof(InfoSubcodeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey InfocodeId { get; private set; }
        public VocabularyKey SubcodeId { get; private set; }
        public VocabularyKey InfoSubcodeRecId { get; private set; }


    }
}