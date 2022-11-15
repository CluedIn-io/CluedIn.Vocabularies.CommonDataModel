using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchDemandConsolidationExternalCatalogItemCategoryVendorEntityVocabulary : SimpleVocabulary
    {
        public PurchDemandConsolidationExternalCatalogItemCategoryVendorEntityVocabulary()
        {
            VocabularyName = "Purch Demand Consolidation External Catalog Item Category Vendor Entity";
            KeyPrefix = "commonDataModel.purchdemandconsolidationexternalcatalogitemcategoryvendorentity";
            KeySeparator = ".";
            Grouping = "/PurchDemandConsolidationExternalCatalogItemCategoryVendorEntity";

            AddGroup("PurchDemandConsolidationExternalCatalogItemCategoryVendorEntity Details", group =>
            {
                PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderCreationAndDemandConsolidationPolicyRuleValidFrom = group.Add(new VocabularyKey(nameof(PurchaseOrderCreationAndDemandConsolidationPolicyRuleValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorLegalEntityId = group.Add(new VocabularyKey(nameof(VendorLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PurchasingPolicyName { get; private set; }
        public VocabularyKey PurchaseOrderCreationAndDemandConsolidationPolicyRuleValidFrom { get; private set; }
        public VocabularyKey ProcurementProductCategoryName { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey VendorLegalEntityId { get; private set; }
        public VocabularyKey ProcurementProductCategoryHierarchyName { get; private set; }
    }
}