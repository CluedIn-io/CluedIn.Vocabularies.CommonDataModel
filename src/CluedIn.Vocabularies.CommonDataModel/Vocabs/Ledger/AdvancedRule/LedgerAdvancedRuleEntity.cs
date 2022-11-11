using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerAdvancedRuleEntityVocabulary : SimpleVocabulary
    {
        public LedgerAdvancedRuleEntityVocabulary()
        {
            VocabularyName = "LedgerAdvancedRuleEntity";
            KeyPrefix = "commonDataModel.ledgeradvancedruleentity";
            KeySeparator = ".";
            Grouping = "/LedgerAdvancedRuleEntity";

            AddGroup("LedgerAdvancedRuleEntity Details", group =>
            {
                AccountStructure = group.Add(new VocabularyKey(nameof(AccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvancedRuleName = group.Add(new VocabularyKey(nameof(AdvancedRuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleType = group.Add(new VocabularyKey(nameof(RuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvancedRuleStructure1 = group.Add(new VocabularyKey(nameof(AdvancedRuleStructure1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvancedRuleStructure2 = group.Add(new VocabularyKey(nameof(AdvancedRuleStructure2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvancedRuleStructure3 = group.Add(new VocabularyKey(nameof(AdvancedRuleStructure3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvancedRuleStructure4 = group.Add(new VocabularyKey(nameof(AdvancedRuleStructure4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountStructure { get; private set; }
        public VocabularyKey AdvancedRuleName { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey RuleType { get; private set; }
        public VocabularyKey AdvancedRuleStructure1 { get; private set; }
        public VocabularyKey AdvancedRuleStructure2 { get; private set; }
        public VocabularyKey AdvancedRuleStructure3 { get; private set; }
        public VocabularyKey AdvancedRuleStructure4 { get; private set; }


    }
}