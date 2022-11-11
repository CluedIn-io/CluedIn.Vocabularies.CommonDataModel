using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseLocationDirectiveV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseLocationDirectiveV2EntityVocabulary()
        {
            VocabularyName = "WHSWarehouseLocationDirectiveV2Entity";
            KeyPrefix = "commonDataModel.whswarehouselocationdirectivev2entity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseLocationDirectiveV2Entity";

            AddGroup("WHSWarehouseLocationDirectiveV2Entity Details", group =>
            {
                WorkOrderType = group.Add(new VocabularyKey(nameof(WorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirectiveId = group.Add(new VocabularyKey(nameof(DirectiveId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkType = group.Add(new VocabularyKey(nameof(WorkType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventorySiteId = group.Add(new VocabularyKey(nameof(InventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveCode = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptDispositionCode = group.Add(new VocabularyKey(nameof(ReceiptDispositionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreMultipleItemsEnabled = group.Add(new VocabularyKey(nameof(AreMultipleItemsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirectiveQuery = group.Add(new VocabularyKey(nameof(DirectiveQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirectiveQueryStrategy = group.Add(new VocabularyKey(nameof(DirectiveQueryStrategy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApplicableWarehouseDispositionCodeRule = group.Add(new VocabularyKey(nameof(ApplicableWarehouseDispositionCodeRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WorkOrderType { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey DirectiveId { get; private set; }
        public VocabularyKey WorkType { get; private set; }
        public VocabularyKey InventorySiteId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveCode { get; private set; }
        public VocabularyKey ReceiptDispositionCode { get; private set; }
        public VocabularyKey AreMultipleItemsEnabled { get; private set; }
        public VocabularyKey DirectiveQuery { get; private set; }
        public VocabularyKey DirectiveQueryStrategy { get; private set; }
        public VocabularyKey ApplicableWarehouseDispositionCodeRule { get; private set; }


    }
}