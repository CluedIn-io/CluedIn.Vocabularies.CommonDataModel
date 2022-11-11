using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgSiteSpecificManufacturingExecutionProductionOrderDefaultsEntityVocabulary : SimpleVocabulary
    {
        public JmgSiteSpecificManufacturingExecutionProductionOrderDefaultsEntityVocabulary()
        {
            VocabularyName = "JmgSiteSpecificManufacturingExecutionProductionOrderDefaultsEntity";
            KeyPrefix = "commonDataModel.jmgsitespecificmanufacturingexecutionproductionorderdefaultsentity";
            KeySeparator = ".";
            Grouping = "/JmgSiteSpecificManufacturingExecutionProductionOrderDefaultsEntity";

            AddGroup("JmgSiteSpecificManufacturingExecutionProductionOrderDefaultsEntity Details", group =>
            {
                InventDimId = group.Add(new VocabularyKey(nameof(InventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionSiteId = group.Add(new VocabularyKey(nameof(ProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProductionStartRouteCardProductionJournalNameId = group.Add(new VocabularyKey(nameof(DefaultProductionStartRouteCardProductionJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOverlapJobRegistrationAllowed = group.Add(new VocabularyKey(nameof(IsOverlapJobRegistrationAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProcessJobRegistrationAllowed = group.Add(new VocabularyKey(nameof(IsProcessJobRegistrationAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQueueAfterJobRegistrationAllowed = group.Add(new VocabularyKey(nameof(IsQueueAfterJobRegistrationAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQueueBeforeJobRegistrationAllowed = group.Add(new VocabularyKey(nameof(IsQueueBeforeJobRegistrationAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSetupJobRegistrationAllowed = group.Add(new VocabularyKey(nameof(IsSetupJobRegistrationAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTransportJobRegistrationAllowed = group.Add(new VocabularyKey(nameof(IsTransportJobRegistrationAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreAssistantsAssignedSecondaryOperations = group.Add(new VocabularyKey(nameof(AreAssistantsAssignedSecondaryOperations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillOperationFeedbackOpenPickingListJournal = group.Add(new VocabularyKey(nameof(WillOperationFeedbackOpenPickingListJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOperationFeedbackPickingListProductionJournalNameId = group.Add(new VocabularyKey(nameof(DefaultOperationFeedbackPickingListProductionJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillOperationFeedbackAutomaticallyPostPickingList = group.Add(new VocabularyKey(nameof(WillOperationFeedbackAutomaticallyPostPickingList), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillCostCalculationUseRouteCostCategory = group.Add(new VocabularyKey(nameof(WillCostCalculationUseRouteCostCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillOperationFeedbackAcceptSurplusDeviation = group.Add(new VocabularyKey(nameof(WillOperationFeedbackAcceptSurplusDeviation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillOperationFeedbackAcceptShortageDeviation = group.Add(new VocabularyKey(nameof(WillOperationFeedbackAcceptShortageDeviation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAcceptedOperationFeedbackSurplusDeviationPercentage = group.Add(new VocabularyKey(nameof(MaximumAcceptedOperationFeedbackSurplusDeviationPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAcceptedOperationFeedbackShortageDeviationPercentage = group.Add(new VocabularyKey(nameof(MaximumAcceptedOperationFeedbackShortageDeviationPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationFeedbackQuantityValidationMethod = group.Add(new VocabularyKey(nameof(OperationFeedbackQuantityValidationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumReportAsFinishedQuantity = group.Add(new VocabularyKey(nameof(MaximumReportAsFinishedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillRegistrationTransferAutomatiallyPostTimeJobCardJournal = group.Add(new VocabularyKey(nameof(WillRegistrationTransferAutomatiallyPostTimeJobCardJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionRegistrationLedgerDimensionSelectionRule = group.Add(new VocabularyKey(nameof(ProductionRegistrationLedgerDimensionSelectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillReportAsFinishedPostingAcceptQuantityError = group.Add(new VocabularyKey(nameof(WillReportAsFinishedPostingAcceptQuantityError), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportAsFinishedAutomaticBOMConsumptionRule = group.Add(new VocabularyKey(nameof(ReportAsFinishedAutomaticBOMConsumptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReportAsFinishedPickingListProductionJournalNameId = group.Add(new VocabularyKey(nameof(DefaultReportAsFinishedPickingListProductionJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReportAsFinishedJobFinalByDefault = group.Add(new VocabularyKey(nameof(IsReportAsFinishedJobFinalByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillReportAsFinishedCreatePickingListJournalWithEndMarkedOperations = group.Add(new VocabularyKey(nameof(WillReportAsFinishedCreatePickingListJournalWithEndMarkedOperations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillReportAsFinishedCreateRouteCardJournalWithEndMarkedLines = group.Add(new VocabularyKey(nameof(WillReportAsFinishedCreateRouteCardJournalWithEndMarkedLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReportAsFinishedProductionJournalNameId = group.Add(new VocabularyKey(nameof(DefaultReportAsFinishedProductionJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportAsFinishedAutomaticRouteConsumptionRule = group.Add(new VocabularyKey(nameof(ReportAsFinishedAutomaticRouteConsumptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReportAsFinishedRouteCardProductionJournalNameId = group.Add(new VocabularyKey(nameof(DefaultReportAsFinishedRouteCardProductionJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportAsFinishedProductionOrderUpdateMethod = group.Add(new VocabularyKey(nameof(ReportAsFinishedProductionOrderUpdateMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReportAsFinishedUsingProductionOrderDefaults = group.Add(new VocabularyKey(nameof(IsReportAsFinishedUsingProductionOrderDefaults), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionStartAcceptQuantityDeviation = group.Add(new VocabularyKey(nameof(WillProductionStartAcceptQuantityDeviation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionStartAutomaticBOMConsumptionRule = group.Add(new VocabularyKey(nameof(ProductionStartAutomaticBOMConsumptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProductionStartPickingListProductionJournalNameId = group.Add(new VocabularyKey(nameof(DefaultProductionStartPickingListProductionJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionPickingListJournalLineGroupingMethod = group.Add(new VocabularyKey(nameof(ProductionPickingListJournalLineGroupingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionPickingListPostingUpdateBOMItemsFinishedPickingStatus = group.Add(new VocabularyKey(nameof(WillProductionPickingListPostingUpdateBOMItemsFinishedPickingStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionPickingListPostingAllowNegativeInventory = group.Add(new VocabularyKey(nameof(WillProductionPickingListPostingAllowNegativeInventory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionStartCreatePickingListJournalWithEndMarkedOperations = group.Add(new VocabularyKey(nameof(WillProductionStartCreatePickingListJournalWithEndMarkedOperations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionStartCreateRouteCardJournalWithEndMarkedLines = group.Add(new VocabularyKey(nameof(WillProductionStartCreateRouteCardJournalWithEndMarkedLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionStartMaximumAcceptedQuantityDeviationPercentage = group.Add(new VocabularyKey(nameof(ProductionStartMaximumAcceptedQuantityDeviationPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionStartAutomaticallyPostPickingList = group.Add(new VocabularyKey(nameof(WillProductionStartAutomaticallyPostPickingList), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionStartAutomaticallyPostRouteCard = group.Add(new VocabularyKey(nameof(WillProductionStartAutomaticallyPostRouteCard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionStartUpdateStartedQuantity = group.Add(new VocabularyKey(nameof(WillProductionStartUpdateStartedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionPickingListPostingReduceToAvailableQuantity = group.Add(new VocabularyKey(nameof(WillProductionPickingListPostingReduceToAvailableQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionStartStartReferencedProductionOrders = group.Add(new VocabularyKey(nameof(WillProductionStartStartReferencedProductionOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionStartAutomaticRouteConsumptionRule = group.Add(new VocabularyKey(nameof(ProductionStartAutomaticRouteConsumptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionStartOpenPickingListJournals = group.Add(new VocabularyKey(nameof(WillProductionStartOpenPickingListJournals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionStartProductionOrderUpdateMethod = group.Add(new VocabularyKey(nameof(ProductionStartProductionOrderUpdateMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionStartUseProductionOrderDefaults = group.Add(new VocabularyKey(nameof(WillProductionStartUseProductionOrderDefaults), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionStartQuantityValidationMethod = group.Add(new VocabularyKey(nameof(ProductionStartQuantityValidationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationFeedbackAutomaticBOMConsumptionRule = group.Add(new VocabularyKey(nameof(OperationFeedbackAutomaticBOMConsumptionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOperationFeedbackRouteCardJournalNameId = group.Add(new VocabularyKey(nameof(DefaultOperationFeedbackRouteCardJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillOperationFeedbackPostRouteCardJournal = group.Add(new VocabularyKey(nameof(WillOperationFeedbackPostRouteCardJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeJobCardProductionJournalNameId = group.Add(new VocabularyKey(nameof(TimeJobCardProductionJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOperationFeedbackQuantityValidated = group.Add(new VocabularyKey(nameof(IsOperationFeedbackQuantityValidated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductionstartQuantityValidated = group.Add(new VocabularyKey(nameof(IsProductionstartQuantityValidated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InventDimId { get; private set; }
        public VocabularyKey ProductionSiteId { get; private set; }
        public VocabularyKey DefaultProductionStartRouteCardProductionJournalNameId { get; private set; }
        public VocabularyKey IsOverlapJobRegistrationAllowed { get; private set; }
        public VocabularyKey IsProcessJobRegistrationAllowed { get; private set; }
        public VocabularyKey IsQueueAfterJobRegistrationAllowed { get; private set; }
        public VocabularyKey IsQueueBeforeJobRegistrationAllowed { get; private set; }
        public VocabularyKey IsSetupJobRegistrationAllowed { get; private set; }
        public VocabularyKey IsTransportJobRegistrationAllowed { get; private set; }
        public VocabularyKey AreAssistantsAssignedSecondaryOperations { get; private set; }
        public VocabularyKey WillOperationFeedbackOpenPickingListJournal { get; private set; }
        public VocabularyKey DefaultOperationFeedbackPickingListProductionJournalNameId { get; private set; }
        public VocabularyKey WillOperationFeedbackAutomaticallyPostPickingList { get; private set; }
        public VocabularyKey WillCostCalculationUseRouteCostCategory { get; private set; }
        public VocabularyKey WillOperationFeedbackAcceptSurplusDeviation { get; private set; }
        public VocabularyKey WillOperationFeedbackAcceptShortageDeviation { get; private set; }
        public VocabularyKey MaximumAcceptedOperationFeedbackSurplusDeviationPercentage { get; private set; }
        public VocabularyKey MaximumAcceptedOperationFeedbackShortageDeviationPercentage { get; private set; }
        public VocabularyKey OperationFeedbackQuantityValidationMethod { get; private set; }
        public VocabularyKey MaximumReportAsFinishedQuantity { get; private set; }
        public VocabularyKey WillRegistrationTransferAutomatiallyPostTimeJobCardJournal { get; private set; }
        public VocabularyKey ProductionRegistrationLedgerDimensionSelectionRule { get; private set; }
        public VocabularyKey WillReportAsFinishedPostingAcceptQuantityError { get; private set; }
        public VocabularyKey ReportAsFinishedAutomaticBOMConsumptionRule { get; private set; }
        public VocabularyKey DefaultReportAsFinishedPickingListProductionJournalNameId { get; private set; }
        public VocabularyKey IsReportAsFinishedJobFinalByDefault { get; private set; }
        public VocabularyKey WillReportAsFinishedCreatePickingListJournalWithEndMarkedOperations { get; private set; }
        public VocabularyKey WillReportAsFinishedCreateRouteCardJournalWithEndMarkedLines { get; private set; }
        public VocabularyKey DefaultReportAsFinishedProductionJournalNameId { get; private set; }
        public VocabularyKey ReportAsFinishedAutomaticRouteConsumptionRule { get; private set; }
        public VocabularyKey DefaultReportAsFinishedRouteCardProductionJournalNameId { get; private set; }
        public VocabularyKey ReportAsFinishedProductionOrderUpdateMethod { get; private set; }
        public VocabularyKey IsReportAsFinishedUsingProductionOrderDefaults { get; private set; }
        public VocabularyKey WillProductionStartAcceptQuantityDeviation { get; private set; }
        public VocabularyKey ProductionStartAutomaticBOMConsumptionRule { get; private set; }
        public VocabularyKey DefaultProductionStartPickingListProductionJournalNameId { get; private set; }
        public VocabularyKey ProductionPickingListJournalLineGroupingMethod { get; private set; }
        public VocabularyKey WillProductionPickingListPostingUpdateBOMItemsFinishedPickingStatus { get; private set; }
        public VocabularyKey WillProductionPickingListPostingAllowNegativeInventory { get; private set; }
        public VocabularyKey WillProductionStartCreatePickingListJournalWithEndMarkedOperations { get; private set; }
        public VocabularyKey WillProductionStartCreateRouteCardJournalWithEndMarkedLines { get; private set; }
        public VocabularyKey ProductionStartMaximumAcceptedQuantityDeviationPercentage { get; private set; }
        public VocabularyKey WillProductionStartAutomaticallyPostPickingList { get; private set; }
        public VocabularyKey WillProductionStartAutomaticallyPostRouteCard { get; private set; }
        public VocabularyKey WillProductionStartUpdateStartedQuantity { get; private set; }
        public VocabularyKey WillProductionPickingListPostingReduceToAvailableQuantity { get; private set; }
        public VocabularyKey WillProductionStartStartReferencedProductionOrders { get; private set; }
        public VocabularyKey ProductionStartAutomaticRouteConsumptionRule { get; private set; }
        public VocabularyKey WillProductionStartOpenPickingListJournals { get; private set; }
        public VocabularyKey ProductionStartProductionOrderUpdateMethod { get; private set; }
        public VocabularyKey WillProductionStartUseProductionOrderDefaults { get; private set; }
        public VocabularyKey ProductionStartQuantityValidationMethod { get; private set; }
        public VocabularyKey OperationFeedbackAutomaticBOMConsumptionRule { get; private set; }
        public VocabularyKey DefaultOperationFeedbackRouteCardJournalNameId { get; private set; }
        public VocabularyKey WillOperationFeedbackPostRouteCardJournal { get; private set; }
        public VocabularyKey TimeJobCardProductionJournalNameId { get; private set; }
        public VocabularyKey IsOperationFeedbackQuantityValidated { get; private set; }
        public VocabularyKey IsProductionstartQuantityValidated { get; private set; }


    }
}