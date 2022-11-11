using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCatalogProductCategoryEntityVocabulary : SimpleVocabulary
    {
        public RetailCatalogProductCategoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailCatalogProductCategoryEntity";
            KeyPrefix = "commonDataModel.retailcatalogproductcategoryentity";
            KeySeparator = ".";
            Grouping = "/RetailCatalogProductCategoryEntity";

            AddGroup("Common Data Model RetailCatalogProductCategoryEntity Details", group =>
            {
                CatalogNumber = group.Add(new VocabularyKey(nameof(CatalogNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayProductNumber = group.Add(new VocabularyKey(nameof(DisplayProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncludeExcludeType = group.Add(new VocabularyKey(nameof(IncludeExcludeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatalogProduct = group.Add(new VocabularyKey(nameof(CatalogProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchy = group.Add(new VocabularyKey(nameof(CategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CatalogNumber { get; private set; }
        public VocabularyKey DisplayProductNumber { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey CategoryHierarchyName { get; private set; }
        public VocabularyKey IncludeExcludeType { get; private set; }
        public VocabularyKey CatalogProduct { get; private set; }
        public VocabularyKey Category { get; private set; }
        public VocabularyKey CategoryHierarchy { get; private set; }


    }
}