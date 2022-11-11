using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HotelRoomReservationVocabulary : SimpleVocabulary
    {
        public HotelRoomReservationVocabulary()
        {
            VocabularyName = "HotelRoomReservation";
            KeyPrefix = "commonDataModel.hotelroomreservation";
            KeySeparator = ".";
            Grouping = "/HotelRoomReservation";

            AddGroup("HotelRoomReservation Details", group =>
            {
                guestType = group.Add(new VocabularyKey(nameof(guestType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                hotelRoomReservationId = group.Add(new VocabularyKey(nameof(hotelRoomReservationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                rewardsProgramNumber = group.Add(new VocabularyKey(nameof(rewardsProgramNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                specialRequests = group.Add(new VocabularyKey(nameof(specialRequests), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey guestType { get; private set; }
        public VocabularyKey hotelRoomReservationId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey rewardsProgramNumber { get; private set; }
        public VocabularyKey specialRequests { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}