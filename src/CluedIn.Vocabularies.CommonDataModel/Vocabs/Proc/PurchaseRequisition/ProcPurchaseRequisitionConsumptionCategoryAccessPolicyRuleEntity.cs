using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcPurchaseRequisitionConsumptionCategoryAccessPolicyRuleEntityVocabulary : SimpleVocabulary
    {
        public ProcPurchaseRequisitionConsumptionCategoryAccessPolicyRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProcPurchaseRequisitionConsumptionCategoryAccessPolicyRuleEntity";
            KeyPrefix = "commonDataModel.procpurchaserequisitionconsumptioncategoryaccesspolicyruleentity";
            KeySeparator = ".";
            Grouping = "/ProcPurchaseRequisitionConsumptionCategoryAccessPolicyRuleEntity";

            AddGroup("Common Data Model ProcPurchaseRequisitionConsumptionCategoryAccessPolicyRuleEntity Details", group =>
            {
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsParentRuleIncluded = group.Add(new VocabularyKey(nameof(IsParentRuleIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategoryName = group.Add(new VocabularyKey(nameof(ProcurementCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategory = group.Add(new VocabularyKey(nameof(ProcurementCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategoryAccessPolicyRule = group.Add(new VocabularyKey(nameof(ProcurementCategoryAccessPolicyRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Policy = group.Add(new VocabularyKey(nameof(Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleType = group.Add(new VocabularyKey(nameof(PolicyRuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstanceRelationType = group.Add(new VocabularyKey(nameof(InstanceRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleName = group.Add(new VocabularyKey(nameof(PolicyRuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey IsParentRuleIncluded { get; private set; }
        public VocabularyKey ProcurementCategoryName { get; private set; }
        public VocabularyKey ProcurementCategory { get; private set; }
        public VocabularyKey ProcurementCategoryAccessPolicyRule { get; private set; }
        public VocabularyKey Policy { get; private set; }
        public VocabularyKey PolicyRuleType { get; private set; }
        public VocabularyKey InstanceRelationType { get; private set; }
        public VocabularyKey PolicyRuleName { get; private set; }
        public VocabularyKey PurchasingPolicyName { get; private set; }


    }
}