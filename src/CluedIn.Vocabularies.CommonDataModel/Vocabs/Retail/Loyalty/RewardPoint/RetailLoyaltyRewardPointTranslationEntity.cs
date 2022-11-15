using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyRewardPointTranslationEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyRewardPointTranslationEntityVocabulary()
        {
            VocabularyName = "Retail Loyalty Reward Point Translation Entity";
            KeyPrefix = "commonDataModel.retailloyaltyrewardpointtranslationentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyRewardPointTranslationEntity";

            AddGroup("RetailLoyaltyRewardPointTranslationEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RewardPoint = group.Add(new VocabularyKey(nameof(RewardPoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailLoyaltyRewardPointId = group.Add(new VocabularyKey(nameof(RetailLoyaltyRewardPointId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey RewardPoint { get; private set; }
        public VocabularyKey RetailLoyaltyRewardPointId { get; private set; }
    }
}