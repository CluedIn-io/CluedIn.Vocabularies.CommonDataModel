using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class GeneralJournalAccountEntryEntityVocabulary : SimpleVocabulary
    {
        public GeneralJournalAccountEntryEntityVocabulary()
        {
            VocabularyName = "GeneralJournalAccountEntryEntity";
            KeyPrefix = "commonDataModel.generaljournalaccountentryentity";
            KeySeparator = ".";
            Grouping = "/GeneralJournalAccountEntryEntity";

            AddGroup("GeneralJournalAccountEntryEntity Details", group =>
            {
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerAccount = group.Add(new VocabularyKey(nameof(LedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyCode = group.Add(new VocabularyKey(nameof(TransactionCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyCreditAmount = group.Add(new VocabularyKey(nameof(TransactionCurrencyCreditAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyDebitAmount = group.Add(new VocabularyKey(nameof(TransactionCurrencyDebitAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingCurrencyAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyAmount = group.Add(new VocabularyKey(nameof(ReportingCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingType = group.Add(new VocabularyKey(nameof(PostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalCategory = group.Add(new VocabularyKey(nameof(JournalCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCorrection = group.Add(new VocabularyKey(nameof(IsCorrection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCredit = group.Add(new VocabularyKey(nameof(IsCredit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcknowledgementDate = group.Add(new VocabularyKey(nameof(AcknowledgementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerName = group.Add(new VocabularyKey(nameof(LedgerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataArea = group.Add(new VocabularyKey(nameof(DataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralJournalAccountEntryRecId = group.Add(new VocabularyKey(nameof(GeneralJournalAccountEntryRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey JournalNumber { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey AccountingDate { get; private set; }
        public VocabularyKey PostingLayer { get; private set; }
        public VocabularyKey LedgerAccount { get; private set; }
        public VocabularyKey TransactionCurrencyCode { get; private set; }
        public VocabularyKey TransactionCurrencyCreditAmount { get; private set; }
        public VocabularyKey TransactionCurrencyDebitAmount { get; private set; }
        public VocabularyKey TransactionCurrencyAmount { get; private set; }
        public VocabularyKey AccountingCurrencyAmount { get; private set; }
        public VocabularyKey ReportingCurrencyAmount { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey PostingType { get; private set; }
        public VocabularyKey JournalCategory { get; private set; }
        public VocabularyKey IsCorrection { get; private set; }
        public VocabularyKey IsCredit { get; private set; }
        public VocabularyKey AcknowledgementDate { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey DocumentNumber { get; private set; }
        public VocabularyKey LedgerName { get; private set; }
        public VocabularyKey DataArea { get; private set; }
        public VocabularyKey GeneralJournalAccountEntryRecId { get; private set; }
        public VocabularyKey AccountDisplayValue { get; private set; }
        public VocabularyKey Account { get; private set; }


    }
}