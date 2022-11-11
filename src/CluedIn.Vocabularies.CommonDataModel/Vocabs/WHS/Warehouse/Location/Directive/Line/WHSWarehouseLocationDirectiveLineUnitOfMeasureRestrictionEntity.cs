using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseLocationDirectiveLineUnitOfMeasureRestrictionEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseLocationDirectiveLineUnitOfMeasureRestrictionEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseLocationDirectiveLineUnitOfMeasureRestrictionEntity";
            KeyPrefix = "commonDataModel.whswarehouselocationdirectivelineunitofmeasurerestrictionentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseLocationDirectiveLineUnitOfMeasureRestrictionEntity";

            AddGroup("Common Data Model WHSWarehouseLocationDirectiveLineUnitOfMeasureRestrictionEntity Details", group =>
            {
                WarehouseLocationDirectiveWorkOrderType = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveWorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveId = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveWorkType = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveWorkType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveInventorySiteId = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveInventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveWarehouseId = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveLineSequenceNumber = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveLineSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefRecId = group.Add(new VocabularyKey(nameof(RefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WHSLocDirLine_RefRecId = group.Add(new VocabularyKey(nameof(WHSLocDirLine_RefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocSeqNum = group.Add(new VocabularyKey(nameof(LocSeqNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WarehouseLocationDirectiveWorkOrderType { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveId { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveWorkType { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveInventorySiteId { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveWarehouseId { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveLineSequenceNumber { get; private set; }
        public VocabularyKey UnitSymbol { get; private set; }
        public VocabularyKey RefRecId { get; private set; }
        public VocabularyKey WHSLocDirLine_RefRecId { get; private set; }
        public VocabularyKey LocSeqNum { get; private set; }


    }
}