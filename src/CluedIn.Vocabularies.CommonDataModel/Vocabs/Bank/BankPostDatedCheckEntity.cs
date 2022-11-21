using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankPostDatedCheckEntityVocabulary : SimpleVocabulary
    {
        public BankPostDatedCheckEntityVocabulary()
        {
            VocabularyName = "Bank Post Dated Check Entity";
            KeyPrefix = "commonDataModel.bankpostdatedcheckentity";
            KeySeparator = ".";
            Grouping = "/BankPostDatedCheckEntity";

            AddGroup("BankPostDatedCheckEntity Details", group =>
            {
                BankName = group.Add(new VocabularyKey(nameof(BankName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankBranch = group.Add(new VocabularyKey(nameof(BankBranch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckNumber = group.Add(new VocabularyKey(nameof(CheckNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comments = group.Add(new VocabularyKey(nameof(Comments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReplacementCheck = group.Add(new VocabularyKey(nameof(IsReplacementCheck), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaturityDate = group.Add(new VocabularyKey(nameof(MaturityDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalCheckNumber = group.Add(new VocabularyKey(nameof(OriginalCheckNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostDatedCheckStatus = group.Add(new VocabularyKey(nameof(PostDatedCheckStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonForStop = group.Add(new VocabularyKey(nameof(ReasonForStop), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPaymentStopped = group.Add(new VocabularyKey(nameof(IsPaymentStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerCollectionAgent = group.Add(new VocabularyKey(nameof(WorkerCollectionAgent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerSalesPerson = group.Add(new VocabularyKey(nameof(WorkerSalesPerson), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerJournalTrans = group.Add(new VocabularyKey(nameof(LedgerJournalTrans), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerCollectionAgentRecId = group.Add(new VocabularyKey(nameof(WorkerCollectionAgentRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerSalesPersonRecId = group.Add(new VocabularyKey(nameof(WorkerSalesPersonRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitAmount = group.Add(new VocabularyKey(nameof(DebitAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditAmount = group.Add(new VocabularyKey(nameof(CreditAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BankName { get; private set; }
        public VocabularyKey BankBranch { get; private set; }
        public VocabularyKey CheckNumber { get; private set; }
        public VocabularyKey Comments { get; private set; }
        public VocabularyKey IsReplacementCheck { get; private set; }
        public VocabularyKey MaturityDate { get; private set; }
        public VocabularyKey OriginalCheckNumber { get; private set; }
        public VocabularyKey PostDatedCheckStatus { get; private set; }
        public VocabularyKey ReasonForStop { get; private set; }
        public VocabularyKey IsPaymentStopped { get; private set; }
        public VocabularyKey WorkerCollectionAgent { get; private set; }
        public VocabularyKey WorkerSalesPerson { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey LedgerJournalTrans { get; private set; }
        public VocabularyKey WorkerCollectionAgentRecId { get; private set; }
        public VocabularyKey WorkerSalesPersonRecId { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
        public VocabularyKey DebitAmount { get; private set; }
        public VocabularyKey CreditAmount { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey AccountDisplayValue { get; private set; }
        public VocabularyKey AccountType { get; private set; }
    }
}