using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class ForumVocabulary : SimpleVocabulary
    {
        public ForumVocabulary()
        {
            VocabularyName = "Forum";
            KeyPrefix = "commonDataModel.forum.portals";
            KeySeparator = ".";
            Grouping = "/Forum";

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