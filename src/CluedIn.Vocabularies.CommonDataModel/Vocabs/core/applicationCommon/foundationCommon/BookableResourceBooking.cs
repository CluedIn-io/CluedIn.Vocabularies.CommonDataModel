using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.FoundationCommon
{
    public class BookableResourceBookingVocabulary : SimpleVocabulary
    {
        public BookableResourceBookingVocabulary()
        {
            VocabularyName = "Bookable Resource Booking";
            KeyPrefix = "commonDataModel.bookableresourcebooking.foundationcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.BookableResourceBooking;

            AddGroup("BookableResourceBooking Details for FoundationCommon", group =>
            {
			    BookableResourceBookingId = group.Add(new VocabularyKey(nameof(BookableResourceBookingId), "Bookable Resource Booking", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BookingType = group.Add(new VocabularyKey(nameof(BookingType), "Booking Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Duration = group.Add(new VocabularyKey(nameof(Duration), "Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    EndTime = group.Add(new VocabularyKey(nameof(EndTime), "End Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartTime = group.Add(new VocabularyKey(nameof(StartTime), "Start Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="Resource"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="BookingStatus"/> to Vocab 'BookingStatus.cdm.json/BookingStatus' with Property 'BookingStatusId'
            ///Property <see cref="Header"/> to Vocab 'BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'BookableResourceBookingHeaderId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab 'BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'Header'
            ///Property <see cref="BookableResourceBookingId"/> from Vocab 'crmCommon/CampaignActivity.cdm.json/CampaignActivity' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingId"/> from Vocab 'crmCommon/CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingId"/> from Vocab 'crmCommon/QuickCampaign.cdm.json/QuickCampaign' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingId"/> from Vocab 'crmCommon/sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingId"/> from Vocab 'crmCommon/sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingId"/> from Vocab 'crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingId"/> from Vocab 'crmCommon/service/CaseResolution.cdm.json/CaseResolution' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingId"/> from Vocab 'crmCommon/service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingId"/> from Vocab 'crmCommon/solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab 'crmCommon/CampaignActivity.cdm.json/CampaignActivity' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab 'crmCommon/CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab 'crmCommon/QuickCampaign.cdm.json/QuickCampaign' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab 'crmCommon/sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab 'crmCommon/sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab 'crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab 'crmCommon/service/CaseResolution.cdm.json/CaseResolution' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab 'crmCommon/service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="BookableResourceBookingHeaderId"/> from Vocab 'crmCommon/solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            #endregion
        }

        public VocabularyKey BookableResourceBookingId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey BookingType { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey EndTime { get; private set; }
        public VocabularyKey StartTime { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}