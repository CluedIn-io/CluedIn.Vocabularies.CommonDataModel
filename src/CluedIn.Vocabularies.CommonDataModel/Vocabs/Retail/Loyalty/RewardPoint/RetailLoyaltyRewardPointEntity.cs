using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyRewardPointEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyRewardPointEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailLoyaltyRewardPointEntity";
            KeyPrefix = "commonDataModel.retailloyaltyrewardpointentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyRewardPointEntity";

            AddGroup("Common Data Model RetailLoyaltyRewardPointEntity Details", group =>
            {
                ExpirationTimeUnit = group.Add(new VocabularyKey(nameof(ExpirationTimeUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationTimeValue = group.Add(new VocabularyKey(nameof(ExpirationTimeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Redeemable = group.Add(new VocabularyKey(nameof(Redeemable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RedeemRanking = group.Add(new VocabularyKey(nameof(RedeemRanking), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RewardPointCurrency = group.Add(new VocabularyKey(nameof(RewardPointCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RewardPointId = group.Add(new VocabularyKey(nameof(RewardPointId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RewardPointType = group.Add(new VocabularyKey(nameof(RewardPointType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VestingTimeUnit = group.Add(new VocabularyKey(nameof(VestingTimeUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VestingTimeValue = group.Add(new VocabularyKey(nameof(VestingTimeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumLoyaltyRewardPoints = group.Add(new VocabularyKey(nameof(MaximumLoyaltyRewardPoints), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ExpirationTimeUnit { get; private set; }
        public VocabularyKey ExpirationTimeValue { get; private set; }
        public VocabularyKey Redeemable { get; private set; }
        public VocabularyKey RedeemRanking { get; private set; }
        public VocabularyKey RewardPointCurrency { get; private set; }
        public VocabularyKey RewardPointId { get; private set; }
        public VocabularyKey RewardPointType { get; private set; }
        public VocabularyKey VestingTimeUnit { get; private set; }
        public VocabularyKey VestingTimeValue { get; private set; }
        public VocabularyKey MaximumLoyaltyRewardPoints { get; private set; }


    }
}