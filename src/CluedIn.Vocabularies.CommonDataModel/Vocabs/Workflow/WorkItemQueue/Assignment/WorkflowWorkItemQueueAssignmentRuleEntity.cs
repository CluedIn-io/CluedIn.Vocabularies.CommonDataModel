using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowWorkItemQueueAssignmentRuleEntityVocabulary : SimpleVocabulary
    {
        public WorkflowWorkItemQueueAssignmentRuleEntityVocabulary()
        {
            VocabularyName = "WorkflowWorkItemQueueAssignmentRuleEntity";
            KeyPrefix = "commonDataModel.workflowworkitemqueueassignmentruleentity";
            KeySeparator = ".";
            Grouping = "/WorkflowWorkItemQueueAssignmentRuleEntity";

            AddGroup("WorkflowWorkItemQueueAssignmentRuleEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EvaluationOrder = group.Add(new VocabularyKey(nameof(EvaluationOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Expression = group.Add(new VocabularyKey(nameof(Expression), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowWorkItemQueue = group.Add(new VocabularyKey(nameof(WorkflowWorkItemQueue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkFlowWorkItemQueueExpressionDef = group.Add(new VocabularyKey(nameof(WorkFlowWorkItemQueueExpressionDef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpressionId = group.Add(new VocabularyKey(nameof(ExpressionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkItemQueueName = group.Add(new VocabularyKey(nameof(WorkItemQueueName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkItemQueueType = group.Add(new VocabularyKey(nameof(WorkItemQueueType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkItemType = group.Add(new VocabularyKey(nameof(WorkItemType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey EvaluationOrder { get; private set; }
        public VocabularyKey Expression { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey WorkflowWorkItemQueue { get; private set; }
        public VocabularyKey WorkFlowWorkItemQueueExpressionDef { get; private set; }
        public VocabularyKey ExpressionId { get; private set; }
        public VocabularyKey WorkItemQueueName { get; private set; }
        public VocabularyKey WorkItemQueueType { get; private set; }
        public VocabularyKey WorkItemType { get; private set; }


    }
}