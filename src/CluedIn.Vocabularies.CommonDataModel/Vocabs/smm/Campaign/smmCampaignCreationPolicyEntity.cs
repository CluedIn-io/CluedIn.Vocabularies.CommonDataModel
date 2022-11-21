using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmCampaignCreationPolicyEntityVocabulary : SimpleVocabulary
    {
        public SmmCampaignCreationPolicyEntityVocabulary()
        {
            VocabularyName = "Smm Campaign Creation Policy Entity";
            KeyPrefix = "commonDataModel.smmcampaigncreationpolicyentity";
            KeySeparator = ".";
            Grouping = "/SmmCampaignCreationPolicyEntity";

            AddGroup("SmmCampaignCreationPolicyEntity Details", group =>
            {
                DefaultStatus = group.Add(new VocabularyKey(nameof(DefaultStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCampaignTypeId = group.Add(new VocabularyKey(nameof(DefaultCampaignTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCampaignGroupId = group.Add(new VocabularyKey(nameof(DefaultCampaignGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCampaignTargetId = group.Add(new VocabularyKey(nameof(DefaultCampaignTargetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultActiveDays = group.Add(new VocabularyKey(nameof(DefaultActiveDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultFollowUpDays = group.Add(new VocabularyKey(nameof(DefaultFollowUpDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DefaultStatus { get; private set; }
        public VocabularyKey DefaultCampaignTypeId { get; private set; }
        public VocabularyKey DefaultCampaignGroupId { get; private set; }
        public VocabularyKey DefaultCampaignTargetId { get; private set; }
        public VocabularyKey DefaultActiveDays { get; private set; }
        public VocabularyKey DefaultFollowUpDays { get; private set; }
    }
}