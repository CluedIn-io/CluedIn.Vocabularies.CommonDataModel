using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManCreditLimitRuleLineEntityVocabulary : SimpleVocabulary
    {
        public CredManCreditLimitRuleLineEntityVocabulary()
        {
            VocabularyName = "CredManCreditLimitRuleLineEntity";
            KeyPrefix = "commonDataModel.credmancreditlimitrulelineentity";
            KeySeparator = ".";
            Grouping = "/CredManCreditLimitRuleLineEntity";

            AddGroup("CredManCreditLimitRuleLineEntity Details", group =>
            {
                ComparisonOperator = group.Add(new VocabularyKey(nameof(ComparisonOperator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComparisonValue = group.Add(new VocabularyKey(nameof(ComparisonValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditMax = group.Add(new VocabularyKey(nameof(CreditMax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefRecId = group.Add(new VocabularyKey(nameof(RefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RiskScoreGroupId = group.Add(new VocabularyKey(nameof(RiskScoreGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleCurrencyCode = group.Add(new VocabularyKey(nameof(RuleCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleRiskGroupId = group.Add(new VocabularyKey(nameof(RuleRiskGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ComparisonOperator { get; private set; }
        public VocabularyKey ComparisonValue { get; private set; }
        public VocabularyKey CreditMax { get; private set; }
        public VocabularyKey LineNum { get; private set; }
        public VocabularyKey RefRecId { get; private set; }
        public VocabularyKey RiskScoreGroupId { get; private set; }
        public VocabularyKey RuleCurrencyCode { get; private set; }
        public VocabularyKey RuleRiskGroupId { get; private set; }


    }
}