using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CrmCommon
{
    public class CampaignActivityVocabulary : SimpleVocabulary
    {
        public CampaignActivityVocabulary()
        {
            VocabularyName = "Campaign Activity";
            KeyPrefix = "commonDataModel.campaignactivity.crmcommon";
            KeySeparator = ".";
            Grouping = "/CampaignActivity";

            AddGroup("CampaignActivity Details for CrmCommon", group =>
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
			    ActualCost = group.Add(new VocabularyKey(nameof(ActualCost), "Actual Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActualCostBase = group.Add(new VocabularyKey(nameof(ActualCostBase), "Actual Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BudgetedCost = group.Add(new VocabularyKey(nameof(BudgetedCost), "Budget Allocated", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BudgetedCostBase = group.Add(new VocabularyKey(nameof(BudgetedCostBase), "Budget Allocated (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ChannelTypeCode = group.Add(new VocabularyKey(nameof(ChannelTypeCode), "Channel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DoNotSendOnOptOut = group.Add(new VocabularyKey(nameof(DoNotSendOnOptOut), "Exclude Members Who Opt Out", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ExcludeIfContactedInXDays = group.Add(new VocabularyKey(nameof(ExcludeIfContactedInXDays), "No. of Days", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    IgnoreInactiveListMembers = group.Add(new VocabularyKey(nameof(IgnoreInactiveListMembers), "Ignore Inactive Marketing List Members", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TypeCode = group.Add(new VocabularyKey(nameof(TypeCode), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ServiceId = group.Add(new VocabularyKey(nameof(ServiceId), "Service", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey ActualCost { get; private set; }
        public VocabularyKey ActualCostBase { get; private set; }
        public VocabularyKey BudgetedCost { get; private set; }
        public VocabularyKey BudgetedCostBase { get; private set; }
        public VocabularyKey ChannelTypeCode { get; private set; }
        public VocabularyKey DoNotSendOnOptOut { get; private set; }
        public VocabularyKey ExcludeIfContactedInXDays { get; private set; }
        public VocabularyKey IgnoreInactiveListMembers { get; private set; }
        public VocabularyKey TypeCode { get; private set; }
        public VocabularyKey ServiceId { get; private set; }
    }
}