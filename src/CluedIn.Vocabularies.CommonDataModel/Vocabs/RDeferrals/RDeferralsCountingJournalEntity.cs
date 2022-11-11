using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RDeferralsCountingJournalEntityVocabulary : SimpleVocabulary
    {
        public RDeferralsCountingJournalEntityVocabulary()
        {
            VocabularyName = "RDeferralsCountingJournalEntity";
            KeyPrefix = "commonDataModel.rdeferralscountingjournalentity";
            KeySeparator = ".";
            Grouping = "/RDeferralsCountingJournalEntity";

            AddGroup("RDeferralsCountingJournalEntity Details", group =>
            {
                Closed = group.Add(new VocabularyKey(nameof(Closed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountingStartDate = group.Add(new VocabularyKey(nameof(CountingStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountingEndDate = group.Add(new VocabularyKey(nameof(CountingEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfficialSession = group.Add(new VocabularyKey(nameof(OfficialSession), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResolutionDate = group.Add(new VocabularyKey(nameof(ResolutionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResolutionNumber = group.Add(new VocabularyKey(nameof(ResolutionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Closed { get; private set; }
        public VocabularyKey CountingStartDate { get; private set; }
        public VocabularyKey CountingEndDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey OfficialSession { get; private set; }
        public VocabularyKey ResolutionDate { get; private set; }
        public VocabularyKey ResolutionNumber { get; private set; }


    }
}