using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyTierTranslationEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyTierTranslationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailLoyaltyTierTranslationEntity";
            KeyPrefix = "commonDataModel.retailloyaltytiertranslationentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyTierTranslationEntity";

            AddGroup("Common Data Model RetailLoyaltyTierTranslationEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTier = group.Add(new VocabularyKey(nameof(LoyaltyTier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Affiliation = group.Add(new VocabularyKey(nameof(Affiliation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyTierId = group.Add(new VocabularyKey(nameof(LoyaltyTierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyProgramName = group.Add(new VocabularyKey(nameof(LoyaltyProgramName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey LoyaltyTier { get; private set; }
        public VocabularyKey Affiliation { get; private set; }
        public VocabularyKey LoyaltyTierId { get; private set; }
        public VocabularyKey LoyaltyProgramName { get; private set; }


    }
}