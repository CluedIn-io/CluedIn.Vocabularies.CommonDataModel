using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RoomVocabulary : SimpleVocabulary
    {
        public RoomVocabulary()
        {
            VocabularyName = "Common Data Model Room";
            KeyPrefix = "commonDataModel.room";
            KeySeparator = ".";
            Grouping = "/Room";

            AddGroup("Common Data Model Room Details", group =>
            {
                AVSupport = group.Add(new VocabularyKey(nameof(AVSupport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                capacity = group.Add(new VocabularyKey(nameof(capacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                disabledAccess = group.Add(new VocabularyKey(nameof(disabledAccess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                internetConnection = group.Add(new VocabularyKey(nameof(internetConnection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                other = group.Add(new VocabularyKey(nameof(other), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                roomId = group.Add(new VocabularyKey(nameof(roomId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                videoConferencing = group.Add(new VocabularyKey(nameof(videoConferencing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                whiteboard = group.Add(new VocabularyKey(nameof(whiteboard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AVSupport { get; private set; }
        public VocabularyKey capacity { get; private set; }
        public VocabularyKey description { get; private set; }
        public VocabularyKey disabledAccess { get; private set; }
        public VocabularyKey internetConnection { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey other { get; private set; }
        public VocabularyKey roomId { get; private set; }
        public VocabularyKey videoConferencing { get; private set; }
        public VocabularyKey whiteboard { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}