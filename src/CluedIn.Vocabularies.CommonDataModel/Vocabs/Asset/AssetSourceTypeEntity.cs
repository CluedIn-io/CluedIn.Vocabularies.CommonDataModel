using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetSourceTypeEntityVocabulary : SimpleVocabulary
    {
        public AssetSourceTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetSourceTypeEntity";
            KeyPrefix = "commonDataModel.assetsourcetypeentity";
            KeySeparator = ".";
            Grouping = "/AssetSourceTypeEntity";

            AddGroup("Common Data Model AssetSourceTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Direction = group.Add(new VocabularyKey(nameof(Direction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceTypeId = group.Add(new VocabularyKey(nameof(SourceTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Direction { get; private set; }
        public VocabularyKey SourceTypeId { get; private set; }


    }
}