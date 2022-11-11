using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetReductionEntryProfileEntityVocabulary : SimpleVocabulary
    {
        public AssetReductionEntryProfileEntityVocabulary()
        {
            VocabularyName = "AssetReductionEntryProfileEntity";
            KeyPrefix = "commonDataModel.assetreductionentryprofileentity";
            KeySeparator = ".";
            Grouping = "/AssetReductionEntryProfileEntity";

            AddGroup("AssetReductionEntryProfileEntity Details", group =>
            {
                DepreciationConvention = group.Add(new VocabularyKey(nameof(DepreciationConvention), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubsidiesReason = group.Add(new VocabularyKey(nameof(SubsidiesReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxAmt = group.Add(new VocabularyKey(nameof(MaxAmt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxPer = group.Add(new VocabularyKey(nameof(MaxPer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReductionEntryType = group.Add(new VocabularyKey(nameof(ReductionEntryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReductionEntryDocument = group.Add(new VocabularyKey(nameof(ReductionEntryDocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RepaymentType = group.Add(new VocabularyKey(nameof(RepaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetentionPeriod = group.Add(new VocabularyKey(nameof(RetentionPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetentionPeriodMeasure = group.Add(new VocabularyKey(nameof(RetentionPeriodMeasure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetentionStartDate = group.Add(new VocabularyKey(nameof(RetentionStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DepreciationConvention { get; private set; }
        public VocabularyKey SubsidiesReason { get; private set; }
        public VocabularyKey MaxAmt { get; private set; }
        public VocabularyKey MaxPer { get; private set; }
        public VocabularyKey ReductionEntryType { get; private set; }
        public VocabularyKey ReductionEntryDocument { get; private set; }
        public VocabularyKey RepaymentType { get; private set; }
        public VocabularyKey RetentionPeriod { get; private set; }
        public VocabularyKey RetentionPeriodMeasure { get; private set; }
        public VocabularyKey RetentionStartDate { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }


    }
}