using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WebinarProviderVocabulary : SimpleVocabulary
    {
        public WebinarProviderVocabulary()
        {
            VocabularyName = "Webinar Provider";
            KeyPrefix = "commonDataModel.webinarprovider";
            KeySeparator = ".";
            Grouping = "/WebinarProvider";

            AddGroup("WebinarProvider Details", group =>
            {
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseServiceURL = group.Add(new VocabularyKey(nameof(BaseServiceURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClientID = group.Add(new VocabularyKey(nameof(ClientID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClientSecret = group.Add(new VocabularyKey(nameof(ClientSecret), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultProvider = group.Add(new VocabularyKey(nameof(IsDefaultProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxDurationInMinutes = group.Add(new VocabularyKey(nameof(MaxDurationInMinutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrivacyPolicy = group.Add(new VocabularyKey(nameof(PrivacyPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfService = group.Add(new VocabularyKey(nameof(TermsOfService), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpdateCredentials = group.Add(new VocabularyKey(nameof(UpdateCredentials), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarProviderId = group.Add(new VocabularyKey(nameof(WebinarProviderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
        public VocabularyKey BaseServiceURL { get; private set; }
        public VocabularyKey ClientID { get; private set; }
        public VocabularyKey ClientSecret { get; private set; }
        public VocabularyKey IsDefaultProvider { get; private set; }
        public VocabularyKey MaxDurationInMinutes { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PrivacyPolicy { get; private set; }
        public VocabularyKey TermsOfService { get; private set; }
        public VocabularyKey UpdateCredentials { get; private set; }
        public VocabularyKey WebinarProviderId { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}