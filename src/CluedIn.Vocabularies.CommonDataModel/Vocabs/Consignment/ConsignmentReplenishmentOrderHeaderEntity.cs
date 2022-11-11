using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConsignmentReplenishmentOrderHeaderEntityVocabulary : SimpleVocabulary
    {
        public ConsignmentReplenishmentOrderHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model ConsignmentReplenishmentOrderHeaderEntity";
            KeyPrefix = "commonDataModel.consignmentreplenishmentorderheaderentity";
            KeySeparator = ".";
            Grouping = "/ConsignmentReplenishmentOrderHeaderEntity";

            AddGroup("Common Data Model ConsignmentReplenishmentOrderHeaderEntity Details", group =>
            {
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReceivingSiteId = group.Add(new VocabularyKey(nameof(DefaultReceivingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReceivingWarehouseId = group.Add(new VocabularyKey(nameof(DefaultReceivingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPostalAddressRecId = group.Add(new VocabularyKey(nameof(DeliveryPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsignmentVendorAccountNumber = group.Add(new VocabularyKey(nameof(ConsignmentVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsignmentReplenishmentOrderNumber = group.Add(new VocabularyKey(nameof(ConsignmentReplenishmentOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsignmentReplenishmentOrderStatus = group.Add(new VocabularyKey(nameof(ConsignmentReplenishmentOrderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmedDeliveryDate = group.Add(new VocabularyKey(nameof(ConfirmedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedDeliveryDate = group.Add(new VocabularyKey(nameof(RequestedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedDeliveryAddress = group.Add(new VocabularyKey(nameof(FormattedDeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDescription = group.Add(new VocabularyKey(nameof(DeliveryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountyId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDistrictName = group.Add(new VocabularyKey(nameof(DeliveryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressPrivate = group.Add(new VocabularyKey(nameof(IsDeliveryAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLatitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLongitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressPostBox = group.Add(new VocabularyKey(nameof(DeliveryAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStateId = group.Add(new VocabularyKey(nameof(DeliveryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressTimeZone = group.Add(new VocabularyKey(nameof(DeliveryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressValidFrom = group.Add(new VocabularyKey(nameof(DeliveryAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressValidTo = group.Add(new VocabularyKey(nameof(DeliveryAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCityInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDunsNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreet = group.Add(new VocabularyKey(nameof(DeliveryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsDeliveryAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey DefaultReceivingSiteId { get; private set; }
        public VocabularyKey DefaultReceivingWarehouseId { get; private set; }
        public VocabularyKey DeliveryAddressName { get; private set; }
        public VocabularyKey DeliveryPostalAddressRecId { get; private set; }
        public VocabularyKey ConsignmentVendorAccountNumber { get; private set; }
        public VocabularyKey ConsignmentReplenishmentOrderNumber { get; private set; }
        public VocabularyKey ConsignmentReplenishmentOrderStatus { get; private set; }
        public VocabularyKey ConfirmedDeliveryDate { get; private set; }
        public VocabularyKey RequestedDeliveryDate { get; private set; }
        public VocabularyKey FormattedDeliveryAddress { get; private set; }
        public VocabularyKey DeliveryAddressDescription { get; private set; }
        public VocabularyKey DeliveryAddressLocationId { get; private set; }
        public VocabularyKey DeliveryAddressBuildingCompliment { get; private set; }
        public VocabularyKey DeliveryAddressCity { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey DeliveryAddressCountyId { get; private set; }
        public VocabularyKey DeliveryAddressDistrictName { get; private set; }
        public VocabularyKey IsDeliveryAddressPrivate { get; private set; }
        public VocabularyKey DeliveryAddressLatitude { get; private set; }
        public VocabularyKey DeliveryAddressLongitude { get; private set; }
        public VocabularyKey DeliveryAddressPostBox { get; private set; }
        public VocabularyKey DeliveryAddressStateId { get; private set; }
        public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
        public VocabularyKey DeliveryAddressTimeZone { get; private set; }
        public VocabularyKey DeliveryAddressValidFrom { get; private set; }
        public VocabularyKey DeliveryAddressValidTo { get; private set; }
        public VocabularyKey DeliveryAddressZipCode { get; private set; }
        public VocabularyKey DeliveryAddressCityInKana { get; private set; }
        public VocabularyKey DeliveryAddressStreetInKana { get; private set; }
        public VocabularyKey DeliveryAddressDunsNumber { get; private set; }
        public VocabularyKey DeliveryAddressStreet { get; private set; }
        public VocabularyKey IsDeliveryAddressOrderSpecific { get; private set; }


    }
}