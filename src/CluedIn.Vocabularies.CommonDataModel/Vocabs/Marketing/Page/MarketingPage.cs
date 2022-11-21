using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingPageVocabulary : SimpleVocabulary
    {
        public MarketingPageVocabulary()
        {
            VocabularyName = "Marketing Page";
            KeyPrefix = "commonDataModel.marketingpage";
            KeySeparator = ".";
            Grouping = "/MarketingPage";

            AddGroup("MarketingPage Details", group =>
            {
                FormToSave = group.Add(new VocabularyKey(nameof(FormToSave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Content = group.Add(new VocabularyKey(nameof(Content), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContentType = group.Add(new VocabularyKey(nameof(ContentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormPageMapping = group.Add(new VocabularyKey(nameof(FormPageMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Alloweddomains = group.Add(new VocabularyKey(nameof(Alloweddomains), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullPageURL = group.Add(new VocabularyKey(nameof(FullPageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullPageUrls = group.Add(new VocabularyKey(nameof(FullPageUrls), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingPageId = group.Add(new VocabularyKey(nameof(MarketingPageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketType = group.Add(new VocabularyKey(nameof(MarketType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OptimizedFor = group.Add(new VocabularyKey(nameof(OptimizedFor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartialURL = group.Add(new VocabularyKey(nameof(PartialURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemoteWebsiteID = group.Add(new VocabularyKey(nameof(RemoteWebsiteID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VisualStyle = group.Add(new VocabularyKey(nameof(VisualStyle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastPublishedDate = group.Add(new VocabularyKey(nameof(LastPublishedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastUnpublishedDate = group.Add(new VocabularyKey(nameof(LastUnpublishedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingProvided = group.Add(new VocabularyKey(nameof(MarketingProvided), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForcePortalLess = group.Add(new VocabularyKey(nameof(ForcePortalLess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebsitefilterPlaceholder = group.Add(new VocabularyKey(nameof(WebsitefilterPlaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Pagetemplateid = group.Add(new VocabularyKey(nameof(Pagetemplateid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Parentwebpageid = group.Add(new VocabularyKey(nameof(Parentwebpageid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Webtemplateid = group.Add(new VocabularyKey(nameof(Webtemplateid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Websiteid = group.Add(new VocabularyKey(nameof(Websiteid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Websitelanguageid = group.Add(new VocabularyKey(nameof(Websitelanguageid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Webpageid = group.Add(new VocabularyKey(nameof(Webpageid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Iamlive = group.Add(new VocabularyKey(nameof(Iamlive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FormToSave { get; private set; }
        public VocabularyKey Content { get; private set; }
        public VocabularyKey ContentType { get; private set; }
        public VocabularyKey FormPageMapping { get; private set; }
        public VocabularyKey Alloweddomains { get; private set; }
        public VocabularyKey FullPageURL { get; private set; }
        public VocabularyKey FullPageUrls { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey MarketingPageId { get; private set; }
        public VocabularyKey MarketType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OptimizedFor { get; private set; }
        public VocabularyKey PartialURL { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey RemoteWebsiteID { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey VisualStyle { get; private set; }
        public VocabularyKey LastPublishedDate { get; private set; }
        public VocabularyKey LastUnpublishedDate { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey MarketingProvided { get; private set; }
        public VocabularyKey ForcePortalLess { get; private set; }
        public VocabularyKey WebsitefilterPlaceholder { get; private set; }
        public VocabularyKey Pagetemplateid { get; private set; }
        public VocabularyKey Parentwebpageid { get; private set; }
        public VocabularyKey Webtemplateid { get; private set; }
        public VocabularyKey Websiteid { get; private set; }
        public VocabularyKey Websitelanguageid { get; private set; }
        public VocabularyKey Webpageid { get; private set; }
        public VocabularyKey Iamlive { get; private set; }
    }
}