using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class PollVocabulary : SimpleVocabulary
    {
        public PollVocabulary()
        {
            VocabularyName = "Poll";
            KeyPrefix = "commonDataModel.poll.portals";
            KeySeparator = ".";
            Grouping = "/Poll";

            AddGroup("Poll Details for Portals", group =>
            {
			    PollId = group.Add(new VocabularyKey(nameof(PollId), "Poll", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Active = group.Add(new VocabularyKey(nameof(Active), "Active", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    CloseVotingDate = group.Add(new VocabularyKey(nameof(CloseVotingDate), "Close Voting Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), "Expiration Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Question = group.Add(new VocabularyKey(nameof(Question), "Question", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReleaseDate = group.Add(new VocabularyKey(nameof(ReleaseDate), "Release Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubmitButtonLabel = group.Add(new VocabularyKey(nameof(SubmitButtonLabel), "Submit Button Label", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey PollId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Active { get; private set; }
        public VocabularyKey CloseVotingDate { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey Question { get; private set; }
        public VocabularyKey ReleaseDate { get; private set; }
        public VocabularyKey SubmitButtonLabel { get; private set; }
    }
}