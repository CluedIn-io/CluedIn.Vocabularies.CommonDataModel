using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Marketing
{
    public class ConnectionVocabulary : SimpleVocabulary
    {
        public ConnectionVocabulary()
        {
            VocabularyName = "Connection";
            KeyPrefix = "commonDataModel.connection.marketing";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Connection;

            AddGroup("Connection Details for Marketing", group =>
            {
			                 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="RelatedConnectionId"/> to Vocab 'Connection.cdm.json/Connection' with Property 'ConnectionId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="Record2RoleId"/> to Vocab '/core/applicationCommon/ConnectionRole.cdm.json/ConnectionRole' with Property 'ConnectionRoleId'
            ///Property <see cref="Record1RoleId"/> to Vocab '/core/applicationCommon/ConnectionRole.cdm.json/ConnectionRole' with Property 'ConnectionRoleId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/SocialActivity.cdm.json/SocialActivity' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Letter.cdm.json/Letter' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Email.cdm.json/Email' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/Task.cdm.json/Task' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/SocialProfile.cdm.json/SocialProfile' with Property 'SocialProfileId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Activity.cdm.json/Activity' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/Goal.cdm.json/Goal' with Property 'GoalId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/foundationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/Position.cdm.json/Position' with Property 'PositionId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Fax.cdm.json/Fax' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/RecurringAppointment.cdm.json/RecurringAppointment' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/PhoneCall.cdm.json/PhoneCall' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/Task.cdm.json/Task' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/RecurringAppointment.cdm.json/RecurringAppointment' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/SocialProfile.cdm.json/SocialProfile' with Property 'SocialProfileId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/PhoneCall.cdm.json/PhoneCall' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Fax.cdm.json/Fax' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/foundationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Letter.cdm.json/Letter' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/Goal.cdm.json/Goal' with Property 'GoalId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Activity.cdm.json/Activity' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Email.cdm.json/Email' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/Position.cdm.json/Position' with Property 'PositionId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/SocialActivity.cdm.json/SocialActivity' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="RelatedConnectionId"/> to Vocab 'Connection.cdm.json/Connection' with Property 'ConnectionId'
            ///Property <see cref="Record2Id"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Record1Id"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ConnectionId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'RelatedConnectionId'
            ///Property <see cref="ConnectionRoleId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record2RoleId'
            ///Property <see cref="ConnectionRoleId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record1RoleId'
            ///Property <see cref="ConnectionId"/> from Vocab '/core/applicationCommon/Connection.cdm.json/Connection' with Property 'RelatedConnectionId'
            #endregion
        }

        
    }
}