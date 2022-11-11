using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyPriceGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyPriceGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailLoyaltyPriceGroupEntity";
            KeyPrefix = "commonDataModel.retailloyaltypricegroupentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyPriceGroupEntity";

            AddGroup("Common Data Model RetailLoyaltyPriceGroupEntity Details", group =>
            {
                LoyaltyName = group.Add(new VocabularyKey(nameof(LoyaltyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceCustomerGroupCode = group.Add(new VocabularyKey(nameof(PriceCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceCustomerGroupCompany = group.Add(new VocabularyKey(nameof(PriceCustomerGroupCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LoyaltyName { get; private set; }
        public VocabularyKey PriceCustomerGroupCode { get; private set; }
        public VocabularyKey PriceCustomerGroupCompany { get; private set; }


    }
}