using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HotelRoomAllocationVocabulary : SimpleVocabulary
    {
        public HotelRoomAllocationVocabulary()
        {
            VocabularyName = "HotelRoomAllocation";
            KeyPrefix = "commonDataModel.hotelroomallocation";
            KeySeparator = ".";
            Grouping = "/HotelRoomAllocation";

            AddGroup("HotelRoomAllocation Details", group =>
            {
                exchangeRate = group.Add(new VocabularyKey(nameof(exchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                additionalDetails = group.Add(new VocabularyKey(nameof(additionalDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                hotelRoomAllocationId = group.Add(new VocabularyKey(nameof(hotelRoomAllocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                numberOfRoomsAllocated = group.Add(new VocabularyKey(nameof(numberOfRoomsAllocated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                numberOfRoomsLeft = group.Add(new VocabularyKey(nameof(numberOfRoomsLeft), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                numberOfRoomsReserved = group.Add(new VocabularyKey(nameof(numberOfRoomsReserved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                pricePerRoom = group.Add(new VocabularyKey(nameof(pricePerRoom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                pricePerRoomBase = group.Add(new VocabularyKey(nameof(pricePerRoomBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                roomType = group.Add(new VocabularyKey(nameof(roomType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey exchangeRate { get; private set; }
        public VocabularyKey additionalDetails { get; private set; }
        public VocabularyKey hotelRoomAllocationId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey numberOfRoomsAllocated { get; private set; }
        public VocabularyKey numberOfRoomsLeft { get; private set; }
        public VocabularyKey numberOfRoomsReserved { get; private set; }
        public VocabularyKey pricePerRoom { get; private set; }
        public VocabularyKey pricePerRoomBase { get; private set; }
        public VocabularyKey roomType { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}