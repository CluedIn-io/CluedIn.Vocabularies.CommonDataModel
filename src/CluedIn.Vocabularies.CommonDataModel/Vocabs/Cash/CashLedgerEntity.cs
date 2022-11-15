using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CashLedgerEntityVocabulary : SimpleVocabulary
    {
        public CashLedgerEntityVocabulary()
        {
            VocabularyName = "Cash Ledger Entity";
            KeyPrefix = "commonDataModel.cashledgerentity";
            KeySeparator = ".";
            Grouping = "/CashLedgerEntity";

            AddGroup("CashLedgerEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashPosting = group.Add(new VocabularyKey(nameof(CashPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFor = group.Add(new VocabularyKey(nameof(ValidFor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Cash = group.Add(new VocabularyKey(nameof(Cash), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey CashPosting { get; private set; }
        public VocabularyKey ValidFor { get; private set; }
        public VocabularyKey Cash { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey MainAccountIdDisplayValue { get; private set; }
    }
}