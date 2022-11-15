using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanScenarioEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanScenarioEntityVocabulary()
        {
            VocabularyName = "Budget Plan Scenario Entity";
            KeyPrefix = "commonDataModel.budgetplanscenarioentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanScenarioEntity";

            AddGroup("BudgetPlanScenarioEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasureClass = group.Add(new VocabularyKey(nameof(UnitOfMeasureClass), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasureId = group.Add(new VocabularyKey(nameof(UnitOfMeasureId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasureSymbol = group.Add(new VocabularyKey(nameof(UnitOfMeasureSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey UnitOfMeasureClass { get; private set; }
        public VocabularyKey UnitOfMeasureId { get; private set; }
        public VocabularyKey UnitOfMeasureSymbol { get; private set; }
    }
}