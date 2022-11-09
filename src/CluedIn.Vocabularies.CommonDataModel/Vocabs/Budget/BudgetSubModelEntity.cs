using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetSubModelEntityVocabulary : SimpleVocabulary
    {
        public BudgetSubModelEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetSubModelEntity";
            KeyPrefix = "commonDataModel.budgetsubmodelentity";
            KeySeparator = ".";
            Grouping = "/BudgetSubModelEntity";

            AddGroup("Common Data Model BudgetSubModelEntity Details", group =>
            {
                BudgetModel = group.Add(new VocabularyKey(nameof(BudgetModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Submodel = group.Add(new VocabularyKey(nameof(Submodel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BudgetModel { get; private set; }
public VocabularyKey Submodel { get; private set; }
public VocabularyKey Type { get; private set; }


    }
}