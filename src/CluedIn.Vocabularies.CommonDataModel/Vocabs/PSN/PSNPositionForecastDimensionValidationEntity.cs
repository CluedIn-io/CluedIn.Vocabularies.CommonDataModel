using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PSNPositionForecastDimensionValidationEntityVocabulary : SimpleVocabulary
    {
        public PSNPositionForecastDimensionValidationEntityVocabulary()
        {
            VocabularyName = "Common Data Model PSNPositionForecastDimensionValidationEntity";
            KeyPrefix = "commonDataModel.psnpositionforecastdimensionvalidationentity";
            KeySeparator = ".";
            Grouping = "/PSNPositionForecastDimensionValidationEntity";

            AddGroup("Common Data Model PSNPositionForecastDimensionValidationEntity Details", group =>
            {
                DimensionValidatedBy = group.Add(new VocabularyKey(nameof(DimensionValidatedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValidatedDateTime = group.Add(new VocabularyKey(nameof(DimensionValidatedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastPositionScenarioRecId = group.Add(new VocabularyKey(nameof(ForecastPositionScenarioRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastScenarioRecId = group.Add(new VocabularyKey(nameof(ForecastScenarioRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastPositionRecId = group.Add(new VocabularyKey(nameof(ForecastPositionRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningProcessRecId = group.Add(new VocabularyKey(nameof(BudgetPlanningProcessRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanScenarioRecId = group.Add(new VocabularyKey(nameof(BudgetPlanScenarioRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningProcessName = group.Add(new VocabularyKey(nameof(BudgetPlanningProcessName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanScenarioName = group.Add(new VocabularyKey(nameof(BudgetPlanScenarioName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionRecId = group.Add(new VocabularyKey(nameof(PositionRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DimensionValidatedBy { get; private set; }
        public VocabularyKey DimensionValidatedDateTime { get; private set; }
        public VocabularyKey ForecastPositionScenarioRecId { get; private set; }
        public VocabularyKey ForecastScenarioRecId { get; private set; }
        public VocabularyKey ForecastPositionRecId { get; private set; }
        public VocabularyKey BudgetPlanningProcessRecId { get; private set; }
        public VocabularyKey BudgetPlanScenarioRecId { get; private set; }
        public VocabularyKey BudgetPlanningProcessName { get; private set; }
        public VocabularyKey BudgetPlanScenarioName { get; private set; }
        public VocabularyKey PositionRecId { get; private set; }
        public VocabularyKey PositionId { get; private set; }


    }
}