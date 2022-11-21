using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseSlottingTemplateDetailsV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseSlottingTemplateDetailsV2EntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Slotting Template Details V2 Entity";
            KeyPrefix = "commonDataModel.whswarehouseslottingtemplatedetailsv2entity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseSlottingTemplateDetailsV2Entity";

            AddGroup("WHSWarehouseSlottingTemplateDetailsV2Entity Details", group =>
            {
                SlotCriteriaAssignmentRule = group.Add(new VocabularyKey(nameof(SlotCriteriaAssignmentRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLetUpWorkCreationAllowed = group.Add(new VocabularyKey(nameof(IsLetUpWorkCreationAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DetailsDescription = group.Add(new VocabularyKey(nameof(DetailsDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumSlottingQuantity = group.Add(new VocabularyKey(nameof(MaximumSlottingQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumSlottingQuantity = group.Add(new VocabularyKey(nameof(MinimumSlottingQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverflowLocation = group.Add(new VocabularyKey(nameof(OverflowLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SlotTemplate = group.Add(new VocabularyKey(nameof(SlotTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseSlottingUnitTierId = group.Add(new VocabularyKey(nameof(WarehouseSlottingUnitTierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateDetailsQuery = group.Add(new VocabularyKey(nameof(TemplateDetailsQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SlottingUnitSymbol = group.Add(new VocabularyKey(nameof(SlottingUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationDirectiveCode = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedLocationUsageMethod = group.Add(new VocabularyKey(nameof(FixedLocationUsageMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseSlottingTemplateId = group.Add(new VocabularyKey(nameof(WarehouseSlottingTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverflowWarehouseId = group.Add(new VocabularyKey(nameof(OverflowWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverflowWarehouseLocationId = group.Add(new VocabularyKey(nameof(OverflowWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey SlotCriteriaAssignmentRule { get; private set; }
        public VocabularyKey IsLetUpWorkCreationAllowed { get; private set; }
        public VocabularyKey DetailsDescription { get; private set; }
        public VocabularyKey MaximumSlottingQuantity { get; private set; }
        public VocabularyKey MinimumSlottingQuantity { get; private set; }
        public VocabularyKey OverflowLocation { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey SlotTemplate { get; private set; }
        public VocabularyKey WarehouseSlottingUnitTierId { get; private set; }
        public VocabularyKey TemplateDetailsQuery { get; private set; }
        public VocabularyKey SlottingUnitSymbol { get; private set; }
        public VocabularyKey WarehouseLocationDirectiveCode { get; private set; }
        public VocabularyKey FixedLocationUsageMethod { get; private set; }
        public VocabularyKey WarehouseSlottingTemplateId { get; private set; }
        public VocabularyKey OverflowWarehouseId { get; private set; }
        public VocabularyKey OverflowWarehouseLocationId { get; private set; }
    }
}