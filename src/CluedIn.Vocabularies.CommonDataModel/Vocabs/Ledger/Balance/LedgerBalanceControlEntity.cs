using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerBalanceControlEntityVocabulary : SimpleVocabulary
    {
        public LedgerBalanceControlEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerBalanceControlEntity";
            KeyPrefix = "commonDataModel.ledgerbalancecontrolentity";
            KeySeparator = ".";
            Grouping = "/LedgerBalanceControlEntity";

            AddGroup("Common Data Model LedgerBalanceControlEntity Details", group =>
            {
                MainAccountRecId = group.Add(new VocabularyKey(nameof(MainAccountRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccounts = group.Add(new VocabularyKey(nameof(ChartOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccountsRecId = group.Add(new VocabularyKey(nameof(ChartOfAccountsRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountName = group.Add(new VocabularyKey(nameof(MainAccountName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MainAccountRecId { get; private set; }
        public VocabularyKey ChartOfAccounts { get; private set; }
        public VocabularyKey ChartOfAccountsRecId { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey MainAccountName { get; private set; }


    }
}