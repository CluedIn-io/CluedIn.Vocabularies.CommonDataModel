using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetImpairmentCashGeneratingUnitAssetEntityVocabulary : SimpleVocabulary
    {
        public AssetImpairmentCashGeneratingUnitAssetEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetImpairmentCashGeneratingUnitAssetEntity";
            KeyPrefix = "commonDataModel.assetimpairmentcashgeneratingunitassetentity";
            KeySeparator = ".";
            Grouping = "/AssetImpairmentCashGeneratingUnitAssetEntity";

            AddGroup("Common Data Model AssetImpairmentCashGeneratingUnitAssetEntity Details", group =>
            {
                ImpairmentCGU = group.Add(new VocabularyKey(nameof(ImpairmentCGU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashGeneratingUnitNumber = group.Add(new VocabularyKey(nameof(CashGeneratingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetNumber = group.Add(new VocabularyKey(nameof(AssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Book = group.Add(new VocabularyKey(nameof(Book), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocationPriority = group.Add(new VocabularyKey(nameof(AllocationPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImpairmentAllocationMethod = group.Add(new VocabularyKey(nameof(ImpairmentAllocationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImpairmentHoldingAssetId = group.Add(new VocabularyKey(nameof(ImpairmentHoldingAssetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImpairmentHoldingBookId = group.Add(new VocabularyKey(nameof(ImpairmentHoldingBookId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ImpairmentCGU { get; private set; }
        public VocabularyKey CashGeneratingUnitNumber { get; private set; }
        public VocabularyKey AssetNumber { get; private set; }
        public VocabularyKey Book { get; private set; }
        public VocabularyKey AllocationPriority { get; private set; }
        public VocabularyKey ImpairmentAllocationMethod { get; private set; }
        public VocabularyKey ImpairmentHoldingAssetId { get; private set; }
        public VocabularyKey ImpairmentHoldingBookId { get; private set; }


    }
}