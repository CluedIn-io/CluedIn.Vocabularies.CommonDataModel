using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInCampaignVocabulary : SimpleVocabulary
    {
        public LinkedInCampaignVocabulary()
        {
            VocabularyName = "Linked In Campaign";
            KeyPrefix = "commonDataModel.linkedincampaign";
            KeySeparator = ".";
            Grouping = "/LinkedInCampaign";

            AddGroup("LinkedInCampaign Details", group =>
            {
                CampaignType = group.Add(new VocabularyKey(nameof(CampaignType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInCampaignId = group.Add(new VocabularyKey(nameof(LinkedInCampaignId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInID = group.Add(new VocabularyKey(nameof(LinkedInID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInStatus = group.Add(new VocabularyKey(nameof(LinkedInStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalLeads = group.Add(new VocabularyKey(nameof(TotalLeads), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalSubmissions = group.Add(new VocabularyKey(nameof(TotalSubmissions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CampaignType { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey LinkedInCampaignId { get; private set; }
        public VocabularyKey LinkedInID { get; private set; }
        public VocabularyKey LinkedInStatus { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey TotalLeads { get; private set; }
        public VocabularyKey TotalSubmissions { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}