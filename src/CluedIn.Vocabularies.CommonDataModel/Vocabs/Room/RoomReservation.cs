using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RoomReservationVocabulary : SimpleVocabulary
    {
        public RoomReservationVocabulary()
        {
            VocabularyName = "Room Reservation";
            KeyPrefix = "commonDataModel.roomreservation";
            KeySeparator = ".";
            Grouping = "/RoomReservation";

            AddGroup("RoomReservation Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndTime = group.Add(new VocabularyKey(nameof(EndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoomReservationId = group.Add(new VocabularyKey(nameof(RoomReservationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartTime = group.Add(new VocabularyKey(nameof(StartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndTime { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RoomReservationId { get; private set; }
        public VocabularyKey StartTime { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}