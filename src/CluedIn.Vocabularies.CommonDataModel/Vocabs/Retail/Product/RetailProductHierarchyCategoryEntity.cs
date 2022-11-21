using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailProductHierarchyCategoryEntityVocabulary : SimpleVocabulary
    {
        public RetailProductHierarchyCategoryEntityVocabulary()
        {
            VocabularyName = "Retail Product Hierarchy Category Entity";
            KeyPrefix = "commonDataModel.retailproducthierarchycategoryentity";
            KeySeparator = ".";
            Grouping = "/RetailProductHierarchyCategoryEntity";

            AddGroup("RetailProductHierarchyCategoryEntity Details", group =>
            {
                CategoryHierarchy = group.Add(new VocabularyKey(nameof(CategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentCategoryRecordId = group.Add(new VocabularyKey(nameof(ParentCategoryRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentCategoryName = group.Add(new VocabularyKey(nameof(ParentCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryRecordId = group.Add(new VocabularyKey(nameof(CategoryRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CategoryHierarchy { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey CategoryHierarchyName { get; private set; }
        public VocabularyKey ParentCategoryRecordId { get; private set; }
        public VocabularyKey ParentCategoryName { get; private set; }
        public VocabularyKey CategoryRecordId { get; private set; }
    }
}