using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInFormSubmissionVocabulary : SimpleVocabulary
    {
        public LinkedInFormSubmissionVocabulary()
        {
            VocabularyName = "LinkedInFormSubmission";
            KeyPrefix = "commonDataModel.linkedinformsubmission";
            KeySeparator = ".";
            Grouping = "/LinkedInFormSubmission";

            AddGroup("LinkedInFormSubmission Details", group =>
            {
                answerTextid = group.Add(new VocabularyKey(nameof(answerTextid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                answerFormat = group.Add(new VocabularyKey(nameof(answerFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                answerText = group.Add(new VocabularyKey(nameof(answerText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedInFormAnswerId = group.Add(new VocabularyKey(nameof(linkedInFormAnswerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedInQuestionID = group.Add(new VocabularyKey(nameof(linkedInQuestionID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey answerTextid { get; private set; }
        public VocabularyKey answerFormat { get; private set; }
        public VocabularyKey answerText { get; private set; }
        public VocabularyKey linkedInFormAnswerId { get; private set; }
        public VocabularyKey linkedInQuestionID { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}