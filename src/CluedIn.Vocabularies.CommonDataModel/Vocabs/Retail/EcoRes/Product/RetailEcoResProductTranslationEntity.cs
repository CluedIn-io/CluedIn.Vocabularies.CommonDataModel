using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailEcoResProductTranslationEntityVocabulary : SimpleVocabulary
    {
        public RetailEcoResProductTranslationEntityVocabulary()
        {
            VocabularyName = "Retail Eco Res Product Translation Entity";
            KeyPrefix = "commonDataModel.retailecoresproducttranslationentity";
            KeySeparator = ".";
            Grouping = "/RetailEcoResProductTranslationEntity";

            AddGroup("RetailEcoResProductTranslationEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Product = group.Add(new VocabularyKey(nameof(Product), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EcoResProduct_DisplayProductNumber = group.Add(new VocabularyKey(nameof(EcoResProduct_DisplayProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Product { get; private set; }
        public VocabularyKey EcoResProduct_DisplayProductNumber { get; private set; }
    }
}