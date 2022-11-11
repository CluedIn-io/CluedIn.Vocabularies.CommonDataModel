using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdRouteCardProductionJournalEntryEntityVocabulary : SimpleVocabulary
    {
        public ProdRouteCardProductionJournalEntryEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProdRouteCardProductionJournalEntryEntity";
            KeyPrefix = "commonDataModel.prodroutecardproductionjournalentryentity";
            KeySeparator = ".";
            Grouping = "/ProdRouteCardProductionJournalEntryEntity";

            AddGroup("Common Data Model ProdRouteCardProductionJournalEntryEntity Details", group =>
            {
                IsJobCancelled = group.Add(new VocabularyKey(nameof(IsJobCancelled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HoursRouteCostCategoryId = group.Add(new VocabularyKey(nameof(HoursRouteCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityRouteCostCategoryId = group.Add(new VocabularyKey(nameof(QuantityRouteCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorCause = group.Add(new VocabularyKey(nameof(ErrorCause), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobProcessingPercentage = group.Add(new VocabularyKey(nameof(JobProcessingPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourlyCostCategoryRate = group.Add(new VocabularyKey(nameof(HourlyCostCategoryRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegisteredHours = group.Add(new VocabularyKey(nameof(RegisteredHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteJobType = group.Add(new VocabularyKey(nameof(RouteJobType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalLineNumber = group.Add(new VocabularyKey(nameof(JournalLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOperationCompleted = group.Add(new VocabularyKey(nameof(IsOperationCompleted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationId = group.Add(new VocabularyKey(nameof(RouteOperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationNumber = group.Add(new VocabularyKey(nameof(RouteOperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationPriority = group.Add(new VocabularyKey(nameof(RouteOperationPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportedErrorCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ReportedErrorCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportedGoodCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ReportedGoodCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionOrderNumber = group.Add(new VocabularyKey(nameof(ProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDimId = group.Add(new VocabularyKey(nameof(InventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillRouteCardPostingAutomaticallyPostPickingList = group.Add(new VocabularyKey(nameof(WillRouteCardPostingAutomaticallyPostPickingList), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionPickingListJournalNumber = group.Add(new VocabularyKey(nameof(ProductionPickingListJournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillLastOperationEndingExecuteReportAsFinished = group.Add(new VocabularyKey(nameof(WillLastOperationEndingExecuteReportAsFinished), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportAsFinishedProductionJournalNumber = group.Add(new VocabularyKey(nameof(ReportAsFinishedProductionJournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportedErrorInventoryQuantity = group.Add(new VocabularyKey(nameof(ReportedErrorInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportedGoodInventoryQuantity = group.Add(new VocabularyKey(nameof(ReportedGoodInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityCostCategoryUnitCost = group.Add(new VocabularyKey(nameof(QuantityCostCategoryUnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionDate = group.Add(new VocabularyKey(nameof(ConsumptionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherNumber = group.Add(new VocabularyKey(nameof(VoucherNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsResourceId = group.Add(new VocabularyKey(nameof(OperationsResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionSiteId = group.Add(new VocabularyKey(nameof(ProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivedInventoryStatusId = group.Add(new VocabularyKey(nameof(ReceivedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostedDateTime = group.Add(new VocabularyKey(nameof(PostedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostedUserId = group.Add(new VocabularyKey(nameof(PostedUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalDescription = group.Add(new VocabularyKey(nameof(JournalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsJobCancelled { get; private set; }
        public VocabularyKey HoursRouteCostCategoryId { get; private set; }
        public VocabularyKey QuantityRouteCostCategoryId { get; private set; }
        public VocabularyKey ErrorCause { get; private set; }
        public VocabularyKey JobProcessingPercentage { get; private set; }
        public VocabularyKey HourlyCostCategoryRate { get; private set; }
        public VocabularyKey RegisteredHours { get; private set; }
        public VocabularyKey RouteJobType { get; private set; }
        public VocabularyKey JournalLineNumber { get; private set; }
        public VocabularyKey IsOperationCompleted { get; private set; }
        public VocabularyKey RouteOperationId { get; private set; }
        public VocabularyKey RouteOperationNumber { get; private set; }
        public VocabularyKey RouteOperationPriority { get; private set; }
        public VocabularyKey ReportedErrorCatchWeightQuantity { get; private set; }
        public VocabularyKey ReportedGoodCatchWeightQuantity { get; private set; }
        public VocabularyKey ProductionOrderNumber { get; private set; }
        public VocabularyKey InventDimId { get; private set; }
        public VocabularyKey WillRouteCardPostingAutomaticallyPostPickingList { get; private set; }
        public VocabularyKey ProductionPickingListJournalNumber { get; private set; }
        public VocabularyKey WillLastOperationEndingExecuteReportAsFinished { get; private set; }
        public VocabularyKey ReportAsFinishedProductionJournalNumber { get; private set; }
        public VocabularyKey ReportedErrorInventoryQuantity { get; private set; }
        public VocabularyKey ReportedGoodInventoryQuantity { get; private set; }
        public VocabularyKey QuantityCostCategoryUnitCost { get; private set; }
        public VocabularyKey ConsumptionDate { get; private set; }
        public VocabularyKey VoucherNumber { get; private set; }
        public VocabularyKey OperationsResourceId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey InventoryOwnerId { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey ProductionSiteId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ReceivedInventoryStatusId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey LicensePlateNumber { get; private set; }
        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey PostedDateTime { get; private set; }
        public VocabularyKey IsPosted { get; private set; }
        public VocabularyKey PostedUserId { get; private set; }
        public VocabularyKey JournalNumber { get; private set; }
        public VocabularyKey JournalDescription { get; private set; }


    }
}