using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class ForumThreadVocabulary : SimpleVocabulary
    {
        public ForumThreadVocabulary()
        {
            VocabularyName = "Forum Thread";
            KeyPrefix = "commonDataModel.forumthread.portals";
            KeySeparator = ".";
            Grouping = "/ForumThread";

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
        }

        public VocabularyKey CommunityForumThreadId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey IsAnswered { get; private set; }
        public VocabularyKey LastPostDate { get; private set; }
        public VocabularyKey Locked { get; private set; }
        public VocabularyKey PostCount { get; private set; }
        public VocabularyKey Sticky { get; private set; }
        public VocabularyKey ViewCount { get; private set; }
    }
}