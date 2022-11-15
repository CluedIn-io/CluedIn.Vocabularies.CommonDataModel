using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WebsiteTableConfigurationVocabulary : SimpleVocabulary
    {
        public WebsiteTableConfigurationVocabulary()
        {
            VocabularyName = "Website Table Configuration";
            KeyPrefix = "commonDataModel.websitetableconfiguration";
            KeySeparator = ".";
            Grouping = "/WebsiteTableConfiguration";

            AddGroup("WebsiteTableConfiguration Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SelectedEntity = group.Add(new VocabularyKey(nameof(SelectedEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SelectedFields = group.Add(new VocabularyKey(nameof(SelectedFields), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebsiteentityconfigurationId = group.Add(new VocabularyKey(nameof(WebsiteentityconfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SelectedEntity { get; private set; }
        public VocabularyKey SelectedFields { get; private set; }
        public VocabularyKey WebsiteentityconfigurationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}