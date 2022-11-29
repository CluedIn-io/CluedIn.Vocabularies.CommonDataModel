using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class IdeaVocabulary : SimpleVocabulary
    {
        public IdeaVocabulary()
        {
            VocabularyName = "Idea";
            KeyPrefix = "commonDataModel.idea.portals";
            KeySeparator = ".";
            Grouping = "/Idea";

            AddGroup("Idea Details for Portals", group =>
            {
			    IdeaId = group.Add(new VocabularyKey(nameof(IdeaId), "Idea", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Approved = group.Add(new VocabularyKey(nameof(Approved), "Published to Web", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AuthorEmail = group.Add(new VocabularyKey(nameof(AuthorEmail), "Author Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    AuthorName = group.Add(new VocabularyKey(nameof(AuthorName), "Author Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommentPolicy = group.Add(new VocabularyKey(nameof(CommentPolicy), "Comment Policy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Copy = group.Add(new VocabularyKey(nameof(Copy), "Copy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByIPAddress = group.Add(new VocabularyKey(nameof(AdxCreatedByIPAddress), "Created By (IP Address)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByUsername = group.Add(new VocabularyKey(nameof(AdxCreatedByUsername), "Created By (Username)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubmittedOn = group.Add(new VocabularyKey(nameof(SubmittedOn), "Submitted On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartialURL = group.Add(new VocabularyKey(nameof(PartialURL), "Partial URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    StatusComment = group.Add(new VocabularyKey(nameof(StatusComment), "Status Comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Summary = group.Add(new VocabularyKey(nameof(Summary), "Summary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VotersTotalNumberOf = group.Add(new VocabularyKey(nameof(VotersTotalNumberOf), "Total Number Of Voters", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    VotesDown = group.Add(new VocabularyKey(nameof(VotesDown), "Votes Down", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    VotesTotalNumberOf = group.Add(new VocabularyKey(nameof(VotesTotalNumberOf), "Total Number of Votes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    VoteSum = group.Add(new VocabularyKey(nameof(VoteSum), "Vote Sum", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    VotesUp = group.Add(new VocabularyKey(nameof(VotesUp), "Votes Up", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TotalVotes = group.Add(new VocabularyKey(nameof(TotalVotes), "Total Votes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TotalVotesDate = group.Add(new VocabularyKey(nameof(TotalVotesDate), "Total Votes (Last Updated On)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalVotesState = group.Add(new VocabularyKey(nameof(TotalVotesState), "Total Votes (State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    VotesSum = group.Add(new VocabularyKey(nameof(VotesSum), "Vote Sum", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    VotesSumDate = group.Add(new VocabularyKey(nameof(VotesSumDate), "Vote Sum (Last Updated On)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VotesSumState = group.Add(new VocabularyKey(nameof(VotesSumState), "Vote Sum (State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey IdeaId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Approved { get; private set; }
        public VocabularyKey AuthorEmail { get; private set; }
        public VocabularyKey AuthorName { get; private set; }
        public VocabularyKey CommentPolicy { get; private set; }
        public VocabularyKey Copy { get; private set; }
        public VocabularyKey AdxCreatedByIPAddress { get; private set; }
        public VocabularyKey AdxCreatedByUsername { get; private set; }
        public VocabularyKey SubmittedOn { get; private set; }
        public VocabularyKey PartialURL { get; private set; }
        public VocabularyKey StatusComment { get; private set; }
        public VocabularyKey Summary { get; private set; }
        public VocabularyKey VotersTotalNumberOf { get; private set; }
        public VocabularyKey VotesDown { get; private set; }
        public VocabularyKey VotesTotalNumberOf { get; private set; }
        public VocabularyKey VoteSum { get; private set; }
        public VocabularyKey VotesUp { get; private set; }
        public VocabularyKey TotalVotes { get; private set; }
        public VocabularyKey TotalVotesDate { get; private set; }
        public VocabularyKey TotalVotesState { get; private set; }
        public VocabularyKey VotesSum { get; private set; }
        public VocabularyKey VotesSumDate { get; private set; }
        public VocabularyKey VotesSumState { get; private set; }
    }
}