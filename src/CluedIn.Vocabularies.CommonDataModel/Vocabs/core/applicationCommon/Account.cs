using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account.applicationcommon";
            KeySeparator = ".";
            Grouping = "/Account";

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
        }

        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey AccountCategoryCode { get; private set; }
        public VocabularyKey CustomerSizeCode { get; private set; }
        public VocabularyKey PreferredContactMethodCode { get; private set; }
        public VocabularyKey CustomerTypeCode { get; private set; }
        public VocabularyKey AccountRatingCode { get; private set; }
        public VocabularyKey IndustryCode { get; private set; }
        public VocabularyKey TerritoryCode { get; private set; }
        public VocabularyKey AccountClassificationCode { get; private set; }
        public VocabularyKey BusinessTypeCode { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey PaymentTermsCode { get; private set; }
        public VocabularyKey ShippingMethodCode { get; private set; }
        public VocabularyKey ParticipatesInWorkflow { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AccountNumber { get; private set; }
        public VocabularyKey Revenue { get; private set; }
        public VocabularyKey NumberOfEmployees { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey SIC { get; private set; }
        public VocabularyKey OwnershipCode { get; private set; }
        public VocabularyKey MarketCap { get; private set; }
        public VocabularyKey SharesOutstanding { get; private set; }
        public VocabularyKey TickerSymbol { get; private set; }
        public VocabularyKey StockExchange { get; private set; }
        public VocabularyKey WebSiteUrl { get; private set; }
        public VocabularyKey FtpSiteUrl { get; private set; }
        public VocabularyKey EMailAddress1 { get; private set; }
        public VocabularyKey EMailAddress2 { get; private set; }
        public VocabularyKey EMailAddress3 { get; private set; }
        public VocabularyKey DoNotPhone { get; private set; }
        public VocabularyKey DoNotFax { get; private set; }
        public VocabularyKey Telephone1 { get; private set; }
        public VocabularyKey DoNotEMail { get; private set; }
        public VocabularyKey Telephone2 { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey Telephone3 { get; private set; }
        public VocabularyKey DoNotPostalMail { get; private set; }
        public VocabularyKey DoNotBulkEMail { get; private set; }
        public VocabularyKey DoNotBulkPostalMail { get; private set; }
        public VocabularyKey CreditLimit { get; private set; }
        public VocabularyKey CreditOnHold { get; private set; }
        public VocabularyKey Aging30 { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Aging60 { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Aging90 { get; private set; }
        public VocabularyKey PreferredAppointmentDayCode { get; private set; }
        public VocabularyKey PreferredAppointmentTimeCode { get; private set; }
        public VocabularyKey Merged { get; private set; }
        public VocabularyKey DoNotSendMM { get; private set; }
        public VocabularyKey LastUsedInCampaign { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CreditLimitBase { get; private set; }
        public VocabularyKey Aging30Base { get; private set; }
        public VocabularyKey RevenueBase { get; private set; }
        public VocabularyKey Aging90Base { get; private set; }
        public VocabularyKey MarketCapBase { get; private set; }
        public VocabularyKey Aging60Base { get; private set; }
        public VocabularyKey YomiName { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey TimeSpentByMeOnEmailAndMeetings { get; private set; }
        public VocabularyKey CreatedByExternalParty { get; private set; }
        public VocabularyKey ModifiedByExternalParty { get; private set; }
        public VocabularyKey PrimarySatoriId { get; private set; }
        public VocabularyKey PrimaryTwitterId { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey FollowEmail { get; private set; }
        public VocabularyKey MarketingOnly { get; private set; }
    }
}