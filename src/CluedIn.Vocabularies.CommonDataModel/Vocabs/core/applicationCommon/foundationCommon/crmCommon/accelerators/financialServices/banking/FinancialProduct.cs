using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Banking
{
    public class FinancialProductVocabulary : SimpleVocabulary
    {
        public FinancialProductVocabulary()
        {
            VocabularyName = "Financial Product";
            KeyPrefix = "commonDataModel.financialproduct.banking";
            KeySeparator = ".";
            Grouping = "/FinancialProduct";

            AddGroup("FinancialProduct Details for Banking", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AvailableBalance = group.Add(new VocabularyKey(nameof(AvailableBalance), "Available Balance", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AvailableBalanceBase = group.Add(new VocabularyKey(nameof(AvailableBalanceBase), "Available Balance (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AverageBalance = group.Add(new VocabularyKey(nameof(AverageBalance), "Average Balance", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AverageBalanceBase = group.Add(new VocabularyKey(nameof(AverageBalanceBase), "Average Balance (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BalanceAtMaturity = group.Add(new VocabularyKey(nameof(BalanceAtMaturity), "Balance at Maturity", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BalanceAtMaturityBase = group.Add(new VocabularyKey(nameof(BalanceAtMaturityBase), "Balance at Maturity (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BlockedAmount = group.Add(new VocabularyKey(nameof(BlockedAmount), "Blocked Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BlockedAmountBase = group.Add(new VocabularyKey(nameof(BlockedAmountBase), "Blocked Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BookBalance = group.Add(new VocabularyKey(nameof(BookBalance), "Book Balance", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BookBalanceBase = group.Add(new VocabularyKey(nameof(BookBalanceBase), "Book Balance (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CapitalArrears = group.Add(new VocabularyKey(nameof(CapitalArrears), "Capital Arrears", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CapitalArrearsBase = group.Add(new VocabularyKey(nameof(CapitalArrearsBase), "Capital Arrears (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CollectionRisk = group.Add(new VocabularyKey(nameof(CollectionRisk), "Collection Risk", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DaysPastDue = group.Add(new VocabularyKey(nameof(DaysPastDue), "Days Past Due", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DebtType = group.Add(new VocabularyKey(nameof(DebtType), "Debt Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DelinquencyStatus = group.Add(new VocabularyKey(nameof(DelinquencyStatus), "Delinquency Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisbursedAmount = group.Add(new VocabularyKey(nameof(DisbursedAmount), "Disbursed Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DisbursedAmountBase = group.Add(new VocabularyKey(nameof(DisbursedAmountBase), "Disbursed Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DisbursementDate = group.Add(new VocabularyKey(nameof(DisbursementDate), "Disbursement Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FinancialProductId = group.Add(new VocabularyKey(nameof(FinancialProductId), "Financial Product", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InitialDeposit = group.Add(new VocabularyKey(nameof(InitialDeposit), "Initial Deposit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InitialDepositBase = group.Add(new VocabularyKey(nameof(InitialDepositBase), "Initial Deposit (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InitialDepositSource = group.Add(new VocabularyKey(nameof(InitialDepositSource), "Initial Deposit Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InstallmentAmount = group.Add(new VocabularyKey(nameof(InstallmentAmount), "Installment Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InstallmentAmountBase = group.Add(new VocabularyKey(nameof(InstallmentAmountBase), "Installment Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InterestAmount = group.Add(new VocabularyKey(nameof(InterestAmount), "Interest Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InterestAmountBase = group.Add(new VocabularyKey(nameof(InterestAmountBase), "Interest Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InterestArrears = group.Add(new VocabularyKey(nameof(InterestArrears), "Interest Arrears", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InterestArrearsBase = group.Add(new VocabularyKey(nameof(InterestArrearsBase), "Interest Arrears (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InterestRate = group.Add(new VocabularyKey(nameof(InterestRate), "Interest Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    IsSyndicated = group.Add(new VocabularyKey(nameof(IsSyndicated), "Is Syndicated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    JointType = group.Add(new VocabularyKey(nameof(JointType), "Joint Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastPaymentAmount = group.Add(new VocabularyKey(nameof(LastPaymentAmount), "Last Payment Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    LastPaymentAmountBase = group.Add(new VocabularyKey(nameof(LastPaymentAmountBase), "Last Payment Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    LastPaymentDate = group.Add(new VocabularyKey(nameof(LastPaymentDate), "Last Payment Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LoanMaturityDate = group.Add(new VocabularyKey(nameof(LoanMaturityDate), "Loan Maturity Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LoanStartDate = group.Add(new VocabularyKey(nameof(LoanStartDate), "Loan Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LoanType = group.Add(new VocabularyKey(nameof(LoanType), "Loan Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MaturityDate = group.Add(new VocabularyKey(nameof(MaturityDate), "Maturity Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MaturityInstructionsDetails = group.Add(new VocabularyKey(nameof(MaturityInstructionsDetails), "Maturity Instructions Details", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModeOfPayment = group.Add(new VocabularyKey(nameof(ModeOfPayment), "Mode of Payment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NextPaymentAmount = group.Add(new VocabularyKey(nameof(NextPaymentAmount), "Next Payment Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    NextPaymentAmountBase = group.Add(new VocabularyKey(nameof(NextPaymentAmountBase), "Next Payment Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    NextPaymentDate = group.Add(new VocabularyKey(nameof(NextPaymentDate), "Next Payment Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Number = group.Add(new VocabularyKey(nameof(Number), "Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfDeferralsMade = group.Add(new VocabularyKey(nameof(NumberOfDeferralsMade), "Number of Deferrals Made", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    NumberOfInstallmentsPaid = group.Add(new VocabularyKey(nameof(NumberOfInstallmentsPaid), "Number of Installments Paid", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OpeningDate = group.Add(new VocabularyKey(nameof(OpeningDate), "Opening Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OutstandingPrincipalAmount = group.Add(new VocabularyKey(nameof(OutstandingPrincipalAmount), "Outstanding Principal Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OutstandingPrincipalAmountBase = group.Add(new VocabularyKey(nameof(OutstandingPrincipalAmountBase), "Outstanding Principal Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OutstandingTotalAmount = group.Add(new VocabularyKey(nameof(OutstandingTotalAmount), "Outstanding Total Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OutstandingTotalAmountBase = group.Add(new VocabularyKey(nameof(OutstandingTotalAmountBase), "Outstanding Total Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OverdraftLimit = group.Add(new VocabularyKey(nameof(OverdraftLimit), "Overdraft Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OverdraftLimitBase = group.Add(new VocabularyKey(nameof(OverdraftLimitBase), "Overdraft Limit (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OverdraftRate = group.Add(new VocabularyKey(nameof(OverdraftRate), "Overdraft Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    OverdueDate = group.Add(new VocabularyKey(nameof(OverdueDate), "Overdue Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverdueInstallmentAmount = group.Add(new VocabularyKey(nameof(OverdueInstallmentAmount), "Overdue Installment Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OverdueInstallmentAmountBase = group.Add(new VocabularyKey(nameof(OverdueInstallmentAmountBase), "Overdue Installment Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PrincipalAmount = group.Add(new VocabularyKey(nameof(PrincipalAmount), "Principal Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PrincipalAmountBase = group.Add(new VocabularyKey(nameof(PrincipalAmountBase), "Principal Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ProjectedInterestAmount = group.Add(new VocabularyKey(nameof(ProjectedInterestAmount), "Projected Interest Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ProjectedInterestAmountBase = group.Add(new VocabularyKey(nameof(ProjectedInterestAmountBase), "Projected Interest Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PurposeOfLoan = group.Add(new VocabularyKey(nameof(PurposeOfLoan), "Purpose of Loan", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Rate = group.Add(new VocabularyKey(nameof(Rate), "Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SourceOfFunds = group.Add(new VocabularyKey(nameof(SourceOfFunds), "Source of Funds", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Term = group.Add(new VocabularyKey(nameof(Term), "Term", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TotalArrear = group.Add(new VocabularyKey(nameof(TotalArrear), "Total Arrear", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalArrearBase = group.Add(new VocabularyKey(nameof(TotalArrearBase), "Total Arrear (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalInterestPaid = group.Add(new VocabularyKey(nameof(TotalInterestPaid), "Total Interest Paid", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalInterestPaidBase = group.Add(new VocabularyKey(nameof(TotalInterestPaidBase), "Total Interest Paid (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    UnclearedBalance = group.Add(new VocabularyKey(nameof(UnclearedBalance), "Uncleared Balance", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    UnclearedBalanceBase = group.Add(new VocabularyKey(nameof(UnclearedBalanceBase), "Uncleared Balance (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    UnsecuredAmount = group.Add(new VocabularyKey(nameof(UnsecuredAmount), "Unsecured Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    UnsecuredAmountBase = group.Add(new VocabularyKey(nameof(UnsecuredAmountBase), "Unsecured Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    DeprecatedStageId = group.Add(new VocabularyKey(nameof(DeprecatedStageId), "(Deprecated) Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeprecatedTraversedPath = group.Add(new VocabularyKey(nameof(DeprecatedTraversedPath), "(Deprecated) Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AvailableBalance { get; private set; }
        public VocabularyKey AvailableBalanceBase { get; private set; }
        public VocabularyKey AverageBalance { get; private set; }
        public VocabularyKey AverageBalanceBase { get; private set; }
        public VocabularyKey BalanceAtMaturity { get; private set; }
        public VocabularyKey BalanceAtMaturityBase { get; private set; }
        public VocabularyKey BlockedAmount { get; private set; }
        public VocabularyKey BlockedAmountBase { get; private set; }
        public VocabularyKey BookBalance { get; private set; }
        public VocabularyKey BookBalanceBase { get; private set; }
        public VocabularyKey CapitalArrears { get; private set; }
        public VocabularyKey CapitalArrearsBase { get; private set; }
        public VocabularyKey CollectionRisk { get; private set; }
        public VocabularyKey DaysPastDue { get; private set; }
        public VocabularyKey DebtType { get; private set; }
        public VocabularyKey DelinquencyStatus { get; private set; }
        public VocabularyKey DisbursedAmount { get; private set; }
        public VocabularyKey DisbursedAmountBase { get; private set; }
        public VocabularyKey DisbursementDate { get; private set; }
        public VocabularyKey FinancialProductId { get; private set; }
        public VocabularyKey InitialDeposit { get; private set; }
        public VocabularyKey InitialDepositBase { get; private set; }
        public VocabularyKey InitialDepositSource { get; private set; }
        public VocabularyKey InstallmentAmount { get; private set; }
        public VocabularyKey InstallmentAmountBase { get; private set; }
        public VocabularyKey InterestAmount { get; private set; }
        public VocabularyKey InterestAmountBase { get; private set; }
        public VocabularyKey InterestArrears { get; private set; }
        public VocabularyKey InterestArrearsBase { get; private set; }
        public VocabularyKey InterestRate { get; private set; }
        public VocabularyKey IsSyndicated { get; private set; }
        public VocabularyKey JointType { get; private set; }
        public VocabularyKey LastPaymentAmount { get; private set; }
        public VocabularyKey LastPaymentAmountBase { get; private set; }
        public VocabularyKey LastPaymentDate { get; private set; }
        public VocabularyKey LoanMaturityDate { get; private set; }
        public VocabularyKey LoanStartDate { get; private set; }
        public VocabularyKey LoanType { get; private set; }
        public VocabularyKey MaturityDate { get; private set; }
        public VocabularyKey MaturityInstructionsDetails { get; private set; }
        public VocabularyKey ModeOfPayment { get; private set; }
        public VocabularyKey NextPaymentAmount { get; private set; }
        public VocabularyKey NextPaymentAmountBase { get; private set; }
        public VocabularyKey NextPaymentDate { get; private set; }
        public VocabularyKey Number { get; private set; }
        public VocabularyKey NumberOfDeferralsMade { get; private set; }
        public VocabularyKey NumberOfInstallmentsPaid { get; private set; }
        public VocabularyKey OpeningDate { get; private set; }
        public VocabularyKey OutstandingPrincipalAmount { get; private set; }
        public VocabularyKey OutstandingPrincipalAmountBase { get; private set; }
        public VocabularyKey OutstandingTotalAmount { get; private set; }
        public VocabularyKey OutstandingTotalAmountBase { get; private set; }
        public VocabularyKey OverdraftLimit { get; private set; }
        public VocabularyKey OverdraftLimitBase { get; private set; }
        public VocabularyKey OverdraftRate { get; private set; }
        public VocabularyKey OverdueDate { get; private set; }
        public VocabularyKey OverdueInstallmentAmount { get; private set; }
        public VocabularyKey OverdueInstallmentAmountBase { get; private set; }
        public VocabularyKey PrincipalAmount { get; private set; }
        public VocabularyKey PrincipalAmountBase { get; private set; }
        public VocabularyKey ProjectedInterestAmount { get; private set; }
        public VocabularyKey ProjectedInterestAmountBase { get; private set; }
        public VocabularyKey PurposeOfLoan { get; private set; }
        public VocabularyKey Rate { get; private set; }
        public VocabularyKey SourceOfFunds { get; private set; }
        public VocabularyKey Term { get; private set; }
        public VocabularyKey TotalArrear { get; private set; }
        public VocabularyKey TotalArrearBase { get; private set; }
        public VocabularyKey TotalInterestPaid { get; private set; }
        public VocabularyKey TotalInterestPaidBase { get; private set; }
        public VocabularyKey UnclearedBalance { get; private set; }
        public VocabularyKey UnclearedBalanceBase { get; private set; }
        public VocabularyKey UnsecuredAmount { get; private set; }
        public VocabularyKey UnsecuredAmountBase { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey DeprecatedStageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey DeprecatedTraversedPath { get; private set; }
    }
}