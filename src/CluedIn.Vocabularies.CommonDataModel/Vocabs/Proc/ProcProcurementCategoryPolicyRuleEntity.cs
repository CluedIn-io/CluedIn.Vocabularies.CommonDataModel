using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcProcurementCategoryPolicyRuleEntityVocabulary : SimpleVocabulary
    {
        public ProcProcurementCategoryPolicyRuleEntityVocabulary()
        {
            VocabularyName = "Proc Procurement Category Policy Rule Entity";
            KeyPrefix = "commonDataModel.procprocurementcategorypolicyruleentity";
            KeySeparator = ".";
            Grouping = "/ProcProcurementCategoryPolicyRuleEntity";

            AddGroup("ProcProcurementCategoryPolicyRuleEntity Details", group =>
            {
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategoryName = group.Add(new VocabularyKey(nameof(ProcurementCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReturnedQuantityVerifiedBeforeRecordingReturn = group.Add(new VocabularyKey(nameof(IsReturnedQuantityVerifiedBeforeRecordingReturn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchaseRequisitionShowQuestionnaires = group.Add(new VocabularyKey(nameof(WillPurchaseRequisitionShowQuestionnaires), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuantityVerifiedBeforeRecordingPurchase = group.Add(new VocabularyKey(nameof(IsQuantityVerifiedBeforeRecordingPurchase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryMatchingPolicy = group.Add(new VocabularyKey(nameof(CategoryMatchingPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductReceiptAccruePurchaseExpense = group.Add(new VocabularyKey(nameof(WillProductReceiptAccruePurchaseExpense), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorSelectionRule = group.Add(new VocabularyKey(nameof(VendorSelectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategory = group.Add(new VocabularyKey(nameof(ProcurementCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategoryPolicyRule = group.Add(new VocabularyKey(nameof(ProcurementCategoryPolicyRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Policy = group.Add(new VocabularyKey(nameof(Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleType = group.Add(new VocabularyKey(nameof(PolicyRuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstanceRelationType = group.Add(new VocabularyKey(nameof(InstanceRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleName = group.Add(new VocabularyKey(nameof(PolicyRuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey ProcurementCategoryName { get; private set; }
        public VocabularyKey IsReturnedQuantityVerifiedBeforeRecordingReturn { get; private set; }
        public VocabularyKey WillPurchaseRequisitionShowQuestionnaires { get; private set; }
        public VocabularyKey IsQuantityVerifiedBeforeRecordingPurchase { get; private set; }
        public VocabularyKey CategoryMatchingPolicy { get; private set; }
        public VocabularyKey WillProductReceiptAccruePurchaseExpense { get; private set; }
        public VocabularyKey VendorSelectionRule { get; private set; }
        public VocabularyKey ProcurementCategory { get; private set; }
        public VocabularyKey ProcurementCategoryPolicyRule { get; private set; }
        public VocabularyKey Policy { get; private set; }
        public VocabularyKey PolicyRuleType { get; private set; }
        public VocabularyKey InstanceRelationType { get; private set; }
        public VocabularyKey PolicyRuleName { get; private set; }
        public VocabularyKey PurchasingPolicyName { get; private set; }
    }
}