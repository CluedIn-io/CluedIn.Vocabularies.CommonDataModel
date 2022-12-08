using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectCommon
{
    public class BookableResourceBookingHeaderVocabulary : SimpleVocabulary
    {
        public BookableResourceBookingHeaderVocabulary()
        {
            VocabularyName = "Bookable Resource Booking Header";
            KeyPrefix = "commonDataModel.bookableresourcebookingheader.projectcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.BookableResourceBookingHeader;

            AddGroup("BookableResourceBookingHeader Details for ProjectCommon", group =>
            {
			    BookingType = group.Add(new VocabularyKey(nameof(BookingType), "Booking Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="BookableResourceId"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
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

        public VocabularyKey BookingType { get; private set; }
    }
}