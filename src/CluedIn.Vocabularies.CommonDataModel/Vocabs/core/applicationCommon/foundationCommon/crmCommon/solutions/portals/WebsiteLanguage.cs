using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class WebsiteLanguageVocabulary : SimpleVocabulary
    {
        public WebsiteLanguageVocabulary()
        {
            VocabularyName = "Website Language";
            KeyPrefix = "commonDataModel.websitelanguage";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.WebsiteLanguage;

            AddGroup("WebsiteLanguage Details for Portals", group =>
            {
			    WebsiteLanguageId = group.Add(new VocabularyKey(nameof(WebsiteLanguageId), "Website Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="PortalLanguageId"/> to Vocab 'PortalLanguage.cdm.json/PortalLanguage' with Property 'PortalLanguageId'
            ///Property <see cref="PublishingState"/> to Vocab 'PublishingState.cdm.json/PublishingState' with Property 'PublishingStateId'
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
            ///Property <see cref="WebsiteLanguageId"/> from Vocab 'Blog.cdm.json/Blog' with Property 'BlogPostLanguageId'
            ///Property <see cref="WebsiteLanguageId"/> from Vocab 'Forum.cdm.json/Forum' with Property 'ForumLanguageId'
            ///Property <see cref="WebsiteLanguageId"/> from Vocab 'IdeaForum.cdm.json/IdeaForum' with Property 'WebsiteLanguageId'
            ///Property <see cref="WebsiteLanguageId"/> from Vocab 'WebPage.cdm.json/WebPage' with Property 'WebpageLanguageId'
            ///Property <see cref="WebsiteLanguageId"/> from Vocab 'Website.cdm.json/Website' with Property 'DefaultLanguage'
            ///Property <see cref="WebsiteLanguageId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/MarketingPage.cdm.json/MarketingPage' with Property 'PageLanguage'
            #endregion
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey WebsiteLanguageId { get; private set; }
    }
}