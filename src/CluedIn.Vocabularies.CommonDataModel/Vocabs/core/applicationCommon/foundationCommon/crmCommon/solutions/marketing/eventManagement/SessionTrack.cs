using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class SessionTrackVocabulary : SimpleVocabulary
    {
        public SessionTrackVocabulary()
        {
            VocabularyName = "Session Track";
            KeyPrefix = "commonDataModel.sessiontrack.eventmanagement";
            KeySeparator = ".";
            Grouping = "/SessionTrack";

            AddGroup("SessionTrack Details for EventManagement", group =>
            {
			    SessionTrackId = group.Add(new VocabularyKey(nameof(SessionTrackId), "Session Track", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AudienceType = group.Add(new VocabularyKey(nameof(AudienceType), "Audience Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IndustryType = group.Add(new VocabularyKey(nameof(IndustryType), "Industry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Keywords = group.Add(new VocabularyKey(nameof(Keywords), "Keywords", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfRegistrations = group.Add(new VocabularyKey(nameof(NumberOfRegistrations), "Number of Registrations", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    PublishStatus = group.Add(new VocabularyKey(nameof(PublishStatus), "Publish Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SessionsInTrack = group.Add(new VocabularyKey(nameof(SessionsInTrack), "Sessions in track", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TargetNumberOfSessions = group.Add(new VocabularyKey(nameof(TargetNumberOfSessions), "Target number of sessions", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TrackCode = group.Add(new VocabularyKey(nameof(TrackCode), "Track code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TrackGoal = group.Add(new VocabularyKey(nameof(TrackGoal), "Track goal", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TrackType = group.Add(new VocabularyKey(nameof(TrackType), "Track Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SessionTrackId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AudienceType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IndustryType { get; private set; }
        public VocabularyKey Keywords { get; private set; }
        public VocabularyKey NumberOfRegistrations { get; private set; }
        public VocabularyKey PublishStatus { get; private set; }
        public VocabularyKey SessionsInTrack { get; private set; }
        public VocabularyKey TargetNumberOfSessions { get; private set; }
        public VocabularyKey TrackCode { get; private set; }
        public VocabularyKey TrackGoal { get; private set; }
        public VocabularyKey TrackType { get; private set; }
    }
}