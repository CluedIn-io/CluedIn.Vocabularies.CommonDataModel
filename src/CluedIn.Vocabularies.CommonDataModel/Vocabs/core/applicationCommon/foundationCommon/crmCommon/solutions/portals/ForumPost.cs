using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class ForumPostVocabulary : SimpleVocabulary
    {
        public ForumPostVocabulary()
        {
            VocabularyName = "Forum Post";
            KeyPrefix = "commonDataModel.forumpost.portals";
            KeySeparator = ".";
            Grouping = "/ForumPost";

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
        }

        public VocabularyKey CommunityForumPostId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Content { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey HelpfulVoteCount { get; private set; }
        public VocabularyKey IsAnswer { get; private set; }
    }
}