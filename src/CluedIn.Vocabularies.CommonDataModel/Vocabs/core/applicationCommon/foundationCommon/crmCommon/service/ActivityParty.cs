using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Service
{
    public class ActivityPartyVocabulary : SimpleVocabulary
    {
        public ActivityPartyVocabulary()
        {
            VocabularyName = "Activity Party";
            KeyPrefix = "commonDataModel.activityparty.service";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ActivityParty;

            AddGroup("ActivityParty Details for Service", group =>
            {
			                 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ActivityId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="ActivityId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Activity.cdm.json/Activity' with Property 'ActivityId'
            ///Property <see cref="ActivityId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Fax.cdm.json/Fax' with Property 'ActivityId'
            ///Property <see cref="ActivityId"/> to Vocab '/core/applicationCommon/Task.cdm.json/Task' with Property 'ActivityId'
            ///Property <see cref="ActivityId"/> to Vocab '/core/applicationCommon/SocialActivity.cdm.json/SocialActivity' with Property 'ActivityId'
            ///Property <see cref="ActivityId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Letter.cdm.json/Letter' with Property 'ActivityId'
            ///Property <see cref="ActivityId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Email.cdm.json/Email' with Property 'ActivityId'
            ///Property <see cref="ActivityId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/PhoneCall.cdm.json/PhoneCall' with Property 'ActivityId'
            ///Property <see cref="ActivityId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/RecurringAppointment.cdm.json/RecurringAppointment' with Property 'ActivityId'
            ///Property <see cref="PartyId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PartyId"/> to Vocab '/core/applicationCommon/foundationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="PartyId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="PartyId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PartyId"/> to Vocab '/core/applicationCommon/Queue.cdm.json/Queue' with Property 'QueueId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ResourceSpecId"/> to Vocab 'ResourceSpecification.cdm.json/ResourceSpecification' with Property 'ResourceSpecId'
            ///Property <see cref="PartyId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="PartyId"/> to Vocab 'User.cdm.json/User' with Property 'BusinessUnitId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'BusinessUnitId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        
    }
}