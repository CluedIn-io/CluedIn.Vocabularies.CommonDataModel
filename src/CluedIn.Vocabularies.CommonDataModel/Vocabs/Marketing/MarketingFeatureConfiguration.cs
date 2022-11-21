using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingFeatureConfigurationVocabulary : SimpleVocabulary
    {
        public MarketingFeatureConfigurationVocabulary()
        {
            VocabularyName = "Marketing Feature Configuration";
            KeyPrefix = "commonDataModel.marketingfeatureconfiguration";
            KeySeparator = ".";
            Grouping = "/MarketingFeatureConfiguration";

            AddGroup("MarketingFeatureConfiguration Details", group =>
            {
                Requiredconsent = group.Add(new VocabularyKey(nameof(Requiredconsent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Requiredconsent { get; private set; }
    }
}