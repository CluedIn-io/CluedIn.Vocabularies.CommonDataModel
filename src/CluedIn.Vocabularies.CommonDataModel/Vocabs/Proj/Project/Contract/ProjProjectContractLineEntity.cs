using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectContractLineEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectContractLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjProjectContractLineEntity";
            KeyPrefix = "commonDataModel.projprojectcontractlineentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectContractLineEntity";

            AddGroup("Common Data Model ProjProjectContractLineEntity Details", group =>
            {
                ChangeOrderNumber = group.Add(new VocabularyKey(nameof(ChangeOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractLineId = group.Add(new VocabularyKey(nameof(ContractLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeCategoryId = group.Add(new VocabularyKey(nameof(FeeCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeePercentage = group.Add(new VocabularyKey(nameof(FeePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeProjectId = group.Add(new VocabularyKey(nameof(FeeProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIndirectCostIncluded = group.Add(new VocabularyKey(nameof(IsIndirectCostIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingMethod = group.Add(new VocabularyKey(nameof(BillingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreHourTransactionsIncluded = group.Add(new VocabularyKey(nameof(AreHourTransactionsIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreExpenseTransactionsIncluded = group.Add(new VocabularyKey(nameof(AreExpenseTransactionsIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreFeeTransactionsIncluded = group.Add(new VocabularyKey(nameof(AreFeeTransactionsIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreItemTransactionsIncluded = group.Add(new VocabularyKey(nameof(AreItemTransactionsIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaidAmount = group.Add(new VocabularyKey(nameof(PaidAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetMethod = group.Add(new VocabularyKey(nameof(BudgetMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectContractId = group.Add(new VocabularyKey(nameof(ProjectContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetainagePercentage = group.Add(new VocabularyKey(nameof(RetainagePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRetentionTermId = group.Add(new VocabularyKey(nameof(CustomerRetentionTermId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATCommodityCode = group.Add(new VocabularyKey(nameof(VATCommodityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPrice = group.Add(new VocabularyKey(nameof(UnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssessableValue = group.Add(new VocabularyKey(nameof(AssessableValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumRetailPrice = group.Add(new VocabularyKey(nameof(MaximumRetailPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TCSGroupCode = group.Add(new VocabularyKey(nameof(TCSGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TDSGroupCode = group.Add(new VocabularyKey(nameof(TDSGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineSequenceNumber = group.Add(new VocabularyKey(nameof(LineSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjInvoiceProjId = group.Add(new VocabularyKey(nameof(ProjInvoiceProjId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineProjectId = group.Add(new VocabularyKey(nameof(LineProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ChangeOrderNumber { get; private set; }
        public VocabularyKey ContractLineId { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey FeeCategoryId { get; private set; }
        public VocabularyKey FeePercentage { get; private set; }
        public VocabularyKey FeeProjectId { get; private set; }
        public VocabularyKey IsIndirectCostIncluded { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey BillingMethod { get; private set; }
        public VocabularyKey AreHourTransactionsIncluded { get; private set; }
        public VocabularyKey AreExpenseTransactionsIncluded { get; private set; }
        public VocabularyKey AreFeeTransactionsIncluded { get; private set; }
        public VocabularyKey AreItemTransactionsIncluded { get; private set; }
        public VocabularyKey LineAmount { get; private set; }
        public VocabularyKey PaidAmount { get; private set; }
        public VocabularyKey BudgetMethod { get; private set; }
        public VocabularyKey ProjectContractId { get; private set; }
        public VocabularyKey RetainagePercentage { get; private set; }
        public VocabularyKey CustomerRetentionTermId { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey VATCommodityCode { get; private set; }
        public VocabularyKey UnitPrice { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey UnitSymbol { get; private set; }
        public VocabularyKey AssessableValue { get; private set; }
        public VocabularyKey MaximumRetailPrice { get; private set; }
        public VocabularyKey TCSGroupCode { get; private set; }
        public VocabularyKey TDSGroupCode { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey LineSequenceNumber { get; private set; }
        public VocabularyKey ProjInvoiceProjId { get; private set; }
        public VocabularyKey LineProjectId { get; private set; }


    }
}