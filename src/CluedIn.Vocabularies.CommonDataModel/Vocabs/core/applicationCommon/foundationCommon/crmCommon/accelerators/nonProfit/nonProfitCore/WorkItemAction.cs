using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class WorkItemActionVocabulary : SimpleVocabulary
    {
        public WorkItemActionVocabulary()
        {
            VocabularyName = "Work Item Action";
            KeyPrefix = "commonDataModel.workitemaction.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/WorkItemAction";

            AddGroup("WorkItemAction Details for NonProfitCore", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Work Item Action Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WorkItemActionDueDate = group.Add(new VocabularyKey(nameof(WorkItemActionDueDate), "Work Item Action Due Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WorkItemActionId = group.Add(new VocabularyKey(nameof(WorkItemActionId), "Work Item Action", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WorkItemActionType = group.Add(new VocabularyKey(nameof(WorkItemActionType), "Work Item Action Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey WorkItemActionDueDate { get; private set; }
        public VocabularyKey WorkItemActionId { get; private set; }
        public VocabularyKey WorkItemActionType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}