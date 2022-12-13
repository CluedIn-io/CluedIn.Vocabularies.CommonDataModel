using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class LinkedInLeadGenFormVocabulary : SimpleVocabulary
    {
        public LinkedInLeadGenFormVocabulary()
        {
            VocabularyName = "Linked In Lead Gen Form";
            KeyPrefix = "commonDataModel.linkedinleadgenform";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.LinkedInLeadGenForm;

            AddGroup("LinkedInLeadGenForm Details for LinkedInLeads", group =>
            {
                LinkedinformId = group.Add(new VocabularyKey(nameof(LinkedinformId), "LinkedIn Lead Gen Form", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Headline = group.Add(new VocabularyKey(nameof(Headline), "LinkedIn form headline", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LandingpageURL = group.Add(new VocabularyKey(nameof(LandingpageURL), "Landing page URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
                LastSyncDate = group.Add(new VocabularyKey(nameof(LastSyncDate), "Last Sync Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInID = group.Add(new VocabularyKey(nameof(LinkedInID), "LinkedIn ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocaleCountry = group.Add(new VocabularyKey(nameof(LocaleCountry), "Locale country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocaleLanguage = group.Add(new VocabularyKey(nameof(LocaleLanguage), "Locale language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrivacyPolicyURL = group.Add(new VocabularyKey(nameof(PrivacyPolicyURL), "Privacy policy URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
                SyncStatus = group.Add(new VocabularyKey(nameof(SyncStatus), "Sync status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Thankyoumessage = group.Add(new VocabularyKey(nameof(Thankyoumessage), "Thank you message", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalSubmissions = group.Add(new VocabularyKey(nameof(TotalSubmissions), "Total submissions", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                TotalsubmissionsDate = group.Add(new VocabularyKey(nameof(TotalsubmissionsDate), "Total submissions (Last Updated On)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalsubmissionsState = group.Add(new VocabularyKey(nameof(TotalsubmissionsState), "Total submissions (State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="LinkedInParentAccount"/> to Vocab 'LinkedInAccount.cdm.json/LinkedInAccount' with Property 'LinkedInAccountID'
            ///Property <see cref="LinkedInCampaign"/> to Vocab 'LinkedInCampaign.cdm.json/LinkedInCampaign' with Property 'LinkedInCampaignID'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="LinkedinformId"/> to Vocab 'LinkedInLeadGenForm.cdm.json/LinkedInLeadGenForm' with Property 'LinkedinformId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Lead"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="CustomerJourney"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/CustomerJourney.cdm.json/CustomerJourney' with Property 'CustomerJourneyId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="LinkedinformId"/> from Vocab 'LinkedInFormQuestion.cdm.json/LinkedInFormQuestion' with Property 'LinkedinForm'
            ///Property <see cref="LinkedInFormSubmissionId"/> from Vocab 'LinkedInFormSubmissionAnswer.cdm.json/LinkedInFormSubmissionAnswer' with Property 'LinkedInFormSubmissionID'
            ///Property <see cref="LinkedinformId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Lead.cdm.json/Lead' with Property 'SourceLinkedInForm'
            ///Property <see cref="LinkedinformId"/> from Vocab 'LinkedInLeadGenFormSubmission.cdm.json/LinkedInLeadGenFormSubmission' with Property 'LinkedinformId'
            #endregion
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Headline { get; private set; }
        public VocabularyKey LandingpageURL { get; private set; }
        public VocabularyKey LastSyncDate { get; private set; }
        public VocabularyKey LinkedinformId { get; private set; }
        public VocabularyKey LinkedInID { get; private set; }
        public VocabularyKey LocaleCountry { get; private set; }
        public VocabularyKey LocaleLanguage { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PrivacyPolicyURL { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SyncStatus { get; private set; }
        public VocabularyKey Thankyoumessage { get; private set; }
        public VocabularyKey TotalSubmissions { get; private set; }
        public VocabularyKey TotalsubmissionsDate { get; private set; }
        public VocabularyKey TotalsubmissionsState { get; private set; }
    }
}