using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerJournalDescriptionsEntityVocabulary : SimpleVocabulary
    {
        public LedgerJournalDescriptionsEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerJournalDescriptionsEntity";
            KeyPrefix = "commonDataModel.ledgerjournaldescriptionsentity";
            KeySeparator = ".";
            Grouping = "/LedgerJournalDescriptionsEntity";

            AddGroup("Common Data Model LedgerJournalDescriptionsEntity Details", group =>
            {
                Identification = group.Add(new VocabularyKey(nameof(Identification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SearchName = group.Add(new VocabularyKey(nameof(SearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Identification { get; private set; }
        public VocabularyKey SearchName { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}