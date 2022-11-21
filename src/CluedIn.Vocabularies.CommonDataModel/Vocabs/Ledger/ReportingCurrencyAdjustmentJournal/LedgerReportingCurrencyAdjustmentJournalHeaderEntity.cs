using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerReportingCurrencyAdjustmentJournalHeaderEntityVocabulary : SimpleVocabulary
    {
        public LedgerReportingCurrencyAdjustmentJournalHeaderEntityVocabulary()
        {
            VocabularyName = "Ledger Reporting Currency Adjustment Journal Header Entity";
            KeyPrefix = "commonDataModel.ledgerreportingcurrencyadjustmentjournalheaderentity";
            KeySeparator = ".";
            Grouping = "/LedgerReportingCurrencyAdjustmentJournalHeaderEntity";

            AddGroup("LedgerReportingCurrencyAdjustmentJournalHeaderEntity Details", group =>
            {
                PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalTotalDebitReportingCurrency = group.Add(new VocabularyKey(nameof(JournalTotalDebitReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalTotalCreditReportingCurrency = group.Add(new VocabularyKey(nameof(JournalTotalCreditReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrency = group.Add(new VocabularyKey(nameof(ReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PostingLayer { get; private set; }
        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey IsPosted { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey JournalTotalDebitReportingCurrency { get; private set; }
        public VocabularyKey JournalTotalCreditReportingCurrency { get; private set; }
        public VocabularyKey ReportingCurrency { get; private set; }
    }
}