using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class QuickCampaignVocabulary : SimpleVocabulary
    {
        public QuickCampaignVocabulary()
        {
            VocabularyName = "Quick Campaign";
            KeyPrefix = "commonDataModel.quickcampaign";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.QuickCampaign;

            AddGroup("QuickCampaign Details for CrmCommon", group =>
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
			    BulkOperationNumber = group.Add(new VocabularyKey(nameof(BulkOperationNumber), "Bulk Operation Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedRecordTypeCode = group.Add(new VocabularyKey(nameof(CreatedRecordTypeCode), "Activity Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ErrorNumber = group.Add(new VocabularyKey(nameof(ErrorNumber), "Error Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    FailureCount = group.Add(new VocabularyKey(nameof(FailureCount), "No. of Failures", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OperationTypeCode = group.Add(new VocabularyKey(nameof(OperationTypeCode), "Operation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WorkflowInfo = group.Add(new VocabularyKey(nameof(WorkflowInfo), "Workflow information", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Parameters = group.Add(new VocabularyKey(nameof(Parameters), "Parameters", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SuccessCount = group.Add(new VocabularyKey(nameof(SuccessCount), "No. of Successes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TargetedRecordTypeCode = group.Add(new VocabularyKey(nameof(TargetedRecordTypeCode), "Members Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TargetMembersCount = group.Add(new VocabularyKey(nameof(TargetMembersCount), "Total Members", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ServiceId = group.Add(new VocabularyKey(nameof(ServiceId), "Service", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'CampaignActivity.cdm.json/CampaignActivity' with Property 'ActivityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'MarketingList.cdm.json/MarketingList' with Property 'ListId'
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
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'BookableResourceBookingHeaderId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ActivityId"/> from Vocab 'CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'service/CaseResolution.cdm.json/CaseResolution' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            #endregion
        }

        public VocabularyKey BulkOperationNumber { get; private set; }
        public VocabularyKey CreatedRecordTypeCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ErrorNumber { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey FailureCount { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey OperationTypeCode { get; private set; }
        public VocabularyKey Parameters { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey ServiceId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SuccessCount { get; private set; }
        public VocabularyKey TargetedRecordTypeCode { get; private set; }
        public VocabularyKey TargetMembersCount { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey WorkflowInfo { get; private set; }
    }
}