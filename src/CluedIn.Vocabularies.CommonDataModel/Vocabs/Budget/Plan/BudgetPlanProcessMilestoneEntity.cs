using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanProcessMilestoneEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanProcessMilestoneEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetPlanProcessMilestoneEntity";
            KeyPrefix = "commonDataModel.budgetplanprocessmilestoneentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanProcessMilestoneEntity";

            AddGroup("Common Data Model BudgetPlanProcessMilestoneEntity Details", group =>
            {
                BudgetPlanningProcess = group.Add(new VocabularyKey(nameof(BudgetPlanningProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DueDate = group.Add(new VocabularyKey(nameof(DueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompletedDate = group.Add(new VocabularyKey(nameof(CompletedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Process = group.Add(new VocabularyKey(nameof(Process), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BudgetPlanningProcess { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey CompletedDate { get; private set; }
        public VocabularyKey Process { get; private set; }


    }
}