using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class ForumThreadTypeVocabulary : SimpleVocabulary
    {
        public ForumThreadTypeVocabulary()
        {
            VocabularyName = "Forum Thread Type";
            KeyPrefix = "commonDataModel.forumthreadtype.portals";
            KeySeparator = ".";
            Grouping = "/ForumThreadType";

            AddGroup("ForumThreadType Details for Portals", group =>
            {
			    ForumThreadTypeId = group.Add(new VocabularyKey(nameof(ForumThreadTypeId), "Forum Thread Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllowsVoting = group.Add(new VocabularyKey(nameof(AllowsVoting), "Allows Voting", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), "Display Order", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RequiresAnswer = group.Add(new VocabularyKey(nameof(RequiresAnswer), "Requires Answer", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ForumThreadTypeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AllowsVoting { get; private set; }
        public VocabularyKey DisplayOrder { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey RequiresAnswer { get; private set; }
    }
}