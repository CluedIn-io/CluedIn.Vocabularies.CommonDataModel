using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanStageEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanStageEntityVocabulary()
        {
            VocabularyName = "Budget Plan Stage Entity";
            KeyPrefix = "commonDataModel.budgetplanstageentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanStageEntity";

            AddGroup("BudgetPlanStageEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}