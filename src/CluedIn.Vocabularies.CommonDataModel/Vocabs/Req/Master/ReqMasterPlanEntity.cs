using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqMasterPlanEntityVocabulary : SimpleVocabulary
    {
        public ReqMasterPlanEntityVocabulary()
        {
            VocabularyName = "Common Data Model ReqMasterPlanEntity";
            KeyPrefix = "commonDataModel.reqmasterplanentity";
            KeySeparator = ".";
            Grouping = "/ReqMasterPlanEntity";

            AddGroup("Common Data Model ReqMasterPlanEntity Details", group =>
            {
                ForecastModelId = group.Add(new VocabularyKey(nameof(ForecastModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastRequirementReductionMethod = group.Add(new VocabularyKey(nameof(ForecastRequirementReductionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContinuityPlanId = group.Add(new VocabularyKey(nameof(ContinuityPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MasterPlanDescription = group.Add(new VocabularyKey(nameof(MasterPlanDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MasterPlanId = group.Add(new VocabularyKey(nameof(MasterPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningIncludeDemandForecast = group.Add(new VocabularyKey(nameof(WillMasterPlanningIncludeDemandForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningIncludeSupplyForecast = group.Add(new VocabularyKey(nameof(WillMasterPlanningIncludeSupplyForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillActionMessageGenerationUsePlannedPurchaseOrderRequirementDateAsPostponedDate = group.Add(new VocabularyKey(nameof(WillActionMessageGenerationUsePlannedPurchaseOrderRequirementDateAsPostponedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillCapacitySchedulingConsiderBottleneckResourcesAsFinite = group.Add(new VocabularyKey(nameof(WillCapacitySchedulingConsiderBottleneckResourcesAsFinite), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillCapacitySchedulingConsiderAlreadyReservedCapacity = group.Add(new VocabularyKey(nameof(WillCapacitySchedulingConsiderAlreadyReservedCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillCapacitySchedulingUseResourceProperties = group.Add(new VocabularyKey(nameof(WillCapacitySchedulingUseResourceProperties), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlannedProductionOrderSchedulingMethod = group.Add(new VocabularyKey(nameof(PlannedProductionOrderSchedulingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BackwardSchedulingCapacityTimeFenceDays = group.Add(new VocabularyKey(nameof(BackwardSchedulingCapacityTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningAddCalculatedDelayToPlannedPurchaseOrderRequirementDate = group.Add(new VocabularyKey(nameof(WillMasterPlanningAddCalculatedDelayToPlannedPurchaseOrderRequirementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningAddCalculatedDelayToPlannedProductionOrderRequirementDate = group.Add(new VocabularyKey(nameof(WillMasterPlanningAddCalculatedDelayToPlannedProductionOrderRequirementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningAddCalculatedDelayToPlannedTransferOrderRequirementDate = group.Add(new VocabularyKey(nameof(WillMasterPlanningAddCalculatedDelayToPlannedTransferOrderRequirementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningIncludePurchaseRequisitions = group.Add(new VocabularyKey(nameof(WillMasterPlanningIncludePurchaseRequisitions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningIncludeContinuityPlan = group.Add(new VocabularyKey(nameof(WillMasterPlanningIncludeContinuityPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsContinuityPlanTimeFenceEnabled = group.Add(new VocabularyKey(nameof(IsContinuityPlanTimeFenceEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContinuityPlanTimeFenceDays = group.Add(new VocabularyKey(nameof(ContinuityPlanTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequirementDateDeductedSafetyIssueMarginDays = group.Add(new VocabularyKey(nameof(RequirementDateDeductedSafetyIssueMarginDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningIncludeDownstreamDemand = group.Add(new VocabularyKey(nameof(WillMasterPlanningIncludeDownstreamDemand), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsOnHandConsumptionStrategyEnabled = group.Add(new VocabularyKey(nameof(IsOnHandConsumptionStrategyEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OnHandConsumptionStrategy = group.Add(new VocabularyKey(nameof(OnHandConsumptionStrategy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningConsiderShelfLifeDates = group.Add(new VocabularyKey(nameof(WillMasterPlanningConsiderShelfLifeDates), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlannedOrderNumberSequenceRecId = group.Add(new VocabularyKey(nameof(PlannedOrderNumberSequenceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlannedOrderNumberSequenceCode = group.Add(new VocabularyKey(nameof(PlannedOrderNumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MasterPlanCalculationSessionNumberSequenceRecId = group.Add(new VocabularyKey(nameof(MasterPlanCalculationSessionNumberSequenceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MasterPlanCalculationSessionNumberSequenceCode = group.Add(new VocabularyKey(nameof(MasterPlanCalculationSessionNumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemLeadTimeAddedReorderMarginDays = group.Add(new VocabularyKey(nameof(ItemLeadTimeAddedReorderMarginDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlannedProductionOrderSequencingTimeFenceDays = group.Add(new VocabularyKey(nameof(PlannedProductionOrderSequencingTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningSequencePlannedOrders = group.Add(new VocabularyKey(nameof(WillMasterPlanningSequencePlannedOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlannedProductionOrderSequencingBucketType = group.Add(new VocabularyKey(nameof(PlannedProductionOrderSequencingBucketType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlannedProductionOrderSequencingPeriodType = group.Add(new VocabularyKey(nameof(PlannedProductionOrderSequencingPeriodType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlannedProductionOrderSequencingCampaignCycleBucketCount = group.Add(new VocabularyKey(nameof(PlannedProductionOrderSequencingCampaignCycleBucketCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuotationProbabilityPercentageThreshold = group.Add(new VocabularyKey(nameof(QuotationProbabilityPercentageThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningSuggestFuturePlannedOrderDatesOnly = group.Add(new VocabularyKey(nameof(WillMasterPlanningSuggestFuturePlannedOrderDatesOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningAddCalculatedDelayToPlannedKanbanRequirementDate = group.Add(new VocabularyKey(nameof(WillMasterPlanningAddCalculatedDelayToPlannedKanbanRequirementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequirementDateAddedSafetyReceiptMarginDays = group.Add(new VocabularyKey(nameof(RequirementDateAddedSafetyReceiptMarginDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAutomaticFirmingTimeFenceOverridden = group.Add(new VocabularyKey(nameof(IsAutomaticFirmingTimeFenceOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AutomaticFirmingTimeFenceDays = group.Add(new VocabularyKey(nameof(AutomaticFirmingTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActionTimeFenceOverridden = group.Add(new VocabularyKey(nameof(IsActionTimeFenceOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActionTimeFenceDays = group.Add(new VocabularyKey(nameof(ActionTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ApprovedRequisitionTimeFenceDays = group.Add(new VocabularyKey(nameof(ApprovedRequisitionTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BottleneckResourceFiniteCapacitySchedulingTimeFenceDays = group.Add(new VocabularyKey(nameof(BottleneckResourceFiniteCapacitySchedulingTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CoverageTimeFenceDays = group.Add(new VocabularyKey(nameof(CoverageTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCapacityTimeFenceOverridden = group.Add(new VocabularyKey(nameof(IsCapacityTimeFenceOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CapacitySchedulingTimeFenceDays = group.Add(new VocabularyKey(nameof(CapacitySchedulingTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsApprovedRequisitionsTimeFenceOverridden = group.Add(new VocabularyKey(nameof(IsApprovedRequisitionsTimeFenceOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiniteCapacitySchdedulingTimeFenceDays = group.Add(new VocabularyKey(nameof(FiniteCapacitySchdedulingTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCoverageTimeFenceOverridden = group.Add(new VocabularyKey(nameof(IsCoverageTimeFenceOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsBOMOrFormulaExplosionTimeFenceOverridden = group.Add(new VocabularyKey(nameof(IsBOMOrFormulaExplosionTimeFenceOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BOMOrFormulaExplosionTimeFenceDays = group.Add(new VocabularyKey(nameof(BOMOrFormulaExplosionTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CalculateDelayTimeFenceDays = group.Add(new VocabularyKey(nameof(CalculateDelayTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsFreezeTimeFenceOverridden = group.Add(new VocabularyKey(nameof(IsFreezeTimeFenceOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FreezeTimeFenceDays = group.Add(new VocabularyKey(nameof(FreezeTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsForecastDemandPlanTimeFenceOverridden = group.Add(new VocabularyKey(nameof(IsForecastDemandPlanTimeFenceOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastDemandPlanTimeFenceDays = group.Add(new VocabularyKey(nameof(ForecastDemandPlanTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCalculatedDaysTimeFenceOverridden = group.Add(new VocabularyKey(nameof(IsCalculatedDaysTimeFenceOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningIncludeOnHand = group.Add(new VocabularyKey(nameof(WillMasterPlanningIncludeOnHand), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningIncludeExpectedInventoryTransactions = group.Add(new VocabularyKey(nameof(WillMasterPlanningIncludeExpectedInventoryTransactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningIncludeQuotations = group.Add(new VocabularyKey(nameof(WillMasterPlanningIncludeQuotations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlanningIncludeRFQs = group.Add(new VocabularyKey(nameof(WillMasterPlanningIncludeRFQs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ForecastModelId { get; private set; }
public VocabularyKey ForecastRequirementReductionMethod { get; private set; }
public VocabularyKey ContinuityPlanId { get; private set; }
public VocabularyKey MasterPlanDescription { get; private set; }
public VocabularyKey MasterPlanId { get; private set; }
public VocabularyKey WillMasterPlanningIncludeDemandForecast { get; private set; }
public VocabularyKey WillMasterPlanningIncludeSupplyForecast { get; private set; }
public VocabularyKey WillActionMessageGenerationUsePlannedPurchaseOrderRequirementDateAsPostponedDate { get; private set; }
public VocabularyKey WillCapacitySchedulingConsiderBottleneckResourcesAsFinite { get; private set; }
public VocabularyKey WillCapacitySchedulingConsiderAlreadyReservedCapacity { get; private set; }
public VocabularyKey WillCapacitySchedulingUseResourceProperties { get; private set; }
public VocabularyKey PlannedProductionOrderSchedulingMethod { get; private set; }
public VocabularyKey BackwardSchedulingCapacityTimeFenceDays { get; private set; }
public VocabularyKey WillMasterPlanningAddCalculatedDelayToPlannedPurchaseOrderRequirementDate { get; private set; }
public VocabularyKey WillMasterPlanningAddCalculatedDelayToPlannedProductionOrderRequirementDate { get; private set; }
public VocabularyKey WillMasterPlanningAddCalculatedDelayToPlannedTransferOrderRequirementDate { get; private set; }
public VocabularyKey WillMasterPlanningIncludePurchaseRequisitions { get; private set; }
public VocabularyKey WillMasterPlanningIncludeContinuityPlan { get; private set; }
public VocabularyKey IsContinuityPlanTimeFenceEnabled { get; private set; }
public VocabularyKey ContinuityPlanTimeFenceDays { get; private set; }
public VocabularyKey RequirementDateDeductedSafetyIssueMarginDays { get; private set; }
public VocabularyKey WillMasterPlanningIncludeDownstreamDemand { get; private set; }
public VocabularyKey IsOnHandConsumptionStrategyEnabled { get; private set; }
public VocabularyKey OnHandConsumptionStrategy { get; private set; }
public VocabularyKey WillMasterPlanningConsiderShelfLifeDates { get; private set; }
public VocabularyKey PlannedOrderNumberSequenceRecId { get; private set; }
public VocabularyKey PlannedOrderNumberSequenceCode { get; private set; }
public VocabularyKey MasterPlanCalculationSessionNumberSequenceRecId { get; private set; }
public VocabularyKey MasterPlanCalculationSessionNumberSequenceCode { get; private set; }
public VocabularyKey ItemLeadTimeAddedReorderMarginDays { get; private set; }
public VocabularyKey PlannedProductionOrderSequencingTimeFenceDays { get; private set; }
public VocabularyKey WillMasterPlanningSequencePlannedOrders { get; private set; }
public VocabularyKey PlannedProductionOrderSequencingBucketType { get; private set; }
public VocabularyKey PlannedProductionOrderSequencingPeriodType { get; private set; }
public VocabularyKey PlannedProductionOrderSequencingCampaignCycleBucketCount { get; private set; }
public VocabularyKey QuotationProbabilityPercentageThreshold { get; private set; }
public VocabularyKey WillMasterPlanningSuggestFuturePlannedOrderDatesOnly { get; private set; }
public VocabularyKey WillMasterPlanningAddCalculatedDelayToPlannedKanbanRequirementDate { get; private set; }
public VocabularyKey RequirementDateAddedSafetyReceiptMarginDays { get; private set; }
public VocabularyKey IsAutomaticFirmingTimeFenceOverridden { get; private set; }
public VocabularyKey AutomaticFirmingTimeFenceDays { get; private set; }
public VocabularyKey IsActionTimeFenceOverridden { get; private set; }
public VocabularyKey ActionTimeFenceDays { get; private set; }
public VocabularyKey ApprovedRequisitionTimeFenceDays { get; private set; }
public VocabularyKey BottleneckResourceFiniteCapacitySchedulingTimeFenceDays { get; private set; }
public VocabularyKey CoverageTimeFenceDays { get; private set; }
public VocabularyKey IsCapacityTimeFenceOverridden { get; private set; }
public VocabularyKey CapacitySchedulingTimeFenceDays { get; private set; }
public VocabularyKey IsApprovedRequisitionsTimeFenceOverridden { get; private set; }
public VocabularyKey FiniteCapacitySchdedulingTimeFenceDays { get; private set; }
public VocabularyKey IsCoverageTimeFenceOverridden { get; private set; }
public VocabularyKey IsBOMOrFormulaExplosionTimeFenceOverridden { get; private set; }
public VocabularyKey BOMOrFormulaExplosionTimeFenceDays { get; private set; }
public VocabularyKey CalculateDelayTimeFenceDays { get; private set; }
public VocabularyKey IsFreezeTimeFenceOverridden { get; private set; }
public VocabularyKey FreezeTimeFenceDays { get; private set; }
public VocabularyKey IsForecastDemandPlanTimeFenceOverridden { get; private set; }
public VocabularyKey ForecastDemandPlanTimeFenceDays { get; private set; }
public VocabularyKey IsCalculatedDaysTimeFenceOverridden { get; private set; }
public VocabularyKey WillMasterPlanningIncludeOnHand { get; private set; }
public VocabularyKey WillMasterPlanningIncludeExpectedInventoryTransactions { get; private set; }
public VocabularyKey WillMasterPlanningIncludeQuotations { get; private set; }
public VocabularyKey WillMasterPlanningIncludeRFQs { get; private set; }


    }
}