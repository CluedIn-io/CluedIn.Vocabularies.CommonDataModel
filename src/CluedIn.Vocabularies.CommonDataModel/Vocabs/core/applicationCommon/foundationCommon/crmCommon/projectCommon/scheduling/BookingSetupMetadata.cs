using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class BookingSetupMetadataVocabulary : SimpleVocabulary
    {
        public BookingSetupMetadataVocabulary()
        {
            VocabularyName = "Booking Setup Metadata";
            KeyPrefix = "commonDataModel.bookingsetupmetadata.scheduling";
            KeySeparator = ".";
            Grouping = "/BookingSetupMetadata";

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
        }

        public VocabularyKey BookingSetupMetadataId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey EntityLogicalName { get; private set; }
        public VocabularyKey AvailableDurationMinimumPercentage { get; private set; }
        public VocabularyKey BookingRelationshipLogicalName { get; private set; }
        public VocabularyKey BookingStatusFieldLogicalName { get; private set; }
        public VocabularyKey CancelBookingsWhenMoving { get; private set; }
        public VocabularyKey DefaultBookingDuration { get; private set; }
        public VocabularyKey DisableRequirementAutoCreation { get; private set; }
        public VocabularyKey RequirementRelationshipLogicalName { get; private set; }
        public VocabularyKey ResourceAvailabilityRetrievalLimit { get; private set; }
    }
}