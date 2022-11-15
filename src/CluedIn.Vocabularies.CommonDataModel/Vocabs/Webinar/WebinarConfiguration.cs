using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WebinarConfigurationVocabulary : SimpleVocabulary
    {
        public WebinarConfigurationVocabulary()
        {
            VocabularyName = "Webinar Configuration";
            KeyPrefix = "commonDataModel.webinarconfiguration";
            KeySeparator = ".";
            Grouping = "/WebinarConfiguration";

            AddGroup("WebinarConfiguration Details", group =>
            {
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccessToken = group.Add(new VocabularyKey(nameof(AccessToken), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccessTokenKey = group.Add(new VocabularyKey(nameof(AccessTokenKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccessTokenSecret = group.Add(new VocabularyKey(nameof(AccessTokenSecret), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppURL = group.Add(new VocabularyKey(nameof(AppURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Authorized = group.Add(new VocabularyKey(nameof(Authorized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClientID = group.Add(new VocabularyKey(nameof(ClientID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastUpdateDateTime = group.Add(new VocabularyKey(nameof(LastUpdateDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Message = group.Add(new VocabularyKey(nameof(Message), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProviderServiceStatus = group.Add(new VocabularyKey(nameof(ProviderServiceStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpdateCredentials = group.Add(new VocabularyKey(nameof(UpdateCredentials), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarConfigurationId = group.Add(new VocabularyKey(nameof(WebinarConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey AccessToken { get; private set; }
        public VocabularyKey AccessTokenKey { get; private set; }
        public VocabularyKey AccessTokenSecret { get; private set; }
        public VocabularyKey AppURL { get; private set; }
        public VocabularyKey Authorized { get; private set; }
        public VocabularyKey ClientID { get; private set; }
        public VocabularyKey LastUpdateDateTime { get; private set; }
        public VocabularyKey Message { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProviderServiceStatus { get; private set; }
        public VocabularyKey UpdateCredentials { get; private set; }
        public VocabularyKey WebinarConfigurationId { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}