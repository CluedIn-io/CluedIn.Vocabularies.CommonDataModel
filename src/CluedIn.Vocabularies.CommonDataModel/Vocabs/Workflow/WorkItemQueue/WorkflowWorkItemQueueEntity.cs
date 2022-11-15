using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowWorkItemQueueEntityVocabulary : SimpleVocabulary
    {
        public WorkflowWorkItemQueueEntityVocabulary()
        {
            VocabularyName = "Workflow Work Item Queue Entity";
            KeyPrefix = "commonDataModel.workflowworkitemqueueentity";
            KeySeparator = ".";
            Grouping = "/WorkflowWorkItemQueueEntity";

            AddGroup("WorkflowWorkItemQueueEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkItemType = group.Add(new VocabularyKey(nameof(WorkItemType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkItemTypeFriendlyName = group.Add(new VocabularyKey(nameof(WorkItemTypeFriendlyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey WorkItemType { get; private set; }
        public VocabularyKey WorkItemTypeFriendlyName { get; private set; }
    }
}