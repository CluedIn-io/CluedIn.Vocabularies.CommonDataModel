using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FHLoanVocabulary : SimpleVocabulary
    {
        public FHLoanVocabulary()
        {
            VocabularyName = "FH Loan";
            KeyPrefix = "commonDataModel.fhloan";
            KeySeparator = ".";
            Grouping = "/FHLoan";

            AddGroup("FHLoan Details", group =>
            {
                FH_LoanId = group.Add(new VocabularyKey(nameof(FH_LoanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statecode = group.Add(new VocabularyKey(nameof(Statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statuscode = group.Add(new VocabularyKey(nameof(Statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingClassification = group.Add(new VocabularyKey(nameof(AccountingClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balance = group.Add(new VocabularyKey(nameof(Balance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balance_Base = group.Add(new VocabularyKey(nameof(Balance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceDefault = group.Add(new VocabularyKey(nameof(BalanceDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceExchangerate = group.Add(new VocabularyKey(nameof(BalanceExchangerate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapitalArrears = group.Add(new VocabularyKey(nameof(CapitalArrears), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Capitalarrears_Base = group.Add(new VocabularyKey(nameof(Capitalarrears_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapitalArrears_default = group.Add(new VocabularyKey(nameof(CapitalArrears_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionRisk = group.Add(new VocabularyKey(nameof(CollectionRisk), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DelinquencyStatus = group.Add(new VocabularyKey(nameof(DelinquencyStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisbursedAmount = group.Add(new VocabularyKey(nameof(DisbursedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Disbursedamount_Base = group.Add(new VocabularyKey(nameof(Disbursedamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisbursedAmount_default = group.Add(new VocabularyKey(nameof(DisbursedAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisbursementDate = group.Add(new VocabularyKey(nameof(DisbursementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeArrears = group.Add(new VocabularyKey(nameof(FeeArrears), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Feearrears_Base = group.Add(new VocabularyKey(nameof(Feearrears_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeArrears_default = group.Add(new VocabularyKey(nameof(FeeArrears_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialHoldingCategory = group.Add(new VocabularyKey(nameof(FinancialHoldingCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialHoldingType = group.Add(new VocabularyKey(nameof(FinancialHoldingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstallmentAmount = group.Add(new VocabularyKey(nameof(InstallmentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Installmentamount_Base = group.Add(new VocabularyKey(nameof(Installmentamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstallmentAmount_default = group.Add(new VocabularyKey(nameof(InstallmentAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegrationKey = group.Add(new VocabularyKey(nameof(IntegrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestArrears = group.Add(new VocabularyKey(nameof(InterestArrears), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Interestarrears_Base = group.Add(new VocabularyKey(nameof(Interestarrears_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestArrears_default = group.Add(new VocabularyKey(nameof(InterestArrears_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Interestrate = group.Add(new VocabularyKey(nameof(Interestrate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestReviewPeriod = group.Add(new VocabularyKey(nameof(InterestReviewPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestType = group.Add(new VocabularyKey(nameof(InterestType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastPaymentAmount = group.Add(new VocabularyKey(nameof(LastPaymentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lastpaymentamount_Base = group.Add(new VocabularyKey(nameof(Lastpaymentamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastPaymentAmount_default = group.Add(new VocabularyKey(nameof(LastPaymentAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastPaymentDate = group.Add(new VocabularyKey(nameof(LastPaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoanStartDate = group.Add(new VocabularyKey(nameof(LoanStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Maturitydate = group.Add(new VocabularyKey(nameof(Maturitydate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModeofPayment = group.Add(new VocabularyKey(nameof(ModeofPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextInterestReviewDate = group.Add(new VocabularyKey(nameof(NextInterestReviewDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextPaymentAmount = group.Add(new VocabularyKey(nameof(NextPaymentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Nextpaymentamount_Base = group.Add(new VocabularyKey(nameof(Nextpaymentamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextPaymentAmount_default = group.Add(new VocabularyKey(nameof(NextPaymentAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextPaymentDate = group.Add(new VocabularyKey(nameof(NextPaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberofDeferralsMade = group.Add(new VocabularyKey(nameof(NumberofDeferralsMade), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberofInstallmentsPaid = group.Add(new VocabularyKey(nameof(NumberofInstallmentsPaid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverdueDate = group.Add(new VocabularyKey(nameof(OverdueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrincipalAmount = group.Add(new VocabularyKey(nameof(PrincipalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Principalamount_Base = group.Add(new VocabularyKey(nameof(Principalamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrincipalAmount_default = group.Add(new VocabularyKey(nameof(PrincipalAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RepaymentAccount = group.Add(new VocabularyKey(nameof(RepaymentAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalArrear = group.Add(new VocabularyKey(nameof(TotalArrear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Totalarrear_Base = group.Add(new VocabularyKey(nameof(Totalarrear_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalArrear_default = group.Add(new VocabularyKey(nameof(TotalArrear_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalInterestPaid = group.Add(new VocabularyKey(nameof(TotalInterestPaid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Totalinterestpaid_Base = group.Add(new VocabularyKey(nameof(Totalinterestpaid_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalInterestPaid_default = group.Add(new VocabularyKey(nameof(TotalInterestPaid_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceDefaultDisplayValue = group.Add(new VocabularyKey(nameof(BalanceDefaultDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceDisplayValue = group.Add(new VocabularyKey(nameof(BalanceDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balancedisplayvalue_Base = group.Add(new VocabularyKey(nameof(Balancedisplayvalue_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dayspastdue = group.Add(new VocabularyKey(nameof(Dayspastdue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FH_LoanId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AccountingClassification { get; private set; }
        public VocabularyKey Balance { get; private set; }
        public VocabularyKey Balance_Base { get; private set; }
        public VocabularyKey BalanceDefault { get; private set; }
        public VocabularyKey BalanceExchangerate { get; private set; }
        public VocabularyKey CapitalArrears { get; private set; }
        public VocabularyKey Capitalarrears_Base { get; private set; }
        public VocabularyKey CapitalArrears_default { get; private set; }
        public VocabularyKey CollectionRisk { get; private set; }
        public VocabularyKey DelinquencyStatus { get; private set; }
        public VocabularyKey DisbursedAmount { get; private set; }
        public VocabularyKey Disbursedamount_Base { get; private set; }
        public VocabularyKey DisbursedAmount_default { get; private set; }
        public VocabularyKey DisbursementDate { get; private set; }
        public VocabularyKey FeeArrears { get; private set; }
        public VocabularyKey Feearrears_Base { get; private set; }
        public VocabularyKey FeeArrears_default { get; private set; }
        public VocabularyKey FinancialHoldingCategory { get; private set; }
        public VocabularyKey FinancialHoldingType { get; private set; }
        public VocabularyKey InstallmentAmount { get; private set; }
        public VocabularyKey Installmentamount_Base { get; private set; }
        public VocabularyKey InstallmentAmount_default { get; private set; }
        public VocabularyKey IntegrationKey { get; private set; }
        public VocabularyKey InterestArrears { get; private set; }
        public VocabularyKey Interestarrears_Base { get; private set; }
        public VocabularyKey InterestArrears_default { get; private set; }
        public VocabularyKey Interestrate { get; private set; }
        public VocabularyKey InterestReviewPeriod { get; private set; }
        public VocabularyKey InterestType { get; private set; }
        public VocabularyKey LastPaymentAmount { get; private set; }
        public VocabularyKey Lastpaymentamount_Base { get; private set; }
        public VocabularyKey LastPaymentAmount_default { get; private set; }
        public VocabularyKey LastPaymentDate { get; private set; }
        public VocabularyKey LoanStartDate { get; private set; }
        public VocabularyKey Maturitydate { get; private set; }
        public VocabularyKey ModeofPayment { get; private set; }
        public VocabularyKey NextInterestReviewDate { get; private set; }
        public VocabularyKey NextPaymentAmount { get; private set; }
        public VocabularyKey Nextpaymentamount_Base { get; private set; }
        public VocabularyKey NextPaymentAmount_default { get; private set; }
        public VocabularyKey NextPaymentDate { get; private set; }
        public VocabularyKey NumberofDeferralsMade { get; private set; }
        public VocabularyKey NumberofInstallmentsPaid { get; private set; }
        public VocabularyKey OverdueDate { get; private set; }
        public VocabularyKey PrincipalAmount { get; private set; }
        public VocabularyKey Principalamount_Base { get; private set; }
        public VocabularyKey PrincipalAmount_default { get; private set; }
        public VocabularyKey RepaymentAccount { get; private set; }
        public VocabularyKey TotalArrear { get; private set; }
        public VocabularyKey Totalarrear_Base { get; private set; }
        public VocabularyKey TotalArrear_default { get; private set; }
        public VocabularyKey TotalInterestPaid { get; private set; }
        public VocabularyKey Totalinterestpaid_Base { get; private set; }
        public VocabularyKey TotalInterestPaid_default { get; private set; }
        public VocabularyKey BalanceDefaultDisplayValue { get; private set; }
        public VocabularyKey BalanceDisplayValue { get; private set; }
        public VocabularyKey Balancedisplayvalue_Base { get; private set; }
        public VocabularyKey Dayspastdue { get; private set; }
    }
}