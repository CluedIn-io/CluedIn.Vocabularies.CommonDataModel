using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdProductionPickingListJournalEntryEntityVocabulary : SimpleVocabulary
    {
        public ProdProductionPickingListJournalEntryEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProdProductionPickingListJournalEntryEntity";
            KeyPrefix = "commonDataModel.prodproductionpickinglistjournalentryentity";
            KeySeparator = ".";
            Grouping = "/ProdProductionPickingListJournalEntryEntity";

            AddGroup("Common Data Model ProdProductionPickingListJournalEntryEntity Details", group =>
            {
                ConsumptionBOMQuantity = group.Add(new VocabularyKey(nameof(ConsumptionBOMQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProposalBOMQuantity = group.Add(new VocabularyKey(nameof(ProposalBOMQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScrapBOMQuantity = group.Add(new VocabularyKey(nameof(ScrapBOMQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMUnitSymbol = group.Add(new VocabularyKey(nameof(BOMUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsConsumptionEnded = group.Add(new VocabularyKey(nameof(IsConsumptionEnded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorCause = group.Add(new VocabularyKey(nameof(ErrorCause), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionInventoryQuantity = group.Add(new VocabularyKey(nameof(ConsumptionInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDimId = group.Add(new VocabularyKey(nameof(InventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProposalInventoryQuantity = group.Add(new VocabularyKey(nameof(ProposalInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsConsumptionReturned = group.Add(new VocabularyKey(nameof(IsConsumptionReturned), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryLotId = group.Add(new VocabularyKey(nameof(InventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalLineNumber = group.Add(new VocabularyKey(nameof(JournalLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationNumber = group.Add(new VocabularyKey(nameof(OperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ConsumptionCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProposalCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ProposalCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionNumber = group.Add(new VocabularyKey(nameof(PositionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionOrderNumber = group.Add(new VocabularyKey(nameof(ProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCostAmount = group.Add(new VocabularyKey(nameof(ProjectCostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectUnitCost = group.Add(new VocabularyKey(nameof(ProjectUnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectSalesCurrencyCode = group.Add(new VocabularyKey(nameof(ProjectSalesCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectSalesPrice = group.Add(new VocabularyKey(nameof(ProjectSalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTaxGroupCode = group.Add(new VocabularyKey(nameof(ProjectTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTaxItemGroupCode = group.Add(new VocabularyKey(nameof(ProjectTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTransactionId = group.Add(new VocabularyKey(nameof(ProjectTransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionDate = group.Add(new VocabularyKey(nameof(ConsumptionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectVoucherNumber = group.Add(new VocabularyKey(nameof(ProjectVoucherNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalDescription = group.Add(new VocabularyKey(nameof(JournalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalType = group.Add(new VocabularyKey(nameof(JournalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostedDateTime = group.Add(new VocabularyKey(nameof(PostedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostedUserId = group.Add(new VocabularyKey(nameof(PostedUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionPickingListPostingReduceToAvailableQuantity = group.Add(new VocabularyKey(nameof(WillProductionPickingListPostingReduceToAvailableQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionSiteId = group.Add(new VocabularyKey(nameof(ProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ConsumptionBOMQuantity { get; private set; }
        public VocabularyKey ProposalBOMQuantity { get; private set; }
        public VocabularyKey ScrapBOMQuantity { get; private set; }
        public VocabularyKey BOMUnitSymbol { get; private set; }
        public VocabularyKey IsConsumptionEnded { get; private set; }
        public VocabularyKey ErrorCause { get; private set; }
        public VocabularyKey ConsumptionInventoryQuantity { get; private set; }
        public VocabularyKey InventDimId { get; private set; }
        public VocabularyKey ProposalInventoryQuantity { get; private set; }
        public VocabularyKey IsConsumptionReturned { get; private set; }
        public VocabularyKey InventoryLotId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey JournalLineNumber { get; private set; }
        public VocabularyKey OperationNumber { get; private set; }
        public VocabularyKey ConsumptionCatchWeightQuantity { get; private set; }
        public VocabularyKey ProposalCatchWeightQuantity { get; private set; }
        public VocabularyKey PositionNumber { get; private set; }
        public VocabularyKey ProductionOrderNumber { get; private set; }
        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey ProjectCostAmount { get; private set; }
        public VocabularyKey ProjectUnitCost { get; private set; }
        public VocabularyKey ProjectSalesCurrencyCode { get; private set; }
        public VocabularyKey ProjectSalesPrice { get; private set; }
        public VocabularyKey ProjectTaxGroupCode { get; private set; }
        public VocabularyKey ProjectTaxItemGroupCode { get; private set; }
        public VocabularyKey ProjectTransactionId { get; private set; }
        public VocabularyKey ConsumptionDate { get; private set; }
        public VocabularyKey ProjectVoucherNumber { get; private set; }
        public VocabularyKey JournalDescription { get; private set; }
        public VocabularyKey JournalNumber { get; private set; }
        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey JournalType { get; private set; }
        public VocabularyKey IsPosted { get; private set; }
        public VocabularyKey PostedDateTime { get; private set; }
        public VocabularyKey PostedUserId { get; private set; }
        public VocabularyKey WillProductionPickingListPostingReduceToAvailableQuantity { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey InventoryOwnerId { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey ProductionSiteId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey InventoryStatusId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey LicensePlateNumber { get; private set; }


    }
}