using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class UserVocabulary : SimpleVocabulary
    {
        public UserVocabulary()
        {
            VocabularyName = "User";
            KeyPrefix = "commonDataModel.user.applicationcommon";
            KeySeparator = ".";
            Grouping = "/User";

            AddGroup("User Details for ApplicationCommon", group =>
            {
			    SystemUserId = group.Add(new VocabularyKey(nameof(SystemUserId), "User", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FirstName = group.Add(new VocabularyKey(nameof(FirstName), "First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Salutation = group.Add(new VocabularyKey(nameof(Salutation), "Salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), "Middle Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastName = group.Add(new VocabularyKey(nameof(LastName), "Last Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PersonalEMailAddress = group.Add(new VocabularyKey(nameof(PersonalEMailAddress), "Email 2", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    FullName = group.Add(new VocabularyKey(nameof(FullName), "Full Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NickName = group.Add(new VocabularyKey(nameof(NickName), "Nickname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InternalEMailAddress = group.Add(new VocabularyKey(nameof(InternalEMailAddress), "Primary Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    JobTitle = group.Add(new VocabularyKey(nameof(JobTitle), "Job Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MobileAlertEMail = group.Add(new VocabularyKey(nameof(MobileAlertEMail), "Mobile Alert Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    PreferredEmailCode = group.Add(new VocabularyKey(nameof(PreferredEmailCode), "Preferred Email", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HomePhone = group.Add(new VocabularyKey(nameof(HomePhone), "Home Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    MobilePhone = group.Add(new VocabularyKey(nameof(MobilePhone), "Mobile Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    PreferredPhoneCode = group.Add(new VocabularyKey(nameof(PreferredPhoneCode), "Preferred Phone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PreferredAddressCode = group.Add(new VocabularyKey(nameof(PreferredAddressCode), "Preferred Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PhotoUrl = group.Add(new VocabularyKey(nameof(PhotoUrl), "Photo URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    DomainName = group.Add(new VocabularyKey(nameof(DomainName), "User Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PassportLo = group.Add(new VocabularyKey(nameof(PassportLo), "Passport Lo", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PassportHi = group.Add(new VocabularyKey(nameof(PassportHi), "Passport Hi", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DisabledReason = group.Add(new VocabularyKey(nameof(DisabledReason), "Disabled Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmployeeId = group.Add(new VocabularyKey(nameof(EmployeeId), "Employee", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsDisabled = group.Add(new VocabularyKey(nameof(IsDisabled), "Status", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    GovernmentId = group.Add(new VocabularyKey(nameof(GovernmentId), "Government", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1AddressId = group.Add(new VocabularyKey(nameof(Address1AddressId), "Address 1: ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1AddressTypeCode = group.Add(new VocabularyKey(nameof(Address1AddressTypeCode), "Address 1: Address Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Name = group.Add(new VocabularyKey(nameof(Address1Name), "Address 1: Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Line1 = group.Add(new VocabularyKey(nameof(Address1Line1), "Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Line2 = group.Add(new VocabularyKey(nameof(Address1Line2), "Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Line3 = group.Add(new VocabularyKey(nameof(Address1Line3), "Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1City = group.Add(new VocabularyKey(nameof(Address1City), "City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1StateOrProvince = group.Add(new VocabularyKey(nameof(Address1StateOrProvince), "State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1County = group.Add(new VocabularyKey(nameof(Address1County), "Address 1: County", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address1Country = group.Add(new VocabularyKey(nameof(Address1Country), "Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address1PostOfficeBox = group.Add(new VocabularyKey(nameof(Address1PostOfficeBox), "Address 1: Post Office Box", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PostalCode = group.Add(new VocabularyKey(nameof(Address1PostalCode), "ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1UTCOffset = group.Add(new VocabularyKey(nameof(Address1UTCOffset), "Address 1: UTC Offset", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    Address1UPSZone = group.Add(new VocabularyKey(nameof(Address1UPSZone), "Address 1: UPS Zone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Latitude = group.Add(new VocabularyKey(nameof(Address1Latitude), "Address 1: Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Telephone1 = group.Add(new VocabularyKey(nameof(Address1Telephone1), "Main Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address1Longitude = group.Add(new VocabularyKey(nameof(Address1Longitude), "Address 1: Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1ShippingMethodCode = group.Add(new VocabularyKey(nameof(Address1ShippingMethodCode), "Address 1: Shipping Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Telephone2 = group.Add(new VocabularyKey(nameof(Address1Telephone2), "Other Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address1Telephone3 = group.Add(new VocabularyKey(nameof(Address1Telephone3), "Pager", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address1Fax = group.Add(new VocabularyKey(nameof(Address1Fax), "Address 1: Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2AddressId = group.Add(new VocabularyKey(nameof(Address2AddressId), "Address 2: ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2AddressTypeCode = group.Add(new VocabularyKey(nameof(Address2AddressTypeCode), "Address 2: Address Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Name = group.Add(new VocabularyKey(nameof(Address2Name), "Address 2: Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Line1 = group.Add(new VocabularyKey(nameof(Address2Line1), "Other Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Line2 = group.Add(new VocabularyKey(nameof(Address2Line2), "Other Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Line3 = group.Add(new VocabularyKey(nameof(Address2Line3), "Other Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2City = group.Add(new VocabularyKey(nameof(Address2City), "Other City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2StateOrProvince = group.Add(new VocabularyKey(nameof(Address2StateOrProvince), "Other State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2County = group.Add(new VocabularyKey(nameof(Address2County), "Address 2: County", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address2Country = group.Add(new VocabularyKey(nameof(Address2Country), "Other Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Address2PostOfficeBox = group.Add(new VocabularyKey(nameof(Address2PostOfficeBox), "Address 2: Post Office Box", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PostalCode = group.Add(new VocabularyKey(nameof(Address2PostalCode), "Other ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2UTCOffset = group.Add(new VocabularyKey(nameof(Address2UTCOffset), "Address 2: UTC Offset", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    Address2UPSZone = group.Add(new VocabularyKey(nameof(Address2UPSZone), "Address 2: UPS Zone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Latitude = group.Add(new VocabularyKey(nameof(Address2Latitude), "Address 2: Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Telephone1 = group.Add(new VocabularyKey(nameof(Address2Telephone1), "Address 2: Telephone 1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address2Longitude = group.Add(new VocabularyKey(nameof(Address2Longitude), "Address 2: Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2ShippingMethodCode = group.Add(new VocabularyKey(nameof(Address2ShippingMethodCode), "Address 2: Shipping Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2Telephone2 = group.Add(new VocabularyKey(nameof(Address2Telephone2), "Address 2: Telephone 2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address2Telephone3 = group.Add(new VocabularyKey(nameof(Address2Telephone3), "Address 2: Telephone 3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    Address2Fax = group.Add(new VocabularyKey(nameof(Address2Fax), "Address 2: Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Skills = group.Add(new VocabularyKey(nameof(Skills), "Skills", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisplayInServiceViews = group.Add(new VocabularyKey(nameof(DisplayInServiceViews), "Display in Service Views", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), "Calendar", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SetupUser = group.Add(new VocabularyKey(nameof(SetupUser), "Restricted Access Mode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    WindowsLiveID = group.Add(new VocabularyKey(nameof(WindowsLiveID), "Windows Live ID", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    IncomingEmailDeliveryMethod = group.Add(new VocabularyKey(nameof(IncomingEmailDeliveryMethod), "Incoming Email Delivery Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OutgoingEmailDeliveryMethod = group.Add(new VocabularyKey(nameof(OutgoingEmailDeliveryMethod), "Outgoing Email Delivery Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AccessMode = group.Add(new VocabularyKey(nameof(AccessMode), "Access Mode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InviteStatusCode = group.Add(new VocabularyKey(nameof(InviteStatusCode), "Invitation Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    YomiFullName = group.Add(new VocabularyKey(nameof(YomiFullName), "Yomi Full Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YomiLastName = group.Add(new VocabularyKey(nameof(YomiLastName), "Yomi Last Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YomiMiddleName = group.Add(new VocabularyKey(nameof(YomiMiddleName), "Yomi Middle Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YomiFirstName = group.Add(new VocabularyKey(nameof(YomiFirstName), "Yomi First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsIntegrationUser = group.Add(new VocabularyKey(nameof(IsIntegrationUser), "Integration user mode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DefaultFiltersPopulated = group.Add(new VocabularyKey(nameof(DefaultFiltersPopulated), "Default Filters Populated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EmailRouterAccessApproval = group.Add(new VocabularyKey(nameof(EmailRouterAccessApproval), "Primary Email Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CALType = group.Add(new VocabularyKey(nameof(CALType), "License Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsLicensed = group.Add(new VocabularyKey(nameof(IsLicensed), "User Licensed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsSyncWithDirectory = group.Add(new VocabularyKey(nameof(IsSyncWithDirectory), "User Synced", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    YammerEmailAddress = group.Add(new VocabularyKey(nameof(YammerEmailAddress), "Yammer Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    YammerUserId = group.Add(new VocabularyKey(nameof(YammerUserId), "Yammer User ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DefaultMailbox = group.Add(new VocabularyKey(nameof(DefaultMailbox), "Mailbox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UserLicenseType = group.Add(new VocabularyKey(nameof(UserLicenseType), "User License Type", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), "Entity Image Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    Address2Composite = group.Add(new VocabularyKey(nameof(Address2Composite), "Other Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1Composite = group.Add(new VocabularyKey(nameof(Address1Composite), "Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Process Stage", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    IsEmailAddressApprovedByO365Admin = group.Add(new VocabularyKey(nameof(IsEmailAddressApprovedByO365Admin), "Email Address O365 Admin Approval Status", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SharePointEmailAddress = group.Add(new VocabularyKey(nameof(SharePointEmailAddress), "SharePoint Email Address", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    MobileOfflineProfileId = group.Add(new VocabularyKey(nameof(MobileOfflineProfileId), "Mobile Offline Profile", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DefaultOdbFolderName = group.Add(new VocabularyKey(nameof(DefaultOdbFolderName), "Default OneDrive for Business Folder Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ApplicationId = group.Add(new VocabularyKey(nameof(ApplicationId), "Application ID", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    ApplicationIdUri = group.Add(new VocabularyKey(nameof(ApplicationIdUri), "Application ID URI", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AzureActiveDirectoryObjectId = group.Add(new VocabularyKey(nameof(AzureActiveDirectoryObjectId), "Azure AD Object ID", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    IdentityId = group.Add(new VocabularyKey(nameof(IdentityId), "Unique user identity id", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SystemUserId { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey Salutation { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey PersonalEMailAddress { get; private set; }
        public VocabularyKey FullName { get; private set; }
        public VocabularyKey NickName { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey InternalEMailAddress { get; private set; }
        public VocabularyKey JobTitle { get; private set; }
        public VocabularyKey MobileAlertEMail { get; private set; }
        public VocabularyKey PreferredEmailCode { get; private set; }
        public VocabularyKey HomePhone { get; private set; }
        public VocabularyKey MobilePhone { get; private set; }
        public VocabularyKey PreferredPhoneCode { get; private set; }
        public VocabularyKey PreferredAddressCode { get; private set; }
        public VocabularyKey PhotoUrl { get; private set; }
        public VocabularyKey DomainName { get; private set; }
        public VocabularyKey PassportLo { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey PassportHi { get; private set; }
        public VocabularyKey DisabledReason { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey EmployeeId { get; private set; }
        public VocabularyKey IsDisabled { get; private set; }
        public VocabularyKey GovernmentId { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey Address1AddressId { get; private set; }
        public VocabularyKey Address1AddressTypeCode { get; private set; }
        public VocabularyKey Address1Name { get; private set; }
        public VocabularyKey Address1Line1 { get; private set; }
        public VocabularyKey Address1Line2 { get; private set; }
        public VocabularyKey Address1Line3 { get; private set; }
        public VocabularyKey Address1City { get; private set; }
        public VocabularyKey Address1StateOrProvince { get; private set; }
        public VocabularyKey Address1County { get; private set; }
        public VocabularyKey Address1Country { get; private set; }
        public VocabularyKey Address1PostOfficeBox { get; private set; }
        public VocabularyKey Address1PostalCode { get; private set; }
        public VocabularyKey Address1UTCOffset { get; private set; }
        public VocabularyKey Address1UPSZone { get; private set; }
        public VocabularyKey Address1Latitude { get; private set; }
        public VocabularyKey Address1Telephone1 { get; private set; }
        public VocabularyKey Address1Longitude { get; private set; }
        public VocabularyKey Address1ShippingMethodCode { get; private set; }
        public VocabularyKey Address1Telephone2 { get; private set; }
        public VocabularyKey Address1Telephone3 { get; private set; }
        public VocabularyKey Address1Fax { get; private set; }
        public VocabularyKey Address2AddressId { get; private set; }
        public VocabularyKey Address2AddressTypeCode { get; private set; }
        public VocabularyKey Address2Name { get; private set; }
        public VocabularyKey Address2Line1 { get; private set; }
        public VocabularyKey Address2Line2 { get; private set; }
        public VocabularyKey Address2Line3 { get; private set; }
        public VocabularyKey Address2City { get; private set; }
        public VocabularyKey Address2StateOrProvince { get; private set; }
        public VocabularyKey Address2County { get; private set; }
        public VocabularyKey Address2Country { get; private set; }
        public VocabularyKey Address2PostOfficeBox { get; private set; }
        public VocabularyKey Address2PostalCode { get; private set; }
        public VocabularyKey Address2UTCOffset { get; private set; }
        public VocabularyKey Address2UPSZone { get; private set; }
        public VocabularyKey Address2Latitude { get; private set; }
        public VocabularyKey Address2Telephone1 { get; private set; }
        public VocabularyKey Address2Longitude { get; private set; }
        public VocabularyKey Address2ShippingMethodCode { get; private set; }
        public VocabularyKey Address2Telephone2 { get; private set; }
        public VocabularyKey Address2Telephone3 { get; private set; }
        public VocabularyKey Address2Fax { get; private set; }
        public VocabularyKey Skills { get; private set; }
        public VocabularyKey DisplayInServiceViews { get; private set; }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey SetupUser { get; private set; }
        public VocabularyKey WindowsLiveID { get; private set; }
        public VocabularyKey IncomingEmailDeliveryMethod { get; private set; }
        public VocabularyKey OutgoingEmailDeliveryMethod { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey AccessMode { get; private set; }
        public VocabularyKey InviteStatusCode { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey YomiFullName { get; private set; }
        public VocabularyKey YomiLastName { get; private set; }
        public VocabularyKey YomiMiddleName { get; private set; }
        public VocabularyKey YomiFirstName { get; private set; }
        public VocabularyKey IsIntegrationUser { get; private set; }
        public VocabularyKey DefaultFiltersPopulated { get; private set; }
        public VocabularyKey EmailRouterAccessApproval { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CALType { get; private set; }
        public VocabularyKey IsLicensed { get; private set; }
        public VocabularyKey IsSyncWithDirectory { get; private set; }
        public VocabularyKey YammerEmailAddress { get; private set; }
        public VocabularyKey YammerUserId { get; private set; }
        public VocabularyKey DefaultMailbox { get; private set; }
        public VocabularyKey UserLicenseType { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey Address2Composite { get; private set; }
        public VocabularyKey Address1Composite { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey IsEmailAddressApprovedByO365Admin { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey SharePointEmailAddress { get; private set; }
        public VocabularyKey MobileOfflineProfileId { get; private set; }
        public VocabularyKey DefaultOdbFolderName { get; private set; }
        public VocabularyKey ApplicationId { get; private set; }
        public VocabularyKey ApplicationIdUri { get; private set; }
        public VocabularyKey AzureActiveDirectoryObjectId { get; private set; }
        public VocabularyKey IdentityId { get; private set; }
    }
}