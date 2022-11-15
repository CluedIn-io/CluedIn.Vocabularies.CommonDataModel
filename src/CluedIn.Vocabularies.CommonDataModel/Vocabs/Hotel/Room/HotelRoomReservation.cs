using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HotelRoomReservationVocabulary : SimpleVocabulary
    {
        public HotelRoomReservationVocabulary()
        {
            VocabularyName = "Hotel Room Reservation";
            KeyPrefix = "commonDataModel.hotelroomreservation";
            KeySeparator = ".";
            Grouping = "/HotelRoomReservation";

            AddGroup("HotelRoomReservation Details", group =>
            {
                GuestType = group.Add(new VocabularyKey(nameof(GuestType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HotelRoomReservationId = group.Add(new VocabularyKey(nameof(HotelRoomReservationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RewardsProgramNumber = group.Add(new VocabularyKey(nameof(RewardsProgramNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialRequests = group.Add(new VocabularyKey(nameof(SpecialRequests), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GuestType { get; private set; }
        public VocabularyKey HotelRoomReservationId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RewardsProgramNumber { get; private set; }
        public VocabularyKey SpecialRequests { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}