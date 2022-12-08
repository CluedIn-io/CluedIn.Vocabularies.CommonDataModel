using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ApplicationCommon
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact.applicationcommon";
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

        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey CustomerSizeCode { get; private set; }
        public VocabularyKey CustomerTypeCode { get; private set; }
        public VocabularyKey PreferredContactMethodCode { get; private set; }
        public VocabularyKey LeadSourceCode { get; private set; }
        public VocabularyKey PaymentTermsCode { get; private set; }
        public VocabularyKey ShippingMethodCode { get; private set; }
        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey ParticipatesInWorkflow { get; private set; }
        public VocabularyKey IsBackofficeCustomer { get; private set; }
        public VocabularyKey Salutation { get; private set; }
        public VocabularyKey JobTitle { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey Department { get; private set; }
        public VocabularyKey NickName { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey Suffix { get; private set; }
        public VocabularyKey YomiFirstName { get; private set; }
        public VocabularyKey FullName { get; private set; }
        public VocabularyKey YomiMiddleName { get; private set; }
        public VocabularyKey YomiLastName { get; private set; }
        public VocabularyKey Anniversary { get; private set; }
        public VocabularyKey BirthDate { get; private set; }
        public VocabularyKey GovernmentId { get; private set; }
        public VocabularyKey YomiFullName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EmployeeId { get; private set; }
        public VocabularyKey GenderCode { get; private set; }
        public VocabularyKey AnnualIncome { get; private set; }
        public VocabularyKey HasChildrenCode { get; private set; }
        public VocabularyKey EducationCode { get; private set; }
        public VocabularyKey WebSiteUrl { get; private set; }
        public VocabularyKey FamilyStatusCode { get; private set; }
        public VocabularyKey FtpSiteUrl { get; private set; }
        public VocabularyKey EMailAddress1 { get; private set; }
        public VocabularyKey SpousesName { get; private set; }
        public VocabularyKey AssistantName { get; private set; }
        public VocabularyKey EMailAddress2 { get; private set; }
        public VocabularyKey AssistantPhone { get; private set; }
        public VocabularyKey EMailAddress3 { get; private set; }
        public VocabularyKey DoNotPhone { get; private set; }
        public VocabularyKey ManagerName { get; private set; }
        public VocabularyKey ManagerPhone { get; private set; }
        public VocabularyKey DoNotFax { get; private set; }
        public VocabularyKey DoNotEMail { get; private set; }
        public VocabularyKey DoNotPostalMail { get; private set; }
        public VocabularyKey DoNotBulkEMail { get; private set; }
        public VocabularyKey DoNotBulkPostalMail { get; private set; }
        public VocabularyKey AccountRoleCode { get; private set; }
        public VocabularyKey TerritoryCode { get; private set; }
        public VocabularyKey CreditLimit { get; private set; }
        public VocabularyKey CreditOnHold { get; private set; }
        public VocabularyKey NumberOfChildren { get; private set; }
        public VocabularyKey ChildrensNames { get; private set; }
        public VocabularyKey MobilePhone { get; private set; }
        public VocabularyKey Pager { get; private set; }
        public VocabularyKey Telephone1 { get; private set; }
        public VocabularyKey Telephone2 { get; private set; }
        public VocabularyKey Telephone3 { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey Aging30 { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Aging60 { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Aging90 { get; private set; }
        public VocabularyKey ParentContactId { get; private set; }
        public VocabularyKey PreferredAppointmentDayCode { get; private set; }
        public VocabularyKey PreferredAppointmentTimeCode { get; private set; }
        public VocabularyKey DoNotSendMM { get; private set; }
        public VocabularyKey Merged { get; private set; }
        public VocabularyKey ExternalUserIdentifier { get; private set; }
        public VocabularyKey LastUsedInCampaign { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AnnualIncomeBase { get; private set; }
        public VocabularyKey CreditLimitBase { get; private set; }
        public VocabularyKey Aging60Base { get; private set; }
        public VocabularyKey Aging90Base { get; private set; }
        public VocabularyKey Aging30Base { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey FollowEmail { get; private set; }
        public VocabularyKey TimeSpentByMeOnEmailAndMeetings { get; private set; }
        public VocabularyKey Business2 { get; private set; }
        public VocabularyKey Callback { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey Home2 { get; private set; }
        public VocabularyKey CreatedByExternalParty { get; private set; }
        public VocabularyKey ModifiedByExternalParty { get; private set; }
        public VocabularyKey MarketingOnly { get; private set; }
    }
}