using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseRequisitionConsumptionControlWorkflowEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseRequisitionConsumptionControlWorkflowEntityVocabulary()
        {
            VocabularyName = "PurchPurchaseRequisitionConsumptionControlWorkflowEntity";
            KeyPrefix = "commonDataModel.purchpurchaserequisitionconsumptioncontrolworkflowentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseRequisitionConsumptionControlWorkflowEntity";

            AddGroup("PurchPurchaseRequisitionConsumptionControlWorkflowEntity Details", group =>
            {
                FieldId = group.Add(new VocabularyKey(nameof(FieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchReqControlRule = group.Add(new VocabularyKey(nameof(PurchReqControlRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseRequisitionConsumptionControlPolicyRuleValidFrom = group.Add(new VocabularyKey(nameof(PurchaseRequisitionConsumptionControlPolicyRuleValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowFieldRequirementRule = group.Add(new VocabularyKey(nameof(WorkflowFieldRequirementRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowFieldName = group.Add(new VocabularyKey(nameof(WorkflowFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowFieldExpressionId = group.Add(new VocabularyKey(nameof(WorkflowFieldExpressionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FieldId { get; private set; }
        public VocabularyKey PurchReqControlRule { get; private set; }
        public VocabularyKey PurchaseRequisitionConsumptionControlPolicyRuleValidFrom { get; private set; }
        public VocabularyKey WorkflowFieldRequirementRule { get; private set; }
        public VocabularyKey WorkflowFieldName { get; private set; }
        public VocabularyKey WorkflowFieldExpressionId { get; private set; }
        public VocabularyKey PurchasingPolicyName { get; private set; }


    }
}