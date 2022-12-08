using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.EventManagement
{
    public class HotelRoomAllocationVocabulary : SimpleVocabulary
    {
        public HotelRoomAllocationVocabulary()
        {
            VocabularyName = "Hotel Room Allocation";
            KeyPrefix = "commonDataModel.hotelroomallocation.eventmanagement";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.HotelRoomAllocation;

            AddGroup("HotelRoomAllocation Details for EventManagement", group =>
            {
			    HotelRoomAllocationId = group.Add(new VocabularyKey(nameof(HotelRoomAllocationId), "Hotel Room Allocation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdditionalDetails = group.Add(new VocabularyKey(nameof(AdditionalDetails), "Additional Details", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfRoomsAllocated = group.Add(new VocabularyKey(nameof(NumberOfRoomsAllocated), "Number of rooms allocated", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    PricePerRoom = group.Add(new VocabularyKey(nameof(PricePerRoom), "Price per room", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PricePerRoomBase = group.Add(new VocabularyKey(nameof(PricePerRoomBase), "Price per Room (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RoomType = group.Add(new VocabularyKey(nameof(RoomType), "Room Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfRoomsLeft = group.Add(new VocabularyKey(nameof(NumberOfRoomsLeft), "Number of rooms left", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    NumberofRoomsReserved = group.Add(new VocabularyKey(nameof(NumberofRoomsReserved), "Number of rooms reserved", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    NumberofRoomsReservedDate = group.Add(new VocabularyKey(nameof(NumberofRoomsReservedDate), "Number of rooms reserved (Last Updated On)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberofRoomsReservedState = group.Add(new VocabularyKey(nameof(NumberofRoomsReservedState), "Number of rooms reserved (State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="Event"/> to Vocab 'Event.cdm.json/Event' with Property 'EventId'
            ///Property <see cref="HotelProperty"/> to Vocab 'Hotel.cdm.json/Hotel' with Property 'HotelId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="PrimaryContact"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'ContactId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="HotelRoomAllocationId"/> from Vocab 'HotelRoomReservation.cdm.json/HotelRoomReservation' with Property 'HotelRoomAllocation'
            #endregion
        }

        public VocabularyKey HotelRoomAllocationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AdditionalDetails { get; private set; }
        public VocabularyKey NumberOfRoomsAllocated { get; private set; }
        public VocabularyKey PricePerRoom { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey PricePerRoomBase { get; private set; }
        public VocabularyKey RoomType { get; private set; }
        public VocabularyKey NumberOfRoomsLeft { get; private set; }
        public VocabularyKey NumberofRoomsReserved { get; private set; }
        public VocabularyKey NumberofRoomsReservedDate { get; private set; }
        public VocabularyKey NumberofRoomsReservedState { get; private set; }
    }
}