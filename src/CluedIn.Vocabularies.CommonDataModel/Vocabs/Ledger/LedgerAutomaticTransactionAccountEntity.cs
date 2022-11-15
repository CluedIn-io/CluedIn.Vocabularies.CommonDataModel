using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerAutomaticTransactionAccountEntityVocabulary : SimpleVocabulary
    {
        public LedgerAutomaticTransactionAccountEntityVocabulary()
        {
            VocabularyName = "Ledger Automatic Transaction Account Entity";
            KeyPrefix = "commonDataModel.ledgerautomatictransactionaccountentity";
            KeySeparator = ".";
            Grouping = "/LedgerAutomaticTransactionAccountEntity";

            AddGroup("LedgerAutomaticTransactionAccountEntity Details", group =>
            {
                PostingType = group.Add(new VocabularyKey(nameof(PostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PostingType { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey MainAccountIdDisplayValue { get; private set; }
    }
}