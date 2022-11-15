using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerConsolidateAccountGroupV2EntityVocabulary : SimpleVocabulary
    {
        public LedgerConsolidateAccountGroupV2EntityVocabulary()
        {
            VocabularyName = "Ledger Consolidate Account Group V2 Entity";
            KeyPrefix = "commonDataModel.ledgerconsolidateaccountgroupv2entity";
            KeySeparator = ".";
            Grouping = "/LedgerConsolidateAccountGroupV2Entity";

            AddGroup("LedgerConsolidateAccountGroupV2Entity Details", group =>
            {
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountName = group.Add(new VocabularyKey(nameof(MainAccountName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsolidationAccountGroup = group.Add(new VocabularyKey(nameof(ConsolidationAccountGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsolidationAccountGroupName = group.Add(new VocabularyKey(nameof(ConsolidationAccountGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsolidationAccount = group.Add(new VocabularyKey(nameof(ConsolidationAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsolidationAccountName = group.Add(new VocabularyKey(nameof(ConsolidationAccountName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountType = group.Add(new VocabularyKey(nameof(MainAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountCategory = group.Add(new VocabularyKey(nameof(MainAccountCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccounts = group.Add(new VocabularyKey(nameof(ChartOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostCenterName = group.Add(new VocabularyKey(nameof(CostCenterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey MainAccountName { get; private set; }
        public VocabularyKey ConsolidationAccountGroup { get; private set; }
        public VocabularyKey ConsolidationAccountGroupName { get; private set; }
        public VocabularyKey ConsolidationAccount { get; private set; }
        public VocabularyKey ConsolidationAccountName { get; private set; }
        public VocabularyKey MainAccountType { get; private set; }
        public VocabularyKey MainAccountCategory { get; private set; }
        public VocabularyKey ChartOfAccounts { get; private set; }
        public VocabularyKey CostCenterName { get; private set; }
    }
}