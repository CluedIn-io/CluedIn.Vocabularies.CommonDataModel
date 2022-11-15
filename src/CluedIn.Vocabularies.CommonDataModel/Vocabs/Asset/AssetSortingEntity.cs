using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetSortingEntityVocabulary : SimpleVocabulary
    {
        public AssetSortingEntityVocabulary()
        {
            VocabularyName = "Asset Sorting Entity";
            KeyPrefix = "commonDataModel.assetsortingentity";
            KeySeparator = ".";
            Grouping = "/AssetSortingEntity";

            AddGroup("AssetSortingEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Sorting = group.Add(new VocabularyKey(nameof(Sorting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Identification = group.Add(new VocabularyKey(nameof(Identification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Sorting { get; private set; }
        public VocabularyKey Identification { get; private set; }
    }
}