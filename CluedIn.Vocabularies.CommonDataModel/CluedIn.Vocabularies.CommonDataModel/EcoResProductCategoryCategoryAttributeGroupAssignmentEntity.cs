using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductCategoryCategoryAttributeGroupAssignmentEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductCategoryCategoryAttributeGroupAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductCategoryCategoryAttributeGroupAssignmentEntity";
            KeyPrefix = "commonDataModel.ecoresproductcategorycategoryattributegroupassignmententity";
            KeySeparator = ".";
            Grouping = "/EcoResProductCategoryCategoryAttributeGroupAssignmentEntity";

            AddGroup("Common Data Model EcoResProductCategoryCategoryAttributeGroupAssignmentEntity Details", group =>
            {
                EcoResCategory_CategoryHierarchy = group.Add(new VocabularyKey(nameof(EcoResCategory_CategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributeGroup = group.Add(new VocabularyKey(nameof(AttributeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductAttributeGroupName = group.Add(new VocabularyKey(nameof(ProductAttributeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductAttributeGroupDisplayOrder = group.Add(new VocabularyKey(nameof(ProductAttributeGroupDisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey EcoResCategory_CategoryHierarchy { get; private set; }
public VocabularyKey ProductCategoryHierarchyName { get; private set; }
public VocabularyKey Category { get; private set; }
public VocabularyKey ProductCategoryName { get; private set; }
public VocabularyKey AttributeGroup { get; private set; }
public VocabularyKey ProductAttributeGroupName { get; private set; }
public VocabularyKey ProductAttributeGroupDisplayOrder { get; private set; }


    }
}