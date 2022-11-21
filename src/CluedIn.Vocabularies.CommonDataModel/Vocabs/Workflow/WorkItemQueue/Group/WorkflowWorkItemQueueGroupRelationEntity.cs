using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowWorkItemQueueGroupRelationEntityVocabulary : SimpleVocabulary
    {
        public WorkflowWorkItemQueueGroupRelationEntityVocabulary()
        {
            VocabularyName = "Workflow Work Item Queue Group Relation Entity";
            KeyPrefix = "commonDataModel.workflowworkitemqueuegrouprelationentity";
            KeySeparator = ".";
            Grouping = "/WorkflowWorkItemQueueGroupRelationEntity";

            AddGroup("WorkflowWorkItemQueueGroupRelationEntity Details", group =>
            {
                WorkflowWorkitemQueue = group.Add(new VocabularyKey(nameof(WorkflowWorkitemQueue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowWorkitemQueueGroup = group.Add(new VocabularyKey(nameof(WorkflowWorkitemQueueGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkItemQueueName = group.Add(new VocabularyKey(nameof(WorkItemQueueName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkItemQueueType = group.Add(new VocabularyKey(nameof(WorkItemQueueType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkItemQueueGroupName = group.Add(new VocabularyKey(nameof(WorkItemQueueGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WorkflowWorkitemQueue { get; private set; }
        public VocabularyKey WorkflowWorkitemQueueGroup { get; private set; }
        public VocabularyKey WorkItemQueueName { get; private set; }
        public VocabularyKey WorkItemQueueType { get; private set; }
        public VocabularyKey WorkItemQueueGroupName { get; private set; }
    }
}