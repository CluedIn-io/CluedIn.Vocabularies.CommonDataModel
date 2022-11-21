using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCDSActualsImportEntityVocabulary : SimpleVocabulary
    {
        public ProjCDSActualsImportEntityVocabulary()
        {
            VocabularyName = "Proj CDS Actuals Import Entity";
            KeyPrefix = "commonDataModel.projcdsactualsimportentity";
            KeySeparator = ".";
            Grouping = "/ProjCDSActualsImportEntity";

            AddGroup("ProjCDSActualsImportEntity Details", group =>
            {
                AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualId = group.Add(new VocabularyKey(nameof(ActualId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualsImportId = group.Add(new VocabularyKey(nameof(ActualsImportId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdjustmentStatus = group.Add(new VocabularyKey(nameof(AdjustmentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountMST = group.Add(new VocabularyKey(nameof(AmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingStatusId = group.Add(new VocabularyKey(nameof(BillingStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingType = group.Add(new VocabularyKey(nameof(BillingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractId = group.Add(new VocabularyKey(nameof(ContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractLine = group.Add(new VocabularyKey(nameof(ContractLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractingUnit = group.Add(new VocabularyKey(nameof(ContractingUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateDate = group.Add(new VocabularyKey(nameof(ExchangeRateDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalDescription = group.Add(new VocabularyKey(nameof(ExternalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalReference = group.Add(new VocabularyKey(nameof(ExternalReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceId = group.Add(new VocabularyKey(nameof(InvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsJournalized = group.Add(new VocabularyKey(nameof(IsJournalized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwningBusinessId = group.Add(new VocabularyKey(nameof(OwningBusinessId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusReason = group.Add(new VocabularyKey(nameof(StatusReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskId = group.Add(new VocabularyKey(nameof(TaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionClassification = group.Add(new VocabularyKey(nameof(TransactionClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCategory = group.Add(new VocabularyKey(nameof(TransactionCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyId = group.Add(new VocabularyKey(nameof(TransactionCurrencyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasure = group.Add(new VocabularyKey(nameof(UnitOfMeasure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransType = group.Add(new VocabularyKey(nameof(TransType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPrice = group.Add(new VocabularyKey(nameof(UnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPriceMST = group.Add(new VocabularyKey(nameof(UnitPriceMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceOperationUnitId = group.Add(new VocabularyKey(nameof(ResourceOperationUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectDataAreaId = group.Add(new VocabularyKey(nameof(ProjectDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDuplicate = group.Add(new VocabularyKey(nameof(IsDuplicate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountingDate { get; private set; }
        public VocabularyKey ActualId { get; private set; }
        public VocabularyKey ActualsImportId { get; private set; }
        public VocabularyKey AdjustmentStatus { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey AmountMST { get; private set; }
        public VocabularyKey BillingStatusId { get; private set; }
        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey ContractId { get; private set; }
        public VocabularyKey ContractLine { get; private set; }
        public VocabularyKey ContractingUnit { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey ExchangeRateDate { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExternalDescription { get; private set; }
        public VocabularyKey ExternalReference { get; private set; }
        public VocabularyKey InvoiceId { get; private set; }
        public VocabularyKey IsJournalized { get; private set; }
        public VocabularyKey OwningBusinessId { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StatusReason { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey TaskId { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
        public VocabularyKey TransactionCategory { get; private set; }
        public VocabularyKey TransactionCurrencyId { get; private set; }
        public VocabularyKey UnitOfMeasure { get; private set; }
        public VocabularyKey TransType { get; private set; }
        public VocabularyKey UnitPrice { get; private set; }
        public VocabularyKey UnitPriceMST { get; private set; }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey ResourceOperationUnitId { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey ProjectDataAreaId { get; private set; }
        public VocabularyKey IsDuplicate { get; private set; }
    }
}