using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ForumPostVocabulary : SimpleVocabulary
    {
        public ForumPostVocabulary()
        {
            VocabularyName = "Forum Post";
            KeyPrefix = "commonDataModel.forumpost";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ForumPost;

            AddGroup("ForumPost Details for Portals", group =>
            {
                CommunityForumPostId = group.Add(new VocabularyKey(nameof(CommunityForumPostId), "Forum Post", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Content = group.Add(new VocabularyKey(nameof(Content), "Content", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Date = group.Add(new VocabularyKey(nameof(Date), "Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HelpfulVoteCount = group.Add(new VocabularyKey(nameof(HelpfulVoteCount), "Helpful Vote Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                IsAnswer = group.Add(new VocabularyKey(nameof(IsAnswer), "Answer?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
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
            ///Property <see cref="ForumThreadId"/> to Vocab 'ForumThread.cdm.json/ForumThread' with Property 'CommunityForumThreadId'
            ///Property <see cref="PublishingStateId"/> to Vocab 'PublishingState.cdm.json/PublishingState' with Property 'PublishingStateId'
            ///Property <see cref="RegardingId"/> to Vocab 'ForumPost.cdm.json/ForumPost' with Property 'CommunityForumPostId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="CommunityForumPostId"/> from Vocab 'Forum.cdm.json/Forum' with Property 'LastPostID'
            ///Property <see cref="CommunityForumPostId"/> from Vocab 'ForumPost.cdm.json/ForumPost' with Property 'RegardingId'
            ///Property <see cref="CommunityForumPostId"/> from Vocab 'ForumThread.cdm.json/ForumThread' with Property 'FirstPostId'
            ///Property <see cref="CommunityForumPostId"/> from Vocab 'ForumThread.cdm.json/ForumThread' with Property 'LastPostId'
            #endregion
        }

        public VocabularyKey CommunityForumPostId { get; private set; }
        public VocabularyKey Content { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey HelpfulVoteCount { get; private set; }
        public VocabularyKey IsAnswer { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}