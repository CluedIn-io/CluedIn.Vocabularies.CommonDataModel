using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductCategoryAttributeEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductCategoryAttributeEntityVocabulary()
        {
            VocabularyName = "Eco Res Product Category Attribute Entity";
            KeyPrefix = "commonDataModel.ecoresproductcategoryattributeentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductCategoryAttributeEntity";

            AddGroup("EcoResProductCategoryAttributeEntity Details", group =>
            {
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeModifier = group.Add(new VocabularyKey(nameof(AttributeModifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductAttributeTypeName = group.Add(new VocabularyKey(nameof(ProductAttributeTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductAttributeName = group.Add(new VocabularyKey(nameof(ProductAttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProductCategoryHierarchyName { get; private set; }
        public VocabularyKey ProductCategoryName { get; private set; }
        public VocabularyKey AttributeModifier { get; private set; }
        public VocabularyKey ProductAttributeTypeName { get; private set; }
        public VocabularyKey ProductAttributeName { get; private set; }
    }
}