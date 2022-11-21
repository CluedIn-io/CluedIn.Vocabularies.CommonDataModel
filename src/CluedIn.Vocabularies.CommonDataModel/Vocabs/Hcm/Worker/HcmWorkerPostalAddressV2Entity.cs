using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmWorkerPostalAddressV2EntityVocabulary : SimpleVocabulary
    {
        public HcmWorkerPostalAddressV2EntityVocabulary()
        {
            VocabularyName = "Hcm Worker Postal Address V2 Entity";
            KeyPrefix = "commonDataModel.hcmworkerpostaladdressv2entity";
            KeySeparator = ".";
            Grouping = "/HcmWorkerPostalAddressV2Entity";

            AddGroup("HcmWorkerPostalAddressV2Entity Details", group =>
            {
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedAddress = group.Add(new VocabularyKey(nameof(FormattedAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttentionToAddressLine = group.Add(new VocabularyKey(nameof(AttentionToAddressLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuildingCompliment = group.Add(new VocabularyKey(nameof(BuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressApartment = group.Add(new VocabularyKey(nameof(AddressApartment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBuilding = group.Add(new VocabularyKey(nameof(AddressBuilding), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCityInKana = group.Add(new VocabularyKey(nameof(AddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(AddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountyId = group.Add(new VocabularyKey(nameof(AddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationId = group.Add(new VocabularyKey(nameof(AddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressPostBox = group.Add(new VocabularyKey(nameof(AddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreetInKana = group.Add(new VocabularyKey(nameof(AddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreetNumber = group.Add(new VocabularyKey(nameof(AddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressTimeZone = group.Add(new VocabularyKey(nameof(AddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationRoles = group.Add(new VocabularyKey(nameof(AddressLocationRoles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DunsNumber = group.Add(new VocabularyKey(nameof(DunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLocationOwner = group.Add(new VocabularyKey(nameof(IsLocationOwner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPostalAddress = group.Add(new VocabularyKey(nameof(IsPostalAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimary = group.Add(new VocabularyKey(nameof(IsPrimary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimaryTaxRegistration = group.Add(new VocabularyKey(nameof(IsPrimaryTaxRegistration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrivate = group.Add(new VocabularyKey(nameof(IsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrivatePostalAddress = group.Add(new VocabularyKey(nameof(IsPrivatePostalAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRoleBusiness = group.Add(new VocabularyKey(nameof(IsRoleBusiness), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRoleDelivery = group.Add(new VocabularyKey(nameof(IsRoleDelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRoleHome = group.Add(new VocabularyKey(nameof(IsRoleHome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRoleInvoice = group.Add(new VocabularyKey(nameof(IsRoleInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Effective = group.Add(new VocabularyKey(nameof(Effective), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Expiration = group.Add(new VocabularyKey(nameof(Expiration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey FormattedAddress { get; private set; }
        public VocabularyKey AttentionToAddressLine { get; private set; }
        public VocabularyKey BuildingCompliment { get; private set; }
        public VocabularyKey AddressApartment { get; private set; }
        public VocabularyKey AddressBuilding { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressCityInKana { get; private set; }
        public VocabularyKey AddressCountryRegionId { get; private set; }
        public VocabularyKey AddressCountryRegionISOCode { get; private set; }
        public VocabularyKey AddressCountyId { get; private set; }
        public VocabularyKey AddressDescription { get; private set; }
        public VocabularyKey AddressDistrictName { get; private set; }
        public VocabularyKey AddressLatitude { get; private set; }
        public VocabularyKey AddressLocationId { get; private set; }
        public VocabularyKey AddressLongitude { get; private set; }
        public VocabularyKey AddressPostBox { get; private set; }
        public VocabularyKey AddressState { get; private set; }
        public VocabularyKey AddressStreet { get; private set; }
        public VocabularyKey AddressStreetInKana { get; private set; }
        public VocabularyKey AddressStreetNumber { get; private set; }
        public VocabularyKey AddressTimeZone { get; private set; }
        public VocabularyKey AddressZipCode { get; private set; }
        public VocabularyKey AddressLocationRoles { get; private set; }
        public VocabularyKey DunsNumber { get; private set; }
        public VocabularyKey IsLocationOwner { get; private set; }
        public VocabularyKey IsPostalAddress { get; private set; }
        public VocabularyKey IsPrimary { get; private set; }
        public VocabularyKey IsPrimaryTaxRegistration { get; private set; }
        public VocabularyKey IsPrivate { get; private set; }
        public VocabularyKey IsPrivatePostalAddress { get; private set; }
        public VocabularyKey IsRoleBusiness { get; private set; }
        public VocabularyKey IsRoleDelivery { get; private set; }
        public VocabularyKey IsRoleHome { get; private set; }
        public VocabularyKey IsRoleInvoice { get; private set; }
        public VocabularyKey Effective { get; private set; }
        public VocabularyKey Expiration { get; private set; }
    }
}