using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ConnectionVocabulary : SimpleVocabulary
    {
        public ConnectionVocabulary()
        {
            VocabularyName = "Connection";
            KeyPrefix = "commonDataModel.connection";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Connection;

            AddGroup("Connection Details for ApplicationCommon", group =>
            {
                OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), "Owning User", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ConnectionId = group.Add(new VocabularyKey(nameof(ConnectionId), "Connection", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveStart = group.Add(new VocabularyKey(nameof(EffectiveStart), "Starting", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMaster = group.Add(new VocabularyKey(nameof(IsMaster), "Is Master", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveEnd = group.Add(new VocabularyKey(nameof(EffectiveEnd), "Ending", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwningTeam = group.Add(new VocabularyKey(nameof(OwningTeam), "Owning Team", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                Record2ObjectTypeCode = group.Add(new VocabularyKey(nameof(Record2ObjectTypeCode), "Type (To)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Record1ObjectTypeCode = group.Add(new VocabularyKey(nameof(Record1ObjectTypeCode), "Type (From)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Connection Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), "Entity Image Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Connection Details for Marketing", group =>
            {

            });

            #region Incoming Relationships
            ///Property <see cref="Record2Id"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="Record1Id"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="Record2Id"/> to Vocab 'Activity.cdm.json/Activity' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab 'Activity.cdm.json/Activity' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab 'Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab 'Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="RelatedConnectionId"/> to Vocab 'Connection.cdm.json/Connection' with Property 'ConnectionId'
            ///Property <see cref="Record2Id"/> to Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab 'Letter.cdm.json/Letter' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab 'Email.cdm.json/Email' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="Record2Id"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Record2Id"/> to Vocab 'Task.cdm.json/Task' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab 'SocialProfile.cdm.json/SocialProfile' with Property 'SocialProfileId'
            ///Property <see cref="Record2Id"/> to Vocab 'Goal.cdm.json/Goal' with Property 'GoalId'
            ///Property <see cref="Record2Id"/> to Vocab 'KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="Record2Id"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="Record2Id"/> to Vocab 'Position.cdm.json/Position' with Property 'PositionId'
            ///Property <see cref="Record2Id"/> to Vocab 'Fax.cdm.json/Fax' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Record2Id"/> to Vocab 'RecurringAppointment.cdm.json/RecurringAppointment' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab 'PhoneCall.cdm.json/PhoneCall' with Property 'ActivityId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="Record2RoleId"/> to Vocab 'ConnectionRole.cdm.json/ConnectionRole' with Property 'ConnectionRoleId'
            ///Property <see cref="Record1RoleId"/> to Vocab 'ConnectionRole.cdm.json/ConnectionRole' with Property 'ConnectionRoleId'
            ///Property <see cref="Record1Id"/> to Vocab 'Task.cdm.json/Task' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab 'RecurringAppointment.cdm.json/RecurringAppointment' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab 'SocialProfile.cdm.json/SocialProfile' with Property 'SocialProfileId'
            ///Property <see cref="Record1Id"/> to Vocab 'PhoneCall.cdm.json/PhoneCall' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Record1Id"/> to Vocab 'Fax.cdm.json/Fax' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="Record1Id"/> to Vocab 'Letter.cdm.json/Letter' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab 'Goal.cdm.json/Goal' with Property 'GoalId'
            ///Property <see cref="Record1Id"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Record1Id"/> to Vocab 'Email.cdm.json/Email' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab 'Position.cdm.json/Position' with Property 'PositionId'
            ///Property <see cref="Record1Id"/> to Vocab 'KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="Record1Id"/> to Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="Record2RoleId"/> to Vocab 'ConnectionRole.cdm.json/ConnectionRole' with Property 'ConnectionRoleId'
            ///Property <see cref="Record1RoleId"/> to Vocab 'ConnectionRole.cdm.json/ConnectionRole' with Property 'ConnectionRoleId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="Record2Id"/> to Vocab 'Goal.cdm.json/Goal' with Property 'GoalId'
            ///Property <see cref="Record1Id"/> to Vocab 'Goal.cdm.json/Goal' with Property 'GoalId'
            ///Property <see cref="Record2Id"/> to Vocab 'KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="Record1Id"/> to Vocab 'KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="Record2Id"/> to Vocab 'Position.cdm.json/Position' with Property 'PositionId'
            ///Property <see cref="Record1Id"/> to Vocab 'Position.cdm.json/Position' with Property 'PositionId'
            ///Property <see cref="Record2Id"/> to Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'ActivityId'
            ///Property <see cref="Record2Id"/> to Vocab 'SocialProfile.cdm.json/SocialProfile' with Property 'SocialProfileId'
            ///Property <see cref="Record1Id"/> to Vocab 'SocialProfile.cdm.json/SocialProfile' with Property 'SocialProfileId'
            ///Property <see cref="Record2Id"/> to Vocab 'Task.cdm.json/Task' with Property 'ActivityId'
            ///Property <see cref="Record1Id"/> to Vocab 'Task.cdm.json/Task' with Property 'ActivityId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Record2Id"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Record1Id"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="ConnectionId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'RelatedConnectionId'
            ///Property <see cref="ConnectionRoleId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record2RoleId'
            ///Property <see cref="ConnectionRoleId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record1RoleId'
            ///Property <see cref="ConnectionRoleId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Connection.cdm.json/Connection' with Property 'Record2RoleId'
            ///Property <see cref="ConnectionRoleId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Connection.cdm.json/Connection' with Property 'Record1RoleId'
            #endregion
        }

        public VocabularyKey ConnectionId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EffectiveEnd { get; private set; }
        public VocabularyKey EffectiveStart { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey IsMaster { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey OwningTeam { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey Record1ObjectTypeCode { get; private set; }
        public VocabularyKey Record2ObjectTypeCode { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}