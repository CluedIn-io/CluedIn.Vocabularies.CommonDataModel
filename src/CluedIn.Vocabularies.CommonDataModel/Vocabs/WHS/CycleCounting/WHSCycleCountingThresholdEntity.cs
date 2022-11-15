using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSCycleCountingThresholdEntityVocabulary : SimpleVocabulary
    {
        public WHSCycleCountingThresholdEntityVocabulary()
        {
            VocabularyName = "WHS Cycle Counting Threshold Entity";
            KeyPrefix = "commonDataModel.whscyclecountingthresholdentity";
            KeySeparator = ".";
            Grouping = "/WHSCycleCountingThresholdEntity";

            AddGroup("WHSCycleCountingThresholdEntity Details", group =>
            {
                ThresholdId = group.Add(new VocabularyKey(nameof(ThresholdId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThresholdType = group.Add(new VocabularyKey(nameof(ThresholdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DaysAllowedBetweenCycleCounts = group.Add(new VocabularyKey(nameof(DaysAllowedBetweenCycleCounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThresholdDescription = group.Add(new VocabularyKey(nameof(ThresholdDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillAssignCycleCountingWorkImmediately = group.Add(new VocabularyKey(nameof(WillAssignCycleCountingWorkImmediately), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductQuery = group.Add(new VocabularyKey(nameof(ProductQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationQuery = group.Add(new VocabularyKey(nameof(LocationQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThresholdInventoryCapacityPercentage = group.Add(new VocabularyKey(nameof(ThresholdInventoryCapacityPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThresholdInventoryQuantity = group.Add(new VocabularyKey(nameof(ThresholdInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThresholdInventoryQuantityUnitSymbol = group.Add(new VocabularyKey(nameof(ThresholdInventoryQuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkPoolId = group.Add(new VocabularyKey(nameof(WarehouseWorkPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ThresholdId { get; private set; }
        public VocabularyKey ThresholdType { get; private set; }
        public VocabularyKey DaysAllowedBetweenCycleCounts { get; private set; }
        public VocabularyKey ThresholdDescription { get; private set; }
        public VocabularyKey WillAssignCycleCountingWorkImmediately { get; private set; }
        public VocabularyKey ProductQuery { get; private set; }
        public VocabularyKey LocationQuery { get; private set; }
        public VocabularyKey ThresholdInventoryCapacityPercentage { get; private set; }
        public VocabularyKey ThresholdInventoryQuantity { get; private set; }
        public VocabularyKey ThresholdInventoryQuantityUnitSymbol { get; private set; }
        public VocabularyKey WarehouseWorkPoolId { get; private set; }
    }
}