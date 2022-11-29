using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class PlannedGivingVocabulary : SimpleVocabulary
    {
        public PlannedGivingVocabulary()
        {
            VocabularyName = "Planned Giving";
            KeyPrefix = "commonDataModel.plannedgiving.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/PlannedGiving";

            AddGroup("PlannedGiving Details for NonProfitCore", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActualPercentOfEstateRecieved = group.Add(new VocabularyKey(nameof(ActualPercentOfEstateRecieved), "Actual % of Estate Received", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Affiliation = group.Add(new VocabularyKey(nameof(Affiliation), "Affiliation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AmountPerFrequency = group.Add(new VocabularyKey(nameof(AmountPerFrequency), "Amount Per Frequency", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountPerFrequencyBase = group.Add(new VocabularyKey(nameof(AmountPerFrequencyBase), "Amount Per Frequency (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AnnualMarketValue = group.Add(new VocabularyKey(nameof(AnnualMarketValue), "Annual Market Value", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AnnualMarketValueBase = group.Add(new VocabularyKey(nameof(AnnualMarketValueBase), "Annual Market Value (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AnnualMarketValueDate = group.Add(new VocabularyKey(nameof(AnnualMarketValueDate), "Annual Market Value Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AnnualPayment = group.Add(new VocabularyKey(nameof(AnnualPayment), "Annual Payment", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AnnualPaymentBase = group.Add(new VocabularyKey(nameof(AnnualPaymentBase), "Annual Payment (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AnticipatedAnnualPayment = group.Add(new VocabularyKey(nameof(AnticipatedAnnualPayment), "Anticipated Annual Payment", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AnticipatedAnnualPaymentBase = group.Add(new VocabularyKey(nameof(AnticipatedAnnualPaymentBase), "Anticipated Annual Payment (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AnticipatedDistributionDateOfTrust = group.Add(new VocabularyKey(nameof(AnticipatedDistributionDateOfTrust), "Anticipated Distribution Date of Trust", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AnticipatedPercentOfTrust = group.Add(new VocabularyKey(nameof(AnticipatedPercentOfTrust), "Anticipated % of Trust", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AppraisalDate = group.Add(new VocabularyKey(nameof(AppraisalDate), "Appraisal Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AppraisalValue = group.Add(new VocabularyKey(nameof(AppraisalValue), "Appraisal Value", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AppraisalValueBase = group.Add(new VocabularyKey(nameof(AppraisalValueBase), "Appraisal Value (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BequestType = group.Add(new VocabularyKey(nameof(BequestType), "Bequest Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CapitalGainIncome = group.Add(new VocabularyKey(nameof(CapitalGainIncome), "Capital Gain Income", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CapitalGainIncomeBase = group.Add(new VocabularyKey(nameof(CapitalGainIncomeBase), "Capital Gain Income (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CashSurrenderValue = group.Add(new VocabularyKey(nameof(CashSurrenderValue), "Cash Surrender Value", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CashSurrenderValueBase = group.Add(new VocabularyKey(nameof(CashSurrenderValueBase), "Cash Surrender Value (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CharitableDeduction = group.Add(new VocabularyKey(nameof(CharitableDeduction), "Charitable Deduction", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CharitableDeductionBase = group.Add(new VocabularyKey(nameof(CharitableDeductionBase), "Charitable Deduction (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ContractDate = group.Add(new VocabularyKey(nameof(ContractDate), "Contract Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostBasis = group.Add(new VocabularyKey(nameof(CostBasis), "Cost Basis", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CostBasisBase = group.Add(new VocabularyKey(nameof(CostBasisBase), "Cost Basis (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DateClaimFormsRecieved = group.Add(new VocabularyKey(nameof(DateClaimFormsRecieved), "Date Claim Forms Received", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DateClaimFormsSubmitted = group.Add(new VocabularyKey(nameof(DateClaimFormsSubmitted), "Date Claim Forms Submitted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DateEstateClosed = group.Add(new VocabularyKey(nameof(DateEstateClosed), "Date Estate Closed", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DateManagementAgreementSigned = group.Add(new VocabularyKey(nameof(DateManagementAgreementSigned), "Date Management Agreement Signed", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DateStationNotifiedOfDeath = group.Add(new VocabularyKey(nameof(DateStationNotifiedOfDeath), "Date Organization Notified of Death", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DateStationNotifiedOfIntention = group.Add(new VocabularyKey(nameof(DateStationNotifiedOfIntention), "Date Organization Notified of Intention", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DateStationNotifiedToMakeClaim = group.Add(new VocabularyKey(nameof(DateStationNotifiedToMakeClaim), "Date Organization Notified to Make Claim", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DateWillExecuted = group.Add(new VocabularyKey(nameof(DateWillExecuted), "Date Will Executed", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Deceased = group.Add(new VocabularyKey(nameof(Deceased), "Deceased?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DeceasedDay = group.Add(new VocabularyKey(nameof(DeceasedDay), "Deceased Day", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeceasedMonth = group.Add(new VocabularyKey(nameof(DeceasedMonth), "Deceased Month", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeceasedYear = group.Add(new VocabularyKey(nameof(DeceasedYear), "Deceased Year", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeferredToDate = group.Add(new VocabularyKey(nameof(DeferredToDate), "Deferred To Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DesignatedOrganizationPercent = group.Add(new VocabularyKey(nameof(DesignatedOrganizationPercent), "Designated Organization %", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DesignatedPrincipleAmount = group.Add(new VocabularyKey(nameof(DesignatedPrincipleAmount), "Designated Principle Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DesignatedPrincipleAmountBase = group.Add(new VocabularyKey(nameof(DesignatedPrincipleAmountBase), "Designated Principle Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Designation = group.Add(new VocabularyKey(nameof(Designation), "Designation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DiscountRate = group.Add(new VocabularyKey(nameof(DiscountRate), "Discount Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DiscountRateMonth = group.Add(new VocabularyKey(nameof(DiscountRateMonth), "Discount Rate Month", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DiscountRateYear = group.Add(new VocabularyKey(nameof(DiscountRateYear), "Discount Rate Year", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndowmentType = group.Add(new VocabularyKey(nameof(EndowmentType), "Endowment Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimatedGivingAmount = group.Add(new VocabularyKey(nameof(EstimatedGivingAmount), "Estimated Giving Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstimatedGivingAmountBase = group.Add(new VocabularyKey(nameof(EstimatedGivingAmountBase), "Estimated Giving Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstimatedTrustProbateDate = group.Add(new VocabularyKey(nameof(EstimatedTrustProbateDate), "Estimated Trust/Probate Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedFinalDistributionDate = group.Add(new VocabularyKey(nameof(ExpectedFinalDistributionDate), "Expected Final Distribution Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedFirstDistributionDate = group.Add(new VocabularyKey(nameof(ExpectedFirstDistributionDate), "Expected First Distribution Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalID = group.Add(new VocabularyKey(nameof(ExternalID), "External ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FaceValue = group.Add(new VocabularyKey(nameof(FaceValue), "Face Value", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    FaceValueBase = group.Add(new VocabularyKey(nameof(FaceValueBase), "Face Value (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    GivingAmount = group.Add(new VocabularyKey(nameof(GivingAmount), "Giving Amount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    GivingReceivedDate = group.Add(new VocabularyKey(nameof(GivingReceivedDate), "Giving Received Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GivingSubtype = group.Add(new VocabularyKey(nameof(GivingSubtype), "Giving Subtype", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InsuranceAnnualPremium = group.Add(new VocabularyKey(nameof(InsuranceAnnualPremium), "Insurance Annual Premium", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InsuranceAnnualPremiumBase = group.Add(new VocabularyKey(nameof(InsuranceAnnualPremiumBase), "Insurance Annual Premium (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InsuranceCompany = group.Add(new VocabularyKey(nameof(InsuranceCompany), "Insurance Company", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InsuranceDeathBenefitAmount = group.Add(new VocabularyKey(nameof(InsuranceDeathBenefitAmount), "Insurance Death Benefit Amount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    InsurancePolicyCode = group.Add(new VocabularyKey(nameof(InsurancePolicyCode), "Insurance Policy Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InsurancePolicyName = group.Add(new VocabularyKey(nameof(InsurancePolicyName), "Insurance Policy Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InsurancePremiumDueDate = group.Add(new VocabularyKey(nameof(InsurancePremiumDueDate), "Insurance Premium Due Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InsurancePremiumPaymentAddress = group.Add(new VocabularyKey(nameof(InsurancePremiumPaymentAddress), "Insurance Premium Payment Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsRevocable = group.Add(new VocabularyKey(nameof(IsRevocable), "Revocable", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LeadSource = group.Add(new VocabularyKey(nameof(LeadSource), "Lead Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrdinaryIncome = group.Add(new VocabularyKey(nameof(OrdinaryIncome), "Ordinary Income", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OrdinaryIncomeBase = group.Add(new VocabularyKey(nameof(OrdinaryIncomeBase), "Ordinary Income (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PaymentFrequency = group.Add(new VocabularyKey(nameof(PaymentFrequency), "Payment Frequency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PayoutRate = group.Add(new VocabularyKey(nameof(PayoutRate), "Payout Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PlannedGivingId = group.Add(new VocabularyKey(nameof(PlannedGivingId), "Planned Giving", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PresentValue = group.Add(new VocabularyKey(nameof(PresentValue), "Present Value", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PresentValueBase = group.Add(new VocabularyKey(nameof(PresentValueBase), "Present Value (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RecordType = group.Add(new VocabularyKey(nameof(RecordType), "Record Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RemainderAmount = group.Add(new VocabularyKey(nameof(RemainderAmount), "Remainder Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RemainderAmountBase = group.Add(new VocabularyKey(nameof(RemainderAmountBase), "Remainder Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RollupGiving = group.Add(new VocabularyKey(nameof(RollupGiving), "Rollup Giving", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SalvageValueOfBuildings = group.Add(new VocabularyKey(nameof(SalvageValueOfBuildings), "Salvage Value of Buildings", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    SalvageValueOfBuildingsBase = group.Add(new VocabularyKey(nameof(SalvageValueOfBuildingsBase), "Salvage Value of Buildings (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    SeverDate = group.Add(new VocabularyKey(nameof(SeverDate), "Sever Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Stage = group.Add(new VocabularyKey(nameof(Stage), "Stage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TaxFreeIncome = group.Add(new VocabularyKey(nameof(TaxFreeIncome), "Tax Free Income", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TaxFreeIncomeBase = group.Add(new VocabularyKey(nameof(TaxFreeIncomeBase), "Tax Free Income (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TermEndDate = group.Add(new VocabularyKey(nameof(TermEndDate), "Term End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TermType = group.Add(new VocabularyKey(nameof(TermType), "Term Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TermYears = group.Add(new VocabularyKey(nameof(TermYears), "Term Years", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TotalEstateValue = group.Add(new VocabularyKey(nameof(TotalEstateValue), "Total Estate Value", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalEstateValueBase = group.Add(new VocabularyKey(nameof(TotalEstateValueBase), "Total Estate Value (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TrustMarketValue = group.Add(new VocabularyKey(nameof(TrustMarketValue), "Trust Market Value", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TrustMarketValueBase = group.Add(new VocabularyKey(nameof(TrustMarketValueBase), "Trust Market Value (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TrustProbateNoticeDate = group.Add(new VocabularyKey(nameof(TrustProbateNoticeDate), "Trust/Probate Notice Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TrustValueDate = group.Add(new VocabularyKey(nameof(TrustValueDate), "Trust Value Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TypeOfManagement = group.Add(new VocabularyKey(nameof(TypeOfManagement), "Type of Management", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ActualPercentOfEstateRecieved { get; private set; }
        public VocabularyKey Affiliation { get; private set; }
        public VocabularyKey AmountPerFrequency { get; private set; }
        public VocabularyKey AmountPerFrequencyBase { get; private set; }
        public VocabularyKey AnnualMarketValue { get; private set; }
        public VocabularyKey AnnualMarketValueBase { get; private set; }
        public VocabularyKey AnnualMarketValueDate { get; private set; }
        public VocabularyKey AnnualPayment { get; private set; }
        public VocabularyKey AnnualPaymentBase { get; private set; }
        public VocabularyKey AnticipatedAnnualPayment { get; private set; }
        public VocabularyKey AnticipatedAnnualPaymentBase { get; private set; }
        public VocabularyKey AnticipatedDistributionDateOfTrust { get; private set; }
        public VocabularyKey AnticipatedPercentOfTrust { get; private set; }
        public VocabularyKey AppraisalDate { get; private set; }
        public VocabularyKey AppraisalValue { get; private set; }
        public VocabularyKey AppraisalValueBase { get; private set; }
        public VocabularyKey BequestType { get; private set; }
        public VocabularyKey CapitalGainIncome { get; private set; }
        public VocabularyKey CapitalGainIncomeBase { get; private set; }
        public VocabularyKey CashSurrenderValue { get; private set; }
        public VocabularyKey CashSurrenderValueBase { get; private set; }
        public VocabularyKey CharitableDeduction { get; private set; }
        public VocabularyKey CharitableDeductionBase { get; private set; }
        public VocabularyKey ContractDate { get; private set; }
        public VocabularyKey CostBasis { get; private set; }
        public VocabularyKey CostBasisBase { get; private set; }
        public VocabularyKey DateClaimFormsRecieved { get; private set; }
        public VocabularyKey DateClaimFormsSubmitted { get; private set; }
        public VocabularyKey DateEstateClosed { get; private set; }
        public VocabularyKey DateManagementAgreementSigned { get; private set; }
        public VocabularyKey DateStationNotifiedOfDeath { get; private set; }
        public VocabularyKey DateStationNotifiedOfIntention { get; private set; }
        public VocabularyKey DateStationNotifiedToMakeClaim { get; private set; }
        public VocabularyKey DateWillExecuted { get; private set; }
        public VocabularyKey Deceased { get; private set; }
        public VocabularyKey DeceasedDay { get; private set; }
        public VocabularyKey DeceasedMonth { get; private set; }
        public VocabularyKey DeceasedYear { get; private set; }
        public VocabularyKey DeferredToDate { get; private set; }
        public VocabularyKey DesignatedOrganizationPercent { get; private set; }
        public VocabularyKey DesignatedPrincipleAmount { get; private set; }
        public VocabularyKey DesignatedPrincipleAmountBase { get; private set; }
        public VocabularyKey Designation { get; private set; }
        public VocabularyKey DiscountRate { get; private set; }
        public VocabularyKey DiscountRateMonth { get; private set; }
        public VocabularyKey DiscountRateYear { get; private set; }
        public VocabularyKey EndowmentType { get; private set; }
        public VocabularyKey EstimatedGivingAmount { get; private set; }
        public VocabularyKey EstimatedGivingAmountBase { get; private set; }
        public VocabularyKey EstimatedTrustProbateDate { get; private set; }
        public VocabularyKey ExpectedFinalDistributionDate { get; private set; }
        public VocabularyKey ExpectedFirstDistributionDate { get; private set; }
        public VocabularyKey ExternalID { get; private set; }
        public VocabularyKey FaceValue { get; private set; }
        public VocabularyKey FaceValueBase { get; private set; }
        public VocabularyKey GivingAmount { get; private set; }
        public VocabularyKey GivingReceivedDate { get; private set; }
        public VocabularyKey GivingSubtype { get; private set; }
        public VocabularyKey InsuranceAnnualPremium { get; private set; }
        public VocabularyKey InsuranceAnnualPremiumBase { get; private set; }
        public VocabularyKey InsuranceCompany { get; private set; }
        public VocabularyKey InsuranceDeathBenefitAmount { get; private set; }
        public VocabularyKey InsurancePolicyCode { get; private set; }
        public VocabularyKey InsurancePolicyName { get; private set; }
        public VocabularyKey InsurancePremiumDueDate { get; private set; }
        public VocabularyKey InsurancePremiumPaymentAddress { get; private set; }
        public VocabularyKey IsRevocable { get; private set; }
        public VocabularyKey LeadSource { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OrdinaryIncome { get; private set; }
        public VocabularyKey OrdinaryIncomeBase { get; private set; }
        public VocabularyKey PaymentFrequency { get; private set; }
        public VocabularyKey PayoutRate { get; private set; }
        public VocabularyKey PlannedGivingId { get; private set; }
        public VocabularyKey PresentValue { get; private set; }
        public VocabularyKey PresentValueBase { get; private set; }
        public VocabularyKey RecordType { get; private set; }
        public VocabularyKey RemainderAmount { get; private set; }
        public VocabularyKey RemainderAmountBase { get; private set; }
        public VocabularyKey RollupGiving { get; private set; }
        public VocabularyKey SalvageValueOfBuildings { get; private set; }
        public VocabularyKey SalvageValueOfBuildingsBase { get; private set; }
        public VocabularyKey SeverDate { get; private set; }
        public VocabularyKey Stage { get; private set; }
        public VocabularyKey TaxFreeIncome { get; private set; }
        public VocabularyKey TaxFreeIncomeBase { get; private set; }
        public VocabularyKey TermEndDate { get; private set; }
        public VocabularyKey TermType { get; private set; }
        public VocabularyKey TermYears { get; private set; }
        public VocabularyKey TotalEstateValue { get; private set; }
        public VocabularyKey TotalEstateValueBase { get; private set; }
        public VocabularyKey TrustMarketValue { get; private set; }
        public VocabularyKey TrustMarketValueBase { get; private set; }
        public VocabularyKey TrustProbateNoticeDate { get; private set; }
        public VocabularyKey TrustValueDate { get; private set; }
        public VocabularyKey TypeOfManagement { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}