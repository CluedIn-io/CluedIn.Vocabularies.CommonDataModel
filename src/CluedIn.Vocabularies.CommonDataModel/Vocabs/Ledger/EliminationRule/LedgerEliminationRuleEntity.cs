using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerEliminationRuleEntityVocabulary : SimpleVocabulary
    {
        public LedgerEliminationRuleEntityVocabulary()
        {
            VocabularyName = "LedgerEliminationRuleEntity";
            KeyPrefix = "commonDataModel.ledgereliminationruleentity";
            KeySeparator = ".";
            Grouping = "/LedgerEliminationRuleEntity";

            AddGroup("LedgerEliminationRuleEntity Details", group =>
            {
                Active = group.Add(new VocabularyKey(nameof(Active), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateLastRun = group.Add(new VocabularyKey(nameof(DateLastRun), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationCompany = group.Add(new VocabularyKey(nameof(DestinationCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveEndDate = group.Add(new VocabularyKey(nameof(EffectiveEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveStartDate = group.Add(new VocabularyKey(nameof(EffectiveStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleId = group.Add(new VocabularyKey(nameof(RuleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceCompany = group.Add(new VocabularyKey(nameof(SourceCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Active { get; private set; }
        public VocabularyKey DateLastRun { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DestinationCompany { get; private set; }
        public VocabularyKey EffectiveEndDate { get; private set; }
        public VocabularyKey EffectiveStartDate { get; private set; }
        public VocabularyKey RuleId { get; private set; }
        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey SourceCompany { get; private set; }


    }
}