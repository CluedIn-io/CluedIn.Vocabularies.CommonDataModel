using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanProposedProjectEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanProposedProjectEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetPlanProposedProjectEntity";
            KeyPrefix = "commonDataModel.budgetplanproposedprojectentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanProposedProjectEntity";

            AddGroup("Common Data Model BudgetPlanProposedProjectEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}