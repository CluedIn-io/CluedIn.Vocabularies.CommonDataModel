using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmJobDetailEntityVocabulary : SimpleVocabulary
    {
        public HcmJobDetailEntityVocabulary()
        {
            VocabularyName = "Hcm Job Detail Entity";
            KeyPrefix = "commonDataModel.hcmjobdetailentity";
            KeySeparator = ".";
            Grouping = "/HcmJobDetailEntity";

            AddGroup("HcmJobDetailEntity Details", group =>
            {
                CompensationLevel = group.Add(new VocabularyKey(nameof(CompensationLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompensationLevelId = group.Add(new VocabularyKey(nameof(CompensationLevelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullTimeEquivalent = group.Add(new VocabularyKey(nameof(FullTimeEquivalent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompensationReferenceJob = group.Add(new VocabularyKey(nameof(CompensationReferenceJob), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Job = group.Add(new VocabularyKey(nameof(Job), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Function = group.Add(new VocabularyKey(nameof(Function), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FunctionId = group.Add(new VocabularyKey(nameof(FunctionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobType = group.Add(new VocabularyKey(nameof(JobType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobTypeId = group.Add(new VocabularyKey(nameof(JobTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketPriceControlPoint = group.Add(new VocabularyKey(nameof(MarketPriceControlPoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketPriceHighThreshold = group.Add(new VocabularyKey(nameof(MarketPriceHighThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketPriceLowThreshold = group.Add(new VocabularyKey(nameof(MarketPriceLowThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketPriceSource = group.Add(new VocabularyKey(nameof(MarketPriceSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobDescription = group.Add(new VocabularyKey(nameof(JobDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompensationSurveyCompany = group.Add(new VocabularyKey(nameof(CompensationSurveyCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompensationSurveyCompanyId = group.Add(new VocabularyKey(nameof(CompensationSurveyCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Title = group.Add(new VocabularyKey(nameof(Title), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TitleId = group.Add(new VocabularyKey(nameof(TitleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaidHourly = group.Add(new VocabularyKey(nameof(PaidHourly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CompensationLevel { get; private set; }
        public VocabularyKey CompensationLevelId { get; private set; }
        public VocabularyKey FullTimeEquivalent { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey CompensationReferenceJob { get; private set; }
        public VocabularyKey Job { get; private set; }
        public VocabularyKey JobId { get; private set; }
        public VocabularyKey Function { get; private set; }
        public VocabularyKey FunctionId { get; private set; }
        public VocabularyKey JobType { get; private set; }
        public VocabularyKey JobTypeId { get; private set; }
        public VocabularyKey MarketPriceControlPoint { get; private set; }
        public VocabularyKey MarketPriceHighThreshold { get; private set; }
        public VocabularyKey MarketPriceLowThreshold { get; private set; }
        public VocabularyKey MarketPriceSource { get; private set; }
        public VocabularyKey JobDescription { get; private set; }
        public VocabularyKey CompensationSurveyCompany { get; private set; }
        public VocabularyKey CompensationSurveyCompanyId { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey TitleId { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey PaidHourly { get; private set; }
    }
}