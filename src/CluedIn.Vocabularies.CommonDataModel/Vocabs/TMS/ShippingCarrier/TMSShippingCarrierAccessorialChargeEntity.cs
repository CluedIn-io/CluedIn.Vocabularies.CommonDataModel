using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSShippingCarrierAccessorialChargeEntityVocabulary : SimpleVocabulary
    {
        public TMSShippingCarrierAccessorialChargeEntityVocabulary()
        {
            VocabularyName = "TMSShippingCarrierAccessorialChargeEntity";
            KeyPrefix = "commonDataModel.tmsshippingcarrieraccessorialchargeentity";
            KeySeparator = ".";
            Grouping = "/TMSShippingCarrierAccessorialChargeEntity";

            AddGroup("TMSShippingCarrierAccessorialChargeEntity Details", group =>
            {
                AccessorialChargeMasterCode = group.Add(new VocabularyKey(nameof(AccessorialChargeMasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationBillingGroupId = group.Add(new VocabularyKey(nameof(TransportationBillingGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeId = group.Add(new VocabularyKey(nameof(ChargeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalChargeCode = group.Add(new VocabularyKey(nameof(ExternalChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccessorialDeliveryType = group.Add(new VocabularyKey(nameof(AccessorialDeliveryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccessorialChargeMasterCode { get; private set; }
        public VocabularyKey TransportationBillingGroupId { get; private set; }
        public VocabularyKey ChargeId { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ShippingCarrierServiceId { get; private set; }
        public VocabularyKey ExternalChargeCode { get; private set; }
        public VocabularyKey AccessorialDeliveryType { get; private set; }


    }
}