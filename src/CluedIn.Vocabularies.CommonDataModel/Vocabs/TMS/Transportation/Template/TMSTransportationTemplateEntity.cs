using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationTemplateEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationTemplateEntityVocabulary()
        {
            VocabularyName = "TMSTransportationTemplateEntity";
            KeyPrefix = "commonDataModel.tmstransportationtemplateentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationTemplateEntity";

            AddGroup("TMSTransportationTemplateEntity Details", group =>
            {
                ShipperShippingCarrierId = group.Add(new VocabularyKey(nameof(ShipperShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipperShippingCarrierGroupId = group.Add(new VocabularyKey(nameof(ShipperShippingCarrierGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipperTransportationRoutePlanId = group.Add(new VocabularyKey(nameof(ShipperTransportationRoutePlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRateShippingCarrierId = group.Add(new VocabularyKey(nameof(CustomerRateShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRateShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(CustomerRateShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCustomerRateManual = group.Add(new VocabularyKey(nameof(IsCustomerRateManual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRateTransportationRoutePlanId = group.Add(new VocabularyKey(nameof(CustomerRateTransportationRoutePlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadTemplateId = group.Add(new VocabularyKey(nameof(LoadTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateDescription = group.Add(new VocabularyKey(nameof(TemplateDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipperShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShipperShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ShipperShippingCarrierId { get; private set; }
        public VocabularyKey ShipperShippingCarrierGroupId { get; private set; }
        public VocabularyKey ShipperTransportationRoutePlanId { get; private set; }
        public VocabularyKey CustomerRateShippingCarrierId { get; private set; }
        public VocabularyKey CustomerRateShippingCarrierServiceId { get; private set; }
        public VocabularyKey IsCustomerRateManual { get; private set; }
        public VocabularyKey CustomerRateTransportationRoutePlanId { get; private set; }
        public VocabularyKey LoadTemplateId { get; private set; }
        public VocabularyKey TemplateDescription { get; private set; }
        public VocabularyKey ShipperShippingCarrierServiceId { get; private set; }
        public VocabularyKey TemplateId { get; private set; }


    }
}