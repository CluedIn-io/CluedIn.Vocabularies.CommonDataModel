using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmCampaignTargetEntityVocabulary : SimpleVocabulary
    {
        public SmmCampaignTargetEntityVocabulary()
        {
            VocabularyName = "Smm Campaign Target Entity";
            KeyPrefix = "commonDataModel.smmcampaigntargetentity";
            KeySeparator = ".";
            Grouping = "/SmmCampaignTargetEntity";

            AddGroup("SmmCampaignTargetEntity Details", group =>
            {
                TargetDescription = group.Add(new VocabularyKey(nameof(TargetDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetId = group.Add(new VocabularyKey(nameof(TargetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TargetDescription { get; private set; }
        public VocabularyKey TargetId { get; private set; }
    }
}