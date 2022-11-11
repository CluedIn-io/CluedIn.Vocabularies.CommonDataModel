using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanStageRuleEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanStageRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetPlanStageRuleEntity";
            KeyPrefix = "commonDataModel.budgetplanstageruleentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanStageRuleEntity";

            AddGroup("Common Data Model BudgetPlanStageRuleEntity Details", group =>
            {
                BudgetPlanningProcess = group.Add(new VocabularyKey(nameof(BudgetPlanningProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningWorkflowStage = group.Add(new VocabularyKey(nameof(BudgetPlanningWorkflowStage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CanAddBudgetPlanLines = group.Add(new VocabularyKey(nameof(CanAddBudgetPlanLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CanAddChildBudgetPlans = group.Add(new VocabularyKey(nameof(CanAddChildBudgetPlans), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CanModifyBudgetPlanLines = group.Add(new VocabularyKey(nameof(CanModifyBudgetPlanLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LayoutRecId = group.Add(new VocabularyKey(nameof(LayoutRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Process = group.Add(new VocabularyKey(nameof(Process), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningStage = group.Add(new VocabularyKey(nameof(BudgetPlanningStage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningWorkflow = group.Add(new VocabularyKey(nameof(BudgetPlanningWorkflow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Stage = group.Add(new VocabularyKey(nameof(Stage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Workflow = group.Add(new VocabularyKey(nameof(Workflow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Layout = group.Add(new VocabularyKey(nameof(Layout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BudgetPlanningProcess { get; private set; }
        public VocabularyKey BudgetPlanningWorkflowStage { get; private set; }
        public VocabularyKey CanAddBudgetPlanLines { get; private set; }
        public VocabularyKey CanAddChildBudgetPlans { get; private set; }
        public VocabularyKey CanModifyBudgetPlanLines { get; private set; }
        public VocabularyKey LayoutRecId { get; private set; }
        public VocabularyKey Process { get; private set; }
        public VocabularyKey BudgetPlanningStage { get; private set; }
        public VocabularyKey BudgetPlanningWorkflow { get; private set; }
        public VocabularyKey Stage { get; private set; }
        public VocabularyKey Workflow { get; private set; }
        public VocabularyKey Layout { get; private set; }


    }
}