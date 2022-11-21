using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdProductionControlParametersEntityVocabulary : SimpleVocabulary
    {
        public ProdProductionControlParametersEntityVocabulary()
        {
            VocabularyName = "Prod Production Control Parameters Entity";
            KeyPrefix = "commonDataModel.prodproductioncontrolparametersentity";
            KeySeparator = ".";
            Grouping = "/ProdProductionControlParametersEntity";

            AddGroup("ProdProductionControlParametersEntity Details", group =>
            {
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParameterUsageLevel = group.Add(new VocabularyKey(nameof(ParameterUsageLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillLastOperationEndingExecuteReportAsFinishedByDefault = group.Add(new VocabularyKey(nameof(WillLastOperationEndingExecuteReportAsFinishedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionPickingListPostingAllowNegativeInventory = group.Add(new VocabularyKey(nameof(WillProductionPickingListPostingAllowNegativeInventory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionPickingListPostingReduceToAvailableQuantity = group.Add(new VocabularyKey(nameof(WillProductionPickingListPostingReduceToAvailableQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPickingListJournalLineProposedQuantityOverrideConsumptionQuantityByDefault = group.Add(new VocabularyKey(nameof(WillPickingListJournalLineProposedQuantityOverrideConsumptionQuantityByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionCostRecalculationProductionOrderBundleSize = group.Add(new VocabularyKey(nameof(ProductionCostRecalculationProductionOrderBundleSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProductionOrderAutoReservationMode = group.Add(new VocabularyKey(nameof(DefaultProductionOrderAutoReservationMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillReportAsFinishedPostingAcceptQuantityErrorByDefault = group.Add(new VocabularyKey(nameof(WillReportAsFinishedPostingAcceptQuantityErrorByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLeanCostingFullBatchParallelizationEnabled = group.Add(new VocabularyKey(nameof(IsLeanCostingFullBatchParallelizationEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillLeanBatchProcessingSplitLedgerVoucherTransactions = group.Add(new VocabularyKey(nameof(WillLeanBatchProcessingSplitLedgerVoucherTransactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillNonStandardRouteVersionBatchOrderUsageAlertUser = group.Add(new VocabularyKey(nameof(WillNonStandardRouteVersionBatchOrderUsageAlertUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBurdenRouteCostCategoryId = group.Add(new VocabularyKey(nameof(DefaultBurdenRouteCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillReportAsFinishedPostingAutomaticallyPostPickingListByDefault = group.Add(new VocabularyKey(nameof(WillReportAsFinishedPostingAutomaticallyPostPickingListByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillEstimationPurchaseOrderCreationGroupByBuyerGroup = group.Add(new VocabularyKey(nameof(WillEstimationPurchaseOrderCreationGroupByBuyerGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillEstimationPurchaseOrderCreationGroupByPurchaseAgreement = group.Add(new VocabularyKey(nameof(WillEstimationPurchaseOrderCreationGroupByPurchaseAgreement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillEstimationPurchaseOrderCreationGroupByVendor = group.Add(new VocabularyKey(nameof(WillEstimationPurchaseOrderCreationGroupByVendor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillEstimationPurchaseOrderCreationFindPurchaseAgreements = group.Add(new VocabularyKey(nameof(WillEstimationPurchaseOrderCreationFindPurchaseAgreements), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProductionOrderLedgerPostingRule = group.Add(new VocabularyKey(nameof(DefaultProductionOrderLedgerPostingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProductionFlowQuantityUnit = group.Add(new VocabularyKey(nameof(DefaultProductionFlowQuantityUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProductionFlowQuantityUnitSymbol = group.Add(new VocabularyKey(nameof(DefaultProductionFlowQuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProductionFlowTimeUnit = group.Add(new VocabularyKey(nameof(DefaultProductionFlowTimeUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProductionFlowTimeUnitSymbol = group.Add(new VocabularyKey(nameof(DefaultProductionFlowTimeUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KanbanProductionInstructionDocumenAttachmentTypeCode = group.Add(new VocabularyKey(nameof(KanbanProductionInstructionDocumenAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProductionOrderWarehouseReleaseReservationRequirementRule = group.Add(new VocabularyKey(nameof(DefaultProductionOrderWarehouseReleaseReservationRequirementRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProductionOrderProfitSettingMethod = group.Add(new VocabularyKey(nameof(DefaultProductionOrderProfitSettingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillRouteCardPostingAutomaticallyPostPickingListByDefault = group.Add(new VocabularyKey(nameof(WillRouteCardPostingAutomaticallyPostPickingListByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillOnlyProductionEndingUpdateCostCalculation = group.Add(new VocabularyKey(nameof(WillOnlyProductionEndingUpdateCostCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeCalculationDaysUnitSymbol = group.Add(new VocabularyKey(nameof(TimeCalculationDaysUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeCalculationDaysUnit = group.Add(new VocabularyKey(nameof(TimeCalculationDaysUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeCalculationHoursUnitSymbol = group.Add(new VocabularyKey(nameof(TimeCalculationHoursUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeCalculationHoursUnit = group.Add(new VocabularyKey(nameof(TimeCalculationHoursUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeCalculationMinutesUnitSymbol = group.Add(new VocabularyKey(nameof(TimeCalculationMinutesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeCalculationMinutesUnit = group.Add(new VocabularyKey(nameof(TimeCalculationMinutesUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeCalculationSecondsUnitSymbol = group.Add(new VocabularyKey(nameof(TimeCalculationSecondsUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeCalculationSecondsUnit = group.Add(new VocabularyKey(nameof(TimeCalculationSecondsUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCreatedToEstimatedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsCreatedToEstimatedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCreatedToOperationsScheduledStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsCreatedToOperationsScheduledStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCreatedToJobScheduledStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsCreatedToJobScheduledStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCreatedToReleasedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsCreatedToReleasedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCreatedToStartedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsCreatedToStartedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCreatedToReportedAsFinishedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsCreatedToReportedAsFinishedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCreatedToEndedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsCreatedToEndedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEstimatedToCreatedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsEstimatedToCreatedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEstimatedToOperationsScheduledStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsEstimatedToOperationsScheduledStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEstimatedToJobScheduledStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsEstimatedToJobScheduledStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEstimatedToReleasedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsEstimatedToReleasedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEstimatedToStartedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsEstimatedToStartedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEstimatedToReportedAsFinishedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsEstimatedToReportedAsFinishedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEstimatedToEndedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsEstimatedToEndedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOperationsScheduledToCreatedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsOperationsScheduledToCreatedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOperationsScheduledToEstimatedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsOperationsScheduledToEstimatedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOperationsScheduledToJobScheduledStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsOperationsScheduledToJobScheduledStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOperationsScheduledToReleasedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsOperationsScheduledToReleasedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOperationsScheduledToStartedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsOperationsScheduledToStartedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOperationsScheduledToReportedAsFinishedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsOperationsScheduledToReportedAsFinishedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOperationsScheduledToEndedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsOperationsScheduledToEndedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsJobScheduledToCreatedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsJobScheduledToCreatedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsJobScheduledToEstimatedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsJobScheduledToEstimatedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsJobScheduledToOperationsScheduledStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsJobScheduledToOperationsScheduledStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsJobScheduledToReleasedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsJobScheduledToReleasedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsJobScheduledToStartedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsJobScheduledToStartedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsJobScheduledToReportedAsFinishedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsJobScheduledToReportedAsFinishedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsJobScheduledToEndedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsJobScheduledToEndedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReleasedToCreatedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsReleasedToCreatedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReleasedToEstimatedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsReleasedToEstimatedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReleasedToOperationsScheduledStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsReleasedToOperationsScheduledStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReleasedToJobScheduledStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsReleasedToJobScheduledStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReleasedToStartedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsReleasedToStartedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReleasedToReportedAsFinishedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsReleasedToReportedAsFinishedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReleasedToEndedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsReleasedToEndedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStartedToCreatedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsStartedToCreatedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStartedToEstimatedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsStartedToEstimatedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStartedToOperationsScheduledStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsStartedToOperationsScheduledStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStartedToJobScheduledStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsStartedToJobScheduledStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStartedToReleasedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsStartedToReleasedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStartedToReportedAsFinishedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsStartedToReportedAsFinishedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStartedToEndedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsStartedToEndedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReportedAsFinishedToCreatedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsReportedAsFinishedToCreatedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReportedAsFinishedToEstimatedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsReportedAsFinishedToEstimatedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReportedAsFinishedToOperationsScheduledStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsReportedAsFinishedToOperationsScheduledStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReportedAsFinishedToJobScheduledStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsReportedAsFinishedToJobScheduledStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReportedAsFinishedToReleasedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsReportedAsFinishedToReleasedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReportedAsFinishedToStartedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsReportedAsFinishedToStartedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReportedAsFinishedToEndedStatusChangedAllowed = group.Add(new VocabularyKey(nameof(IsReportedAsFinishedToEndedStatusChangedAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseProductReceiptAutomaticBOMConsumptionRule = group.Add(new VocabularyKey(nameof(PurchaseProductReceiptAutomaticBOMConsumptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportAsFinishedAutomaticBOMConsumptionRule = group.Add(new VocabularyKey(nameof(ReportAsFinishedAutomaticBOMConsumptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionStartAutomaticBOMConsumptionRule = group.Add(new VocabularyKey(nameof(ProductionStartAutomaticBOMConsumptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPickingListProductionJournalNameId = group.Add(new VocabularyKey(nameof(DefaultPickingListProductionJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSchedulingConsiderFiniteCapacityByDefault = group.Add(new VocabularyKey(nameof(WillSchedulingConsiderFiniteCapacityByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionEndingScrapMethod = group.Add(new VocabularyKey(nameof(ProductionEndingScrapMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillReportedAsFinishedDeleteCapacityReservations = group.Add(new VocabularyKey(nameof(WillReportedAsFinishedDeleteCapacityReservations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillReportAsFinishedIncreaseRemainingQuantityWithErrorQuantity = group.Add(new VocabularyKey(nameof(WillReportAsFinishedIncreaseRemainingQuantityWithErrorQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultJobCardProductionJournalNameId = group.Add(new VocabularyKey(nameof(DefaultJobCardProductionJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillRouteCardPostingUpdateCapacityPlan = group.Add(new VocabularyKey(nameof(WillRouteCardPostingUpdateCapacityPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillCapacityPlanningIncludePlannedOrders = group.Add(new VocabularyKey(nameof(WillCapacityPlanningIncludePlannedOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillCapacityPlanningIncludeProjectHourForecasts = group.Add(new VocabularyKey(nameof(WillCapacityPlanningIncludeProjectHourForecasts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRouteCardHourCostCategoryMandatory = group.Add(new VocabularyKey(nameof(IsRouteCardHourCostCategoryMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRouteCardQuantityCostCategoryMandatory = group.Add(new VocabularyKey(nameof(IsRouteCardQuantityCostCategoryMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSchedulingConsiderFiniteMaterialsByDefault = group.Add(new VocabularyKey(nameof(WillSchedulingConsiderFiniteMaterialsByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumJobSchedulingJobLeadTimeDays = group.Add(new VocabularyKey(nameof(MaximumJobSchedulingJobLeadTimeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillReportAsFinishedUseEstimatedUnitCost = group.Add(new VocabularyKey(nameof(WillReportAsFinishedUseEstimatedUnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionPostingExcludeTransactionType = group.Add(new VocabularyKey(nameof(WillProductionPostingExcludeTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionPickingListPostInLedger = group.Add(new VocabularyKey(nameof(WillProductionPickingListPostInLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillReportAsFinishedPostInLedger = group.Add(new VocabularyKey(nameof(WillReportAsFinishedPostInLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProductionJournalNameId = group.Add(new VocabularyKey(nameof(DefaultProductionJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionLineReleaseToWarehousePrinciple = group.Add(new VocabularyKey(nameof(ProductionLineReleaseToWarehousePrinciple), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSchedulingConsiderFinitePropertyByDefault = group.Add(new VocabularyKey(nameof(WillSchedulingConsiderFinitePropertyByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchaseProductReceiptDisplayRouteCardInformation = group.Add(new VocabularyKey(nameof(WillPurchaseProductReceiptDisplayRouteCardInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseProductReceiptAutomaticRouteConsumptionRule = group.Add(new VocabularyKey(nameof(PurchaseProductReceiptAutomaticRouteConsumptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportAsFinishedAutomaticRouteConsumptionRule = group.Add(new VocabularyKey(nameof(ReportAsFinishedAutomaticRouteConsumptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionStartAutomaticRouteConsumptionRule = group.Add(new VocabularyKey(nameof(ProductionStartAutomaticRouteConsumptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRouteCardProductionJournalNameId = group.Add(new VocabularyKey(nameof(DefaultRouteCardProductionJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutomaticSchedulingMethod = group.Add(new VocabularyKey(nameof(AutomaticSchedulingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionEstimationCalculateEstimatedUnitCost = group.Add(new VocabularyKey(nameof(WillProductionEstimationCalculateEstimatedUnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsApprovedRouteEditingAllowed = group.Add(new VocabularyKey(nameof(IsApprovedRouteEditingAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRouteApprovalRemovalAllowed = group.Add(new VocabularyKey(nameof(IsRouteApprovalRemovalAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreRouteVersionValidDatesMandatory = group.Add(new VocabularyKey(nameof(AreRouteVersionValidDatesMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreRouteNetworksEnabled = group.Add(new VocabularyKey(nameof(AreRouteNetworksEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey ParameterUsageLevel { get; private set; }
        public VocabularyKey WillLastOperationEndingExecuteReportAsFinishedByDefault { get; private set; }
        public VocabularyKey WillProductionPickingListPostingAllowNegativeInventory { get; private set; }
        public VocabularyKey WillProductionPickingListPostingReduceToAvailableQuantity { get; private set; }
        public VocabularyKey WillPickingListJournalLineProposedQuantityOverrideConsumptionQuantityByDefault { get; private set; }
        public VocabularyKey ProductionCostRecalculationProductionOrderBundleSize { get; private set; }
        public VocabularyKey DefaultProductionOrderAutoReservationMode { get; private set; }
        public VocabularyKey WillReportAsFinishedPostingAcceptQuantityErrorByDefault { get; private set; }
        public VocabularyKey IsLeanCostingFullBatchParallelizationEnabled { get; private set; }
        public VocabularyKey WillLeanBatchProcessingSplitLedgerVoucherTransactions { get; private set; }
        public VocabularyKey WillNonStandardRouteVersionBatchOrderUsageAlertUser { get; private set; }
        public VocabularyKey DefaultBurdenRouteCostCategoryId { get; private set; }
        public VocabularyKey WillReportAsFinishedPostingAutomaticallyPostPickingListByDefault { get; private set; }
        public VocabularyKey WillEstimationPurchaseOrderCreationGroupByBuyerGroup { get; private set; }
        public VocabularyKey WillEstimationPurchaseOrderCreationGroupByPurchaseAgreement { get; private set; }
        public VocabularyKey WillEstimationPurchaseOrderCreationGroupByVendor { get; private set; }
        public VocabularyKey WillEstimationPurchaseOrderCreationFindPurchaseAgreements { get; private set; }
        public VocabularyKey DefaultProductionOrderLedgerPostingRule { get; private set; }
        public VocabularyKey DefaultProductionFlowQuantityUnit { get; private set; }
        public VocabularyKey DefaultProductionFlowQuantityUnitSymbol { get; private set; }
        public VocabularyKey DefaultProductionFlowTimeUnit { get; private set; }
        public VocabularyKey DefaultProductionFlowTimeUnitSymbol { get; private set; }
        public VocabularyKey KanbanProductionInstructionDocumenAttachmentTypeCode { get; private set; }
        public VocabularyKey DefaultProductionOrderWarehouseReleaseReservationRequirementRule { get; private set; }
        public VocabularyKey DefaultProductionOrderProfitSettingMethod { get; private set; }
        public VocabularyKey WillRouteCardPostingAutomaticallyPostPickingListByDefault { get; private set; }
        public VocabularyKey WillOnlyProductionEndingUpdateCostCalculation { get; private set; }
        public VocabularyKey TimeCalculationDaysUnitSymbol { get; private set; }
        public VocabularyKey TimeCalculationDaysUnit { get; private set; }
        public VocabularyKey TimeCalculationHoursUnitSymbol { get; private set; }
        public VocabularyKey TimeCalculationHoursUnit { get; private set; }
        public VocabularyKey TimeCalculationMinutesUnitSymbol { get; private set; }
        public VocabularyKey TimeCalculationMinutesUnit { get; private set; }
        public VocabularyKey TimeCalculationSecondsUnitSymbol { get; private set; }
        public VocabularyKey TimeCalculationSecondsUnit { get; private set; }
        public VocabularyKey IsCreatedToEstimatedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsCreatedToOperationsScheduledStatusChangedAllowed { get; private set; }
        public VocabularyKey IsCreatedToJobScheduledStatusChangedAllowed { get; private set; }
        public VocabularyKey IsCreatedToReleasedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsCreatedToStartedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsCreatedToReportedAsFinishedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsCreatedToEndedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsEstimatedToCreatedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsEstimatedToOperationsScheduledStatusChangedAllowed { get; private set; }
        public VocabularyKey IsEstimatedToJobScheduledStatusChangedAllowed { get; private set; }
        public VocabularyKey IsEstimatedToReleasedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsEstimatedToStartedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsEstimatedToReportedAsFinishedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsEstimatedToEndedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsOperationsScheduledToCreatedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsOperationsScheduledToEstimatedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsOperationsScheduledToJobScheduledStatusChangedAllowed { get; private set; }
        public VocabularyKey IsOperationsScheduledToReleasedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsOperationsScheduledToStartedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsOperationsScheduledToReportedAsFinishedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsOperationsScheduledToEndedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsJobScheduledToCreatedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsJobScheduledToEstimatedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsJobScheduledToOperationsScheduledStatusChangedAllowed { get; private set; }
        public VocabularyKey IsJobScheduledToReleasedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsJobScheduledToStartedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsJobScheduledToReportedAsFinishedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsJobScheduledToEndedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsReleasedToCreatedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsReleasedToEstimatedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsReleasedToOperationsScheduledStatusChangedAllowed { get; private set; }
        public VocabularyKey IsReleasedToJobScheduledStatusChangedAllowed { get; private set; }
        public VocabularyKey IsReleasedToStartedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsReleasedToReportedAsFinishedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsReleasedToEndedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsStartedToCreatedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsStartedToEstimatedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsStartedToOperationsScheduledStatusChangedAllowed { get; private set; }
        public VocabularyKey IsStartedToJobScheduledStatusChangedAllowed { get; private set; }
        public VocabularyKey IsStartedToReleasedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsStartedToReportedAsFinishedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsStartedToEndedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsReportedAsFinishedToCreatedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsReportedAsFinishedToEstimatedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsReportedAsFinishedToOperationsScheduledStatusChangedAllowed { get; private set; }
        public VocabularyKey IsReportedAsFinishedToJobScheduledStatusChangedAllowed { get; private set; }
        public VocabularyKey IsReportedAsFinishedToReleasedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsReportedAsFinishedToStartedStatusChangedAllowed { get; private set; }
        public VocabularyKey IsReportedAsFinishedToEndedStatusChangedAllowed { get; private set; }
        public VocabularyKey PurchaseProductReceiptAutomaticBOMConsumptionRule { get; private set; }
        public VocabularyKey ReportAsFinishedAutomaticBOMConsumptionRule { get; private set; }
        public VocabularyKey ProductionStartAutomaticBOMConsumptionRule { get; private set; }
        public VocabularyKey DefaultPickingListProductionJournalNameId { get; private set; }
        public VocabularyKey WillSchedulingConsiderFiniteCapacityByDefault { get; private set; }
        public VocabularyKey ProductionEndingScrapMethod { get; private set; }
        public VocabularyKey WillReportedAsFinishedDeleteCapacityReservations { get; private set; }
        public VocabularyKey WillReportAsFinishedIncreaseRemainingQuantityWithErrorQuantity { get; private set; }
        public VocabularyKey DefaultJobCardProductionJournalNameId { get; private set; }
        public VocabularyKey WillRouteCardPostingUpdateCapacityPlan { get; private set; }
        public VocabularyKey WillCapacityPlanningIncludePlannedOrders { get; private set; }
        public VocabularyKey WillCapacityPlanningIncludeProjectHourForecasts { get; private set; }
        public VocabularyKey IsRouteCardHourCostCategoryMandatory { get; private set; }
        public VocabularyKey IsRouteCardQuantityCostCategoryMandatory { get; private set; }
        public VocabularyKey WillSchedulingConsiderFiniteMaterialsByDefault { get; private set; }
        public VocabularyKey MaximumJobSchedulingJobLeadTimeDays { get; private set; }
        public VocabularyKey WillReportAsFinishedUseEstimatedUnitCost { get; private set; }
        public VocabularyKey WillProductionPostingExcludeTransactionType { get; private set; }
        public VocabularyKey WillProductionPickingListPostInLedger { get; private set; }
        public VocabularyKey WillReportAsFinishedPostInLedger { get; private set; }
        public VocabularyKey DefaultProductionJournalNameId { get; private set; }
        public VocabularyKey ProductionLineReleaseToWarehousePrinciple { get; private set; }
        public VocabularyKey WillSchedulingConsiderFinitePropertyByDefault { get; private set; }
        public VocabularyKey WillPurchaseProductReceiptDisplayRouteCardInformation { get; private set; }
        public VocabularyKey PurchaseProductReceiptAutomaticRouteConsumptionRule { get; private set; }
        public VocabularyKey ReportAsFinishedAutomaticRouteConsumptionRule { get; private set; }
        public VocabularyKey ProductionStartAutomaticRouteConsumptionRule { get; private set; }
        public VocabularyKey DefaultRouteCardProductionJournalNameId { get; private set; }
        public VocabularyKey AutomaticSchedulingMethod { get; private set; }
        public VocabularyKey WillProductionEstimationCalculateEstimatedUnitCost { get; private set; }
        public VocabularyKey IsApprovedRouteEditingAllowed { get; private set; }
        public VocabularyKey IsRouteApprovalRemovalAllowed { get; private set; }
        public VocabularyKey AreRouteVersionValidDatesMandatory { get; private set; }
        public VocabularyKey AreRouteNetworksEnabled { get; private set; }
    }
}