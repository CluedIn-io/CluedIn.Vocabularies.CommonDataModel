using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceAgreementLineEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceAgreementLineEntityVocabulary()
        {
            VocabularyName = "SMA Service Agreement Line Entity";
            KeyPrefix = "commonDataModel.smaserviceagreementlineentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceAgreementLineEntity";

            AddGroup("SMAServiceAgreementLineEntity Details", group =>
            {
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLineSuspended = group.Add(new VocabularyKey(nameof(IsLineSuspended), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSetup = group.Add(new VocabularyKey(nameof(ItemSetup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemUnitSymbol = group.Add(new VocabularyKey(nameof(ItemUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNote = group.Add(new VocabularyKey(nameof(LineNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodEndDate = group.Add(new VocabularyKey(nameof(PeriodEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodStartDate = group.Add(new VocabularyKey(nameof(PeriodStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectActivityNumber = group.Add(new VocabularyKey(nameof(ProjectActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCustomerAccountNumber = group.Add(new VocabularyKey(nameof(ProjectCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectSalesCurrencyCode = group.Add(new VocabularyKey(nameof(ProjectSalesCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectLinePropertyId = group.Add(new VocabularyKey(nameof(ProjectLinePropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTaxGroupCode = group.Add(new VocabularyKey(nameof(ProjectTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTaxItemGroupCode = group.Add(new VocabularyKey(nameof(ProjectTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectDescription = group.Add(new VocabularyKey(nameof(ProjectDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAgreementId = group.Add(new VocabularyKey(nameof(ServiceAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceIntervalId = group.Add(new VocabularyKey(nameof(ServiceIntervalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceObjectId = group.Add(new VocabularyKey(nameof(ServiceObjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceObjectRelationId = group.Add(new VocabularyKey(nameof(ServiceObjectRelationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceTaskId = group.Add(new VocabularyKey(nameof(ServiceTaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceEndBeforeTime = group.Add(new VocabularyKey(nameof(ServiceEndBeforeTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceStartAfterTime = group.Add(new VocabularyKey(nameof(ServiceStartAfterTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceTimeWindowId = group.Add(new VocabularyKey(nameof(ServiceTimeWindowId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceTransactionType = group.Add(new VocabularyKey(nameof(ServiceTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceInventoryAgreementSiteId = group.Add(new VocabularyKey(nameof(ServiceInventoryAgreementSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceInventoryAgreementWarehouseId = group.Add(new VocabularyKey(nameof(ServiceInventoryAgreementWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceInventoryAgreementWarehouseLocationId = group.Add(new VocabularyKey(nameof(ServiceInventoryAgreementWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Hours = group.Add(new VocabularyKey(nameof(Hours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemQuantity = group.Add(new VocabularyKey(nameof(ItemQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseQuantity = group.Add(new VocabularyKey(nameof(ExpenseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey IsLineSuspended { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ItemSetup { get; private set; }
        public VocabularyKey ItemUnitSymbol { get; private set; }
        public VocabularyKey LineDescription { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey LineNote { get; private set; }
        public VocabularyKey PeriodEndDate { get; private set; }
        public VocabularyKey PeriodStartDate { get; private set; }
        public VocabularyKey ProjectActivityNumber { get; private set; }
        public VocabularyKey ProjectCustomerAccountNumber { get; private set; }
        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey ProjectSalesCurrencyCode { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ProjectLinePropertyId { get; private set; }
        public VocabularyKey ProjectTaxGroupCode { get; private set; }
        public VocabularyKey ProjectTaxItemGroupCode { get; private set; }
        public VocabularyKey ProjectDescription { get; private set; }
        public VocabularyKey ServiceAgreementId { get; private set; }
        public VocabularyKey ServiceIntervalId { get; private set; }
        public VocabularyKey ServiceObjectId { get; private set; }
        public VocabularyKey ServiceObjectRelationId { get; private set; }
        public VocabularyKey ServiceTaskId { get; private set; }
        public VocabularyKey ServiceEndBeforeTime { get; private set; }
        public VocabularyKey ServiceStartAfterTime { get; private set; }
        public VocabularyKey ServiceTimeWindowId { get; private set; }
        public VocabularyKey ServiceTransactionType { get; private set; }
        public VocabularyKey WorkerPersonnelNumber { get; private set; }
        public VocabularyKey ServiceInventoryAgreementSiteId { get; private set; }
        public VocabularyKey ServiceInventoryAgreementWarehouseId { get; private set; }
        public VocabularyKey ServiceInventoryAgreementWarehouseLocationId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey Hours { get; private set; }
        public VocabularyKey ItemQuantity { get; private set; }
        public VocabularyKey ExpenseQuantity { get; private set; }
    }
}