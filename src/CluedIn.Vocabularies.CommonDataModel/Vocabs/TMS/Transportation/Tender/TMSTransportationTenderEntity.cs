using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationTenderEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationTenderEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationTenderEntity";
            KeyPrefix = "commonDataModel.tmstransportationtenderentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationTenderEntity";

            AddGroup("Common Data Model TMSTransportationTenderEntity Details", group =>
            {
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierVendorAccountNumber = group.Add(new VocabularyKey(nameof(ShippingCarrierVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedPickupDateTime = group.Add(new VocabularyKey(nameof(ConfirmedPickupDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedRate = group.Add(new VocabularyKey(nameof(ConfirmedRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationEquipmentCode = group.Add(new VocabularyKey(nameof(TransportationEquipmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceRouteSegmentLoadId = group.Add(new VocabularyKey(nameof(ReferenceRouteSegmentLoadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationDistanceMiles = group.Add(new VocabularyKey(nameof(TransportationDistanceMiles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceId = group.Add(new VocabularyKey(nameof(ReferenceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedPickupDateTime = group.Add(new VocabularyKey(nameof(RequestedPickupDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedRate = group.Add(new VocabularyKey(nameof(RequestedRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceRouteSegmentSequenceNumber = group.Add(new VocabularyKey(nameof(ReferenceRouteSegmentSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceType = group.Add(new VocabularyKey(nameof(ReferenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TenderStatus = group.Add(new VocabularyKey(nameof(TenderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TenderId = group.Add(new VocabularyKey(nameof(TenderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculatedGrossWeight = group.Add(new VocabularyKey(nameof(CalculatedGrossWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                ReferenceLoadId = group.Add(new VocabularyKey(nameof(ReferenceLoadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceRouteId = group.Add(new VocabularyKey(nameof(ReferenceRouteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey ShippingCarrierServiceId { get; private set; }
        public VocabularyKey ShippingCarrierVendorAccountNumber { get; private set; }
        public VocabularyKey ConfirmedPickupDateTime { get; private set; }
        public VocabularyKey ConfirmedRate { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey TransportationEquipmentCode { get; private set; }
        public VocabularyKey ReferenceRouteSegmentLoadId { get; private set; }
        public VocabularyKey TransportationDistanceMiles { get; private set; }
        public VocabularyKey ReferenceId { get; private set; }
        public VocabularyKey RequestedPickupDateTime { get; private set; }
        public VocabularyKey RequestedRate { get; private set; }
        public VocabularyKey ReferenceRouteSegmentSequenceNumber { get; private set; }
        public VocabularyKey ReferenceType { get; private set; }
        public VocabularyKey TenderStatus { get; private set; }
        public VocabularyKey TenderId { get; private set; }
        public VocabularyKey CalculatedGrossWeight { get; private set; }
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
        public VocabularyKey ReferenceLoadId { get; private set; }
        public VocabularyKey ReferenceRouteId { get; private set; }


    }
}