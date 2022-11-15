using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductCategoryAssignmentEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductCategoryAssignmentEntityVocabulary()
        {
            VocabularyName = "Eco Res Product Category Assignment Entity";
            KeyPrefix = "commonDataModel.ecoresproductcategoryassignmententity";
            KeySeparator = ".";
            Grouping = "/EcoResProductCategoryAssignmentEntity";

            AddGroup("EcoResProductCategoryAssignmentEntity Details", group =>
            {
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryRecId = group.Add(new VocabularyKey(nameof(ProductCategoryRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryHierarchyRecId = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductRecId = group.Add(new VocabularyKey(nameof(ProductRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ProductCategoryHierarchyName { get; private set; }
        public VocabularyKey ProductCategoryName { get; private set; }
        public VocabularyKey ProductCategoryRecId { get; private set; }
        public VocabularyKey ProductCategoryHierarchyRecId { get; private set; }
        public VocabularyKey ProductRecId { get; private set; }
    }
}