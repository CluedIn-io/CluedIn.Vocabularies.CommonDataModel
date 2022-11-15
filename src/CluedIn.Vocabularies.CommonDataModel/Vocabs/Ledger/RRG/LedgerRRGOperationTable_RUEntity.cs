using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerRRGOperationTable_RUEntityVocabulary : SimpleVocabulary
    {
        public LedgerRRGOperationTable_RUEntityVocabulary()
        {
            VocabularyName = "Ledger RRG Operation Table _RU Entity";
            KeyPrefix = "commonDataModel.ledgerrrgoperationtable_ruentity";
            KeySeparator = ".";
            Grouping = "/LedgerRRGOperationTable_RUEntity";

            AddGroup("LedgerRRGOperationTable_RUEntity Details", group =>
            {
                AccountIntervalType = group.Add(new VocabularyKey(nameof(AccountIntervalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNumMask = group.Add(new VocabularyKey(nameof(AccountNumMask), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceDetail = group.Add(new VocabularyKey(nameof(BalanceDetail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceType = group.Add(new VocabularyKey(nameof(BalanceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CellRecId = group.Add(new VocabularyKey(nameof(CellRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CellTableId = group.Add(new VocabularyKey(nameof(CellTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConstantText = group.Add(new VocabularyKey(nameof(ConstantText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConstantValue = group.Add(new VocabularyKey(nameof(ConstantValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataType = group.Add(new VocabularyKey(nameof(DataType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerOperation = group.Add(new VocabularyKey(nameof(LedgerOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerPeriodCode = group.Add(new VocabularyKey(nameof(LedgerPeriodCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModelNum = group.Add(new VocabularyKey(nameof(ModelNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountIntervalType = group.Add(new VocabularyKey(nameof(OffsetAccountIntervalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountNumMask = group.Add(new VocabularyKey(nameof(OffsetAccountNumMask), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Operation = group.Add(new VocabularyKey(nameof(Operation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Query = group.Add(new VocabularyKey(nameof(Query), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueryBaseDateField = group.Add(new VocabularyKey(nameof(QueryBaseDateField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueryFieldOperation = group.Add(new VocabularyKey(nameof(QueryFieldOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuerySelectedField = group.Add(new VocabularyKey(nameof(QuerySelectedField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25FieldId = group.Add(new VocabularyKey(nameof(RTax25FieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25RegisterId = group.Add(new VocabularyKey(nameof(RTax25RegisterId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeByCorrect = group.Add(new VocabularyKey(nameof(TypeByCorrect), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuerySelectReportDate = group.Add(new VocabularyKey(nameof(QuerySelectReportDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerRRGEProperties_W_PropertyId = group.Add(new VocabularyKey(nameof(LedgerRRGEProperties_W_PropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefTableName = group.Add(new VocabularyKey(nameof(RefTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefLineId = group.Add(new VocabularyKey(nameof(RefLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountIntervalType { get; private set; }
        public VocabularyKey AccountNumMask { get; private set; }
        public VocabularyKey BalanceDetail { get; private set; }
        public VocabularyKey BalanceType { get; private set; }
        public VocabularyKey CellRecId { get; private set; }
        public VocabularyKey CellTableId { get; private set; }
        public VocabularyKey ConstantText { get; private set; }
        public VocabularyKey ConstantValue { get; private set; }
        public VocabularyKey DataType { get; private set; }
        public VocabularyKey LedgerOperation { get; private set; }
        public VocabularyKey LedgerPeriodCode { get; private set; }
        public VocabularyKey LineNum { get; private set; }
        public VocabularyKey ModelNum { get; private set; }
        public VocabularyKey OffsetAccountIntervalType { get; private set; }
        public VocabularyKey OffsetAccountNumMask { get; private set; }
        public VocabularyKey Operation { get; private set; }
        public VocabularyKey Query { get; private set; }
        public VocabularyKey QueryBaseDateField { get; private set; }
        public VocabularyKey QueryFieldOperation { get; private set; }
        public VocabularyKey QuerySelectedField { get; private set; }
        public VocabularyKey RTax25FieldId { get; private set; }
        public VocabularyKey RTax25RegisterId { get; private set; }
        public VocabularyKey TypeByCorrect { get; private set; }
        public VocabularyKey QuerySelectReportDate { get; private set; }
        public VocabularyKey LineId { get; private set; }
        public VocabularyKey LedgerRRGEProperties_W_PropertyId { get; private set; }
        public VocabularyKey RefTableName { get; private set; }
        public VocabularyKey RefLineId { get; private set; }
    }
}