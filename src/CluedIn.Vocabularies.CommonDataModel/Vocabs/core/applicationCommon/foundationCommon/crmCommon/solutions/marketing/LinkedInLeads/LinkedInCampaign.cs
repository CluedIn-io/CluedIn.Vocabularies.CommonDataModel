using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.LinkedInLeads
{
    public class LinkedInCampaignVocabulary : SimpleVocabulary
    {
        public LinkedInCampaignVocabulary()
        {
            VocabularyName = "Linked In Campaign";
            KeyPrefix = "commonDataModel.linkedincampaign.linkedinleads";
            KeySeparator = ".";
            Grouping = "/LinkedInCampaign";

            AddGroup("LinkedInCampaign Details for LinkedInLeads", group =>
            {
			    LinkedInCampaignID = group.Add(new VocabularyKey(nameof(LinkedInCampaignID), "LinkedIn Campaign", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CampaignType = group.Add(new VocabularyKey(nameof(CampaignType), "Campaign Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "Proposed End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInID = group.Add(new VocabularyKey(nameof(LinkedInID), "LinkedIn ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInStatus = group.Add(new VocabularyKey(nameof(LinkedInStatus), "LinkedIn Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Proposed Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey LinkedInCampaignID { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CampaignType { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey LinkedInID { get; private set; }
        public VocabularyKey LinkedInStatus { get; private set; }
        public VocabularyKey StartDate { get; private set; }
    }
}