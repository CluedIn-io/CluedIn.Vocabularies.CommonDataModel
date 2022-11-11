using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyCardTierEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyCardTierEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailLoyaltyCardTierEntity";
            KeyPrefix = "commonDataModel.retailloyaltycardtierentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyCardTierEntity";

            AddGroup("Common Data Model RetailLoyaltyCardTierEntity Details", group =>
            {
                Affiliation = group.Add(new VocabularyKey(nameof(Affiliation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyCard = group.Add(new VocabularyKey(nameof(LoyaltyCard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTier = group.Add(new VocabularyKey(nameof(LoyaltyTier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AffiliationType = group.Add(new VocabularyKey(nameof(AffiliationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyProgramName = group.Add(new VocabularyKey(nameof(LoyaltyProgramName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyCardNumber = group.Add(new VocabularyKey(nameof(LoyaltyCardNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTierAffiliation = group.Add(new VocabularyKey(nameof(LoyaltyTierAffiliation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTierId = group.Add(new VocabularyKey(nameof(LoyaltyTierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTierAffiliationName = group.Add(new VocabularyKey(nameof(LoyaltyTierAffiliationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Affiliation { get; private set; }
        public VocabularyKey LoyaltyCard { get; private set; }
        public VocabularyKey LoyaltyTier { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey AffiliationType { get; private set; }
        public VocabularyKey LoyaltyProgramName { get; private set; }
        public VocabularyKey LoyaltyCardNumber { get; private set; }
        public VocabularyKey LoyaltyTierAffiliation { get; private set; }
        public VocabularyKey LoyaltyTierId { get; private set; }
        public VocabularyKey LoyaltyTierAffiliationName { get; private set; }


    }
}