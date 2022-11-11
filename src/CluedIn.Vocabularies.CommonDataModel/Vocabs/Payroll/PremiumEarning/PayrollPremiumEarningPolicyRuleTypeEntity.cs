using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollPremiumEarningPolicyRuleTypeEntityVocabulary : SimpleVocabulary
    {
        public PayrollPremiumEarningPolicyRuleTypeEntityVocabulary()
        {
            VocabularyName = "PayrollPremiumEarningPolicyRuleTypeEntity";
            KeyPrefix = "commonDataModel.payrollpremiumearningpolicyruletypeentity";
            KeySeparator = ".";
            Grouping = "/PayrollPremiumEarningPolicyRuleTypeEntity";

            AddGroup("PayrollPremiumEarningPolicyRuleTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleName = group.Add(new VocabularyKey(nameof(RuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueryName = group.Add(new VocabularyKey(nameof(QueryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncludeParentRules = group.Add(new VocabularyKey(nameof(IncludeParentRules), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrecedenceSupported = group.Add(new VocabularyKey(nameof(IsPrecedenceSupported), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyType = group.Add(new VocabularyKey(nameof(PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey RuleName { get; private set; }
        public VocabularyKey QueryName { get; private set; }
        public VocabularyKey IncludeParentRules { get; private set; }
        public VocabularyKey IsPrecedenceSupported { get; private set; }
        public VocabularyKey PolicyType { get; private set; }


    }
}