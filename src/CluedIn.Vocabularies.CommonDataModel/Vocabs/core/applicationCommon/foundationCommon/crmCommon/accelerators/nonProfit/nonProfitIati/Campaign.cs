using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class CampaignVocabulary : SimpleVocabulary
    {
        public CampaignVocabulary()
        {
            VocabularyName = "Campaign";
            KeyPrefix = "commonDataModel.campaign.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/Campaign";

            AddGroup("Campaign Details for NonProfitIati", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Entity Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AppealSegment = group.Add(new VocabularyKey(nameof(AppealSegment), "Appeal Segment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AquisitionSource = group.Add(new VocabularyKey(nameof(AquisitionSource), "Acquisition Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CampaignCategory = group.Add(new VocabularyKey(nameof(CampaignCategory), "Campaign Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CampaignType = group.Add(new VocabularyKey(nameof(CampaignType), "Campaign Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Channel = group.Add(new VocabularyKey(nameof(Channel), "Channel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Effort = group.Add(new VocabularyKey(nameof(Effort), "Effort", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FirstResponseDate = group.Add(new VocabularyKey(nameof(FirstResponseDate), "First Response Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastResponseDate = group.Add(new VocabularyKey(nameof(LastResponseDate), "Last Response Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SourceCode = group.Add(new VocabularyKey(nameof(SourceCode), "Source Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubChannel = group.Add(new VocabularyKey(nameof(SubChannel), "SubChannel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AppealSegment { get; private set; }
        public VocabularyKey AquisitionSource { get; private set; }
        public VocabularyKey CampaignCategory { get; private set; }
        public VocabularyKey CampaignType { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey Effort { get; private set; }
        public VocabularyKey FirstResponseDate { get; private set; }
        public VocabularyKey LastResponseDate { get; private set; }
        public VocabularyKey SourceCode { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey SubChannel { get; private set; }
    }
}