using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailLoyaltyEntity";
            KeyPrefix = "commonDataModel.retailloyaltyentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyEntity";

            AddGroup("Common Data Model RetailLoyaltyEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PoolRelatedCards = group.Add(new VocabularyKey(nameof(PoolRelatedCards), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey PoolRelatedCards { get; private set; }


    }
}