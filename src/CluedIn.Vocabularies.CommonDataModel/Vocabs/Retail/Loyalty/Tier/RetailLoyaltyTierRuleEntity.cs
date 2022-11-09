using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyTierRuleEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyTierRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailLoyaltyTierRuleEntity";
            KeyPrefix = "commonDataModel.retailloyaltytierruleentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyTierRuleEntity";

            AddGroup("Common Data Model RetailLoyaltyTierRuleEntity Details", group =>
            {
                LoyaltyTier = group.Add(new VocabularyKey(nameof(LoyaltyTier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinValue = group.Add(new VocabularyKey(nameof(MinValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PoolRelatedCards = group.Add(new VocabularyKey(nameof(PoolRelatedCards), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RewardPoint = group.Add(new VocabularyKey(nameof(RewardPoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EvaluationDateInterval = group.Add(new VocabularyKey(nameof(EvaluationDateInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RewardPointId = group.Add(new VocabularyKey(nameof(RewardPointId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Affiliation = group.Add(new VocabularyKey(nameof(Affiliation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltyTierId = group.Add(new VocabularyKey(nameof(LoyaltyTierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltyName = group.Add(new VocabularyKey(nameof(LoyaltyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LoyaltyTier { get; private set; }
public VocabularyKey MinValue { get; private set; }
public VocabularyKey PoolRelatedCards { get; private set; }
public VocabularyKey RewardPoint { get; private set; }
public VocabularyKey EvaluationDateInterval { get; private set; }
public VocabularyKey RewardPointId { get; private set; }
public VocabularyKey Affiliation { get; private set; }
public VocabularyKey LoyaltyTierId { get; private set; }
public VocabularyKey LoyaltyName { get; private set; }


    }
}