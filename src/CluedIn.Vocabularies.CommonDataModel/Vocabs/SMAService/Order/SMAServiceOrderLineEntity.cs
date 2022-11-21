using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceOrderLineEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceOrderLineEntityVocabulary()
        {
            VocabularyName = "SMA Service Order Line Entity";
            KeyPrefix = "commonDataModel.smaserviceorderlineentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceOrderLineEntity";

            AddGroup("SMAServiceOrderLineEntity Details", group =>
            {
                ProjectSalesCurrencyCode = group.Add(new VocabularyKey(nameof(ProjectSalesCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DispatchActivityNumber = group.Add(new VocabularyKey(nameof(DispatchActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectActivityNumber = group.Add(new VocabularyKey(nameof(ProjectActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAgreementId = group.Add(new VocabularyKey(nameof(ServiceAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAgreementLineNumber = group.Add(new VocabularyKey(nameof(ServiceAgreementLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(ServiceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledExecutionDate = group.Add(new VocabularyKey(nameof(ScheduledExecutionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualExecutionDate = group.Add(new VocabularyKey(nameof(ActualExecutionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServicingWindowStartDate = group.Add(new VocabularyKey(nameof(ServicingWindowStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServicingWindowEndDate = group.Add(new VocabularyKey(nameof(ServicingWindowEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNote = group.Add(new VocabularyKey(nameof(LineNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceId = group.Add(new VocabularyKey(nameof(InvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseOffsetLedgerAccount = group.Add(new VocabularyKey(nameof(ExpenseOffsetLedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseOffsetLedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(ExpenseOffsetLedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseOffsetAccountType = group.Add(new VocabularyKey(nameof(ExpenseOffsetAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineOrigin = group.Add(new VocabularyKey(nameof(LineOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCostPrice = group.Add(new VocabularyKey(nameof(ProjectCostPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectLinePropertyId = group.Add(new VocabularyKey(nameof(ProjectLinePropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectSalesPrice = group.Add(new VocabularyKey(nameof(ProjectSalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTaxGroupCode = group.Add(new VocabularyKey(nameof(ProjectTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTaxItemGroupCode = group.Add(new VocabularyKey(nameof(ProjectTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTransactionId = group.Add(new VocabularyKey(nameof(ProjectTransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectDescription = group.Add(new VocabularyKey(nameof(ProjectDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceObjectId = group.Add(new VocabularyKey(nameof(ServiceObjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceObjectRelationId = group.Add(new VocabularyKey(nameof(ServiceObjectRelationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceOrderNumber = group.Add(new VocabularyKey(nameof(ServiceOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineStatus = group.Add(new VocabularyKey(nameof(LineStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceTaskId = group.Add(new VocabularyKey(nameof(ServiceTaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceEndBeforeTime = group.Add(new VocabularyKey(nameof(ServiceEndBeforeTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceStartAfterTime = group.Add(new VocabularyKey(nameof(ServiceStartAfterTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLineSignedOff = group.Add(new VocabularyKey(nameof(IsLineSignedOff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualServiceEndTime = group.Add(new VocabularyKey(nameof(ActualServiceEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualServiceStartTime = group.Add(new VocabularyKey(nameof(ActualServiceStartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceTransactionType = group.Add(new VocabularyKey(nameof(ServiceTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemUnitSymbol = group.Add(new VocabularyKey(nameof(ItemUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssignedTechnicianRecId = group.Add(new VocabularyKey(nameof(AssignedTechnicianRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssignedTechnicianPersonnelNumber = group.Add(new VocabularyKey(nameof(AssignedTechnicianPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Hours = group.Add(new VocabularyKey(nameof(Hours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemQuantity = group.Add(new VocabularyKey(nameof(ItemQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseQuantity = group.Add(new VocabularyKey(nameof(ExpenseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceInventorySiteId = group.Add(new VocabularyKey(nameof(ServiceInventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceInventoryWarehouseId = group.Add(new VocabularyKey(nameof(ServiceInventoryWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceInventoryStatusId = group.Add(new VocabularyKey(nameof(ServiceInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProjectSalesCurrencyCode { get; private set; }
        public VocabularyKey DispatchActivityNumber { get; private set; }
        public VocabularyKey ProjectActivityNumber { get; private set; }
        public VocabularyKey ServiceAgreementId { get; private set; }
        public VocabularyKey ServiceAgreementLineNumber { get; private set; }
        public VocabularyKey ServiceCustomerAccountNumber { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey ScheduledExecutionDate { get; private set; }
        public VocabularyKey ActualExecutionDate { get; private set; }
        public VocabularyKey ServicingWindowStartDate { get; private set; }
        public VocabularyKey ServicingWindowEndDate { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey LineDescription { get; private set; }
        public VocabularyKey LineNote { get; private set; }
        public VocabularyKey InvoiceId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ExpenseOffsetLedgerAccount { get; private set; }
        public VocabularyKey ExpenseOffsetLedgerAccountDisplayValue { get; private set; }
        public VocabularyKey ExpenseOffsetAccountType { get; private set; }
        public VocabularyKey LineOrigin { get; private set; }
        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey ProjectCostPrice { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ProjectLinePropertyId { get; private set; }
        public VocabularyKey ProjectSalesPrice { get; private set; }
        public VocabularyKey ProjectTaxGroupCode { get; private set; }
        public VocabularyKey ProjectTaxItemGroupCode { get; private set; }
        public VocabularyKey ProjectTransactionId { get; private set; }
        public VocabularyKey ProjectDescription { get; private set; }
        public VocabularyKey ServiceObjectId { get; private set; }
        public VocabularyKey ServiceObjectRelationId { get; private set; }
        public VocabularyKey ServiceOrderNumber { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey LineStatus { get; private set; }
        public VocabularyKey ServiceTaskId { get; private set; }
        public VocabularyKey ServiceEndBeforeTime { get; private set; }
        public VocabularyKey ServiceStartAfterTime { get; private set; }
        public VocabularyKey IsLineSignedOff { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey SalesTaxItemGroupCode { get; private set; }
        public VocabularyKey ActualServiceEndTime { get; private set; }
        public VocabularyKey ActualServiceStartTime { get; private set; }
        public VocabularyKey ServiceTransactionType { get; private set; }
        public VocabularyKey ItemUnitSymbol { get; private set; }
        public VocabularyKey AssignedTechnicianRecId { get; private set; }
        public VocabularyKey AssignedTechnicianPersonnelNumber { get; private set; }
        public VocabularyKey Hours { get; private set; }
        public VocabularyKey ItemQuantity { get; private set; }
        public VocabularyKey ExpenseQuantity { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ServiceInventorySiteId { get; private set; }
        public VocabularyKey ServiceInventoryWarehouseId { get; private set; }
        public VocabularyKey ServiceInventoryStatusId { get; private set; }
    }
}