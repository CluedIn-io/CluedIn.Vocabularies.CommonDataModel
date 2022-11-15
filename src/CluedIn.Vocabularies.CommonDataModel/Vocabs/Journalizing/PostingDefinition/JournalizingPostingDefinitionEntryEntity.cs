using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JournalizingPostingDefinitionEntryEntityVocabulary : SimpleVocabulary
    {
        public JournalizingPostingDefinitionEntryEntityVocabulary()
        {
            VocabularyName = "Journalizing Posting Definition Entry Entity";
            KeyPrefix = "commonDataModel.journalizingpostingdefinitionentryentity";
            KeySeparator = ".";
            Grouping = "/JournalizingPostingDefinitionEntryEntity";

            AddGroup("JournalizingPostingDefinitionEntryEntity Details", group =>
            {
                GeneratedEntryAccountStructure = group.Add(new VocabularyKey(nameof(GeneratedEntryAccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalizingDefinitionMatch = group.Add(new VocabularyKey(nameof(JournalizingDefinitionMatch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneratedEntriesDebitCredit = group.Add(new VocabularyKey(nameof(GeneratedEntriesDebitCredit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneratedEntryLedgerAccount = group.Add(new VocabularyKey(nameof(GeneratedEntryLedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchCriteriaAccountStructure = group.Add(new VocabularyKey(nameof(MatchCriteriaAccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalizingDefinitionVersion = group.Add(new VocabularyKey(nameof(JournalizingDefinitionVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchCriteriaLedgerAccount = group.Add(new VocabularyKey(nameof(MatchCriteriaLedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchCriteriaLedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(MatchCriteriaLedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchCriteriaLedgerAccountAccountStructure = group.Add(new VocabularyKey(nameof(MatchCriteriaLedgerAccountAccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneratedEntryLedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(GeneratedEntryLedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneratedEntryLedgerAccountAccountStructure = group.Add(new VocabularyKey(nameof(GeneratedEntryLedgerAccountAccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingDefinitionId = group.Add(new VocabularyKey(nameof(PostingDefinitionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GeneratedEntryAccountStructure { get; private set; }
        public VocabularyKey JournalizingDefinitionMatch { get; private set; }
        public VocabularyKey GeneratedEntriesDebitCredit { get; private set; }
        public VocabularyKey GeneratedEntryLedgerAccount { get; private set; }
        public VocabularyKey MatchCriteriaAccountStructure { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey JournalizingDefinitionVersion { get; private set; }
        public VocabularyKey MatchCriteriaLedgerAccount { get; private set; }
        public VocabularyKey MatchCriteriaLedgerAccountDisplayValue { get; private set; }
        public VocabularyKey MatchCriteriaLedgerAccountAccountStructure { get; private set; }
        public VocabularyKey GeneratedEntryLedgerAccountDisplayValue { get; private set; }
        public VocabularyKey GeneratedEntryLedgerAccountAccountStructure { get; private set; }
        public VocabularyKey PostingDefinitionId { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
    }
}