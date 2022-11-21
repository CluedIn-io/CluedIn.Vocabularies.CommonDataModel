using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmCampaignGroupEntityVocabulary : SimpleVocabulary
    {
        public SmmCampaignGroupEntityVocabulary()
        {
            VocabularyName = "Smm Campaign Group Entity";
            KeyPrefix = "commonDataModel.smmcampaigngroupentity";
            KeySeparator = ".";
            Grouping = "/SmmCampaignGroupEntity";

            AddGroup("SmmCampaignGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey GroupId { get; private set; }
    }
}