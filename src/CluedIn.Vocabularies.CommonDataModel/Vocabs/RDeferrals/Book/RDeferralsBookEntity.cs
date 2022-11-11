using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RDeferralsBookEntityVocabulary : SimpleVocabulary
    {
        public RDeferralsBookEntityVocabulary()
        {
            VocabularyName = "Common Data Model RDeferralsBookEntity";
            KeyPrefix = "commonDataModel.rdeferralsbookentity";
            KeySeparator = ".";
            Grouping = "/RDeferralsBookEntity";

            AddGroup("Common Data Model RDeferralsBookEntity Details", group =>
            {
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeferralsSum = group.Add(new VocabularyKey(nameof(DeferralsSum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModelNumber = group.Add(new VocabularyKey(nameof(ModelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeferralsGroup = group.Add(new VocabularyKey(nameof(DeferralsGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeferralsId = group.Add(new VocabularyKey(nameof(DeferralsId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WritingOffMethod = group.Add(new VocabularyKey(nameof(WritingOffMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lock = group.Add(new VocabularyKey(nameof(Lock), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDateOfWritingOff = group.Add(new VocabularyKey(nameof(EndDateOfWritingOff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WritingOffTime = group.Add(new VocabularyKey(nameof(WritingOffTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisposalDate = group.Add(new VocabularyKey(nameof(DisposalDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BeginningDateOfWritingOff = group.Add(new VocabularyKey(nameof(BeginningDateOfWritingOff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey DeferralsSum { get; private set; }
        public VocabularyKey ModelNumber { get; private set; }
        public VocabularyKey DeferralsGroup { get; private set; }
        public VocabularyKey DeferralsId { get; private set; }
        public VocabularyKey WritingOffMethod { get; private set; }
        public VocabularyKey Lock { get; private set; }
        public VocabularyKey EndDateOfWritingOff { get; private set; }
        public VocabularyKey WritingOffTime { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey DisposalDate { get; private set; }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey BeginningDateOfWritingOff { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey MainAccountDisplayValue { get; private set; }


    }
}