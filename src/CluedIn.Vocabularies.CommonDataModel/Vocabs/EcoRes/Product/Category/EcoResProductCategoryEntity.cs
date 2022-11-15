using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductCategoryEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductCategoryEntityVocabulary()
        {
            VocabularyName = "Eco Res Product Category Entity";
            KeyPrefix = "commonDataModel.ecoresproductcategoryentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductCategoryEntity";

            AddGroup("EcoResProductCategoryEntity Details", group =>
            {
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentProductCategoryCode = group.Add(new VocabularyKey(nameof(ParentProductCategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentProductCategoryName = group.Add(new VocabularyKey(nameof(ParentProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryCode = group.Add(new VocabularyKey(nameof(CategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FriendlyCategoryName = group.Add(new VocabularyKey(nameof(FriendlyCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryDescription = group.Add(new VocabularyKey(nameof(CategoryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTangibleProduct = group.Add(new VocabularyKey(nameof(IsTangibleProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryKeywords = group.Add(new VocabularyKey(nameof(CategoryKeywords), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCategoryInheritingParentCategoryAttributes = group.Add(new VocabularyKey(nameof(IsCategoryInheritingParentCategoryAttributes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCategoryInheritingParentProductAttributes = group.Add(new VocabularyKey(nameof(IsCategoryInheritingParentProductAttributes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PKWiUCode = group.Add(new VocabularyKey(nameof(PKWiUCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategoryName = group.Add(new VocabularyKey(nameof(ProjectCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProjectGlobalCategoryId = group.Add(new VocabularyKey(nameof(DefaultProjectGlobalCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProductCategoryHierarchyName { get; private set; }
        public VocabularyKey ParentProductCategoryCode { get; private set; }
        public VocabularyKey ParentProductCategoryName { get; private set; }
        public VocabularyKey CategoryCode { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey FriendlyCategoryName { get; private set; }
        public VocabularyKey CategoryDescription { get; private set; }
        public VocabularyKey IsTangibleProduct { get; private set; }
        public VocabularyKey CategoryKeywords { get; private set; }
        public VocabularyKey IsCategoryInheritingParentCategoryAttributes { get; private set; }
        public VocabularyKey IsCategoryInheritingParentProductAttributes { get; private set; }
        public VocabularyKey PKWiUCode { get; private set; }
        public VocabularyKey ProjectCategoryName { get; private set; }
        public VocabularyKey DefaultProjectGlobalCategoryId { get; private set; }
    }
}