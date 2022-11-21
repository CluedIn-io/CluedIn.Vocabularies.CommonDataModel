using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RoomVocabulary : SimpleVocabulary
    {
        public RoomVocabulary()
        {
            VocabularyName = "Room";
            KeyPrefix = "commonDataModel.room";
            KeySeparator = ".";
            Grouping = "/Room";

            AddGroup("Room Details", group =>
            {
                AVSupport = group.Add(new VocabularyKey(nameof(AVSupport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Capacity = group.Add(new VocabularyKey(nameof(Capacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisabledAccess = group.Add(new VocabularyKey(nameof(DisabledAccess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternetConnection = group.Add(new VocabularyKey(nameof(InternetConnection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Other = group.Add(new VocabularyKey(nameof(Other), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoomId = group.Add(new VocabularyKey(nameof(RoomId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VideoConferencing = group.Add(new VocabularyKey(nameof(VideoConferencing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Whiteboard = group.Add(new VocabularyKey(nameof(Whiteboard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AVSupport { get; private set; }
        public VocabularyKey Capacity { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DisabledAccess { get; private set; }
        public VocabularyKey InternetConnection { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Other { get; private set; }
        public VocabularyKey RoomId { get; private set; }
        public VocabularyKey VideoConferencing { get; private set; }
        public VocabularyKey Whiteboard { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}