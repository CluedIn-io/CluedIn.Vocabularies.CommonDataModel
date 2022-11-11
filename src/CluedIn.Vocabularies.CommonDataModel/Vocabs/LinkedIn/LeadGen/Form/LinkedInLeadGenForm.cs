using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInLeadGenFormVocabulary : SimpleVocabulary
    {
        public LinkedInLeadGenFormVocabulary()
        {
            VocabularyName = "Common Data Model LinkedInLeadGenForm";
            KeyPrefix = "commonDataModel.linkedinleadgenform";
            KeySeparator = ".";
            Grouping = "/LinkedInLeadGenForm";

            AddGroup("Common Data Model LinkedInLeadGenForm Details", group =>
            {
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                headline = group.Add(new VocabularyKey(nameof(headline), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                landingPageURL = group.Add(new VocabularyKey(nameof(landingPageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastSyncDate = group.Add(new VocabularyKey(nameof(lastSyncDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedinformId = group.Add(new VocabularyKey(nameof(linkedinformId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedInID = group.Add(new VocabularyKey(nameof(linkedInID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                localeCountry = group.Add(new VocabularyKey(nameof(localeCountry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                localeLanguage = group.Add(new VocabularyKey(nameof(localeLanguage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                privacyPolicyURL = group.Add(new VocabularyKey(nameof(privacyPolicyURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                syncStatus = group.Add(new VocabularyKey(nameof(syncStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                thankYouMessage = group.Add(new VocabularyKey(nameof(thankYouMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                totalSubmissions = group.Add(new VocabularyKey(nameof(totalSubmissions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey description { get; private set; }
        public VocabularyKey headline { get; private set; }
        public VocabularyKey landingPageURL { get; private set; }
        public VocabularyKey lastSyncDate { get; private set; }
        public VocabularyKey linkedinformId { get; private set; }
        public VocabularyKey linkedInID { get; private set; }
        public VocabularyKey localeCountry { get; private set; }
        public VocabularyKey localeLanguage { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey privacyPolicyURL { get; private set; }
        public VocabularyKey syncStatus { get; private set; }
        public VocabularyKey thankYouMessage { get; private set; }
        public VocabularyKey totalSubmissions { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}