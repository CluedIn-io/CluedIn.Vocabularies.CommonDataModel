using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetCodeEntityVocabulary : SimpleVocabulary
    {
        public BudgetCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetCodeEntity";
            KeyPrefix = "commonDataModel.budgetcodeentity";
            KeySeparator = ".";
            Grouping = "/BudgetCodeEntity";

            AddGroup("Common Data Model BudgetCodeEntity Details", group =>
            {
                BudgetCode = group.Add(new VocabularyKey(nameof(BudgetCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetType = group.Add(new VocabularyKey(nameof(BudgetType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDefaultCode = group.Add(new VocabularyKey(nameof(IsDefaultCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkflowId = group.Add(new VocabularyKey(nameof(WorkflowId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BudgetCode { get; private set; }
public VocabularyKey BudgetType { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey IsDefaultCode { get; private set; }
public VocabularyKey ReasonCode { get; private set; }
public VocabularyKey WorkflowId { get; private set; }


    }
}