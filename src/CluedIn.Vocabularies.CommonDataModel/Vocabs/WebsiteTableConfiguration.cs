using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WebsiteTableConfigurationVocabulary : SimpleVocabulary
    {
        public WebsiteTableConfigurationVocabulary()
        {
            VocabularyName = "WebsiteTableConfiguration";
            KeyPrefix = "commonDataModel.websitetableconfiguration";
            KeySeparator = ".";
            Grouping = "/WebsiteTableConfiguration";

            AddGroup("WebsiteTableConfiguration Details", group =>
            {
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                selectedEntity = group.Add(new VocabularyKey(nameof(selectedEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                selectedFields = group.Add(new VocabularyKey(nameof(selectedFields), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                websiteentityconfigurationId = group.Add(new VocabularyKey(nameof(websiteentityconfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey name { get; private set; }
        public VocabularyKey selectedEntity { get; private set; }
        public VocabularyKey selectedFields { get; private set; }
        public VocabularyKey websiteentityconfigurationId { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}