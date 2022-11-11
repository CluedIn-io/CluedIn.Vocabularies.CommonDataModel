using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailAffiliationTranslationEntityVocabulary : SimpleVocabulary
    {
        public RetailAffiliationTranslationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailAffiliationTranslationEntity";
            KeyPrefix = "commonDataModel.retailaffiliationtranslationentity";
            KeySeparator = ".";
            Grouping = "/RetailAffiliationTranslationEntity";

            AddGroup("Common Data Model RetailAffiliationTranslationEntity Details", group =>
            {
                Affiliation = group.Add(new VocabularyKey(nameof(Affiliation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AffiliationName = group.Add(new VocabularyKey(nameof(AffiliationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Affiliation { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey AffiliationName { get; private set; }


    }
}