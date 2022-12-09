using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ParticipatingOrganizationVocabulary : SimpleVocabulary
    {
        public ParticipatingOrganizationVocabulary()
        {
            VocabularyName = "Participating Organization";
            KeyPrefix = "commonDataModel.participatingorganization";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ParticipatingOrganization;

            AddGroup("ParticipatingOrganization Details for NonProfitIati", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ParticipatingOrganizationActivityId = group.Add(new VocabularyKey(nameof(ParticipatingOrganizationActivityId), "Participating Organization Activity Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ParticipatingOrganizationId = group.Add(new VocabularyKey(nameof(ParticipatingOrganizationId), "Participating Organization", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrganizationRole = group.Add(new VocabularyKey(nameof(OrganizationRole), "Organization Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="AccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CrsChannelId"/> to Vocab 'NonEmbeddedCodelist.cdm.json/NonEmbeddedCodelist' with Property 'NonEmbeddedCodelistId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="DeliveryFrameworkId"/> to Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DeliveryFrameworkId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey OrganizationRole { get; private set; }
        public VocabularyKey ParticipatingOrganizationActivityId { get; private set; }
        public VocabularyKey ParticipatingOrganizationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}