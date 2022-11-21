using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25LedgerIntervalEntityVocabulary : SimpleVocabulary
    {
        public RTax25LedgerIntervalEntityVocabulary()
        {
            VocabularyName = "R Tax 25 Ledger Interval Entity";
            KeyPrefix = "commonDataModel.rtax25ledgerintervalentity";
            KeySeparator = ".";
            Grouping = "/RTax25LedgerIntervalEntity";

            AddGroup("RTax25LedgerIntervalEntity Details", group =>
            {
                IntervalGroup = group.Add(new VocabularyKey(nameof(IntervalGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromLedgerChartOfAccounts = group.Add(new VocabularyKey(nameof(FromLedgerChartOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromAccount = group.Add(new VocabularyKey(nameof(FromAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToLedgerChartOfAccounts = group.Add(new VocabularyKey(nameof(ToLedgerChartOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToAccount = group.Add(new VocabularyKey(nameof(ToAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IntervalGroup { get; private set; }
        public VocabularyKey FromLedgerChartOfAccounts { get; private set; }
        public VocabularyKey FromAccount { get; private set; }
        public VocabularyKey ToLedgerChartOfAccounts { get; private set; }
        public VocabularyKey ToAccount { get; private set; }
    }
}