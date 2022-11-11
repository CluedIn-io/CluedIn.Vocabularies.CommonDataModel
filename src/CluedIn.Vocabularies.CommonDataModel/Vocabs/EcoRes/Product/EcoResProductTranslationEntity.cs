using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductTranslationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductTranslationEntityVocabulary()
        {
            VocabularyName = "EcoResProductTranslationEntity";
            KeyPrefix = "commonDataModel.ecoresproducttranslationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductTranslationEntity";

            AddGroup("EcoResProductTranslationEntity Details", group =>
            {
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}