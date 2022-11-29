using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class PollSubmissionVocabulary : SimpleVocabulary
    {
        public PollSubmissionVocabulary()
        {
            VocabularyName = "Poll Submission";
            KeyPrefix = "commonDataModel.pollsubmission.portals";
            KeySeparator = ".";
            Grouping = "/PollSubmission";

            AddGroup("PollSubmission Details for Portals", group =>
            {
			    PollSubmissionId = group.Add(new VocabularyKey(nameof(PollSubmissionId), "Poll Submission", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VisitorID = group.Add(new VocabularyKey(nameof(VisitorID), "Visitor ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey PollSubmissionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey VisitorID { get; private set; }
    }
}