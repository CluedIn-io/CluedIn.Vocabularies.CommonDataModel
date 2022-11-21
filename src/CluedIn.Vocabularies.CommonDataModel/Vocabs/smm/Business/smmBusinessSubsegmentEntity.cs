using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmBusinessSubsegmentEntityVocabulary : SimpleVocabulary
    {
        public SmmBusinessSubsegmentEntityVocabulary()
        {
            VocabularyName = "Smm Business Subsegment Entity";
            KeyPrefix = "commonDataModel.smmbusinesssubsegmententity";
            KeySeparator = ".";
            Grouping = "/SmmBusinessSubsegmentEntity";

            AddGroup("SmmBusinessSubsegmentEntity Details", group =>
            {
                BusinessSegmentCode = group.Add(new VocabularyKey(nameof(BusinessSegmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubsegmentDescription = group.Add(new VocabularyKey(nameof(SubsegmentDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubsegmentCode = group.Add(new VocabularyKey(nameof(SubsegmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BusinessSegmentCode { get; private set; }
        public VocabularyKey SubsegmentDescription { get; private set; }
        public VocabularyKey SubsegmentCode { get; private set; }
    }
}