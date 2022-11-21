using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetDepreciationProfileEntityVocabulary : SimpleVocabulary
    {
        public AssetDepreciationProfileEntityVocabulary()
        {
            VocabularyName = "Asset Depreciation Profile Entity";
            KeyPrefix = "commonDataModel.assetdepreciationprofileentity";
            KeySeparator = ".";
            Grouping = "/AssetDepreciationProfileEntity";

            AddGroup("AssetDepreciationProfileEntity Details", group =>
            {
                DepreciationProfileId = group.Add(new VocabularyKey(nameof(DepreciationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationYear = group.Add(new VocabularyKey(nameof(DepreciationYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullDepreciation = group.Add(new VocabularyKey(nameof(FullDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Interval = group.Add(new VocabularyKey(nameof(Interval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Method = group.Add(new VocabularyKey(nameof(Method), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Percentage = group.Add(new VocabularyKey(nameof(Percentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodFrequency = group.Add(new VocabularyKey(nameof(PeriodFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculationBasis = group.Add(new VocabularyKey(nameof(CalculationBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationRateSchedule = group.Add(new VocabularyKey(nameof(DepreciationRateSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationRateScheduleDescription = group.Add(new VocabularyKey(nameof(DepreciationRateScheduleDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationRateScheduleName = group.Add(new VocabularyKey(nameof(DepreciationRateScheduleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EquallySplitDepreciationAmount95PercentOfAcquisitionCost = group.Add(new VocabularyKey(nameof(EquallySplitDepreciationAmount95PercentOfAcquisitionCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LowValuePoolLowCostValue = group.Add(new VocabularyKey(nameof(LowValuePoolLowCostValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LowValuePoolPercentage = group.Add(new VocabularyKey(nameof(LowValuePoolPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LowValuePoolPercentFirstYear = group.Add(new VocabularyKey(nameof(LowValuePoolPercentFirstYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfYearsToEquallyDivideDepreciationAmounts = group.Add(new VocabularyKey(nameof(NumberOfYearsToEquallyDivideDepreciationAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialDepreciationAccountingMethod = group.Add(new VocabularyKey(nameof(SpecialDepreciationAccountingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialDepreciationApplyNumberOfPeriods = group.Add(new VocabularyKey(nameof(SpecialDepreciationApplyNumberOfPeriods), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialDepreciationBaseRatio = group.Add(new VocabularyKey(nameof(SpecialDepreciationBaseRatio), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialDepreciationRate = group.Add(new VocabularyKey(nameof(SpecialDepreciationRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullYearDepreciationOnAdditionalAcquisitions = group.Add(new VocabularyKey(nameof(FullYearDepreciationOnAdditionalAcquisitions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsShiftDepreciation = group.Add(new VocabularyKey(nameof(IsShiftDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DepreciationProfileId { get; private set; }
        public VocabularyKey DepreciationYear { get; private set; }
        public VocabularyKey FullDepreciation { get; private set; }
        public VocabularyKey Interval { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Method { get; private set; }
        public VocabularyKey Percentage { get; private set; }
        public VocabularyKey PeriodFrequency { get; private set; }
        public VocabularyKey CalculationBasis { get; private set; }
        public VocabularyKey DepreciationRateSchedule { get; private set; }
        public VocabularyKey DepreciationRateScheduleDescription { get; private set; }
        public VocabularyKey DepreciationRateScheduleName { get; private set; }
        public VocabularyKey EquallySplitDepreciationAmount95PercentOfAcquisitionCost { get; private set; }
        public VocabularyKey LowValuePoolLowCostValue { get; private set; }
        public VocabularyKey LowValuePoolPercentage { get; private set; }
        public VocabularyKey LowValuePoolPercentFirstYear { get; private set; }
        public VocabularyKey NumberOfYearsToEquallyDivideDepreciationAmounts { get; private set; }
        public VocabularyKey SpecialDepreciationAccountingMethod { get; private set; }
        public VocabularyKey SpecialDepreciationApplyNumberOfPeriods { get; private set; }
        public VocabularyKey SpecialDepreciationBaseRatio { get; private set; }
        public VocabularyKey SpecialDepreciationRate { get; private set; }
        public VocabularyKey FullYearDepreciationOnAdditionalAcquisitions { get; private set; }
        public VocabularyKey IsShiftDepreciation { get; private set; }
    }
}