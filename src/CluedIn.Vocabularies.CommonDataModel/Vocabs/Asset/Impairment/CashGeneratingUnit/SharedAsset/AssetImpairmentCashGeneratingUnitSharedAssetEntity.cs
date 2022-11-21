using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetImpairmentCashGeneratingUnitSharedAssetEntityVocabulary : SimpleVocabulary
    {
        public AssetImpairmentCashGeneratingUnitSharedAssetEntityVocabulary()
        {
            VocabularyName = "Asset Impairment Cash Generating Unit Shared Asset Entity";
            KeyPrefix = "commonDataModel.assetimpairmentcashgeneratingunitsharedassetentity";
            KeySeparator = ".";
            Grouping = "/AssetImpairmentCashGeneratingUnitSharedAssetEntity";

            AddGroup("AssetImpairmentCashGeneratingUnitSharedAssetEntity Details", group =>
            {
                CGUGroup = group.Add(new VocabularyKey(nameof(CGUGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CGUGroupName = group.Add(new VocabularyKey(nameof(CGUGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetNumber = group.Add(new VocabularyKey(nameof(AssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Book = group.Add(new VocabularyKey(nameof(Book), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocationPriority = group.Add(new VocabularyKey(nameof(AllocationPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetSellingPrice = group.Add(new VocabularyKey(nameof(NetSellingPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProrationMethodOverride = group.Add(new VocabularyKey(nameof(ProrationMethodOverride), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SharedAssetType = group.Add(new VocabularyKey(nameof(SharedAssetType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CGUGroup { get; private set; }
        public VocabularyKey CGUGroupName { get; private set; }
        public VocabularyKey AssetNumber { get; private set; }
        public VocabularyKey Book { get; private set; }
        public VocabularyKey AllocationPriority { get; private set; }
        public VocabularyKey NetSellingPrice { get; private set; }
        public VocabularyKey ProrationMethodOverride { get; private set; }
        public VocabularyKey SharedAssetType { get; private set; }
    }
}