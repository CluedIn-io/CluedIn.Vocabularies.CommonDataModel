using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CrmCommon
{
    public class QuickCampaignVocabulary : SimpleVocabulary
    {
        public QuickCampaignVocabulary()
        {
            VocabularyName = "Quick Campaign";
            KeyPrefix = "commonDataModel.quickcampaign.crmcommon";
            KeySeparator = ".";
            Grouping = "/QuickCampaign";

            AddGroup("QuickCampaign Details for CrmCommon", group =>
            {
			    Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Subcategory = group.Add(new VocabularyKey(nameof(Subcategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
        }

        public VocabularyKey Category { get; private set; }
        public VocabularyKey Subcategory { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey BulkOperationNumber { get; private set; }
        public VocabularyKey CreatedRecordTypeCode { get; private set; }
        public VocabularyKey ErrorNumber { get; private set; }
        public VocabularyKey FailureCount { get; private set; }
        public VocabularyKey OperationTypeCode { get; private set; }
        public VocabularyKey WorkflowInfo { get; private set; }
        public VocabularyKey Parameters { get; private set; }
        public VocabularyKey SuccessCount { get; private set; }
        public VocabularyKey TargetedRecordTypeCode { get; private set; }
        public VocabularyKey TargetMembersCount { get; private set; }
        public VocabularyKey ServiceId { get; private set; }
    }
}