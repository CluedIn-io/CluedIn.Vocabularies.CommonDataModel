using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTSLCurrencyIndexTransEntityVocabulary : SimpleVocabulary
    {
        public RTSLCurrencyIndexTransEntityVocabulary()
        {
            VocabularyName = "RTSLCurrencyIndexTransEntity";
            KeyPrefix = "commonDataModel.rtslcurrencyindextransentity";
            KeySeparator = ".";
            Grouping = "/RTSLCurrencyIndexTransEntity";

            AddGroup("RTSLCurrencyIndexTransEntity Details", group =>
            {
                InflationIndex = group.Add(new VocabularyKey(nameof(InflationIndex), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleGroup = group.Add(new VocabularyKey(nameof(RuleGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InflationIndex { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey RuleGroup { get; private set; }


    }
}