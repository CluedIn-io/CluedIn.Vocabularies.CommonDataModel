using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Account;

            AddGroup("Account Details for ApplicationCommon", group =>
            {
                AccountId = group.Add(new VocabularyKey(nameof(AccountId), "Account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCategoryCode = group.Add(new VocabularyKey(nameof(AccountCategoryCode), "Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerSizeCode = group.Add(new VocabularyKey(nameof(CustomerSizeCode), "Customer Size", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreferredContactMethodCode = group.Add(new VocabularyKey(nameof(PreferredContactMethodCode), "Preferred Method of Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerTypeCode = group.Add(new VocabularyKey(nameof(CustomerTypeCode), "Relationship Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRatingCode = group.Add(new VocabularyKey(nameof(AccountRatingCode), "Account Rating", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndustryCode = group.Add(new VocabularyKey(nameof(IndustryCode), "Industry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TerritoryCode = group.Add(new VocabularyKey(nameof(TerritoryCode), "Territory Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountClassificationCode = group.Add(new VocabularyKey(nameof(AccountClassificationCode), "Classification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessTypeCode = group.Add(new VocabularyKey(nameof(BusinessTypeCode), "Business Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsCode = group.Add(new VocabularyKey(nameof(PaymentTermsCode), "Payment Terms", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingMethodCode = group.Add(new VocabularyKey(nameof(ShippingMethodCode), "Shipping Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParticipatesInWorkflow = group.Add(new VocabularyKey(nameof(ParticipatesInWorkflow), "Participates in Workflow", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Account Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNumber = group.Add(new VocabularyKey(nameof(AccountNumber), "Account Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Revenue = group.Add(new VocabularyKey(nameof(Revenue), "Annual Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                NumberOfEmployees = group.Add(new VocabularyKey(nameof(NumberOfEmployees), "Number of Employees", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SIC = group.Add(new VocabularyKey(nameof(SIC), "SIC Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnershipCode = group.Add(new VocabularyKey(nameof(OwnershipCode), "Ownership", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketCap = group.Add(new VocabularyKey(nameof(MarketCap), "Market Capitalization", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                SharesOutstanding = group.Add(new VocabularyKey(nameof(SharesOutstanding), "Shares Outstanding", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                TickerSymbol = group.Add(new VocabularyKey(nameof(TickerSymbol), "Ticker Symbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StockExchange = group.Add(new VocabularyKey(nameof(StockExchange), "Stock Exchange", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebSiteUrl = group.Add(new VocabularyKey(nameof(WebSiteUrl), "Website", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
                FtpSiteUrl = group.Add(new VocabularyKey(nameof(FtpSiteUrl), "FTP Site", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
                EMailAddress1 = group.Add(new VocabularyKey(nameof(EMailAddress1), "Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible));
                EMailAddress2 = group.Add(new VocabularyKey(nameof(EMailAddress2), "Email Address 2", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible));
                EMailAddress3 = group.Add(new VocabularyKey(nameof(EMailAddress3), "Email Address 3", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible));
                DoNotPhone = group.Add(new VocabularyKey(nameof(DoNotPhone), "Do not allow Phone Calls", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DoNotFax = group.Add(new VocabularyKey(nameof(DoNotFax), "Do not allow Faxes", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Telephone1 = group.Add(new VocabularyKey(nameof(Telephone1), "Main Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible));
                DoNotEMail = group.Add(new VocabularyKey(nameof(DoNotEMail), "Do not allow Emails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Telephone2 = group.Add(new VocabularyKey(nameof(Telephone2), "Other Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible));
                Fax = group.Add(new VocabularyKey(nameof(Fax), "Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telephone3 = group.Add(new VocabularyKey(nameof(Telephone3), "Telephone 3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible));
                DoNotPostalMail = group.Add(new VocabularyKey(nameof(DoNotPostalMail), "Do not allow Mails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DoNotBulkEMail = group.Add(new VocabularyKey(nameof(DoNotBulkEMail), "Do not allow Bulk Emails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DoNotBulkPostalMail = group.Add(new VocabularyKey(nameof(DoNotBulkPostalMail), "Do not allow Bulk Mails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                CreditLimit = group.Add(new VocabularyKey(nameof(CreditLimit), "Credit Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                CreditOnHold = group.Add(new VocabularyKey(nameof(CreditOnHold), "Credit Hold", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Aging30 = group.Add(new VocabularyKey(nameof(Aging30), "Aging 30", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Aging60 = group.Add(new VocabularyKey(nameof(Aging60), "Aging 60", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Aging90 = group.Add(new VocabularyKey(nameof(Aging90), "Aging 90", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                PreferredAppointmentDayCode = group.Add(new VocabularyKey(nameof(PreferredAppointmentDayCode), "Preferred Day", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreferredAppointmentTimeCode = group.Add(new VocabularyKey(nameof(PreferredAppointmentTimeCode), "Preferred Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Merged = group.Add(new VocabularyKey(nameof(Merged), "Merged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DoNotSendMM = group.Add(new VocabularyKey(nameof(DoNotSendMM), "Send Marketing Materials", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                LastUsedInCampaign = group.Add(new VocabularyKey(nameof(LastUsedInCampaign), "Last Date Included in Campaign", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                CreditLimitBase = group.Add(new VocabularyKey(nameof(CreditLimitBase), "Credit Limit (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Aging30Base = group.Add(new VocabularyKey(nameof(Aging30Base), "Aging 30 (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RevenueBase = group.Add(new VocabularyKey(nameof(RevenueBase), "Annual Revenue (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Aging90Base = group.Add(new VocabularyKey(nameof(Aging90Base), "Aging 90 (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketCapBase = group.Add(new VocabularyKey(nameof(MarketCapBase), "Market Capitalization (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Aging60Base = group.Add(new VocabularyKey(nameof(Aging60Base), "Aging 60 (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YomiName = group.Add(new VocabularyKey(nameof(YomiName), "Yomi Account Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StageId = group.Add(new VocabularyKey(nameof(StageId), "Process Stage", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), "Entity Image Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                TimeSpentByMeOnEmailAndMeetings = group.Add(new VocabularyKey(nameof(TimeSpentByMeOnEmailAndMeetings), "Time Spent by me", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible));
                CreatedByExternalParty = group.Add(new VocabularyKey(nameof(CreatedByExternalParty), "Created By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedByExternalParty = group.Add(new VocabularyKey(nameof(ModifiedByExternalParty), "Modified By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimarySatoriId = group.Add(new VocabularyKey(nameof(PrimarySatoriId), "Primary Satori ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryTwitterId = group.Add(new VocabularyKey(nameof(PrimaryTwitterId), "Primary Twitter ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FollowEmail = group.Add(new VocabularyKey(nameof(FollowEmail), "Follow Email Activity", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                MarketingOnly = group.Add(new VocabularyKey(nameof(MarketingOnly), "Marketing Only", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Account Details for FoundationCommon", group =>
            {

            });
            AddGroup("Account Details for CrmCommon", group =>
            {
                OpenDeals = group.Add(new VocabularyKey(nameof(OpenDeals), "Open Deals", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OpenDealsDate = group.Add(new VocabularyKey(nameof(OpenDealsDate), "Open Deals (Last Updated On)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpenDealsState = group.Add(new VocabularyKey(nameof(OpenDealsState), "Open Deals (State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OpenRevenue = group.Add(new VocabularyKey(nameof(OpenRevenue), "Open Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                OpenRevenueBase = group.Add(new VocabularyKey(nameof(OpenRevenueBase), "Open Revenue (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpenRevenueDate = group.Add(new VocabularyKey(nameof(OpenRevenueDate), "Open Revenue (Last Updated On)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpenRevenueState = group.Add(new VocabularyKey(nameof(OpenRevenueState), "Open Revenue (State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Account Details for HigherEducation", group =>
            {
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), "Account Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalIdentifier = group.Add(new VocabularyKey(nameof(ExternalIdentifier), "External Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalSourceSystem = group.Add(new VocabularyKey(nameof(ExternalSourceSystem), "External Source System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberofContacts = group.Add(new VocabularyKey(nameof(NumberofContacts), "# of Contacts", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
            });
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
            AddGroup("Account Details for ElectronicMedicalRecords", group =>
            {
                Address1PeriodEndDate = group.Add(new VocabularyKey(nameof(Address1PeriodEndDate), "Primary - Primary End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Address1PeriodStartDate = group.Add(new VocabularyKey(nameof(Address1PeriodStartDate), "Primary - Address Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Address2PeriodEndDate = group.Add(new VocabularyKey(nameof(Address2PeriodEndDate), "Secondary  - Address Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Address2PeriodStartDate = group.Add(new VocabularyKey(nameof(Address2PeriodStartDate), "Secondary  - Address Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Alias = group.Add(new VocabularyKey(nameof(Alias), "DBA", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telecom1EndDate = group.Add(new VocabularyKey(nameof(Telecom1EndDate), "Primary Phone End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telecom1Rank = group.Add(new VocabularyKey(nameof(Telecom1Rank), "Rank Of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Telecom1StartDate = group.Add(new VocabularyKey(nameof(Telecom1StartDate), "Primary Phone Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telecom1System = group.Add(new VocabularyKey(nameof(Telecom1System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telecom1Use = group.Add(new VocabularyKey(nameof(Telecom1Use), "Use Of Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telecom2EndDate = group.Add(new VocabularyKey(nameof(Telecom2EndDate), "Secondary Phone End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telecom2Rank = group.Add(new VocabularyKey(nameof(Telecom2Rank), "Rank Of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Telecom2StartDate = group.Add(new VocabularyKey(nameof(Telecom2StartDate), "Secondary Phone Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telecom2System = group.Add(new VocabularyKey(nameof(Telecom2System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telecom2Use = group.Add(new VocabularyKey(nameof(Telecom2Use), "Use Of Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telecom3EndDate = group.Add(new VocabularyKey(nameof(Telecom3EndDate), "Primary Email End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telecom3Rank = group.Add(new VocabularyKey(nameof(Telecom3Rank), "Rank Of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Telecom3StartDate = group.Add(new VocabularyKey(nameof(Telecom3StartDate), "Primary Email Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telecom3System = group.Add(new VocabularyKey(nameof(Telecom3System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telecom3Use = group.Add(new VocabularyKey(nameof(Telecom3Use), "Use Of Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Account Details for NonProfitCore", group =>
            {
                AcquisitionDate = group.Add(new VocabularyKey(nameof(AcquisitionDate), "Acquisition Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcquisitionSource = group.Add(new VocabularyKey(nameof(AcquisitionSource), "Acquisition Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryConstituentType = group.Add(new VocabularyKey(nameof(PrimaryConstituentType), "Primary Constituent Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Account Details for NonProfitIati", group =>
            {
                IatiOrganizationIdentifier = group.Add(new VocabularyKey(nameof(IatiOrganizationIdentifier), "IATI Organization Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondaryReporter = group.Add(new VocabularyKey(nameof(SecondaryReporter), "Secondary Reporter", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Account Details for NonProfitVolunteers", group =>
            {

            });
            AddGroup("Account Details for ProjectServiceAutomation", group =>
            {
                DefaultPriceLevelId = group.Add(new VocabularyKey(nameof(DefaultPriceLevelId), "Product Price List", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalID = group.Add(new VocabularyKey(nameof(ExternalID), "External ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Account Details for EventManagement", group =>
            {
                HotelGroup = group.Add(new VocabularyKey(nameof(HotelGroup), "Hotel Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RentalCarProvider = group.Add(new VocabularyKey(nameof(RentalCarProvider), "Rental Car Provider", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Account Details for Portals", group =>
            {
                AdxCreatedByIPAddress = group.Add(new VocabularyKey(nameof(AdxCreatedByIPAddress), "Created By (IP Address)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdxCreatedByUsername = group.Add(new VocabularyKey(nameof(AdxCreatedByUsername), "Created By (User Name)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdxModifiedByIPAddress = group.Add(new VocabularyKey(nameof(AdxModifiedByIPAddress), "Modified By (IP Address)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdxModifiedByUsername = group.Add(new VocabularyKey(nameof(AdxModifiedByUsername), "Modified By (User Name)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PreferredSystemUserId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="MasterId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="DefaultCurrency"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CurrencyKey"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TerritoryId"/> to Vocab 'Territory.cdm.json/Territory' with Property 'TerritoryId'
            ///Property <see cref="TerritoryId"/> to Vocab 'Territory.cdm.json/Territory' with Property 'TerritoryId'
            ///Property <see cref="TerritoryId"/> to Vocab 'Territory.cdm.json/Territory' with Property 'TerritoryId'
            ///Property <see cref="TerritoryId"/> to Vocab 'Territory.cdm.json/Territory' with Property 'TerritoryId'
            ///Property <see cref="TerritoryId"/> to Vocab 'Territory.cdm.json/Territory' with Property 'TerritoryId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="PreferredSystemUserId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="PreferredSystemUserId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="PreferredSystemUserId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="PreferredSystemUserId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="PreferredSystemUserId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="PreferredSystemUserId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="AccountId"/> from Vocab 'Account.cdm.json/Account' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'Account.cdm.json/Account' with Property 'MasterId'
            ///Property <see cref="AccountId"/> from Vocab 'Activity.cdm.json/Activity' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'ActivityParty.cdm.json/ActivityParty' with Property 'PartyId'
            ///Property <see cref="AccountId"/> from Vocab 'Address.cdm.json/Address' with Property 'ParentId'
            ///Property <see cref="AccountId"/> from Vocab 'Appointment.cdm.json/Appointment' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="AccountId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="AccountId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'ParentCustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'CustomerRelationship.cdm.json/CustomerRelationship' with Property 'PartnerId'
            ///Property <see cref="AccountId"/> from Vocab 'CustomerRelationship.cdm.json/CustomerRelationship' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'Email.cdm.json/Email' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'Email.cdm.json/Email' with Property 'EmailSender'
            ///Property <see cref="AccountId"/> from Vocab 'Fax.cdm.json/Fax' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'Letter.cdm.json/Letter' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'Note.cdm.json/Note' with Property 'ObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'PhoneCall.cdm.json/PhoneCall' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'RecurringAppointment.cdm.json/RecurringAppointment' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'Regarding'
            ///Property <see cref="AccountId"/> from Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'PostAuthorAccount'
            ///Property <see cref="AccountId"/> from Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'PostAuthor'
            ///Property <see cref="AccountId"/> from Vocab 'SocialProfile.cdm.json/SocialProfile' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/Lead.cdm.json/Lead' with Property 'ParentAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/Lead.cdm.json/Lead' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/AggregateKPIContext.cdm.json/AggregateKPIContext' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/Business.cdm.json/Business' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/BusinessFacility.cdm.json/BusinessFacility' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/BusinessOperation.cdm.json/BusinessOperation' with Property 'AccountId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/BusinessOperationCustomerPreference.cdm.json/BusinessOperationCustomerPreference' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/CustomerIdentifier.cdm.json/CustomerIdentifier' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/DealCustomer.cdm.json/DealCustomer' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/DeviceRegistration.cdm.json/DeviceRegistration' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/FinancingOpportunity.cdm.json/FinancingOpportunity' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/Fleet.cdm.json/Fleet' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/SalesContract.cdm.json/SalesContract' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/SalesContractPayment.cdm.json/SalesContractPayment' with Property 'ProviderAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/ServiceAppointment.cdm.json/ServiceAppointment' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/ServiceContract.cdm.json/ServiceContract' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/ServiceContract.cdm.json/ServiceContract' with Property 'ProviderAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/ServiceOrder.cdm.json/ServiceOrder' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/ServiceOrderJobDetail.cdm.json/ServiceOrderJobDetail' with Property 'SubcontractorAccountId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/TestDrive.cdm.json/TestDrive' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/TradeIn.cdm.json/TradeIn' with Property 'CustomerId'
            ///Property <see cref="AccountId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/Warranty.cdm.json/Warranty' with Property 'ProviderAccountId'
            #endregion
        }

        public VocabularyKey AccountCategoryCode { get; private set; }
        public VocabularyKey AccountClassificationCode { get; private set; }
        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey AccountNumber { get; private set; }
        public VocabularyKey AccountRatingCode { get; private set; }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey AcquisitionDate { get; private set; }
        public VocabularyKey AcquisitionSource { get; private set; }
        public VocabularyKey Address1PeriodEndDate { get; private set; }
        public VocabularyKey Address1PeriodStartDate { get; private set; }
        public VocabularyKey Address2PeriodEndDate { get; private set; }
        public VocabularyKey Address2PeriodStartDate { get; private set; }
        public VocabularyKey AdxCreatedByIPAddress { get; private set; }
        public VocabularyKey AdxCreatedByUsername { get; private set; }
        public VocabularyKey AdxModifiedByIPAddress { get; private set; }
        public VocabularyKey AdxModifiedByUsername { get; private set; }
        public VocabularyKey Aging30 { get; private set; }
        public VocabularyKey Aging30Base { get; private set; }
        public VocabularyKey Aging60 { get; private set; }
        public VocabularyKey Aging60Base { get; private set; }
        public VocabularyKey Aging90 { get; private set; }
        public VocabularyKey Aging90Base { get; private set; }
        public VocabularyKey Alias { get; private set; }
        public VocabularyKey AnnualReviewDate { get; private set; }
        public VocabularyKey AvailableLimit { get; private set; }
        public VocabularyKey AvailableLimitBase { get; private set; }
        public VocabularyKey BanksYTDRevenue { get; private set; }
        public VocabularyKey BanksYTDRevenueBase { get; private set; }
        public VocabularyKey BusinessTypeCode { get; private set; }
        public VocabularyKey CompanysProfitInTheLastYear { get; private set; }
        public VocabularyKey CompanysProfitInTheLastYearBase { get; private set; }
        public VocabularyKey CompanyTurnoverInTheLastYear { get; private set; }
        public VocabularyKey CompanyTurnoverInTheLastYearBase { get; private set; }
        public VocabularyKey CreatedByExternalParty { get; private set; }
        public VocabularyKey CreditLimit { get; private set; }
        public VocabularyKey CreditLimitBase { get; private set; }
        public VocabularyKey CreditOnHold { get; private set; }
        public VocabularyKey CustomerSizeCode { get; private set; }
        public VocabularyKey CustomerTypeCode { get; private set; }
        public VocabularyKey DaysPastDue { get; private set; }
        public VocabularyKey DefaultPriceLevelId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DoNotBulkEMail { get; private set; }
        public VocabularyKey DoNotBulkPostalMail { get; private set; }
        public VocabularyKey DoNotEMail { get; private set; }
        public VocabularyKey DoNotFax { get; private set; }
        public VocabularyKey DoNotPhone { get; private set; }
        public VocabularyKey DoNotPostalMail { get; private set; }
        public VocabularyKey DoNotSendMM { get; private set; }
        public VocabularyKey EMailAddress1 { get; private set; }
        public VocabularyKey EMailAddress2 { get; private set; }
        public VocabularyKey EMailAddress3 { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExternalID { get; private set; }
        public VocabularyKey ExternalIdentifier { get; private set; }
        public VocabularyKey ExternalSourceSystem { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey FollowEmail { get; private set; }
        public VocabularyKey FtpSiteUrl { get; private set; }
        public VocabularyKey HotelGroup { get; private set; }
        public VocabularyKey IatiOrganizationIdentifier { get; private set; }
        public VocabularyKey ImplementedLimit { get; private set; }
        public VocabularyKey ImplementedLimitBase { get; private set; }
        public VocabularyKey IndustryCode { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey LastUsedInCampaign { get; private set; }
        public VocabularyKey LimitReviewDate { get; private set; }
        public VocabularyKey MarketCap { get; private set; }
        public VocabularyKey MarketCapBase { get; private set; }
        public VocabularyKey MarketingOnly { get; private set; }
        public VocabularyKey Merged { get; private set; }
        public VocabularyKey ModifiedByExternalParty { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NumberofContacts { get; private set; }
        public VocabularyKey NumberOfEmployees { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey OpenDeals { get; private set; }
        public VocabularyKey OpenDealsDate { get; private set; }
        public VocabularyKey OpenDealsState { get; private set; }
        public VocabularyKey OpenRevenue { get; private set; }
        public VocabularyKey OpenRevenueBase { get; private set; }
        public VocabularyKey OpenRevenueDate { get; private set; }
        public VocabularyKey OpenRevenueState { get; private set; }
        public VocabularyKey OwnershipCode { get; private set; }
        public VocabularyKey ParticipatesInWorkflow { get; private set; }
        public VocabularyKey PastDueSince { get; private set; }
        public VocabularyKey PaymentTermsCode { get; private set; }
        public VocabularyKey PreferredAppointmentDayCode { get; private set; }
        public VocabularyKey PreferredAppointmentTimeCode { get; private set; }
        public VocabularyKey PreferredContactMethodCode { get; private set; }
        public VocabularyKey PrimaryConstituentType { get; private set; }
        public VocabularyKey PrimarySatoriId { get; private set; }
        public VocabularyKey PrimaryTwitterId { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey ProfitTier { get; private set; }
        public VocabularyKey RentalCarProvider { get; private set; }
        public VocabularyKey ReturnOnCapital { get; private set; }
        public VocabularyKey Revenue { get; private set; }
        public VocabularyKey RevenueBase { get; private set; }
        public VocabularyKey RiskRating { get; private set; }
        public VocabularyKey SecondaryReporter { get; private set; }
        public VocabularyKey SharesOutstanding { get; private set; }
        public VocabularyKey ShippingMethodCode { get; private set; }
        public VocabularyKey SIC { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey StockExchange { get; private set; }
        public VocabularyKey Telecom1EndDate { get; private set; }
        public VocabularyKey Telecom1Rank { get; private set; }
        public VocabularyKey Telecom1StartDate { get; private set; }
        public VocabularyKey Telecom1System { get; private set; }
        public VocabularyKey Telecom1Use { get; private set; }
        public VocabularyKey Telecom2EndDate { get; private set; }
        public VocabularyKey Telecom2Rank { get; private set; }
        public VocabularyKey Telecom2StartDate { get; private set; }
        public VocabularyKey Telecom2System { get; private set; }
        public VocabularyKey Telecom2Use { get; private set; }
        public VocabularyKey Telecom3EndDate { get; private set; }
        public VocabularyKey Telecom3Rank { get; private set; }
        public VocabularyKey Telecom3StartDate { get; private set; }
        public VocabularyKey Telecom3System { get; private set; }
        public VocabularyKey Telecom3Use { get; private set; }
        public VocabularyKey Telephone1 { get; private set; }
        public VocabularyKey Telephone2 { get; private set; }
        public VocabularyKey Telephone3 { get; private set; }
        public VocabularyKey TerritoryCode { get; private set; }
        public VocabularyKey TickerSymbol { get; private set; }
        public VocabularyKey TimeSpentByMeOnEmailAndMeetings { get; private set; }
        public VocabularyKey TotalDeposits { get; private set; }
        public VocabularyKey TotalDepositsBase { get; private set; }
        public VocabularyKey TotalLimit { get; private set; }
        public VocabularyKey TotalLimitBase { get; private set; }
        public VocabularyKey TotalLoans { get; private set; }
        public VocabularyKey TotalLoansBase { get; private set; }
        public VocabularyKey TotalPastDue { get; private set; }
        public VocabularyKey TotalPastDueBase { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey UtilizedLimit { get; private set; }
        public VocabularyKey UtilizedLimitBase { get; private set; }
        public VocabularyKey WebSiteUrl { get; private set; }
        public VocabularyKey YomiName { get; private set; }
    }
}