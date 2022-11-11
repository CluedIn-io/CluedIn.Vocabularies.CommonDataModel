using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyCardEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyCardEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailLoyaltyCardEntity";
            KeyPrefix = "commonDataModel.retailloyaltycardentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyCardEntity";

            AddGroup("Common Data Model RetailLoyaltyCardEntity Details", group =>
            {
                CardNumber = group.Add(new VocabularyKey(nameof(CardNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardTenderType = group.Add(new VocabularyKey(nameof(CardTenderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Party = group.Add(new VocabularyKey(nameof(Party), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplacementCard = group.Add(new VocabularyKey(nameof(ReplacementCard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplacementCardNumber = group.Add(new VocabularyKey(nameof(ReplacementCardNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMOperatingUnitId = group.Add(new VocabularyKey(nameof(OMOperatingUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyEnrollmentDate = group.Add(new VocabularyKey(nameof(LoyaltyEnrollmentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OmOperatingUnitNumber = group.Add(new VocabularyKey(nameof(OmOperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyEnrollmentTime = group.Add(new VocabularyKey(nameof(LoyaltyEnrollmentTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyEnrollmentDateLocal = group.Add(new VocabularyKey(nameof(LoyaltyEnrollmentDateLocal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyEnrollmentTimeLocal = group.Add(new VocabularyKey(nameof(LoyaltyEnrollmentTimeLocal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CardNumber { get; private set; }
        public VocabularyKey CardTenderType { get; private set; }
        public VocabularyKey Party { get; private set; }
        public VocabularyKey ReplacementCard { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey ReplacementCardNumber { get; private set; }
        public VocabularyKey OMOperatingUnitId { get; private set; }
        public VocabularyKey LoyaltyEnrollmentDate { get; private set; }
        public VocabularyKey OmOperatingUnitNumber { get; private set; }
        public VocabularyKey LoyaltyEnrollmentTime { get; private set; }
        public VocabularyKey LoyaltyEnrollmentDateLocal { get; private set; }
        public VocabularyKey LoyaltyEnrollmentTimeLocal { get; private set; }


    }
}