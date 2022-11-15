using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchDemandConsolidationNonCatalogItemCategoryEntityVocabulary : SimpleVocabulary
    {
        public PurchDemandConsolidationNonCatalogItemCategoryEntityVocabulary()
        {
            VocabularyName = "Purch Demand Consolidation Non Catalog Item Category Entity";
            KeyPrefix = "commonDataModel.purchdemandconsolidationnoncatalogitemcategoryentity";
            KeySeparator = ".";
            Grouping = "/PurchDemandConsolidationNonCatalogItemCategoryEntity";

            AddGroup("PurchDemandConsolidationNonCatalogItemCategoryEntity Details", group =>
            {
                PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderCreationAndDemandConsolidationPolicyRuleValidFrom = group.Add(new VocabularyKey(nameof(PurchaseOrderCreationAndDemandConsolidationPolicyRuleValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PurchasingPolicyName { get; private set; }
        public VocabularyKey PurchaseOrderCreationAndDemandConsolidationPolicyRuleValidFrom { get; private set; }
        public VocabularyKey ProcurementProductCategoryName { get; private set; }
        public VocabularyKey ProcurementProductCategoryHierarchyName { get; private set; }
    }
}