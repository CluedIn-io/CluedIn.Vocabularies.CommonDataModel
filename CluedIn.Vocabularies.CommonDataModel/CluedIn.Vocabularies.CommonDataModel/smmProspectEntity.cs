using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmProspectEntityVocabulary : SimpleVocabulary
    {
        public smmProspectEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmProspectEntity";
            KeyPrefix = "commonDataModel.smmprospectentity";
            KeySeparator = ".";
            Grouping = "/smmProspectEntity";

            AddGroup("Common Data Model smmProspectEntity Details", group =>
            {
                CompanyChainName = group.Add(new VocabularyKey(nameof(CompanyChainName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditLimit = group.Add(new VocabularyKey(nameof(CreditLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditRating = group.Add(new VocabularyKey(nameof(CreditRating), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerGroupId = group.Add(new VocabularyKey(nameof(CustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DestinationCode = group.Add(new VocabularyKey(nameof(DestinationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReceivingDirectMail = group.Add(new VocabularyKey(nameof(IsReceivingDirectMail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProspectResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(ProspectResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalCode = group.Add(new VocabularyKey(nameof(FiscalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SiretNumber = group.Add(new VocabularyKey(nameof(SiretNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsImported = group.Add(new VocabularyKey(nameof(IsImported), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OnHoldStatus = group.Add(new VocabularyKey(nameof(OnHoldStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineOfBusinessId = group.Add(new VocabularyKey(nameof(LineOfBusinessId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCreditLimitCheckingRequired = group.Add(new VocabularyKey(nameof(IsCreditLimitCheckingRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NAFCode = group.Add(new VocabularyKey(nameof(NAFCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Note = group.Add(new VocabularyKey(nameof(Note), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsOneTimeCustomerOrVendor = group.Add(new VocabularyKey(nameof(IsOneTimeCustomerOrVendor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BusinessOpeningTime = group.Add(new VocabularyKey(nameof(BusinessOpeningTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BusinessClosingTime = group.Add(new VocabularyKey(nameof(BusinessClosingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ArePricesIncludingSalesTax = group.Add(new VocabularyKey(nameof(ArePricesIncludingSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProspectId = group.Add(new VocabularyKey(nameof(ProspectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryReceiptWorkCalendarId = group.Add(new VocabularyKey(nameof(DeliveryReceiptWorkCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesDistrictId = group.Add(new VocabularyKey(nameof(SalesDistrictId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BusinessSegmentCode = group.Add(new VocabularyKey(nameof(BusinessSegmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProspectStatusCode = group.Add(new VocabularyKey(nameof(ProspectStatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BusinessSubsegmentCode = group.Add(new VocabularyKey(nameof(BusinessSubsegmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProspectRelationTypeId = group.Add(new VocabularyKey(nameof(ProspectRelationTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UPSFreightZone = group.Add(new VocabularyKey(nameof(UPSFreightZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorGroupId = group.Add(new VocabularyKey(nameof(VendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressBooks = group.Add(new VocabularyKey(nameof(AddressBooks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(AddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCountyId = group.Add(new VocabularyKey(nameof(AddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLocationId = group.Add(new VocabularyKey(nameof(AddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLocationRoles = group.Add(new VocabularyKey(nameof(AddressLocationRoles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressStateId = group.Add(new VocabularyKey(nameof(AddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressPostBox = group.Add(new VocabularyKey(nameof(AddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressBuildingCompliment = group.Add(new VocabularyKey(nameof(AddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressStreetNumber = group.Add(new VocabularyKey(nameof(AddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCityInKana = group.Add(new VocabularyKey(nameof(AddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressStreetInKana = group.Add(new VocabularyKey(nameof(AddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressTimeZone = group.Add(new VocabularyKey(nameof(AddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FormattedAddress = group.Add(new VocabularyKey(nameof(FormattedAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProspectKnownAsName = group.Add(new VocabularyKey(nameof(ProspectKnownAsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProspectName = group.Add(new VocabularyKey(nameof(ProspectName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProspectSearchName = group.Add(new VocabularyKey(nameof(ProspectSearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrganizationABCCode = group.Add(new VocabularyKey(nameof(OrganizationABCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrganizationNumber = group.Add(new VocabularyKey(nameof(OrganizationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrganizationEmployeeAmount = group.Add(new VocabularyKey(nameof(OrganizationEmployeeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrganizationPhoneticName = group.Add(new VocabularyKey(nameof(OrganizationPhoneticName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProspectPartyNumber = group.Add(new VocabularyKey(nameof(ProspectPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProspectPartyType = group.Add(new VocabularyKey(nameof(ProspectPartyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonAnniversaryDay = group.Add(new VocabularyKey(nameof(PersonAnniversaryDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonAnniversaryMonth = group.Add(new VocabularyKey(nameof(PersonAnniversaryMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonAnniversaryYear = group.Add(new VocabularyKey(nameof(PersonAnniversaryYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonBirthDay = group.Add(new VocabularyKey(nameof(PersonBirthDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonBirthMonth = group.Add(new VocabularyKey(nameof(PersonBirthMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonBirthYear = group.Add(new VocabularyKey(nameof(PersonBirthYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonChildrenNames = group.Add(new VocabularyKey(nameof(PersonChildrenNames), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonGender = group.Add(new VocabularyKey(nameof(PersonGender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonHobbies = group.Add(new VocabularyKey(nameof(PersonHobbies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonInitials = group.Add(new VocabularyKey(nameof(PersonInitials), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonMaritalStatus = group.Add(new VocabularyKey(nameof(PersonMaritalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonPhoneticFirstName = group.Add(new VocabularyKey(nameof(PersonPhoneticFirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonPhoneticLastName = group.Add(new VocabularyKey(nameof(PersonPhoneticLastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonPhoneticMiddleName = group.Add(new VocabularyKey(nameof(PersonPhoneticMiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonProfessionalSuffix = group.Add(new VocabularyKey(nameof(PersonProfessionalSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonProfessionalTitle = group.Add(new VocabularyKey(nameof(PersonProfessionalTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryEmailAddress = group.Add(new VocabularyKey(nameof(PrimaryEmailAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryEmailAddressDescription = group.Add(new VocabularyKey(nameof(PrimaryEmailAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPrimaryEmailAddressIMEnabled = group.Add(new VocabularyKey(nameof(IsPrimaryEmailAddressIMEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryEmailAddressPurpose = group.Add(new VocabularyKey(nameof(PrimaryEmailAddressPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryFaxNumber = group.Add(new VocabularyKey(nameof(PrimaryFaxNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryFaxNumberDescription = group.Add(new VocabularyKey(nameof(PrimaryFaxNumberDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryFaxNumberExtension = group.Add(new VocabularyKey(nameof(PrimaryFaxNumberExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryFaxNumberPurpose = group.Add(new VocabularyKey(nameof(PrimaryFaxNumberPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryPhoneNumber = group.Add(new VocabularyKey(nameof(PrimaryPhoneNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryPhoneNumberDescription = group.Add(new VocabularyKey(nameof(PrimaryPhoneNumberDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryPhoneNumberExtension = group.Add(new VocabularyKey(nameof(PrimaryPhoneNumberExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPrimaryPhoneNumberMobile = group.Add(new VocabularyKey(nameof(IsPrimaryPhoneNumberMobile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryPhoneNumberPurpose = group.Add(new VocabularyKey(nameof(PrimaryPhoneNumberPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryTelex = group.Add(new VocabularyKey(nameof(PrimaryTelex), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryTelexDescription = group.Add(new VocabularyKey(nameof(PrimaryTelexDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryTelexPurpose = group.Add(new VocabularyKey(nameof(PrimaryTelexPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryURL = group.Add(new VocabularyKey(nameof(PrimaryURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryURLDescription = group.Add(new VocabularyKey(nameof(PrimaryURLDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryURLPurpose = group.Add(new VocabularyKey(nameof(PrimaryURLPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryFacebook = group.Add(new VocabularyKey(nameof(PrimaryFacebook), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryFacebookDescription = group.Add(new VocabularyKey(nameof(PrimaryFacebookDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryFacebookPurpose = group.Add(new VocabularyKey(nameof(PrimaryFacebookPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryLinkedIn = group.Add(new VocabularyKey(nameof(PrimaryLinkedIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryLinkedInDescription = group.Add(new VocabularyKey(nameof(PrimaryLinkedInDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryLinkedInPurpose = group.Add(new VocabularyKey(nameof(PrimaryLinkedInPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryTwitter = group.Add(new VocabularyKey(nameof(PrimaryTwitter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryTwitterDescription = group.Add(new VocabularyKey(nameof(PrimaryTwitterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryTwitterPurpose = group.Add(new VocabularyKey(nameof(PrimaryTwitterPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ElectronicLocationId = group.Add(new VocabularyKey(nameof(ElectronicLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CompanyChainName { get; private set; }
public VocabularyKey CreditLimit { get; private set; }
public VocabularyKey CreditRating { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey CustomerGroupId { get; private set; }
public VocabularyKey DefaultLedgerDimension { get; private set; }
public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
public VocabularyKey DeliveryTermsCode { get; private set; }
public VocabularyKey DestinationCode { get; private set; }
public VocabularyKey IsReceivingDirectMail { get; private set; }
public VocabularyKey ProspectResponsiblePersonnelNumber { get; private set; }
public VocabularyKey FiscalCode { get; private set; }
public VocabularyKey SiretNumber { get; private set; }
public VocabularyKey IsImported { get; private set; }
public VocabularyKey OnHoldStatus { get; private set; }
public VocabularyKey LineOfBusinessId { get; private set; }
public VocabularyKey IsCreditLimitCheckingRequired { get; private set; }
public VocabularyKey DeliveryModeCode { get; private set; }
public VocabularyKey NAFCode { get; private set; }
public VocabularyKey Note { get; private set; }
public VocabularyKey IsOneTimeCustomerOrVendor { get; private set; }
public VocabularyKey BusinessOpeningTime { get; private set; }
public VocabularyKey BusinessClosingTime { get; private set; }
public VocabularyKey ArePricesIncludingSalesTax { get; private set; }
public VocabularyKey ProspectId { get; private set; }
public VocabularyKey DeliveryReceiptWorkCalendarId { get; private set; }
public VocabularyKey SalesDistrictId { get; private set; }
public VocabularyKey SalesTaxGroupCode { get; private set; }
public VocabularyKey BusinessSegmentCode { get; private set; }
public VocabularyKey ProspectStatusCode { get; private set; }
public VocabularyKey BusinessSubsegmentCode { get; private set; }
public VocabularyKey ProspectRelationTypeId { get; private set; }
public VocabularyKey UPSFreightZone { get; private set; }
public VocabularyKey VendorGroupId { get; private set; }
public VocabularyKey AddressBooks { get; private set; }
public VocabularyKey AddressCity { get; private set; }
public VocabularyKey AddressCountryRegionId { get; private set; }
public VocabularyKey AddressCountryRegionISOCode { get; private set; }
public VocabularyKey AddressCountyId { get; private set; }
public VocabularyKey AddressDistrictName { get; private set; }
public VocabularyKey AddressLatitude { get; private set; }
public VocabularyKey AddressLocationId { get; private set; }
public VocabularyKey AddressLocationRoles { get; private set; }
public VocabularyKey AddressLongitude { get; private set; }
public VocabularyKey AddressStateId { get; private set; }
public VocabularyKey AddressStreet { get; private set; }
public VocabularyKey AddressPostBox { get; private set; }
public VocabularyKey AddressBuildingCompliment { get; private set; }
public VocabularyKey AddressStreetNumber { get; private set; }
public VocabularyKey AddressCityInKana { get; private set; }
public VocabularyKey AddressStreetInKana { get; private set; }
public VocabularyKey AddressTimeZone { get; private set; }
public VocabularyKey AddressValidFrom { get; private set; }
public VocabularyKey AddressValidTo { get; private set; }
public VocabularyKey AddressZipCode { get; private set; }
public VocabularyKey AddressDescription { get; private set; }
public VocabularyKey FormattedAddress { get; private set; }
public VocabularyKey ProspectKnownAsName { get; private set; }
public VocabularyKey LanguageId { get; private set; }
public VocabularyKey ProspectName { get; private set; }
public VocabularyKey ProspectSearchName { get; private set; }
public VocabularyKey OrganizationABCCode { get; private set; }
public VocabularyKey OrganizationNumber { get; private set; }
public VocabularyKey OrganizationEmployeeAmount { get; private set; }
public VocabularyKey OrganizationPhoneticName { get; private set; }
public VocabularyKey ProspectPartyNumber { get; private set; }
public VocabularyKey ProspectPartyType { get; private set; }
public VocabularyKey PersonAnniversaryDay { get; private set; }
public VocabularyKey PersonAnniversaryMonth { get; private set; }
public VocabularyKey PersonAnniversaryYear { get; private set; }
public VocabularyKey PersonBirthDay { get; private set; }
public VocabularyKey PersonBirthMonth { get; private set; }
public VocabularyKey PersonBirthYear { get; private set; }
public VocabularyKey PersonChildrenNames { get; private set; }
public VocabularyKey PersonGender { get; private set; }
public VocabularyKey PersonHobbies { get; private set; }
public VocabularyKey PersonInitials { get; private set; }
public VocabularyKey PersonMaritalStatus { get; private set; }
public VocabularyKey PersonPhoneticFirstName { get; private set; }
public VocabularyKey PersonPhoneticLastName { get; private set; }
public VocabularyKey PersonPhoneticMiddleName { get; private set; }
public VocabularyKey PersonProfessionalSuffix { get; private set; }
public VocabularyKey PersonProfessionalTitle { get; private set; }
public VocabularyKey PrimaryEmailAddress { get; private set; }
public VocabularyKey PrimaryEmailAddressDescription { get; private set; }
public VocabularyKey IsPrimaryEmailAddressIMEnabled { get; private set; }
public VocabularyKey PrimaryEmailAddressPurpose { get; private set; }
public VocabularyKey PrimaryFaxNumber { get; private set; }
public VocabularyKey PrimaryFaxNumberDescription { get; private set; }
public VocabularyKey PrimaryFaxNumberExtension { get; private set; }
public VocabularyKey PrimaryFaxNumberPurpose { get; private set; }
public VocabularyKey PrimaryPhoneNumber { get; private set; }
public VocabularyKey PrimaryPhoneNumberDescription { get; private set; }
public VocabularyKey PrimaryPhoneNumberExtension { get; private set; }
public VocabularyKey IsPrimaryPhoneNumberMobile { get; private set; }
public VocabularyKey PrimaryPhoneNumberPurpose { get; private set; }
public VocabularyKey PrimaryTelex { get; private set; }
public VocabularyKey PrimaryTelexDescription { get; private set; }
public VocabularyKey PrimaryTelexPurpose { get; private set; }
public VocabularyKey PrimaryURL { get; private set; }
public VocabularyKey PrimaryURLDescription { get; private set; }
public VocabularyKey PrimaryURLPurpose { get; private set; }
public VocabularyKey PrimaryFacebook { get; private set; }
public VocabularyKey PrimaryFacebookDescription { get; private set; }
public VocabularyKey PrimaryFacebookPurpose { get; private set; }
public VocabularyKey PrimaryLinkedIn { get; private set; }
public VocabularyKey PrimaryLinkedInDescription { get; private set; }
public VocabularyKey PrimaryLinkedInPurpose { get; private set; }
public VocabularyKey PrimaryTwitter { get; private set; }
public VocabularyKey PrimaryTwitterDescription { get; private set; }
public VocabularyKey PrimaryTwitterPurpose { get; private set; }
public VocabularyKey ElectronicLocationId { get; private set; }


    }
}