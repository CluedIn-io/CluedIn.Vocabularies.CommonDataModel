using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerAdvancedRuleCriterionEntityVocabulary : SimpleVocabulary
    {
        public LedgerAdvancedRuleCriterionEntityVocabulary()
        {
            VocabularyName = "Ledger Advanced Rule Criterion Entity";
            KeyPrefix = "commonDataModel.ledgeradvancedrulecriterionentity";
            KeySeparator = ".";
            Grouping = "/LedgerAdvancedRuleCriterionEntity";

            AddGroup("LedgerAdvancedRuleCriterionEntity Details", group =>
            {
                AccountStructure = group.Add(new VocabularyKey(nameof(AccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvancedRule = group.Add(new VocabularyKey(nameof(AdvancedRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleType = group.Add(new VocabularyKey(nameof(RuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName = group.Add(new VocabularyKey(nameof(SegmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvancedRuleCriterion = group.Add(new VocabularyKey(nameof(AdvancedRuleCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountStructure { get; private set; }
        public VocabularyKey AdvancedRule { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey RuleType { get; private set; }
        public VocabularyKey SegmentName { get; private set; }
        public VocabularyKey AdvancedRuleCriterion { get; private set; }
    }
}