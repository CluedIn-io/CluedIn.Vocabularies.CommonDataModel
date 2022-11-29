using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class RoomVocabulary : SimpleVocabulary
    {
        public RoomVocabulary()
        {
            VocabularyName = "Room";
            KeyPrefix = "commonDataModel.room.eventmanagement";
            KeySeparator = ".";
            Grouping = "/Room";

            AddGroup("Room Details for EventManagement", group =>
            {
			    RoomId = group.Add(new VocabularyKey(nameof(RoomId), "Room", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AVSupport = group.Add(new VocabularyKey(nameof(AVSupport), "A/V support", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Capacity = group.Add(new VocabularyKey(nameof(Capacity), "Capacity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisabledAccess = group.Add(new VocabularyKey(nameof(DisabledAccess), "Disabled Access", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InternetConnection = group.Add(new VocabularyKey(nameof(InternetConnection), "Internet connection", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Other = group.Add(new VocabularyKey(nameof(Other), "Other", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VideoConferencing = group.Add(new VocabularyKey(nameof(VideoConferencing), "Video conferencing", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WhiteBoard = group.Add(new VocabularyKey(nameof(WhiteBoard), "Whiteboard", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RoomId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AVSupport { get; private set; }
        public VocabularyKey Capacity { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DisabledAccess { get; private set; }
        public VocabularyKey InternetConnection { get; private set; }
        public VocabularyKey Other { get; private set; }
        public VocabularyKey VideoConferencing { get; private set; }
        public VocabularyKey WhiteBoard { get; private set; }
    }
}