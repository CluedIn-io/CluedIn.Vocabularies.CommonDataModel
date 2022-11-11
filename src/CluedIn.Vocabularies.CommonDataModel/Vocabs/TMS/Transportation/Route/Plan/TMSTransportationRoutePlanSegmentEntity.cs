using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationRoutePlanSegmentEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationRoutePlanSegmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationRoutePlanSegmentEntity";
            KeyPrefix = "commonDataModel.tmstransportationrouteplansegmententity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationRoutePlanSegmentEntity";

            AddGroup("Common Data Model TMSTransportationRoutePlanSegmentEntity Details", group =>
            {
                OriginTransportationHubId = group.Add(new VocabularyKey(nameof(OriginTransportationHubId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceGroupId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAccountType = group.Add(new VocabularyKey(nameof(InvoiceAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationModeCode = group.Add(new VocabularyKey(nameof(TransportationModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName = group.Add(new VocabularyKey(nameof(SegmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayingPartyRole = group.Add(new VocabularyKey(nameof(PayingPartyRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRoutePlanId = group.Add(new VocabularyKey(nameof(TransportationRoutePlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationTransportationHubId = group.Add(new VocabularyKey(nameof(DestinationTransportationHubId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderVendorAccountNumber = group.Add(new VocabularyKey(nameof(OrderVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceVendorAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey OriginTransportationHubId { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ShippingCarrierServiceGroupId { get; private set; }
        public VocabularyKey ShippingCarrierServiceId { get; private set; }
        public VocabularyKey DeliveryTermsCode { get; private set; }
        public VocabularyKey InvoiceAccountType { get; private set; }
        public VocabularyKey TransportationModeCode { get; private set; }
        public VocabularyKey SegmentName { get; private set; }
        public VocabularyKey PayingPartyRole { get; private set; }
        public VocabularyKey TransportationRoutePlanId { get; private set; }
        public VocabularyKey DestinationTransportationHubId { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey OrderVendorAccountNumber { get; private set; }
        public VocabularyKey InvoiceVendorAccountNumber { get; private set; }


    }
}