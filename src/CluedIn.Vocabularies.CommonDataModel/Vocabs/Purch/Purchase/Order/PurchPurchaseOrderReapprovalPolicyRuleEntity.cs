using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseOrderReapprovalPolicyRuleEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseOrderReapprovalPolicyRuleEntityVocabulary()
        {
            VocabularyName = "Purch Purchase Order Reapproval Policy Rule Entity";
            KeyPrefix = "commonDataModel.purchpurchaseorderreapprovalpolicyruleentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseOrderReapprovalPolicyRuleEntity";

            AddGroup("PurchPurchaseOrderReapprovalPolicyRuleEntity Details", group =>
            {
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Policy = group.Add(new VocabularyKey(nameof(Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleType = group.Add(new VocabularyKey(nameof(PolicyRuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleName = group.Add(new VocabularyKey(nameof(PolicyRuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReapprovalTableName = group.Add(new VocabularyKey(nameof(ReapprovalTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReapprovalFieldName = group.Add(new VocabularyKey(nameof(ReapprovalFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReapprovalFieldId = group.Add(new VocabularyKey(nameof(ReapprovalFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReapprovalTableId = group.Add(new VocabularyKey(nameof(ReapprovalTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey PurchasingPolicyName { get; private set; }
        public VocabularyKey Policy { get; private set; }
        public VocabularyKey PolicyRuleType { get; private set; }
        public VocabularyKey PolicyRuleName { get; private set; }
        public VocabularyKey ReapprovalTableName { get; private set; }
        public VocabularyKey ReapprovalFieldName { get; private set; }
        public VocabularyKey ReapprovalFieldId { get; private set; }
        public VocabularyKey ReapprovalTableId { get; private set; }
    }
}