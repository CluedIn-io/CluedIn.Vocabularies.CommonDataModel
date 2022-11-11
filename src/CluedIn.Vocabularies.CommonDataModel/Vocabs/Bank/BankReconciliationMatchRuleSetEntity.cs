using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankReconciliationMatchRuleSetEntityVocabulary : SimpleVocabulary
    {
        public BankReconciliationMatchRuleSetEntityVocabulary()
        {
            VocabularyName = "BankReconciliationMatchRuleSetEntity";
            KeyPrefix = "commonDataModel.bankreconciliationmatchrulesetentity";
            KeySeparator = ".";
            Grouping = "/BankReconciliationMatchRuleSetEntity";

            AddGroup("BankReconciliationMatchRuleSetEntity Details", group =>
            {
                MatchingRuleSet = group.Add(new VocabularyKey(nameof(MatchingRuleSet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchingRule = group.Add(new VocabularyKey(nameof(MatchingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconciliationMatchRule = group.Add(new VocabularyKey(nameof(ReconciliationMatchRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MatchingRuleSet { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey MatchingRule { get; private set; }
        public VocabularyKey ReconciliationMatchRule { get; private set; }


    }
}