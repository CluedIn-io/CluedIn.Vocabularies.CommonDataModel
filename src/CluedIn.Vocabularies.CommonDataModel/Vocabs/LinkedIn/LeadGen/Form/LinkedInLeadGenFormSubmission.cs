using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInLeadGenFormSubmissionVocabulary : SimpleVocabulary
    {
        public LinkedInLeadGenFormSubmissionVocabulary()
        {
            VocabularyName = "Linked In Lead Gen Form Submission";
            KeyPrefix = "commonDataModel.linkedinleadgenformsubmission";
            KeySeparator = ".";
            Grouping = "/LinkedInLeadGenFormSubmission";

            AddGroup("LinkedInLeadGenFormSubmission Details", group =>
            {
                LinkedInAccountId = group.Add(new VocabularyKey(nameof(LinkedInAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInCampaignID = group.Add(new VocabularyKey(nameof(LinkedInCampaignID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInCreativeID = group.Add(new VocabularyKey(nameof(LinkedInCreativeID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInFormName = group.Add(new VocabularyKey(nameof(LinkedInFormName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedinformsubmissionTextid = group.Add(new VocabularyKey(nameof(LinkedinformsubmissionTextid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedinformsubmissionId = group.Add(new VocabularyKey(nameof(LinkedinformsubmissionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchingStatus = group.Add(new VocabularyKey(nameof(MatchingStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessingState = group.Add(new VocabularyKey(nameof(ProcessingState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubmissionDate = group.Add(new VocabularyKey(nameof(SubmissionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LinkedInAccountId { get; private set; }
        public VocabularyKey LinkedInCampaignID { get; private set; }
        public VocabularyKey LinkedInCreativeID { get; private set; }
        public VocabularyKey LinkedInFormName { get; private set; }
        public VocabularyKey LinkedinformsubmissionTextid { get; private set; }
        public VocabularyKey LinkedinformsubmissionId { get; private set; }
        public VocabularyKey MatchingStatus { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcessingState { get; private set; }
        public VocabularyKey SubmissionDate { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}