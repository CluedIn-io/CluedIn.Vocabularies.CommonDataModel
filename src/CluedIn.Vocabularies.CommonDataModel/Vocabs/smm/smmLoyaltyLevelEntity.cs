using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmLoyaltyLevelEntityVocabulary : SimpleVocabulary
    {
        public smmLoyaltyLevelEntityVocabulary()
        {
            VocabularyName = "smmLoyaltyLevelEntity";
            KeyPrefix = "commonDataModel.smmloyaltylevelentity";
            KeySeparator = ".";
            Grouping = "/smmLoyaltyLevelEntity";

            AddGroup("smmLoyaltyLevelEntity Details", group =>
            {
                LevelDescription = group.Add(new VocabularyKey(nameof(LevelDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LevelPhrase = group.Add(new VocabularyKey(nameof(LevelPhrase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LevelDescription { get; private set; }
        public VocabularyKey LevelPhrase { get; private set; }


    }
}