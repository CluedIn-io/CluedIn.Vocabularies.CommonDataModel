using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmCampaignTargetEntityVocabulary : SimpleVocabulary
    {
        public smmCampaignTargetEntityVocabulary()
        {
            VocabularyName = "smmCampaignTargetEntity";
            KeyPrefix = "commonDataModel.smmcampaigntargetentity";
            KeySeparator = ".";
            Grouping = "/smmCampaignTargetEntity";

            AddGroup("smmCampaignTargetEntity Details", group =>
            {
                TargetDescription = group.Add(new VocabularyKey(nameof(TargetDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetId = group.Add(new VocabularyKey(nameof(TargetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TargetDescription { get; private set; }
        public VocabularyKey TargetId { get; private set; }


    }
}