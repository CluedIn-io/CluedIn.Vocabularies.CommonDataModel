using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTSLCurrencyRuleGroupEntityVocabulary : SimpleVocabulary
    {
        public RTSLCurrencyRuleGroupEntityVocabulary()
        {
            VocabularyName = "RTSL Currency Rule Group Entity";
            KeyPrefix = "commonDataModel.rtslcurrencyrulegroupentity";
            KeySeparator = ".";
            Grouping = "/RTSLCurrencyRuleGroupEntity";

            AddGroup("RTSLCurrencyRuleGroupEntity Details", group =>
            {
                CurrencyRuleGroupId = group.Add(new VocabularyKey(nameof(CurrencyRuleGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleGroupId = group.Add(new VocabularyKey(nameof(RuleGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CurrencyRuleGroupId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey RuleGroupId { get; private set; }
    }
}