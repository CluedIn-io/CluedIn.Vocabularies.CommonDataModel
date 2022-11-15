using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HotelRoomAllocationVocabulary : SimpleVocabulary
    {
        public HotelRoomAllocationVocabulary()
        {
            VocabularyName = "Hotel Room Allocation";
            KeyPrefix = "commonDataModel.hotelroomallocation";
            KeySeparator = ".";
            Grouping = "/HotelRoomAllocation";

            AddGroup("HotelRoomAllocation Details", group =>
            {
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdditionalDetails = group.Add(new VocabularyKey(nameof(AdditionalDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HotelRoomAllocationId = group.Add(new VocabularyKey(nameof(HotelRoomAllocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfRoomsAllocated = group.Add(new VocabularyKey(nameof(NumberOfRoomsAllocated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfRoomsLeft = group.Add(new VocabularyKey(nameof(NumberOfRoomsLeft), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfRoomsReserved = group.Add(new VocabularyKey(nameof(NumberOfRoomsReserved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PricePerRoom = group.Add(new VocabularyKey(nameof(PricePerRoom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PricePerRoomBase = group.Add(new VocabularyKey(nameof(PricePerRoomBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoomType = group.Add(new VocabularyKey(nameof(RoomType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AdditionalDetails { get; private set; }
        public VocabularyKey HotelRoomAllocationId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NumberOfRoomsAllocated { get; private set; }
        public VocabularyKey NumberOfRoomsLeft { get; private set; }
        public VocabularyKey NumberOfRoomsReserved { get; private set; }
        public VocabularyKey PricePerRoom { get; private set; }
        public VocabularyKey PricePerRoomBase { get; private set; }
        public VocabularyKey RoomType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}