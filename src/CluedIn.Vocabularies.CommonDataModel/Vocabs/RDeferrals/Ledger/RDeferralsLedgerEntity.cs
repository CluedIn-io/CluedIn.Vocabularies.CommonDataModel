using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RDeferralsLedgerEntityVocabulary : SimpleVocabulary
    {
        public RDeferralsLedgerEntityVocabulary()
        {
            VocabularyName = "RDeferralsLedgerEntity";
            KeyPrefix = "commonDataModel.rdeferralsledgerentity";
            KeySeparator = ".";
            Grouping = "/RDeferralsLedgerEntity";

            AddGroup("RDeferralsLedgerEntity Details", group =>
            {
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}