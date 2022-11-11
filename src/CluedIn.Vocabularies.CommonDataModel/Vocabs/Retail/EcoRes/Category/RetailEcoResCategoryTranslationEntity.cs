using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailEcoResCategoryTranslationEntityVocabulary : SimpleVocabulary
    {
        public RetailEcoResCategoryTranslationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailEcoResCategoryTranslationEntity";
            KeyPrefix = "commonDataModel.retailecorescategorytranslationentity";
            KeySeparator = ".";
            Grouping = "/RetailEcoResCategoryTranslationEntity";

            AddGroup("Common Data Model RetailEcoResCategoryTranslationEntity Details", group =>
            {
                Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FriendlyName = group.Add(new VocabularyKey(nameof(FriendlyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SearchText = group.Add(new VocabularyKey(nameof(SearchText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EcoResCategory_CategoryHierarchy = group.Add(new VocabularyKey(nameof(EcoResCategory_CategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EcoResCategory_Name = group.Add(new VocabularyKey(nameof(EcoResCategory_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EcoResCategoryHierarchy_Name = group.Add(new VocabularyKey(nameof(EcoResCategoryHierarchy_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Category { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey FriendlyName { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey SearchText { get; private set; }
        public VocabularyKey EcoResCategory_CategoryHierarchy { get; private set; }
        public VocabularyKey EcoResCategory_Name { get; private set; }
        public VocabularyKey EcoResCategoryHierarchy_Name { get; private set; }


    }
}