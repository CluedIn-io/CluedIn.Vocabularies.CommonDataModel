using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Portals
{
    public class ForumVocabulary : SimpleVocabulary
    {
        public ForumVocabulary()
        {
            VocabularyName = "Forum";
            KeyPrefix = "commonDataModel.forum.portals";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Forum;

            AddGroup("Forum Details for Portals", group =>
            {
			    CommunityForumId = group.Add(new VocabularyKey(nameof(CommunityForumId), "Forum", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), "Display Order", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    EnableQueuedPosts = group.Add(new VocabularyKey(nameof(EnableQueuedPosts), "Enable queued posts", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    HiddenFromSitemap = group.Add(new VocabularyKey(nameof(HiddenFromSitemap), "Hidden From Sitemap", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    PartialURL = group.Add(new VocabularyKey(nameof(PartialURL), "Partial Url", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    PostCount = group.Add(new VocabularyKey(nameof(PostCount), "Post Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ThreadCount = group.Add(new VocabularyKey(nameof(ThreadCount), "Thread Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="AuthorId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ForumPageTemplateID"/> to Vocab 'PageTemplate.cdm.json/PageTemplate' with Property 'PageTemplateId'
            ///Property <see cref="LastPostID"/> to Vocab 'ForumPost.cdm.json/ForumPost' with Property 'CommunityForumPostId'
            ///Property <see cref="ParentPageID"/> to Vocab 'WebPage.cdm.json/WebPage' with Property 'WebpageId'
            ///Property <see cref="PublishingStateID"/> to Vocab 'PublishingState.cdm.json/PublishingState' with Property 'PublishingStateId'
            ///Property <see cref="ThreadPageTemplateID"/> to Vocab 'PageTemplate.cdm.json/PageTemplate' with Property 'PageTemplateId'
            ///Property <see cref="WebsiteId"/> to Vocab 'Website.cdm.json/Website' with Property 'WebsiteId'
            ///Property <see cref="ForumLanguageId"/> to Vocab 'WebsiteLanguage.cdm.json/WebsiteLanguage' with Property 'WebsiteLanguageId'
            ///Property <see cref="ForumId"/> to Vocab 'Forum.cdm.json/Forum' with Property 'CommunityForumId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ForumThreadId"/> to Vocab 'ForumThread.cdm.json/ForumThread' with Property 'CommunityForumThreadId'
            ///Property <see cref="PublishingStateId"/> to Vocab 'PublishingState.cdm.json/PublishingState' with Property 'PublishingStateId'
            ///Property <see cref="RegardingId"/> to Vocab 'ForumPost.cdm.json/ForumPost' with Property 'CommunityForumPostId'
            ///Property <see cref="FirstPostId"/> to Vocab 'ForumPost.cdm.json/ForumPost' with Property 'CommunityForumPostId'
            ///Property <see cref="LastPostId"/> to Vocab 'ForumPost.cdm.json/ForumPost' with Property 'CommunityForumPostId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="PublishingStateId"/> to Vocab 'PublishingState.cdm.json/PublishingState' with Property 'PublishingStateId'
            ///Property <see cref="TypeId"/> to Vocab 'ForumThreadType.cdm.json/ForumThreadType' with Property 'ForumThreadTypeId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
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
            ///Property <see cref="WebsiteId"/> to Vocab 'Website.cdm.json/Website' with Property 'WebsiteId'
            ///Property <see cref="WebsiteLanguageId"/> to Vocab 'WebsiteLanguage.cdm.json/WebsiteLanguage' with Property 'WebsiteLanguageId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="CommunityForumPostId"/> from Vocab 'Forum.cdm.json/Forum' with Property 'LastPostID'
            ///Property <see cref="CommunityForumId"/> from Vocab 'ForumThread.cdm.json/ForumThread' with Property 'ForumId'
            ///Property <see cref="CommunityForumThreadId"/> from Vocab 'ForumPost.cdm.json/ForumPost' with Property 'ForumThreadId'
            ///Property <see cref="CommunityForumPostId"/> from Vocab 'ForumPost.cdm.json/ForumPost' with Property 'RegardingId'
            ///Property <see cref="CommunityForumPostId"/> from Vocab 'ForumThread.cdm.json/ForumThread' with Property 'FirstPostId'
            ///Property <see cref="CommunityForumPostId"/> from Vocab 'ForumThread.cdm.json/ForumThread' with Property 'LastPostId'
            ///Property <see cref="ForumThreadTypeId"/> from Vocab 'ForumThread.cdm.json/ForumThread' with Property 'TypeId'
            ///Property <see cref="IdeaForumId"/> from Vocab 'Idea.cdm.json/Idea' with Property 'IdeaForumId'
            #endregion
        }

        public VocabularyKey CommunityForumId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DisplayOrder { get; private set; }
        public VocabularyKey EnableQueuedPosts { get; private set; }
        public VocabularyKey HiddenFromSitemap { get; private set; }
        public VocabularyKey PartialURL { get; private set; }
        public VocabularyKey PostCount { get; private set; }
        public VocabularyKey ThreadCount { get; private set; }
    }
}