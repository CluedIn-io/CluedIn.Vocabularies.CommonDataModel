using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionLoyaltyRewardPointsLineEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionLoyaltyRewardPointsLineEntityVocabulary()
        {
            VocabularyName = "RetailTransactionLoyaltyRewardPointsLineEntity";
            KeyPrefix = "commonDataModel.retailtransactionloyaltyrewardpointslineentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionLoyaltyRewardPointsLineEntity";

            AddGroup("RetailTransactionLoyaltyRewardPointsLineEntity Details", group =>
            {
                AffiliationId = group.Add(new VocabularyKey(nameof(AffiliationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyCardNumber = group.Add(new VocabularyKey(nameof(LoyaltyCardNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntryDate = group.Add(new VocabularyKey(nameof(EntryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntryTime = group.Add(new VocabularyKey(nameof(EntryTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntryType = group.Add(new VocabularyKey(nameof(EntryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTier = group.Add(new VocabularyKey(nameof(LoyaltyTier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptNumber = group.Add(new VocabularyKey(nameof(ReceiptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RewardPoint = group.Add(new VocabularyKey(nameof(RewardPoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RewardPoints = group.Add(new VocabularyKey(nameof(RewardPoints), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelTableOMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTableOMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RewardPointId = group.Add(new VocabularyKey(nameof(RewardPointId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTierAffiliationId = group.Add(new VocabularyKey(nameof(LoyaltyTierAffiliationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTierId = group.Add(new VocabularyKey(nameof(LoyaltyTierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyName = group.Add(new VocabularyKey(nameof(LoyaltyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailTransactionSalesTransLineNum = group.Add(new VocabularyKey(nameof(RetailTransactionSalesTransLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AffiliationId { get; private set; }
        public VocabularyKey LoyaltyCardNumber { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey EntryDate { get; private set; }
        public VocabularyKey EntryTime { get; private set; }
        public VocabularyKey EntryType { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey LoyaltyTier { get; private set; }
        public VocabularyKey ReceiptNumber { get; private set; }
        public VocabularyKey RewardPoint { get; private set; }
        public VocabularyKey RewardPoints { get; private set; }
        public VocabularyKey Terminal { get; private set; }
        public VocabularyKey TransactionNumber { get; private set; }
        public VocabularyKey RetailChannelTableOMOperatingUnitID { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }
        public VocabularyKey RewardPointId { get; private set; }
        public VocabularyKey LoyaltyTierAffiliationId { get; private set; }
        public VocabularyKey LoyaltyTierId { get; private set; }
        public VocabularyKey LoyaltyName { get; private set; }
        public VocabularyKey RetailTransactionSalesTransLineNum { get; private set; }


    }
}