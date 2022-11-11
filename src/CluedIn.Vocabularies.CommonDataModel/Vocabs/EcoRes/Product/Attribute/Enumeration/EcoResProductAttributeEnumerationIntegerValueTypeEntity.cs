using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductAttributeEnumerationIntegerValueTypeEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductAttributeEnumerationIntegerValueTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductAttributeEnumerationIntegerValueTypeEntity";
            KeyPrefix = "commonDataModel.ecoresproductattributeenumerationintegervaluetypeentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductAttributeEnumerationIntegerValueTypeEntity";

            AddGroup("Common Data Model EcoResProductAttributeEnumerationIntegerValueTypeEntity Details", group =>
            {
                EnumerationName = group.Add(new VocabularyKey(nameof(EnumerationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnumerationNameUniqueID = group.Add(new VocabularyKey(nameof(EnumerationNameUniqueID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnumerationIntegerValue = group.Add(new VocabularyKey(nameof(EnumerationIntegerValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey EnumerationName { get; private set; }
        public VocabularyKey EnumerationNameUniqueID { get; private set; }
        public VocabularyKey EnumerationIntegerValue { get; private set; }


    }
}