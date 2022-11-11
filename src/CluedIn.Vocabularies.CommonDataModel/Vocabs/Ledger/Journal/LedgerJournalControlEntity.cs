using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerJournalControlEntityVocabulary : SimpleVocabulary
    {
        public LedgerJournalControlEntityVocabulary()
        {
            VocabularyName = "LedgerJournalControlEntity";
            KeyPrefix = "commonDataModel.ledgerjournalcontrolentity";
            KeySeparator = ".";
            Grouping = "/LedgerJournalControlEntity";

            AddGroup("LedgerJournalControlEntity Details", group =>
            {
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalLegalEntity = group.Add(new VocabularyKey(nameof(JournalLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionConstraintTree = group.Add(new VocabularyKey(nameof(DimensionConstraintTree), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructure = group.Add(new VocabularyKey(nameof(AccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerJournalControl = group.Add(new VocabularyKey(nameof(LedgerJournalControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerLegalEntity = group.Add(new VocabularyKey(nameof(LedgerLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromValue = group.Add(new VocabularyKey(nameof(FromValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToValue = group.Add(new VocabularyKey(nameof(ToValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segment = group.Add(new VocabularyKey(nameof(Segment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey JournalLegalEntity { get; private set; }
        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey DimensionConstraintTree { get; private set; }
        public VocabularyKey AccountStructure { get; private set; }
        public VocabularyKey LedgerJournalControl { get; private set; }
        public VocabularyKey LedgerLegalEntity { get; private set; }
        public VocabularyKey FromValue { get; private set; }
        public VocabularyKey ToValue { get; private set; }
        public VocabularyKey Segment { get; private set; }


    }
}