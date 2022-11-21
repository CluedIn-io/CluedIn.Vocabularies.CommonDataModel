using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetValueModelShiftDepreciationEntityVocabulary : SimpleVocabulary
    {
        public AssetValueModelShiftDepreciationEntityVocabulary()
        {
            VocabularyName = "Asset Value Model Shift Depreciation Entity";
            KeyPrefix = "commonDataModel.assetvaluemodelshiftdepreciationentity";
            KeySeparator = ".";
            Grouping = "/AssetValueModelShiftDepreciationEntity";

            AddGroup("AssetValueModelShiftDepreciationEntity Details", group =>
            {
                FixedAssetNumber = group.Add(new VocabularyKey(nameof(FixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueModel = group.Add(new VocabularyKey(nameof(ValueModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeOfIndustry = group.Add(new VocabularyKey(nameof(TypeOfIndustry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeOfShift = group.Add(new VocabularyKey(nameof(TypeOfShift), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShiftPercentage = group.Add(new VocabularyKey(nameof(ShiftPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FixedAssetNumber { get; private set; }
        public VocabularyKey ValueModel { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey TypeOfIndustry { get; private set; }
        public VocabularyKey TypeOfShift { get; private set; }
        public VocabularyKey ShiftPercentage { get; private set; }
    }
}