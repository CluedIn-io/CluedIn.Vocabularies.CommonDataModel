using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanPriorityConstraintEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanPriorityConstraintEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetPlanPriorityConstraintEntity";
            KeyPrefix = "commonDataModel.budgetplanpriorityconstraintentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanPriorityConstraintEntity";

            AddGroup("Common Data Model BudgetPlanPriorityConstraintEntity Details", group =>
            {
                BudgetPlanningProcess = group.Add(new VocabularyKey(nameof(BudgetPlanningProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetPlanPriority = group.Add(new VocabularyKey(nameof(BudgetPlanPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Process = group.Add(new VocabularyKey(nameof(Process), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BudgetPlanningProcess { get; private set; }
public VocabularyKey BudgetPlanPriority { get; private set; }
public VocabularyKey Process { get; private set; }
public VocabularyKey Priority { get; private set; }


    }
}