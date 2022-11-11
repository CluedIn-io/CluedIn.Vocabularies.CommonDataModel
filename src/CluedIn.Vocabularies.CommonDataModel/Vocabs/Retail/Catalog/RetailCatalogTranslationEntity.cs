using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCatalogTranslationEntityVocabulary : SimpleVocabulary
    {
        public RetailCatalogTranslationEntityVocabulary()
        {
            VocabularyName = "RetailCatalogTranslationEntity";
            KeyPrefix = "commonDataModel.retailcatalogtranslationentity";
            KeySeparator = ".";
            Grouping = "/RetailCatalogTranslationEntity";

            AddGroup("RetailCatalogTranslationEntity Details", group =>
            {
                CatalogNumber = group.Add(new VocabularyKey(nameof(CatalogNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FriendlyName = group.Add(new VocabularyKey(nameof(FriendlyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Image = group.Add(new VocabularyKey(nameof(Image), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CatalogNumber { get; private set; }
        public VocabularyKey FriendlyName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey Image { get; private set; }


    }
}