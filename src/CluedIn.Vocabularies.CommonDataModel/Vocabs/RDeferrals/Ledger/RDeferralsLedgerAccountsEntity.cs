using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RDeferralsLedgerAccountsEntityVocabulary : SimpleVocabulary
    {
        public RDeferralsLedgerAccountsEntityVocabulary()
        {
            VocabularyName = "R Deferrals Ledger Accounts Entity";
            KeyPrefix = "commonDataModel.rdeferralsledgeraccountsentity";
            KeySeparator = ".";
            Grouping = "/RDeferralsLedgerAccountsEntity";

            AddGroup("RDeferralsLedgerAccountsEntity Details", group =>
            {
                Groupings = group.Add(new VocabularyKey(nameof(Groupings), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Num = group.Add(new VocabularyKey(nameof(Num), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostValue = group.Add(new VocabularyKey(nameof(PostValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Groupings { get; private set; }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey OffsetAccount { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
        public VocabularyKey Num { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey PostValue { get; private set; }
        public VocabularyKey MainAccountDisplayValue { get; private set; }
        public VocabularyKey OffsetAccountDisplayValue { get; private set; }
    }
}