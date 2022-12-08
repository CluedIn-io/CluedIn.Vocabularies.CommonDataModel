using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Portals
{
    public class WebPageVocabulary : SimpleVocabulary
    {
        public WebPageVocabulary()
        {
            VocabularyName = "Web Page";
            KeyPrefix = "commonDataModel.webpage.portals";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.WebPage;

            AddGroup("WebPage Details for Portals", group =>
            {
			    WebpageId = group.Add(new VocabularyKey(nameof(WebpageId), "Web Page", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Category = group.Add(new VocabularyKey(nameof(Category), "Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Copy = group.Add(new VocabularyKey(nameof(Copy), "Copy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByIPAddress = group.Add(new VocabularyKey(nameof(AdxCreatedByIPAddress), "Created By IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByUsername = group.Add(new VocabularyKey(nameof(AdxCreatedByUsername), "Created By Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisplayDate = group.Add(new VocabularyKey(nameof(DisplayDate), "Display Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), "Display Order", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    HiddenFromSitemap = group.Add(new VocabularyKey(nameof(HiddenFromSitemap), "Hidden From Sitemap", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByIPAddress = group.Add(new VocabularyKey(nameof(AdxModifiedByIPAddress), "Modified By IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByUsername = group.Add(new VocabularyKey(nameof(AdxModifiedByUsername), "Modified By Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartialURL = group.Add(new VocabularyKey(nameof(PartialURL), "Partial URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    SubjectId = group.Add(new VocabularyKey(nameof(SubjectId), "Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Summary = group.Add(new VocabularyKey(nameof(Summary), "Summary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllowOrigin = group.Add(new VocabularyKey(nameof(AllowOrigin), "Allow Origin", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomCSS = group.Add(new VocabularyKey(nameof(CustomCSS), "Custom CSS", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomJavaScript = group.Add(new VocabularyKey(nameof(CustomJavaScript), "Custom JavaScript", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EditorialComments = group.Add(new VocabularyKey(nameof(EditorialComments), "Editorial Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Enabletracking = group.Add(new VocabularyKey(nameof(Enabletracking), "Enable Tracking (deprecated)", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ExcludeFromSearch = group.Add(new VocabularyKey(nameof(ExcludeFromSearch), "Exclude From Search", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), "Expiration Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImageURL = group.Add(new VocabularyKey(nameof(ImageURL), "Image URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    IsRoot = group.Add(new VocabularyKey(nameof(IsRoot), "Is Root", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MetaDescription = group.Add(new VocabularyKey(nameof(MetaDescription), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Navigation = group.Add(new VocabularyKey(nameof(Navigation), "Navigation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReleaseDate = group.Add(new VocabularyKey(nameof(ReleaseDate), "Release Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SharedPageConfiguration = group.Add(new VocabularyKey(nameof(SharedPageConfiguration), "Shared Page Configuration", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EntityForm = group.Add(new VocabularyKey(nameof(EntityForm), "Entity Form", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityList = group.Add(new VocabularyKey(nameof(EntityList), "Entity List", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebForm = group.Add(new VocabularyKey(nameof(WebForm), "Web Form", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommentPolicy = group.Add(new VocabularyKey(nameof(CommentPolicy), "Comment Policy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EnableRatings = group.Add(new VocabularyKey(nameof(EnableRatings), "Enable Ratings", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="AuthorId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PageTemplateId"/> to Vocab 'PageTemplate.cdm.json/PageTemplate' with Property 'PageTemplateId'
            ///Property <see cref="PublishingStateId"/> to Vocab 'PublishingState.cdm.json/PublishingState' with Property 'PublishingStateId'
            ///Property <see cref="Image"/> to Vocab 'WebFile.cdm.json/WebFile' with Property 'WebFileId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ParentPageId"/> to Vocab 'WebPage.cdm.json/WebPage' with Property 'WebpageId'
            ///Property <see cref="WebsiteId"/> to Vocab 'Website.cdm.json/Website' with Property 'WebsiteId'
            ///Property <see cref="MasterWebPageId"/> to Vocab 'WebPage.cdm.json/WebPage' with Property 'WebpageId'
            ///Property <see cref="RootWebpageId"/> to Vocab 'WebPage.cdm.json/WebPage' with Property 'WebpageId'
            ///Property <see cref="WebpageLanguageId"/> to Vocab 'WebsiteLanguage.cdm.json/WebsiteLanguage' with Property 'WebsiteLanguageId'
            ///Property <see cref="WebPageId"/> to Vocab 'WebPage.cdm.json/WebPage' with Property 'WebpageId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="WebpageId"/> from Vocab 'Ad.cdm.json/Ad' with Property 'WebpageId'
            ///Property <see cref="WebpageId"/> from Vocab 'Blog.cdm.json/Blog' with Property 'ParentPageId'
            ///Property <see cref="WebpageId"/> from Vocab 'Forum.cdm.json/Forum' with Property 'ParentPageID'
            ///Property <see cref="WebpageId"/> from Vocab 'InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="WebpageId"/> from Vocab 'WebFile.cdm.json/WebFile' with Property 'ParentPageId'
            ///Property <see cref="WebpageId"/> from Vocab 'WebPage.cdm.json/WebPage' with Property 'ParentPageId'
            ///Property <see cref="WebpageId"/> from Vocab 'WebPage.cdm.json/WebPage' with Property 'MasterWebPageId'
            ///Property <see cref="WebpageId"/> from Vocab 'WebPage.cdm.json/WebPage' with Property 'RootWebpageId'
            ///Property <see cref="WebpageId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/MarketingPage.cdm.json/MarketingPage' with Property 'WebPage'
            ///Property <see cref="WebpageId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/MarketingPage.cdm.json/MarketingPage' with Property 'ContainerPage'
            ///Property <see cref="WebpageId"/> from Vocab 'WebPageLog.cdm.json/WebPageLog' with Property 'WebPageId'
            #endregion
        }

        public VocabularyKey WebpageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Category { get; private set; }
        public VocabularyKey Copy { get; private set; }
        public VocabularyKey AdxCreatedByIPAddress { get; private set; }
        public VocabularyKey AdxCreatedByUsername { get; private set; }
        public VocabularyKey DisplayDate { get; private set; }
        public VocabularyKey DisplayOrder { get; private set; }
        public VocabularyKey HiddenFromSitemap { get; private set; }
        public VocabularyKey AdxModifiedByIPAddress { get; private set; }
        public VocabularyKey AdxModifiedByUsername { get; private set; }
        public VocabularyKey PartialURL { get; private set; }
        public VocabularyKey SubjectId { get; private set; }
        public VocabularyKey Summary { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey AllowOrigin { get; private set; }
        public VocabularyKey CustomCSS { get; private set; }
        public VocabularyKey CustomJavaScript { get; private set; }
        public VocabularyKey EditorialComments { get; private set; }
        public VocabularyKey Enabletracking { get; private set; }
        public VocabularyKey ExcludeFromSearch { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey ImageURL { get; private set; }
        public VocabularyKey IsRoot { get; private set; }
        public VocabularyKey MetaDescription { get; private set; }
        public VocabularyKey Navigation { get; private set; }
        public VocabularyKey ReleaseDate { get; private set; }
        public VocabularyKey SharedPageConfiguration { get; private set; }
        public VocabularyKey EntityForm { get; private set; }
        public VocabularyKey EntityList { get; private set; }
        public VocabularyKey WebForm { get; private set; }
        public VocabularyKey CommentPolicy { get; private set; }
        public VocabularyKey EnableRatings { get; private set; }
    }
}