using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvPolicyRuleEntityVocabulary : SimpleVocabulary
    {
        public TrvPolicyRuleEntityVocabulary()
        {
            VocabularyName = "TrvPolicyRuleEntity";
            KeyPrefix = "commonDataModel.trvpolicyruleentity";
            KeySeparator = ".";
            Grouping = "/TrvPolicyRuleEntity";

            AddGroup("TrvPolicyRuleEntity Details", group =>
            {
                RelationTypeField = group.Add(new VocabularyKey(nameof(RelationTypeField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncludeParentRule = group.Add(new VocabularyKey(nameof(IncludeParentRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Policy = group.Add(new VocabularyKey(nameof(Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyPolicyType = group.Add(new VocabularyKey(nameof(PolicyPolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleType = group.Add(new VocabularyKey(nameof(PolicyRuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyType = group.Add(new VocabularyKey(nameof(PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRuleName = group.Add(new VocabularyKey(nameof(PolicyRuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyRulesPolicyType = group.Add(new VocabularyKey(nameof(PolicyRulesPolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyType_2 = group.Add(new VocabularyKey(nameof(PolicyType_2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Action = group.Add(new VocabularyKey(nameof(Action), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpressionTableRecId = group.Add(new VocabularyKey(nameof(ExpressionTableRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpressionId = group.Add(new VocabularyKey(nameof(ExpressionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RelationTypeField { get; private set; }
        public VocabularyKey IncludeParentRule { get; private set; }
        public VocabularyKey Policy { get; private set; }
        public VocabularyKey PolicyName { get; private set; }
        public VocabularyKey PolicyPolicyType { get; private set; }
        public VocabularyKey PolicyRuleType { get; private set; }
        public VocabularyKey PolicyType { get; private set; }
        public VocabularyKey PolicyRuleName { get; private set; }
        public VocabularyKey PolicyRulesPolicyType { get; private set; }
        public VocabularyKey PolicyType_2 { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey Action { get; private set; }
        public VocabularyKey ExpressionTableRecId { get; private set; }
        public VocabularyKey ExpressionId { get; private set; }


    }
}