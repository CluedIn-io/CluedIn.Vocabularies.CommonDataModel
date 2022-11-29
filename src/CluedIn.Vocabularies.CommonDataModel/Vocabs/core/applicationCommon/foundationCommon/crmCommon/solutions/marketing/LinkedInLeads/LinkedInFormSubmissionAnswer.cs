using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.LinkedInLeads
{
    public class LinkedInFormSubmissionAnswerVocabulary : SimpleVocabulary
    {
        public LinkedInFormSubmissionAnswerVocabulary()
        {
            VocabularyName = "Linked In Form Submission Answer";
            KeyPrefix = "commonDataModel.linkedinformsubmissionanswer.linkedinleads";
            KeySeparator = ".";
            Grouping = "/LinkedInFormSubmissionAnswer";

            AddGroup("LinkedInFormSubmissionAnswer Details for LinkedInLeads", group =>
            {
			    LinkedInFormAnswerId = group.Add(new VocabularyKey(nameof(LinkedInFormAnswerId), "LinkedIn Form Answer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AnswerId = group.Add(new VocabularyKey(nameof(AnswerId), "Answer Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AnswerFormat = group.Add(new VocabularyKey(nameof(AnswerFormat), "Answer format", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AnswerText = group.Add(new VocabularyKey(nameof(AnswerText), "Answer text", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInQuestionID = group.Add(new VocabularyKey(nameof(LinkedInQuestionID), "LinkedIn question ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey LinkedInFormAnswerId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AnswerId { get; private set; }
        public VocabularyKey AnswerFormat { get; private set; }
        public VocabularyKey AnswerText { get; private set; }
        public VocabularyKey LinkedInQuestionID { get; private set; }
    }
}