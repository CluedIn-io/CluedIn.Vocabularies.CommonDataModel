using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class TimeGroupVocabulary : SimpleVocabulary
    {
        public TimeGroupVocabulary()
        {
            VocabularyName = "Time Group";
            KeyPrefix = "commonDataModel.timegroup.scheduling";
            KeySeparator = ".";
            Grouping = "/TimeGroup";

            AddGroup("TimeGroup Details for Scheduling", group =>
            {
			    TimeGroupId = group.Add(new VocabularyKey(nameof(TimeGroupId), "Time Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisplayTopXResultsInSATimeGroup = group.Add(new VocabularyKey(nameof(DisplayTopXResultsInSATimeGroup), "Results per Time Group Detail", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    HideBookingTimeOnSA = group.Add(new VocabularyKey(nameof(HideBookingTimeOnSA), "Hide Booking Time On Schedule Assistant", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Interval = group.Add(new VocabularyKey(nameof(Interval), "Interval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    IntervalsBegin = group.Add(new VocabularyKey(nameof(IntervalsBegin), "Intervals Begin", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResetPerTimeGroupDetail = group.Add(new VocabularyKey(nameof(ResetPerTimeGroupDetail), "Reset Per Time Group Detail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ResultsPerInterval = group.Add(new VocabularyKey(nameof(ResultsPerInterval), "Results per Interval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey TimeGroupId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey DisplayTopXResultsInSATimeGroup { get; private set; }
        public VocabularyKey HideBookingTimeOnSA { get; private set; }
        public VocabularyKey Interval { get; private set; }
        public VocabularyKey IntervalsBegin { get; private set; }
        public VocabularyKey ResetPerTimeGroupDetail { get; private set; }
        public VocabularyKey ResultsPerInterval { get; private set; }
    }
}