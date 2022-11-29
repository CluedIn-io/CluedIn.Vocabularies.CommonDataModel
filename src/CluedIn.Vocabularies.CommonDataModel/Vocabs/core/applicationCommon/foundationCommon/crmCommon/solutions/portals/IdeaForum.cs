using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class IdeaForumVocabulary : SimpleVocabulary
    {
        public IdeaForumVocabulary()
        {
            VocabularyName = "Idea Forum";
            KeyPrefix = "commonDataModel.ideaforum.portals";
            KeySeparator = ".";
            Grouping = "/IdeaForum";

            AddGroup("IdeaForum Details for Portals", group =>
            {
			    IdeaForumId = group.Add(new VocabularyKey(nameof(IdeaForumId), "Idea Forum", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommentPolicy = group.Add(new VocabularyKey(nameof(CommentPolicy), "Comment Policy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IdeaSubmissionPolicy = group.Add(new VocabularyKey(nameof(IdeaSubmissionPolicy), "Idea Submission Policy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartialURL = group.Add(new VocabularyKey(nameof(PartialURL), "Partial URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    Summary = group.Add(new VocabularyKey(nameof(Summary), "Summary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VotesPerIdea = group.Add(new VocabularyKey(nameof(VotesPerIdea), "Votes Per Idea", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    VotesPerUser = group.Add(new VocabularyKey(nameof(VotesPerUser), "Votes Per User", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    VotingPolicy = group.Add(new VocabularyKey(nameof(VotingPolicy), "Voting Policy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VotingType = group.Add(new VocabularyKey(nameof(VotingType), "Voting Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey IdeaForumId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CommentPolicy { get; private set; }
        public VocabularyKey IdeaSubmissionPolicy { get; private set; }
        public VocabularyKey PartialURL { get; private set; }
        public VocabularyKey Summary { get; private set; }
        public VocabularyKey VotesPerIdea { get; private set; }
        public VocabularyKey VotesPerUser { get; private set; }
        public VocabularyKey VotingPolicy { get; private set; }
        public VocabularyKey VotingType { get; private set; }
    }
}