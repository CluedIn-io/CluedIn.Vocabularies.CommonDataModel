using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductAttributeTranslationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductAttributeTranslationEntityVocabulary()
        {
            VocabularyName = "EcoResProductAttributeTranslationEntity";
            KeyPrefix = "commonDataModel.ecoresproductattributetranslationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductAttributeTranslationEntity";

            AddGroup("EcoResProductAttributeTranslationEntity Details", group =>
            {
                ProductAttributeId = group.Add(new VocabularyKey(nameof(ProductAttributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductAttributeTypeName = group.Add(new VocabularyKey(nameof(ProductAttributeTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductAttributeName = group.Add(new VocabularyKey(nameof(ProductAttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedAttributeDescription = group.Add(new VocabularyKey(nameof(TranslatedAttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedFriendlyAttributeName = group.Add(new VocabularyKey(nameof(TranslatedFriendlyAttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedAttributeHelpText = group.Add(new VocabularyKey(nameof(TranslatedAttributeHelpText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductAttributeId { get; private set; }
        public VocabularyKey ProductAttributeTypeName { get; private set; }
        public VocabularyKey ProductAttributeName { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey TranslatedAttributeDescription { get; private set; }
        public VocabularyKey TranslatedFriendlyAttributeName { get; private set; }
        public VocabularyKey TranslatedAttributeHelpText { get; private set; }


    }
}