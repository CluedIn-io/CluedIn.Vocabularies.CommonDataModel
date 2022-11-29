using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact.portals";
            KeySeparator = ".";
            Grouping = "/Contact";

            AddGroup("Contact Details for Portals", group =>
            {
			    AdxCreatedByIPAddress = group.Add(new VocabularyKey(nameof(AdxCreatedByIPAddress), "Created By IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByUsername = group.Add(new VocabularyKey(nameof(AdxCreatedByUsername), "Created By Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByIPAddress = group.Add(new VocabularyKey(nameof(AdxModifiedByIPAddress), "Modified By IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByUsername = group.Add(new VocabularyKey(nameof(AdxModifiedByUsername), "Modified By Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxOrganizationName = group.Add(new VocabularyKey(nameof(AdxOrganizationName), "Organization Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxTimeZone = group.Add(new VocabularyKey(nameof(AdxTimeZone), "Time Zone", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    DisableWebTracking = group.Add(new VocabularyKey(nameof(DisableWebTracking), "Disable Web Tracking", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsMinor = group.Add(new VocabularyKey(nameof(IsMinor), "Is Minor", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
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
        }

        public VocabularyKey AdxCreatedByIPAddress { get; private set; }
        public VocabularyKey AdxCreatedByUsername { get; private set; }
        public VocabularyKey AdxModifiedByIPAddress { get; private set; }
        public VocabularyKey AdxModifiedByUsername { get; private set; }
        public VocabularyKey AdxOrganizationName { get; private set; }
        public VocabularyKey AdxTimeZone { get; private set; }
        public VocabularyKey DisableWebTracking { get; private set; }
        public VocabularyKey IsMinor { get; private set; }
        public VocabularyKey IsMinorWithParentalConsent { get; private set; }
        public VocabularyKey PortalTermsAgreementDate { get; private set; }
        public VocabularyKey ProfileAlert { get; private set; }
        public VocabularyKey ProfileAlertDate { get; private set; }
        public VocabularyKey ProfileAlertInstructions { get; private set; }
        public VocabularyKey AdxProfileIsAnonymous { get; private set; }
        public VocabularyKey AdxProfileLastActivity { get; private set; }
        public VocabularyKey ProfileModifiedOn { get; private set; }
        public VocabularyKey PublicProfileCopy { get; private set; }
        public VocabularyKey AccessFailedCount { get; private set; }
        public VocabularyKey EmailConfirmed { get; private set; }
        public VocabularyKey LastSuccessfulLogin { get; private set; }
        public VocabularyKey LocalLoginDisabled { get; private set; }
        public VocabularyKey LockoutEnabled { get; private set; }
        public VocabularyKey LockoutEndDate { get; private set; }
        public VocabularyKey LoginEnabled { get; private set; }
        public VocabularyKey MobilePhoneConfirmed { get; private set; }
        public VocabularyKey PasswordHash { get; private set; }
        public VocabularyKey SecurityStamp { get; private set; }
        public VocabularyKey TwoFactorEnabled { get; private set; }
        public VocabularyKey UserName { get; private set; }
    }
}