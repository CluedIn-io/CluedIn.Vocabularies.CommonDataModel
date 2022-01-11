using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventStandardCostVarianceLedgerPostingDefinitionEntityVocabulary : SimpleVocabulary
    {
        public InventStandardCostVarianceLedgerPostingDefinitionEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventStandardCostVarianceLedgerPostingDefinitionEntity";
            KeyPrefix = "commonDataModel.inventstandardcostvarianceledgerpostingdefinitionentity";
            KeySeparator = ".";
            Grouping = "/InventStandardCostVarianceLedgerPostingDefinitionEntity";

            AddGroup("Common Data Model InventStandardCostVarianceLedgerPostingDefinitionEntity Details", group =>
            {
                InventoryAccountType = group.Add(new VocabularyKey(nameof(InventoryAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostGroupId = group.Add(new VocabularyKey(nameof(CostGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostCode = group.Add(new VocabularyKey(nameof(CostCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostRelation = group.Add(new VocabularyKey(nameof(CostRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostGroupType = group.Add(new VocabularyKey(nameof(CostGroupType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SiteCode = group.Add(new VocabularyKey(nameof(SiteCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SiteRelation = group.Add(new VocabularyKey(nameof(SiteRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostingSiteId = group.Add(new VocabularyKey(nameof(CostingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey InventoryAccountType { get; private set; }
public VocabularyKey MainAccountIdDisplayValue { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey ProductGroupId { get; private set; }
public VocabularyKey CostGroupId { get; private set; }
public VocabularyKey AccountType { get; private set; }
public VocabularyKey ItemCode { get; private set; }
public VocabularyKey ItemRelation { get; private set; }
public VocabularyKey CostCode { get; private set; }
public VocabularyKey CostRelation { get; private set; }
public VocabularyKey MainAccountId { get; private set; }
public VocabularyKey CostGroupType { get; private set; }
public VocabularyKey SiteCode { get; private set; }
public VocabularyKey SiteRelation { get; private set; }
public VocabularyKey CostingSiteId { get; private set; }


    }
}