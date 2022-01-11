using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowWorkItemQueueAssigneeEntityVocabulary : SimpleVocabulary
    {
        public WorkflowWorkItemQueueAssigneeEntityVocabulary()
        {
            VocabularyName = "Common Data Model WorkflowWorkItemQueueAssigneeEntity";
            KeyPrefix = "commonDataModel.workflowworkitemqueueassigneeentity";
            KeySeparator = ".";
            Grouping = "/WorkflowWorkItemQueueAssigneeEntity";

            AddGroup("Common Data Model WorkflowWorkItemQueueAssigneeEntity Details", group =>
            {
                IsOwner = group.Add(new VocabularyKey(nameof(IsOwner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
User = group.Add(new VocabularyKey(nameof(User), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkitemQueue = group.Add(new VocabularyKey(nameof(WorkitemQueue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkItemQueueName = group.Add(new VocabularyKey(nameof(WorkItemQueueName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkItemQueueType = group.Add(new VocabularyKey(nameof(WorkItemQueueType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IsOwner { get; private set; }
public VocabularyKey User { get; private set; }
public VocabularyKey WorkitemQueue { get; private set; }
public VocabularyKey WorkItemQueueName { get; private set; }
public VocabularyKey WorkItemQueueType { get; private set; }


    }
}