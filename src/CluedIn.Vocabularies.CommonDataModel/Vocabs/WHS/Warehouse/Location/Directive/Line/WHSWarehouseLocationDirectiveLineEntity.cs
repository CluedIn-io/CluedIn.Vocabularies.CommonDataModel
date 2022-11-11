using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseLocationDirectiveLineEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseLocationDirectiveLineEntityVocabulary()
        {
            VocabularyName = "WHSWarehouseLocationDirectiveLineEntity";
            KeyPrefix = "commonDataModel.whswarehouselocationdirectivelineentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseLocationDirectiveLineEntity";

            AddGroup("WHSWarehouseLocationDirectiveLineEntity Details", group =>
            {
                WarehouseLocationDirectiveWorkOrderType = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveWorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveId = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveWorkType = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveWorkType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveInventorySiteId = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveInventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveWarehouseId = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumWarehouseWorkOrderLineQuantity = group.Add(new VocabularyKey(nameof(MinimumWarehouseWorkOrderLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumWarehouseWorkOrderLineQuantity = group.Add(new VocabularyKey(nameof(MaximumWarehouseWorkOrderLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkOrderLineQuantityUnitSymbol = group.Add(new VocabularyKey(nameof(WarehouseWorkOrderLineQuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocateQuantityMethod = group.Add(new VocabularyKey(nameof(LocateQuantityMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsUnitOfMeasureRestrictionEnabled = group.Add(new VocabularyKey(nameof(IsUnitOfMeasureRestrictionEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPackingQuantityLocated = group.Add(new VocabularyKey(nameof(IsPackingQuantityLocated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWarehouseWorkOrderLineSplittingAllowed = group.Add(new VocabularyKey(nameof(IsWarehouseWorkOrderLineSplittingAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefRecId = group.Add(new VocabularyKey(nameof(RefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillRestrictingUnitQuantityCalculationRoundUp = group.Add(new VocabularyKey(nameof(WillRestrictingUnitQuantityCalculationRoundUp), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImmediateWarehouseReplenishmentTemplateId = group.Add(new VocabularyKey(nameof(ImmediateWarehouseReplenishmentTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WarehouseLocationDirectiveWorkOrderType { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveId { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveWorkType { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveInventorySiteId { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveWarehouseId { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey MinimumWarehouseWorkOrderLineQuantity { get; private set; }
        public VocabularyKey MaximumWarehouseWorkOrderLineQuantity { get; private set; }
        public VocabularyKey WarehouseWorkOrderLineQuantityUnitSymbol { get; private set; }
        public VocabularyKey LocateQuantityMethod { get; private set; }
        public VocabularyKey IsUnitOfMeasureRestrictionEnabled { get; private set; }
        public VocabularyKey IsPackingQuantityLocated { get; private set; }
        public VocabularyKey IsWarehouseWorkOrderLineSplittingAllowed { get; private set; }
        public VocabularyKey RefRecId { get; private set; }
        public VocabularyKey WillRestrictingUnitQuantityCalculationRoundUp { get; private set; }
        public VocabularyKey ImmediateWarehouseReplenishmentTemplateId { get; private set; }


    }
}