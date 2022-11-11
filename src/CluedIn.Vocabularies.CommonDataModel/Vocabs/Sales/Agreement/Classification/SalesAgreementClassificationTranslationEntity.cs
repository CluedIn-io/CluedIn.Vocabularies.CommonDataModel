using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesAgreementClassificationTranslationEntityVocabulary : SimpleVocabulary
    {
        public SalesAgreementClassificationTranslationEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesAgreementClassificationTranslationEntity";
            KeyPrefix = "commonDataModel.salesagreementclassificationtranslationentity";
            KeySeparator = ".";
            Grouping = "/SalesAgreementClassificationTranslationEntity";

            AddGroup("Common Data Model SalesAgreementClassificationTranslationEntity Details", group =>
            {
                SalesAgreementClassificationName = group.Add(new VocabularyKey(nameof(SalesAgreementClassificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedClassificationDescription = group.Add(new VocabularyKey(nameof(TranslatedClassificationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SalesAgreementClassificationName { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey TranslatedClassificationDescription { get; private set; }


    }
}