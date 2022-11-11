using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyCardRewardPointTransactionEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyCardRewardPointTransactionEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailLoyaltyCardRewardPointTransactionEntity";
            KeyPrefix = "commonDataModel.retailloyaltycardrewardpointtransactionentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyCardRewardPointTransactionEntity";

            AddGroup("Common Data Model RetailLoyaltyCardRewardPointTransactionEntity Details", group =>
            {
                AdjustmentId = group.Add(new VocabularyKey(nameof(AdjustmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyProgram = group.Add(new VocabularyKey(nameof(LoyaltyProgram), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardNumber = group.Add(new VocabularyKey(nameof(CardNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountCompany = group.Add(new VocabularyKey(nameof(CustomerAccountCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntryDate = group.Add(new VocabularyKey(nameof(EntryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntryTime = group.Add(new VocabularyKey(nameof(EntryTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntryType = group.Add(new VocabularyKey(nameof(EntryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTier = group.Add(new VocabularyKey(nameof(LoyaltyTier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTransactionType = group.Add(new VocabularyKey(nameof(LoyaltyTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTransactionCompany = group.Add(new VocabularyKey(nameof(LoyaltyTransactionCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTransactionLineNumber = group.Add(new VocabularyKey(nameof(LoyaltyTransactionLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptId = group.Add(new VocabularyKey(nameof(ReceiptId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Remaining = group.Add(new VocabularyKey(nameof(Remaining), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RewardPoint = group.Add(new VocabularyKey(nameof(RewardPoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RewardPointAmountQty = group.Add(new VocabularyKey(nameof(RewardPointAmountQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderId = group.Add(new VocabularyKey(nameof(SalesOrderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatorId = group.Add(new VocabularyKey(nameof(OperatorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyProgramName = group.Add(new VocabularyKey(nameof(LoyaltyProgramName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChannelOperatingUnitId = group.Add(new VocabularyKey(nameof(ChannelOperatingUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RewardPointId = group.Add(new VocabularyKey(nameof(RewardPointId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTierLoyaltyProgram = group.Add(new VocabularyKey(nameof(LoyaltyTierLoyaltyProgram), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTierId = group.Add(new VocabularyKey(nameof(LoyaltyTierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTierLoyaltyProgramName = group.Add(new VocabularyKey(nameof(LoyaltyTierLoyaltyProgramName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailTransactionSalesTransLineNum = group.Add(new VocabularyKey(nameof(RetailTransactionSalesTransLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesLineLineNum = group.Add(new VocabularyKey(nameof(SalesLineLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardTenderType = group.Add(new VocabularyKey(nameof(CardTenderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonTransactionalActivityId = group.Add(new VocabularyKey(nameof(NonTransactionalActivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyOtherActivityTypeId = group.Add(new VocabularyKey(nameof(LoyaltyOtherActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyOtherActivityTypeName = group.Add(new VocabularyKey(nameof(LoyaltyOtherActivityTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AdjustmentId { get; private set; }
        public VocabularyKey LoyaltyProgram { get; private set; }
        public VocabularyKey CardNumber { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey CustomerAccountCompany { get; private set; }
        public VocabularyKey EntryDate { get; private set; }
        public VocabularyKey EntryTime { get; private set; }
        public VocabularyKey EntryType { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey LoyaltyTier { get; private set; }
        public VocabularyKey LoyaltyTransactionType { get; private set; }
        public VocabularyKey LoyaltyTransactionCompany { get; private set; }
        public VocabularyKey LoyaltyTransactionLineNumber { get; private set; }
        public VocabularyKey ReceiptId { get; private set; }
        public VocabularyKey Remaining { get; private set; }
        public VocabularyKey RewardPoint { get; private set; }
        public VocabularyKey RewardPointAmountQty { get; private set; }
        public VocabularyKey SalesOrderId { get; private set; }
        public VocabularyKey OperatorId { get; private set; }
        public VocabularyKey Terminal { get; private set; }
        public VocabularyKey TransactionNumber { get; private set; }
        public VocabularyKey LoyaltyProgramName { get; private set; }
        public VocabularyKey ChannelOperatingUnitId { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }
        public VocabularyKey RewardPointId { get; private set; }
        public VocabularyKey LoyaltyTierLoyaltyProgram { get; private set; }
        public VocabularyKey LoyaltyTierId { get; private set; }
        public VocabularyKey LoyaltyTierLoyaltyProgramName { get; private set; }
        public VocabularyKey RetailTransactionSalesTransLineNum { get; private set; }
        public VocabularyKey SalesLineLineNum { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey CardTenderType { get; private set; }
        public VocabularyKey NonTransactionalActivityId { get; private set; }
        public VocabularyKey LoyaltyOtherActivityTypeId { get; private set; }
        public VocabularyKey LoyaltyOtherActivityTypeName { get; private set; }


    }
}