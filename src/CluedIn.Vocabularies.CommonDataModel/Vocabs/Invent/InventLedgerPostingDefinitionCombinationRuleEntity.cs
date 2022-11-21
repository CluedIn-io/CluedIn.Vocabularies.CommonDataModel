using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventLedgerPostingDefinitionCombinationRuleEntityVocabulary : SimpleVocabulary
    {
        public InventLedgerPostingDefinitionCombinationRuleEntityVocabulary()
        {
            VocabularyName = "Invent Ledger Posting Definition Combination Rule Entity";
            KeyPrefix = "commonDataModel.inventledgerpostingdefinitioncombinationruleentity";
            KeySeparator = ".";
            Grouping = "/InventLedgerPostingDefinitionCombinationRuleEntity";

            AddGroup("InventLedgerPostingDefinitionCombinationRuleEntity Details", group =>
            {
                AreAllAccountLedgerPostingDefinitionsActive = group.Add(new VocabularyKey(nameof(AreAllAccountLedgerPostingDefinitionsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreAccountGroupLedgerPostingDefinitionsActive = group.Add(new VocabularyKey(nameof(AreAccountGroupLedgerPostingDefinitionsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreAccountLedgerPostingDefinitionsActive = group.Add(new VocabularyKey(nameof(AreAccountLedgerPostingDefinitionsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreAllCostLedgerPostingDefinitionsActive = group.Add(new VocabularyKey(nameof(AreAllCostLedgerPostingDefinitionsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreCostGroupTypeLedgerPostingDefinitionsActive = group.Add(new VocabularyKey(nameof(AreCostGroupTypeLedgerPostingDefinitionsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreCostGroupLedgerPostingDefinitionsActive = group.Add(new VocabularyKey(nameof(AreCostGroupLedgerPostingDefinitionsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreAllItemLedgerPostingDefinitionsActive = group.Add(new VocabularyKey(nameof(AreAllItemLedgerPostingDefinitionsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreProductCategoryLedgerPostingDefinitionsActive = group.Add(new VocabularyKey(nameof(AreProductCategoryLedgerPostingDefinitionsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreProductGroupLedgerPostingDefinitionsActive = group.Add(new VocabularyKey(nameof(AreProductGroupLedgerPostingDefinitionsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreProductLedgerPostingDefinitionsActive = group.Add(new VocabularyKey(nameof(AreProductLedgerPostingDefinitionsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesTaxGroupLedgerPostingDefinitionsActive = group.Add(new VocabularyKey(nameof(AreSalesTaxGroupLedgerPostingDefinitionsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AreAllAccountLedgerPostingDefinitionsActive { get; private set; }
        public VocabularyKey AreAccountGroupLedgerPostingDefinitionsActive { get; private set; }
        public VocabularyKey AreAccountLedgerPostingDefinitionsActive { get; private set; }
        public VocabularyKey AreAllCostLedgerPostingDefinitionsActive { get; private set; }
        public VocabularyKey AreCostGroupTypeLedgerPostingDefinitionsActive { get; private set; }
        public VocabularyKey AreCostGroupLedgerPostingDefinitionsActive { get; private set; }
        public VocabularyKey AreAllItemLedgerPostingDefinitionsActive { get; private set; }
        public VocabularyKey AreProductCategoryLedgerPostingDefinitionsActive { get; private set; }
        public VocabularyKey AreProductGroupLedgerPostingDefinitionsActive { get; private set; }
        public VocabularyKey AreProductLedgerPostingDefinitionsActive { get; private set; }
        public VocabularyKey AreSalesTaxGroupLedgerPostingDefinitionsActive { get; private set; }
    }
}