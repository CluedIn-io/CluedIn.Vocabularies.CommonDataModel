using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ForumThreadVocabulary : SimpleVocabulary
    {
        public ForumThreadVocabulary()
        {
            VocabularyName = "Forum Thread";
            KeyPrefix = "commonDataModel.forumthread";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ForumThread;

            AddGroup("ForumThread Details for Portals", group =>
            {
                CommunityForumThreadId = group.Add(new VocabularyKey(nameof(CommunityForumThreadId), "Forum Thread", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAnswered = group.Add(new VocabularyKey(nameof(IsAnswered), "Answered?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                LastPostDate = group.Add(new VocabularyKey(nameof(LastPostDate), "Last Post Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Locked = group.Add(new VocabularyKey(nameof(Locked), "Locked", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                PostCount = group.Add(new VocabularyKey(nameof(PostCount), "Post Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Sticky = group.Add(new VocabularyKey(nameof(Sticky), "Sticky?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ViewCount = group.Add(new VocabularyKey(nameof(ViewCount), "View Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="ForumId"/> to Vocab 'Forum.cdm.json/Forum' with Property 'CommunityForumId'
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
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="CommunityForumThreadId"/> from Vocab 'ForumPost.cdm.json/ForumPost' with Property 'ForumThreadId'
            ///Property <see cref="ForumThreadTypeId"/> from Vocab 'ForumThread.cdm.json/ForumThread' with Property 'TypeId'
            #endregion
        }

        public VocabularyKey CommunityForumThreadId { get; private set; }
        public VocabularyKey IsAnswered { get; private set; }
        public VocabularyKey LastPostDate { get; private set; }
        public VocabularyKey Locked { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PostCount { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Sticky { get; private set; }
        public VocabularyKey ViewCount { get; private set; }
    }
}