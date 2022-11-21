using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInFormSubmissionVocabulary : SimpleVocabulary
    {
        public LinkedInFormSubmissionVocabulary()
        {
            VocabularyName = "Linked In Form Submission";
            KeyPrefix = "commonDataModel.linkedinformsubmission";
            KeySeparator = ".";
            Grouping = "/LinkedInFormSubmission";

            AddGroup("LinkedInFormSubmission Details", group =>
            {
                AnswerTextid = group.Add(new VocabularyKey(nameof(AnswerTextid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AnswerFormat = group.Add(new VocabularyKey(nameof(AnswerFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AnswerText = group.Add(new VocabularyKey(nameof(AnswerText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInFormAnswerId = group.Add(new VocabularyKey(nameof(LinkedInFormAnswerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInQuestionID = group.Add(new VocabularyKey(nameof(LinkedInQuestionID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AnswerTextid { get; private set; }
        public VocabularyKey AnswerFormat { get; private set; }
        public VocabularyKey AnswerText { get; private set; }
        public VocabularyKey LinkedInFormAnswerId { get; private set; }
        public VocabularyKey LinkedInQuestionID { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}