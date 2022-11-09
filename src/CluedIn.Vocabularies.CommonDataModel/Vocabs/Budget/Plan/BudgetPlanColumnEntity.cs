using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanColumnEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanColumnEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetPlanColumnEntity";
            KeyPrefix = "commonDataModel.budgetplancolumnentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanColumnEntity";

            AddGroup("Common Data Model BudgetPlanColumnEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetPlanScenario = group.Add(new VocabularyKey(nameof(BudgetPlanScenario), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ColumnPeriodLength = group.Add(new VocabularyKey(nameof(ColumnPeriodLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ColumnPeriodLengthValue = group.Add(new VocabularyKey(nameof(ColumnPeriodLengthValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
YearOffset = group.Add(new VocabularyKey(nameof(YearOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Scenario = group.Add(new VocabularyKey(nameof(Scenario), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey BudgetPlanScenario { get; private set; }
public VocabularyKey ColumnPeriodLength { get; private set; }
public VocabularyKey ColumnPeriodLengthValue { get; private set; }
public VocabularyKey YearOffset { get; private set; }
public VocabularyKey Scenario { get; private set; }


    }
}