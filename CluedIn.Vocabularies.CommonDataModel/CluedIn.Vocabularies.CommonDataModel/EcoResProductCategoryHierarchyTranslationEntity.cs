using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductCategoryHierarchyTranslationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductCategoryHierarchyTranslationEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductCategoryHierarchyTranslationEntity";
            KeyPrefix = "commonDataModel.ecoresproductcategoryhierarchytranslationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductCategoryHierarchyTranslationEntity";

            AddGroup("Common Data Model EcoResProductCategoryHierarchyTranslationEntity Details", group =>
            {
                ProductCategoryHierarchyId = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TranslatedHierarchyDescription = group.Add(new VocabularyKey(nameof(TranslatedHierarchyDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TranslatedHierarchyHelpText = group.Add(new VocabularyKey(nameof(TranslatedHierarchyHelpText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProductCategoryHierarchyId { get; private set; }
public VocabularyKey ProductCategoryHierarchyName { get; private set; }
public VocabularyKey LanguageId { get; private set; }
public VocabularyKey TranslatedHierarchyDescription { get; private set; }
public VocabularyKey TranslatedHierarchyHelpText { get; private set; }


    }
}