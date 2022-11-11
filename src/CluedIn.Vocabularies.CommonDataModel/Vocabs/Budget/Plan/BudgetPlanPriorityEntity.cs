using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanPriorityEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanPriorityEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetPlanPriorityEntity";
            KeyPrefix = "commonDataModel.budgetplanpriorityentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanPriorityEntity";

            AddGroup("Common Data Model BudgetPlanPriorityEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}