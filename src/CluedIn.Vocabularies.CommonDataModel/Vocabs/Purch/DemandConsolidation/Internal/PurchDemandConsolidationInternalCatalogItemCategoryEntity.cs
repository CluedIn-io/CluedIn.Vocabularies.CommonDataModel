using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchDemandConsolidationInternalCatalogItemCategoryEntityVocabulary : SimpleVocabulary
    {
        public PurchDemandConsolidationInternalCatalogItemCategoryEntityVocabulary()
        {
            VocabularyName = "PurchDemandConsolidationInternalCatalogItemCategoryEntity";
            KeyPrefix = "commonDataModel.purchdemandconsolidationinternalcatalogitemcategoryentity";
            KeySeparator = ".";
            Grouping = "/PurchDemandConsolidationInternalCatalogItemCategoryEntity";

            AddGroup("PurchDemandConsolidationInternalCatalogItemCategoryEntity Details", group =>
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