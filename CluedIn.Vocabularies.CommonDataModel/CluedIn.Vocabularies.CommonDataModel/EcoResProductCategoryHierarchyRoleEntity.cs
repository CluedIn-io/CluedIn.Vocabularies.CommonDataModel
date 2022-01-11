using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductCategoryHierarchyRoleEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductCategoryHierarchyRoleEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductCategoryHierarchyRoleEntity";
            KeyPrefix = "commonDataModel.ecoresproductcategoryhierarchyroleentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductCategoryHierarchyRoleEntity";

            AddGroup("Common Data Model EcoResProductCategoryHierarchyRoleEntity Details", group =>
            {
                HierarchyRole = group.Add(new VocabularyKey(nameof(HierarchyRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey HierarchyRole { get; private set; }
public VocabularyKey ProductCategoryHierarchyName { get; private set; }


    }
}