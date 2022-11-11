using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerBadDebtAccountsEntityVocabulary : SimpleVocabulary
    {
        public LedgerBadDebtAccountsEntityVocabulary()
        {
            VocabularyName = "LedgerBadDebtAccountsEntity";
            KeyPrefix = "commonDataModel.ledgerbaddebtaccountsentity";
            KeySeparator = ".";
            Grouping = "/LedgerBadDebtAccountsEntity";

            AddGroup("LedgerBadDebtAccountsEntity Details", group =>
            {
                BadDebtMainAccountDisplayValue = group.Add(new VocabularyKey(nameof(BadDebtMainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectedBadDebtMainAccountDisplayValue = group.Add(new VocabularyKey(nameof(CollectedBadDebtMainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BadDebtMainAccount = group.Add(new VocabularyKey(nameof(BadDebtMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectedBadDebtMainAccount = group.Add(new VocabularyKey(nameof(CollectedBadDebtMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BadDebtMainAccountDisplayValue { get; private set; }
        public VocabularyKey CollectedBadDebtMainAccountDisplayValue { get; private set; }
        public VocabularyKey BadDebtMainAccount { get; private set; }
        public VocabularyKey CollectedBadDebtMainAccount { get; private set; }
        public VocabularyKey Company { get; private set; }


    }
}