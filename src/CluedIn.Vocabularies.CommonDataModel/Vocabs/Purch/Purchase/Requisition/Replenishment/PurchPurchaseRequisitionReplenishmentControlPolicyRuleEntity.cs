using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseRequisitionReplenishmentControlPolicyRuleEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseRequisitionReplenishmentControlPolicyRuleEntityVocabulary()
        {
            VocabularyName = "Purch Purchase Requisition Replenishment Control Policy Rule Entity";
            KeyPrefix = "commonDataModel.purchpurchaserequisitionreplenishmentcontrolpolicyruleentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseRequisitionReplenishmentControlPolicyRuleEntity";

            AddGroup("PurchPurchaseRequisitionReplenishmentControlPolicyRuleEntity Details", group =>
            {
                Policy = group.Add(new VocabularyKey(nameof(Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleType = group.Add(new VocabularyKey(nameof(PolicyRuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRequestedDateDefaultAccountingDate = group.Add(new VocabularyKey(nameof(IsRequestedDateDefaultAccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleName = group.Add(new VocabularyKey(nameof(PolicyRuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldId = group.Add(new VocabularyKey(nameof(FieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowFieldExpressionId = group.Add(new VocabularyKey(nameof(WorkflowFieldExpressionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowFieldRequirementRule = group.Add(new VocabularyKey(nameof(WorkflowFieldRequirementRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequisitionReplenishControlRule = group.Add(new VocabularyKey(nameof(RequisitionReplenishControlRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequisitionReplenishControlSubmsnParam = group.Add(new VocabularyKey(nameof(RequisitionReplenishControlSubmsnParam), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowFieldName = group.Add(new VocabularyKey(nameof(WorkflowFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Policy { get; private set; }
        public VocabularyKey PolicyRuleType { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey IsRequestedDateDefaultAccountingDate { get; private set; }
        public VocabularyKey PurchasingPolicyName { get; private set; }
        public VocabularyKey PolicyRuleName { get; private set; }
        public VocabularyKey FieldId { get; private set; }
        public VocabularyKey WorkflowFieldExpressionId { get; private set; }
        public VocabularyKey WorkflowFieldRequirementRule { get; private set; }
        public VocabularyKey RequisitionReplenishControlRule { get; private set; }
        public VocabularyKey RequisitionReplenishControlSubmsnParam { get; private set; }
        public VocabularyKey WorkflowFieldName { get; private set; }
    }
}