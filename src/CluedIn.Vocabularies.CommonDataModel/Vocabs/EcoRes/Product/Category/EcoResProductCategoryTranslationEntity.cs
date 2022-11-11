using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductCategoryTranslationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductCategoryTranslationEntityVocabulary()
        {
            VocabularyName = "EcoResProductCategoryTranslationEntity";
            KeyPrefix = "commonDataModel.ecoresproductcategorytranslationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductCategoryTranslationEntity";

            AddGroup("EcoResProductCategoryTranslationEntity Details", group =>
            {
                ProductCategoryHierarchyId = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryId = group.Add(new VocabularyKey(nameof(ProductCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedCategoryDescription = group.Add(new VocabularyKey(nameof(TranslatedCategoryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedFriendlyCategoryName = group.Add(new VocabularyKey(nameof(TranslatedFriendlyCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedCategoryKeywords = group.Add(new VocabularyKey(nameof(TranslatedCategoryKeywords), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductCategoryHierarchyId { get; private set; }
        public VocabularyKey ProductCategoryId { get; private set; }
        public VocabularyKey ProductCategoryHierarchyName { get; private set; }
        public VocabularyKey ProductCategoryName { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey TranslatedCategoryDescription { get; private set; }
        public VocabularyKey TranslatedFriendlyCategoryName { get; private set; }
        public VocabularyKey TranslatedCategoryKeywords { get; private set; }


    }
}