using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmCompensationPayPerformanceAllocationLineEntityVocabulary : SimpleVocabulary
    {
        public HcmCompensationPayPerformanceAllocationLineEntityVocabulary()
        {
            VocabularyName = "Hcm Compensation Pay Performance Allocation Line Entity";
            KeyPrefix = "commonDataModel.hcmcompensationpayperformanceallocationlineentity";
            KeySeparator = ".";
            Grouping = "/HcmCompensationPayPerformanceAllocationLineEntity";

            AddGroup("HcmCompensationPayPerformanceAllocationLineEntity Details", group =>
            {
                AllocationId = group.Add(new VocabularyKey(nameof(AllocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompPerfRatingId = group.Add(new VocabularyKey(nameof(CompPerfRatingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PerfFactorPercent = group.Add(new VocabularyKey(nameof(PerfFactorPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlanType = group.Add(new VocabularyKey(nameof(PlanType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RatingLevel = group.Add(new VocabularyKey(nameof(RatingLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RatingLevelId = group.Add(new VocabularyKey(nameof(RatingLevelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RatingModel = group.Add(new VocabularyKey(nameof(RatingModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RatingModelId = group.Add(new VocabularyKey(nameof(RatingModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RatingModelType = group.Add(new VocabularyKey(nameof(RatingModelType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AllocationId { get; private set; }
        public VocabularyKey CompPerfRatingId { get; private set; }
        public VocabularyKey PerfFactorPercent { get; private set; }
        public VocabularyKey PlanType { get; private set; }
        public VocabularyKey RatingLevel { get; private set; }
        public VocabularyKey RatingLevelId { get; private set; }
        public VocabularyKey RatingModel { get; private set; }
        public VocabularyKey RatingModelId { get; private set; }
        public VocabularyKey RatingModelType { get; private set; }
    }
}