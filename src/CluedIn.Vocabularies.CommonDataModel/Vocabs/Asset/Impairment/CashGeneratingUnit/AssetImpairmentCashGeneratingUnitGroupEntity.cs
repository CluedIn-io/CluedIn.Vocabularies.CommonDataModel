using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetImpairmentCashGeneratingUnitGroupEntityVocabulary : SimpleVocabulary
    {
        public AssetImpairmentCashGeneratingUnitGroupEntityVocabulary()
        {
            VocabularyName = "Asset Impairment Cash Generating Unit Group Entity";
            KeyPrefix = "commonDataModel.assetimpairmentcashgeneratingunitgroupentity";
            KeySeparator = ".";
            Grouping = "/AssetImpairmentCashGeneratingUnitGroupEntity";

            AddGroup("AssetImpairmentCashGeneratingUnitGroupEntity Details", group =>
            {
                CGUGroup = group.Add(new VocabularyKey(nameof(CGUGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProrationMethod = group.Add(new VocabularyKey(nameof(ProrationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImpairmentMethod = group.Add(new VocabularyKey(nameof(ImpairmentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SharedAssetHasHigherPriority = group.Add(new VocabularyKey(nameof(SharedAssetHasHigherPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CGUGroup { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey PostingLayer { get; private set; }
        public VocabularyKey ProrationMethod { get; private set; }
        public VocabularyKey ImpairmentMethod { get; private set; }
        public VocabularyKey SharedAssetHasHigherPriority { get; private set; }
    }
}