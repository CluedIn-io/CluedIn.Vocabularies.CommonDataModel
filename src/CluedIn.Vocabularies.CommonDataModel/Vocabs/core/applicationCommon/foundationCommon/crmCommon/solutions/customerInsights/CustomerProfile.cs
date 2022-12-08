using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.CustomerInsights
{
    public class CustomerProfileVocabulary : SimpleVocabulary
    {
        public CustomerProfileVocabulary()
        {
            VocabularyName = "Customer Profile";
            KeyPrefix = "commonDataModel.customerprofile.customerinsights";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.CustomerProfile;

            AddGroup("CustomerProfile Details for CustomerInsights", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AccountNumber = group.Add(new VocabularyKey(nameof(AccountNumber), "Account Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Affiliations = group.Add(new VocabularyKey(nameof(Affiliations), "Affiliations", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AlumniOf = group.Add(new VocabularyKey(nameof(AlumniOf), "Alumni Of", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Anniversary = group.Add(new VocabularyKey(nameof(Anniversary), "Anniversary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AssistantName = group.Add(new VocabularyKey(nameof(AssistantName), "Assistant Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Awards = group.Add(new VocabularyKey(nameof(Awards), "Awards", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingAddress = group.Add(new VocabularyKey(nameof(BillingAddress), "Billing Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BirthDate = group.Add(new VocabularyKey(nameof(BirthDate), "Birthday", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ChildrenNames = group.Add(new VocabularyKey(nameof(ChildrenNames), "Children Names", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ChurnScore = group.Add(new VocabularyKey(nameof(ChurnScore), "Churn Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CompanyName = group.Add(new VocabularyKey(nameof(CompanyName), "Company Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CountryOrRegion = group.Add(new VocabularyKey(nameof(CountryOrRegion), "Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    Culture = group.Add(new VocabularyKey(nameof(Culture), "Culture", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CurrencyName = group.Add(new VocabularyKey(nameof(CurrencyName), "Currency Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerProfileId = group.Add(new VocabularyKey(nameof(CustomerProfileId), "CustomerProfile", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Department = group.Add(new VocabularyKey(nameof(Department), "Department", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DonotBulkEmail = group.Add(new VocabularyKey(nameof(DonotBulkEmail), "Do not allow Bulk Emails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotBulkPostalMail = group.Add(new VocabularyKey(nameof(DoNotBulkPostalMail), "Do not allow Bulk Postal Mails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotContact = group.Add(new VocabularyKey(nameof(DoNotContact), "Do not Contact", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotEmail = group.Add(new VocabularyKey(nameof(DoNotEmail), "Do not allow Emails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotFax = group.Add(new VocabularyKey(nameof(DoNotFax), "Do not allow Faxes", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotPhone = group.Add(new VocabularyKey(nameof(DoNotPhone), "Do not allow Phone Calls", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DoNotPostalMail = group.Add(new VocabularyKey(nameof(DoNotPostalMail), "Do not allow Postal Mails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EducationCode = group.Add(new VocabularyKey(nameof(EducationCode), "Education Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmployeeIdentifier = group.Add(new VocabularyKey(nameof(EmployeeIdentifier), "Employee Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmploymentStartDate = group.Add(new VocabularyKey(nameof(EmploymentStartDate), "Employment Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EngagementScore = group.Add(new VocabularyKey(nameof(EngagementScore), "Engagement Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    FacebookProfile = group.Add(new VocabularyKey(nameof(FacebookProfile), "Facebook Profile", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FamilyStatus = group.Add(new VocabularyKey(nameof(FamilyStatus), "Family Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Fax = group.Add(new VocabularyKey(nameof(Fax), "Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FirstName = group.Add(new VocabularyKey(nameof(FirstName), "First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FirstNamePronunciation = group.Add(new VocabularyKey(nameof(FirstNamePronunciation), "First Name Pronunciation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FraudScore = group.Add(new VocabularyKey(nameof(FraudScore), "Fraud Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    FTPSiteUrl = group.Add(new VocabularyKey(nameof(FTPSiteUrl), "FTP Site Url", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    GamerTag = group.Add(new VocabularyKey(nameof(GamerTag), "GamerTag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Gender = group.Add(new VocabularyKey(nameof(Gender), "Gender", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HasChildren = group.Add(new VocabularyKey(nameof(HasChildren), "Has Children", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    HasPets = group.Add(new VocabularyKey(nameof(HasPets), "Has Pets", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Hobbies = group.Add(new VocabularyKey(nameof(Hobbies), "Hobbies", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HomeOwnershipType = group.Add(new VocabularyKey(nameof(HomeOwnershipType), "Home Ownership Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HomePhone = group.Add(new VocabularyKey(nameof(HomePhone), "Home Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    IndustryCode = group.Add(new VocabularyKey(nameof(IndustryCode), "Industry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InfluencerScore = group.Add(new VocabularyKey(nameof(InfluencerScore), "Influencer Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    InstagramHandle = group.Add(new VocabularyKey(nameof(InstagramHandle), "Instagram Handle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Interests = group.Add(new VocabularyKey(nameof(Interests), "Interests", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsGovernment = group.Add(new VocabularyKey(nameof(IsGovernment), "Is Government", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsLead = group.Add(new VocabularyKey(nameof(IsLead), "Is Lead", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsPublicSector = group.Add(new VocabularyKey(nameof(IsPublicSector), "Is Public Sector", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    JobTitle = group.Add(new VocabularyKey(nameof(JobTitle), "Job Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    KnownSince = group.Add(new VocabularyKey(nameof(KnownSince), "Known Since", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Language = group.Add(new VocabularyKey(nameof(Language), "Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastName = group.Add(new VocabularyKey(nameof(LastName), "Last Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastNamePronunciation = group.Add(new VocabularyKey(nameof(LastNamePronunciation), "Last Name Pronunciation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LifeTimeValue = group.Add(new VocabularyKey(nameof(LifeTimeValue), "Life Time Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    LinkedInProfile = group.Add(new VocabularyKey(nameof(LinkedInProfile), "LinkedIn Profile", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MailingAddress = group.Add(new VocabularyKey(nameof(MailingAddress), "Mailing Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), "Middle Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MiddleNamePronunciation = group.Add(new VocabularyKey(nameof(MiddleNamePronunciation), "Middle Name Pronunciation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MobilePhone = group.Add(new VocabularyKey(nameof(MobilePhone), "Mobile Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    NameAlias = group.Add(new VocabularyKey(nameof(NameAlias), "Name Alias", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NamePrefix = group.Add(new VocabularyKey(nameof(NamePrefix), "Name Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NameSuffix = group.Add(new VocabularyKey(nameof(NameSuffix), "Name Suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Nationality = group.Add(new VocabularyKey(nameof(Nationality), "Nationality", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NickName = group.Add(new VocabularyKey(nameof(NickName), "Nick Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Notes = group.Add(new VocabularyKey(nameof(Notes), "Notes", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfChildren = group.Add(new VocabularyKey(nameof(NumberOfChildren), "Number of children", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    PinterestId = group.Add(new VocabularyKey(nameof(PinterestId), "Pinterest Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    POBoxAddress = group.Add(new VocabularyKey(nameof(POBoxAddress), "PO Box Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostalCode = group.Add(new VocabularyKey(nameof(PostalCode), "Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PreferredCallTime = group.Add(new VocabularyKey(nameof(PreferredCallTime), "Preferred Call Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PreferredContactMethodCode = group.Add(new VocabularyKey(nameof(PreferredContactMethodCode), "Preferred Method of Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PreferredName = group.Add(new VocabularyKey(nameof(PreferredName), "Preferred Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrimaryEmail = group.Add(new VocabularyKey(nameof(PrimaryEmail), "Primary Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    PrimaryPhone = group.Add(new VocabularyKey(nameof(PrimaryPhone), "Primary Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    ProfileImage = group.Add(new VocabularyKey(nameof(ProfileImage), "Profile Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProfileSubtype = group.Add(new VocabularyKey(nameof(ProfileSubtype), "Profile Subtype", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProfileType = group.Add(new VocabularyKey(nameof(ProfileType), "Profile Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Salutation = group.Add(new VocabularyKey(nameof(Salutation), "Salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SatisfactionScore = group.Add(new VocabularyKey(nameof(SatisfactionScore), "Satisfaction Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SecondaryEmail = group.Add(new VocabularyKey(nameof(SecondaryEmail), "Secondary Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    SentimentScore = group.Add(new VocabularyKey(nameof(SentimentScore), "Sentiment Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ShippingAddress = group.Add(new VocabularyKey(nameof(ShippingAddress), "Shipping Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SpouseName = group.Add(new VocabularyKey(nameof(SpouseName), "Spouse/Partner Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SystemOfOrigin = group.Add(new VocabularyKey(nameof(SystemOfOrigin), "System of Origin", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Tags = group.Add(new VocabularyKey(nameof(Tags), "Tags", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalLifetimeSpendAmount = group.Add(new VocabularyKey(nameof(TotalLifetimeSpendAmount), "Total Lifetime Spend Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Totallifetimespendamount_Base = group.Add(new VocabularyKey(nameof(Totallifetimespendamount_Base), "Total Lifetime Spend Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalTransactionCount = group.Add(new VocabularyKey(nameof(TotalTransactionCount), "Total Transaction Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TwitterHandle = group.Add(new VocabularyKey(nameof(TwitterHandle), "Twitter Handle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Version = group.Add(new VocabularyKey(nameof(Version), "Version", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    WebsiteUrl = group.Add(new VocabularyKey(nameof(WebsiteUrl), "Website Url", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    WorkAddress = group.Add(new VocabularyKey(nameof(WorkAddress), "Work Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WorkPhone = group.Add(new VocabularyKey(nameof(WorkPhone), "Work Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="CustomerProfileId"/> from Vocab 'CustomerActivity.cdm.json/CustomerActivity' with Property 'CustomerProfileId'
            ///Property <see cref="CustomerProfileId"/> from Vocab 'SegmentMembership.cdm.json/SegmentMembership' with Property 'CustomerProfileId'
            #endregion
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AccountNumber { get; private set; }
        public VocabularyKey Affiliations { get; private set; }
        public VocabularyKey AlumniOf { get; private set; }
        public VocabularyKey Anniversary { get; private set; }
        public VocabularyKey AssistantName { get; private set; }
        public VocabularyKey Awards { get; private set; }
        public VocabularyKey BillingAddress { get; private set; }
        public VocabularyKey BirthDate { get; private set; }
        public VocabularyKey ChildrenNames { get; private set; }
        public VocabularyKey ChurnScore { get; private set; }
        public VocabularyKey CompanyName { get; private set; }
        public VocabularyKey CountryOrRegion { get; private set; }
        public VocabularyKey Culture { get; private set; }
        public VocabularyKey CurrencyName { get; private set; }
        public VocabularyKey CustomerProfileId { get; private set; }
        public VocabularyKey Department { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DonotBulkEmail { get; private set; }
        public VocabularyKey DoNotBulkPostalMail { get; private set; }
        public VocabularyKey DoNotContact { get; private set; }
        public VocabularyKey DoNotEmail { get; private set; }
        public VocabularyKey DoNotFax { get; private set; }
        public VocabularyKey DoNotPhone { get; private set; }
        public VocabularyKey DoNotPostalMail { get; private set; }
        public VocabularyKey EducationCode { get; private set; }
        public VocabularyKey EmployeeIdentifier { get; private set; }
        public VocabularyKey EmploymentStartDate { get; private set; }
        public VocabularyKey EngagementScore { get; private set; }
        public VocabularyKey FacebookProfile { get; private set; }
        public VocabularyKey FamilyStatus { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey FirstNamePronunciation { get; private set; }
        public VocabularyKey FraudScore { get; private set; }
        public VocabularyKey FTPSiteUrl { get; private set; }
        public VocabularyKey GamerTag { get; private set; }
        public VocabularyKey Gender { get; private set; }
        public VocabularyKey HasChildren { get; private set; }
        public VocabularyKey HasPets { get; private set; }
        public VocabularyKey Hobbies { get; private set; }
        public VocabularyKey HomeOwnershipType { get; private set; }
        public VocabularyKey HomePhone { get; private set; }
        public VocabularyKey IndustryCode { get; private set; }
        public VocabularyKey InfluencerScore { get; private set; }
        public VocabularyKey InstagramHandle { get; private set; }
        public VocabularyKey Interests { get; private set; }
        public VocabularyKey IsGovernment { get; private set; }
        public VocabularyKey IsLead { get; private set; }
        public VocabularyKey IsPublicSector { get; private set; }
        public VocabularyKey JobTitle { get; private set; }
        public VocabularyKey KnownSince { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey LastNamePronunciation { get; private set; }
        public VocabularyKey LifeTimeValue { get; private set; }
        public VocabularyKey LinkedInProfile { get; private set; }
        public VocabularyKey MailingAddress { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey MiddleNamePronunciation { get; private set; }
        public VocabularyKey MobilePhone { get; private set; }
        public VocabularyKey NameAlias { get; private set; }
        public VocabularyKey NamePrefix { get; private set; }
        public VocabularyKey NameSuffix { get; private set; }
        public VocabularyKey Nationality { get; private set; }
        public VocabularyKey NickName { get; private set; }
        public VocabularyKey Notes { get; private set; }
        public VocabularyKey NumberOfChildren { get; private set; }
        public VocabularyKey PinterestId { get; private set; }
        public VocabularyKey POBoxAddress { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey PreferredCallTime { get; private set; }
        public VocabularyKey PreferredContactMethodCode { get; private set; }
        public VocabularyKey PreferredName { get; private set; }
        public VocabularyKey PrimaryEmail { get; private set; }
        public VocabularyKey PrimaryPhone { get; private set; }
        public VocabularyKey ProfileImage { get; private set; }
        public VocabularyKey ProfileSubtype { get; private set; }
        public VocabularyKey ProfileType { get; private set; }
        public VocabularyKey Salutation { get; private set; }
        public VocabularyKey SatisfactionScore { get; private set; }
        public VocabularyKey SecondaryEmail { get; private set; }
        public VocabularyKey SentimentScore { get; private set; }
        public VocabularyKey ShippingAddress { get; private set; }
        public VocabularyKey SpouseName { get; private set; }
        public VocabularyKey SystemOfOrigin { get; private set; }
        public VocabularyKey Tags { get; private set; }
        public VocabularyKey TotalLifetimeSpendAmount { get; private set; }
        public VocabularyKey Totallifetimespendamount_Base { get; private set; }
        public VocabularyKey TotalTransactionCount { get; private set; }
        public VocabularyKey TwitterHandle { get; private set; }
        public VocabularyKey Version { get; private set; }
        public VocabularyKey WebsiteUrl { get; private set; }
        public VocabularyKey WorkAddress { get; private set; }
        public VocabularyKey WorkPhone { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}