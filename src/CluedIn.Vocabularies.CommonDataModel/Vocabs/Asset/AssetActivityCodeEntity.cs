using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetActivityCodeEntityVocabulary : SimpleVocabulary
    {
        public AssetActivityCodeEntityVocabulary()
        {
            VocabularyName = "Asset Activity Code Entity";
            KeyPrefix = "commonDataModel.assetactivitycodeentity";
            KeySeparator = ".";
            Grouping = "/AssetActivityCodeEntity";

            AddGroup("AssetActivityCodeEntity Details", group =>
            {
                ActivityCode = group.Add(new VocabularyKey(nameof(ActivityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ActivityCode { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}