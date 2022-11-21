using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyCardRewardPointNonTransactionalActivityEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyCardRewardPointNonTransactionalActivityEntityVocabulary()
        {
            VocabularyName = "Retail Loyalty Card Reward Point Non Transactional Activity Entity";
            KeyPrefix = "commonDataModel.retailloyaltycardrewardpointnontransactionalactivityentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyCardRewardPointNonTransactionalActivityEntity";

            AddGroup("RetailLoyaltyCardRewardPointNonTransactionalActivityEntity Details", group =>
            {
                CardNumber = group.Add(new VocabularyKey(nameof(CardNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonTransactionalActivityId = group.Add(new VocabularyKey(nameof(NonTransactionalActivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyOtherActivityTypeId = group.Add(new VocabularyKey(nameof(LoyaltyOtherActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMOperatingUnitID = group.Add(new VocabularyKey(nameof(OMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntryDate = group.Add(new VocabularyKey(nameof(EntryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntryTime = group.Add(new VocabularyKey(nameof(EntryTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailAffiliationId = group.Add(new VocabularyKey(nameof(RetailAffiliationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorLogs = group.Add(new VocabularyKey(nameof(ErrorLogs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CardNumber { get; private set; }
        public VocabularyKey NonTransactionalActivityId { get; private set; }
        public VocabularyKey LoyaltyOtherActivityTypeId { get; private set; }
        public VocabularyKey OMOperatingUnitID { get; private set; }
        public VocabularyKey EntryDate { get; private set; }
        public VocabularyKey EntryTime { get; private set; }
        public VocabularyKey RetailAffiliationId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey ErrorLogs { get; private set; }
    }
}