using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInfocodeLineEntityVocabulary : SimpleVocabulary
    {
        public RetailInfocodeLineEntityVocabulary()
        {
            VocabularyName = "Retail Infocode Line Entity";
            KeyPrefix = "commonDataModel.retailinfocodelineentity";
            KeySeparator = ".";
            Grouping = "/RetailInfocodeLineEntity";

            AddGroup("RetailInfocodeLineEntity Details", group =>
            {
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InformationAmount = group.Add(new VocabularyKey(nameof(InformationAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InfocodeId = group.Add(new VocabularyKey(nameof(InfocodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Information = group.Add(new VocabularyKey(nameof(Information), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InputType = group.Add(new VocabularyKey(nameof(InputType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemTender = group.Add(new VocabularyKey(nameof(ItemTender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceCode = group.Add(new VocabularyKey(nameof(SourceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceCode2 = group.Add(new VocabularyKey(nameof(SourceCode2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceCode3 = group.Add(new VocabularyKey(nameof(SourceCode3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementCode = group.Add(new VocabularyKey(nameof(StatementCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubInfocodeId = group.Add(new VocabularyKey(nameof(SubInfocodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InfocodeLineType = group.Add(new VocabularyKey(nameof(InfocodeLineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryLotId = group.Add(new VocabularyKey(nameof(InventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalLineNumber = group.Add(new VocabularyKey(nameof(JournalLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey InformationAmount { get; private set; }
        public VocabularyKey InfocodeId { get; private set; }
        public VocabularyKey Information { get; private set; }
        public VocabularyKey InputType { get; private set; }
        public VocabularyKey ItemTender { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey SourceCode { get; private set; }
        public VocabularyKey SourceCode2 { get; private set; }
        public VocabularyKey SourceCode3 { get; private set; }
        public VocabularyKey StatementCode { get; private set; }
        public VocabularyKey SubInfocodeId { get; private set; }
        public VocabularyKey InfocodeLineType { get; private set; }
        public VocabularyKey SalesOrderNumber { get; private set; }
        public VocabularyKey InventoryLotId { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey JournalLineNumber { get; private set; }
    }
}