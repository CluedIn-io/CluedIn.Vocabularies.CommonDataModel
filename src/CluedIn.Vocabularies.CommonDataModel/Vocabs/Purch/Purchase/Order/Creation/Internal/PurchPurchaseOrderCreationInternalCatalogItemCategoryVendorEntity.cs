using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseOrderCreationInternalCatalogItemCategoryVendorEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseOrderCreationInternalCatalogItemCategoryVendorEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPurchaseOrderCreationInternalCatalogItemCategoryVendorEntity";
            KeyPrefix = "commonDataModel.purchpurchaseordercreationinternalcatalogitemcategoryvendorentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseOrderCreationInternalCatalogItemCategoryVendorEntity";

            AddGroup("Common Data Model PurchPurchaseOrderCreationInternalCatalogItemCategoryVendorEntity Details", group =>
            {
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorLegalEntityId = group.Add(new VocabularyKey(nameof(VendorLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderCreationAndDemandConsolidationPolicyRuleValidFrom = group.Add(new VocabularyKey(nameof(PurchaseOrderCreationAndDemandConsolidationPolicyRuleValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey VendorLegalEntityId { get; private set; }
        public VocabularyKey ProcurementProductCategoryName { get; private set; }
        public VocabularyKey PurchaseOrderCreationAndDemandConsolidationPolicyRuleValidFrom { get; private set; }
        public VocabularyKey PurchasingPolicyName { get; private set; }
        public VocabularyKey ProcurementProductCategoryHierarchyName { get; private set; }


    }
}