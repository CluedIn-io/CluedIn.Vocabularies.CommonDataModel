using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmCampaignCancellationReasonCodeEntityVocabulary : SimpleVocabulary
    {
        public SmmCampaignCancellationReasonCodeEntityVocabulary()
        {
            VocabularyName = "Smm Campaign Cancellation Reason Code Entity";
            KeyPrefix = "commonDataModel.smmcampaigncancellationreasoncodeentity";
            KeySeparator = ".";
            Grouping = "/SmmCampaignCancellationReasonCodeEntity";

            AddGroup("SmmCampaignCancellationReasonCodeEntity Details", group =>
            {
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ReasonDescription { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
    }
}