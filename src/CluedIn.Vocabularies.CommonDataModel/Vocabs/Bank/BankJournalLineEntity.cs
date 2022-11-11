using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankJournalLineEntityVocabulary : SimpleVocabulary
    {
        public BankJournalLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankJournalLineEntity";
            KeyPrefix = "commonDataModel.bankjournallineentity";
            KeySeparator = ".";
            Grouping = "/BankJournalLineEntity";

            AddGroup("Common Data Model BankJournalLineEntity Details", group =>
            {
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditAmount = group.Add(new VocabularyKey(nameof(CreditAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitAmount = group.Add(new VocabularyKey(nameof(DebitAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccountDisplayValue = group.Add(new VocabularyKey(nameof(BankAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountType = group.Add(new VocabularyKey(nameof(OffsetAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetLedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetLedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetText = group.Add(new VocabularyKey(nameof(OffsetText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChineseVoucherTypeRecId = group.Add(new VocabularyKey(nameof(ChineseVoucherTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChineseVoucherType = group.Add(new VocabularyKey(nameof(ChineseVoucherType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChineseVoucher = group.Add(new VocabularyKey(nameof(ChineseVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetCompany = group.Add(new VocabularyKey(nameof(OffsetCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankTransactionType = group.Add(new VocabularyKey(nameof(BankTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey CreditAmount { get; private set; }
        public VocabularyKey DebitAmount { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey Account { get; private set; }
        public VocabularyKey BankAccountDisplayValue { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey OffsetAccountType { get; private set; }
        public VocabularyKey OffsetAccount { get; private set; }
        public VocabularyKey OffsetLedgerAccountDisplayValue { get; private set; }
        public VocabularyKey OffsetText { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
        public VocabularyKey Text { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey ChineseVoucherTypeRecId { get; private set; }
        public VocabularyKey ChineseVoucherType { get; private set; }
        public VocabularyKey ChineseVoucher { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey OffsetCompany { get; private set; }
        public VocabularyKey OffsetAccountDisplayValue { get; private set; }
        public VocabularyKey AccountDisplayValue { get; private set; }
        public VocabularyKey BankTransactionType { get; private set; }


    }
}