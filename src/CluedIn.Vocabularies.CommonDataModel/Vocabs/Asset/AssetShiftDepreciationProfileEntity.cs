using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetShiftDepreciationProfileEntityVocabulary : SimpleVocabulary
    {
        public AssetShiftDepreciationProfileEntityVocabulary()
        {
            VocabularyName = "AssetShiftDepreciationProfileEntity";
            KeyPrefix = "commonDataModel.assetshiftdepreciationprofileentity";
            KeySeparator = ".";
            Grouping = "/AssetShiftDepreciationProfileEntity";

            AddGroup("AssetShiftDepreciationProfileEntity Details", group =>
            {
                DoubleShiftPercentage = group.Add(new VocabularyKey(nameof(DoubleShiftPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationProfile = group.Add(new VocabularyKey(nameof(DepreciationProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SingleShiftPercentage = group.Add(new VocabularyKey(nameof(SingleShiftPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TripleShiftPercentage = group.Add(new VocabularyKey(nameof(TripleShiftPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DoubleShiftPercentage { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey DepreciationProfile { get; private set; }
        public VocabularyKey SingleShiftPercentage { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey TripleShiftPercentage { get; private set; }


    }
}