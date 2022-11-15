using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSInboundShipmentHeaderEntityVocabulary : SimpleVocabulary
    {
        public WHSInboundShipmentHeaderEntityVocabulary()
        {
            VocabularyName = "WHS Inbound Shipment Header Entity";
            KeyPrefix = "commonDataModel.whsinboundshipmentheaderentity";
            KeySeparator = ".";
            Grouping = "/WHSInboundShipmentHeaderEntity";

            AddGroup("WHSInboundShipmentHeaderEntity Details", group =>
            {
                DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipmentId = group.Add(new VocabularyKey(nameof(ShipmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorShipmentId = group.Add(new VocabularyKey(nameof(VendorShipmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAddressCountryRegionId = group.Add(new VocabularyKey(nameof(VendorAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAddressStreet = group.Add(new VocabularyKey(nameof(VendorAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAddressStreetInKana = group.Add(new VocabularyKey(nameof(VendorAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAddressStateId = group.Add(new VocabularyKey(nameof(VendorAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAddressCountyId = group.Add(new VocabularyKey(nameof(VendorAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAddressCity = group.Add(new VocabularyKey(nameof(VendorAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAddressCityInKana = group.Add(new VocabularyKey(nameof(VendorAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAddressZipCode = group.Add(new VocabularyKey(nameof(VendorAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InboundLoadId = group.Add(new VocabularyKey(nameof(InboundLoadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DeliveryTermsCode { get; private set; }
        public VocabularyKey ShipmentId { get; private set; }
        public VocabularyKey VendorShipmentId { get; private set; }
        public VocabularyKey VendorAddressCountryRegionId { get; private set; }
        public VocabularyKey VendorAddressStreet { get; private set; }
        public VocabularyKey VendorAddressStreetInKana { get; private set; }
        public VocabularyKey VendorAddressStateId { get; private set; }
        public VocabularyKey VendorAddressCountyId { get; private set; }
        public VocabularyKey VendorAddressCity { get; private set; }
        public VocabularyKey VendorAddressCityInKana { get; private set; }
        public VocabularyKey VendorAddressZipCode { get; private set; }
        public VocabularyKey InboundLoadId { get; private set; }
    }
}