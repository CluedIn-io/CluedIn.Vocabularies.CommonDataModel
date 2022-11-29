using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class TimeEntryVocabulary : SimpleVocabulary
    {
        public TimeEntryVocabulary()
        {
            VocabularyName = "Time Entry";
            KeyPrefix = "commonDataModel.timeentry.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/TimeEntry";

            AddGroup("TimeEntry Details for ProjectServiceAutomation", group =>
            {
			    TimeEntryId = group.Add(new VocabularyKey(nameof(TimeEntryId), "Time Entry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InternalComments = group.Add(new VocabularyKey(nameof(InternalComments), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "(Deprecated) Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "(Deprecated) Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Date = group.Add(new VocabularyKey(nameof(Date), "Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Duration = group.Add(new VocabularyKey(nameof(Duration), "Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    EntryStatus = group.Add(new VocabularyKey(nameof(EntryStatus), "Entry Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalDescription = group.Add(new VocabularyKey(nameof(ExternalDescription), "External Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RelatedItemId = group.Add(new VocabularyKey(nameof(RelatedItemId), "Related item identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RelatedItemType = group.Add(new VocabularyKey(nameof(RelatedItemType), "Related item type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TargetEntryStatus = group.Add(new VocabularyKey(nameof(TargetEntryStatus), "Target Entry Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey TimeEntryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey InternalComments { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey EntryStatus { get; private set; }
        public VocabularyKey ExternalDescription { get; private set; }
        public VocabularyKey RelatedItemId { get; private set; }
        public VocabularyKey RelatedItemType { get; private set; }
        public VocabularyKey TargetEntryStatus { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}