using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManBlockExclusionRuleEntityVocabulary : SimpleVocabulary
    {
        public CredManBlockExclusionRuleEntityVocabulary()
        {
            VocabularyName = "Cred Man Block Exclusion Rule Entity";
            KeyPrefix = "commonDataModel.credmanblockexclusionruleentity";
            KeySeparator = ".";
            Grouping = "/CredManBlockExclusionRuleEntity";

            AddGroup("CredManBlockExclusionRuleEntity Details", group =>
            {
                CreditLimitThreshold = group.Add(new VocabularyKey(nameof(CreditLimitThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustRelation = group.Add(new VocabularyKey(nameof(CustRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GraceValue = group.Add(new VocabularyKey(nameof(GraceValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RiskGroupId = group.Add(new VocabularyKey(nameof(RiskGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableGroupAll = group.Add(new VocabularyKey(nameof(TableGroupAll), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueType = group.Add(new VocabularyKey(nameof(ValueType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleType = group.Add(new VocabularyKey(nameof(RuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReleaseSalesOrder = group.Add(new VocabularyKey(nameof(ReleaseSalesOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleId = group.Add(new VocabularyKey(nameof(RuleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CreditLimitThreshold { get; private set; }
        public VocabularyKey CustRelation { get; private set; }
        public VocabularyKey GraceValue { get; private set; }
        public VocabularyKey RiskGroupId { get; private set; }
        public VocabularyKey TableGroupAll { get; private set; }
        public VocabularyKey ValueType { get; private set; }
        public VocabularyKey RuleType { get; private set; }
        public VocabularyKey ReleaseSalesOrder { get; private set; }
        public VocabularyKey RuleId { get; private set; }
    }
}