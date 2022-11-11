using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetActivityCodeEntityVocabulary : SimpleVocabulary
    {
        public AssetActivityCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetActivityCodeEntity";
            KeyPrefix = "commonDataModel.assetactivitycodeentity";
            KeySeparator = ".";
            Grouping = "/AssetActivityCodeEntity";

            AddGroup("Common Data Model AssetActivityCodeEntity Details", group =>
            {
                ActivityCode = group.Add(new VocabularyKey(nameof(ActivityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ActivityCode { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}