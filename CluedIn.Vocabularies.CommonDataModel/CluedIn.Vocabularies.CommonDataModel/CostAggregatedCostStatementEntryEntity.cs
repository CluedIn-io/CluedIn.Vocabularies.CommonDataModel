using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CostAggregatedCostStatementEntryEntityVocabulary : SimpleVocabulary
    {
        public CostAggregatedCostStatementEntryEntityVocabulary()
        {
            VocabularyName = "Common Data Model CostAggregatedCostStatementEntryEntity";
            KeyPrefix = "commonDataModel.costaggregatedcoststatemententryentity";
            KeySeparator = ".";
            Grouping = "/CostAggregatedCostStatementEntryEntity";

            AddGroup("Common Data Model CostAggregatedCostStatementEntryEntity Details", group =>
            {
                AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostAmount = group.Add(new VocabularyKey(nameof(CostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostResourceGroupId = group.Add(new VocabularyKey(nameof(CostResourceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostStatementType = group.Add(new VocabularyKey(nameof(CostStatementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LevelOneCostStatementLineCategoryName = group.Add(new VocabularyKey(nameof(LevelOneCostStatementLineCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LevelThreeCostStatementLineCategoryName = group.Add(new VocabularyKey(nameof(LevelThreeCostStatementLineCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LevelTwoCostStatementLineCategoryName = group.Add(new VocabularyKey(nameof(LevelTwoCostStatementLineCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountingDate { get; private set; }
public VocabularyKey CostAmount { get; private set; }
public VocabularyKey CostResourceGroupId { get; private set; }
public VocabularyKey CostStatementType { get; private set; }
public VocabularyKey LevelOneCostStatementLineCategoryName { get; private set; }
public VocabularyKey LevelThreeCostStatementLineCategoryName { get; private set; }
public VocabularyKey LevelTwoCostStatementLineCategoryName { get; private set; }
public VocabularyKey OperationalSiteId { get; private set; }
public VocabularyKey Quantity { get; private set; }


    }
}