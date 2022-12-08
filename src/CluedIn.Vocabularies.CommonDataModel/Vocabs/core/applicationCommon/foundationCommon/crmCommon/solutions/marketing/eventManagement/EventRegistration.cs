using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.EventManagement
{
    public class EventRegistrationVocabulary : SimpleVocabulary
    {
        public EventRegistrationVocabulary()
        {
            VocabularyName = "Event Registration";
            KeyPrefix = "commonDataModel.eventregistration.eventmanagement";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.EventRegistration;

            AddGroup("EventRegistration Details for EventManagement", group =>
            {
			    EventRegistrationId = group.Add(new VocabularyKey(nameof(EventRegistrationId), "Event Registration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Registration ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Area = group.Add(new VocabularyKey(nameof(Area), "Area", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CompanySize = group.Add(new VocabularyKey(nameof(CompanySize), "Company Size", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Industry = group.Add(new VocabularyKey(nameof(Industry), "Industry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsCanceled = group.Add(new VocabularyKey(nameof(IsCanceled), "Is Canceled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Memo = group.Add(new VocabularyKey(nameof(Memo), "Memo", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrimaryRole = group.Add(new VocabularyKey(nameof(PrimaryRole), "Primary Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PublishingState = group.Add(new VocabularyKey(nameof(PublishingState), "Publishing State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RegisteredBy = group.Add(new VocabularyKey(nameof(RegisteredBy), "Registered By", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RegistrationNotificationSeen = group.Add(new VocabularyKey(nameof(RegistrationNotificationSeen), "Registration Notification Seen", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RegistrationStatus = group.Add(new VocabularyKey(nameof(RegistrationStatus), "Registration Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SyncedWithProvider = group.Add(new VocabularyKey(nameof(SyncedWithProvider), "Synced with Provider", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimesCheckedIn = group.Add(new VocabularyKey(nameof(TimesCheckedIn), "Times Checked-in", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    WebinarRegistrationID = group.Add(new VocabularyKey(nameof(WebinarRegistrationID), "Webinar Registration ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YearsInIndustry = group.Add(new VocabularyKey(nameof(YearsInIndustry), "Years in Industry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="EventId"/> to Vocab 'Event.cdm.json/Event' with Property 'EventId'
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
            ///Property <see cref="EventRegistrationId"/> from Vocab 'AttendeePass.cdm.json/AttendeePass' with Property 'EventRegistrationId'
            ///Property <see cref="EventRegistrationId"/> from Vocab 'CheckIn.cdm.json/CheckIn' with Property 'RegistrationId'
            ///Property <see cref="EventRegistrationId"/> from Vocab 'HotelRoomReservation.cdm.json/HotelRoomReservation' with Property 'Attendee'
            ///Property <see cref="EventRegistrationId"/> from Vocab 'RegistrationResponse.cdm.json/RegistrationResponse' with Property 'EventRegistration'
            ///Property <see cref="EventRegistrationId"/> from Vocab 'SessionRegistration.cdm.json/SessionRegistration' with Property 'RegistrationId'
            #endregion
        }

        public VocabularyKey EventRegistrationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Area { get; private set; }
        public VocabularyKey CompanySize { get; private set; }
        public VocabularyKey Industry { get; private set; }
        public VocabularyKey IsCanceled { get; private set; }
        public VocabularyKey Memo { get; private set; }
        public VocabularyKey PrimaryRole { get; private set; }
        public VocabularyKey PublishingState { get; private set; }
        public VocabularyKey RegisteredBy { get; private set; }
        public VocabularyKey RegistrationNotificationSeen { get; private set; }
        public VocabularyKey RegistrationStatus { get; private set; }
        public VocabularyKey SyncedWithProvider { get; private set; }
        public VocabularyKey TimesCheckedIn { get; private set; }
        public VocabularyKey WebinarRegistrationID { get; private set; }
        public VocabularyKey YearsInIndustry { get; private set; }
    }
}