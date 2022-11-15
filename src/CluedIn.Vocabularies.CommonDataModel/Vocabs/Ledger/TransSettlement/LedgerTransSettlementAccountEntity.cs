using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerTransSettlementAccountEntityVocabulary : SimpleVocabulary
    {
        public LedgerTransSettlementAccountEntityVocabulary()
        {
            VocabularyName = "Ledger Trans Settlement Account Entity";
            KeyPrefix = "commonDataModel.ledgertranssettlementaccountentity";
            KeySeparator = ".";
            Grouping = "/LedgerTransSettlementAccountEntity";

            AddGroup("LedgerTransSettlementAccountEntity Details", group =>
            {
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccounts = group.Add(new VocabularyKey(nameof(ChartOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey ChartOfAccounts { get; private set; }
        public VocabularyKey MainAccount { get; private set; }
    }
}