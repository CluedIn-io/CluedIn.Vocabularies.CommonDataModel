using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyTierEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyTierEntityVocabulary()
        {
            VocabularyName = "RetailLoyaltyTierEntity";
            KeyPrefix = "commonDataModel.retailloyaltytierentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyTierEntity";

            AddGroup("RetailLoyaltyTierEntity Details", group =>
            {
                Affiliation = group.Add(new VocabularyKey(nameof(Affiliation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TierId = group.Add(new VocabularyKey(nameof(TierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TierLevel = group.Add(new VocabularyKey(nameof(TierLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidDateInterval = group.Add(new VocabularyKey(nameof(ValidDateInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyName = group.Add(new VocabularyKey(nameof(LoyaltyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Affiliation { get; private set; }
        public VocabularyKey TierId { get; private set; }
        public VocabularyKey TierLevel { get; private set; }
        public VocabularyKey ValidDateInterval { get; private set; }
        public VocabularyKey LoyaltyName { get; private set; }


    }
}