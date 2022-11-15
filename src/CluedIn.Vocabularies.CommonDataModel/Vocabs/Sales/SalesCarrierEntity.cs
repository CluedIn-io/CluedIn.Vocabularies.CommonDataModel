using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesCarrierEntityVocabulary : SimpleVocabulary
    {
        public SalesCarrierEntityVocabulary()
        {
            VocabularyName = "Sales Carrier Entity";
            KeyPrefix = "commonDataModel.salescarrierentity";
            KeySeparator = ".";
            Grouping = "/SalesCarrierEntity";

            AddGroup("SalesCarrierEntity Details", group =>
            {
                CarrierName = group.Add(new VocabularyKey(nameof(CarrierName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CnpjOrCpf = group.Add(new VocabularyKey(nameof(CnpjOrCpf), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IE = group.Add(new VocabularyKey(nameof(IE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Vendor = group.Add(new VocabularyKey(nameof(Vendor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationId = group.Add(new VocabularyKey(nameof(AddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBuildingCompliment = group.Add(new VocabularyKey(nameof(AddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(AddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCityInKana = group.Add(new VocabularyKey(nameof(AddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountyId = group.Add(new VocabularyKey(nameof(AddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressPostBox = group.Add(new VocabularyKey(nameof(AddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStateId = group.Add(new VocabularyKey(nameof(AddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreetNumber = group.Add(new VocabularyKey(nameof(AddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreetInKana = group.Add(new VocabularyKey(nameof(AddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressTimezone = group.Add(new VocabularyKey(nameof(AddressTimezone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedAddress = group.Add(new VocabularyKey(nameof(FormattedAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CarrierName { get; private set; }
        public VocabularyKey CnpjOrCpf { get; private set; }
        public VocabularyKey IE { get; private set; }
        public VocabularyKey Vendor { get; private set; }
        public VocabularyKey AddressLocationId { get; private set; }
        public VocabularyKey AddressDescription { get; private set; }
        public VocabularyKey AddressBuildingCompliment { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressCountryRegionId { get; private set; }
        public VocabularyKey AddressCountryRegionISOCode { get; private set; }
        public VocabularyKey AddressCityInKana { get; private set; }
        public VocabularyKey AddressCountyId { get; private set; }
        public VocabularyKey AddressDistrictName { get; private set; }
        public VocabularyKey AddressLatitude { get; private set; }
        public VocabularyKey AddressLongitude { get; private set; }
        public VocabularyKey AddressPostBox { get; private set; }
        public VocabularyKey AddressStateId { get; private set; }
        public VocabularyKey AddressStreet { get; private set; }
        public VocabularyKey AddressStreetNumber { get; private set; }
        public VocabularyKey AddressStreetInKana { get; private set; }
        public VocabularyKey AddressTimezone { get; private set; }
        public VocabularyKey AddressValidFrom { get; private set; }
        public VocabularyKey AddressValidTo { get; private set; }
        public VocabularyKey AddressZipCode { get; private set; }
        public VocabularyKey FormattedAddress { get; private set; }
        public VocabularyKey Location { get; private set; }
    }
}