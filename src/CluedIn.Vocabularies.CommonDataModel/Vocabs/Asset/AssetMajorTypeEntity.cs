using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetMajorTypeEntityVocabulary : SimpleVocabulary
    {
        public AssetMajorTypeEntityVocabulary()
        {
            VocabularyName = "AssetMajorTypeEntity";
            KeyPrefix = "commonDataModel.assetmajortypeentity";
            KeySeparator = ".";
            Grouping = "/AssetMajorTypeEntity";

            AddGroup("AssetMajorTypeEntity Details", group =>
            {
                AssetType_JP = group.Add(new VocabularyKey(nameof(AssetType_JP), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MajorTypeId = group.Add(new VocabularyKey(nameof(MajorTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AssetType_JP { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey MajorTypeId { get; private set; }


    }
}