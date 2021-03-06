using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductAttributeEnumerationValueTypeTranslationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductAttributeEnumerationValueTypeTranslationEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductAttributeEnumerationValueTypeTranslationEntity";
            KeyPrefix = "commonDataModel.ecoresproductattributeenumerationvaluetypetranslationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductAttributeEnumerationValueTypeTranslationEntity";

            AddGroup("Common Data Model EcoResProductAttributeEnumerationValueTypeTranslationEntity Details", group =>
            {
                ProductAttributeEnumerationName = group.Add(new VocabularyKey(nameof(ProductAttributeEnumerationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductAttributeEnumerationValue = group.Add(new VocabularyKey(nameof(ProductAttributeEnumerationValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TranslatedEnumerationValue = group.Add(new VocabularyKey(nameof(TranslatedEnumerationValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProductAttributeEnumerationName { get; private set; }
public VocabularyKey ProductAttributeEnumerationValue { get; private set; }
public VocabularyKey LanguageId { get; private set; }
public VocabularyKey TranslatedEnumerationValue { get; private set; }


    }
}