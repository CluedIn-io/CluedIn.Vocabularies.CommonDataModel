using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductAttributeGroupTranslationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductAttributeGroupTranslationEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductAttributeGroupTranslationEntity";
            KeyPrefix = "commonDataModel.ecoresproductattributegrouptranslationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductAttributeGroupTranslationEntity";

            AddGroup("Common Data Model EcoResProductAttributeGroupTranslationEntity Details", group =>
            {
                AttributeGroup = group.Add(new VocabularyKey(nameof(AttributeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductAttributeGroupName = group.Add(new VocabularyKey(nameof(ProductAttributeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TranslatedGroupDescription = group.Add(new VocabularyKey(nameof(TranslatedGroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TranslatedFriendlyGroupName = group.Add(new VocabularyKey(nameof(TranslatedFriendlyGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TranslatedGroupHelpText = group.Add(new VocabularyKey(nameof(TranslatedGroupHelpText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AttributeGroup { get; private set; }
public VocabularyKey ProductAttributeGroupName { get; private set; }
public VocabularyKey LanguageId { get; private set; }
public VocabularyKey TranslatedGroupDescription { get; private set; }
public VocabularyKey TranslatedFriendlyGroupName { get; private set; }
public VocabularyKey TranslatedGroupHelpText { get; private set; }


    }
}