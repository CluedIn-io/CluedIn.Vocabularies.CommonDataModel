using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectCommon
{
    public class BookableResourceBookingVocabulary : SimpleVocabulary
    {
        public BookableResourceBookingVocabulary()
        {
            VocabularyName = "Bookable Resource Booking";
            KeyPrefix = "commonDataModel.bookableresourcebooking.projectcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.BookableResourceBooking;

            AddGroup("BookableResourceBooking Details for ProjectCommon", group =>
            {
			    ActualArrivalTime = group.Add(new VocabularyKey(nameof(ActualArrivalTime), "Actual Arrival Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualTravelDuration = group.Add(new VocabularyKey(nameof(ActualTravelDuration), "Actual Travel Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AllowOverlapping = group.Add(new VocabularyKey(nameof(AllowOverlapping), "Allow Overlapping", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    BookingMethod = group.Add(new VocabularyKey(nameof(BookingMethod), "Booking Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CascadeCrewChanges = group.Add(new VocabularyKey(nameof(CascadeCrewChanges), "Cascade Crew Changes", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AcceptCascadeCrewChanges = group.Add(new VocabularyKey(nameof(AcceptCascadeCrewChanges), "Accept Cascade Crew Changes", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Effort = group.Add(new VocabularyKey(nameof(Effort), "Capacity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EstimatedArrivalTime = group.Add(new VocabularyKey(nameof(EstimatedArrivalTime), "Estimated Arrival Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimatedTravelDuration = group.Add(new VocabularyKey(nameof(EstimatedTravelDuration), "Estimated Travel Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Latitude = group.Add(new VocabularyKey(nameof(Latitude), "Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Longitude = group.Add(new VocabularyKey(nameof(Longitude), "Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MilesTraveled = group.Add(new VocabularyKey(nameof(MilesTraveled), "Miles Traveled", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    WorkLocation = group.Add(new VocabularyKey(nameof(WorkLocation), "Work Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="Resource"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="Resource"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="ResourceGroup"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="BookableResourceId"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="BookingStatus"/> to Vocab 'BookingStatus.cdm.json/BookingStatus' with Property 'BookingStatusId'
            ///Property <see cref="Header"/> to Vocab 'BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'BookableResourceBookingHeaderId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="AppointmentBookingId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="BookingSetupMetadataId"/> to Vocab 'scheduling/BookingSetupMetadata.cdm.json/BookingSetupMetadata' with Property 'BookingSetupMetadataId'
            ///Property <see cref="RequirementGroup"/> to Vocab 'scheduling/RequirementGroup.cdm.json/RequirementGroup' with Property 'RequirementgroupId'
            ///Property <see cref="ResourceRequirement"/> to Vocab 'scheduling/ResourceRequirement.cdm.json/ResourceRequirement' with Property 'ResourceRequirementId'
            ///Property <see cref="TimeGroupDetailSelected"/> to Vocab 'scheduling/TimeGroupDetail.cdm.json/TimeGroupDetail' with Property 'TimeGroupDetailId'
            ///Property <see cref="ProjectId"/> to Vocab 'projectServiceAutomation/Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="ProjectTeamId"/> to Vocab 'projectServiceAutomation/ProjectTeam.cdm.json/ProjectTeam' with Property 'ProjectTeamId'
            ///Property <see cref="ResourceCategoryId"/> to Vocab 'projectServiceAutomation/BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="BookingStatusId"/> to Vocab 'BookingStatus.cdm.json/BookingStatus' with Property 'BookingStatusId'
            ///Property <see cref="ResourceRequirement"/> to Vocab 'scheduling/ResourceRequirement.cdm.json/ResourceRequirement' with Property 'ResourceRequirementId'
            ///Property <see cref="ProjectId"/> to Vocab 'projectServiceAutomation/Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="ProjectTeamId"/> to Vocab 'projectServiceAutomation/ProjectTeam.cdm.json/ProjectTeam' with Property 'ProjectTeamId'
            ///Property <see cref="ResourceCategoryId"/> to Vocab 'projectServiceAutomation/BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="Header"/> to Vocab 'BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'BookableResourceBookingHeaderId'
            ///Property <see cref="BookingStatus"/> to Vocab 'BookingStatus.cdm.json/BookingStatus' with Property 'BookingStatusId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab 'BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'Header'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'Header'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/CampaignActivity.cdm.json/CampaignActivity' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/QuickCampaign.cdm.json/QuickCampaign' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/CaseResolution.cdm.json/CaseResolution' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            #endregion
        }

        public VocabularyKey ActualArrivalTime { get; private set; }
        public VocabularyKey ActualTravelDuration { get; private set; }
        public VocabularyKey AllowOverlapping { get; private set; }
        public VocabularyKey BookingMethod { get; private set; }
        public VocabularyKey CascadeCrewChanges { get; private set; }
        public VocabularyKey AcceptCascadeCrewChanges { get; private set; }
        public VocabularyKey Effort { get; private set; }
        public VocabularyKey EstimatedArrivalTime { get; private set; }
        public VocabularyKey EstimatedTravelDuration { get; private set; }
        public VocabularyKey Latitude { get; private set; }
        public VocabularyKey Longitude { get; private set; }
        public VocabularyKey MilesTraveled { get; private set; }
        public VocabularyKey WorkLocation { get; private set; }
    }
}