using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class LinkedInCampaignVocabulary : SimpleVocabulary
    {
        public LinkedInCampaignVocabulary()
        {
            VocabularyName = "Linked In Campaign";
            KeyPrefix = "commonDataModel.linkedincampaign";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.LinkedInCampaign;

            AddGroup("LinkedInCampaign Details for LinkedInLeads", group =>
            {
                LinkedInCampaignID = group.Add(new VocabularyKey(nameof(LinkedInCampaignID), "LinkedIn Campaign", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CampaignType = group.Add(new VocabularyKey(nameof(CampaignType), "Campaign Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), "Proposed End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInID = group.Add(new VocabularyKey(nameof(LinkedInID), "LinkedIn ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInStatus = group.Add(new VocabularyKey(nameof(LinkedInStatus), "LinkedIn Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Proposed Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="LinkedInAccount"/> to Vocab 'LinkedInAccount.cdm.json/LinkedInAccount' with Property 'LinkedInAccountID'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="LinkedInCampaignID"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/financialServices/banking/CustomerJourney.cdm.json/CustomerJourney' with Property 'LinkedInCampaign'
            ///Property <see cref="LinkedInCampaignID"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/CustomerJourney.cdm.json/CustomerJourney' with Property 'LinkedInCampaign'
            ///Property <see cref="LinkedInCampaignID"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Lead.cdm.json/Lead' with Property 'LinkedInCampaign'
            ///Property <see cref="LinkedInCampaignID"/> from Vocab 'LinkedInLeadGenFormSubmission.cdm.json/LinkedInLeadGenFormSubmission' with Property 'LinkedInCampaign'
            #endregion
        }

        public VocabularyKey CampaignType { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey LinkedInCampaignID { get; private set; }
        public VocabularyKey LinkedInID { get; private set; }
        public VocabularyKey LinkedInStatus { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}