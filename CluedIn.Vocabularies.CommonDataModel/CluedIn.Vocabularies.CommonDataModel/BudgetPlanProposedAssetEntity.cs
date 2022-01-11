using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanProposedAssetEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanProposedAssetEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetPlanProposedAssetEntity";
            KeyPrefix = "commonDataModel.budgetplanproposedassetentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanProposedAssetEntity";

            AddGroup("Common Data Model BudgetPlanProposedAssetEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}