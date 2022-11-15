using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingWebsiteVocabulary : SimpleVocabulary
    {
        public MarketingWebsiteVocabulary()
        {
            VocabularyName = "Marketing Website";
            KeyPrefix = "commonDataModel.marketingwebsite";
            KeySeparator = ".";
            Grouping = "/MarketingWebsite";

            AddGroup("MarketingWebsite Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JavascriptcodeCompound = group.Add(new VocabularyKey(nameof(JavascriptcodeCompound), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalFormHostingCodeTemplate = group.Add(new VocabularyKey(nameof(ExternalFormHostingCodeTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalFormHostingIframeTemplate = group.Add(new VocabularyKey(nameof(ExternalFormHostingIframeTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JavaScriptCode = group.Add(new VocabularyKey(nameof(JavaScriptCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapturingCode = group.Add(new VocabularyKey(nameof(CapturingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemoteWebsiteID = group.Add(new VocabularyKey(nameof(RemoteWebsiteID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShouldBeRemoved = group.Add(new VocabularyKey(nameof(ShouldBeRemoved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Timeout = group.Add(new VocabularyKey(nameof(Timeout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                URL = group.Add(new VocabularyKey(nameof(URL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebsiteId = group.Add(new VocabularyKey(nameof(WebsiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey JavascriptcodeCompound { get; private set; }
        public VocabularyKey ExternalFormHostingCodeTemplate { get; private set; }
        public VocabularyKey ExternalFormHostingIframeTemplate { get; private set; }
        public VocabularyKey JavaScriptCode { get; private set; }
        public VocabularyKey CapturingCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RemoteWebsiteID { get; private set; }
        public VocabularyKey ShouldBeRemoved { get; private set; }
        public VocabularyKey Timeout { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey WebsiteId { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Purpose { get; private set; }
    }
}