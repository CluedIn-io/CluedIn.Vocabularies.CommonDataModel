using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductAttributeEnumerationValueTypeEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductAttributeEnumerationValueTypeEntityVocabulary()
        {
            VocabularyName = "Eco Res Product Attribute Enumeration Value Type Entity";
            KeyPrefix = "commonDataModel.ecoresproductattributeenumerationvaluetypeentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductAttributeEnumerationValueTypeEntity";

            AddGroup("EcoResProductAttributeEnumerationValueTypeEntity Details", group =>
            {
                EnumerationName = group.Add(new VocabularyKey(nameof(EnumerationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnumerationNameUniqueID = group.Add(new VocabularyKey(nameof(EnumerationNameUniqueID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnumerationValue = group.Add(new VocabularyKey(nameof(EnumerationValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EnumerationName { get; private set; }
        public VocabularyKey EnumerationNameUniqueID { get; private set; }
        public VocabularyKey EnumerationValue { get; private set; }
    }
}