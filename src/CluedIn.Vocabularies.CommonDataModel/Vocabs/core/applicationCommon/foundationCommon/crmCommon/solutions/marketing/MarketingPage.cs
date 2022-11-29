using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Marketing
{
    public class MarketingPageVocabulary : SimpleVocabulary
    {
        public MarketingPageVocabulary()
        {
            VocabularyName = "Marketing Page";
            KeyPrefix = "commonDataModel.marketingpage.marketing";
            KeySeparator = ".";
            Grouping = "/MarketingPage";

            AddGroup("MarketingPage Details for Marketing", group =>
            {
			    MarketingPageId = group.Add(new VocabularyKey(nameof(MarketingPageId), "Marketing page", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Content = group.Add(new VocabularyKey(nameof(Content), "Content", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContentType = group.Add(new VocabularyKey(nameof(ContentType), "Content type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FormPageMapping = group.Add(new VocabularyKey(nameof(FormPageMapping), "Form page mapping", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    KnownDomains = group.Add(new VocabularyKey(nameof(KnownDomains), "Known domains", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FullPageURL = group.Add(new VocabularyKey(nameof(FullPageURL), "Full page URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), "Insights", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MarketingPageTemplate = group.Add(new VocabularyKey(nameof(MarketingPageTemplate), "Marketing page template", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MarketType = group.Add(new VocabularyKey(nameof(MarketType), "Market type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OptimizedFor = group.Add(new VocabularyKey(nameof(OptimizedFor), "Optimized for", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartialURL = group.Add(new VocabularyKey(nameof(PartialURL), "Partial URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    Purpose = group.Add(new VocabularyKey(nameof(Purpose), "Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RemoteWebsiteID = group.Add(new VocabularyKey(nameof(RemoteWebsiteID), "Remote website ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VisualStyle = group.Add(new VocabularyKey(nameof(VisualStyle), "Visual style", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastPublishedDate = group.Add(new VocabularyKey(nameof(LastPublishedDate), "Last published date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastUnpublishedDate = group.Add(new VocabularyKey(nameof(LastUnpublishedDate), "Last unpublished date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MarketingPageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Content { get; private set; }
        public VocabularyKey ContentType { get; private set; }
        public VocabularyKey FormPageMapping { get; private set; }
        public VocabularyKey KnownDomains { get; private set; }
        public VocabularyKey FullPageURL { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey MarketingPageTemplate { get; private set; }
        public VocabularyKey MarketType { get; private set; }
        public VocabularyKey OptimizedFor { get; private set; }
        public VocabularyKey PartialURL { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey RemoteWebsiteID { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey VisualStyle { get; private set; }
        public VocabularyKey LastPublishedDate { get; private set; }
        public VocabularyKey LastUnpublishedDate { get; private set; }
    }
}