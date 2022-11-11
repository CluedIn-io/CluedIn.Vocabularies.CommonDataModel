using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerJournalNameEntityVocabulary : SimpleVocabulary
    {
        public LedgerJournalNameEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerJournalNameEntity";
            KeyPrefix = "commonDataModel.ledgerjournalnameentity";
            KeySeparator = ".";
            Grouping = "/LedgerJournalNameEntity";

            AddGroup("Common Data Model LedgerJournalNameEntity Details", group =>
            {
                IsApprovalActive = group.Add(new VocabularyKey(nameof(IsApprovalActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApprovalUserGroup = group.Add(new VocabularyKey(nameof(ApprovalUserGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrivateForUserGroup = group.Add(new VocabularyKey(nameof(PrivateForUserGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCashAccount = group.Add(new VocabularyKey(nameof(DefaultCashAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowId = group.Add(new VocabularyKey(nameof(WorkflowId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrincipleOfDateInitialization = group.Add(new VocabularyKey(nameof(PrincipleOfDateInitialization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultFinancialDimension = group.Add(new VocabularyKey(nameof(DefaultFinancialDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DetailLevel = group.Add(new VocabularyKey(nameof(DetailLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndBalanceControl = group.Add(new VocabularyKey(nameof(EndBalanceControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFixedExchangeRate = group.Add(new VocabularyKey(nameof(IsFixedExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFixedOffsetAccount = group.Add(new VocabularyKey(nameof(IsFixedOffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneratePaymentsBeforePosting = group.Add(new VocabularyKey(nameof(GeneratePaymentsBeforePosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeesPosting = group.Add(new VocabularyKey(nameof(FeesPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountsIncludeSalesTax = group.Add(new VocabularyKey(nameof(AmountsIncludeSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingLineLimit = group.Add(new VocabularyKey(nameof(PostingLineLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingDateControl = group.Add(new VocabularyKey(nameof(PostingDateControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NewVoucher = group.Add(new VocabularyKey(nameof(NewVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherSeries = group.Add(new VocabularyKey(nameof(VoucherSeries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountType = group.Add(new VocabularyKey(nameof(OffsetAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowOnlyPositiveDebitsAndCredits = group.Add(new VocabularyKey(nameof(AllowOnlyPositiveDebitsAndCredits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrepaymentJournalVoucher = group.Add(new VocabularyKey(nameof(PrepaymentJournalVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HideSalesTaxFieldsInJournalEntryForms = group.Add(new VocabularyKey(nameof(HideSalesTaxFieldsInJournalEntryForms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherAllocationAtPosting = group.Add(new VocabularyKey(nameof(VoucherAllocationAtPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkflowApprovalActive = group.Add(new VocabularyKey(nameof(IsWorkflowApprovalActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherSeriesCode = group.Add(new VocabularyKey(nameof(VoucherSeriesCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherSeriesCompanyId = group.Add(new VocabularyKey(nameof(VoucherSeriesCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultFinancialDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultFinancialDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiresSimulationValidation_IT = group.Add(new VocabularyKey(nameof(RequiresSimulationValidation_IT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsApprovalActive { get; private set; }
        public VocabularyKey ApprovalUserGroup { get; private set; }
        public VocabularyKey PrivateForUserGroup { get; private set; }
        public VocabularyKey DefaultCashAccount { get; private set; }
        public VocabularyKey WorkflowId { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey PostingLayer { get; private set; }
        public VocabularyKey PrincipleOfDateInitialization { get; private set; }
        public VocabularyKey DefaultFinancialDimension { get; private set; }
        public VocabularyKey DetailLevel { get; private set; }
        public VocabularyKey DocumentNumber { get; private set; }
        public VocabularyKey EndBalanceControl { get; private set; }
        public VocabularyKey IsFixedExchangeRate { get; private set; }
        public VocabularyKey IsFixedOffsetAccount { get; private set; }
        public VocabularyKey GeneratePaymentsBeforePosting { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey FeesPosting { get; private set; }
        public VocabularyKey AmountsIncludeSalesTax { get; private set; }
        public VocabularyKey PostingLineLimit { get; private set; }
        public VocabularyKey PostingDateControl { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey NewVoucher { get; private set; }
        public VocabularyKey VoucherSeries { get; private set; }
        public VocabularyKey OffsetAccountType { get; private set; }
        public VocabularyKey OffsetAccount { get; private set; }
        public VocabularyKey AllowOnlyPositiveDebitsAndCredits { get; private set; }
        public VocabularyKey PrepaymentJournalVoucher { get; private set; }
        public VocabularyKey HideSalesTaxFieldsInJournalEntryForms { get; private set; }
        public VocabularyKey VoucherAllocationAtPosting { get; private set; }
        public VocabularyKey IsWorkflowApprovalActive { get; private set; }
        public VocabularyKey VoucherSeriesCode { get; private set; }
        public VocabularyKey VoucherSeriesCompanyId { get; private set; }
        public VocabularyKey DefaultFinancialDimensionDisplayValue { get; private set; }
        public VocabularyKey OffsetAccountDisplayValue { get; private set; }
        public VocabularyKey RequiresSimulationValidation_IT { get; private set; }


    }
}