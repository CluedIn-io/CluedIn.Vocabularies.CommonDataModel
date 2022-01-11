using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductRelationTypeTranslationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductRelationTypeTranslationEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductRelationTypeTranslationEntity";
            KeyPrefix = "commonDataModel.ecoresproductrelationtypetranslationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductRelationTypeTranslationEntity";

            AddGroup("Common Data Model EcoResProductRelationTypeTranslationEntity Details", group =>
            {
                ProductRelationType = group.Add(new VocabularyKey(nameof(ProductRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductRelationTypeName = group.Add(new VocabularyKey(nameof(ProductRelationTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TranslatedTypeDescription = group.Add(new VocabularyKey(nameof(TranslatedTypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TranslatedFriendlyName = group.Add(new VocabularyKey(nameof(TranslatedFriendlyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProductRelationType { get; private set; }
public VocabularyKey ProductRelationTypeName { get; private set; }
public VocabularyKey LanguageId { get; private set; }
public VocabularyKey TranslatedTypeDescription { get; private set; }
public VocabularyKey TranslatedFriendlyName { get; private set; }


    }
}