using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTSLCurrencyRuleEntityVocabulary : SimpleVocabulary
    {
        public RTSLCurrencyRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model RTSLCurrencyRuleEntity";
            KeyPrefix = "commonDataModel.rtslcurrencyruleentity";
            KeySeparator = ".";
            Grouping = "/RTSLCurrencyRuleEntity";

            AddGroup("Common Data Model RTSLCurrencyRuleEntity Details", group =>
            {
                CurrencyAction = group.Add(new VocabularyKey(nameof(CurrencyAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyIndexId = group.Add(new VocabularyKey(nameof(CurrencyIndexId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MSTAction = group.Add(new VocabularyKey(nameof(MSTAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MSTIndexId = group.Add(new VocabularyKey(nameof(MSTIndexId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondaryAction = group.Add(new VocabularyKey(nameof(SecondaryAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondaryIndexId = group.Add(new VocabularyKey(nameof(SecondaryIndexId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateMethod = group.Add(new VocabularyKey(nameof(RateMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleGroup = group.Add(new VocabularyKey(nameof(RuleGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyRuleGroup = group.Add(new VocabularyKey(nameof(CurrencyRuleGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CurrencyAction { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey CurrencyIndexId { get; private set; }
        public VocabularyKey MSTAction { get; private set; }
        public VocabularyKey MSTIndexId { get; private set; }
        public VocabularyKey SecondaryAction { get; private set; }
        public VocabularyKey SecondaryIndexId { get; private set; }
        public VocabularyKey RateMethod { get; private set; }
        public VocabularyKey RuleGroup { get; private set; }
        public VocabularyKey CurrencyRuleGroup { get; private set; }


    }
}