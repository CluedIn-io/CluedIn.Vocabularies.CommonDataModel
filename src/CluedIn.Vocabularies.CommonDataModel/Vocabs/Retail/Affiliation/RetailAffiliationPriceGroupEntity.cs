using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailAffiliationPriceGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailAffiliationPriceGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailAffiliationPriceGroupEntity";
            KeyPrefix = "commonDataModel.retailaffiliationpricegroupentity";
            KeySeparator = ".";
            Grouping = "/RetailAffiliationPriceGroupEntity";

            AddGroup("Common Data Model RetailAffiliationPriceGroupEntity Details", group =>
            {
                AffiliationName = group.Add(new VocabularyKey(nameof(AffiliationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceCustomerGroupCode = group.Add(new VocabularyKey(nameof(PriceCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceCustomerGroupLegalEntity = group.Add(new VocabularyKey(nameof(PriceCustomerGroupLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AffiliationName { get; private set; }
        public VocabularyKey PriceCustomerGroupCode { get; private set; }
        public VocabularyKey PriceCustomerGroupLegalEntity { get; private set; }


    }
}