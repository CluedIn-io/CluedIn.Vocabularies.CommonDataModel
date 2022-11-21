using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25LedgerIntervalGroupEntityVocabulary : SimpleVocabulary
    {
        public RTax25LedgerIntervalGroupEntityVocabulary()
        {
            VocabularyName = "R Tax 25 Ledger Interval Group Entity";
            KeyPrefix = "commonDataModel.rtax25ledgerintervalgroupentity";
            KeySeparator = ".";
            Grouping = "/RTax25LedgerIntervalGroupEntity";

            AddGroup("RTax25LedgerIntervalGroupEntity Details", group =>
            {
                IntervalGroup = group.Add(new VocabularyKey(nameof(IntervalGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IntervalGroup { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}