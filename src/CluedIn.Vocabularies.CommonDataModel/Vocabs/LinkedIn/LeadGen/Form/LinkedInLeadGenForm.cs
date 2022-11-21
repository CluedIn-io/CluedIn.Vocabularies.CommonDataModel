using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInLeadGenFormVocabulary : SimpleVocabulary
    {
        public LinkedInLeadGenFormVocabulary()
        {
            VocabularyName = "Linked In Lead Gen Form";
            KeyPrefix = "commonDataModel.linkedinleadgenform";
            KeySeparator = ".";
            Grouping = "/LinkedInLeadGenForm";

            AddGroup("LinkedInLeadGenForm Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Headline = group.Add(new VocabularyKey(nameof(Headline), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LandingPageURL = group.Add(new VocabularyKey(nameof(LandingPageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastSyncDate = group.Add(new VocabularyKey(nameof(LastSyncDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedinformId = group.Add(new VocabularyKey(nameof(LinkedinformId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInID = group.Add(new VocabularyKey(nameof(LinkedInID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocaleCountry = group.Add(new VocabularyKey(nameof(LocaleCountry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocaleLanguage = group.Add(new VocabularyKey(nameof(LocaleLanguage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrivacyPolicyURL = group.Add(new VocabularyKey(nameof(PrivacyPolicyURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SyncStatus = group.Add(new VocabularyKey(nameof(SyncStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThankYouMessage = group.Add(new VocabularyKey(nameof(ThankYouMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalSubmissions = group.Add(new VocabularyKey(nameof(TotalSubmissions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Headline { get; private set; }
        public VocabularyKey LandingPageURL { get; private set; }
        public VocabularyKey LastSyncDate { get; private set; }
        public VocabularyKey LinkedinformId { get; private set; }
        public VocabularyKey LinkedInID { get; private set; }
        public VocabularyKey LocaleCountry { get; private set; }
        public VocabularyKey LocaleLanguage { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PrivacyPolicyURL { get; private set; }
        public VocabularyKey SyncStatus { get; private set; }
        public VocabularyKey ThankYouMessage { get; private set; }
        public VocabularyKey TotalSubmissions { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}