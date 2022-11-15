using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerTransSettlementEntityVocabulary : SimpleVocabulary
    {
        public LedgerTransSettlementEntityVocabulary()
        {
            VocabularyName = "Ledger Trans Settlement Entity";
            KeyPrefix = "commonDataModel.ledgertranssettlemententity";
            KeySeparator = ".";
            Grouping = "/LedgerTransSettlementEntity";

            AddGroup("LedgerTransSettlementEntity Details", group =>
            {
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubledgerVoucher = group.Add(new VocabularyKey(nameof(SubledgerVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(LedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingCurrencyAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyAmount = group.Add(new VocabularyKey(nameof(ReportingCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyCode = group.Add(new VocabularyKey(nameof(TransactionCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingType = group.Add(new VocabularyKey(nameof(PostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateProcessed = group.Add(new VocabularyKey(nameof(DateProcessed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettleDate = group.Add(new VocabularyKey(nameof(SettleDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerAccount = group.Add(new VocabularyKey(nameof(LedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Marked = group.Add(new VocabularyKey(nameof(Marked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettleId = group.Add(new VocabularyKey(nameof(SettleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralJournalAccountEntry = group.Add(new VocabularyKey(nameof(GeneralJournalAccountEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Ledger = group.Add(new VocabularyKey(nameof(Ledger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey JournalNumber { get; private set; }
        public VocabularyKey SubledgerVoucher { get; private set; }
        public VocabularyKey AccountingDate { get; private set; }
        public VocabularyKey LedgerAccountDisplayValue { get; private set; }
        public VocabularyKey AccountingCurrencyAmount { get; private set; }
        public VocabularyKey ReportingCurrencyAmount { get; private set; }
        public VocabularyKey TransactionCurrencyAmount { get; private set; }
        public VocabularyKey TransactionCurrencyCode { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey PostingType { get; private set; }
        public VocabularyKey PostingLayer { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey DocumentNumber { get; private set; }
        public VocabularyKey DateProcessed { get; private set; }
        public VocabularyKey SettleDate { get; private set; }
        public VocabularyKey LedgerAccount { get; private set; }
        public VocabularyKey Marked { get; private set; }
        public VocabularyKey SettleId { get; private set; }
        public VocabularyKey GeneralJournalAccountEntry { get; private set; }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey Text { get; private set; }
        public VocabularyKey Ledger { get; private set; }
    }
}