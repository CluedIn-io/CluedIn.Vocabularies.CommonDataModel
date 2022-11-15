using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchDemandConsolidationExternalCatalogItemCategoryEntityVocabulary : SimpleVocabulary
    {
        public PurchDemandConsolidationExternalCatalogItemCategoryEntityVocabulary()
        {
            VocabularyName = "Purch Demand Consolidation External Catalog Item Category Entity";
            KeyPrefix = "commonDataModel.purchdemandconsolidationexternalcatalogitemcategoryentity";
            KeySeparator = ".";
            Grouping = "/PurchDemandConsolidationExternalCatalogItemCategoryEntity";

            AddGroup("PurchDemandConsolidationExternalCatalogItemCategoryEntity Details", group =>
            {
                PurchaseOrderCreationAndDemandConsolidationPolicyRuleValidFrom = group.Add(new VocabularyKey(nameof(PurchaseOrderCreationAndDemandConsolidationPolicyRuleValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PurchaseOrderCreationAndDemandConsolidationPolicyRuleValidFrom { get; private set; }
        public VocabularyKey PurchasingPolicyName { get; private set; }
        public VocabularyKey ProcurementProductCategoryName { get; private set; }
        public VocabularyKey ProcurementProductCategoryHierarchyName { get; private set; }
    }
}