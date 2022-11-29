using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class FindWorkEventVocabulary : SimpleVocabulary
    {
        public FindWorkEventVocabulary()
        {
            VocabularyName = "Find Work Event";
            KeyPrefix = "commonDataModel.findworkevent.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/FindWorkEvent";

            AddGroup("FindWorkEvent Details for ProjectServiceAutomation", group =>
            {
			    FindWorkEventId = group.Add(new VocabularyKey(nameof(FindWorkEventId), "Find Work Event", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Timestamp = group.Add(new VocabularyKey(nameof(Timestamp), "Timestamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Value = group.Add(new VocabularyKey(nameof(Value), "Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey FindWorkEventId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Timestamp { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey Value { get; private set; }
    }
}