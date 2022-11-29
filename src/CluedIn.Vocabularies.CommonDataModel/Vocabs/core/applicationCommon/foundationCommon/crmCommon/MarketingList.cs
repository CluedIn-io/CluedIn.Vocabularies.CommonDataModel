using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CrmCommon
{
    public class MarketingListVocabulary : SimpleVocabulary
    {
        public MarketingListVocabulary()
        {
            VocabularyName = "Marketing List";
            KeyPrefix = "commonDataModel.marketinglist.crmcommon";
            KeySeparator = ".";
            Grouping = "/MarketingList";

            AddGroup("MarketingList Details for CrmCommon", group =>
            {
			    ListId = group.Add(new VocabularyKey(nameof(ListId), "List", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ListName = group.Add(new VocabularyKey(nameof(ListName), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Cost = group.Add(new VocabularyKey(nameof(Cost), "Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CostBase = group.Add(new VocabularyKey(nameof(CostBase), "Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedFromCode = group.Add(new VocabularyKey(nameof(CreatedFromCode), "Marketing List Member Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DoNotSendOnOptOut = group.Add(new VocabularyKey(nameof(DoNotSendOnOptOut), "Exclude Members Who Opt Out", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IgnoreInactiveListMembers = group.Add(new VocabularyKey(nameof(IgnoreInactiveListMembers), "Ignore Inactive List Members", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LastUsedOn = group.Add(new VocabularyKey(nameof(LastUsedOn), "Last Used On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LockStatus = group.Add(new VocabularyKey(nameof(LockStatus), "Locked", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MemberCount = group.Add(new VocabularyKey(nameof(MemberCount), "Members Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    MemberType = group.Add(new VocabularyKey(nameof(MemberType), "Member Type", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Purpose = group.Add(new VocabularyKey(nameof(Purpose), "Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Query = group.Add(new VocabularyKey(nameof(Query), "Query", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Source = group.Add(new VocabularyKey(nameof(Source), "Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ListId { get; private set; }
        public VocabularyKey ListName { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey Cost { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CostBase { get; private set; }
        public VocabularyKey CreatedFromCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DoNotSendOnOptOut { get; private set; }
        public VocabularyKey IgnoreInactiveListMembers { get; private set; }
        public VocabularyKey LastUsedOn { get; private set; }
        public VocabularyKey LockStatus { get; private set; }
        public VocabularyKey MemberCount { get; private set; }
        public VocabularyKey MemberType { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey Query { get; private set; }
        public VocabularyKey Source { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}