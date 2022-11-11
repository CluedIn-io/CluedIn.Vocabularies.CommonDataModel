using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanAlternateLayoutEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanAlternateLayoutEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetPlanAlternateLayoutEntity";
            KeyPrefix = "commonDataModel.budgetplanalternatelayoutentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanAlternateLayoutEntity";

            AddGroup("Common Data Model BudgetPlanAlternateLayoutEntity Details", group =>
            {
                BudgetPlanLayoutId = group.Add(new VocabularyKey(nameof(BudgetPlanLayoutId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningStageRule = group.Add(new VocabularyKey(nameof(BudgetPlanningStageRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanLayout = group.Add(new VocabularyKey(nameof(BudgetPlanLayout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningProcessName = group.Add(new VocabularyKey(nameof(BudgetPlanningProcessName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningWorkflowStage = group.Add(new VocabularyKey(nameof(BudgetPlanningWorkflowStage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningProcess = group.Add(new VocabularyKey(nameof(BudgetPlanningProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningStageId = group.Add(new VocabularyKey(nameof(BudgetPlanningStageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningWorkflowId = group.Add(new VocabularyKey(nameof(BudgetPlanningWorkflowId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningStage = group.Add(new VocabularyKey(nameof(BudgetPlanningStage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningWorkflow = group.Add(new VocabularyKey(nameof(BudgetPlanningWorkflow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BudgetPlanLayoutId { get; private set; }
        public VocabularyKey BudgetPlanningStageRule { get; private set; }
        public VocabularyKey BudgetPlanLayout { get; private set; }
        public VocabularyKey BudgetPlanningProcessName { get; private set; }
        public VocabularyKey BudgetPlanningWorkflowStage { get; private set; }
        public VocabularyKey BudgetPlanningProcess { get; private set; }
        public VocabularyKey BudgetPlanningStageId { get; private set; }
        public VocabularyKey BudgetPlanningWorkflowId { get; private set; }
        public VocabularyKey BudgetPlanningStage { get; private set; }
        public VocabularyKey BudgetPlanningWorkflow { get; private set; }


    }
}