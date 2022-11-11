using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingFeatureConfigurationVocabulary : SimpleVocabulary
    {
        public MarketingFeatureConfigurationVocabulary()
        {
            VocabularyName = "MarketingFeatureConfiguration";
            KeyPrefix = "commonDataModel.marketingfeatureconfiguration";
            KeySeparator = ".";
            Grouping = "/MarketingFeatureConfiguration";

            AddGroup("MarketingFeatureConfiguration Details", group =>
            {
                requiredconsent = group.Add(new VocabularyKey(nameof(requiredconsent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey requiredconsent { get; private set; }


    }
}