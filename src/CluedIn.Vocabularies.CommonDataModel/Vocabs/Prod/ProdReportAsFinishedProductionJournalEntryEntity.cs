using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdReportAsFinishedProductionJournalEntryEntityVocabulary : SimpleVocabulary
    {
        public ProdReportAsFinishedProductionJournalEntryEntityVocabulary()
        {
            VocabularyName = "ProdReportAsFinishedProductionJournalEntryEntity";
            KeyPrefix = "commonDataModel.prodreportasfinishedproductionjournalentryentity";
            KeySeparator = ".";
            Grouping = "/ProdReportAsFinishedProductionJournalEntryEntity";

            AddGroup("ProdReportAsFinishedProductionJournalEntryEntity Details", group =>
            {
                ErrorCause = group.Add(new VocabularyKey(nameof(ErrorCause), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDimId = group.Add(new VocabularyKey(nameof(InventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReceiptReturned = group.Add(new VocabularyKey(nameof(IsReceiptReturned), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryLotId = group.Add(new VocabularyKey(nameof(InventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalLineNumber = group.Add(new VocabularyKey(nameof(JournalLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportedErrorCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ReportedErrorCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportedGoodCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ReportedGoodCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillAsFinishedPostingAcceptQuantityError = group.Add(new VocabularyKey(nameof(WillAsFinishedPostingAcceptQuantityError), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionType = group.Add(new VocabularyKey(nameof(ProductionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLastReportAsFinished = group.Add(new VocabularyKey(nameof(IsLastReportAsFinished), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionOrderNumber = group.Add(new VocabularyKey(nameof(ProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillReportAsFinishedPostingAutomaticallyPostPickingList = group.Add(new VocabularyKey(nameof(WillReportAsFinishedPostingAutomaticallyPostPickingList), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionPickingListJournalNumber = group.Add(new VocabularyKey(nameof(ProductionPickingListJournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportedErrorInventoryQuantity = group.Add(new VocabularyKey(nameof(ReportedErrorInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportedGoodInventoryQuantity = group.Add(new VocabularyKey(nameof(ReportedGoodInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportAsFinishedDate = group.Add(new VocabularyKey(nameof(ReportAsFinishedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherNumber = group.Add(new VocabularyKey(nameof(VoucherNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostedDateTime = group.Add(new VocabularyKey(nameof(PostedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostedUserId = group.Add(new VocabularyKey(nameof(PostedUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalDescription = group.Add(new VocabularyKey(nameof(JournalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionSiteId = group.Add(new VocabularyKey(nameof(ProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivedInventoryStatusId = group.Add(new VocabularyKey(nameof(ReceivedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ErrorCause { get; private set; }
        public VocabularyKey InventDimId { get; private set; }
        public VocabularyKey IsReceiptReturned { get; private set; }
        public VocabularyKey InventoryLotId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey JournalLineNumber { get; private set; }
        public VocabularyKey ReportedErrorCatchWeightQuantity { get; private set; }
        public VocabularyKey ReportedGoodCatchWeightQuantity { get; private set; }
        public VocabularyKey WillAsFinishedPostingAcceptQuantityError { get; private set; }
        public VocabularyKey ProductionType { get; private set; }
        public VocabularyKey IsLastReportAsFinished { get; private set; }
        public VocabularyKey ProductionOrderNumber { get; private set; }
        public VocabularyKey WillReportAsFinishedPostingAutomaticallyPostPickingList { get; private set; }
        public VocabularyKey ProductionPickingListJournalNumber { get; private set; }
        public VocabularyKey ReportedErrorInventoryQuantity { get; private set; }
        public VocabularyKey ReportedGoodInventoryQuantity { get; private set; }
        public VocabularyKey ReportAsFinishedDate { get; private set; }
        public VocabularyKey VoucherNumber { get; private set; }
        public VocabularyKey IsPosted { get; private set; }
        public VocabularyKey PostedDateTime { get; private set; }
        public VocabularyKey PostedUserId { get; private set; }
        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey JournalDescription { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey InventoryOwnerId { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey ProductionSiteId { get; private set; }
        public VocabularyKey ReceivedInventoryStatusId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey LicensePlateNumber { get; private set; }
        public VocabularyKey JournalNumber { get; private set; }


    }
}