using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSShippingCarrierServiceEntityVocabulary : SimpleVocabulary
    {
        public TMSShippingCarrierServiceEntityVocabulary()
        {
            VocabularyName = "TMSShippingCarrierServiceEntity";
            KeyPrefix = "commonDataModel.tmsshippingcarrierserviceentity";
            KeySeparator = ".";
            Grouping = "/TMSShippingCarrierServiceEntity";

            AddGroup("TMSShippingCarrierServiceEntity Details", group =>
            {
                DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalLoadTemplateId = group.Add(new VocabularyKey(nameof(PhysicalLoadTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ExternalShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceId = group.Add(new VocabularyKey(nameof(ServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceName = group.Add(new VocabularyKey(nameof(ServiceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationBillingGroupId = group.Add(new VocabularyKey(nameof(TransportationBillingGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationMethodId = group.Add(new VocabularyKey(nameof(TransportationMethodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadVolumeFactor = group.Add(new VocabularyKey(nameof(LoadVolumeFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DeliveryModeCode { get; private set; }
        public VocabularyKey PhysicalLoadTemplateId { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ExternalShippingCarrierServiceId { get; private set; }
        public VocabularyKey ServiceId { get; private set; }
        public VocabularyKey ServiceName { get; private set; }
        public VocabularyKey TransportationBillingGroupId { get; private set; }
        public VocabularyKey TransportationMethodId { get; private set; }
        public VocabularyKey LoadVolumeFactor { get; private set; }


    }
}