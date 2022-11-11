using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RDeferralsBookTableEntityVocabulary : SimpleVocabulary
    {
        public RDeferralsBookTableEntityVocabulary()
        {
            VocabularyName = "RDeferralsBookTableEntity";
            KeyPrefix = "commonDataModel.rdeferralsbooktableentity";
            KeySeparator = ".";
            Grouping = "/RDeferralsBookTableEntity";

            AddGroup("RDeferralsBookTableEntity Details", group =>
            {
                PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModelNumber = group.Add(new VocabularyKey(nameof(ModelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PostingLayer { get; private set; }
        public VocabularyKey ModelNumber { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}