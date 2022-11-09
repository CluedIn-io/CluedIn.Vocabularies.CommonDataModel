using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CostMonthlyCostStatementEntryV2EntityVocabulary : SimpleVocabulary
    {
        public CostMonthlyCostStatementEntryV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model CostMonthlyCostStatementEntryV2Entity";
            KeyPrefix = "commonDataModel.costmonthlycoststatemententryv2entity";
            KeySeparator = ".";
            Grouping = "/CostMonthlyCostStatementEntryV2Entity";

            AddGroup("Common Data Model CostMonthlyCostStatementEntryV2Entity Details", group =>
            {
                AccountingMonthStartDate = group.Add(new VocabularyKey(nameof(AccountingMonthStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostAmount = group.Add(new VocabularyKey(nameof(CostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostResourceNumber = group.Add(new VocabularyKey(nameof(CostResourceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostResourceType = group.Add(new VocabularyKey(nameof(CostResourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostStatementType = group.Add(new VocabularyKey(nameof(CostStatementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LevelOneCostStatementLineCategoryName = group.Add(new VocabularyKey(nameof(LevelOneCostStatementLineCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LevelTwoCostStatementLineCategoryName = group.Add(new VocabularyKey(nameof(LevelTwoCostStatementLineCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LevelThreeCostStatementLineCategoryName = group.Add(new VocabularyKey(nameof(LevelThreeCostStatementLineCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostResourceGroupId = group.Add(new VocabularyKey(nameof(CostResourceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountingMonthStartDate { get; private set; }
public VocabularyKey CostAmount { get; private set; }
public VocabularyKey CostResourceNumber { get; private set; }
public VocabularyKey CostResourceType { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey CostStatementType { get; private set; }
public VocabularyKey LevelOneCostStatementLineCategoryName { get; private set; }
public VocabularyKey LevelTwoCostStatementLineCategoryName { get; private set; }
public VocabularyKey LevelThreeCostStatementLineCategoryName { get; private set; }
public VocabularyKey CostResourceGroupId { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey OperationalSiteId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }


    }
}