using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.EventManagement
{
    public class SessionRegistrationVocabulary : SimpleVocabulary
    {
        public SessionRegistrationVocabulary()
        {
            VocabularyName = "Session Registration";
            KeyPrefix = "commonDataModel.sessionregistration.eventmanagement";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.SessionRegistration;

            AddGroup("SessionRegistration Details for EventManagement", group =>
            {
			    SessionRegistrationId = group.Add(new VocabularyKey(nameof(SessionRegistrationId), "Session Registration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Registration ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsCanceled = group.Add(new VocabularyKey(nameof(IsCanceled), "Is Canceled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    PublishingState = group.Add(new VocabularyKey(nameof(PublishingState), "Publishing State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RegistrationNotificationSeen = group.Add(new VocabularyKey(nameof(RegistrationNotificationSeen), "Registration Notification Seen", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RegistrationStatus = group.Add(new VocabularyKey(nameof(RegistrationStatus), "Registration Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SyncedWithProvider = group.Add(new VocabularyKey(nameof(SyncedWithProvider), "Synced with Provider", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimesCheckedIn = group.Add(new VocabularyKey(nameof(TimesCheckedIn), "Times Checked-in", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    WebinarRegistrationID = group.Add(new VocabularyKey(nameof(WebinarRegistrationID), "Webinar Registration ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="Event"/> to Vocab 'Event.cdm.json/Event' with Property 'EventId'
            ///Property <see cref="RegistrationId"/> to Vocab 'EventRegistration.cdm.json/EventRegistration' with Property 'EventRegistrationId'
            ///Property <see cref="SessionId"/> to Vocab 'Session.cdm.json/Session' with Property 'SessionId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ContactId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'ContactId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="SessionRegistrationId"/> from Vocab 'CheckIn.cdm.json/CheckIn' with Property 'SessionRegistration'
            #endregion
        }

        public VocabularyKey SessionRegistrationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey IsCanceled { get; private set; }
        public VocabularyKey PublishingState { get; private set; }
        public VocabularyKey RegistrationNotificationSeen { get; private set; }
        public VocabularyKey RegistrationStatus { get; private set; }
        public VocabularyKey SyncedWithProvider { get; private set; }
        public VocabularyKey TimesCheckedIn { get; private set; }
        public VocabularyKey WebinarRegistrationID { get; private set; }
    }
}