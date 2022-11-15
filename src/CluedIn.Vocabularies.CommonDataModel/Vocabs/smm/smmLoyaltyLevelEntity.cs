using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmLoyaltyLevelEntityVocabulary : SimpleVocabulary
    {
        public SmmLoyaltyLevelEntityVocabulary()
        {
            VocabularyName = "Smm Loyalty Level Entity";
            KeyPrefix = "commonDataModel.smmloyaltylevelentity";
            KeySeparator = ".";
            Grouping = "/SmmLoyaltyLevelEntity";

            AddGroup("SmmLoyaltyLevelEntity Details", group =>
            {
                LevelDescription = group.Add(new VocabularyKey(nameof(LevelDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LevelPhrase = group.Add(new VocabularyKey(nameof(LevelPhrase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LevelDescription { get; private set; }
        public VocabularyKey LevelPhrase { get; private set; }
    }
}