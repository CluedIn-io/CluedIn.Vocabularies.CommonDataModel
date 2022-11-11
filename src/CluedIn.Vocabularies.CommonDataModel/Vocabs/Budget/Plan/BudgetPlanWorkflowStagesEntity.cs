using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanWorkflowStagesEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanWorkflowStagesEntityVocabulary()
        {
            VocabularyName = "BudgetPlanWorkflowStagesEntity";
            KeyPrefix = "commonDataModel.budgetplanworkflowstagesentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanWorkflowStagesEntity";

            AddGroup("BudgetPlanWorkflowStagesEntity Details", group =>
            {
                BudgetPlanningStage = group.Add(new VocabularyKey(nameof(BudgetPlanningStage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningWorkflow = group.Add(new VocabularyKey(nameof(BudgetPlanningWorkflow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriorBudgetPlanningWorkflowStage = group.Add(new VocabularyKey(nameof(PriorBudgetPlanningWorkflowStage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowName = group.Add(new VocabularyKey(nameof(WorkflowName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowId = group.Add(new VocabularyKey(nameof(WorkflowId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StageName = group.Add(new VocabularyKey(nameof(StageName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriorBudgetPlanningStageName = group.Add(new VocabularyKey(nameof(PriorBudgetPlanningStageName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriorBudgetPlanningWorkflowName = group.Add(new VocabularyKey(nameof(PriorBudgetPlanningWorkflowName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsParentBudgetPlanRequired = group.Add(new VocabularyKey(nameof(IsParentBudgetPlanRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RestrictDeleteBudgetPlan = group.Add(new VocabularyKey(nameof(RestrictDeleteBudgetPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RestrictResetBudgetPlan = group.Add(new VocabularyKey(nameof(RestrictResetBudgetPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriorBudgetPlanningStageRecId = group.Add(new VocabularyKey(nameof(PriorBudgetPlanningStageRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriorBudgetPlanningWorkflowRecId = group.Add(new VocabularyKey(nameof(PriorBudgetPlanningWorkflowRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BudgetPlanningStage { get; private set; }
        public VocabularyKey BudgetPlanningWorkflow { get; private set; }
        public VocabularyKey PriorBudgetPlanningWorkflowStage { get; private set; }
        public VocabularyKey WorkflowName { get; private set; }
        public VocabularyKey WorkflowId { get; private set; }
        public VocabularyKey StageName { get; private set; }
        public VocabularyKey PriorBudgetPlanningStageName { get; private set; }
        public VocabularyKey PriorBudgetPlanningWorkflowName { get; private set; }
        public VocabularyKey IsParentBudgetPlanRequired { get; private set; }
        public VocabularyKey RestrictDeleteBudgetPlan { get; private set; }
        public VocabularyKey RestrictResetBudgetPlan { get; private set; }
        public VocabularyKey PriorBudgetPlanningStageRecId { get; private set; }
        public VocabularyKey PriorBudgetPlanningWorkflowRecId { get; private set; }


    }
}