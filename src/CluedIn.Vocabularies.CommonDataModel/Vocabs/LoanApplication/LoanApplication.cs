using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LoanApplicationVocabulary : SimpleVocabulary
    {
        public LoanApplicationVocabulary()
        {
            VocabularyName = "Loan Application";
            KeyPrefix = "commonDataModel.loanapplication";
            KeySeparator = ".";
            Grouping = "/LoanApplication";

            AddGroup("LoanApplication Details", group =>
            {
                LoanApplicationId = group.Add(new VocabularyKey(nameof(LoanApplicationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statecode = group.Add(new VocabularyKey(nameof(Statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statuscode = group.Add(new VocabularyKey(nameof(Statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmortizationType = group.Add(new VocabularyKey(nameof(AmortizationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Applicationnumber = group.Add(new VocabularyKey(nameof(Applicationnumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalloonAmount = group.Add(new VocabularyKey(nameof(BalloonAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balloonamount_Base = group.Add(new VocabularyKey(nameof(Balloonamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalloonTermCount = group.Add(new VocabularyKey(nameof(BalloonTermCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Costofimprovements = group.Add(new VocabularyKey(nameof(Costofimprovements), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Costofimprovements_Base = group.Add(new VocabularyKey(nameof(Costofimprovements_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepositAmount = group.Add(new VocabularyKey(nameof(DepositAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Depositamount_Base = group.Add(new VocabularyKey(nameof(Depositamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Describeimprovements = group.Add(new VocabularyKey(nameof(Describeimprovements), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Discountpointstotalamount = group.Add(new VocabularyKey(nameof(Discountpointstotalamount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Discountpointstotalamount_Base = group.Add(new VocabularyKey(nameof(Discountpointstotalamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DownPayment = group.Add(new VocabularyKey(nameof(DownPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Downpayment_Base = group.Add(new VocabularyKey(nameof(Downpayment_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EscrowPaymentAmount = group.Add(new VocabularyKey(nameof(EscrowPaymentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Escrowpaymentamount_Base = group.Add(new VocabularyKey(nameof(Escrowpaymentamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancingType = group.Add(new VocabularyKey(nameof(FinancingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstMonthInterestAmount = group.Add(new VocabularyKey(nameof(FirstMonthInterestAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Firstmonthinterestamount_Base = group.Add(new VocabularyKey(nameof(Firstmonthinterestamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegrationKey = group.Add(new VocabularyKey(nameof(IntegrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestOnlyTermMonthCount = group.Add(new VocabularyKey(nameof(InterestOnlyTermMonthCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestRate = group.Add(new VocabularyKey(nameof(InterestRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestType = group.Add(new VocabularyKey(nameof(InterestType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBalloonPayment = group.Add(new VocabularyKey(nameof(IsBalloonPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInterestOnly = group.Add(new VocabularyKey(nameof(IsInterestOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsNegativeAmortization = group.Add(new VocabularyKey(nameof(IsNegativeAmortization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LendingLimit = group.Add(new VocabularyKey(nameof(LendingLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lendinglimit_Base = group.Add(new VocabularyKey(nameof(Lendinglimit_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoanApplicationClosingDate = group.Add(new VocabularyKey(nameof(LoanApplicationClosingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoanCategory = group.Add(new VocabularyKey(nameof(LoanCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoanorrefinancePurpose = group.Add(new VocabularyKey(nameof(LoanorrefinancePurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoanTerm = group.Add(new VocabularyKey(nameof(LoanTerm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoanToValue = group.Add(new VocabularyKey(nameof(LoanToValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoanType = group.Add(new VocabularyKey(nameof(LoanType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxLoanToValue = group.Add(new VocabularyKey(nameof(MaxLoanToValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NoteAmount = group.Add(new VocabularyKey(nameof(NoteAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Noteamount_Base = group.Add(new VocabularyKey(nameof(Noteamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrincipalAmount = group.Add(new VocabularyKey(nameof(PrincipalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Principalamount_Base = group.Add(new VocabularyKey(nameof(Principalamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefinanceType = group.Add(new VocabularyKey(nameof(RefinanceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceofDownPayment = group.Add(new VocabularyKey(nameof(SourceofDownPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VerificationStatus = group.Add(new VocabularyKey(nameof(VerificationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryMemberHelper = group.Add(new VocabularyKey(nameof(PrimaryMemberHelper), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LoanApplicationId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AmortizationType { get; private set; }
        public VocabularyKey Applicationnumber { get; private set; }
        public VocabularyKey BalloonAmount { get; private set; }
        public VocabularyKey Balloonamount_Base { get; private set; }
        public VocabularyKey BalloonTermCount { get; private set; }
        public VocabularyKey Costofimprovements { get; private set; }
        public VocabularyKey Costofimprovements_Base { get; private set; }
        public VocabularyKey DepositAmount { get; private set; }
        public VocabularyKey Depositamount_Base { get; private set; }
        public VocabularyKey Describeimprovements { get; private set; }
        public VocabularyKey Discountpointstotalamount { get; private set; }
        public VocabularyKey Discountpointstotalamount_Base { get; private set; }
        public VocabularyKey DownPayment { get; private set; }
        public VocabularyKey Downpayment_Base { get; private set; }
        public VocabularyKey EscrowPaymentAmount { get; private set; }
        public VocabularyKey Escrowpaymentamount_Base { get; private set; }
        public VocabularyKey FinancingType { get; private set; }
        public VocabularyKey FirstMonthInterestAmount { get; private set; }
        public VocabularyKey Firstmonthinterestamount_Base { get; private set; }
        public VocabularyKey IntegrationKey { get; private set; }
        public VocabularyKey InterestOnlyTermMonthCount { get; private set; }
        public VocabularyKey InterestRate { get; private set; }
        public VocabularyKey InterestType { get; private set; }
        public VocabularyKey IsBalloonPayment { get; private set; }
        public VocabularyKey IsInterestOnly { get; private set; }
        public VocabularyKey IsNegativeAmortization { get; private set; }
        public VocabularyKey LendingLimit { get; private set; }
        public VocabularyKey Lendinglimit_Base { get; private set; }
        public VocabularyKey LoanApplicationClosingDate { get; private set; }
        public VocabularyKey LoanCategory { get; private set; }
        public VocabularyKey LoanorrefinancePurpose { get; private set; }
        public VocabularyKey LoanTerm { get; private set; }
        public VocabularyKey LoanToValue { get; private set; }
        public VocabularyKey LoanType { get; private set; }
        public VocabularyKey MaxLoanToValue { get; private set; }
        public VocabularyKey NoteAmount { get; private set; }
        public VocabularyKey Noteamount_Base { get; private set; }
        public VocabularyKey PrincipalAmount { get; private set; }
        public VocabularyKey Principalamount_Base { get; private set; }
        public VocabularyKey RefinanceType { get; private set; }
        public VocabularyKey SourceofDownPayment { get; private set; }
        public VocabularyKey VerificationStatus { get; private set; }
        public VocabularyKey PrimaryMemberHelper { get; private set; }
    }
}