using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class CampaignResponseVocabulary : SimpleVocabulary
    {
        public CampaignResponseVocabulary()
        {
            VocabularyName = "Campaign Response";
            KeyPrefix = "commonDataModel.campaignresponse";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.CampaignResponse;

            AddGroup("CampaignResponse Details for CrmCommon", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Process Stage", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ChannelTypeCode = group.Add(new VocabularyKey(nameof(ChannelTypeCode), "Channel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CompanyName = group.Add(new VocabularyKey(nameof(CompanyName), "Company Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Customer = group.Add(new VocabularyKey(nameof(Customer), "Customer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmailAddress = group.Add(new VocabularyKey(nameof(EmailAddress), "Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    Fax = group.Add(new VocabularyKey(nameof(Fax), "Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FirstName = group.Add(new VocabularyKey(nameof(FirstName), "First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastName = group.Add(new VocabularyKey(nameof(LastName), "Last Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Partner = group.Add(new VocabularyKey(nameof(Partner), "Outsource Vendor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PromotionCodeName = group.Add(new VocabularyKey(nameof(PromotionCodeName), "Promotion Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReceivedOn = group.Add(new VocabularyKey(nameof(ReceivedOn), "Received On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResponseCode = group.Add(new VocabularyKey(nameof(ResponseCode), "Response Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone = group.Add(new VocabularyKey(nameof(Telephone), "Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    YomiCompanyName = group.Add(new VocabularyKey(nameof(YomiCompanyName), "Yomi Company Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YomiFirstName = group.Add(new VocabularyKey(nameof(YomiFirstName), "Yomi First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    YomiLastName = group.Add(new VocabularyKey(nameof(YomiLastName), "Yomi Last Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ServiceId = group.Add(new VocabularyKey(nameof(ServiceId), "Service", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="OriginatingActivityId"/> to Vocab 'Activity.cdm.json/Activity' with Property 'ActivityId'
            ///Property <see cref="OriginatingActivityId"/> to Vocab 'Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'CampaignActivity.cdm.json/CampaignActivity' with Property 'ActivityId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'BookableResourceBookingId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'BookableResourceBookingHeaderId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'QuickCampaign.cdm.json/QuickCampaign' with Property 'ActivityId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="OriginatingActivityId"/> to Vocab 'Email.cdm.json/Email' with Property 'ActivityId'
            ///Property <see cref="OriginatingActivityId"/> to Vocab 'Letter.cdm.json/Letter' with Property 'ActivityId'
            ///Property <see cref="OriginatingActivityId"/> to Vocab 'Fax.cdm.json/Fax' with Property 'ActivityId'
            ///Property <see cref="OriginatingActivityId"/> to Vocab 'RecurringAppointment.cdm.json/RecurringAppointment' with Property 'ActivityId'
            ///Property <see cref="OriginatingActivityId"/> to Vocab 'PhoneCall.cdm.json/PhoneCall' with Property 'ActivityId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ActivityId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'RelatedObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'accelerators/automotive/Lead.cdm.json/Lead' with Property 'RelatedObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'accelerators/financialServices/banking/Lead.cdm.json/Lead' with Property 'RelatedObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'accelerators/nonProfit/nonProfitForSales/Lead.cdm.json/Lead' with Property 'RelatedObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'projectCommon/Lead.cdm.json/Lead' with Property 'RelatedObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'solutions/marketing/Lead.cdm.json/Lead' with Property 'RelatedObjectId'
            #endregion
        }

        public VocabularyKey ChannelTypeCode { get; private set; }
        public VocabularyKey CompanyName { get; private set; }
        public VocabularyKey Customer { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey Partner { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey PromotionCodeName { get; private set; }
        public VocabularyKey ReceivedOn { get; private set; }
        public VocabularyKey ResponseCode { get; private set; }
        public VocabularyKey ServiceId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Telephone { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey YomiCompanyName { get; private set; }
        public VocabularyKey YomiFirstName { get; private set; }
        public VocabularyKey YomiLastName { get; private set; }
    }
}