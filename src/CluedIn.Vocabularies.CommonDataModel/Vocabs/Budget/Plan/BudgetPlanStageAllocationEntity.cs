using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanStageAllocationEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanStageAllocationEntityVocabulary()
        {
            VocabularyName = "BudgetPlanStageAllocationEntity";
            KeyPrefix = "commonDataModel.budgetplanstageallocationentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanStageAllocationEntity";

            AddGroup("BudgetPlanStageAllocationEntity Details", group =>
            {
                BudgetPlanningAllocationSchedule = group.Add(new VocabularyKey(nameof(BudgetPlanningAllocationSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningWorkflowStage = group.Add(new VocabularyKey(nameof(BudgetPlanningWorkflowStage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocationSchedule = group.Add(new VocabularyKey(nameof(AllocationSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningStage = group.Add(new VocabularyKey(nameof(BudgetPlanningStage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningWorkflow = group.Add(new VocabularyKey(nameof(BudgetPlanningWorkflow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Stage = group.Add(new VocabularyKey(nameof(Stage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Workflow = group.Add(new VocabularyKey(nameof(Workflow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Ordinal = group.Add(new VocabularyKey(nameof(Ordinal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BudgetPlanningAllocationSchedule { get; private set; }
        public VocabularyKey BudgetPlanningWorkflowStage { get; private set; }
        public VocabularyKey AllocationSchedule { get; private set; }
        public VocabularyKey BudgetPlanningStage { get; private set; }
        public VocabularyKey BudgetPlanningWorkflow { get; private set; }
        public VocabularyKey Stage { get; private set; }
        public VocabularyKey Workflow { get; private set; }
        public VocabularyKey Ordinal { get; private set; }


    }
}