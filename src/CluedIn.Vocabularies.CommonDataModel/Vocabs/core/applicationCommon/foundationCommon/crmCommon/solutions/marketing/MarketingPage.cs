using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class MarketingPageVocabulary : SimpleVocabulary
    {
        public MarketingPageVocabulary()
        {
            VocabularyName = "Marketing Page";
            KeyPrefix = "commonDataModel.marketingpage";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.MarketingPage;

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

            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="MarketingWebsite"/> to Vocab 'MarketingWebsite.cdm.json/MarketingWebsite' with Property 'WebsiteId'
            ///Property <see cref="PageTemplate"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/PageTemplate.cdm.json/PageTemplate' with Property 'PageTemplateId'
            ///Property <see cref="WebPage"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/WebPage.cdm.json/WebPage' with Property 'WebpageId'
            ///Property <see cref="WebTemplate"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/WebTemplate.cdm.json/WebTemplate' with Property 'WebTemplateId'
            ///Property <see cref="Portalswebsite"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Website.cdm.json/Website' with Property 'WebsiteId'
            ///Property <see cref="PageLanguage"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/WebsiteLanguage.cdm.json/WebsiteLanguage' with Property 'WebsiteLanguageId'
            ///Property <see cref="ContainerPage"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/WebPage.cdm.json/WebPage' with Property 'WebpageId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="MarketingPageId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'SourceLandingPage'
            ///Property <see cref="MarketingPageId"/> from Vocab 'FormPage.cdm.json/FormPage' with Property 'MarketingPage'
            ///Property <see cref="MarketingPageId"/> from Vocab 'GeoPin.cdm.json/GeoPin' with Property 'MarketingPageGeoPinsId'
            ///Property <see cref="MarketingPageId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'SourceLandingPage'
            #endregion
        }

        public VocabularyKey Content { get; private set; }
        public VocabularyKey ContentType { get; private set; }
        public VocabularyKey FormPageMapping { get; private set; }
        public VocabularyKey FullPageURL { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey KnownDomains { get; private set; }
        public VocabularyKey LastPublishedDate { get; private set; }
        public VocabularyKey LastUnpublishedDate { get; private set; }
        public VocabularyKey MarketingPageId { get; private set; }
        public VocabularyKey MarketingPageTemplate { get; private set; }
        public VocabularyKey MarketType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OptimizedFor { get; private set; }
        public VocabularyKey PartialURL { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey RemoteWebsiteID { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey VisualStyle { get; private set; }
    }
}