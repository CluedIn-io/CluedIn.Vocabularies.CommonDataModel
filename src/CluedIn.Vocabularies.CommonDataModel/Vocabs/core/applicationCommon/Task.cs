using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class TaskVocabulary : SimpleVocabulary
    {
        public TaskVocabulary()
        {
            VocabularyName = "Task";
            KeyPrefix = "commonDataModel.task.applicationcommon";
            KeySeparator = ".";
            Grouping = "/Task";

            AddGroup("Task Details for ApplicationCommon", group =>
            {
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Activity Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PercentComplete = group.Add(new VocabularyKey(nameof(PercentComplete), "Percent Complete", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Process Stage", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CrmTaskAssignedUniqueId = group.Add(new VocabularyKey(nameof(CrmTaskAssignedUniqueId), "Assigned Task Unique Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PercentComplete { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey CrmTaskAssignedUniqueId { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
    }
}