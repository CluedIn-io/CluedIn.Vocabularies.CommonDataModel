using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInLeadGenFormSubmissionVocabulary : SimpleVocabulary
    {
        public LinkedInLeadGenFormSubmissionVocabulary()
        {
            VocabularyName = "LinkedInLeadGenFormSubmission";
            KeyPrefix = "commonDataModel.linkedinleadgenformsubmission";
            KeySeparator = ".";
            Grouping = "/LinkedInLeadGenFormSubmission";

            AddGroup("LinkedInLeadGenFormSubmission Details", group =>
            {
                linkedInAccountId = group.Add(new VocabularyKey(nameof(linkedInAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedInCampaignID = group.Add(new VocabularyKey(nameof(linkedInCampaignID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedInCreativeID = group.Add(new VocabularyKey(nameof(linkedInCreativeID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedInFormName = group.Add(new VocabularyKey(nameof(linkedInFormName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedinformsubmissionTextid = group.Add(new VocabularyKey(nameof(linkedinformsubmissionTextid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedinformsubmissionId = group.Add(new VocabularyKey(nameof(linkedinformsubmissionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                matchingStatus = group.Add(new VocabularyKey(nameof(matchingStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                processingState = group.Add(new VocabularyKey(nameof(processingState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                submissionDate = group.Add(new VocabularyKey(nameof(submissionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                type = group.Add(new VocabularyKey(nameof(type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey linkedInAccountId { get; private set; }
        public VocabularyKey linkedInCampaignID { get; private set; }
        public VocabularyKey linkedInCreativeID { get; private set; }
        public VocabularyKey linkedInFormName { get; private set; }
        public VocabularyKey linkedinformsubmissionTextid { get; private set; }
        public VocabularyKey linkedinformsubmissionId { get; private set; }
        public VocabularyKey matchingStatus { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey processingState { get; private set; }
        public VocabularyKey submissionDate { get; private set; }
        public VocabularyKey type { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}