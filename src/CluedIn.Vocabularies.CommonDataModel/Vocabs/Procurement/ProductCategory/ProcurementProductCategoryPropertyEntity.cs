using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcurementProductCategoryPropertyEntityVocabulary : SimpleVocabulary
    {
        public ProcurementProductCategoryPropertyEntityVocabulary()
        {
            VocabularyName = "Procurement Product Category Property Entity";
            KeyPrefix = "commonDataModel.procurementproductcategorypropertyentity";
            KeySeparator = ".";
            Grouping = "/ProcurementProductCategoryPropertyEntity";

            AddGroup("ProcurementProductCategoryPropertyEntity Details", group =>
            {
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInheritingParentProductCategoryVendors = group.Add(new VocabularyKey(nameof(IsInheritingParentProductCategoryVendors), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInheritingParentProductCategoryProductAttributes = group.Add(new VocabularyKey(nameof(IsInheritingParentProductCategoryProductAttributes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInheritingParentProductCategoryVendorEvaluatiionCriterionGroups = group.Add(new VocabularyKey(nameof(IsInheritingParentProductCategoryVendorEvaluatiionCriterionGroups), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInheritingParentProductCategoryQuestionnaires = group.Add(new VocabularyKey(nameof(IsInheritingParentProductCategoryQuestionnaires), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProductCategoryHierarchyName { get; private set; }
        public VocabularyKey ProductCategoryName { get; private set; }
        public VocabularyKey IsInheritingParentProductCategoryVendors { get; private set; }
        public VocabularyKey IsInheritingParentProductCategoryProductAttributes { get; private set; }
        public VocabularyKey IsInheritingParentProductCategoryVendorEvaluatiionCriterionGroups { get; private set; }
        public VocabularyKey IsInheritingParentProductCategoryQuestionnaires { get; private set; }
    }
}