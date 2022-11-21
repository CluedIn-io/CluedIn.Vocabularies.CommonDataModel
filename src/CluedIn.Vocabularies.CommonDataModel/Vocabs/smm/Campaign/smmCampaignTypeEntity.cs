using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmCampaignTypeEntityVocabulary : SimpleVocabulary
    {
        public SmmCampaignTypeEntityVocabulary()
        {
            VocabularyName = "Smm Campaign Type Entity";
            KeyPrefix = "commonDataModel.smmcampaigntypeentity";
            KeySeparator = ".";
            Grouping = "/SmmCampaignTypeEntity";

            AddGroup("SmmCampaignTypeEntity Details", group =>
            {
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TypeDescription { get; private set; }
        public VocabularyKey TypeId { get; private set; }
    }
}