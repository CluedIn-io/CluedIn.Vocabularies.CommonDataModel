using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class WorkItemVocabulary : SimpleVocabulary
    {
        public WorkItemVocabulary()
        {
            VocabularyName = "Work Item";
            KeyPrefix = "commonDataModel.workitem.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/WorkItem";

            AddGroup("WorkItem Details for NonProfitCore", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Work Item Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WorkItemId = group.Add(new VocabularyKey(nameof(WorkItemId), "Work Item", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WorkItemPriorityType = group.Add(new VocabularyKey(nameof(WorkItemPriorityType), "Work Item Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WorkItemType = group.Add(new VocabularyKey(nameof(WorkItemType), "Work Item Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey WorkItemId { get; private set; }
        public VocabularyKey WorkItemPriorityType { get; private set; }
        public VocabularyKey WorkItemType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}