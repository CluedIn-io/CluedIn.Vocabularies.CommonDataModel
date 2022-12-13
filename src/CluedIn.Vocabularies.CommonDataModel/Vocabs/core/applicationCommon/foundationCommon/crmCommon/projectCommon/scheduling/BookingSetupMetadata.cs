using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class BookingSetupMetadataVocabulary : SimpleVocabulary
    {
        public BookingSetupMetadataVocabulary()
        {
            VocabularyName = "Booking Setup Metadata";
            KeyPrefix = "commonDataModel.bookingsetupmetadata";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.BookingSetupMetadata;

            AddGroup("BookingSetupMetadata Details for Scheduling", group =>
            {
                BookingSetupMetadataId = group.Add(new VocabularyKey(nameof(BookingSetupMetadataId), "Booking Setup Metadata", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityLogicalName = group.Add(new VocabularyKey(nameof(EntityLogicalName), "Entity Logical Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AvailableDurationMinimumPercentage = group.Add(new VocabularyKey(nameof(AvailableDurationMinimumPercentage), "Available Duration Minimum(%)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                BookingRelationshipLogicalName = group.Add(new VocabularyKey(nameof(BookingRelationshipLogicalName), "Booking Relationship Logical Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BookingStatusFieldLogicalName = group.Add(new VocabularyKey(nameof(BookingStatusFieldLogicalName), "Booking Status Field Logical Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CancelBookingsWhenMoving = group.Add(new VocabularyKey(nameof(CancelBookingsWhenMoving), "Cancel Bookings When Moving", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DefaultBookingDuration = group.Add(new VocabularyKey(nameof(DefaultBookingDuration), "Default Booking Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                DisableRequirementAutoCreation = group.Add(new VocabularyKey(nameof(DisableRequirementAutoCreation), "Disable Requirement Auto Creation for Bookings", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                RequirementRelationshipLogicalName = group.Add(new VocabularyKey(nameof(RequirementRelationshipLogicalName), "Requirement Relationship Logical Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceAvailabilityRetrievalLimit = group.Add(new VocabularyKey(nameof(ResourceAvailabilityRetrievalLimit), "Resource Availability Retrieval Limit", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CloneEntityQuery"/> to Vocab 'Configuration.cdm.json/Configuration' with Property 'ConfigurationId'
            ///Property <see cref="DefaultBookingCanceledStatus"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookingStatus.cdm.json/BookingStatus' with Property 'BookingStatusId'
            ///Property <see cref="DefaultBookingCommittedStatus"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookingStatus.cdm.json/BookingStatus' with Property 'BookingStatusId'
            ///Property <see cref="DefaultRequirementActiveStatus"/> to Vocab 'RequirementStatus.cdm.json/RequirementStatus' with Property 'RequirementStatusId'
            ///Property <see cref="DefaultRequirementCanceledStatus"/> to Vocab 'RequirementStatus.cdm.json/RequirementStatus' with Property 'RequirementStatusId'
            ///Property <see cref="DefaultRequirementCompletedStatus"/> to Vocab 'RequirementStatus.cdm.json/RequirementStatus' with Property 'RequirementStatusId'
            ///Property <see cref="RetrieveConstraintsQuery"/> to Vocab 'Configuration.cdm.json/Configuration' with Property 'ConfigurationId'
            ///Property <see cref="RetrieveResourcesQuery"/> to Vocab 'Configuration.cdm.json/Configuration' with Property 'ConfigurationId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="BookingSetupMetadataId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'BookingSetupMetadataId'
            ///Property <see cref="BookingSetupMetadataId"/> from Vocab 'ResourceRequirement.cdm.json/ResourceRequirement' with Property 'BookingSetupMetadataId'
            #endregion
        }

        public VocabularyKey AvailableDurationMinimumPercentage { get; private set; }
        public VocabularyKey BookingRelationshipLogicalName { get; private set; }
        public VocabularyKey BookingSetupMetadataId { get; private set; }
        public VocabularyKey BookingStatusFieldLogicalName { get; private set; }
        public VocabularyKey CancelBookingsWhenMoving { get; private set; }
        public VocabularyKey DefaultBookingDuration { get; private set; }
        public VocabularyKey DisableRequirementAutoCreation { get; private set; }
        public VocabularyKey EntityLogicalName { get; private set; }
        public VocabularyKey RequirementRelationshipLogicalName { get; private set; }
        public VocabularyKey ResourceAvailabilityRetrievalLimit { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}