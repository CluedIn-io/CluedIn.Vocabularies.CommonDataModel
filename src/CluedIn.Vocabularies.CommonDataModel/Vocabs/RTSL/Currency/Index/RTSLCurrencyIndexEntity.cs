using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTSLCurrencyIndexEntityVocabulary : SimpleVocabulary
    {
        public RTSLCurrencyIndexEntityVocabulary()
        {
            VocabularyName = "Common Data Model RTSLCurrencyIndexEntity";
            KeyPrefix = "commonDataModel.rtslcurrencyindexentity";
            KeySeparator = ".";
            Grouping = "/RTSLCurrencyIndexEntity";

            AddGroup("Common Data Model RTSLCurrencyIndexEntity Details", group =>
            {
                InflationIndex = group.Add(new VocabularyKey(nameof(InflationIndex), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleGroup = group.Add(new VocabularyKey(nameof(RuleGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InflationIndex { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey RuleGroup { get; private set; }


    }
}