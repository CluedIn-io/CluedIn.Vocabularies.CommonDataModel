using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseLocationDirectiveLineActionV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseLocationDirectiveLineActionV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseLocationDirectiveLineActionV2Entity";
            KeyPrefix = "commonDataModel.whswarehouselocationdirectivelineactionv2entity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseLocationDirectiveLineActionV2Entity";

            AddGroup("Common Data Model WHSWarehouseLocationDirectiveLineActionV2Entity Details", group =>
            {
                WarehouseLocationDirectiveWorkOrderType = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveWorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveId = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveWorkType = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveWorkType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveInventorySiteId = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveInventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveWarehouseId = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveLineSequenceNumber = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveLineSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionSequenceNumber = group.Add(new VocabularyKey(nameof(ActionSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionName = group.Add(new VocabularyKey(nameof(ActionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedLocationUsageMethod = group.Add(new VocabularyKey(nameof(FixedLocationUsageMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsNegativeInventoryAllowed = group.Add(new VocabularyKey(nameof(IsNegativeInventoryAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsItemBatchEnabled = group.Add(new VocabularyKey(nameof(IsItemBatchEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionStrategy = group.Add(new VocabularyKey(nameof(ActionStrategy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionQuery = group.Add(new VocabularyKey(nameof(ActionQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WHSLocDirLine_RefRecId = group.Add(new VocabularyKey(nameof(WHSLocDirLine_RefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefRecId = group.Add(new VocabularyKey(nameof(RefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WarehouseLocationDirectiveWorkOrderType { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveId { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveWorkType { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveInventorySiteId { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveWarehouseId { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveLineSequenceNumber { get; private set; }
        public VocabularyKey ActionSequenceNumber { get; private set; }
        public VocabularyKey ActionName { get; private set; }
        public VocabularyKey FixedLocationUsageMethod { get; private set; }
        public VocabularyKey IsNegativeInventoryAllowed { get; private set; }
        public VocabularyKey IsItemBatchEnabled { get; private set; }
        public VocabularyKey ActionStrategy { get; private set; }
        public VocabularyKey ActionQuery { get; private set; }
        public VocabularyKey WHSLocDirLine_RefRecId { get; private set; }
        public VocabularyKey RefRecId { get; private set; }


    }
}