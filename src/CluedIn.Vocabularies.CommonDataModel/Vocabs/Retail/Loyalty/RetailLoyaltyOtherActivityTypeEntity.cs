using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyOtherActivityTypeEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyOtherActivityTypeEntityVocabulary()
        {
            VocabularyName = "RetailLoyaltyOtherActivityTypeEntity";
            KeyPrefix = "commonDataModel.retailloyaltyotheractivitytypeentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyOtherActivityTypeEntity";

            AddGroup("RetailLoyaltyOtherActivityTypeEntity Details", group =>
            {
                LoyaltyOtherActivityTypeId = group.Add(new VocabularyKey(nameof(LoyaltyOtherActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyOtherActivityTypeName = group.Add(new VocabularyKey(nameof(LoyaltyOtherActivityTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyOtherActivityTypeDescription = group.Add(new VocabularyKey(nameof(LoyaltyOtherActivityTypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IgnoreVestingPeriod = group.Add(new VocabularyKey(nameof(IgnoreVestingPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LoyaltyOtherActivityTypeId { get; private set; }
        public VocabularyKey LoyaltyOtherActivityTypeName { get; private set; }
        public VocabularyKey LoyaltyOtherActivityTypeDescription { get; private set; }
        public VocabularyKey IgnoreVestingPeriod { get; private set; }


    }
}