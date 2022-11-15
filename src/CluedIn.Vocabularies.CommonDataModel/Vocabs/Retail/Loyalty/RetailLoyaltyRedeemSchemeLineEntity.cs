using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyRedeemSchemeLineEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyRedeemSchemeLineEntityVocabulary()
        {
            VocabularyName = "Retail Loyalty Redeem Scheme Line Entity";
            KeyPrefix = "commonDataModel.retailloyaltyredeemschemelineentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyRedeemSchemeLineEntity";

            AddGroup("RetailLoyaltyRedeemSchemeLineEntity Details", group =>
            {
                FromRewardPoint = group.Add(new VocabularyKey(nameof(FromRewardPoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromRewardPointAmountQty = group.Add(new VocabularyKey(nameof(FromRewardPointAmountQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyScheme = group.Add(new VocabularyKey(nameof(LoyaltyScheme), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTier = group.Add(new VocabularyKey(nameof(LoyaltyTier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToRetailGroupMemberLine = group.Add(new VocabularyKey(nameof(ToRetailGroupMemberLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToRewardAmountCurrency = group.Add(new VocabularyKey(nameof(ToRewardAmountCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToRewardAmountQty = group.Add(new VocabularyKey(nameof(ToRewardAmountQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToRewardType = group.Add(new VocabularyKey(nameof(ToRewardType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltySchemeId = group.Add(new VocabularyKey(nameof(LoyaltySchemeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailLoyaltyTier_Affiliation = group.Add(new VocabularyKey(nameof(RetailLoyaltyTier_Affiliation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTierId = group.Add(new VocabularyKey(nameof(LoyaltyTierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyProgramName = group.Add(new VocabularyKey(nameof(LoyaltyProgramName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Color = group.Add(new VocabularyKey(nameof(Color), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Size = group.Add(new VocabularyKey(nameof(Size), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Style = group.Add(new VocabularyKey(nameof(Style), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfigId = group.Add(new VocabularyKey(nameof(ConfigId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromRewardPointId = group.Add(new VocabularyKey(nameof(FromRewardPointId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailAffiliationId = group.Add(new VocabularyKey(nameof(RetailAffiliationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AffiliationName = group.Add(new VocabularyKey(nameof(AffiliationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceDataAreaId = group.Add(new VocabularyKey(nameof(SourceDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FromRewardPoint { get; private set; }
        public VocabularyKey FromRewardPointAmountQty { get; private set; }
        public VocabularyKey LoyaltyScheme { get; private set; }
        public VocabularyKey LoyaltyTier { get; private set; }
        public VocabularyKey ToRetailGroupMemberLine { get; private set; }
        public VocabularyKey ToRewardAmountCurrency { get; private set; }
        public VocabularyKey ToRewardAmountQty { get; private set; }
        public VocabularyKey ToRewardType { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey LoyaltySchemeId { get; private set; }
        public VocabularyKey RetailLoyaltyTier_Affiliation { get; private set; }
        public VocabularyKey LoyaltyTierId { get; private set; }
        public VocabularyKey LoyaltyProgramName { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey Color { get; private set; }
        public VocabularyKey Size { get; private set; }
        public VocabularyKey Style { get; private set; }
        public VocabularyKey ConfigId { get; private set; }
        public VocabularyKey CategoryHierarchyName { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey FromRewardPointId { get; private set; }
        public VocabularyKey RetailAffiliationId { get; private set; }
        public VocabularyKey AffiliationName { get; private set; }
        public VocabularyKey SourceDataAreaId { get; private set; }
    }
}