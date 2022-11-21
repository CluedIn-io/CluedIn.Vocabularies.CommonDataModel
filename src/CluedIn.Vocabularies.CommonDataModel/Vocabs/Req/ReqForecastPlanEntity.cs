using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqForecastPlanEntityVocabulary : SimpleVocabulary
    {
        public ReqForecastPlanEntityVocabulary()
        {
            VocabularyName = "Req Forecast Plan Entity";
            KeyPrefix = "commonDataModel.reqforecastplanentity";
            KeySeparator = ".";
            Grouping = "/ReqForecastPlanEntity";

            AddGroup("ReqForecastPlanEntity Details", group =>
            {
                ForecastPlanId = group.Add(new VocabularyKey(nameof(ForecastPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastPlanDescription = group.Add(new VocabularyKey(nameof(ForecastPlanDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastModelId = group.Add(new VocabularyKey(nameof(ForecastModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillForecastPlanningIncludeSupplyForecast = group.Add(new VocabularyKey(nameof(WillForecastPlanningIncludeSupplyForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillForecastPlanningIncludeDemandForecast = group.Add(new VocabularyKey(nameof(WillForecastPlanningIncludeDemandForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillForecastPlanningSkipCoverageCalculations = group.Add(new VocabularyKey(nameof(WillForecastPlanningSkipCoverageCalculations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastRequirementReductionMethod = group.Add(new VocabularyKey(nameof(ForecastRequirementReductionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderNumberSequenceRecId = group.Add(new VocabularyKey(nameof(PlannedOrderNumberSequenceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderNumberSequenceCode = group.Add(new VocabularyKey(nameof(PlannedOrderNumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastPlanCalculationSessionNumberSequenceRecId = group.Add(new VocabularyKey(nameof(ForecastPlanCalculationSessionNumberSequenceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastPlanCalculationSessionNumberSequenceCode = group.Add(new VocabularyKey(nameof(ForecastPlanCalculationSessionNumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementDateDeductedSafetyIssueMarginDays = group.Add(new VocabularyKey(nameof(RequirementDateDeductedSafetyIssueMarginDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementDateAddedSafetyReceiptMarginDays = group.Add(new VocabularyKey(nameof(RequirementDateAddedSafetyReceiptMarginDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemLeadTimeAddedReorderMarginDays = group.Add(new VocabularyKey(nameof(ItemLeadTimeAddedReorderMarginDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapacitySchedulingTimeFenceDays = group.Add(new VocabularyKey(nameof(CapacitySchedulingTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageTimeFenceDays = group.Add(new VocabularyKey(nameof(CoverageTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMOrFormulaExplosionTimeFenceDays = group.Add(new VocabularyKey(nameof(BOMOrFormulaExplosionTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ForecastPlanId { get; private set; }
        public VocabularyKey ForecastPlanDescription { get; private set; }
        public VocabularyKey ForecastModelId { get; private set; }
        public VocabularyKey WillForecastPlanningIncludeSupplyForecast { get; private set; }
        public VocabularyKey WillForecastPlanningIncludeDemandForecast { get; private set; }
        public VocabularyKey WillForecastPlanningSkipCoverageCalculations { get; private set; }
        public VocabularyKey ForecastRequirementReductionMethod { get; private set; }
        public VocabularyKey PlannedOrderNumberSequenceRecId { get; private set; }
        public VocabularyKey PlannedOrderNumberSequenceCode { get; private set; }
        public VocabularyKey ForecastPlanCalculationSessionNumberSequenceRecId { get; private set; }
        public VocabularyKey ForecastPlanCalculationSessionNumberSequenceCode { get; private set; }
        public VocabularyKey RequirementDateDeductedSafetyIssueMarginDays { get; private set; }
        public VocabularyKey RequirementDateAddedSafetyReceiptMarginDays { get; private set; }
        public VocabularyKey ItemLeadTimeAddedReorderMarginDays { get; private set; }
        public VocabularyKey CapacitySchedulingTimeFenceDays { get; private set; }
        public VocabularyKey CoverageTimeFenceDays { get; private set; }
        public VocabularyKey BOMOrFormulaExplosionTimeFenceDays { get; private set; }
    }
}