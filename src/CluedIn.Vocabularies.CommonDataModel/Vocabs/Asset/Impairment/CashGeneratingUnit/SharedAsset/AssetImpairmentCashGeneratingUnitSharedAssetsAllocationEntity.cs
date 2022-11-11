using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetImpairmentCashGeneratingUnitSharedAssetsAllocationEntityVocabulary : SimpleVocabulary
    {
        public AssetImpairmentCashGeneratingUnitSharedAssetsAllocationEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetImpairmentCashGeneratingUnitSharedAssetsAllocationEntity";
            KeyPrefix = "commonDataModel.assetimpairmentcashgeneratingunitsharedassetsallocationentity";
            KeySeparator = ".";
            Grouping = "/AssetImpairmentCashGeneratingUnitSharedAssetsAllocationEntity";

            AddGroup("Common Data Model AssetImpairmentCashGeneratingUnitSharedAssetsAllocationEntity Details", group =>
            {
                CGUGroupName = group.Add(new VocabularyKey(nameof(CGUGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SharedAssetId = group.Add(new VocabularyKey(nameof(SharedAssetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SharedAssetBookId = group.Add(new VocabularyKey(nameof(SharedAssetBookId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashGeneratingUnitNumber = group.Add(new VocabularyKey(nameof(CashGeneratingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Proportion = group.Add(new VocabularyKey(nameof(Proportion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CGUGroupName { get; private set; }
        public VocabularyKey SharedAssetId { get; private set; }
        public VocabularyKey SharedAssetBookId { get; private set; }
        public VocabularyKey CashGeneratingUnitNumber { get; private set; }
        public VocabularyKey Proportion { get; private set; }


    }
}