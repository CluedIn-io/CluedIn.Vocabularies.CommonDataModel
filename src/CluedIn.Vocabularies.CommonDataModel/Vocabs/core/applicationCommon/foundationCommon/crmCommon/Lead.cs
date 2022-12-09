using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class LeadVocabulary : SimpleVocabulary
    {
        public LeadVocabulary()
        {
            VocabularyName = "Lead";
            KeyPrefix = "commonDataModel.lead";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Lead;

            AddGroup("Lead Details for CrmCommon", group =>
            {
			    LeadId = group.Add(new VocabularyKey(nameof(LeadId), "Lead", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FullName = group.Add(new VocabularyKey(nameof(FullName), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1AddressId = group.Add(new VocabularyKey(nameof(Address1AddressId), "Address 1: ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1AddressTypeCode = group.Add(new VocabularyKey(nameof(Address1AddressTypeCode), "Address 1: Address Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1City = group.Add(new VocabularyKey(nameof(Address1City), "City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Composite = group.Add(new VocabularyKey(nameof(Address1Composite), "Address 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Country = group.Add(new VocabularyKey(nameof(Address1Country), "Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address1County = group.Add(new VocabularyKey(nameof(Address1County), "Address 1: County", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address1Fax = group.Add(new VocabularyKey(nameof(Address1Fax), "Address 1: Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Latitude = group.Add(new VocabularyKey(nameof(Address1Latitude), "Address 1: Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Line1 = group.Add(new VocabularyKey(nameof(Address1Line1), "Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Line2 = group.Add(new VocabularyKey(nameof(Address1Line2), "Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Line3 = group.Add(new VocabularyKey(nameof(Address1Line3), "Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Longitude = group.Add(new VocabularyKey(nameof(Address1Longitude), "Address 1: Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Name = group.Add(new VocabularyKey(nameof(Address1Name), "Address 1: Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PostalCode = group.Add(new VocabularyKey(nameof(Address1PostalCode), "ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PostOfficeBox = group.Add(new VocabularyKey(nameof(Address1PostOfficeBox), "Address 1: Post Office Box", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1ShippingMethodCode = group.Add(new VocabularyKey(nameof(Address1ShippingMethodCode), "Address 1: Shipping Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1StateOrProvince = group.Add(new VocabularyKey(nameof(Address1StateOrProvince), "State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Telephone1 = group.Add(new VocabularyKey(nameof(Address1Telephone1), "Address 1: Telephone 1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address1Telephone2 = group.Add(new VocabularyKey(nameof(Address1Telephone2), "Address 1: Telephone 2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address1Telephone3 = group.Add(new VocabularyKey(nameof(Address1Telephone3), "Address 1: Telephone 3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address1UPSZone = group.Add(new VocabularyKey(nameof(Address1UPSZone), "Address 1: UPS Zone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1UTCOffset = group.Add(new VocabularyKey(nameof(Address1UTCOffset), "Address 1: UTC Offset", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    Address2AddressId = group.Add(new VocabularyKey(nameof(Address2AddressId), "Address 2: ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2AddressTypeCode = group.Add(new VocabularyKey(nameof(Address2AddressTypeCode), "Address 2: Address Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2City = group.Add(new VocabularyKey(nameof(Address2City), "Address 2: City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Composite = group.Add(new VocabularyKey(nameof(Address2Composite), "Address 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Country = group.Add(new VocabularyKey(nameof(Address2Country), "Address 2: Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address2County = group.Add(new VocabularyKey(nameof(Address2County), "Address 2: County", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address2Fax = group.Add(new VocabularyKey(nameof(Address2Fax), "Address 2: Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Latitude = group.Add(new VocabularyKey(nameof(Address2Latitude), "Address 2: Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Line1 = group.Add(new VocabularyKey(nameof(Address2Line1), "Address 2: Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Line2 = group.Add(new VocabularyKey(nameof(Address2Line2), "Address 2: Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Line3 = group.Add(new VocabularyKey(nameof(Address2Line3), "Address 2: Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Longitude = group.Add(new VocabularyKey(nameof(Address2Longitude), "Address 2: Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Name = group.Add(new VocabularyKey(nameof(Address2Name), "Address 2: Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PostalCode = group.Add(new VocabularyKey(nameof(Address2PostalCode), "Address 2: ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PostOfficeBox = group.Add(new VocabularyKey(nameof(Address2PostOfficeBox), "Address 2: Post Office Box", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2ShippingMethodCode = group.Add(new VocabularyKey(nameof(Address2ShippingMethodCode), "Address 2: Shipping Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2StateOrProvince = group.Add(new VocabularyKey(nameof(Address2StateOrProvince), "Address 2: State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Telephone1 = group.Add(new VocabularyKey(nameof(Address2Telephone1), "Address 2: Telephone 1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address2Telephone2 = group.Add(new VocabularyKey(nameof(Address2Telephone2), "Address 2: Telephone 2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address2Telephone3 = group.Add(new VocabularyKey(nameof(Address2Telephone3), "Address 2: Telephone 3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address2UPSZone = group.Add(new VocabularyKey(nameof(Address2UPSZone), "Address 2: UPS Zone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2UTCOffset = group.Add(new VocabularyKey(nameof(Address2UTCOffset), "Address 2: UTC Offset", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    BudgetAmount = group.Add(new VocabularyKey(nameof(BudgetAmount), "Budget Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    BudgetAmountBase = group.Add(new VocabularyKey(nameof(BudgetAmountBase), "Budget Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BudgetStatus = group.Add(new VocabularyKey(nameof(BudgetStatus), "Budget", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CompanyName = group.Add(new VocabularyKey(nameof(CompanyName), "Company Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ConfirmInterest = group.Add(new VocabularyKey(nameof(ConfirmInterest), "Confirm Interest", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DecisionMaker = group.Add(new VocabularyKey(nameof(DecisionMaker), "Decision Maker?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DoNotBulkEMail = group.Add(new VocabularyKey(nameof(DoNotBulkEMail), "Do not allow Bulk Emails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotEMail = group.Add(new VocabularyKey(nameof(DoNotEMail), "Do not allow Emails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotFax = group.Add(new VocabularyKey(nameof(DoNotFax), "Do not allow Faxes", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotPhone = group.Add(new VocabularyKey(nameof(DoNotPhone), "Do not allow Phone Calls", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotPostalMail = group.Add(new VocabularyKey(nameof(DoNotPostalMail), "Do not allow Mails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotSendMM = group.Add(new VocabularyKey(nameof(DoNotSendMM), "Marketing Material", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EMailAddress1 = group.Add(new VocabularyKey(nameof(EMailAddress1), "Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    EMailAddress2 = group.Add(new VocabularyKey(nameof(EMailAddress2), "Email Address 2", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    EMailAddress3 = group.Add(new VocabularyKey(nameof(EMailAddress3), "Email Address 3", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    EstimatedAmount = group.Add(new VocabularyKey(nameof(EstimatedAmount), "Est. Value", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstimatedAmountBase = group.Add(new VocabularyKey(nameof(EstimatedAmountBase), "Est. Value (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimatedCloseDate = group.Add(new VocabularyKey(nameof(EstimatedCloseDate), "Est. Close Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimatedValue = group.Add(new VocabularyKey(nameof(EstimatedValue), "Est. Value (deprecated)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EvaluateFit = group.Add(new VocabularyKey(nameof(EvaluateFit), "Evaluate Fit", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Fax = group.Add(new VocabularyKey(nameof(Fax), "Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FirstName = group.Add(new VocabularyKey(nameof(FirstName), "First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IndustryCode = group.Add(new VocabularyKey(nameof(IndustryCode), "Industry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InitialCommunication = group.Add(new VocabularyKey(nameof(InitialCommunication), "Initial Communication", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    JobTitle = group.Add(new VocabularyKey(nameof(JobTitle), "Job Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastName = group.Add(new VocabularyKey(nameof(LastName), "Last Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastUsedInCampaign = group.Add(new VocabularyKey(nameof(LastUsedInCampaign), "Last Campaign Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LeadQualityCode = group.Add(new VocabularyKey(nameof(LeadQualityCode), "Rating", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LeadSourceCode = group.Add(new VocabularyKey(nameof(LeadSourceCode), "Lead Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Merged = group.Add(new VocabularyKey(nameof(Merged), "Merged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), "Middle Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MobilePhone = group.Add(new VocabularyKey(nameof(MobilePhone), "Mobile Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Need = group.Add(new VocabularyKey(nameof(Need), "Need", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfEmployees = group.Add(new VocabularyKey(nameof(NumberOfEmployees), "No. of Employees", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Pager = group.Add(new VocabularyKey(nameof(Pager), "Pager", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ParticipatesInWorkflow = group.Add(new VocabularyKey(nameof(ParticipatesInWorkflow), "Participates in Workflow", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    PreferredContactMethodCode = group.Add(new VocabularyKey(nameof(PreferredContactMethodCode), "Preferred Method of Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PriorityCode = group.Add(new VocabularyKey(nameof(PriorityCode), "Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PurchaseProcess = group.Add(new VocabularyKey(nameof(PurchaseProcess), "Purchase Process", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    QualificationComments = group.Add(new VocabularyKey(nameof(QualificationComments), "Qualification Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Revenue = group.Add(new VocabularyKey(nameof(Revenue), "Annual Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RevenueBase = group.Add(new VocabularyKey(nameof(RevenueBase), "Annual Revenue (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SalesStage = group.Add(new VocabularyKey(nameof(SalesStage), "Sales Stage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SalesStageCode = group.Add(new VocabularyKey(nameof(SalesStageCode), "Sales Stage Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Salutation = group.Add(new VocabularyKey(nameof(Salutation), "Salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduleFollowupProspect = group.Add(new VocabularyKey(nameof(ScheduleFollowupProspect), "Schedule Follow Up (Prospect)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduleFollowUpQualify = group.Add(new VocabularyKey(nameof(ScheduleFollowUpQualify), "Schedule Follow Up (Qualify)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SIC = group.Add(new VocabularyKey(nameof(SIC), "SIC Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Subject = group.Add(new VocabularyKey(nameof(Subject), "Topic", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone1 = group.Add(new VocabularyKey(nameof(Telephone1), "Business Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Telephone2 = group.Add(new VocabularyKey(nameof(Telephone2), "Home Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Telephone3 = group.Add(new VocabularyKey(nameof(Telephone3), "Other Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    PurchaseTimeFrame = group.Add(new VocabularyKey(nameof(PurchaseTimeFrame), "Purchase Timeframe", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebSiteUrl = group.Add(new VocabularyKey(nameof(WebSiteUrl), "Website", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FollowEmail = group.Add(new VocabularyKey(nameof(FollowEmail), "Follow Email Activity", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TimeSpentByMeOnEmailAndMeetings = group.Add(new VocabularyKey(nameof(TimeSpentByMeOnEmailAndMeetings), "Time Spent by me", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    AccountId = group.Add(new VocabularyKey(nameof(AccountId), "Account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContactId = group.Add(new VocabularyKey(nameof(ContactId), "Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YomiCompanyName = group.Add(new VocabularyKey(nameof(YomiCompanyName), "Yomi Company Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YomiFirstName = group.Add(new VocabularyKey(nameof(YomiFirstName), "Yomi First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YomiFullName = group.Add(new VocabularyKey(nameof(YomiFullName), "Yomi Full Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YomiLastName = group.Add(new VocabularyKey(nameof(YomiLastName), "Yomi Last Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YomiMiddleName = group.Add(new VocabularyKey(nameof(YomiMiddleName), "Yomi Middle Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Lead Details for Automotive", group =>
            {
			    BusinessOperationId = group.Add(new VocabularyKey(nameof(BusinessOperationId), "Business Operation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Interest = group.Add(new VocabularyKey(nameof(Interest), "Interest", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsResent = group.Add(new VocabularyKey(nameof(IsResent), "Is Resent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RequestedOn = group.Add(new VocabularyKey(nameof(RequestedOn), "Requested On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RespondBefore = group.Add(new VocabularyKey(nameof(RespondBefore), "Respond Before", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SourceBusinessOperationId = group.Add(new VocabularyKey(nameof(SourceBusinessOperationId), "Source Business Operation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SourceName = group.Add(new VocabularyKey(nameof(SourceName), "Source Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SourceVersion = group.Add(new VocabularyKey(nameof(SourceVersion), "Source Version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Lead Details for Banking", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Entity Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Employer = group.Add(new VocabularyKey(nameof(Employer), "Employer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IDNumber = group.Add(new VocabularyKey(nameof(IDNumber), "ID Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProspectType = group.Add(new VocabularyKey(nameof(ProspectType), "Prospect Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Lead Details for NonProfitForSales", group =>
            {
			    ApplicationDeadline = group.Add(new VocabularyKey(nameof(ApplicationDeadline), "Application Deadline", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedAmountRequested = group.Add(new VocabularyKey(nameof(ExpectedAmountRequested), "Expected Amount Requested", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExpectedAmountRequested_Base = group.Add(new VocabularyKey(nameof(ExpectedAmountRequested_Base), "Expected Amount Requested (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExpectedDuration = group.Add(new VocabularyKey(nameof(ExpectedDuration), "Expected Duration (Months)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ExpectedStartDate = group.Add(new VocabularyKey(nameof(ExpectedStartDate), "Expected Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsRenewal = group.Add(new VocabularyKey(nameof(IsRenewal), "Is Renewal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LetterOfIntentDeadline = group.Add(new VocabularyKey(nameof(LetterOfIntentDeadline), "Letter of Intent Deadline", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrganizationalBudget = group.Add(new VocabularyKey(nameof(OrganizationalBudget), "Organization Budget", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OrganizationalBudget_Base = group.Add(new VocabularyKey(nameof(OrganizationalBudget_Base), "Organization Budget (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OrganizationType = group.Add(new VocabularyKey(nameof(OrganizationType), "Organization Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestType = group.Add(new VocabularyKey(nameof(RequestType), "Request Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalProjectBudget = group.Add(new VocabularyKey(nameof(TotalProjectBudget), "Total Project Budget", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalProjectBudget_Base = group.Add(new VocabularyKey(nameof(TotalProjectBudget_Base), "Total Project Budget (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Lead Details for ProjectCommon", group =>
            {
			    GDPROptOut = group.Add(new VocabularyKey(nameof(GDPROptOut), "GDPR Optout", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    OrderType = group.Add(new VocabularyKey(nameof(OrderType), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Lead Details for Marketing", group =>
            {
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LeadSourceType = group.Add(new VocabularyKey(nameof(LeadSourceType), "Lead source type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Scores = group.Add(new VocabularyKey(nameof(Scores), "Scores", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ScoringGrade = group.Add(new VocabularyKey(nameof(ScoringGrade), "Scoring grade", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), "Insights", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Profileid = group.Add(new VocabularyKey(nameof(Profileid), "Profile ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PurchaseNeed = group.Add(new VocabularyKey(nameof(PurchaseNeed), "Purchase need", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TriggerRecycle = group.Add(new VocabularyKey(nameof(TriggerRecycle), "Recycle", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Recycled = group.Add(new VocabularyKey(nameof(Recycled), "Recycled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SalesAccepted = group.Add(new VocabularyKey(nameof(SalesAccepted), "Sales accepted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SalesReady = group.Add(new VocabularyKey(nameof(SalesReady), "Sales ready", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SasToken = group.Add(new VocabularyKey(nameof(SasToken), "SAS token", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TeleProspectAccepted = group.Add(new VocabularyKey(nameof(TeleProspectAccepted), "Teleprospecting accepted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TeleProspectReady = group.Add(new VocabularyKey(nameof(TeleProspectReady), "Teleprospecting ready", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    CompanySize = group.Add(new VocabularyKey(nameof(CompanySize), "Company size", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Degree = group.Add(new VocabularyKey(nameof(Degree), "Degree", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FieldOfStudy = group.Add(new VocabularyKey(nameof(FieldOfStudy), "Field of study", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GraduationDate = group.Add(new VocabularyKey(nameof(GraduationDate), "Graduation date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Industry = group.Add(new VocabularyKey(nameof(Industry), "Industry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    JobFunction = group.Add(new VocabularyKey(nameof(JobFunction), "Job function", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LatestFormSubmissionDate = group.Add(new VocabularyKey(nameof(LatestFormSubmissionDate), "Latest Form Submission Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    School = group.Add(new VocabularyKey(nameof(School), "School", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Seniority = group.Add(new VocabularyKey(nameof(Seniority), "Seniority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInFormSubmissions = group.Add(new VocabularyKey(nameof(LinkedInFormSubmissions), "LinkedIn Form Submissions", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="AccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="RelatedObjectId"/> to Vocab 'CampaignResponse.cdm.json/CampaignResponse' with Property 'ActivityId'
            ///Property <see cref="RelatedObjectId"/> to Vocab 'CampaignResponse.cdm.json/CampaignResponse' with Property 'ActivityId'
            ///Property <see cref="RelatedObjectId"/> to Vocab 'CampaignResponse.cdm.json/CampaignResponse' with Property 'ActivityId'
            ///Property <see cref="RelatedObjectId"/> to Vocab 'CampaignResponse.cdm.json/CampaignResponse' with Property 'ActivityId'
            ///Property <see cref="RelatedObjectId"/> to Vocab 'CampaignResponse.cdm.json/CampaignResponse' with Property 'ActivityId'
            ///Property <see cref="RelatedObjectId"/> to Vocab 'CampaignResponse.cdm.json/CampaignResponse' with Property 'ActivityId'
            ///Property <see cref="ParentContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="CreatedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="MasterId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="OriginatingCaseId"/> to Vocab 'service/Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="QualifyingOpportunityId"/> to Vocab 'sales/Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="ParentId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="CreatedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="LeadId"/> from Vocab 'Account.cdm.json/Account' with Property 'OriginatingLeadId'
            ///Property <see cref="LeadId"/> from Vocab 'AccountLeads.cdm.json/AccountLeads' with Property 'LeadId'
            ///Property <see cref="LeadId"/> from Vocab 'CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'OriginatingLeadId'
            ///Property <see cref="LeadId"/> from Vocab 'ContactLeads.cdm.json/ContactLeads' with Property 'LeadId'
            ///Property <see cref="LeadId"/> from Vocab 'Email.cdm.json/Email' with Property 'EmailSender'
            ///Property <see cref="LeadId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'MasterId'
            ///Property <see cref="LeadId"/> from Vocab 'LeadAddress.cdm.json/LeadAddress' with Property 'ParentId'
            ///Property <see cref="LeadId"/> from Vocab 'MarketingListMember.cdm.json/MarketingListMember' with Property 'EntityId'
            ///Property <see cref="LeadId"/> from Vocab 'QuickCampaign.cdm.json/QuickCampaign' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab 'sales/LeadCompetitors.cdm.json/LeadCompetitors' with Property 'LeadId'
            ///Property <see cref="LeadId"/> from Vocab 'sales/LeadProduct.cdm.json/LeadProduct' with Property 'LeadId'
            ///Property <see cref="LeadId"/> from Vocab 'sales/Opportunity.cdm.json/Opportunity' with Property 'OriginatingLeadId'
            ///Property <see cref="LeadId"/> from Vocab 'sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab 'sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab 'sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab 'service/CaseResolution.cdm.json/CaseResolution' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab 'service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab 'solutions/portals/Account.cdm.json/Account' with Property 'OriginatingLeadId'
            ///Property <see cref="LeadId"/> from Vocab 'solutions/portals/Contact.cdm.json/Contact' with Property 'OriginatingLeadId'
            ///Property <see cref="LeadId"/> from Vocab 'solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="LeadId"/> from Vocab 'solutions/portals/Opportunity.cdm.json/Opportunity' with Property 'OriginatingLeadId'
            #endregion
        }

        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey Address1AddressId { get; private set; }
        public VocabularyKey Address1AddressTypeCode { get; private set; }
        public VocabularyKey Address1City { get; private set; }
        public VocabularyKey Address1Composite { get; private set; }
        public VocabularyKey Address1Country { get; private set; }
        public VocabularyKey Address1County { get; private set; }
        public VocabularyKey Address1Fax { get; private set; }
        public VocabularyKey Address1Latitude { get; private set; }
        public VocabularyKey Address1Line1 { get; private set; }
        public VocabularyKey Address1Line2 { get; private set; }
        public VocabularyKey Address1Line3 { get; private set; }
        public VocabularyKey Address1Longitude { get; private set; }
        public VocabularyKey Address1Name { get; private set; }
        public VocabularyKey Address1PostalCode { get; private set; }
        public VocabularyKey Address1PostOfficeBox { get; private set; }
        public VocabularyKey Address1ShippingMethodCode { get; private set; }
        public VocabularyKey Address1StateOrProvince { get; private set; }
        public VocabularyKey Address1Telephone1 { get; private set; }
        public VocabularyKey Address1Telephone2 { get; private set; }
        public VocabularyKey Address1Telephone3 { get; private set; }
        public VocabularyKey Address1UPSZone { get; private set; }
        public VocabularyKey Address1UTCOffset { get; private set; }
        public VocabularyKey Address2AddressId { get; private set; }
        public VocabularyKey Address2AddressTypeCode { get; private set; }
        public VocabularyKey Address2City { get; private set; }
        public VocabularyKey Address2Composite { get; private set; }
        public VocabularyKey Address2Country { get; private set; }
        public VocabularyKey Address2County { get; private set; }
        public VocabularyKey Address2Fax { get; private set; }
        public VocabularyKey Address2Latitude { get; private set; }
        public VocabularyKey Address2Line1 { get; private set; }
        public VocabularyKey Address2Line2 { get; private set; }
        public VocabularyKey Address2Line3 { get; private set; }
        public VocabularyKey Address2Longitude { get; private set; }
        public VocabularyKey Address2Name { get; private set; }
        public VocabularyKey Address2PostalCode { get; private set; }
        public VocabularyKey Address2PostOfficeBox { get; private set; }
        public VocabularyKey Address2ShippingMethodCode { get; private set; }
        public VocabularyKey Address2StateOrProvince { get; private set; }
        public VocabularyKey Address2Telephone1 { get; private set; }
        public VocabularyKey Address2Telephone2 { get; private set; }
        public VocabularyKey Address2Telephone3 { get; private set; }
        public VocabularyKey Address2UPSZone { get; private set; }
        public VocabularyKey Address2UTCOffset { get; private set; }
        public VocabularyKey ApplicationDeadline { get; private set; }
        public VocabularyKey BudgetAmount { get; private set; }
        public VocabularyKey BudgetAmountBase { get; private set; }
        public VocabularyKey BudgetStatus { get; private set; }
        public VocabularyKey BusinessOperationId { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey CompanyName { get; private set; }
        public VocabularyKey CompanySize { get; private set; }
        public VocabularyKey ConfirmInterest { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey DecisionMaker { get; private set; }
        public VocabularyKey Degree { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DoNotBulkEMail { get; private set; }
        public VocabularyKey DoNotEMail { get; private set; }
        public VocabularyKey DoNotFax { get; private set; }
        public VocabularyKey DoNotPhone { get; private set; }
        public VocabularyKey DoNotPostalMail { get; private set; }
        public VocabularyKey DoNotSendMM { get; private set; }
        public VocabularyKey EMailAddress1 { get; private set; }
        public VocabularyKey EMailAddress2 { get; private set; }
        public VocabularyKey EMailAddress3 { get; private set; }
        public VocabularyKey Employer { get; private set; }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey EstimatedAmount { get; private set; }
        public VocabularyKey EstimatedAmountBase { get; private set; }
        public VocabularyKey EstimatedCloseDate { get; private set; }
        public VocabularyKey EstimatedValue { get; private set; }
        public VocabularyKey EvaluateFit { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExpectedAmountRequested { get; private set; }
        public VocabularyKey ExpectedAmountRequested_Base { get; private set; }
        public VocabularyKey ExpectedDuration { get; private set; }
        public VocabularyKey ExpectedStartDate { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey FieldOfStudy { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey FollowEmail { get; private set; }
        public VocabularyKey FullName { get; private set; }
        public VocabularyKey GDPROptOut { get; private set; }
        public VocabularyKey GraduationDate { get; private set; }
        public VocabularyKey IDNumber { get; private set; }
        public VocabularyKey Industry { get; private set; }
        public VocabularyKey IndustryCode { get; private set; }
        public VocabularyKey InitialCommunication { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey Interest { get; private set; }
        public VocabularyKey IsRenewal { get; private set; }
        public VocabularyKey IsResent { get; private set; }
        public VocabularyKey JobFunction { get; private set; }
        public VocabularyKey JobTitle { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey LastUsedInCampaign { get; private set; }
        public VocabularyKey LatestFormSubmissionDate { get; private set; }
        public VocabularyKey LeadId { get; private set; }
        public VocabularyKey LeadQualityCode { get; private set; }
        public VocabularyKey LeadSourceCode { get; private set; }
        public VocabularyKey LeadSourceType { get; private set; }
        public VocabularyKey LetterOfIntentDeadline { get; private set; }
        public VocabularyKey LinkedInFormSubmissions { get; private set; }
        public VocabularyKey Merged { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey MobilePhone { get; private set; }
        public VocabularyKey Need { get; private set; }
        public VocabularyKey NumberOfEmployees { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey OrderType { get; private set; }
        public VocabularyKey OrganizationalBudget { get; private set; }
        public VocabularyKey OrganizationalBudget_Base { get; private set; }
        public VocabularyKey OrganizationType { get; private set; }
        public VocabularyKey Pager { get; private set; }
        public VocabularyKey ParticipatesInWorkflow { get; private set; }
        public VocabularyKey PreferredContactMethodCode { get; private set; }
        public VocabularyKey PriorityCode { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey Profileid { get; private set; }
        public VocabularyKey ProspectType { get; private set; }
        public VocabularyKey PurchaseNeed { get; private set; }
        public VocabularyKey PurchaseProcess { get; private set; }
        public VocabularyKey PurchaseTimeFrame { get; private set; }
        public VocabularyKey QualificationComments { get; private set; }
        public VocabularyKey Recycled { get; private set; }
        public VocabularyKey RequestedOn { get; private set; }
        public VocabularyKey RequestType { get; private set; }
        public VocabularyKey RespondBefore { get; private set; }
        public VocabularyKey Revenue { get; private set; }
        public VocabularyKey RevenueBase { get; private set; }
        public VocabularyKey SalesAccepted { get; private set; }
        public VocabularyKey SalesReady { get; private set; }
        public VocabularyKey SalesStage { get; private set; }
        public VocabularyKey SalesStageCode { get; private set; }
        public VocabularyKey Salutation { get; private set; }
        public VocabularyKey SasToken { get; private set; }
        public VocabularyKey ScheduleFollowupProspect { get; private set; }
        public VocabularyKey ScheduleFollowUpQualify { get; private set; }
        public VocabularyKey School { get; private set; }
        public VocabularyKey Scores { get; private set; }
        public VocabularyKey ScoringGrade { get; private set; }
        public VocabularyKey Seniority { get; private set; }
        public VocabularyKey SIC { get; private set; }
        public VocabularyKey SourceBusinessOperationId { get; private set; }
        public VocabularyKey SourceName { get; private set; }
        public VocabularyKey SourceVersion { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey Telephone1 { get; private set; }
        public VocabularyKey Telephone2 { get; private set; }
        public VocabularyKey Telephone3 { get; private set; }
        public VocabularyKey TeleProspectAccepted { get; private set; }
        public VocabularyKey TeleProspectReady { get; private set; }
        public VocabularyKey TimeSpentByMeOnEmailAndMeetings { get; private set; }
        public VocabularyKey TotalProjectBudget { get; private set; }
        public VocabularyKey TotalProjectBudget_Base { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey TriggerRecycle { get; private set; }
        public VocabularyKey WebSiteUrl { get; private set; }
        public VocabularyKey YomiCompanyName { get; private set; }
        public VocabularyKey YomiFirstName { get; private set; }
        public VocabularyKey YomiFullName { get; private set; }
        public VocabularyKey YomiLastName { get; private set; }
        public VocabularyKey YomiMiddleName { get; private set; }
    }
}