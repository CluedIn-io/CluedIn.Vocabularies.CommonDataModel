using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkTemplateV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkTemplateV2EntityVocabulary()
        {
            VocabularyName = "WHSWarehouseWorkTemplateV2Entity";
            KeyPrefix = "commonDataModel.whswarehouseworktemplatev2entity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkTemplateV2Entity";

            AddGroup("WHSWarehouseWorkTemplateV2Entity Details", group =>
            {
                WorkOrderType = group.Add(new VocabularyKey(nameof(WorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateSequenceNumber = group.Add(new VocabularyKey(nameof(TemplateSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateDescription = group.Add(new VocabularyKey(nameof(TemplateDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAutomaticProcessingAllowed = group.Add(new VocabularyKey(nameof(IsAutomaticProcessingAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkPoolId = group.Add(new VocabularyKey(nameof(WarehouseWorkPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchAllocationStrategy = group.Add(new VocabularyKey(nameof(ItemBatchAllocationStrategy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultWarehouseWorkOrderPriority = group.Add(new VocabularyKey(nameof(DefaultWarehouseWorkOrderPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkHeaderMaximumEstimatedPickTime = group.Add(new VocabularyKey(nameof(WarehouseWorkHeaderMaximumEstimatedPickTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumWarehouseWorkOrderPickLines = group.Add(new VocabularyKey(nameof(MaximumWarehouseWorkOrderPickLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumWarehouseWorkOrderQuantity = group.Add(new VocabularyKey(nameof(MaximumWarehouseWorkOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumWarehouseWorkOrderVolume = group.Add(new VocabularyKey(nameof(MaximumWarehouseWorkOrderVolume), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumWarehouseWorkOrderWeight = group.Add(new VocabularyKey(nameof(MaximumWarehouseWorkOrderWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumWarehouseWorkOrderLineVolume = group.Add(new VocabularyKey(nameof(MaximumWarehouseWorkOrderLineVolume), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumWarehouseWorkOrderLineWeight = group.Add(new VocabularyKey(nameof(MaximumWarehouseWorkOrderLineWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumWarehouseWorkOrderLineQuantity = group.Add(new VocabularyKey(nameof(MaximumWarehouseWorkOrderLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumWarehouseWorkOrderLineQuantityUnitSymbol = group.Add(new VocabularyKey(nameof(MaximumWarehouseWorkOrderLineQuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPackingQuantityUsedAsMaximumQuantity = group.Add(new VocabularyKey(nameof(IsPackingQuantityUsedAsMaximumQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateQuery = group.Add(new VocabularyKey(nameof(TemplateQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentDependentWorkBlockingPolicy = group.Add(new VocabularyKey(nameof(ReplenishmentDependentWorkBlockingPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicensePlateLabelBuildConfigurationId = group.Add(new VocabularyKey(nameof(LicensePlateLabelBuildConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicensePlateLabelBuildConfiguration = group.Add(new VocabularyKey(nameof(LicensePlateLabelBuildConfiguration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WorkOrderType { get; private set; }
        public VocabularyKey TemplateSequenceNumber { get; private set; }
        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey TemplateDescription { get; private set; }
        public VocabularyKey IsAutomaticProcessingAllowed { get; private set; }
        public VocabularyKey WarehouseWorkPoolId { get; private set; }
        public VocabularyKey ItemBatchAllocationStrategy { get; private set; }
        public VocabularyKey DefaultWarehouseWorkOrderPriority { get; private set; }
        public VocabularyKey WarehouseWorkHeaderMaximumEstimatedPickTime { get; private set; }
        public VocabularyKey MaximumWarehouseWorkOrderPickLines { get; private set; }
        public VocabularyKey MaximumWarehouseWorkOrderQuantity { get; private set; }
        public VocabularyKey MaximumWarehouseWorkOrderVolume { get; private set; }
        public VocabularyKey MaximumWarehouseWorkOrderWeight { get; private set; }
        public VocabularyKey MaximumWarehouseWorkOrderLineVolume { get; private set; }
        public VocabularyKey MaximumWarehouseWorkOrderLineWeight { get; private set; }
        public VocabularyKey MaximumWarehouseWorkOrderLineQuantity { get; private set; }
        public VocabularyKey MaximumWarehouseWorkOrderLineQuantityUnitSymbol { get; private set; }
        public VocabularyKey IsPackingQuantityUsedAsMaximumQuantity { get; private set; }
        public VocabularyKey TemplateQuery { get; private set; }
        public VocabularyKey ReplenishmentDependentWorkBlockingPolicy { get; private set; }
        public VocabularyKey LicensePlateLabelBuildConfigurationId { get; private set; }
        public VocabularyKey LicensePlateLabelBuildConfiguration { get; private set; }


    }
}