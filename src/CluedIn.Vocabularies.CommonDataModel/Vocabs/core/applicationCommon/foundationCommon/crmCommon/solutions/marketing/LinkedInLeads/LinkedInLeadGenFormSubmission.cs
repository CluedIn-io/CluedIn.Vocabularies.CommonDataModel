using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.LinkedInLeads
{
    public class LinkedInLeadGenFormSubmissionVocabulary : SimpleVocabulary
    {
        public LinkedInLeadGenFormSubmissionVocabulary()
        {
            VocabularyName = "Linked In Lead Gen Form Submission";
            KeyPrefix = "commonDataModel.linkedinleadgenformsubmission.linkedinleads";
            KeySeparator = ".";
            Grouping = "/LinkedInLeadGenFormSubmission";

            AddGroup("LinkedInLeadGenFormSubmission Details for LinkedInLeads", group =>
            {
			    LinkedInFormSubmissionId = group.Add(new VocabularyKey(nameof(LinkedInFormSubmissionId), "LinkedIn ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInAccountID = group.Add(new VocabularyKey(nameof(LinkedInAccountID), "LinkedIn account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInCampaignID = group.Add(new VocabularyKey(nameof(LinkedInCampaignID), "LinkedIn campaign ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInCreativeID = group.Add(new VocabularyKey(nameof(LinkedInCreativeID), "LinkedIn Creative ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInLeadGenFormSubmissionTextId = group.Add(new VocabularyKey(nameof(LinkedInLeadGenFormSubmissionTextId), "LinkedIn Lead Gen Form Submission Text Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInUserProfileID = group.Add(new VocabularyKey(nameof(LinkedInUserProfileID), "LinkedIn User Profile", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MatchingStatus = group.Add(new VocabularyKey(nameof(MatchingStatus), "Matching status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessingState = group.Add(new VocabularyKey(nameof(ProcessingState), "Processing State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubmissionDate = group.Add(new VocabularyKey(nameof(SubmissionDate), "Submission date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInFormName = group.Add(new VocabularyKey(nameof(LinkedInFormName), "Source Form", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey LinkedInFormSubmissionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey LinkedInAccountID { get; private set; }
        public VocabularyKey LinkedInCampaignID { get; private set; }
        public VocabularyKey LinkedInCreativeID { get; private set; }
        public VocabularyKey LinkedInLeadGenFormSubmissionTextId { get; private set; }
        public VocabularyKey LinkedInUserProfileID { get; private set; }
        public VocabularyKey MatchingStatus { get; private set; }
        public VocabularyKey ProcessingState { get; private set; }
        public VocabularyKey SubmissionDate { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey LinkedInFormName { get; private set; }
    }
}