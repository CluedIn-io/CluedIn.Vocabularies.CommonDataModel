using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class SessionVocabulary : SimpleVocabulary
    {
        public SessionVocabulary()
        {
            VocabularyName = "Session";
            KeyPrefix = "commonDataModel.session";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Session;

            AddGroup("Session Details for EventManagement", group =>
            {
			    SessionId = group.Add(new VocabularyKey(nameof(SessionId), "Session", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Session Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AudienceType = group.Add(new VocabularyKey(nameof(AudienceType), "Audience Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AVSupport = group.Add(new VocabularyKey(nameof(AVSupport), "A/V Support", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ByInvitationOnly = group.Add(new VocabularyKey(nameof(ByInvitationOnly), "By invitation only", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CamerasPermitted = group.Add(new VocabularyKey(nameof(CamerasPermitted), "Cameras permitted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CheckInCount = group.Add(new VocabularyKey(nameof(CheckInCount), "Check-in count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DetailedDescription = group.Add(new VocabularyKey(nameof(DetailedDescription), "Detailed Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndTime = group.Add(new VocabularyKey(nameof(EndTime), "End Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EventSpeakerId = group.Add(new VocabularyKey(nameof(EventSpeakerId), "Event Speaker", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalUrl = group.Add(new VocabularyKey(nameof(ExternalUrl), "Session Url", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    FlipChart = group.Add(new VocabularyKey(nameof(FlipChart), "Flip-Chart", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Industry = group.Add(new VocabularyKey(nameof(Industry), "Industry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InternetConnection = group.Add(new VocabularyKey(nameof(InternetConnection), "Internet Connection", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Keywords = group.Add(new VocabularyKey(nameof(Keywords), "Keywords", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Language = group.Add(new VocabularyKey(nameof(Language), "Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NDA = group.Add(new VocabularyKey(nameof(NDA), "NDA", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PresentationManagerUrl = group.Add(new VocabularyKey(nameof(PresentationManagerUrl), "Presentation Manager URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    PublishStatus = group.Add(new VocabularyKey(nameof(PublishStatus), "Publish Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecordingsPermitted = group.Add(new VocabularyKey(nameof(RecordingsPermitted), "Recordings permitted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecurrencePattern = group.Add(new VocabularyKey(nameof(RecurrencePattern), "recurrencepattern", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RegistrationCount = group.Add(new VocabularyKey(nameof(RegistrationCount), "Registration count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    SessionCode = group.Add(new VocabularyKey(nameof(SessionCode), "Session Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SessionFormat = group.Add(new VocabularyKey(nameof(SessionFormat), "Session Format", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SessionMaxCapacity = group.Add(new VocabularyKey(nameof(SessionMaxCapacity), "Session max. capacity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    SessionObjectives = group.Add(new VocabularyKey(nameof(SessionObjectives), "Session Objectives", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SessionPreRequisites = group.Add(new VocabularyKey(nameof(SessionPreRequisites), "Session Pre-Requisites", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SessionSummary = group.Add(new VocabularyKey(nameof(SessionSummary), "Session Summary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SessionType = group.Add(new VocabularyKey(nameof(SessionType), "Session Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartTime = group.Add(new VocabularyKey(nameof(StartTime), "Start Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VideoConferencing = group.Add(new VocabularyKey(nameof(VideoConferencing), "Video Conferencing", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebinarConfigurationId = group.Add(new VocabularyKey(nameof(WebinarConfigurationId), "Webinar Configuration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebinarID = group.Add(new VocabularyKey(nameof(WebinarID), "Webinar ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebinarNotificationSeen = group.Add(new VocabularyKey(nameof(WebinarNotificationSeen), "Webinar Notification Seen", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    WebinarOperation = group.Add(new VocabularyKey(nameof(WebinarOperation), "Webinar Operation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebinarStatus = group.Add(new VocabularyKey(nameof(WebinarStatus), "Webinar Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebinarStatusReason = group.Add(new VocabularyKey(nameof(WebinarStatusReason), "Webinar Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebinarType = group.Add(new VocabularyKey(nameof(WebinarType), "Webinar Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebinarURL = group.Add(new VocabularyKey(nameof(WebinarURL), "Webinar URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    WhiteBoard = group.Add(new VocabularyKey(nameof(WhiteBoard), "Whiteboard", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DurationMins = group.Add(new VocabularyKey(nameof(DurationMins), "Duration (mins)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TotalNumberOfQuestionsAsked = group.Add(new VocabularyKey(nameof(TotalNumberOfQuestionsAsked), "Total number of questions asked", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TotalNumberOfQuestionsAskedDate = group.Add(new VocabularyKey(nameof(TotalNumberOfQuestionsAskedDate), "Total number of questions asked (Last Updated On)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalNumberOfQuestionsAskedState = group.Add(new VocabularyKey(nameof(TotalNumberOfQuestionsAskedState), "Total number of questions asked (State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="Event"/> to Vocab 'Event.cdm.json/Event' with Property 'EventId'
            ///Property <see cref="Event"/> to Vocab 'Event.cdm.json/Event' with Property 'EventId'
            ///Property <see cref="EventId"/> to Vocab 'Event.cdm.json/Event' with Property 'EventId'
            ///Property <see cref="RegistrationId"/> to Vocab 'EventRegistration.cdm.json/EventRegistration' with Property 'EventRegistrationId'
            ///Property <see cref="Producer"/> to Vocab 'EventTeamMember.cdm.json/EventTeamMember' with Property 'EventTeamMemberId'
            ///Property <see cref="PassSessions"/> to Vocab 'Pass.cdm.json/Pass' with Property 'PassId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Venue"/> to Vocab 'Venue.cdm.json/Venue' with Property 'VenueId'
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
            ///Property <see cref="SessionId"/> from Vocab 'CheckIn.cdm.json/CheckIn' with Property 'SessionAttended'
            ///Property <see cref="SessionRegistrationId"/> from Vocab 'CheckIn.cdm.json/CheckIn' with Property 'SessionRegistration'
            ///Property <see cref="SessionTrackId"/> from Vocab 'Pass.cdm.json/Pass' with Property 'Track'
            ///Property <see cref="SessionId"/> from Vocab 'SessionRegistration.cdm.json/SessionRegistration' with Property 'SessionId'
            ///Property <see cref="SessionId"/> from Vocab 'SpeakerEngagement.cdm.json/SpeakerEngagement' with Property 'Session'
            #endregion
        }

        public VocabularyKey AudienceType { get; private set; }
        public VocabularyKey AVSupport { get; private set; }
        public VocabularyKey ByInvitationOnly { get; private set; }
        public VocabularyKey CamerasPermitted { get; private set; }
        public VocabularyKey CheckInCount { get; private set; }
        public VocabularyKey DetailedDescription { get; private set; }
        public VocabularyKey DurationMins { get; private set; }
        public VocabularyKey EndTime { get; private set; }
        public VocabularyKey EventSpeakerId { get; private set; }
        public VocabularyKey ExternalUrl { get; private set; }
        public VocabularyKey FlipChart { get; private set; }
        public VocabularyKey Industry { get; private set; }
        public VocabularyKey InternetConnection { get; private set; }
        public VocabularyKey Keywords { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NDA { get; private set; }
        public VocabularyKey PresentationManagerUrl { get; private set; }
        public VocabularyKey PublishStatus { get; private set; }
        public VocabularyKey RecordingsPermitted { get; private set; }
        public VocabularyKey RecurrencePattern { get; private set; }
        public VocabularyKey RegistrationCount { get; private set; }
        public VocabularyKey SessionCode { get; private set; }
        public VocabularyKey SessionFormat { get; private set; }
        public VocabularyKey SessionId { get; private set; }
        public VocabularyKey SessionMaxCapacity { get; private set; }
        public VocabularyKey SessionObjectives { get; private set; }
        public VocabularyKey SessionPreRequisites { get; private set; }
        public VocabularyKey SessionSummary { get; private set; }
        public VocabularyKey SessionType { get; private set; }
        public VocabularyKey StartTime { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TotalNumberOfQuestionsAsked { get; private set; }
        public VocabularyKey TotalNumberOfQuestionsAskedDate { get; private set; }
        public VocabularyKey TotalNumberOfQuestionsAskedState { get; private set; }
        public VocabularyKey VideoConferencing { get; private set; }
        public VocabularyKey WebinarConfigurationId { get; private set; }
        public VocabularyKey WebinarID { get; private set; }
        public VocabularyKey WebinarNotificationSeen { get; private set; }
        public VocabularyKey WebinarOperation { get; private set; }
        public VocabularyKey WebinarStatus { get; private set; }
        public VocabularyKey WebinarStatusReason { get; private set; }
        public VocabularyKey WebinarType { get; private set; }
        public VocabularyKey WebinarURL { get; private set; }
        public VocabularyKey WhiteBoard { get; private set; }
    }
}