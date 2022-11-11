using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetAllocationRuleEntityVocabulary : SimpleVocabulary
    {
        public AssetAllocationRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetAllocationRuleEntity";
            KeyPrefix = "commonDataModel.assetallocationruleentity";
            KeySeparator = ".";
            Grouping = "/AssetAllocationRuleEntity";

            AddGroup("Common Data Model AssetAllocationRuleEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttribute = group.Add(new VocabularyKey(nameof(DimensionAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleId = group.Add(new VocabularyKey(nameof(RuleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionName = group.Add(new VocabularyKey(nameof(DimensionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey DimensionAttribute { get; private set; }
        public VocabularyKey RuleId { get; private set; }
        public VocabularyKey DimensionName { get; private set; }


    }
}