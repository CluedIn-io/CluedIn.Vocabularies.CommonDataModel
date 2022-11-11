using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetGroupValueModelSetupEntityVocabulary : SimpleVocabulary
    {
        public AssetGroupValueModelSetupEntityVocabulary()
        {
            VocabularyName = "AssetGroupValueModelSetupEntity";
            KeyPrefix = "commonDataModel.assetgroupvaluemodelsetupentity";
            KeySeparator = ".";
            Grouping = "/AssetGroupValueModelSetupEntity";

            AddGroup("AssetGroupValueModelSetupEntity Details", group =>
            {
                FixedAssetGroupId = group.Add(new VocabularyKey(nameof(FixedAssetGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueModelId = group.Add(new VocabularyKey(nameof(ValueModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculateDepreciation = group.Add(new VocabularyKey(nameof(CalculateDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationConvention = group.Add(new VocabularyKey(nameof(DepreciationConvention), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationPeriods = group.Add(new VocabularyKey(nameof(DepreciationPeriods), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationProfileId = group.Add(new VocabularyKey(nameof(DepreciationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlternativeDepreciationProfileId = group.Add(new VocabularyKey(nameof(AlternativeDepreciationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtraordinaryDepreciationProfileId = group.Add(new VocabularyKey(nameof(ExtraordinaryDepreciationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceLife = group.Add(new VocabularyKey(nameof(ServiceLife), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowableLimitForAccumulatedDepreciation = group.Add(new VocabularyKey(nameof(AllowableLimitForAccumulatedDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceLifeMonths = group.Add(new VocabularyKey(nameof(ServiceLifeMonths), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceLifeYears = group.Add(new VocabularyKey(nameof(ServiceLifeYears), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialDepreciationAllocationPeriods = group.Add(new VocabularyKey(nameof(SpecialDepreciationAllocationPeriods), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialDepreciationAllocationUnit = group.Add(new VocabularyKey(nameof(SpecialDepreciationAllocationUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialDepreciationAllocationStartConvention = group.Add(new VocabularyKey(nameof(SpecialDepreciationAllocationStartConvention), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcceleratedDepreciationProfileId = group.Add(new VocabularyKey(nameof(AcceleratedDepreciationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAssetGroupDepreciation = group.Add(new VocabularyKey(nameof(IsAssetGroupDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationGroupId = group.Add(new VocabularyKey(nameof(DepreciationGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FixedAssetGroupId { get; private set; }
        public VocabularyKey ValueModelId { get; private set; }
        public VocabularyKey CalculateDepreciation { get; private set; }
        public VocabularyKey DepreciationConvention { get; private set; }
        public VocabularyKey DepreciationPeriods { get; private set; }
        public VocabularyKey DepreciationProfileId { get; private set; }
        public VocabularyKey AlternativeDepreciationProfileId { get; private set; }
        public VocabularyKey ExtraordinaryDepreciationProfileId { get; private set; }
        public VocabularyKey ServiceLife { get; private set; }
        public VocabularyKey AllowableLimitForAccumulatedDepreciation { get; private set; }
        public VocabularyKey ServiceLifeMonths { get; private set; }
        public VocabularyKey ServiceLifeYears { get; private set; }
        public VocabularyKey SpecialDepreciationAllocationPeriods { get; private set; }
        public VocabularyKey SpecialDepreciationAllocationUnit { get; private set; }
        public VocabularyKey SpecialDepreciationAllocationStartConvention { get; private set; }
        public VocabularyKey AcceleratedDepreciationProfileId { get; private set; }
        public VocabularyKey IsAssetGroupDepreciation { get; private set; }
        public VocabularyKey DepreciationGroupId { get; private set; }


    }
}