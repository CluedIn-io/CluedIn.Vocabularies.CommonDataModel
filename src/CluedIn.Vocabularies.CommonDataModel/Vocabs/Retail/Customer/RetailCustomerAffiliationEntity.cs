using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCustomerAffiliationEntityVocabulary : SimpleVocabulary
    {
        public RetailCustomerAffiliationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailCustomerAffiliationEntity";
            KeyPrefix = "commonDataModel.retailcustomeraffiliationentity";
            KeySeparator = ".";
            Grouping = "/RetailCustomerAffiliationEntity";

            AddGroup("Common Data Model RetailCustomerAffiliationEntity Details", group =>
            {
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reference = group.Add(new VocabularyKey(nameof(Reference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailAffiliationName = group.Add(new VocabularyKey(nameof(RetailAffiliationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey RetailAffiliationName { get; private set; }


    }
}