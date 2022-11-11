using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqMasterPlanningProductCoverageGroupEntityVocabulary : SimpleVocabulary
    {
        public ReqMasterPlanningProductCoverageGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model ReqMasterPlanningProductCoverageGroupEntity";
            KeyPrefix = "commonDataModel.reqmasterplanningproductcoveragegroupentity";
            KeySeparator = ".";
            Grouping = "/ReqMasterPlanningProductCoverageGroupEntity";

            AddGroup("Common Data Model ReqMasterPlanningProductCoverageGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkCalendarId = group.Add(new VocabularyKey(nameof(WorkCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageMethod = group.Add(new VocabularyKey(nameof(CoverageMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoveragePeriodDays = group.Add(new VocabularyKey(nameof(CoveragePeriodDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageTimeFenceDays = group.Add(new VocabularyKey(nameof(CoverageTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NegativeDays = group.Add(new VocabularyKey(nameof(NegativeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositiveDays = group.Add(new VocabularyKey(nameof(PositiveDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnHandInventoryConsumptionStrategy = group.Add(new VocabularyKey(nameof(OnHandInventoryConsumptionStrategy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseSpecifiedBOMOrFormulaVersion = group.Add(new VocabularyKey(nameof(UseSpecifiedBOMOrFormulaVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseSpecifiedRouteVersion = group.Add(new VocabularyKey(nameof(UseSpecifiedRouteVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodTemplateId = group.Add(new VocabularyKey(nameof(PeriodTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedProductionStatus = group.Add(new VocabularyKey(nameof(RequestedProductionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutomaticFirmingTimeFenceDays = group.Add(new VocabularyKey(nameof(AutomaticFirmingTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreezeTimeFenceDays = group.Add(new VocabularyKey(nameof(FreezeTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMOrFormulaExplosionTimeFenceDays = group.Add(new VocabularyKey(nameof(BOMOrFormulaExplosionTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapacitySchedulingTimeFenceDays = group.Add(new VocabularyKey(nameof(CapacitySchedulingTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApprovedRequisitionTimeFenceDays = group.Add(new VocabularyKey(nameof(ApprovedRequisitionTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastDemandPlanTimeFenceDays = group.Add(new VocabularyKey(nameof(ForecastDemandPlanTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastReductionKeyId = group.Add(new VocabularyKey(nameof(ForecastReductionKeyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastReductionMethod = group.Add(new VocabularyKey(nameof(ForecastReductionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillDemandForecastIncludeIntercompanyOrders = group.Add(new VocabularyKey(nameof(WillDemandForecastIncludeIntercompanyOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillDemandForecastIncludeCustomerForecast = group.Add(new VocabularyKey(nameof(WillDemandForecastIncludeCustomerForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptSafetyMarginDays = group.Add(new VocabularyKey(nameof(ReceiptSafetyMarginDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IssueSafetyMarginDays = group.Add(new VocabularyKey(nameof(IssueSafetyMarginDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReorderSafetyMarginDay = group.Add(new VocabularyKey(nameof(ReorderSafetyMarginDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActionMessageEnabled = group.Add(new VocabularyKey(nameof(IsActionMessageEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionTimeFenceDays = group.Add(new VocabularyKey(nameof(ActionTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumPostponeMarginDays = group.Add(new VocabularyKey(nameof(MaximumPostponeMarginDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAdvanceMarginDays = group.Add(new VocabularyKey(nameof(MaximumAdvanceMarginDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionBasisDateType = group.Add(new VocabularyKey(nameof(ActionBasisDateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAdvanceActionEnabled = group.Add(new VocabularyKey(nameof(IsAdvanceActionEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPostponeActionEnabled = group.Add(new VocabularyKey(nameof(IsPostponeActionEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActionDecreaseEnabled = group.Add(new VocabularyKey(nameof(IsActionDecreaseEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActionIncreaseEnabled = group.Add(new VocabularyKey(nameof(IsActionIncreaseEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreDerivedActionsEnabled = group.Add(new VocabularyKey(nameof(AreDerivedActionsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDelayCalculationEnabled = group.Add(new VocabularyKey(nameof(IsDelayCalculationEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculateDelayTimeFenceDays = group.Add(new VocabularyKey(nameof(CalculateDelayTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodTemplate = group.Add(new VocabularyKey(nameof(PeriodTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey WorkCalendarId { get; private set; }
        public VocabularyKey CoverageMethod { get; private set; }
        public VocabularyKey CoveragePeriodDays { get; private set; }
        public VocabularyKey CoverageTimeFenceDays { get; private set; }
        public VocabularyKey NegativeDays { get; private set; }
        public VocabularyKey PositiveDays { get; private set; }
        public VocabularyKey OnHandInventoryConsumptionStrategy { get; private set; }
        public VocabularyKey UseSpecifiedBOMOrFormulaVersion { get; private set; }
        public VocabularyKey UseSpecifiedRouteVersion { get; private set; }
        public VocabularyKey PeriodTemplateId { get; private set; }
        public VocabularyKey RequestedProductionStatus { get; private set; }
        public VocabularyKey AutomaticFirmingTimeFenceDays { get; private set; }
        public VocabularyKey FreezeTimeFenceDays { get; private set; }
        public VocabularyKey BOMOrFormulaExplosionTimeFenceDays { get; private set; }
        public VocabularyKey CapacitySchedulingTimeFenceDays { get; private set; }
        public VocabularyKey ApprovedRequisitionTimeFenceDays { get; private set; }
        public VocabularyKey ForecastDemandPlanTimeFenceDays { get; private set; }
        public VocabularyKey ForecastReductionKeyId { get; private set; }
        public VocabularyKey ForecastReductionMethod { get; private set; }
        public VocabularyKey WillDemandForecastIncludeIntercompanyOrders { get; private set; }
        public VocabularyKey WillDemandForecastIncludeCustomerForecast { get; private set; }
        public VocabularyKey ReceiptSafetyMarginDays { get; private set; }
        public VocabularyKey IssueSafetyMarginDays { get; private set; }
        public VocabularyKey ReorderSafetyMarginDay { get; private set; }
        public VocabularyKey IsActionMessageEnabled { get; private set; }
        public VocabularyKey ActionTimeFenceDays { get; private set; }
        public VocabularyKey MaximumPostponeMarginDays { get; private set; }
        public VocabularyKey MaximumAdvanceMarginDays { get; private set; }
        public VocabularyKey ActionBasisDateType { get; private set; }
        public VocabularyKey IsAdvanceActionEnabled { get; private set; }
        public VocabularyKey IsPostponeActionEnabled { get; private set; }
        public VocabularyKey IsActionDecreaseEnabled { get; private set; }
        public VocabularyKey IsActionIncreaseEnabled { get; private set; }
        public VocabularyKey AreDerivedActionsEnabled { get; private set; }
        public VocabularyKey IsDelayCalculationEnabled { get; private set; }
        public VocabularyKey CalculateDelayTimeFenceDays { get; private set; }
        public VocabularyKey PeriodTemplate { get; private set; }


    }
}