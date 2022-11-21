using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SessionVocabulary : SimpleVocabulary
    {
        public SessionVocabulary()
        {
            VocabularyName = "Session";
            KeyPrefix = "commonDataModel.session";
            KeySeparator = ".";
            Grouping = "/Session";

            AddGroup("Session Details", group =>
            {
                AllowAttendeesToUnmute = group.Add(new VocabularyKey(nameof(AllowAttendeesToUnmute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowMeetingChat = group.Add(new VocabularyKey(nameof(AllowMeetingChat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Allowpstnsserstobypasslobby = group.Add(new VocabularyKey(nameof(Allowpstnsserstobypasslobby), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Allowteamsmeetingreactions = group.Add(new VocabularyKey(nameof(Allowteamsmeetingreactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttendeeEngagementReport = group.Add(new VocabularyKey(nameof(AttendeeEngagementReport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Attendeeurl = group.Add(new VocabularyKey(nameof(Attendeeurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AudienceType = group.Add(new VocabularyKey(nameof(AudienceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Autoadmittedusers = group.Add(new VocabularyKey(nameof(Autoadmittedusers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Autorecordingenabled = group.Add(new VocabularyKey(nameof(Autorecordingenabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AVSupport = group.Add(new VocabularyKey(nameof(AVSupport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseRecurrentSessionId = group.Add(new VocabularyKey(nameof(BaseRecurrentSessionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ByInvitationOnly = group.Add(new VocabularyKey(nameof(ByInvitationOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Calendarcontent = group.Add(new VocabularyKey(nameof(Calendarcontent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalendarcontentPlaintext = group.Add(new VocabularyKey(nameof(CalendarcontentPlaintext), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CamerasPermitted = group.Add(new VocabularyKey(nameof(CamerasPermitted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChangeMeetingOptions = group.Add(new VocabularyKey(nameof(ChangeMeetingOptions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckInCount = group.Add(new VocabularyKey(nameof(CheckInCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DescriptorSyncStatus = group.Add(new VocabularyKey(nameof(DescriptorSyncStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DetailedDescription = group.Add(new VocabularyKey(nameof(DetailedDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DurationMins = group.Add(new VocabularyKey(nameof(DurationMins), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndTime = group.Add(new VocabularyKey(nameof(EndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Entryexitannouncementsenabled = group.Add(new VocabularyKey(nameof(Entryexitannouncementsenabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalUrl = group.Add(new VocabularyKey(nameof(ExternalUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FlipChart = group.Add(new VocabularyKey(nameof(FlipChart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Industry = group.Add(new VocabularyKey(nameof(Industry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternetConnection = group.Add(new VocabularyKey(nameof(InternetConnection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Isoutofsync = group.Add(new VocabularyKey(nameof(Isoutofsync), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Keywords = group.Add(new VocabularyKey(nameof(Keywords), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lastteamssyncdate = group.Add(new VocabularyKey(nameof(Lastteamssyncdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NDA = group.Add(new VocabularyKey(nameof(NDA), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PresentationManagerURL = group.Add(new VocabularyKey(nameof(PresentationManagerURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreviousNumberOfFreeSlots = group.Add(new VocabularyKey(nameof(PreviousNumberOfFreeSlots), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PublishStatus = group.Add(new VocabularyKey(nameof(PublishStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Qna = group.Add(new VocabularyKey(nameof(Qna), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Recordingforattendees = group.Add(new VocabularyKey(nameof(Recordingforattendees), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Recordingforproducersandspeakers = group.Add(new VocabularyKey(nameof(Recordingforproducersandspeakers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecordingsPermitted = group.Add(new VocabularyKey(nameof(RecordingsPermitted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecurrencePattern = group.Add(new VocabularyKey(nameof(RecurrencePattern), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationCount = group.Add(new VocabularyKey(nameof(RegistrationCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionCode = group.Add(new VocabularyKey(nameof(SessionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionFormat = group.Add(new VocabularyKey(nameof(SessionFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionId = group.Add(new VocabularyKey(nameof(SessionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionMaxCapacity = group.Add(new VocabularyKey(nameof(SessionMaxCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionObjectives = group.Add(new VocabularyKey(nameof(SessionObjectives), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionPrerequisites = group.Add(new VocabularyKey(nameof(SessionPrerequisites), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionSummary = group.Add(new VocabularyKey(nameof(SessionSummary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionType = group.Add(new VocabularyKey(nameof(SessionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartTime = group.Add(new VocabularyKey(nameof(StartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Streamingenabled = group.Add(new VocabularyKey(nameof(Streamingenabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreamingProvider = group.Add(new VocabularyKey(nameof(StreamingProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreationSource = group.Add(new VocabularyKey(nameof(CreationSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Teamsinvitationhtml = group.Add(new VocabularyKey(nameof(Teamsinvitationhtml), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalNumberOfQuestionsAsked = group.Add(new VocabularyKey(nameof(TotalNumberOfQuestionsAsked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VideoConferencing = group.Add(new VocabularyKey(nameof(VideoConferencing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarID = group.Add(new VocabularyKey(nameof(WebinarID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarNotificationSeen = group.Add(new VocabularyKey(nameof(WebinarNotificationSeen), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarOperation = group.Add(new VocabularyKey(nameof(WebinarOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarStatus = group.Add(new VocabularyKey(nameof(WebinarStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarStatusReason = group.Add(new VocabularyKey(nameof(WebinarStatusReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebinarURL = group.Add(new VocabularyKey(nameof(WebinarURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Whiteboard = group.Add(new VocabularyKey(nameof(Whiteboard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AllowAttendeesToUnmute { get; private set; }
        public VocabularyKey AllowMeetingChat { get; private set; }
        public VocabularyKey Allowpstnsserstobypasslobby { get; private set; }
        public VocabularyKey Allowteamsmeetingreactions { get; private set; }
        public VocabularyKey AttendeeEngagementReport { get; private set; }
        public VocabularyKey Attendeeurl { get; private set; }
        public VocabularyKey AudienceType { get; private set; }
        public VocabularyKey Autoadmittedusers { get; private set; }
        public VocabularyKey Autorecordingenabled { get; private set; }
        public VocabularyKey AVSupport { get; private set; }
        public VocabularyKey BaseRecurrentSessionId { get; private set; }
        public VocabularyKey ByInvitationOnly { get; private set; }
        public VocabularyKey Calendarcontent { get; private set; }
        public VocabularyKey CalendarcontentPlaintext { get; private set; }
        public VocabularyKey CamerasPermitted { get; private set; }
        public VocabularyKey ChangeMeetingOptions { get; private set; }
        public VocabularyKey CheckInCount { get; private set; }
        public VocabularyKey DescriptorSyncStatus { get; private set; }
        public VocabularyKey DetailedDescription { get; private set; }
        public VocabularyKey DurationMins { get; private set; }
        public VocabularyKey EndTime { get; private set; }
        public VocabularyKey Entryexitannouncementsenabled { get; private set; }
        public VocabularyKey ExternalUrl { get; private set; }
        public VocabularyKey FlipChart { get; private set; }
        public VocabularyKey Industry { get; private set; }
        public VocabularyKey InternetConnection { get; private set; }
        public VocabularyKey Isoutofsync { get; private set; }
        public VocabularyKey Keywords { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey Lastteamssyncdate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NDA { get; private set; }
        public VocabularyKey PresentationManagerURL { get; private set; }
        public VocabularyKey PreviousNumberOfFreeSlots { get; private set; }
        public VocabularyKey PublishStatus { get; private set; }
        public VocabularyKey Qna { get; private set; }
        public VocabularyKey Recordingforattendees { get; private set; }
        public VocabularyKey Recordingforproducersandspeakers { get; private set; }
        public VocabularyKey RecordingsPermitted { get; private set; }
        public VocabularyKey RecurrencePattern { get; private set; }
        public VocabularyKey RegistrationCount { get; private set; }
        public VocabularyKey SessionCode { get; private set; }
        public VocabularyKey SessionFormat { get; private set; }
        public VocabularyKey SessionId { get; private set; }
        public VocabularyKey SessionMaxCapacity { get; private set; }
        public VocabularyKey SessionObjectives { get; private set; }
        public VocabularyKey SessionPrerequisites { get; private set; }
        public VocabularyKey SessionSummary { get; private set; }
        public VocabularyKey SessionType { get; private set; }
        public VocabularyKey StartTime { get; private set; }
        public VocabularyKey Streamingenabled { get; private set; }
        public VocabularyKey StreamingProvider { get; private set; }
        public VocabularyKey CreationSource { get; private set; }
        public VocabularyKey Teamsinvitationhtml { get; private set; }
        public VocabularyKey TotalNumberOfQuestionsAsked { get; private set; }
        public VocabularyKey VideoConferencing { get; private set; }
        public VocabularyKey WebinarID { get; private set; }
        public VocabularyKey WebinarNotificationSeen { get; private set; }
        public VocabularyKey WebinarOperation { get; private set; }
        public VocabularyKey WebinarStatus { get; private set; }
        public VocabularyKey WebinarStatusReason { get; private set; }
        public VocabularyKey WebinarURL { get; private set; }
        public VocabularyKey Whiteboard { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}