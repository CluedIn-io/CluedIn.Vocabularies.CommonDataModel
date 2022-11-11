using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSFreightInvoiceLineV2EntityVocabulary : SimpleVocabulary
    {
        public TMSFreightInvoiceLineV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSFreightInvoiceLineV2Entity";
            KeyPrefix = "commonDataModel.tmsfreightinvoicelinev2entity";
            KeySeparator = ".";
            Grouping = "/TMSFreightInvoiceLineV2Entity";

            AddGroup("Common Data Model TMSFreightInvoiceLineV2Entity Details", group =>
            {
                DestinationCountryRegionId = group.Add(new VocabularyKey(nameof(DestinationCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationBillingGroupId = group.Add(new VocabularyKey(nameof(TransportationBillingGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillOfLadingId = group.Add(new VocabularyKey(nameof(BillOfLadingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BookingNumber = group.Add(new VocabularyKey(nameof(BookingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CosigneeName = group.Add(new VocabularyKey(nameof(CosigneeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DestinationCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastCycleCountingDateTime = group.Add(new VocabularyKey(nameof(LastCycleCountingDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DescriptionLine2 = group.Add(new VocabularyKey(nameof(DescriptionLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DescriptionLine1 = group.Add(new VocabularyKey(nameof(DescriptionLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationDistance = group.Add(new VocabularyKey(nameof(TransportationDistance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalCode = group.Add(new VocabularyKey(nameof(ExternalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightBillTypeId = group.Add(new VocabularyKey(nameof(FreightBillTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLineHeaderCharge = group.Add(new VocabularyKey(nameof(IsLineHeaderCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventorySiteId = group.Add(new VocabularyKey(nameof(InventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineStatus = group.Add(new VocabularyKey(nameof(LineStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadId = group.Add(new VocabularyKey(nameof(LoadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetAmount = group.Add(new VocabularyKey(nameof(NetAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProNumberCode = group.Add(new VocabularyKey(nameof(ProNumberCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightQuantity = group.Add(new VocabularyKey(nameof(FreightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TMSFreightInvoiceRecId = group.Add(new VocabularyKey(nameof(TMSFreightInvoiceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelatedAccountNumber = group.Add(new VocabularyKey(nameof(RelatedAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelatedOrderNumber = group.Add(new VocabularyKey(nameof(RelatedOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRouteCode = group.Add(new VocabularyKey(nameof(TransportationRouteCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrackingNumber = group.Add(new VocabularyKey(nameof(TrackingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipmentId = group.Add(new VocabularyKey(nameof(ShipmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightHeldUntilDateTime = group.Add(new VocabularyKey(nameof(FreightHeldUntilDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrailerNumber = group.Add(new VocabularyKey(nameof(TrailerNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPrice = group.Add(new VocabularyKey(nameof(UnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightWeightUnitId = group.Add(new VocabularyKey(nameof(FreightWeightUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierVendorAccountNumber = group.Add(new VocabularyKey(nameof(ShippingCarrierVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceVendorAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VesselName = group.Add(new VocabularyKey(nameof(VesselName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoyageNumber = group.Add(new VocabularyKey(nameof(VoyageNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightWeight = group.Add(new VocabularyKey(nameof(FreightWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Direction = group.Add(new VocabularyKey(nameof(Direction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalInvoiceNumber = group.Add(new VocabularyKey(nameof(InternalInvoiceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DestinationCountryRegionId { get; private set; }
        public VocabularyKey TransportationBillingGroupId { get; private set; }
        public VocabularyKey BillOfLadingId { get; private set; }
        public VocabularyKey BookingNumber { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ShippingCarrierServiceId { get; private set; }
        public VocabularyKey CosigneeName { get; private set; }
        public VocabularyKey DestinationCountryRegionISOCode { get; private set; }
        public VocabularyKey LastCycleCountingDateTime { get; private set; }
        public VocabularyKey DescriptionLine2 { get; private set; }
        public VocabularyKey DescriptionLine1 { get; private set; }
        public VocabularyKey TransportationDistance { get; private set; }
        public VocabularyKey ExternalCode { get; private set; }
        public VocabularyKey FreightBillTypeId { get; private set; }
        public VocabularyKey IsLineHeaderCharge { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey InventorySiteId { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey LineStatus { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey LoadId { get; private set; }
        public VocabularyKey DeliveryModeCode { get; private set; }
        public VocabularyKey NetAmount { get; private set; }
        public VocabularyKey ProNumberCode { get; private set; }
        public VocabularyKey FreightQuantity { get; private set; }
        public VocabularyKey TMSFreightInvoiceRecId { get; private set; }
        public VocabularyKey RelatedAccountNumber { get; private set; }
        public VocabularyKey RelatedOrderNumber { get; private set; }
        public VocabularyKey TransportationRouteCode { get; private set; }
        public VocabularyKey TrackingNumber { get; private set; }
        public VocabularyKey ShipmentId { get; private set; }
        public VocabularyKey FreightHeldUntilDateTime { get; private set; }
        public VocabularyKey TrailerNumber { get; private set; }
        public VocabularyKey UnitPrice { get; private set; }
        public VocabularyKey FreightWeightUnitId { get; private set; }
        public VocabularyKey ShippingCarrierVendorAccountNumber { get; private set; }
        public VocabularyKey InvoiceVendorAccountNumber { get; private set; }
        public VocabularyKey VesselName { get; private set; }
        public VocabularyKey VoyageNumber { get; private set; }
        public VocabularyKey FreightWeight { get; private set; }
        public VocabularyKey Direction { get; private set; }
        public VocabularyKey InternalInvoiceNumber { get; private set; }


    }
}