using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseRequisitionConsumptionControlPolicyRuleEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseRequisitionConsumptionControlPolicyRuleEntityVocabulary()
        {
            VocabularyName = "PurchPurchaseRequisitionConsumptionControlPolicyRuleEntity";
            KeyPrefix = "commonDataModel.purchpurchaserequisitionconsumptioncontrolpolicyruleentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseRequisitionConsumptionControlPolicyRuleEntity";

            AddGroup("PurchPurchaseRequisitionConsumptionControlPolicyRuleEntity Details", group =>
            {
                Policy = group.Add(new VocabularyKey(nameof(Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleType = group.Add(new VocabularyKey(nameof(PolicyRuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchaseRequisitionAllowAlternateAddress = group.Add(new VocabularyKey(nameof(WillPurchaseRequisitionAllowAlternateAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSystemAutoCorrectMaximumPurchaseRequisitionQuantity = group.Add(new VocabularyKey(nameof(WillSystemAutoCorrectMaximumPurchaseRequisitionQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSystemAutoCorrectMinimumPurchaseRequisitionQuantity = group.Add(new VocabularyKey(nameof(WillSystemAutoCorrectMinimumPurchaseRequisitionQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSystemAutoCorrectMultiplePurchaseRequisitionQuantities = group.Add(new VocabularyKey(nameof(WillSystemAutoCorrectMultiplePurchaseRequisitionQuantities), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRequiredDateDefaultAccountingDate = group.Add(new VocabularyKey(nameof(IsRequiredDateDefaultAccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleName = group.Add(new VocabularyKey(nameof(PolicyRuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Policy { get; private set; }
        public VocabularyKey PolicyRuleType { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey WillPurchaseRequisitionAllowAlternateAddress { get; private set; }
        public VocabularyKey WillSystemAutoCorrectMaximumPurchaseRequisitionQuantity { get; private set; }
        public VocabularyKey WillSystemAutoCorrectMinimumPurchaseRequisitionQuantity { get; private set; }
        public VocabularyKey WillSystemAutoCorrectMultiplePurchaseRequisitionQuantities { get; private set; }
        public VocabularyKey IsRequiredDateDefaultAccountingDate { get; private set; }
        public VocabularyKey PolicyRuleName { get; private set; }
        public VocabularyKey PurchasingPolicyName { get; private set; }


    }
}