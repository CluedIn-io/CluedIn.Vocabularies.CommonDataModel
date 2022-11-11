using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerLiquidityEntityVocabulary : SimpleVocabulary
    {
        public LedgerLiquidityEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerLiquidityEntity";
            KeyPrefix = "commonDataModel.ledgerliquidityentity";
            KeySeparator = ".";
            Grouping = "/LedgerLiquidityEntity";

            AddGroup("Common Data Model LedgerLiquidityEntity Details", group =>
            {
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccounts = group.Add(new VocabularyKey(nameof(ChartOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccountsName = group.Add(new VocabularyKey(nameof(ChartOfAccountsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey ChartOfAccounts { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey ChartOfAccountsName { get; private set; }


    }
}