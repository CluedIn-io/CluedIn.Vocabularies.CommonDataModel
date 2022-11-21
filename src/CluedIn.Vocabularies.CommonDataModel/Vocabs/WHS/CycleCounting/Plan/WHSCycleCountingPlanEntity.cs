using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSCycleCountingPlanEntityVocabulary : SimpleVocabulary
    {
        public WHSCycleCountingPlanEntityVocabulary()
        {
            VocabularyName = "WHS Cycle Counting Plan Entity";
            KeyPrefix = "commonDataModel.whscyclecountingplanentity";
            KeySeparator = ".";
            Grouping = "/WHSCycleCountingPlanEntity";

            AddGroup("WHSCycleCountingPlanEntity Details", group =>
            {
                EmptyLocationCycleCountingRule = group.Add(new VocabularyKey(nameof(EmptyLocationCycleCountingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlanId = group.Add(new VocabularyKey(nameof(PlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CycleCountingFrequencyInDays = group.Add(new VocabularyKey(nameof(CycleCountingFrequencyInDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlanDescription = group.Add(new VocabularyKey(nameof(PlanDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationQuery = group.Add(new VocabularyKey(nameof(LocationQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumWarehouseLocationCount = group.Add(new VocabularyKey(nameof(MaximumWarehouseLocationCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkPoolId = group.Add(new VocabularyKey(nameof(WarehouseWorkPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkTemplateId = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkTemplateWorkOrderType = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateWorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EmptyLocationCycleCountingRule { get; private set; }
        public VocabularyKey PlanId { get; private set; }
        public VocabularyKey CycleCountingFrequencyInDays { get; private set; }
        public VocabularyKey PlanDescription { get; private set; }
        public VocabularyKey LocationQuery { get; private set; }
        public VocabularyKey MaximumWarehouseLocationCount { get; private set; }
        public VocabularyKey WarehouseWorkPoolId { get; private set; }
        public VocabularyKey WarehouseWorkTemplateId { get; private set; }
        public VocabularyKey WarehouseWorkTemplateWorkOrderType { get; private set; }
    }
}