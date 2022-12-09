using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Contact;

            AddGroup("Contact Details for ApplicationCommon", group =>
            {
			    ContactId = group.Add(new VocabularyKey(nameof(ContactId), "Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerSizeCode = group.Add(new VocabularyKey(nameof(CustomerSizeCode), "Customer Size", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerTypeCode = group.Add(new VocabularyKey(nameof(CustomerTypeCode), "Relationship Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PreferredContactMethodCode = group.Add(new VocabularyKey(nameof(PreferredContactMethodCode), "Preferred Method of Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LeadSourceCode = group.Add(new VocabularyKey(nameof(LeadSourceCode), "Lead Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PaymentTermsCode = group.Add(new VocabularyKey(nameof(PaymentTermsCode), "Payment Terms", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShippingMethodCode = group.Add(new VocabularyKey(nameof(ShippingMethodCode), "Shipping Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AccountId = group.Add(new VocabularyKey(nameof(AccountId), "Account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ParticipatesInWorkflow = group.Add(new VocabularyKey(nameof(ParticipatesInWorkflow), "Participates in Workflow", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsBackofficeCustomer = group.Add(new VocabularyKey(nameof(IsBackofficeCustomer), "Back Office Customer", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Salutation = group.Add(new VocabularyKey(nameof(Salutation), "Salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    JobTitle = group.Add(new VocabularyKey(nameof(JobTitle), "Job Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FirstName = group.Add(new VocabularyKey(nameof(FirstName), "First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Department = group.Add(new VocabularyKey(nameof(Department), "Department", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NickName = group.Add(new VocabularyKey(nameof(NickName), "Nickname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), "Middle Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastName = group.Add(new VocabularyKey(nameof(LastName), "Last Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Suffix = group.Add(new VocabularyKey(nameof(Suffix), "Suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YomiFirstName = group.Add(new VocabularyKey(nameof(YomiFirstName), "Yomi First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FullName = group.Add(new VocabularyKey(nameof(FullName), "Full Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YomiMiddleName = group.Add(new VocabularyKey(nameof(YomiMiddleName), "Yomi Middle Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YomiLastName = group.Add(new VocabularyKey(nameof(YomiLastName), "Yomi Last Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Anniversary = group.Add(new VocabularyKey(nameof(Anniversary), "Anniversary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BirthDate = group.Add(new VocabularyKey(nameof(BirthDate), "Birthday", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GovernmentId = group.Add(new VocabularyKey(nameof(GovernmentId), "Government", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YomiFullName = group.Add(new VocabularyKey(nameof(YomiFullName), "Yomi Full Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmployeeId = group.Add(new VocabularyKey(nameof(EmployeeId), "Employee", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GenderCode = group.Add(new VocabularyKey(nameof(GenderCode), "Gender", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AnnualIncome = group.Add(new VocabularyKey(nameof(AnnualIncome), "Annual Income", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    HasChildrenCode = group.Add(new VocabularyKey(nameof(HasChildrenCode), "Has Children", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EducationCode = group.Add(new VocabularyKey(nameof(EducationCode), "Education", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebSiteUrl = group.Add(new VocabularyKey(nameof(WebSiteUrl), "Website", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    FamilyStatusCode = group.Add(new VocabularyKey(nameof(FamilyStatusCode), "Marital Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FtpSiteUrl = group.Add(new VocabularyKey(nameof(FtpSiteUrl), "FTP Site", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    EMailAddress1 = group.Add(new VocabularyKey(nameof(EMailAddress1), "Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    SpousesName = group.Add(new VocabularyKey(nameof(SpousesName), "Spouse/Partner Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AssistantName = group.Add(new VocabularyKey(nameof(AssistantName), "Assistant", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EMailAddress2 = group.Add(new VocabularyKey(nameof(EMailAddress2), "Email Address 2", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    AssistantPhone = group.Add(new VocabularyKey(nameof(AssistantPhone), "Assistant Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    EMailAddress3 = group.Add(new VocabularyKey(nameof(EMailAddress3), "Email Address 3", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    DoNotPhone = group.Add(new VocabularyKey(nameof(DoNotPhone), "Do not allow Phone Calls", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ManagerName = group.Add(new VocabularyKey(nameof(ManagerName), "Manager", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ManagerPhone = group.Add(new VocabularyKey(nameof(ManagerPhone), "Manager Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    DoNotFax = group.Add(new VocabularyKey(nameof(DoNotFax), "Do not allow Faxes", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotEMail = group.Add(new VocabularyKey(nameof(DoNotEMail), "Do not allow Emails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotPostalMail = group.Add(new VocabularyKey(nameof(DoNotPostalMail), "Do not allow Mails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotBulkEMail = group.Add(new VocabularyKey(nameof(DoNotBulkEMail), "Do not allow Bulk Emails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotBulkPostalMail = group.Add(new VocabularyKey(nameof(DoNotBulkPostalMail), "Do not allow Bulk Mails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AccountRoleCode = group.Add(new VocabularyKey(nameof(AccountRoleCode), "Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TerritoryCode = group.Add(new VocabularyKey(nameof(TerritoryCode), "Territory", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreditLimit = group.Add(new VocabularyKey(nameof(CreditLimit), "Credit Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CreditOnHold = group.Add(new VocabularyKey(nameof(CreditOnHold), "Credit Hold", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    NumberOfChildren = group.Add(new VocabularyKey(nameof(NumberOfChildren), "No. of Children", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ChildrensNames = group.Add(new VocabularyKey(nameof(ChildrensNames), "Children's Names", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MobilePhone = group.Add(new VocabularyKey(nameof(MobilePhone), "Mobile Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Pager = group.Add(new VocabularyKey(nameof(Pager), "Pager", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone1 = group.Add(new VocabularyKey(nameof(Telephone1), "Business Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Telephone2 = group.Add(new VocabularyKey(nameof(Telephone2), "Home Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Telephone3 = group.Add(new VocabularyKey(nameof(Telephone3), "Telephone 3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Fax = group.Add(new VocabularyKey(nameof(Fax), "Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Aging30 = group.Add(new VocabularyKey(nameof(Aging30), "Aging 30", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Aging60 = group.Add(new VocabularyKey(nameof(Aging60), "Aging 60", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Aging90 = group.Add(new VocabularyKey(nameof(Aging90), "Aging 90", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ParentContactId = group.Add(new VocabularyKey(nameof(ParentContactId), "Parent Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PreferredAppointmentDayCode = group.Add(new VocabularyKey(nameof(PreferredAppointmentDayCode), "Preferred Day", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PreferredAppointmentTimeCode = group.Add(new VocabularyKey(nameof(PreferredAppointmentTimeCode), "Preferred Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DoNotSendMM = group.Add(new VocabularyKey(nameof(DoNotSendMM), "Send Marketing Materials", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Merged = group.Add(new VocabularyKey(nameof(Merged), "Merged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ExternalUserIdentifier = group.Add(new VocabularyKey(nameof(ExternalUserIdentifier), "External User Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastUsedInCampaign = group.Add(new VocabularyKey(nameof(LastUsedInCampaign), "Last Date Included in Campaign", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AnnualIncomeBase = group.Add(new VocabularyKey(nameof(AnnualIncomeBase), "Annual Income (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreditLimitBase = group.Add(new VocabularyKey(nameof(CreditLimitBase), "Credit Limit (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Aging60Base = group.Add(new VocabularyKey(nameof(Aging60Base), "Aging 60 (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Aging90Base = group.Add(new VocabularyKey(nameof(Aging90Base), "Aging 90 (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Aging30Base = group.Add(new VocabularyKey(nameof(Aging30Base), "Aging 30 (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Process Stage", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), "Entity Image Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FollowEmail = group.Add(new VocabularyKey(nameof(FollowEmail), "Follow Email Activity", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TimeSpentByMeOnEmailAndMeetings = group.Add(new VocabularyKey(nameof(TimeSpentByMeOnEmailAndMeetings), "Time Spent by me", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    Business2 = group.Add(new VocabularyKey(nameof(Business2), "Business Phone 2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Callback = group.Add(new VocabularyKey(nameof(Callback), "Callback Number", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Company = group.Add(new VocabularyKey(nameof(Company), "Company Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Home2 = group.Add(new VocabularyKey(nameof(Home2), "Home Phone 2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    CreatedByExternalParty = group.Add(new VocabularyKey(nameof(CreatedByExternalParty), "Created By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedByExternalParty = group.Add(new VocabularyKey(nameof(ModifiedByExternalParty), "Modified By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MarketingOnly = group.Add(new VocabularyKey(nameof(MarketingOnly), "Marketing Only", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Contact Details for FoundationCommon", group =>
            {

            });
            AddGroup("Contact Details for CrmCommon", group =>
            {

            });
            AddGroup("Contact Details for HigherEducation", group =>
            {
			    ContactType = group.Add(new VocabularyKey(nameof(ContactType), "Contact Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CountryofBirth = group.Add(new VocabularyKey(nameof(CountryofBirth), "Country of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EthnicGroup = group.Add(new VocabularyKey(nameof(EthnicGroup), "Ethnic Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalIdentifier = group.Add(new VocabularyKey(nameof(ExternalIdentifier), "External Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalSourceSystem = group.Add(new VocabularyKey(nameof(ExternalSourceSystem), "External Source System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FERPAPrivacy = group.Add(new VocabularyKey(nameof(FERPAPrivacy), "FERPA Privacy", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    FirstGeneration = group.Add(new VocabularyKey(nameof(FirstGeneration), "First Generation", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    HIPAAIndicator = group.Add(new VocabularyKey(nameof(HIPAAIndicator), "HIPAA Indicator", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsDeceased = group.Add(new VocabularyKey(nameof(IsDeceased), "Is Deceased?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LastPermanentResidenceCountry = group.Add(new VocabularyKey(nameof(LastPermanentResidenceCountry), "Last Permanent Residence Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Legacy = group.Add(new VocabularyKey(nameof(Legacy), "Legacy", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MaidenName = group.Add(new VocabularyKey(nameof(MaidenName), "Maiden Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ManualRiskScore = group.Add(new VocabularyKey(nameof(ManualRiskScore), "Manual Risk Score", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MiltaryStatus = group.Add(new VocabularyKey(nameof(MiltaryStatus), "Miltary Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NationalIdentifier = group.Add(new VocabularyKey(nameof(NationalIdentifier), "National Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Nationality = group.Add(new VocabularyKey(nameof(Nationality), "Nationality", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Race = group.Add(new VocabularyKey(nameof(Race), "Race", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Contact Details for Banking", group =>
            {
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
            AddGroup("Contact Details for ElectronicMedicalRecords", group =>
            {
			    ActivityStartDate = group.Add(new VocabularyKey(nameof(ActivityStartDate), "Activity Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PeriodEndDate = group.Add(new VocabularyKey(nameof(Address1PeriodEndDate), "Permanent - Address Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PeriodStartDate = group.Add(new VocabularyKey(nameof(Address1PeriodStartDate), "Permanent- Address Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PeriodEndDate = group.Add(new VocabularyKey(nameof(Address2PeriodEndDate), "Current - Address Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PeriodStartDate = group.Add(new VocabularyKey(nameof(Address2PeriodStartDate), "Current - Address Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address3PeriodEndDate = group.Add(new VocabularyKey(nameof(Address3PeriodEndDate), "Billing  - Address Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address3PeriodStartDate = group.Add(new VocabularyKey(nameof(Address3PeriodStartDate), "Billing  - Address Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Animal = group.Add(new VocabularyKey(nameof(Animal), "Animal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Communication1Preferred = group.Add(new VocabularyKey(nameof(Communication1Preferred), "Primary Language Preferred", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Communication2Preferred = group.Add(new VocabularyKey(nameof(Communication2Preferred), "Secondary Language Preferred", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Contac1tEndDate = group.Add(new VocabularyKey(nameof(Contac1tEndDate), "Emergency Contact End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Contac2tEndDate = group.Add(new VocabularyKey(nameof(Contac2tEndDate), "Primary Contact End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Contact1StartDate = group.Add(new VocabularyKey(nameof(Contact1StartDate), "Emergency Contact Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Contact2StartDate = group.Add(new VocabularyKey(nameof(Contact2StartDate), "Primary Contact Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeceasedDate = group.Add(new VocabularyKey(nameof(DeceasedDate), "Deceased Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicalRecordNumber = group.Add(new VocabularyKey(nameof(MedicalRecordNumber), "Medical Record Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MultipleBirth = group.Add(new VocabularyKey(nameof(MultipleBirth), "Multiple Birth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name1EndDate = group.Add(new VocabularyKey(nameof(Name1EndDate), "Usual-Name End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name1StartDate = group.Add(new VocabularyKey(nameof(Name1StartDate), "Usual-Name Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name1Use = group.Add(new VocabularyKey(nameof(Name1Use), "Use of Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2 = group.Add(new VocabularyKey(nameof(Name2), "Official Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2EndDate = group.Add(new VocabularyKey(nameof(Name2EndDate), "Official-Name End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2FamilyName = group.Add(new VocabularyKey(nameof(Name2FamilyName), "Official- Family Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2GivenName = group.Add(new VocabularyKey(nameof(Name2GivenName), "Official - Given Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2Prefix = group.Add(new VocabularyKey(nameof(Name2Prefix), "Official- Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2StartDate = group.Add(new VocabularyKey(nameof(Name2StartDate), "Official-Name Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2Suffix = group.Add(new VocabularyKey(nameof(Name2Suffix), "Official- Suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2Use = group.Add(new VocabularyKey(nameof(Name2Use), "Use of Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3 = group.Add(new VocabularyKey(nameof(Name3), "Temporary Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3FamilyName = group.Add(new VocabularyKey(nameof(Name3FamilyName), "Official- Family Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3GivenName = group.Add(new VocabularyKey(nameof(Name3GivenName), "Official - Given Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3NameEndDate = group.Add(new VocabularyKey(nameof(Name3NameEndDate), "Official-Name End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3NameStartDate = group.Add(new VocabularyKey(nameof(Name3NameStartDate), "Official-Name Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3Prefix = group.Add(new VocabularyKey(nameof(Name3Prefix), "Official- Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3Suffix = group.Add(new VocabularyKey(nameof(Name3Suffix), "Official- Suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3Use = group.Add(new VocabularyKey(nameof(Name3Use), "Use of Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Qualification1Identifier = group.Add(new VocabularyKey(nameof(Qualification1Identifier), "Provider NPI Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Qualification1PeriodEndDate = group.Add(new VocabularyKey(nameof(Qualification1PeriodEndDate), "Qualification Expiry Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Qualification1PeriodStartDate = group.Add(new VocabularyKey(nameof(Qualification1PeriodStartDate), "Qualification Issue Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1EndDate = group.Add(new VocabularyKey(nameof(Telecom1EndDate), "Primary Day Time Phone End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1Rank = group.Add(new VocabularyKey(nameof(Telecom1Rank), "Rank of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Telecom1StartDate = group.Add(new VocabularyKey(nameof(Telecom1StartDate), "Primary Day Time Phone Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1System = group.Add(new VocabularyKey(nameof(Telecom1System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1Use = group.Add(new VocabularyKey(nameof(Telecom1Use), "Use of contact point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2EndDate = group.Add(new VocabularyKey(nameof(Telecom2EndDate), "Primary Evening Phone End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2Rank = group.Add(new VocabularyKey(nameof(Telecom2Rank), "Rank of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Telecom2StartDate = group.Add(new VocabularyKey(nameof(Telecom2StartDate), "Primary Evening Phone Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2System = group.Add(new VocabularyKey(nameof(Telecom2System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2Use = group.Add(new VocabularyKey(nameof(Telecom2Use), "Use of Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3EndDate = group.Add(new VocabularyKey(nameof(Telecom3EndDate), "Primary Email End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3Rank = group.Add(new VocabularyKey(nameof(Telecom3Rank), "Rank of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Telecom3StartDate = group.Add(new VocabularyKey(nameof(Telecom3StartDate), "Primary Email Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3System = group.Add(new VocabularyKey(nameof(Telecom3System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3Use = group.Add(new VocabularyKey(nameof(Telecom3Use), "Use of Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Contact Details for NonProfitCore", group =>
            {
			    Age = group.Add(new VocabularyKey(nameof(Age), "Age", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Anonymous = group.Add(new VocabularyKey(nameof(Anonymous), "Anonymous?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    BirthDay = group.Add(new VocabularyKey(nameof(BirthDay), "Birth Day", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BirthMonth = group.Add(new VocabularyKey(nameof(BirthMonth), "Birth Month", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BirthYear = group.Add(new VocabularyKey(nameof(BirthYear), "Birth Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ContactAccountNumber = group.Add(new VocabularyKey(nameof(ContactAccountNumber), "Contact Account Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Deceased = group.Add(new VocabularyKey(nameof(Deceased), "Deceased?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Ethnicity = group.Add(new VocabularyKey(nameof(Ethnicity), "Ethnicity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrimaryConstituentType = group.Add(new VocabularyKey(nameof(PrimaryConstituentType), "Primary Constituent Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Contact Details for NonProfitIati", group =>
            {

            });
            AddGroup("Contact Details for NonProfitVolunteers", group =>
            {

            });
            AddGroup("Contact Details for ProjectCommon", group =>
            {
			    GDPROptOut = group.Add(new VocabularyKey(nameof(GDPROptOut), "GDPR Optout", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Contact Details for Marketing", group =>
            {
			    RememberMe = group.Add(new VocabularyKey(nameof(RememberMe), "Remember me", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), "Insights", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PortalInvitationCode = group.Add(new VocabularyKey(nameof(PortalInvitationCode), "Portal Invitation Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PortalInvitationURL = group.Add(new VocabularyKey(nameof(PortalInvitationURL), "Portal Invitation URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Contact Details for Portals", group =>
            {
			    AdxCreatedByIPAddress = group.Add(new VocabularyKey(nameof(AdxCreatedByIPAddress), "Created By IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByUsername = group.Add(new VocabularyKey(nameof(AdxCreatedByUsername), "Created By Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByIPAddress = group.Add(new VocabularyKey(nameof(AdxModifiedByIPAddress), "Modified By IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByUsername = group.Add(new VocabularyKey(nameof(AdxModifiedByUsername), "Modified By Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxOrganizationName = group.Add(new VocabularyKey(nameof(AdxOrganizationName), "Organization Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxTimeZone = group.Add(new VocabularyKey(nameof(AdxTimeZone), "Time Zone", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    DisableWebTracking = group.Add(new VocabularyKey(nameof(DisableWebTracking), "Disable Web Tracking", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsMinorWithParentalConsent = group.Add(new VocabularyKey(nameof(IsMinorWithParentalConsent), "Is Minor with Parental Consent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    PortalTermsAgreementDate = group.Add(new VocabularyKey(nameof(PortalTermsAgreementDate), "Portal Terms Agreement Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProfileAlert = group.Add(new VocabularyKey(nameof(ProfileAlert), "Profile Alert", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ProfileAlertDate = group.Add(new VocabularyKey(nameof(ProfileAlertDate), "Profile Alert Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProfileAlertInstructions = group.Add(new VocabularyKey(nameof(ProfileAlertInstructions), "Profile Alert Instructions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxProfileIsAnonymous = group.Add(new VocabularyKey(nameof(AdxProfileIsAnonymous), "Profile Is Anonymous", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AdxProfileLastActivity = group.Add(new VocabularyKey(nameof(AdxProfileLastActivity), "Profile Last Activity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProfileModifiedOn = group.Add(new VocabularyKey(nameof(ProfileModifiedOn), "Profile Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PublicProfileCopy = group.Add(new VocabularyKey(nameof(PublicProfileCopy), "Public Profile Copy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AccessFailedCount = group.Add(new VocabularyKey(nameof(AccessFailedCount), "Access Failed Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    EmailConfirmed = group.Add(new VocabularyKey(nameof(EmailConfirmed), "Email Confirmed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LastSuccessfulLogin = group.Add(new VocabularyKey(nameof(LastSuccessfulLogin), "Last Successful Login", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LocalLoginDisabled = group.Add(new VocabularyKey(nameof(LocalLoginDisabled), "Local Login Disabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LockoutEnabled = group.Add(new VocabularyKey(nameof(LockoutEnabled), "Lockout Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LockoutEndDate = group.Add(new VocabularyKey(nameof(LockoutEndDate), "Lockout End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LoginEnabled = group.Add(new VocabularyKey(nameof(LoginEnabled), "Login Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MobilePhoneConfirmed = group.Add(new VocabularyKey(nameof(MobilePhoneConfirmed), "Mobile Phone Confirmed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    PasswordHash = group.Add(new VocabularyKey(nameof(PasswordHash), "Password Hash", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SecurityStamp = group.Add(new VocabularyKey(nameof(SecurityStamp), "Security Stamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TwoFactorEnabled = group.Add(new VocabularyKey(nameof(TwoFactorEnabled), "Two Factor Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    UserName = group.Add(new VocabularyKey(nameof(UserName), "User Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
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
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="PreferredSystemUserId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="MasterId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentCustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
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
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
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
            ///Property <see cref="PreferredSystemUserId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ContactId"/> from Vocab 'Account.cdm.json/Account' with Property 'PrimaryContactId'
            ///Property <see cref="ContactId"/> from Vocab 'Activity.cdm.json/Activity' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab 'ActivityParty.cdm.json/ActivityParty' with Property 'PartyId'
            ///Property <see cref="ContactId"/> from Vocab 'Address.cdm.json/Address' with Property 'ParentId'
            ///Property <see cref="ContactId"/> from Vocab 'Appointment.cdm.json/Appointment' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="ContactId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="ContactId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'MasterId'
            ///Property <see cref="ContactId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'ParentCustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'CustomerRelationship.cdm.json/CustomerRelationship' with Property 'PartnerId'
            ///Property <see cref="ContactId"/> from Vocab 'CustomerRelationship.cdm.json/CustomerRelationship' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'Email.cdm.json/Email' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab 'Email.cdm.json/Email' with Property 'EmailSender'
            ///Property <see cref="ContactId"/> from Vocab 'Fax.cdm.json/Fax' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab 'Feedback.cdm.json/Feedback' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab 'Feedback.cdm.json/Feedback' with Property 'CreatedByContact'
            ///Property <see cref="ContactId"/> from Vocab 'Feedback.cdm.json/Feedback' with Property 'CreatedOnBehalfByContact'
            ///Property <see cref="ContactId"/> from Vocab 'Letter.cdm.json/Letter' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab 'Note.cdm.json/Note' with Property 'ObjectId'
            ///Property <see cref="ContactId"/> from Vocab 'PhoneCall.cdm.json/PhoneCall' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab 'RecurringAppointment.cdm.json/RecurringAppointment' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab 'SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'Regarding'
            ///Property <see cref="ContactId"/> from Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'PostAuthorAccount'
            ///Property <see cref="ContactId"/> from Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'PostAuthor'
            ///Property <see cref="ContactId"/> from Vocab 'SocialProfile.cdm.json/SocialProfile' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/Lead.cdm.json/Lead' with Property 'ParentContactId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/Lead.cdm.json/Lead' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/AggregateKPIContext.cdm.json/AggregateKPIContext' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/BusinessOperationCustomerPreference.cdm.json/BusinessOperationCustomerPreference' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/CustomerIdentifier.cdm.json/CustomerIdentifier' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/DealCustomer.cdm.json/DealCustomer' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/DeviceRegistration.cdm.json/DeviceRegistration' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/FinancingOpportunity.cdm.json/FinancingOpportunity' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/Fleet.cdm.json/Fleet' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/FleetDevice.cdm.json/FleetDevice' with Property 'PrimaryContactId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/LeadProspect.cdm.json/LeadProspect' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/SalesContract.cdm.json/SalesContract' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/ServiceAppointment.cdm.json/ServiceAppointment' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/ServiceContract.cdm.json/ServiceContract' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/ServiceOrder.cdm.json/ServiceOrder' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/TestDrive.cdm.json/TestDrive' with Property 'ContactId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/TestDrive.cdm.json/TestDrive' with Property 'CustomerId'
            ///Property <see cref="ContactId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/TradeIn.cdm.json/TradeIn' with Property 'CustomerId'
            #endregion
        }

        public VocabularyKey AccessFailedCount { get; private set; }
        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey AccountRoleCode { get; private set; }
        public VocabularyKey ActivityStartDate { get; private set; }
        public VocabularyKey Address1PeriodEndDate { get; private set; }
        public VocabularyKey Address1PeriodStartDate { get; private set; }
        public VocabularyKey Address2PeriodEndDate { get; private set; }
        public VocabularyKey Address2PeriodStartDate { get; private set; }
        public VocabularyKey Address3PeriodEndDate { get; private set; }
        public VocabularyKey Address3PeriodStartDate { get; private set; }
        public VocabularyKey AdxCreatedByIPAddress { get; private set; }
        public VocabularyKey AdxCreatedByUsername { get; private set; }
        public VocabularyKey AdxModifiedByIPAddress { get; private set; }
        public VocabularyKey AdxModifiedByUsername { get; private set; }
        public VocabularyKey AdxOrganizationName { get; private set; }
        public VocabularyKey AdxProfileIsAnonymous { get; private set; }
        public VocabularyKey AdxProfileLastActivity { get; private set; }
        public VocabularyKey AdxTimeZone { get; private set; }
        public VocabularyKey Age { get; private set; }
        public VocabularyKey Aging30 { get; private set; }
        public VocabularyKey Aging30Base { get; private set; }
        public VocabularyKey Aging60 { get; private set; }
        public VocabularyKey Aging60Base { get; private set; }
        public VocabularyKey Aging90 { get; private set; }
        public VocabularyKey Aging90Base { get; private set; }
        public VocabularyKey Animal { get; private set; }
        public VocabularyKey Anniversary { get; private set; }
        public VocabularyKey AnnualIncome { get; private set; }
        public VocabularyKey AnnualIncomeBase { get; private set; }
        public VocabularyKey Anonymous { get; private set; }
        public VocabularyKey AssistantName { get; private set; }
        public VocabularyKey AssistantPhone { get; private set; }
        public VocabularyKey BillPay { get; private set; }
        public VocabularyKey BirthDate { get; private set; }
        public VocabularyKey BirthDay { get; private set; }
        public VocabularyKey BirthMonth { get; private set; }
        public VocabularyKey BirthYear { get; private set; }
        public VocabularyKey Business2 { get; private set; }
        public VocabularyKey Callback { get; private set; }
        public VocabularyKey ChargeStartDate { get; private set; }
        public VocabularyKey ChildrensNames { get; private set; }
        public VocabularyKey ChurnScore { get; private set; }
        public VocabularyKey Communication1Preferred { get; private set; }
        public VocabularyKey Communication2Preferred { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey Contac1tEndDate { get; private set; }
        public VocabularyKey Contac2tEndDate { get; private set; }
        public VocabularyKey Contact1StartDate { get; private set; }
        public VocabularyKey Contact2StartDate { get; private set; }
        public VocabularyKey ContactAccountNumber { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey ContactType { get; private set; }
        public VocabularyKey CountryofBirth { get; private set; }
        public VocabularyKey CreatedByExternalParty { get; private set; }
        public VocabularyKey CreditLimit { get; private set; }
        public VocabularyKey CreditLimitBase { get; private set; }
        public VocabularyKey CreditOnHold { get; private set; }
        public VocabularyKey CreditScore { get; private set; }
        public VocabularyKey CustomerSizeCode { get; private set; }
        public VocabularyKey CustomerTypeCode { get; private set; }
        public VocabularyKey DebtBurdenRatio { get; private set; }
        public VocabularyKey Deceased { get; private set; }
        public VocabularyKey DeceasedDate { get; private set; }
        public VocabularyKey DelinquencyScore { get; private set; }
        public VocabularyKey DelinquentAmount { get; private set; }
        public VocabularyKey DelinquentAmountBase { get; private set; }
        public VocabularyKey Department { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DirectDeposit { get; private set; }
        public VocabularyKey DisableWebTracking { get; private set; }
        public VocabularyKey DoNotBulkEMail { get; private set; }
        public VocabularyKey DoNotBulkPostalMail { get; private set; }
        public VocabularyKey DoNotEMail { get; private set; }
        public VocabularyKey DoNotFax { get; private set; }
        public VocabularyKey DoNotPhone { get; private set; }
        public VocabularyKey DoNotPostalMail { get; private set; }
        public VocabularyKey DoNotSendMM { get; private set; }
        public VocabularyKey EducationCode { get; private set; }
        public VocabularyKey EMailAddress1 { get; private set; }
        public VocabularyKey EMailAddress2 { get; private set; }
        public VocabularyKey EMailAddress3 { get; private set; }
        public VocabularyKey EmailConfirmed { get; private set; }
        public VocabularyKey EmployeeId { get; private set; }
        public VocabularyKey EmploymentStatus { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey EthnicGroup { get; private set; }
        public VocabularyKey Ethnicity { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExternalIdentifier { get; private set; }
        public VocabularyKey ExternalSourceSystem { get; private set; }
        public VocabularyKey ExternalUserIdentifier { get; private set; }
        public VocabularyKey FamilyStatusCode { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey FERPAPrivacy { get; private set; }
        public VocabularyKey FirstGeneration { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey FollowEmail { get; private set; }
        public VocabularyKey FtpSiteUrl { get; private set; }
        public VocabularyKey FullName { get; private set; }
        public VocabularyKey GDPROptOut { get; private set; }
        public VocabularyKey GenderCode { get; private set; }
        public VocabularyKey GovernmentId { get; private set; }
        public VocabularyKey HasChildrenCode { get; private set; }
        public VocabularyKey HIPAAIndicator { get; private set; }
        public VocabularyKey Home2 { get; private set; }
        public VocabularyKey IDExpiryDate { get; private set; }
        public VocabularyKey IDType { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey IsBackofficeCustomer { get; private set; }
        public VocabularyKey IsDeceased { get; private set; }
        public VocabularyKey IsMinor { get; private set; }
        public VocabularyKey IsMinorWithParentalConsent { get; private set; }
        public VocabularyKey JobTitle { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey LastPermanentResidenceCountry { get; private set; }
        public VocabularyKey LastSuccessfulLogin { get; private set; }
        public VocabularyKey LastUsedInCampaign { get; private set; }
        public VocabularyKey LeadSourceCode { get; private set; }
        public VocabularyKey Legacy { get; private set; }
        public VocabularyKey LocalLoginDisabled { get; private set; }
        public VocabularyKey LockoutEnabled { get; private set; }
        public VocabularyKey LockoutEndDate { get; private set; }
        public VocabularyKey LoginEnabled { get; private set; }
        public VocabularyKey MaidenName { get; private set; }
        public VocabularyKey ManagerName { get; private set; }
        public VocabularyKey ManagerPhone { get; private set; }
        public VocabularyKey ManualRiskScore { get; private set; }
        public VocabularyKey MarketingOnly { get; private set; }
        public VocabularyKey MedicalRecordNumber { get; private set; }
        public VocabularyKey Merged { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey MiltaryStatus { get; private set; }
        public VocabularyKey MobilePhone { get; private set; }
        public VocabularyKey MobilePhoneConfirmed { get; private set; }
        public VocabularyKey ModifiedByExternalParty { get; private set; }
        public VocabularyKey MonthlyIncome { get; private set; }
        public VocabularyKey MonthlyIncomeBase { get; private set; }
        public VocabularyKey MonthlyLiabilities { get; private set; }
        public VocabularyKey MonthlyLiabilitiesBase { get; private set; }
        public VocabularyKey MultipleBirth { get; private set; }
        public VocabularyKey Name1EndDate { get; private set; }
        public VocabularyKey Name1StartDate { get; private set; }
        public VocabularyKey Name1Use { get; private set; }
        public VocabularyKey Name2 { get; private set; }
        public VocabularyKey Name2EndDate { get; private set; }
        public VocabularyKey Name2FamilyName { get; private set; }
        public VocabularyKey Name2GivenName { get; private set; }
        public VocabularyKey Name2Prefix { get; private set; }
        public VocabularyKey Name2StartDate { get; private set; }
        public VocabularyKey Name2Suffix { get; private set; }
        public VocabularyKey Name2Use { get; private set; }
        public VocabularyKey Name3 { get; private set; }
        public VocabularyKey Name3FamilyName { get; private set; }
        public VocabularyKey Name3GivenName { get; private set; }
        public VocabularyKey Name3NameEndDate { get; private set; }
        public VocabularyKey Name3NameStartDate { get; private set; }
        public VocabularyKey Name3Prefix { get; private set; }
        public VocabularyKey Name3Suffix { get; private set; }
        public VocabularyKey Name3Use { get; private set; }
        public VocabularyKey NationalIdentifier { get; private set; }
        public VocabularyKey Nationality { get; private set; }
        public VocabularyKey NickName { get; private set; }
        public VocabularyKey NumberOfChildren { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey Pager { get; private set; }
        public VocabularyKey ParentContactId { get; private set; }
        public VocabularyKey ParticipatesInWorkflow { get; private set; }
        public VocabularyKey PasswordHash { get; private set; }
        public VocabularyKey PaymentTermsCode { get; private set; }
        public VocabularyKey PlaceOfBirth { get; private set; }
        public VocabularyKey PortalInvitationCode { get; private set; }
        public VocabularyKey PortalInvitationURL { get; private set; }
        public VocabularyKey PortalTermsAgreementDate { get; private set; }
        public VocabularyKey PreferredAppointmentDayCode { get; private set; }
        public VocabularyKey PreferredAppointmentTimeCode { get; private set; }
        public VocabularyKey PreferredContactMethodCode { get; private set; }
        public VocabularyKey PrimaryConstituentType { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey ProfileAlert { get; private set; }
        public VocabularyKey ProfileAlertDate { get; private set; }
        public VocabularyKey ProfileAlertInstructions { get; private set; }
        public VocabularyKey ProfileModifiedOn { get; private set; }
        public VocabularyKey ProfitTier { get; private set; }
        public VocabularyKey PublicProfileCopy { get; private set; }
        public VocabularyKey Qualification1Identifier { get; private set; }
        public VocabularyKey Qualification1PeriodEndDate { get; private set; }
        public VocabularyKey Qualification1PeriodStartDate { get; private set; }
        public VocabularyKey Race { get; private set; }
        public VocabularyKey RememberMe { get; private set; }
        public VocabularyKey ResidencyStatus { get; private set; }
        public VocabularyKey ResidentInCountrySince { get; private set; }
        public VocabularyKey Salutation { get; private set; }
        public VocabularyKey SecurityStamp { get; private set; }
        public VocabularyKey ShippingMethodCode { get; private set; }
        public VocabularyKey SpousesName { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Suffix { get; private set; }
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
        public VocabularyKey TimeSpentByMeOnEmailAndMeetings { get; private set; }
        public VocabularyKey TotalDeposits { get; private set; }
        public VocabularyKey TotalDepositsBase { get; private set; }
        public VocabularyKey TotalLoans { get; private set; }
        public VocabularyKey TotalLoansBase { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey TwoFactorEnabled { get; private set; }
        public VocabularyKey UserName { get; private set; }
        public VocabularyKey VisaExpiry { get; private set; }
        public VocabularyKey WaiveCharges { get; private set; }
        public VocabularyKey WebSiteUrl { get; private set; }
        public VocabularyKey YomiFirstName { get; private set; }
        public VocabularyKey YomiFullName { get; private set; }
        public VocabularyKey YomiLastName { get; private set; }
        public VocabularyKey YomiMiddleName { get; private set; }
    }
}