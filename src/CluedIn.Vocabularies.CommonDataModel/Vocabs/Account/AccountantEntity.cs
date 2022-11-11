using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AccountantEntityVocabulary : SimpleVocabulary
    {
        public AccountantEntityVocabulary()
        {
            VocabularyName = "AccountantEntity";
            KeyPrefix = "commonDataModel.accountantentity";
            KeySeparator = ".";
            Grouping = "/AccountantEntity";

            AddGroup("Metadata", group =>
            {
                CNPJ = group.Add(new VocabularyKey(nameof(CNPJ), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CPF = group.Add(new VocabularyKey(nameof(CPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CRCCountryRegionId = group.Add(new VocabularyKey(nameof(CRCCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CRCExpirationDate = group.Add(new VocabularyKey(nameof(CRCExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CRC = group.Add(new VocabularyKey(nameof(CRC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CRCIssuerState = group.Add(new VocabularyKey(nameof(CRCIssuerState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountantName = group.Add(new VocabularyKey(nameof(AccountantName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountantLogisticsLocationPostalAddressIsPostalAddress = group.Add(new VocabularyKey(nameof(AccountantLogisticsLocationPostalAddressIsPostalAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountantLogisticsLocationPostalAddressIsPrimary = group.Add(new VocabularyKey(nameof(AccountantLogisticsLocationPostalAddressIsPrimary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountantLogisticsLocationPostalAddressRecId = group.Add(new VocabularyKey(nameof(AccountantLogisticsLocationPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountantLogisticsLocationElectronicAddressIsPostalAddress = group.Add(new VocabularyKey(nameof(AccountantLogisticsLocationElectronicAddressIsPostalAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountantLogisticsLocationElectronicAddressRecId = group.Add(new VocabularyKey(nameof(AccountantLogisticsLocationElectronicAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsLocationPostalAddressRecId = group.Add(new VocabularyKey(nameof(LogisticsLocationPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsLocationPostalAddressLocationId = group.Add(new VocabularyKey(nameof(LogisticsLocationPostalAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsLocationElectronicAddressRecId = group.Add(new VocabularyKey(nameof(LogisticsLocationElectronicAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsLocationElectronicAddressLocationId = group.Add(new VocabularyKey(nameof(LogisticsLocationElectronicAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsPostalAddressValidFrom = group.Add(new VocabularyKey(nameof(LogisticsPostalAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsPostalAddressValidTo = group.Add(new VocabularyKey(nameof(LogisticsPostalAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Address = group.Add(new VocabularyKey(nameof(Address), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBuildingCompliment = group.Add(new VocabularyKey(nameof(AddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCityRecId = group.Add(new VocabularyKey(nameof(AddressCityRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCounty = group.Add(new VocabularyKey(nameof(AddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDistrictId = group.Add(new VocabularyKey(nameof(AddressDistrictId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDistrict = group.Add(new VocabularyKey(nameof(AddressDistrict), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressIsPrivate = group.Add(new VocabularyKey(nameof(AddressIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocation = group.Add(new VocabularyKey(nameof(AddressLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreetNumber = group.Add(new VocabularyKey(nameof(AddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCodeRecId = group.Add(new VocabularyKey(nameof(AddressZipCodeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCityName = group.Add(new VocabularyKey(nameof(AddressCityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCodeName = group.Add(new VocabularyKey(nameof(AddressZipCodeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailCountryRegionCode = group.Add(new VocabularyKey(nameof(EmailCountryRegionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailDescription = group.Add(new VocabularyKey(nameof(EmailDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailIsInstantMessage = group.Add(new VocabularyKey(nameof(EmailIsInstantMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailIsPrimary = group.Add(new VocabularyKey(nameof(EmailIsPrimary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailIsPrivate = group.Add(new VocabularyKey(nameof(EmailIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailLocation = group.Add(new VocabularyKey(nameof(EmailLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailLocator = group.Add(new VocabularyKey(nameof(EmailLocator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailLocatorExtension = group.Add(new VocabularyKey(nameof(EmailLocatorExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailPrivateForParty = group.Add(new VocabularyKey(nameof(EmailPrivateForParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailType = group.Add(new VocabularyKey(nameof(EmailType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneCountryRegionCode = group.Add(new VocabularyKey(nameof(PhoneCountryRegionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneDescription = group.Add(new VocabularyKey(nameof(PhoneDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneIsInstantMessage = group.Add(new VocabularyKey(nameof(PhoneIsInstantMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneIsMobilePhone = group.Add(new VocabularyKey(nameof(PhoneIsMobilePhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneIsPrimary = group.Add(new VocabularyKey(nameof(PhoneIsPrimary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneIsPrivate = group.Add(new VocabularyKey(nameof(PhoneIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneLocation = group.Add(new VocabularyKey(nameof(PhoneLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneLocator = group.Add(new VocabularyKey(nameof(PhoneLocator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneLocatorExtension = group.Add(new VocabularyKey(nameof(PhoneLocatorExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhonePrivateForParty = group.Add(new VocabularyKey(nameof(PhonePrivateForParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneType = group.Add(new VocabularyKey(nameof(PhoneType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsAddressCityRecId = group.Add(new VocabularyKey(nameof(LogisticsAddressCityRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressRole = group.Add(new VocabularyKey(nameof(AddressRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressRoleLocationId = group.Add(new VocabularyKey(nameof(AddressRoleLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountantLogisticsLocationElectronicAddressLocation = group.Add(new VocabularyKey(nameof(AccountantLogisticsLocationElectronicAddressLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountantLogisticsLocationElectronicAddressIsPrimary = group.Add(new VocabularyKey(nameof(AccountantLogisticsLocationElectronicAddressIsPrimary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailRoleLocationId = group.Add(new VocabularyKey(nameof(EmailRoleLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailRole = group.Add(new VocabularyKey(nameof(EmailRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneRole = group.Add(new VocabularyKey(nameof(PhoneRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneRoleLocationId = group.Add(new VocabularyKey(nameof(PhoneRoleLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CNPJ { get; private set; }
        public VocabularyKey CPF { get; private set; }
        public VocabularyKey CRCCountryRegionId { get; private set; }
        public VocabularyKey CRCExpirationDate { get; private set; }
        public VocabularyKey CRC { get; private set; }
        public VocabularyKey CRCIssuerState { get; private set; }
        public VocabularyKey AccountantName { get; private set; }
        public VocabularyKey AccountantLogisticsLocationPostalAddressIsPostalAddress { get; private set; }
        public VocabularyKey AccountantLogisticsLocationPostalAddressIsPrimary { get; private set; }
        public VocabularyKey AccountantLogisticsLocationPostalAddressRecId { get; private set; }
        public VocabularyKey AccountantLogisticsLocationElectronicAddressIsPostalAddress { get; private set; }
        public VocabularyKey AccountantLogisticsLocationElectronicAddressRecId { get; private set; }
        public VocabularyKey LogisticsLocationPostalAddressRecId { get; private set; }
        public VocabularyKey LogisticsLocationPostalAddressLocationId { get; private set; }
        public VocabularyKey LogisticsLocationElectronicAddressRecId { get; private set; }
        public VocabularyKey LogisticsLocationElectronicAddressLocationId { get; private set; }
        public VocabularyKey LogisticsPostalAddressValidFrom { get; private set; }
        public VocabularyKey LogisticsPostalAddressValidTo { get; private set; }
        public VocabularyKey Address { get; private set; }
        public VocabularyKey AddressBuildingCompliment { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressCityRecId { get; private set; }
        public VocabularyKey AddressCountryRegionId { get; private set; }
        public VocabularyKey AddressCounty { get; private set; }
        public VocabularyKey AddressDistrictId { get; private set; }
        public VocabularyKey AddressDistrict { get; private set; }
        public VocabularyKey AddressIsPrivate { get; private set; }
        public VocabularyKey AddressLocation { get; private set; }
        public VocabularyKey AddressState { get; private set; }
        public VocabularyKey AddressStreet { get; private set; }
        public VocabularyKey AddressStreetNumber { get; private set; }
        public VocabularyKey AddressValidFrom { get; private set; }
        public VocabularyKey AddressValidTo { get; private set; }
        public VocabularyKey AddressZipCode { get; private set; }
        public VocabularyKey AddressZipCodeRecId { get; private set; }
        public VocabularyKey AddressCityName { get; private set; }
        public VocabularyKey AddressDistrictName { get; private set; }
        public VocabularyKey AddressZipCodeName { get; private set; }
        public VocabularyKey EmailCountryRegionCode { get; private set; }
        public VocabularyKey EmailDescription { get; private set; }
        public VocabularyKey EmailIsInstantMessage { get; private set; }
        public VocabularyKey EmailIsPrimary { get; private set; }
        public VocabularyKey EmailIsPrivate { get; private set; }
        public VocabularyKey EmailLocation { get; private set; }
        public VocabularyKey EmailLocator { get; private set; }
        public VocabularyKey EmailLocatorExtension { get; private set; }
        public VocabularyKey EmailPrivateForParty { get; private set; }
        public VocabularyKey EmailType { get; private set; }
        public VocabularyKey PhoneCountryRegionCode { get; private set; }
        public VocabularyKey PhoneDescription { get; private set; }
        public VocabularyKey PhoneIsInstantMessage { get; private set; }
        public VocabularyKey PhoneIsMobilePhone { get; private set; }
        public VocabularyKey PhoneIsPrimary { get; private set; }
        public VocabularyKey PhoneIsPrivate { get; private set; }
        public VocabularyKey PhoneLocation { get; private set; }
        public VocabularyKey PhoneLocator { get; private set; }
        public VocabularyKey PhoneLocatorExtension { get; private set; }
        public VocabularyKey PhonePrivateForParty { get; private set; }
        public VocabularyKey PhoneType { get; private set; }
        public VocabularyKey LogisticsAddressCityRecId { get; private set; }
        public VocabularyKey AddressDescription { get; private set; }
        public VocabularyKey AddressRole { get; private set; }
        public VocabularyKey AddressRoleLocationId { get; private set; }
        public VocabularyKey AccountantLogisticsLocationElectronicAddressLocation { get; private set; }
        public VocabularyKey AccountantLogisticsLocationElectronicAddressIsPrimary { get; private set; }
        public VocabularyKey EmailRoleLocationId { get; private set; }
        public VocabularyKey EmailRole { get; private set; }
        public VocabularyKey PhoneRole { get; private set; }
        public VocabularyKey PhoneRoleLocationId { get; private set; }
    }
}