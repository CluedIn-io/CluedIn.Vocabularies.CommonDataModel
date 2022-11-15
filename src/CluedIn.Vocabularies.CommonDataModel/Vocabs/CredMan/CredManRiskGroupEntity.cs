using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManRiskGroupEntityVocabulary : SimpleVocabulary
    {
        public CredManRiskGroupEntityVocabulary()
        {
            VocabularyName = "Cred Man Risk Group Entity";
            KeyPrefix = "commonDataModel.credmanriskgroupentity";
            KeySeparator = ".";
            Grouping = "/CredManRiskGroupEntity";

            AddGroup("CredManRiskGroupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PercentFrom = group.Add(new VocabularyKey(nameof(PercentFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PercentTo = group.Add(new VocabularyKey(nameof(PercentTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RiskGroupId = group.Add(new VocabularyKey(nameof(RiskGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RiskGroupIndicator = group.Add(new VocabularyKey(nameof(RiskGroupIndicator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PercentFrom { get; private set; }
        public VocabularyKey PercentTo { get; private set; }
        public VocabularyKey RiskGroupId { get; private set; }
        public VocabularyKey RiskGroupIndicator { get; private set; }
    }
}