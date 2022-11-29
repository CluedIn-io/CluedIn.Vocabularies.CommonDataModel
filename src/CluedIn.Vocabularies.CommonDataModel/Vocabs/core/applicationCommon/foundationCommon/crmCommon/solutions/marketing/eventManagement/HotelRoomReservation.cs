using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class HotelRoomReservationVocabulary : SimpleVocabulary
    {
        public HotelRoomReservationVocabulary()
        {
            VocabularyName = "Hotel Room Reservation";
            KeyPrefix = "commonDataModel.hotelroomreservation.eventmanagement";
            KeySeparator = ".";
            Grouping = "/HotelRoomReservation";

            AddGroup("HotelRoomReservation Details for EventManagement", group =>
            {
			    HotelRoomReservationId = group.Add(new VocabularyKey(nameof(HotelRoomReservationId), "Hotel Room Reservation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Reservation Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RewardsProgramNumber = group.Add(new VocabularyKey(nameof(RewardsProgramNumber), "Rewards Program Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SpecialRequests = group.Add(new VocabularyKey(nameof(SpecialRequests), "Special Requests", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey HotelRoomReservationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RewardsProgramNumber { get; private set; }
        public VocabularyKey SpecialRequests { get; private set; }
    }
}