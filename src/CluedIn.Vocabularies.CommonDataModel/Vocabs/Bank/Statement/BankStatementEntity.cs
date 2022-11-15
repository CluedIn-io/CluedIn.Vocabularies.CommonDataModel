using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankStatementEntityVocabulary : SimpleVocabulary
    {
        public BankStatementEntityVocabulary()
        {
            VocabularyName = "Bank Statement Entity";
            KeyPrefix = "commonDataModel.bankstatemententity";
            KeySeparator = ".";
            Grouping = "/BankStatementEntity";

            AddGroup("BankStatementEntity Details", group =>
            {
                AccountCurrency = group.Add(new VocabularyKey(nameof(AccountCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountIdOtherId = group.Add(new VocabularyKey(nameof(AccountIdOtherId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AsOfDateModifier = group.Add(new VocabularyKey(nameof(AsOfDateModifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankStatementType = group.Add(new VocabularyKey(nameof(BankStatementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDateTime = group.Add(new VocabularyKey(nameof(FromDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupControlTotal = group.Add(new VocabularyKey(nameof(GroupControlTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupStatus = group.Add(new VocabularyKey(nameof(GroupStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IBAN = group.Add(new VocabularyKey(nameof(IBAN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Identification = group.Add(new VocabularyKey(nameof(Identification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SwiftNo = group.Add(new VocabularyKey(nameof(SwiftNo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDateTime = group.Add(new VocabularyKey(nameof(ToDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalAccountsInGroup = group.Add(new VocabularyKey(nameof(TotalAccountsInGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalRecordsInGroup = group.Add(new VocabularyKey(nameof(TotalRecordsInGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalEntriesNumberOfEntries = group.Add(new VocabularyKey(nameof(TotalEntriesNumberOfEntries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginatorName = group.Add(new VocabularyKey(nameof(OriginatorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginatorId = group.Add(new VocabularyKey(nameof(OriginatorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UltimateReceiverName = group.Add(new VocabularyKey(nameof(UltimateReceiverName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UltimateReceiverId = group.Add(new VocabularyKey(nameof(UltimateReceiverId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginatorParty = group.Add(new VocabularyKey(nameof(OriginatorParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UltimateReceiverParty = group.Add(new VocabularyKey(nameof(UltimateReceiverParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementLineNum = group.Add(new VocabularyKey(nameof(StatementLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentLineNum = group.Add(new VocabularyKey(nameof(DocumentLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankStmtISODocument = group.Add(new VocabularyKey(nameof(BankStmtISODocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankStatementRecId = group.Add(new VocabularyKey(nameof(BankStatementRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccountTable = group.Add(new VocabularyKey(nameof(BankAccountTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountCurrency { get; private set; }
        public VocabularyKey AccountIdOtherId { get; private set; }
        public VocabularyKey AsOfDateModifier { get; private set; }
        public VocabularyKey BankStatementType { get; private set; }
        public VocabularyKey FromDateTime { get; private set; }
        public VocabularyKey GroupControlTotal { get; private set; }
        public VocabularyKey GroupStatus { get; private set; }
        public VocabularyKey IBAN { get; private set; }
        public VocabularyKey Identification { get; private set; }
        public VocabularyKey SwiftNo { get; private set; }
        public VocabularyKey ToDateTime { get; private set; }
        public VocabularyKey TotalAccountsInGroup { get; private set; }
        public VocabularyKey TotalRecordsInGroup { get; private set; }
        public VocabularyKey TotalEntriesNumberOfEntries { get; private set; }
        public VocabularyKey OriginatorName { get; private set; }
        public VocabularyKey OriginatorId { get; private set; }
        public VocabularyKey UltimateReceiverName { get; private set; }
        public VocabularyKey UltimateReceiverId { get; private set; }
        public VocabularyKey OriginatorParty { get; private set; }
        public VocabularyKey UltimateReceiverParty { get; private set; }
        public VocabularyKey StatementLineNum { get; private set; }
        public VocabularyKey DocumentLineNum { get; private set; }
        public VocabularyKey BankStmtISODocument { get; private set; }
        public VocabularyKey BankStatementRecId { get; private set; }
        public VocabularyKey BankAccountTable { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
    }
}