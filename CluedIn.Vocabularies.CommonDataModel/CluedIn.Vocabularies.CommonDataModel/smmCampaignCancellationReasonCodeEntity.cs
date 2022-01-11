using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmCampaignCancellationReasonCodeEntityVocabulary : SimpleVocabulary
    {
        public smmCampaignCancellationReasonCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmCampaignCancellationReasonCodeEntity";
            KeyPrefix = "commonDataModel.smmcampaigncancellationreasoncodeentity";
            KeySeparator = ".";
            Grouping = "/smmCampaignCancellationReasonCodeEntity";

            AddGroup("Common Data Model smmCampaignCancellationReasonCodeEntity Details", group =>
            {
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ReasonDescription { get; private set; }
public VocabularyKey ReasonCode { get; private set; }


    }
}