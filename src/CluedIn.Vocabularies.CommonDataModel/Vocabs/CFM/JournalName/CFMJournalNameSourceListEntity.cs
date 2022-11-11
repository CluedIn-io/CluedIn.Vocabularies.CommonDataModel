using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CFMJournalNameSourceListEntityVocabulary : SimpleVocabulary
    {
        public CFMJournalNameSourceListEntityVocabulary()
        {
            VocabularyName = "CFMJournalNameSourceListEntity";
            KeyPrefix = "commonDataModel.cfmjournalnamesourcelistentity";
            KeySeparator = ".";
            Grouping = "/CFMJournalNameSourceListEntity";

            AddGroup("CFMJournalNameSourceListEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalDataSource = group.Add(new VocabularyKey(nameof(JournalDataSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Direction = group.Add(new VocabularyKey(nameof(Direction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey JournalDataSource { get; private set; }
        public VocabularyKey Direction { get; private set; }


    }
}