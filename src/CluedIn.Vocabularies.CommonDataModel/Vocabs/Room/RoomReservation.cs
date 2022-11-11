using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RoomReservationVocabulary : SimpleVocabulary
    {
        public RoomReservationVocabulary()
        {
            VocabularyName = "RoomReservation";
            KeyPrefix = "commonDataModel.roomreservation";
            KeySeparator = ".";
            Grouping = "/RoomReservation";

            AddGroup("RoomReservation Details", group =>
            {
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                endTime = group.Add(new VocabularyKey(nameof(endTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                roomReservationId = group.Add(new VocabularyKey(nameof(roomReservationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                startTime = group.Add(new VocabularyKey(nameof(startTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey description { get; private set; }
        public VocabularyKey endTime { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey roomReservationId { get; private set; }
        public VocabularyKey startTime { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}