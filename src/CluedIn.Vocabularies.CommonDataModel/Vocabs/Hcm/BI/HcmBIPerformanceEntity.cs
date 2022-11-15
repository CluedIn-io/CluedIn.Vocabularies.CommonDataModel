using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmBIPerformanceEntityVocabulary : SimpleVocabulary
    {
        public HcmBIPerformanceEntityVocabulary()
        {
            VocabularyName = "Hcm BI Performance Entity";
            KeyPrefix = "commonDataModel.hcmbiperformanceentity";
            KeySeparator = ".";
            Grouping = "/HcmBIPerformanceEntity";

            AddGroup("HcmBIPerformanceEntity Details", group =>
            {
                Rating = group.Add(new VocabularyKey(nameof(Rating), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RatingDescription = group.Add(new VocabularyKey(nameof(RatingDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RatingModel = group.Add(new VocabularyKey(nameof(RatingModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RatingModelDescription = group.Add(new VocabularyKey(nameof(RatingModelDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Performance = group.Add(new VocabularyKey(nameof(Performance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PerformanceRatingValidFrom = group.Add(new VocabularyKey(nameof(PerformanceRatingValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PerformanceRatingValidTo = group.Add(new VocabularyKey(nameof(PerformanceRatingValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Rating { get; private set; }
        public VocabularyKey RatingDescription { get; private set; }
        public VocabularyKey RatingModel { get; private set; }
        public VocabularyKey RatingModelDescription { get; private set; }
        public VocabularyKey Performance { get; private set; }
        public VocabularyKey PerformanceRatingValidFrom { get; private set; }
        public VocabularyKey PerformanceRatingValidTo { get; private set; }
    }
}