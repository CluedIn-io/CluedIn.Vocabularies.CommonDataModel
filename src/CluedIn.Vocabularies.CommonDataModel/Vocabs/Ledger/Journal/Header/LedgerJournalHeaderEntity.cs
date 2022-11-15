using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerJournalHeaderEntityVocabulary : SimpleVocabulary
    {
        public LedgerJournalHeaderEntityVocabulary()
        {
            VocabularyName = "Ledger Journal Header Entity";
            KeyPrefix = "commonDataModel.ledgerjournalheaderentity";
            KeySeparator = ".";
            Grouping = "/LedgerJournalHeaderEntity";

            AddGroup("LedgerJournalHeaderEntity Details", group =>
            {
                PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalTotalDebit = group.Add(new VocabularyKey(nameof(JournalTotalDebit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalTotalCredit = group.Add(new VocabularyKey(nameof(JournalTotalCredit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingCurrency = group.Add(new VocabularyKey(nameof(AccountingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegrationKey = group.Add(new VocabularyKey(nameof(IntegrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PostingLayer { get; private set; }
        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey IsPosted { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey JournalTotalDebit { get; private set; }
        public VocabularyKey JournalTotalCredit { get; private set; }
        public VocabularyKey AccountingCurrency { get; private set; }
        public VocabularyKey IntegrationKey { get; private set; }
    }
}