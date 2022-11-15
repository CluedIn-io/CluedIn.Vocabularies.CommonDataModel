using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesProductCategoryLegalEntityDefaultsEntityVocabulary : SimpleVocabulary
    {
        public SalesProductCategoryLegalEntityDefaultsEntityVocabulary()
        {
            VocabularyName = "Sales Product Category Legal Entity Defaults Entity";
            KeyPrefix = "commonDataModel.salesproductcategorylegalentitydefaultsentity";
            KeySeparator = ".";
            Grouping = "/SalesProductCategoryLegalEntityDefaultsEntity";

            AddGroup("SalesProductCategoryLegalEntityDefaultsEntity Details", group =>
            {
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesLegalEntityId = group.Add(new VocabularyKey(nameof(SalesLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSalesTaxGroupId = group.Add(new VocabularyKey(nameof(ProductSalesTaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProductCategoryHierarchyName { get; private set; }
        public VocabularyKey ProductCategoryName { get; private set; }
        public VocabularyKey SalesLegalEntityId { get; private set; }
        public VocabularyKey ProductSalesTaxGroupId { get; private set; }
    }
}