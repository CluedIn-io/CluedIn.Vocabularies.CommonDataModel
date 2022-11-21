using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowWorkItemQueueAssignmentEntityVocabulary : SimpleVocabulary
    {
        public WorkflowWorkItemQueueAssignmentEntityVocabulary()
        {
            VocabularyName = "Workflow Work Item Queue Assignment Entity";
            KeyPrefix = "commonDataModel.workflowworkitemqueueassignmententity";
            KeySeparator = ".";
            Grouping = "/WorkflowWorkItemQueueAssignmentEntity";

            AddGroup("WorkflowWorkItemQueueAssignmentEntity Details", group =>
            {
                DefaultQueue = group.Add(new VocabularyKey(nameof(DefaultQueue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkitemType = group.Add(new VocabularyKey(nameof(WorkitemType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultWorkItemQueueName = group.Add(new VocabularyKey(nameof(DefaultWorkItemQueueName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultWorkItemQueueType = group.Add(new VocabularyKey(nameof(DefaultWorkItemQueueType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DefaultQueue { get; private set; }
        public VocabularyKey WorkitemType { get; private set; }
        public VocabularyKey DefaultWorkItemQueueName { get; private set; }
        public VocabularyKey DefaultWorkItemQueueType { get; private set; }
    }
}