using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInCampaignVocabulary : SimpleVocabulary
    {
        public LinkedInCampaignVocabulary()
        {
            VocabularyName = "Common Data Model LinkedInCampaign";
            KeyPrefix = "commonDataModel.linkedincampaign";
            KeySeparator = ".";
            Grouping = "/LinkedInCampaign";

            AddGroup("Common Data Model LinkedInCampaign Details", group =>
            {
                campaignType = group.Add(new VocabularyKey(nameof(campaignType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                endDate = group.Add(new VocabularyKey(nameof(endDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedInCampaignId = group.Add(new VocabularyKey(nameof(linkedInCampaignId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedInID = group.Add(new VocabularyKey(nameof(linkedInID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedInStatus = group.Add(new VocabularyKey(nameof(linkedInStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                startDate = group.Add(new VocabularyKey(nameof(startDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                totalLeads = group.Add(new VocabularyKey(nameof(totalLeads), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                totalSubmissions = group.Add(new VocabularyKey(nameof(totalSubmissions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey campaignType { get; private set; }
        public VocabularyKey endDate { get; private set; }
        public VocabularyKey linkedInCampaignId { get; private set; }
        public VocabularyKey linkedInID { get; private set; }
        public VocabularyKey linkedInStatus { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey startDate { get; private set; }
        public VocabularyKey totalLeads { get; private set; }
        public VocabularyKey totalSubmissions { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}