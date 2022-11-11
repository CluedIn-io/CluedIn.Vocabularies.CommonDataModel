using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductEntityAttributeValueEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductEntityAttributeValueEntityVocabulary()
        {
            VocabularyName = "EcoResProductEntityAttributeValueEntity";
            KeyPrefix = "commonDataModel.ecoresproductentityattributevalueentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductEntityAttributeValueEntity";

            AddGroup("EcoResProductEntityAttributeValueEntity Details", group =>
            {
                ProductAttributeName = group.Add(new VocabularyKey(nameof(ProductAttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductAttributeTextValue = group.Add(new VocabularyKey(nameof(ProductAttributeTextValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductAttributeName { get; private set; }
        public VocabularyKey ProductAttributeTextValue { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }


    }
}