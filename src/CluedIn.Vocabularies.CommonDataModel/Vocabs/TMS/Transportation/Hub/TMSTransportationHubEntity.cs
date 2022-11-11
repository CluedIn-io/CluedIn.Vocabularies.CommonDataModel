using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationHubEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationHubEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationHubEntity";
            KeyPrefix = "commonDataModel.tmstransportationhubentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationHubEntity";

            AddGroup("Common Data Model TMSTransportationHubEntity Details", group =>
            {
                HubCompanyName = group.Add(new VocabularyKey(nameof(HubCompanyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HubContactName = group.Add(new VocabularyKey(nameof(HubContactName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HubValidFrom = group.Add(new VocabularyKey(nameof(HubValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HubValidTo = group.Add(new VocabularyKey(nameof(HubValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HubEmailAddress = group.Add(new VocabularyKey(nameof(HubEmailAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HubFaxNumber = group.Add(new VocabularyKey(nameof(HubFaxNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HubId = group.Add(new VocabularyKey(nameof(HubId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationHubTypeId = group.Add(new VocabularyKey(nameof(TransportationHubTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocation = group.Add(new VocabularyKey(nameof(AddressLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HubName = group.Add(new VocabularyKey(nameof(HubName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HubPhoneNumber = group.Add(new VocabularyKey(nameof(HubPhoneNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRateMasterCode = group.Add(new VocabularyKey(nameof(TransportationRateMasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderVendorAccountNumber = group.Add(new VocabularyKey(nameof(OrderVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceVendorAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationId = group.Add(new VocabularyKey(nameof(AddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBuildingCompliment = group.Add(new VocabularyKey(nameof(AddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreetInKana = group.Add(new VocabularyKey(nameof(AddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreetNumber = group.Add(new VocabularyKey(nameof(AddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressPostBox = group.Add(new VocabularyKey(nameof(AddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCityInKana = group.Add(new VocabularyKey(nameof(AddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountyId = group.Add(new VocabularyKey(nameof(AddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStateId = group.Add(new VocabularyKey(nameof(AddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(AddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressTimeZone = group.Add(new VocabularyKey(nameof(AddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey HubCompanyName { get; private set; }
        public VocabularyKey HubContactName { get; private set; }
        public VocabularyKey HubValidFrom { get; private set; }
        public VocabularyKey HubValidTo { get; private set; }
        public VocabularyKey HubEmailAddress { get; private set; }
        public VocabularyKey HubFaxNumber { get; private set; }
        public VocabularyKey HubId { get; private set; }
        public VocabularyKey TransportationHubTypeId { get; private set; }
        public VocabularyKey AddressLocation { get; private set; }
        public VocabularyKey HubName { get; private set; }
        public VocabularyKey HubPhoneNumber { get; private set; }
        public VocabularyKey TransportationRateMasterCode { get; private set; }
        public VocabularyKey OrderVendorAccountNumber { get; private set; }
        public VocabularyKey InvoiceVendorAccountNumber { get; private set; }
        public VocabularyKey AddressLocationId { get; private set; }
        public VocabularyKey AddressDescription { get; private set; }
        public VocabularyKey AddressBuildingCompliment { get; private set; }
        public VocabularyKey AddressStreet { get; private set; }
        public VocabularyKey AddressStreetInKana { get; private set; }
        public VocabularyKey AddressStreetNumber { get; private set; }
        public VocabularyKey AddressPostBox { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressCityInKana { get; private set; }
        public VocabularyKey AddressDistrictName { get; private set; }
        public VocabularyKey AddressCountyId { get; private set; }
        public VocabularyKey AddressStateId { get; private set; }
        public VocabularyKey AddressZipCode { get; private set; }
        public VocabularyKey AddressCountryRegionId { get; private set; }
        public VocabularyKey AddressCountryRegionISOCode { get; private set; }
        public VocabularyKey AddressLatitude { get; private set; }
        public VocabularyKey AddressLongitude { get; private set; }
        public VocabularyKey AddressValidFrom { get; private set; }
        public VocabularyKey AddressValidTo { get; private set; }
        public VocabularyKey AddressTimeZone { get; private set; }


    }
}