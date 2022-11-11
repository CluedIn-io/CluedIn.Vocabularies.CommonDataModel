using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseRequisitionRequestForQuotationControlPolicyRuleEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseRequisitionRequestForQuotationControlPolicyRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPurchaseRequisitionRequestForQuotationControlPolicyRuleEntity";
            KeyPrefix = "commonDataModel.purchpurchaserequisitionrequestforquotationcontrolpolicyruleentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseRequisitionRequestForQuotationControlPolicyRuleEntity";

            AddGroup("Common Data Model PurchPurchaseRequisitionRequestForQuotationControlPolicyRuleEntity Details", group =>
            {
                Policy = group.Add(new VocabularyKey(nameof(Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleType = group.Add(new VocabularyKey(nameof(PolicyRuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormalRFQInstruction = group.Add(new VocabularyKey(nameof(FormalRFQInstruction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormalRFQRequirementRule = group.Add(new VocabularyKey(nameof(FormalRFQRequirementRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormalRFQThresholdAmount = group.Add(new VocabularyKey(nameof(FormalRFQThresholdAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormalRFQThresholdAmountCurrencyCode = group.Add(new VocabularyKey(nameof(FormalRFQThresholdAmountCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleName = group.Add(new VocabularyKey(nameof(PolicyRuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InformalRFQInstruction = group.Add(new VocabularyKey(nameof(InformalRFQInstruction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InformalRFQRequirementRule = group.Add(new VocabularyKey(nameof(InformalRFQRequirementRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InformalRFQThresholdAmount = group.Add(new VocabularyKey(nameof(InformalRFQThresholdAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InformalRFQThresholdAmountCurrencyCode = group.Add(new VocabularyKey(nameof(InformalRFQThresholdAmountCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Policy { get; private set; }
        public VocabularyKey PolicyRuleType { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey FormalRFQInstruction { get; private set; }
        public VocabularyKey FormalRFQRequirementRule { get; private set; }
        public VocabularyKey FormalRFQThresholdAmount { get; private set; }
        public VocabularyKey FormalRFQThresholdAmountCurrencyCode { get; private set; }
        public VocabularyKey PurchasingPolicyName { get; private set; }
        public VocabularyKey PolicyRuleName { get; private set; }
        public VocabularyKey InformalRFQInstruction { get; private set; }
        public VocabularyKey InformalRFQRequirementRule { get; private set; }
        public VocabularyKey InformalRFQThresholdAmount { get; private set; }
        public VocabularyKey InformalRFQThresholdAmountCurrencyCode { get; private set; }


    }
}