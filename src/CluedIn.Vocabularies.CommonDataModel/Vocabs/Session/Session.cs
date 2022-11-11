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
                allowAttendeesToUnmute = group.Add(new VocabularyKey(nameof(allowAttendeesToUnmute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                allowMeetingChat = group.Add(new VocabularyKey(nameof(allowMeetingChat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                allowpstnsserstobypasslobby = group.Add(new VocabularyKey(nameof(allowpstnsserstobypasslobby), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                allowteamsmeetingreactions = group.Add(new VocabularyKey(nameof(allowteamsmeetingreactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                attendeeEngagementReport = group.Add(new VocabularyKey(nameof(attendeeEngagementReport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                attendeeurl = group.Add(new VocabularyKey(nameof(attendeeurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                audienceType = group.Add(new VocabularyKey(nameof(audienceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                autoadmittedusers = group.Add(new VocabularyKey(nameof(autoadmittedusers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                autorecordingenabled = group.Add(new VocabularyKey(nameof(autorecordingenabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AVSupport = group.Add(new VocabularyKey(nameof(AVSupport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                baseRecurrentSessionId = group.Add(new VocabularyKey(nameof(baseRecurrentSessionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                byInvitationOnly = group.Add(new VocabularyKey(nameof(byInvitationOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                calendarcontent = group.Add(new VocabularyKey(nameof(calendarcontent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                calendarcontentPlaintext = group.Add(new VocabularyKey(nameof(calendarcontentPlaintext), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                camerasPermitted = group.Add(new VocabularyKey(nameof(camerasPermitted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                changeMeetingOptions = group.Add(new VocabularyKey(nameof(changeMeetingOptions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                checkInCount = group.Add(new VocabularyKey(nameof(checkInCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                descriptorSyncStatus = group.Add(new VocabularyKey(nameof(descriptorSyncStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                detailedDescription = group.Add(new VocabularyKey(nameof(detailedDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                durationMins = group.Add(new VocabularyKey(nameof(durationMins), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                endTime = group.Add(new VocabularyKey(nameof(endTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                entryexitannouncementsenabled = group.Add(new VocabularyKey(nameof(entryexitannouncementsenabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                externalUrl = group.Add(new VocabularyKey(nameof(externalUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                flipChart = group.Add(new VocabularyKey(nameof(flipChart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                industry = group.Add(new VocabularyKey(nameof(industry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                internetConnection = group.Add(new VocabularyKey(nameof(internetConnection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isoutofsync = group.Add(new VocabularyKey(nameof(isoutofsync), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                keywords = group.Add(new VocabularyKey(nameof(keywords), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                language = group.Add(new VocabularyKey(nameof(language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastteamssyncdate = group.Add(new VocabularyKey(nameof(lastteamssyncdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NDA = group.Add(new VocabularyKey(nameof(NDA), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                presentationManagerURL = group.Add(new VocabularyKey(nameof(presentationManagerURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                previousNumberOfFreeSlots = group.Add(new VocabularyKey(nameof(previousNumberOfFreeSlots), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                publishStatus = group.Add(new VocabularyKey(nameof(publishStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                qna = group.Add(new VocabularyKey(nameof(qna), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                recordingforattendees = group.Add(new VocabularyKey(nameof(recordingforattendees), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                recordingforproducersandspeakers = group.Add(new VocabularyKey(nameof(recordingforproducersandspeakers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                recordingsPermitted = group.Add(new VocabularyKey(nameof(recordingsPermitted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                recurrencePattern = group.Add(new VocabularyKey(nameof(recurrencePattern), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                registrationCount = group.Add(new VocabularyKey(nameof(registrationCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sessionCode = group.Add(new VocabularyKey(nameof(sessionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sessionFormat = group.Add(new VocabularyKey(nameof(sessionFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sessionId = group.Add(new VocabularyKey(nameof(sessionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sessionMaxCapacity = group.Add(new VocabularyKey(nameof(sessionMaxCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sessionObjectives = group.Add(new VocabularyKey(nameof(sessionObjectives), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sessionPrerequisites = group.Add(new VocabularyKey(nameof(sessionPrerequisites), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sessionSummary = group.Add(new VocabularyKey(nameof(sessionSummary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sessionType = group.Add(new VocabularyKey(nameof(sessionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                startTime = group.Add(new VocabularyKey(nameof(startTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                streamingenabled = group.Add(new VocabularyKey(nameof(streamingenabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                streamingProvider = group.Add(new VocabularyKey(nameof(streamingProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                creationSource = group.Add(new VocabularyKey(nameof(creationSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                teamsinvitationhtml = group.Add(new VocabularyKey(nameof(teamsinvitationhtml), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                totalNumberOfQuestionsAsked = group.Add(new VocabularyKey(nameof(totalNumberOfQuestionsAsked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                videoConferencing = group.Add(new VocabularyKey(nameof(videoConferencing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                webinarID = group.Add(new VocabularyKey(nameof(webinarID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                webinarNotificationSeen = group.Add(new VocabularyKey(nameof(webinarNotificationSeen), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                webinarOperation = group.Add(new VocabularyKey(nameof(webinarOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                webinarStatus = group.Add(new VocabularyKey(nameof(webinarStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                webinarStatusReason = group.Add(new VocabularyKey(nameof(webinarStatusReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                webinarURL = group.Add(new VocabularyKey(nameof(webinarURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                whiteboard = group.Add(new VocabularyKey(nameof(whiteboard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey allowAttendeesToUnmute { get; private set; }
        public VocabularyKey allowMeetingChat { get; private set; }
        public VocabularyKey allowpstnsserstobypasslobby { get; private set; }
        public VocabularyKey allowteamsmeetingreactions { get; private set; }
        public VocabularyKey attendeeEngagementReport { get; private set; }
        public VocabularyKey attendeeurl { get; private set; }
        public VocabularyKey audienceType { get; private set; }
        public VocabularyKey autoadmittedusers { get; private set; }
        public VocabularyKey autorecordingenabled { get; private set; }
        public VocabularyKey AVSupport { get; private set; }
        public VocabularyKey baseRecurrentSessionId { get; private set; }
        public VocabularyKey byInvitationOnly { get; private set; }
        public VocabularyKey calendarcontent { get; private set; }
        public VocabularyKey calendarcontentPlaintext { get; private set; }
        public VocabularyKey camerasPermitted { get; private set; }
        public VocabularyKey changeMeetingOptions { get; private set; }
        public VocabularyKey checkInCount { get; private set; }
        public VocabularyKey descriptorSyncStatus { get; private set; }
        public VocabularyKey detailedDescription { get; private set; }
        public VocabularyKey durationMins { get; private set; }
        public VocabularyKey endTime { get; private set; }
        public VocabularyKey entryexitannouncementsenabled { get; private set; }
        public VocabularyKey externalUrl { get; private set; }
        public VocabularyKey flipChart { get; private set; }
        public VocabularyKey industry { get; private set; }
        public VocabularyKey internetConnection { get; private set; }
        public VocabularyKey isoutofsync { get; private set; }
        public VocabularyKey keywords { get; private set; }
        public VocabularyKey language { get; private set; }
        public VocabularyKey lastteamssyncdate { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey NDA { get; private set; }
        public VocabularyKey presentationManagerURL { get; private set; }
        public VocabularyKey previousNumberOfFreeSlots { get; private set; }
        public VocabularyKey publishStatus { get; private set; }
        public VocabularyKey qna { get; private set; }
        public VocabularyKey recordingforattendees { get; private set; }
        public VocabularyKey recordingforproducersandspeakers { get; private set; }
        public VocabularyKey recordingsPermitted { get; private set; }
        public VocabularyKey recurrencePattern { get; private set; }
        public VocabularyKey registrationCount { get; private set; }
        public VocabularyKey sessionCode { get; private set; }
        public VocabularyKey sessionFormat { get; private set; }
        public VocabularyKey sessionId { get; private set; }
        public VocabularyKey sessionMaxCapacity { get; private set; }
        public VocabularyKey sessionObjectives { get; private set; }
        public VocabularyKey sessionPrerequisites { get; private set; }
        public VocabularyKey sessionSummary { get; private set; }
        public VocabularyKey sessionType { get; private set; }
        public VocabularyKey startTime { get; private set; }
        public VocabularyKey streamingenabled { get; private set; }
        public VocabularyKey streamingProvider { get; private set; }
        public VocabularyKey creationSource { get; private set; }
        public VocabularyKey teamsinvitationhtml { get; private set; }
        public VocabularyKey totalNumberOfQuestionsAsked { get; private set; }
        public VocabularyKey videoConferencing { get; private set; }
        public VocabularyKey webinarID { get; private set; }
        public VocabularyKey webinarNotificationSeen { get; private set; }
        public VocabularyKey webinarOperation { get; private set; }
        public VocabularyKey webinarStatus { get; private set; }
        public VocabularyKey webinarStatusReason { get; private set; }
        public VocabularyKey webinarURL { get; private set; }
        public VocabularyKey whiteboard { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}