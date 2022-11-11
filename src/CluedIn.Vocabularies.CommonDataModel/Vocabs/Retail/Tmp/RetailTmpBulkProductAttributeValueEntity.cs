using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTmpBulkProductAttributeValueEntityVocabulary : SimpleVocabulary
    {
        public RetailTmpBulkProductAttributeValueEntityVocabulary()
        {
            VocabularyName = "RetailTmpBulkProductAttributeValueEntity";
            KeyPrefix = "commonDataModel.retailtmpbulkproductattributevalueentity";
            KeySeparator = ".";
            Grouping = "/RetailTmpBulkProductAttributeValueEntity";

            AddGroup("RetailTmpBulkProductAttributeValueEntity Details", group =>
            {
                CatalogName = group.Add(new VocabularyKey(nameof(CatalogName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatalogNumber = group.Add(new VocabularyKey(nameof(CatalogNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeName = group.Add(new VocabularyKey(nameof(AttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeTypeName = group.Add(new VocabularyKey(nameof(AttributeTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayProductNumber = group.Add(new VocabularyKey(nameof(DisplayProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalOrgNumber = group.Add(new VocabularyKey(nameof(InternalOrgNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueAsText = group.Add(new VocabularyKey(nameof(ValueAsText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeProperty = group.Add(new VocabularyKey(nameof(AttributeProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeSourceName = group.Add(new VocabularyKey(nameof(AttributeSourceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeSourceTypeAsLabel = group.Add(new VocabularyKey(nameof(AttributeSourceTypeAsLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredAsLabel = group.Add(new VocabularyKey(nameof(RequiredAsLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataTypeAsLabel = group.Add(new VocabularyKey(nameof(DataTypeAsLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TmpCatBulkAttrib = group.Add(new VocabularyKey(nameof(TmpCatBulkAttrib), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CatalogName { get; private set; }
        public VocabularyKey CatalogNumber { get; private set; }
        public VocabularyKey AttributeName { get; private set; }
        public VocabularyKey AttributeTypeName { get; private set; }
        public VocabularyKey DisplayProductNumber { get; private set; }
        public VocabularyKey InternalOrgNumber { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey ValueAsText { get; private set; }
        public VocabularyKey AttributeProperty { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey AttributeSourceName { get; private set; }
        public VocabularyKey AttributeSourceTypeAsLabel { get; private set; }
        public VocabularyKey RequiredAsLabel { get; private set; }
        public VocabularyKey DataTypeAsLabel { get; private set; }
        public VocabularyKey TmpCatBulkAttrib { get; private set; }


    }
}