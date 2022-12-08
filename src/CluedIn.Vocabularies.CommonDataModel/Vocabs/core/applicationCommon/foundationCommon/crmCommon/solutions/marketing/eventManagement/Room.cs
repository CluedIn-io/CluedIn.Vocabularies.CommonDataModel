using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.EventManagement
{
    public class RoomVocabulary : SimpleVocabulary
    {
        public RoomVocabulary()
        {
            VocabularyName = "Room";
            KeyPrefix = "commonDataModel.room.eventmanagement";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Room;

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
            
            #region Incoming Relationships
            ///Property <see cref="Building"/> to Vocab 'Building.cdm.json/Building' with Property 'BuildingId'
            ///Property <see cref="Event"/> to Vocab 'Event.cdm.json/Event' with Property 'EventId'
            ///Property <see cref="Attendee"/> to Vocab 'EventRegistration.cdm.json/EventRegistration' with Property 'EventRegistrationId'
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
            ///Property <see cref="HotelRoomAllocation"/> to Vocab 'HotelRoomAllocation.cdm.json/HotelRoomAllocation' with Property 'HotelRoomAllocationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="PrimaryContact"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'ContactId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="HotelRoomAllocationId"/> from Vocab 'HotelRoomReservation.cdm.json/HotelRoomReservation' with Property 'HotelRoomAllocation'
            ///Property <see cref="RoomId"/> from Vocab 'Layout.cdm.json/Layout' with Property 'Room'
            ///Property <see cref="RoomId"/> from Vocab 'Venue.cdm.json/Venue' with Property 'RoomId'
            #endregion
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