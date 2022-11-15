using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseOrderCreationNonCatalogItemCategoryEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseOrderCreationNonCatalogItemCategoryEntityVocabulary()
        {
            VocabularyName = "Purch Purchase Order Creation Non Catalog Item Category Entity";
            KeyPrefix = "commonDataModel.purchpurchaseordercreationnoncatalogitemcategoryentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseOrderCreationNonCatalogItemCategoryEntity";

            AddGroup("PurchPurchaseOrderCreationNonCatalogItemCategoryEntity Details", group =>
            {
                PurchaseOrderCreationAndDemandConsolidationPolicyRuleValidFrom = group.Add(new VocabularyKey(nameof(PurchaseOrderCreationAndDemandConsolidationPolicyRuleValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PurchaseOrderCreationAndDemandConsolidationPolicyRuleValidFrom { get; private set; }
        public VocabularyKey ProcurementProductCategoryName { get; private set; }
        public VocabularyKey PurchasingPolicyName { get; private set; }
        public VocabularyKey ProcurementProductCategoryHierarchyName { get; private set; }
    }
}