using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Banking
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account.banking";
            KeySeparator = ".";
            Grouping = "/Account";

            AddGroup("Account Details for Banking", group =>
            {
			    AnnualReviewDate = group.Add(new VocabularyKey(nameof(AnnualReviewDate), "Annual Review Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AvailableLimit = group.Add(new VocabularyKey(nameof(AvailableLimit), "Available Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AvailableLimitBase = group.Add(new VocabularyKey(nameof(AvailableLimitBase), "Available Limit (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BanksYTDRevenue = group.Add(new VocabularyKey(nameof(BanksYTDRevenue), "Bank’s YTD Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BanksYTDRevenueBase = group.Add(new VocabularyKey(nameof(BanksYTDRevenueBase), "Bank’s YTD Revenue (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CompanysProfitInTheLastYear = group.Add(new VocabularyKey(nameof(CompanysProfitInTheLastYear), "Company’s Profit in the Last Year", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CompanysProfitInTheLastYearBase = group.Add(new VocabularyKey(nameof(CompanysProfitInTheLastYearBase), "Company’s Profit in the Last Year (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CompanyTurnoverInTheLastYear = group.Add(new VocabularyKey(nameof(CompanyTurnoverInTheLastYear), "Company Turnover in the last Year", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CompanyTurnoverInTheLastYearBase = group.Add(new VocabularyKey(nameof(CompanyTurnoverInTheLastYearBase), "Company Turnover in the last Year (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DaysPastDue = group.Add(new VocabularyKey(nameof(DaysPastDue), "Days Past Due", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ImplementedLimit = group.Add(new VocabularyKey(nameof(ImplementedLimit), "Implemented Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ImplementedLimitBase = group.Add(new VocabularyKey(nameof(ImplementedLimitBase), "Implemented Limit (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    LimitReviewDate = group.Add(new VocabularyKey(nameof(LimitReviewDate), "Limit Review Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PastDueSince = group.Add(new VocabularyKey(nameof(PastDueSince), "Past Due Since", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProfitTier = group.Add(new VocabularyKey(nameof(ProfitTier), "Profit Tier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReturnOnCapital = group.Add(new VocabularyKey(nameof(ReturnOnCapital), "Return on Capital", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RiskRating = group.Add(new VocabularyKey(nameof(RiskRating), "Risk Rating", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalDeposits = group.Add(new VocabularyKey(nameof(TotalDeposits), "Total Deposits", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalDepositsBase = group.Add(new VocabularyKey(nameof(TotalDepositsBase), "Total Deposits (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalLimit = group.Add(new VocabularyKey(nameof(TotalLimit), "Total Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalLimitBase = group.Add(new VocabularyKey(nameof(TotalLimitBase), "Total Limit (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalLoans = group.Add(new VocabularyKey(nameof(TotalLoans), "Total Loans", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalLoansBase = group.Add(new VocabularyKey(nameof(TotalLoansBase), "Total Loans (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalPastDue = group.Add(new VocabularyKey(nameof(TotalPastDue), "Total Past Due", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalPastDueBase = group.Add(new VocabularyKey(nameof(TotalPastDueBase), "Total Past Due (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    UtilizedLimit = group.Add(new VocabularyKey(nameof(UtilizedLimit), "Utilized Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    UtilizedLimitBase = group.Add(new VocabularyKey(nameof(UtilizedLimitBase), "Utilized Limit (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AnnualReviewDate { get; private set; }
        public VocabularyKey AvailableLimit { get; private set; }
        public VocabularyKey AvailableLimitBase { get; private set; }
        public VocabularyKey BanksYTDRevenue { get; private set; }
        public VocabularyKey BanksYTDRevenueBase { get; private set; }
        public VocabularyKey CompanysProfitInTheLastYear { get; private set; }
        public VocabularyKey CompanysProfitInTheLastYearBase { get; private set; }
        public VocabularyKey CompanyTurnoverInTheLastYear { get; private set; }
        public VocabularyKey CompanyTurnoverInTheLastYearBase { get; private set; }
        public VocabularyKey DaysPastDue { get; private set; }
        public VocabularyKey ImplementedLimit { get; private set; }
        public VocabularyKey ImplementedLimitBase { get; private set; }
        public VocabularyKey LimitReviewDate { get; private set; }
        public VocabularyKey PastDueSince { get; private set; }
        public VocabularyKey ProfitTier { get; private set; }
        public VocabularyKey ReturnOnCapital { get; private set; }
        public VocabularyKey RiskRating { get; private set; }
        public VocabularyKey TotalDeposits { get; private set; }
        public VocabularyKey TotalDepositsBase { get; private set; }
        public VocabularyKey TotalLimit { get; private set; }
        public VocabularyKey TotalLimitBase { get; private set; }
        public VocabularyKey TotalLoans { get; private set; }
        public VocabularyKey TotalLoansBase { get; private set; }
        public VocabularyKey TotalPastDue { get; private set; }
        public VocabularyKey TotalPastDueBase { get; private set; }
        public VocabularyKey UtilizedLimit { get; private set; }
        public VocabularyKey UtilizedLimitBase { get; private set; }
    }
}