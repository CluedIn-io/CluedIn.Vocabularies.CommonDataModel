using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyTierPriceGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyTierPriceGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailLoyaltyTierPriceGroupEntity";
            KeyPrefix = "commonDataModel.retailloyaltytierpricegroupentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyTierPriceGroupEntity";

            AddGroup("Common Data Model RetailLoyaltyTierPriceGroupEntity Details", group =>
            {
                PriceDiscGroup = group.Add(new VocabularyKey(nameof(PriceDiscGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailAffiliation = group.Add(new VocabularyKey(nameof(RetailAffiliation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailLoyaltyTier = group.Add(new VocabularyKey(nameof(RetailLoyaltyTier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceGroupId = group.Add(new VocabularyKey(nameof(PriceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailLoyaltyTier_Affiliation = group.Add(new VocabularyKey(nameof(RetailLoyaltyTier_Affiliation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTierId = group.Add(new VocabularyKey(nameof(LoyaltyTierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceGroupCompany = group.Add(new VocabularyKey(nameof(PriceGroupCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyName = group.Add(new VocabularyKey(nameof(LoyaltyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PriceDiscGroup { get; private set; }
        public VocabularyKey RetailAffiliation { get; private set; }
        public VocabularyKey RetailLoyaltyTier { get; private set; }
        public VocabularyKey PriceGroupId { get; private set; }
        public VocabularyKey RetailLoyaltyTier_Affiliation { get; private set; }
        public VocabularyKey LoyaltyTierId { get; private set; }
        public VocabularyKey PriceGroupCompany { get; private set; }
        public VocabularyKey LoyaltyName { get; private set; }


    }
}