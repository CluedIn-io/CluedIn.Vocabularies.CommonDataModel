using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowWorkItemQueueGroupEntityVocabulary : SimpleVocabulary
    {
        public WorkflowWorkItemQueueGroupEntityVocabulary()
        {
            VocabularyName = "Workflow Work Item Queue Group Entity";
            KeyPrefix = "commonDataModel.workflowworkitemqueuegroupentity";
            KeySeparator = ".";
            Grouping = "/WorkflowWorkItemQueueGroupEntity";

            AddGroup("WorkflowWorkItemQueueGroupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}