using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanProposedProjectEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanProposedProjectEntityVocabulary()
        {
            VocabularyName = "BudgetPlanProposedProjectEntity";
            KeyPrefix = "commonDataModel.budgetplanproposedprojectentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanProposedProjectEntity";

            AddGroup("BudgetPlanProposedProjectEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}