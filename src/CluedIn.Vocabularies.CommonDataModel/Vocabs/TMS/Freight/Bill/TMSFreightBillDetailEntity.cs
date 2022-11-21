using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSFreightBillDetailEntityVocabulary : SimpleVocabulary
    {
        public TMSFreightBillDetailEntityVocabulary()
        {
            VocabularyName = "TMS Freight Bill Detail Entity";
            KeyPrefix = "commonDataModel.tmsfreightbilldetailentity";
            KeySeparator = ".";
            Grouping = "/TMSFreightBillDetailEntity";

            AddGroup("TMSFreightBillDetailEntity Details", group =>
            {
                AccessorialChargeMasterCode = group.Add(new VocabularyKey(nameof(AccessorialChargeMasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillOfLadingId = group.Add(new VocabularyKey(nameof(BillOfLadingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightBillId = group.Add(new VocabularyKey(nameof(FreightBillId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightBillDetailEntryNumber = group.Add(new VocabularyKey(nameof(FreightBillDetailEntryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightBillTypeId = group.Add(new VocabularyKey(nameof(FreightBillTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightBillOrderAmount = group.Add(new VocabularyKey(nameof(FreightBillOrderAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightBillOrderQuantity = group.Add(new VocabularyKey(nameof(FreightBillOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HoldingFreightEndDatetime = group.Add(new VocabularyKey(nameof(HoldingFreightEndDatetime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceLineType = group.Add(new VocabularyKey(nameof(InvoiceLineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceVendorAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastCycleCountDateTime = group.Add(new VocabularyKey(nameof(LastCycleCountDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadId = group.Add(new VocabularyKey(nameof(LoadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalWeight = group.Add(new VocabularyKey(nameof(PhysicalWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMovementDirectionRule = group.Add(new VocabularyKey(nameof(ProductMovementDirectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProNumberCode = group.Add(new VocabularyKey(nameof(ProNumberCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateNotes = group.Add(new VocabularyKey(nameof(RateNotes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateUnit = group.Add(new VocabularyKey(nameof(RateUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateUnitMethod = group.Add(new VocabularyKey(nameof(RateUnitMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconciliationStatus = group.Add(new VocabularyKey(nameof(ReconciliationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipmentId = group.Add(new VocabularyKey(nameof(ShipmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierVendorAccountNumber = group.Add(new VocabularyKey(nameof(ShippingCarrierVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StandardTransportationCommodityCode = group.Add(new VocabularyKey(nameof(StandardTransportationCommodityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalRate = group.Add(new VocabularyKey(nameof(TotalRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TractorNumber = group.Add(new VocabularyKey(nameof(TractorNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrailerNumber = group.Add(new VocabularyKey(nameof(TrailerNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationBillingGroupId = group.Add(new VocabularyKey(nameof(TransportationBillingGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationBookingNumber = group.Add(new VocabularyKey(nameof(TransportationBookingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationEquipmentCode = group.Add(new VocabularyKey(nameof(TransportationEquipmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationExternalCode = group.Add(new VocabularyKey(nameof(TransportationExternalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationHubId = group.Add(new VocabularyKey(nameof(TransportationHubId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationModeCode = group.Add(new VocabularyKey(nameof(TransportationModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRoutePlanId = group.Add(new VocabularyKey(nameof(TransportationRoutePlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VesselName = group.Add(new VocabularyKey(nameof(VesselName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoyageNum = group.Add(new VocabularyKey(nameof(VoyageNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffPostalAddressRecId = group.Add(new VocabularyKey(nameof(DropOffPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressLocationId = group.Add(new VocabularyKey(nameof(DropOffAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedDropOffAddress = group.Add(new VocabularyKey(nameof(FormattedDropOffAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressZipCode = group.Add(new VocabularyKey(nameof(DropOffAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(DropOffAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressCity = group.Add(new VocabularyKey(nameof(DropOffAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressCityInKana = group.Add(new VocabularyKey(nameof(DropOffAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DropOffAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DropOffAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressCountyId = group.Add(new VocabularyKey(nameof(DropOffAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressDescription = group.Add(new VocabularyKey(nameof(DropOffAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressDistrictName = group.Add(new VocabularyKey(nameof(DropOffAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressDunsNumber = group.Add(new VocabularyKey(nameof(DropOffAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressLatitude = group.Add(new VocabularyKey(nameof(DropOffAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDropOffAddressPrivate = group.Add(new VocabularyKey(nameof(IsDropOffAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressLongitude = group.Add(new VocabularyKey(nameof(DropOffAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressPostBox = group.Add(new VocabularyKey(nameof(DropOffAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressStateId = group.Add(new VocabularyKey(nameof(DropOffAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressStreet = group.Add(new VocabularyKey(nameof(DropOffAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressStreetInKana = group.Add(new VocabularyKey(nameof(DropOffAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressStreetNumber = group.Add(new VocabularyKey(nameof(DropOffAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressValidFrom = group.Add(new VocabularyKey(nameof(DropOffAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressValidTo = group.Add(new VocabularyKey(nameof(DropOffAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropOffAddressTimeZone = group.Add(new VocabularyKey(nameof(DropOffAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupPostalAddressRecId = group.Add(new VocabularyKey(nameof(PickupPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressLocationId = group.Add(new VocabularyKey(nameof(PickupAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedPickupAddress = group.Add(new VocabularyKey(nameof(FormattedPickupAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressZipCode = group.Add(new VocabularyKey(nameof(PickupAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(PickupAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressCity = group.Add(new VocabularyKey(nameof(PickupAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressCityInKana = group.Add(new VocabularyKey(nameof(PickupAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressCountryRegionId = group.Add(new VocabularyKey(nameof(PickupAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(PickupAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressCountyId = group.Add(new VocabularyKey(nameof(PickupAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressDescription = group.Add(new VocabularyKey(nameof(PickupAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressDistrictName = group.Add(new VocabularyKey(nameof(PickupAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressDunsNumber = group.Add(new VocabularyKey(nameof(PickupAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressLatitude = group.Add(new VocabularyKey(nameof(PickupAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPickupAddressPrivate = group.Add(new VocabularyKey(nameof(IsPickupAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressLongitude = group.Add(new VocabularyKey(nameof(PickupAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressPostBox = group.Add(new VocabularyKey(nameof(PickupAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressStateId = group.Add(new VocabularyKey(nameof(PickupAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressStreet = group.Add(new VocabularyKey(nameof(PickupAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressStreetInKana = group.Add(new VocabularyKey(nameof(PickupAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressStreetNumber = group.Add(new VocabularyKey(nameof(PickupAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressValidFrom = group.Add(new VocabularyKey(nameof(PickupAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressValidTo = group.Add(new VocabularyKey(nameof(PickupAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickupAddressTimeZone = group.Add(new VocabularyKey(nameof(PickupAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadCustomerAccountNumber = group.Add(new VocabularyKey(nameof(LoadCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadVendorAccountNumber = group.Add(new VocabularyKey(nameof(LoadVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadSalesOrderNumber = group.Add(new VocabularyKey(nameof(LoadSalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadPurchaseOrderNumber = group.Add(new VocabularyKey(nameof(LoadPurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccessorialChargeMasterCode { get; private set; }
        public VocabularyKey BillOfLadingId { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey FreightBillId { get; private set; }
        public VocabularyKey FreightBillDetailEntryNumber { get; private set; }
        public VocabularyKey FreightBillTypeId { get; private set; }
        public VocabularyKey FreightBillOrderAmount { get; private set; }
        public VocabularyKey FreightBillOrderQuantity { get; private set; }
        public VocabularyKey HoldingFreightEndDatetime { get; private set; }
        public VocabularyKey InvoiceLineType { get; private set; }
        public VocabularyKey InvoiceVendorAccountNumber { get; private set; }
        public VocabularyKey LastCycleCountDateTime { get; private set; }
        public VocabularyKey LoadId { get; private set; }
        public VocabularyKey PhysicalWeight { get; private set; }
        public VocabularyKey ProductMovementDirectionRule { get; private set; }
        public VocabularyKey ProNumberCode { get; private set; }
        public VocabularyKey RateNotes { get; private set; }
        public VocabularyKey RateUnit { get; private set; }
        public VocabularyKey RateUnitMethod { get; private set; }
        public VocabularyKey ReconciliationStatus { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey ShipmentId { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ShippingCarrierServiceId { get; private set; }
        public VocabularyKey ShippingCarrierVendorAccountNumber { get; private set; }
        public VocabularyKey StandardTransportationCommodityCode { get; private set; }
        public VocabularyKey TotalRate { get; private set; }
        public VocabularyKey TractorNumber { get; private set; }
        public VocabularyKey TrailerNumber { get; private set; }
        public VocabularyKey TransportationBillingGroupId { get; private set; }
        public VocabularyKey TransportationBookingNumber { get; private set; }
        public VocabularyKey TransportationEquipmentCode { get; private set; }
        public VocabularyKey TransportationExternalCode { get; private set; }
        public VocabularyKey TransportationHubId { get; private set; }
        public VocabularyKey TransportationModeCode { get; private set; }
        public VocabularyKey TransportationRoutePlanId { get; private set; }
        public VocabularyKey VesselName { get; private set; }
        public VocabularyKey VoyageNum { get; private set; }
        public VocabularyKey DropOffPostalAddressRecId { get; private set; }
        public VocabularyKey DropOffAddressLocationId { get; private set; }
        public VocabularyKey FormattedDropOffAddress { get; private set; }
        public VocabularyKey DropOffAddressZipCode { get; private set; }
        public VocabularyKey DropOffAddressBuildingCompliment { get; private set; }
        public VocabularyKey DropOffAddressCity { get; private set; }
        public VocabularyKey DropOffAddressCityInKana { get; private set; }
        public VocabularyKey DropOffAddressCountryRegionId { get; private set; }
        public VocabularyKey DropOffAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey DropOffAddressCountyId { get; private set; }
        public VocabularyKey DropOffAddressDescription { get; private set; }
        public VocabularyKey DropOffAddressDistrictName { get; private set; }
        public VocabularyKey DropOffAddressDunsNumber { get; private set; }
        public VocabularyKey DropOffAddressLatitude { get; private set; }
        public VocabularyKey IsDropOffAddressPrivate { get; private set; }
        public VocabularyKey DropOffAddressLongitude { get; private set; }
        public VocabularyKey DropOffAddressPostBox { get; private set; }
        public VocabularyKey DropOffAddressStateId { get; private set; }
        public VocabularyKey DropOffAddressStreet { get; private set; }
        public VocabularyKey DropOffAddressStreetInKana { get; private set; }
        public VocabularyKey DropOffAddressStreetNumber { get; private set; }
        public VocabularyKey DropOffAddressValidFrom { get; private set; }
        public VocabularyKey DropOffAddressValidTo { get; private set; }
        public VocabularyKey DropOffAddressTimeZone { get; private set; }
        public VocabularyKey PickupPostalAddressRecId { get; private set; }
        public VocabularyKey PickupAddressLocationId { get; private set; }
        public VocabularyKey FormattedPickupAddress { get; private set; }
        public VocabularyKey PickupAddressZipCode { get; private set; }
        public VocabularyKey PickupAddressBuildingCompliment { get; private set; }
        public VocabularyKey PickupAddressCity { get; private set; }
        public VocabularyKey PickupAddressCityInKana { get; private set; }
        public VocabularyKey PickupAddressCountryRegionId { get; private set; }
        public VocabularyKey PickupAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey PickupAddressCountyId { get; private set; }
        public VocabularyKey PickupAddressDescription { get; private set; }
        public VocabularyKey PickupAddressDistrictName { get; private set; }
        public VocabularyKey PickupAddressDunsNumber { get; private set; }
        public VocabularyKey PickupAddressLatitude { get; private set; }
        public VocabularyKey IsPickupAddressPrivate { get; private set; }
        public VocabularyKey PickupAddressLongitude { get; private set; }
        public VocabularyKey PickupAddressPostBox { get; private set; }
        public VocabularyKey PickupAddressStateId { get; private set; }
        public VocabularyKey PickupAddressStreet { get; private set; }
        public VocabularyKey PickupAddressStreetInKana { get; private set; }
        public VocabularyKey PickupAddressStreetNumber { get; private set; }
        public VocabularyKey PickupAddressValidFrom { get; private set; }
        public VocabularyKey PickupAddressValidTo { get; private set; }
        public VocabularyKey PickupAddressTimeZone { get; private set; }
        public VocabularyKey LoadCustomerAccountNumber { get; private set; }
        public VocabularyKey LoadVendorAccountNumber { get; private set; }
        public VocabularyKey LoadSalesOrderNumber { get; private set; }
        public VocabularyKey LoadPurchaseOrderNumber { get; private set; }
    }
}