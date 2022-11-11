using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetSpecialDepreciationAllowanceEntityVocabulary : SimpleVocabulary
    {
        public AssetSpecialDepreciationAllowanceEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetSpecialDepreciationAllowanceEntity";
            KeyPrefix = "commonDataModel.assetspecialdepreciationallowanceentity";
            KeySeparator = ".";
            Grouping = "/AssetSpecialDepreciationAllowanceEntity";

            AddGroup("Common Data Model AssetSpecialDepreciationAllowanceEntity Details", group =>
            {
                SpecialDepreciationAllowanceId = group.Add(new VocabularyKey(nameof(SpecialDepreciationAllowanceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Percentage = group.Add(new VocabularyKey(nameof(Percentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SpecialDepreciationAllowanceId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey Percentage { get; private set; }


    }
}