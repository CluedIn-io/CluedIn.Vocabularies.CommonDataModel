using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SessionTrackVocabulary : SimpleVocabulary
    {
        public SessionTrackVocabulary()
        {
            VocabularyName = "Session Track";
            KeyPrefix = "commonDataModel.sessiontrack";
            KeySeparator = ".";
            Grouping = "/SessionTrack";

            AddGroup("SessionTrack Details", group =>
            {
                AudienceType = group.Add(new VocabularyKey(nameof(AudienceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndustryType = group.Add(new VocabularyKey(nameof(IndustryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Keywords = group.Add(new VocabularyKey(nameof(Keywords), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfRegistrations = group.Add(new VocabularyKey(nameof(NumberOfRegistrations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PublishStatus = group.Add(new VocabularyKey(nameof(PublishStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionsInTrack = group.Add(new VocabularyKey(nameof(SessionsInTrack), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionTrackId = group.Add(new VocabularyKey(nameof(SessionTrackId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetNumberOfSessions = group.Add(new VocabularyKey(nameof(TargetNumberOfSessions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrackCode = group.Add(new VocabularyKey(nameof(TrackCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrackGoal = group.Add(new VocabularyKey(nameof(TrackGoal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrackType = group.Add(new VocabularyKey(nameof(TrackType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AudienceType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IndustryType { get; private set; }
        public VocabularyKey Keywords { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NumberOfRegistrations { get; private set; }
        public VocabularyKey PublishStatus { get; private set; }
        public VocabularyKey SessionsInTrack { get; private set; }
        public VocabularyKey SessionTrackId { get; private set; }
        public VocabularyKey TargetNumberOfSessions { get; private set; }
        public VocabularyKey TrackCode { get; private set; }
        public VocabularyKey TrackGoal { get; private set; }
        public VocabularyKey TrackType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}