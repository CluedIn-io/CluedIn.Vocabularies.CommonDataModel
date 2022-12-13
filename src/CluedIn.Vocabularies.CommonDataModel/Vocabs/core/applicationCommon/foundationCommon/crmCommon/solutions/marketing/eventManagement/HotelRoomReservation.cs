using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class HotelRoomReservationVocabulary : SimpleVocabulary
    {
        public HotelRoomReservationVocabulary()
        {
            VocabularyName = "Hotel Room Reservation";
            KeyPrefix = "commonDataModel.hotelroomreservation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.HotelRoomReservation;

            AddGroup("HotelRoomReservation Details for EventManagement", group =>
            {
                HotelRoomReservationId = group.Add(new VocabularyKey(nameof(HotelRoomReservationId), "Hotel Room Reservation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Reservation Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RewardsProgramNumber = group.Add(new VocabularyKey(nameof(RewardsProgramNumber), "Rewards Program Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialRequests = group.Add(new VocabularyKey(nameof(SpecialRequests), "Special Requests", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="Attendee"/> to Vocab 'EventRegistration.cdm.json/EventRegistration' with Property 'EventRegistrationId'
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
            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey HotelRoomReservationId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RewardsProgramNumber { get; private set; }
        public VocabularyKey SpecialRequests { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}