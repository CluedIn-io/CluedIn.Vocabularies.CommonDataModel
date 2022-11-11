using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventProductionLedgerPostingDefinitionEntityVocabulary : SimpleVocabulary
    {
        public InventProductionLedgerPostingDefinitionEntityVocabulary()
        {
            VocabularyName = "InventProductionLedgerPostingDefinitionEntity";
            KeyPrefix = "commonDataModel.inventproductionledgerpostingdefinitionentity";
            KeySeparator = ".";
            Grouping = "/InventProductionLedgerPostingDefinitionEntity";

            AddGroup("InventProductionLedgerPostingDefinitionEntity Details", group =>
            {
                InventoryAccountType = group.Add(new VocabularyKey(nameof(InventoryAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryProfileRelation = group.Add(new VocabularyKey(nameof(InventoryProfileRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KindOfActivity = group.Add(new VocabularyKey(nameof(KindOfActivity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryProfileId = group.Add(new VocabularyKey(nameof(InventoryProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiteCode = group.Add(new VocabularyKey(nameof(SiteCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiteRelation = group.Add(new VocabularyKey(nameof(SiteRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionSiteId = group.Add(new VocabularyKey(nameof(ProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InventoryAccountType { get; private set; }
        public VocabularyKey MainAccountIdDisplayValue { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ProductGroupId { get; private set; }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
        public VocabularyKey InventoryProfileRelation { get; private set; }
        public VocabularyKey KindOfActivity { get; private set; }
        public VocabularyKey InventoryProfileId { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey SiteCode { get; private set; }
        public VocabularyKey SiteRelation { get; private set; }
        public VocabularyKey ProductionSiteId { get; private set; }


    }
}