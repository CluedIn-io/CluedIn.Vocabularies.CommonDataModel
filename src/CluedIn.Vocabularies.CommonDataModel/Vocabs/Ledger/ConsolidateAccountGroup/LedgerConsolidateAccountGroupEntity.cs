using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerConsolidateAccountGroupEntityVocabulary : SimpleVocabulary
    {
        public LedgerConsolidateAccountGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerConsolidateAccountGroupEntity";
            KeyPrefix = "commonDataModel.ledgerconsolidateaccountgroupentity";
            KeySeparator = ".";
            Grouping = "/LedgerConsolidateAccountGroupEntity";

            AddGroup("Common Data Model LedgerConsolidateAccountGroupEntity Details", group =>
            {
                ChartOfAccounts = group.Add(new VocabularyKey(nameof(ChartOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountName = group.Add(new VocabularyKey(nameof(MainAccountName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsolidationAccountGroup = group.Add(new VocabularyKey(nameof(ConsolidationAccountGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsolidationAccountGroupName = group.Add(new VocabularyKey(nameof(ConsolidationAccountGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsolidationAccount = group.Add(new VocabularyKey(nameof(ConsolidationAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsolidationAccountName = group.Add(new VocabularyKey(nameof(ConsolidationAccountName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SATLevel = group.Add(new VocabularyKey(nameof(SATLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ChartOfAccounts { get; private set; }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey MainAccountName { get; private set; }
        public VocabularyKey ConsolidationAccountGroup { get; private set; }
        public VocabularyKey ConsolidationAccountGroupName { get; private set; }
        public VocabularyKey ConsolidationAccount { get; private set; }
        public VocabularyKey ConsolidationAccountName { get; private set; }
        public VocabularyKey SATLevel { get; private set; }


    }
}