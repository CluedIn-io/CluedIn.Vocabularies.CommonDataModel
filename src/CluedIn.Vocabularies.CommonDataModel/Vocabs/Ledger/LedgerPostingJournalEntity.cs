using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerPostingJournalEntityVocabulary : SimpleVocabulary
    {
        public LedgerPostingJournalEntityVocabulary()
        {
            VocabularyName = "LedgerPostingJournalEntity";
            KeyPrefix = "commonDataModel.ledgerpostingjournalentity";
            KeySeparator = ".";
            Grouping = "/LedgerPostingJournalEntity";

            AddGroup("LedgerPostingJournalEntity Details", group =>
            {
                Journal = group.Add(new VocabularyKey(nameof(Journal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceCode = group.Add(new VocabularyKey(nameof(NumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalType = group.Add(new VocabularyKey(nameof(JournalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Journal { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey NumberSequenceCode { get; private set; }
        public VocabularyKey JournalType { get; private set; }


    }
}