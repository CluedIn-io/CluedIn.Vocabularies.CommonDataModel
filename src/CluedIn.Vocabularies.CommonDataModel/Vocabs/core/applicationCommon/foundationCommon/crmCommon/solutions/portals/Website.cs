using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Portals
{
    public class WebsiteVocabulary : SimpleVocabulary
    {
        public WebsiteVocabulary()
        {
            VocabularyName = "Website";
            KeyPrefix = "commonDataModel.website.portals";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Website;

            AddGroup("Website Details for Portals", group =>
            {
			    WebsiteId = group.Add(new VocabularyKey(nameof(WebsiteId), "Website", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartialURL = group.Add(new VocabularyKey(nameof(PartialURL), "Partial URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    PrimaryDomainName = group.Add(new VocabularyKey(nameof(PrimaryDomainName), "Primary Domain Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebsiteLanguage = group.Add(new VocabularyKey(nameof(WebsiteLanguage), "Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="PortalLanguageId"/> to Vocab 'PortalLanguage.cdm.json/PortalLanguage' with Property 'PortalLanguageId'
            ///Property <see cref="PublishingState"/> to Vocab 'PublishingState.cdm.json/PublishingState' with Property 'PublishingStateId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="DefaultLanguage"/> to Vocab 'WebsiteLanguage.cdm.json/WebsiteLanguage' with Property 'WebsiteLanguageId'
            ///Property <see cref="FooterTemplateId"/> to Vocab 'WebTemplate.cdm.json/WebTemplate' with Property 'WebTemplateId'
            ///Property <see cref="HeaderTemplateId"/> to Vocab 'WebTemplate.cdm.json/WebTemplate' with Property 'WebTemplateId'
            ///Property <see cref="ParentWebsiteId"/> to Vocab 'Website.cdm.json/Website' with Property 'WebsiteId'
            ///Property <see cref="WebsiteId"/> to Vocab 'Website.cdm.json/Website' with Property 'WebsiteId'
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
            ///Property <see cref="WebsiteId"/> from Vocab 'Ad.cdm.json/Ad' with Property 'WebsiteId'
            ///Property <see cref="WebsiteId"/> from Vocab 'AdPlacement.cdm.json/AdPlacement' with Property 'WebsiteId'
            ///Property <see cref="WebsiteId"/> from Vocab 'Blog.cdm.json/Blog' with Property 'Websiteid'
            ///Property <see cref="WebsiteLanguageId"/> from Vocab 'Blog.cdm.json/Blog' with Property 'BlogPostLanguageId'
            ///Property <see cref="WebsiteId"/> from Vocab 'Forum.cdm.json/Forum' with Property 'WebsiteId'
            ///Property <see cref="WebsiteLanguageId"/> from Vocab 'Forum.cdm.json/Forum' with Property 'ForumLanguageId'
            ///Property <see cref="WebsiteId"/> from Vocab 'ForumThreadType.cdm.json/ForumThreadType' with Property 'WebsiteId'
            ///Property <see cref="WebsiteId"/> from Vocab 'IdeaForum.cdm.json/IdeaForum' with Property 'WebsiteId'
            ///Property <see cref="WebsiteLanguageId"/> from Vocab 'IdeaForum.cdm.json/IdeaForum' with Property 'WebsiteLanguageId'
            ///Property <see cref="WebsiteId"/> from Vocab 'Invitation.cdm.json/Invitation' with Property 'Website'
            ///Property <see cref="WebsiteId"/> from Vocab 'InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="WebsiteId"/> from Vocab 'PageTemplate.cdm.json/PageTemplate' with Property 'WebsiteId'
            ///Property <see cref="WebsiteId"/> from Vocab 'Poll.cdm.json/Poll' with Property 'WebsiteId'
            ///Property <see cref="WebsiteId"/> from Vocab 'PollPlacement.cdm.json/PollPlacement' with Property 'WebsiteId'
            ///Property <see cref="WebsiteId"/> from Vocab 'PublishingState.cdm.json/PublishingState' with Property 'WebsiteId'
            ///Property <see cref="WebsiteId"/> from Vocab 'Tag.cdm.json/Tag' with Property 'WebsiteId'
            ///Property <see cref="WebsiteId"/> from Vocab 'WebFile.cdm.json/WebFile' with Property 'WebsiteId'
            ///Property <see cref="WebsiteId"/> from Vocab 'WebPage.cdm.json/WebPage' with Property 'WebsiteId'
            ///Property <see cref="WebsiteLanguageId"/> from Vocab 'WebPage.cdm.json/WebPage' with Property 'WebpageLanguageId'
            ///Property <see cref="WebsiteId"/> from Vocab 'WebRole.cdm.json/WebRole' with Property 'WebsiteId'
            ///Property <see cref="WebsiteLanguageId"/> from Vocab 'Website.cdm.json/Website' with Property 'DefaultLanguage'
            ///Property <see cref="WebsiteId"/> from Vocab 'Website.cdm.json/Website' with Property 'ParentWebsiteId'
            ///Property <see cref="WebsiteId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/MarketingPage.cdm.json/MarketingPage' with Property 'Portalswebsite'
            ///Property <see cref="WebsiteId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/eventManagement/Invitation.cdm.json/Invitation' with Property 'Website'
            ///Property <see cref="WebsiteId"/> from Vocab 'WebsiteLanguage.cdm.json/WebsiteLanguage' with Property 'WebsiteId'
            ///Property <see cref="WebsiteId"/> from Vocab 'WebTemplate.cdm.json/WebTemplate' with Property 'WebsiteId'
            ///Property <see cref="WebsiteLanguageId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/MarketingPage.cdm.json/MarketingPage' with Property 'PageLanguage'
            #endregion
        }

        public VocabularyKey WebsiteId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PartialURL { get; private set; }
        public VocabularyKey PrimaryDomainName { get; private set; }
        public VocabularyKey WebsiteLanguage { get; private set; }
    }
}