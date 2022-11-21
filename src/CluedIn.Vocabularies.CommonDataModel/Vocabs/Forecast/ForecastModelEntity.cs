using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ForecastModelEntityVocabulary : SimpleVocabulary
    {
        public ForecastModelEntityVocabulary()
        {
            VocabularyName = "Forecast Model Entity";
            KeyPrefix = "commonDataModel.forecastmodelentity";
            KeySeparator = ".";
            Grouping = "/ForecastModelEntity";

            AddGroup("ForecastModelEntity Details", group =>
            {
                ModelId = group.Add(new VocabularyKey(nameof(ModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModelName = group.Add(new VocabularyKey(nameof(ModelName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsModelStopped = group.Add(new VocabularyKey(nameof(IsModelStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCashFlowForecastGenerated = group.Add(new VocabularyKey(nameof(IsCashFlowForecastGenerated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetControlType = group.Add(new VocabularyKey(nameof(BudgetControlType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSufficientProjectExpenseFundsRequired = group.Add(new VocabularyKey(nameof(AreSufficientProjectExpenseFundsRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSufficientProjectHourFundsRequired = group.Add(new VocabularyKey(nameof(AreSufficientProjectHourFundsRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSufficientProjectItemFundsRequired = group.Add(new VocabularyKey(nameof(AreSufficientProjectItemFundsRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProjectExpenseForecastAutomaticallyReduced = group.Add(new VocabularyKey(nameof(IsProjectExpenseForecastAutomaticallyReduced), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFixedPriceProjectWIPIncluded = group.Add(new VocabularyKey(nameof(IsFixedPriceProjectWIPIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInvestmentProjectWIPIncluded = group.Add(new VocabularyKey(nameof(IsInvestmentProjectWIPIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTimeAndMaterialProjectIncluded = group.Add(new VocabularyKey(nameof(IsTimeAndMaterialProjectIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProjectHourForecastAutomaticallyReduced = group.Add(new VocabularyKey(nameof(IsProjectHourForecastAutomaticallyReduced), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProjectItemForecastAutomaticallyReduced = group.Add(new VocabularyKey(nameof(IsProjectItemForecastAutomaticallyReduced), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProjectForecastGenerationUseProjectDate = group.Add(new VocabularyKey(nameof(WillProjectForecastGenerationUseProjectDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ModelId { get; private set; }
        public VocabularyKey ModelName { get; private set; }
        public VocabularyKey IsModelStopped { get; private set; }
        public VocabularyKey IsCashFlowForecastGenerated { get; private set; }
        public VocabularyKey BudgetControlType { get; private set; }
        public VocabularyKey AreSufficientProjectExpenseFundsRequired { get; private set; }
        public VocabularyKey AreSufficientProjectHourFundsRequired { get; private set; }
        public VocabularyKey AreSufficientProjectItemFundsRequired { get; private set; }
        public VocabularyKey IsProjectExpenseForecastAutomaticallyReduced { get; private set; }
        public VocabularyKey IsFixedPriceProjectWIPIncluded { get; private set; }
        public VocabularyKey IsInvestmentProjectWIPIncluded { get; private set; }
        public VocabularyKey IsTimeAndMaterialProjectIncluded { get; private set; }
        public VocabularyKey IsProjectHourForecastAutomaticallyReduced { get; private set; }
        public VocabularyKey IsProjectItemForecastAutomaticallyReduced { get; private set; }
        public VocabularyKey WillProjectForecastGenerationUseProjectDate { get; private set; }
    }
}