using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductAttributeEnumerationValueTypeEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductAttributeEnumerationValueTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductAttributeEnumerationValueTypeEntity";
            KeyPrefix = "commonDataModel.ecoresproductattributeenumerationvaluetypeentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductAttributeEnumerationValueTypeEntity";

            AddGroup("Common Data Model EcoResProductAttributeEnumerationValueTypeEntity Details", group =>
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