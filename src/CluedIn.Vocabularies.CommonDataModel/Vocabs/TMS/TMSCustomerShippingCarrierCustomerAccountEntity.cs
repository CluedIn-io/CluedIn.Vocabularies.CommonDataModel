using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSCustomerShippingCarrierCustomerAccountEntityVocabulary : SimpleVocabulary
    {
        public TMSCustomerShippingCarrierCustomerAccountEntityVocabulary()
        {
            VocabularyName = "TMS Customer Shipping Carrier Customer Account Entity";
            KeyPrefix = "commonDataModel.tmscustomershippingcarriercustomeraccountentity";
            KeySeparator = ".";
            Grouping = "/TMSCustomerShippingCarrierCustomerAccountEntity";

            AddGroup("TMSCustomerShippingCarrierCustomerAccountEntity Details", group =>
            {
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierCustomerAccountNumber = group.Add(new VocabularyKey(nameof(ShippingCarrierCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey ShippingCarrierCustomerAccountNumber { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
    }
}