using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Marketing
{
    public class MarketingWebsiteVocabulary : SimpleVocabulary
    {
        public MarketingWebsiteVocabulary()
        {
            VocabularyName = "Marketing Website";
            KeyPrefix = "commonDataModel.marketingwebsite.marketing";
            KeySeparator = ".";
            Grouping = "/MarketingWebsite";

            AddGroup("MarketingWebsite Details for Marketing", group =>
            {
			    WebsiteId = group.Add(new VocabularyKey(nameof(WebsiteId), "Website", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), "Insights", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Javascriptcode = group.Add(new VocabularyKey(nameof(Javascriptcode), "JavaScript code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RemoteWebsiteID = group.Add(new VocabularyKey(nameof(RemoteWebsiteID), "Remote website ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShouldBeRemoved = group.Add(new VocabularyKey(nameof(ShouldBeRemoved), "Should be removed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Timeout = group.Add(new VocabularyKey(nameof(Timeout), "Timeout", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Url = group.Add(new VocabularyKey(nameof(Url), "URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    Purpose = group.Add(new VocabularyKey(nameof(Purpose), "Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey WebsiteId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey Javascriptcode { get; private set; }
        public VocabularyKey RemoteWebsiteID { get; private set; }
        public VocabularyKey ShouldBeRemoved { get; private set; }
        public VocabularyKey Timeout { get; private set; }
        public VocabularyKey Url { get; private set; }
        public VocabularyKey Purpose { get; private set; }
    }
}