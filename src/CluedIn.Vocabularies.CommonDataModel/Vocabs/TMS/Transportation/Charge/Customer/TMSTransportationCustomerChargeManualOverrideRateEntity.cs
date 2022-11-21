using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationCustomerChargeManualOverrideRateEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationCustomerChargeManualOverrideRateEntityVocabulary()
        {
            VocabularyName = "TMS Transportation Customer Charge Manual Override Rate Entity";
            KeyPrefix = "commonDataModel.tmstransportationcustomerchargemanualoverriderateentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationCustomerChargeManualOverrideRateEntity";

            AddGroup("TMSTransportationCustomerChargeManualOverrideRateEntity Details", group =>
            {
                AccessorialChargeMasterCode = group.Add(new VocabularyKey(nameof(AccessorialChargeMasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateUnitPriceCurrencyCode = group.Add(new VocabularyKey(nameof(RateUnitPriceCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateUnitPrice = group.Add(new VocabularyKey(nameof(RateUnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateQuantity = group.Add(new VocabularyKey(nameof(RateQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationCustomerChargeCustomerAccountNumber = group.Add(new VocabularyKey(nameof(TransportationCustomerChargeCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccessorialChargeMasterCode { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ShippingCarrierServiceId { get; private set; }
        public VocabularyKey RateUnitPriceCurrencyCode { get; private set; }
        public VocabularyKey RateUnitPrice { get; private set; }
        public VocabularyKey RateQuantity { get; private set; }
        public VocabularyKey TransportationCustomerChargeCustomerAccountNumber { get; private set; }
    }
}