using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetModelEntityVocabulary : SimpleVocabulary
    {
        public BudgetModelEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetModelEntity";
            KeyPrefix = "commonDataModel.budgetmodelentity";
            KeySeparator = ".";
            Grouping = "/BudgetModelEntity";

            AddGroup("Common Data Model BudgetModelEntity Details", group =>
            {
                BudgetModel = group.Add(new VocabularyKey(nameof(BudgetModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashFlowForecasts = group.Add(new VocabularyKey(nameof(CashFlowForecasts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Stopped = group.Add(new VocabularyKey(nameof(Stopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Submodel = group.Add(new VocabularyKey(nameof(Submodel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BudgetModel { get; private set; }
public VocabularyKey CashFlowForecasts { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Stopped { get; private set; }
public VocabularyKey Submodel { get; private set; }
public VocabularyKey Type { get; private set; }


    }
}