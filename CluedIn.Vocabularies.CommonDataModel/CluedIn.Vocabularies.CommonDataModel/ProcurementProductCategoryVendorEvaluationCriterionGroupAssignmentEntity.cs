using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcurementProductCategoryVendorEvaluationCriterionGroupAssignmentEntityVocabulary : SimpleVocabulary
    {
        public ProcurementProductCategoryVendorEvaluationCriterionGroupAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProcurementProductCategoryVendorEvaluationCriterionGroupAssignmentEntity";
            KeyPrefix = "commonDataModel.procurementproductcategoryvendorevaluationcriteriongroupassignmententity";
            KeySeparator = ".";
            Grouping = "/ProcurementProductCategoryVendorEvaluationCriterionGroupAssignmentEntity";

            AddGroup("Common Data Model ProcurementProductCategoryVendorEvaluationCriterionGroupAssignmentEntity Details", group =>
            {
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorEvaluationCriterionGroupName = group.Add(new VocabularyKey(nameof(VendorEvaluationCriterionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProductCategoryHierarchyName { get; private set; }
public VocabularyKey ProductCategoryName { get; private set; }
public VocabularyKey VendorEvaluationCriterionGroupName { get; private set; }


    }
}