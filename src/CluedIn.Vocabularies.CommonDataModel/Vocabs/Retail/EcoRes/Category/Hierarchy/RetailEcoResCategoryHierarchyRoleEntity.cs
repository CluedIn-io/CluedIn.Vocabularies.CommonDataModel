using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailEcoResCategoryHierarchyRoleEntityVocabulary : SimpleVocabulary
    {
        public RetailEcoResCategoryHierarchyRoleEntityVocabulary()
        {
            VocabularyName = "Retail Eco Res Category Hierarchy Role Entity";
            KeyPrefix = "commonDataModel.retailecorescategoryhierarchyroleentity";
            KeySeparator = ".";
            Grouping = "/RetailEcoResCategoryHierarchyRoleEntity";

            AddGroup("RetailEcoResCategoryHierarchyRoleEntity Details", group =>
            {
                CategoryHierarchy = group.Add(new VocabularyKey(nameof(CategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NamedCategoryHierarchyRole = group.Add(new VocabularyKey(nameof(NamedCategoryHierarchyRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EcoResCategoryHierarchy_Name = group.Add(new VocabularyKey(nameof(EcoResCategoryHierarchy_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NamedCategoryHierarchyRoleAsInt = group.Add(new VocabularyKey(nameof(NamedCategoryHierarchyRoleAsInt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CategoryHierarchy { get; private set; }
        public VocabularyKey NamedCategoryHierarchyRole { get; private set; }
        public VocabularyKey EcoResCategoryHierarchy_Name { get; private set; }
        public VocabularyKey NamedCategoryHierarchyRoleAsInt { get; private set; }
    }
}