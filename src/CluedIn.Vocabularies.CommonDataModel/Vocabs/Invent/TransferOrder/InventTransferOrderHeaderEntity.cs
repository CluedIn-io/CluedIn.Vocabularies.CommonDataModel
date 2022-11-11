using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventTransferOrderHeaderEntityVocabulary : SimpleVocabulary
    {
        public InventTransferOrderHeaderEntityVocabulary()
        {
            VocabularyName = "InventTransferOrderHeaderEntity";
            KeyPrefix = "commonDataModel.inventtransferorderheaderentity";
            KeySeparator = ".";
            Grouping = "/InventTransferOrderHeaderEntity";

            AddGroup("InventTransferOrderHeaderEntity Details", group =>
            {
                ATPDelayedDemandOffsetDays = group.Add(new VocabularyKey(nameof(ATPDelayedDemandOffsetDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ATPDelayedSupplyOffsetDays = group.Add(new VocabularyKey(nameof(ATPDelayedSupplyOffsetDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ATPBackwardDemandTimeFenceDays = group.Add(new VocabularyKey(nameof(ATPBackwardDemandTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ATPBackwardSupplyTimeFenceDays = group.Add(new VocabularyKey(nameof(ATPBackwardSupplyTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsATPIncludingPlannedOrders = group.Add(new VocabularyKey(nameof(IsATPIncludingPlannedOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ATPTimeFenceDays = group.Add(new VocabularyKey(nameof(ATPTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreLinesAutomaticallyReservedByDefault = group.Add(new VocabularyKey(nameof(AreLinesAutomaticallyReservedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferOrderPromisingMethod = group.Add(new VocabularyKey(nameof(TransferOrderPromisingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingFreightCompany = group.Add(new VocabularyKey(nameof(ShippingFreightCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingFreightZone = group.Add(new VocabularyKey(nameof(ShippingFreightZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressName = group.Add(new VocabularyKey(nameof(ShippingAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingPostalAddressRecId = group.Add(new VocabularyKey(nameof(ShippingPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatSpecialMovementCode = group.Add(new VocabularyKey(nameof(IntrastatSpecialMovementCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingWarehouseId = group.Add(new VocabularyKey(nameof(ShippingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingWarehouseId = group.Add(new VocabularyKey(nameof(ReceivingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransitWarehouseId = group.Add(new VocabularyKey(nameof(TransitWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverrideFEFODateControl = group.Add(new VocabularyKey(nameof(OverrideFEFODateControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatPortId = group.Add(new VocabularyKey(nameof(IntrastatPortId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedReceiptDate = group.Add(new VocabularyKey(nameof(RequestedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedShippingDate = group.Add(new VocabularyKey(nameof(RequestedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatStatisticsProcedureCode = group.Add(new VocabularyKey(nameof(IntrastatStatisticsProcedureCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressName = group.Add(new VocabularyKey(nameof(ReceivingAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingPostalAddressRecId = group.Add(new VocabularyKey(nameof(ReceivingPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransactionCode = group.Add(new VocabularyKey(nameof(IntrastatTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferOrderNumber = group.Add(new VocabularyKey(nameof(TransferOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferOrderStatus = group.Add(new VocabularyKey(nameof(TransferOrderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransportModeCode = group.Add(new VocabularyKey(nameof(IntrastatTransportModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationDocumentLineId = group.Add(new VocabularyKey(nameof(TransportationDocumentLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingContactPersonnelNumber = group.Add(new VocabularyKey(nameof(ShippingContactPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingContactPersonnelNumber = group.Add(new VocabularyKey(nameof(ReceivingContactPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedShippingAddress = group.Add(new VocabularyKey(nameof(FormattedShippingAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingBuildingCompliment = group.Add(new VocabularyKey(nameof(ShippingBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressCity = group.Add(new VocabularyKey(nameof(ShippingAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressCityInKana = group.Add(new VocabularyKey(nameof(ShippingAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressCountryRegionId = group.Add(new VocabularyKey(nameof(ShippingAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(ShippingAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressCountyId = group.Add(new VocabularyKey(nameof(ShippingAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressDescription = group.Add(new VocabularyKey(nameof(ShippingAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressDistrictName = group.Add(new VocabularyKey(nameof(ShippingAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressDunsNumber = group.Add(new VocabularyKey(nameof(ShippingAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsShippingAddressPrivate = group.Add(new VocabularyKey(nameof(IsShippingAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressLatitude = group.Add(new VocabularyKey(nameof(ShippingAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressLocationId = group.Add(new VocabularyKey(nameof(ShippingAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressLongitude = group.Add(new VocabularyKey(nameof(ShippingAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressPostBox = group.Add(new VocabularyKey(nameof(ShippingAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressStateId = group.Add(new VocabularyKey(nameof(ShippingAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressStreet = group.Add(new VocabularyKey(nameof(ShippingAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressStreetInKana = group.Add(new VocabularyKey(nameof(ShippingAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressStreetNumber = group.Add(new VocabularyKey(nameof(ShippingAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressTimeZone = group.Add(new VocabularyKey(nameof(ShippingAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressValidFrom = group.Add(new VocabularyKey(nameof(ShippingAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressValidTo = group.Add(new VocabularyKey(nameof(ShippingAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingAddressZipCode = group.Add(new VocabularyKey(nameof(ShippingAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedReceivingAddress = group.Add(new VocabularyKey(nameof(FormattedReceivingAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingBuildingCompliment = group.Add(new VocabularyKey(nameof(ReceivingBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressCity = group.Add(new VocabularyKey(nameof(ReceivingAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressCityInKana = group.Add(new VocabularyKey(nameof(ReceivingAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressCountryRegionId = group.Add(new VocabularyKey(nameof(ReceivingAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(ReceivingAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressCountyId = group.Add(new VocabularyKey(nameof(ReceivingAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressDescription = group.Add(new VocabularyKey(nameof(ReceivingAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressDistrictName = group.Add(new VocabularyKey(nameof(ReceivingAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressDunsNumber = group.Add(new VocabularyKey(nameof(ReceivingAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReceivingAddressPrivate = group.Add(new VocabularyKey(nameof(IsReceivingAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressLatitude = group.Add(new VocabularyKey(nameof(ReceivingAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressLocationId = group.Add(new VocabularyKey(nameof(ReceivingAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressLongitude = group.Add(new VocabularyKey(nameof(ReceivingAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressPostBox = group.Add(new VocabularyKey(nameof(ReceivingAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressStateId = group.Add(new VocabularyKey(nameof(ReceivingAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressStreet = group.Add(new VocabularyKey(nameof(ReceivingAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressStreetInKana = group.Add(new VocabularyKey(nameof(ReceivingAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressStreetNumber = group.Add(new VocabularyKey(nameof(ReceivingAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressTimeZone = group.Add(new VocabularyKey(nameof(ReceivingAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressValidFrom = group.Add(new VocabularyKey(nameof(ReceivingAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressValidTo = group.Add(new VocabularyKey(nameof(ReceivingAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingAddressZipCode = group.Add(new VocabularyKey(nameof(ReceivingAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceGroupId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationModeId = group.Add(new VocabularyKey(nameof(TransportationModeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ATPDelayedDemandOffsetDays { get; private set; }
        public VocabularyKey ATPDelayedSupplyOffsetDays { get; private set; }
        public VocabularyKey ATPBackwardDemandTimeFenceDays { get; private set; }
        public VocabularyKey ATPBackwardSupplyTimeFenceDays { get; private set; }
        public VocabularyKey IsATPIncludingPlannedOrders { get; private set; }
        public VocabularyKey ATPTimeFenceDays { get; private set; }
        public VocabularyKey AreLinesAutomaticallyReservedByDefault { get; private set; }
        public VocabularyKey TransferOrderPromisingMethod { get; private set; }
        public VocabularyKey DeliveryModeCode { get; private set; }
        public VocabularyKey DeliveryTermsCode { get; private set; }
        public VocabularyKey ShippingFreightCompany { get; private set; }
        public VocabularyKey ShippingFreightZone { get; private set; }
        public VocabularyKey ShippingAddressName { get; private set; }
        public VocabularyKey ShippingPostalAddressRecId { get; private set; }
        public VocabularyKey IntrastatSpecialMovementCode { get; private set; }
        public VocabularyKey ShippingWarehouseId { get; private set; }
        public VocabularyKey ReceivingWarehouseId { get; private set; }
        public VocabularyKey TransitWarehouseId { get; private set; }
        public VocabularyKey OverrideFEFODateControl { get; private set; }
        public VocabularyKey IntrastatPortId { get; private set; }
        public VocabularyKey RequestedReceiptDate { get; private set; }
        public VocabularyKey RequestedShippingDate { get; private set; }
        public VocabularyKey IntrastatStatisticsProcedureCode { get; private set; }
        public VocabularyKey ReceivingAddressName { get; private set; }
        public VocabularyKey ReceivingPostalAddressRecId { get; private set; }
        public VocabularyKey IntrastatTransactionCode { get; private set; }
        public VocabularyKey TransferOrderNumber { get; private set; }
        public VocabularyKey TransferOrderStatus { get; private set; }
        public VocabularyKey IntrastatTransportModeCode { get; private set; }
        public VocabularyKey TransportationDocumentLineId { get; private set; }
        public VocabularyKey ShippingContactPersonnelNumber { get; private set; }
        public VocabularyKey ReceivingContactPersonnelNumber { get; private set; }
        public VocabularyKey FormattedShippingAddress { get; private set; }
        public VocabularyKey ShippingBuildingCompliment { get; private set; }
        public VocabularyKey ShippingAddressCity { get; private set; }
        public VocabularyKey ShippingAddressCityInKana { get; private set; }
        public VocabularyKey ShippingAddressCountryRegionId { get; private set; }
        public VocabularyKey ShippingAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey ShippingAddressCountyId { get; private set; }
        public VocabularyKey ShippingAddressDescription { get; private set; }
        public VocabularyKey ShippingAddressDistrictName { get; private set; }
        public VocabularyKey ShippingAddressDunsNumber { get; private set; }
        public VocabularyKey IsShippingAddressPrivate { get; private set; }
        public VocabularyKey ShippingAddressLatitude { get; private set; }
        public VocabularyKey ShippingAddressLocationId { get; private set; }
        public VocabularyKey ShippingAddressLongitude { get; private set; }
        public VocabularyKey ShippingAddressPostBox { get; private set; }
        public VocabularyKey ShippingAddressStateId { get; private set; }
        public VocabularyKey ShippingAddressStreet { get; private set; }
        public VocabularyKey ShippingAddressStreetInKana { get; private set; }
        public VocabularyKey ShippingAddressStreetNumber { get; private set; }
        public VocabularyKey ShippingAddressTimeZone { get; private set; }
        public VocabularyKey ShippingAddressValidFrom { get; private set; }
        public VocabularyKey ShippingAddressValidTo { get; private set; }
        public VocabularyKey ShippingAddressZipCode { get; private set; }
        public VocabularyKey FormattedReceivingAddress { get; private set; }
        public VocabularyKey ReceivingBuildingCompliment { get; private set; }
        public VocabularyKey ReceivingAddressCity { get; private set; }
        public VocabularyKey ReceivingAddressCityInKana { get; private set; }
        public VocabularyKey ReceivingAddressCountryRegionId { get; private set; }
        public VocabularyKey ReceivingAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey ReceivingAddressCountyId { get; private set; }
        public VocabularyKey ReceivingAddressDescription { get; private set; }
        public VocabularyKey ReceivingAddressDistrictName { get; private set; }
        public VocabularyKey ReceivingAddressDunsNumber { get; private set; }
        public VocabularyKey IsReceivingAddressPrivate { get; private set; }
        public VocabularyKey ReceivingAddressLatitude { get; private set; }
        public VocabularyKey ReceivingAddressLocationId { get; private set; }
        public VocabularyKey ReceivingAddressLongitude { get; private set; }
        public VocabularyKey ReceivingAddressPostBox { get; private set; }
        public VocabularyKey ReceivingAddressStateId { get; private set; }
        public VocabularyKey ReceivingAddressStreet { get; private set; }
        public VocabularyKey ReceivingAddressStreetInKana { get; private set; }
        public VocabularyKey ReceivingAddressStreetNumber { get; private set; }
        public VocabularyKey ReceivingAddressTimeZone { get; private set; }
        public VocabularyKey ReceivingAddressValidFrom { get; private set; }
        public VocabularyKey ReceivingAddressValidTo { get; private set; }
        public VocabularyKey ReceivingAddressZipCode { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ShippingCarrierServiceGroupId { get; private set; }
        public VocabularyKey ShippingCarrierServiceId { get; private set; }
        public VocabularyKey TransportationModeId { get; private set; }


    }
}