using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseRequisitionReplenishmentCategoryAccessPolicyRuleEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseRequisitionReplenishmentCategoryAccessPolicyRuleEntityVocabulary()
        {
            VocabularyName = "Purch Purchase Requisition Replenishment Category Access Policy Rule Entity";
            KeyPrefix = "commonDataModel.purchpurchaserequisitionreplenishmentcategoryaccesspolicyruleentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseRequisitionReplenishmentCategoryAccessPolicyRuleEntity";

            AddGroup("PurchPurchaseRequisitionReplenishmentCategoryAccessPolicyRuleEntity Details", group =>
            {
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Policy = group.Add(new VocabularyKey(nameof(Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleType = group.Add(new VocabularyKey(nameof(PolicyRuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleName = group.Add(new VocabularyKey(nameof(PolicyRuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategoryHierarchy = group.Add(new VocabularyKey(nameof(ProcurementCategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProcurementCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategoryName = group.Add(new VocabularyKey(nameof(ProcurementCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategory = group.Add(new VocabularyKey(nameof(ProcurementCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey PurchasingPolicyName { get; private set; }
        public VocabularyKey Policy { get; private set; }
        public VocabularyKey PolicyRuleType { get; private set; }
        public VocabularyKey PolicyRuleName { get; private set; }
        public VocabularyKey ProcurementCategoryHierarchy { get; private set; }
        public VocabularyKey ProcurementCategoryHierarchyName { get; private set; }
        public VocabularyKey ProcurementCategoryName { get; private set; }
        public VocabularyKey ProcurementCategory { get; private set; }
    }
}