using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Banking
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact.banking";
            KeySeparator = ".";
            Grouping = "/Contact";

            AddGroup("Contact Details for Banking", group =>
            {
			    BirthDate = group.Add(new VocabularyKey(nameof(BirthDate), "Date of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerTypeCode = group.Add(new VocabularyKey(nameof(CustomerTypeCode), "Relationship Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillPay = group.Add(new VocabularyKey(nameof(BillPay), "Bill Pay", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ChargeStartDate = group.Add(new VocabularyKey(nameof(ChargeStartDate), "Charge Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ChurnScore = group.Add(new VocabularyKey(nameof(ChurnScore), "Churn Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CreditScore = group.Add(new VocabularyKey(nameof(CreditScore), "Credit Score", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DebtBurdenRatio = group.Add(new VocabularyKey(nameof(DebtBurdenRatio), "Debt Burden Ratio", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DelinquencyScore = group.Add(new VocabularyKey(nameof(DelinquencyScore), "Delinquency Score", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DelinquentAmount = group.Add(new VocabularyKey(nameof(DelinquentAmount), "Delinquent Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DelinquentAmountBase = group.Add(new VocabularyKey(nameof(DelinquentAmountBase), "Delinquent Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DirectDeposit = group.Add(new VocabularyKey(nameof(DirectDeposit), "Direct Deposit", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EmploymentStatus = group.Add(new VocabularyKey(nameof(EmploymentStatus), "Employment Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IDExpiryDate = group.Add(new VocabularyKey(nameof(IDExpiryDate), "ID Expiry Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IDType = group.Add(new VocabularyKey(nameof(IDType), "ID Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsMinor = group.Add(new VocabularyKey(nameof(IsMinor), "Is Minor", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MonthlyIncome = group.Add(new VocabularyKey(nameof(MonthlyIncome), "Monthly Income", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    MonthlyIncomeBase = group.Add(new VocabularyKey(nameof(MonthlyIncomeBase), "Monthly Income (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    MonthlyLiabilities = group.Add(new VocabularyKey(nameof(MonthlyLiabilities), "Monthly Liabilities", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    MonthlyLiabilitiesBase = group.Add(new VocabularyKey(nameof(MonthlyLiabilitiesBase), "Monthly Liabilities (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PlaceOfBirth = group.Add(new VocabularyKey(nameof(PlaceOfBirth), "Place of birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProfitTier = group.Add(new VocabularyKey(nameof(ProfitTier), "Profit Tier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResidencyStatus = group.Add(new VocabularyKey(nameof(ResidencyStatus), "Residency Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResidentInCountrySince = group.Add(new VocabularyKey(nameof(ResidentInCountrySince), "Resident in Country Since", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalDeposits = group.Add(new VocabularyKey(nameof(TotalDeposits), "Total Deposits", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalDepositsBase = group.Add(new VocabularyKey(nameof(TotalDepositsBase), "Total Deposits (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalLoans = group.Add(new VocabularyKey(nameof(TotalLoans), "Total Loans", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalLoansBase = group.Add(new VocabularyKey(nameof(TotalLoansBase), "Total Loans (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    VisaExpiry = group.Add(new VocabularyKey(nameof(VisaExpiry), "Visa Expiry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WaiveCharges = group.Add(new VocabularyKey(nameof(WaiveCharges), "Waive Charges", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BirthDate { get; private set; }
        public VocabularyKey CustomerTypeCode { get; private set; }
        public VocabularyKey BillPay { get; private set; }
        public VocabularyKey ChargeStartDate { get; private set; }
        public VocabularyKey ChurnScore { get; private set; }
        public VocabularyKey CreditScore { get; private set; }
        public VocabularyKey DebtBurdenRatio { get; private set; }
        public VocabularyKey DelinquencyScore { get; private set; }
        public VocabularyKey DelinquentAmount { get; private set; }
        public VocabularyKey DelinquentAmountBase { get; private set; }
        public VocabularyKey DirectDeposit { get; private set; }
        public VocabularyKey EmploymentStatus { get; private set; }
        public VocabularyKey IDExpiryDate { get; private set; }
        public VocabularyKey IDType { get; private set; }
        public VocabularyKey IsMinor { get; private set; }
        public VocabularyKey MonthlyIncome { get; private set; }
        public VocabularyKey MonthlyIncomeBase { get; private set; }
        public VocabularyKey MonthlyLiabilities { get; private set; }
        public VocabularyKey MonthlyLiabilitiesBase { get; private set; }
        public VocabularyKey PlaceOfBirth { get; private set; }
        public VocabularyKey ProfitTier { get; private set; }
        public VocabularyKey ResidencyStatus { get; private set; }
        public VocabularyKey ResidentInCountrySince { get; private set; }
        public VocabularyKey TotalDeposits { get; private set; }
        public VocabularyKey TotalDepositsBase { get; private set; }
        public VocabularyKey TotalLoans { get; private set; }
        public VocabularyKey TotalLoansBase { get; private set; }
        public VocabularyKey VisaExpiry { get; private set; }
        public VocabularyKey WaiveCharges { get; private set; }
    }
}