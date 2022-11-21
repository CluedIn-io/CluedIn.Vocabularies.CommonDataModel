using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanProcessAdministrationEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanProcessAdministrationEntityVocabulary()
        {
            VocabularyName = "Budget Plan Process Administration Entity";
            KeyPrefix = "commonDataModel.budgetplanprocessadministrationentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanProcessAdministrationEntity";

            AddGroup("BudgetPlanProcessAdministrationEntity Details", group =>
            {
                BudgetingOrganization = group.Add(new VocabularyKey(nameof(BudgetingOrganization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningProcess = group.Add(new VocabularyKey(nameof(BudgetPlanningProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanningWorkflow = group.Add(new VocabularyKey(nameof(BudgetPlanningWorkflow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Process = group.Add(new VocabularyKey(nameof(Process), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Workflow = group.Add(new VocabularyKey(nameof(Workflow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyName = group.Add(new VocabularyKey(nameof(PartyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BudgetingOrganization { get; private set; }
        public VocabularyKey BudgetPlanningProcess { get; private set; }
        public VocabularyKey BudgetPlanningWorkflow { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey Process { get; private set; }
        public VocabularyKey Workflow { get; private set; }
        public VocabularyKey PartyName { get; private set; }
    }
}