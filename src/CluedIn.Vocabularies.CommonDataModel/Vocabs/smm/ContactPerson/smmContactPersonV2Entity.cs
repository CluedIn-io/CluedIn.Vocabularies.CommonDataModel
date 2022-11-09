using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmContactPersonV2EntityVocabulary : SimpleVocabulary
    {
        public smmContactPersonV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model smmContactPersonV2Entity";
            KeyPrefix = "commonDataModel.smmcontactpersonv2entity";
            KeySeparator = ".";
            Grouping = "/smmContactPersonV2Entity";

            AddGroup("Common Data Model smmContactPersonV2Entity Details", group =>
            {
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPersonPartyNumber = group.Add(new VocabularyKey(nameof(ContactPersonPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPersonName = group.Add(new VocabularyKey(nameof(ContactPersonName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPersonPartyType = group.Add(new VocabularyKey(nameof(ContactPersonPartyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactForParty = group.Add(new VocabularyKey(nameof(ContactForParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AssociatedPartyNumber = group.Add(new VocabularyKey(nameof(AssociatedPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FirstName = group.Add(new VocabularyKey(nameof(FirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LastName = group.Add(new VocabularyKey(nameof(LastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SearchName = group.Add(new VocabularyKey(nameof(SearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressBookNames = group.Add(new VocabularyKey(nameof(AddressBookNames), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactInformationLanguageId = group.Add(new VocabularyKey(nameof(ContactInformationLanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChildrenNames = group.Add(new VocabularyKey(nameof(ChildrenNames), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Hobbies = group.Add(new VocabularyKey(nameof(Hobbies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Initials = group.Add(new VocabularyKey(nameof(Initials), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
KnownAsName = group.Add(new VocabularyKey(nameof(KnownAsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProfessionalTitle = group.Add(new VocabularyKey(nameof(ProfessionalTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProfessionalSuffix = group.Add(new VocabularyKey(nameof(ProfessionalSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PhoneticFirstName = group.Add(new VocabularyKey(nameof(PhoneticFirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PhoneticMiddleName = group.Add(new VocabularyKey(nameof(PhoneticMiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PhoneticLastName = group.Add(new VocabularyKey(nameof(PhoneticLastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Gender = group.Add(new VocabularyKey(nameof(Gender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaritalStatus = group.Add(new VocabularyKey(nameof(MaritalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BirthDay = group.Add(new VocabularyKey(nameof(BirthDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BirthMonth = group.Add(new VocabularyKey(nameof(BirthMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BirthYear = group.Add(new VocabularyKey(nameof(BirthYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AnniversaryDay = group.Add(new VocabularyKey(nameof(AnniversaryDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AnniversaryMonth = group.Add(new VocabularyKey(nameof(AnniversaryMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AnniversaryYear = group.Add(new VocabularyKey(nameof(AnniversaryYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressDescription = group.Add(new VocabularyKey(nameof(PrimaryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressCity = group.Add(new VocabularyKey(nameof(PrimaryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressCityInKana = group.Add(new VocabularyKey(nameof(PrimaryAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(PrimaryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(PrimaryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressCountyId = group.Add(new VocabularyKey(nameof(PrimaryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressDistrictName = group.Add(new VocabularyKey(nameof(PrimaryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressLatitude = group.Add(new VocabularyKey(nameof(PrimaryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressLocationId = group.Add(new VocabularyKey(nameof(PrimaryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressLocationRoles = group.Add(new VocabularyKey(nameof(PrimaryAddressLocationRoles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressLongitude = group.Add(new VocabularyKey(nameof(PrimaryAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressStateId = group.Add(new VocabularyKey(nameof(PrimaryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressStreet = group.Add(new VocabularyKey(nameof(PrimaryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressStreetInKana = group.Add(new VocabularyKey(nameof(PrimaryAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressTimeZone = group.Add(new VocabularyKey(nameof(PrimaryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressZipCode = group.Add(new VocabularyKey(nameof(PrimaryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressPostBox = group.Add(new VocabularyKey(nameof(PrimaryAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(PrimaryAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressStreetNumber = group.Add(new VocabularyKey(nameof(PrimaryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FormattedPrimaryAddress = group.Add(new VocabularyKey(nameof(FormattedPrimaryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressValidFrom = group.Add(new VocabularyKey(nameof(PrimaryAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressValidTo = group.Add(new VocabularyKey(nameof(PrimaryAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
EmploymentJobTitle = group.Add(new VocabularyKey(nameof(EmploymentJobTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmploymentJobFunctionName = group.Add(new VocabularyKey(nameof(EmploymentJobFunctionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmploymentProfession = group.Add(new VocabularyKey(nameof(EmploymentProfession), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmploymentDepartment = group.Add(new VocabularyKey(nameof(EmploymentDepartment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmploymentOfficeLocation = group.Add(new VocabularyKey(nameof(EmploymentOfficeLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmploymentComputerNetworkName = group.Add(new VocabularyKey(nameof(EmploymentComputerNetworkName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AvailableFromTime = group.Add(new VocabularyKey(nameof(AvailableFromTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AvailableToTime = group.Add(new VocabularyKey(nameof(AvailableToTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MicrosoftOutlookCategories = group.Add(new VocabularyKey(nameof(MicrosoftOutlookCategories), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactActivitySensitivityLevel = group.Add(new VocabularyKey(nameof(ContactActivitySensitivityLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ManagerContactPersonId = group.Add(new VocabularyKey(nameof(ManagerContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainResponsibleWorker = group.Add(new VocabularyKey(nameof(MainResponsibleWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPersonResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(ContactPersonResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReceivingDirectMail = group.Add(new VocabularyKey(nameof(IsReceivingDirectMail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimarySalutationPhrase = group.Add(new VocabularyKey(nameof(PrimarySalutationPhrase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AlternateSalutationPhrase = group.Add(new VocabularyKey(nameof(AlternateSalutationPhrase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryComplimentaryClosingPhrase = group.Add(new VocabularyKey(nameof(PrimaryComplimentaryClosingPhrase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AlternateComplimentaryClosingPhrase = group.Add(new VocabularyKey(nameof(AlternateComplimentaryClosingPhrase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrganizationIdentificationNumber = group.Add(new VocabularyKey(nameof(OrganizationIdentificationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GovernmentIdentificationNumber = group.Add(new VocabularyKey(nameof(GovernmentIdentificationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MileageDistance = group.Add(new VocabularyKey(nameof(MileageDistance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltyLevelPhrase = group.Add(new VocabularyKey(nameof(LoyaltyLevelPhrase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DecisionMakingRoleCode = group.Add(new VocabularyKey(nameof(DecisionMakingRoleCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonalCharacterTypeCode = group.Add(new VocabularyKey(nameof(PersonalCharacterTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsVIP = group.Add(new VocabularyKey(nameof(IsVIP), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AssistantName = group.Add(new VocabularyKey(nameof(AssistantName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AssistantPhoneNumber = group.Add(new VocabularyKey(nameof(AssistantPhoneNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BillingInformation = group.Add(new VocabularyKey(nameof(BillingInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsImported = group.Add(new VocabularyKey(nameof(IsImported), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsInactive = group.Add(new VocabularyKey(nameof(IsInactive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LastEditDateTime = group.Add(new VocabularyKey(nameof(LastEditDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDefaultContactPerson = group.Add(new VocabularyKey(nameof(IsDefaultContactPerson), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IdentityCardNumber = group.Add(new VocabularyKey(nameof(IdentityCardNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SpouseName = group.Add(new VocabularyKey(nameof(SpouseName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserRole = group.Add(new VocabularyKey(nameof(UserRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HasRequestedInternetAccess = group.Add(new VocabularyKey(nameof(HasRequestedInternetAccess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NameValidFrom = group.Add(new VocabularyKey(nameof(NameValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NameValidTo = group.Add(new VocabularyKey(nameof(NameValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisplayNameSequencePatternName = group.Add(new VocabularyKey(nameof(DisplayNameSequencePatternName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ElectronicLocationId = group.Add(new VocabularyKey(nameof(ElectronicLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsVendorPortalAccessAllowed = group.Add(new VocabularyKey(nameof(IsVendorPortalAccessAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsContactPersonExternallyMaintained = group.Add(new VocabularyKey(nameof(IsContactPersonExternallyMaintained), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryPostalAddressRecId = group.Add(new VocabularyKey(nameof(PrimaryPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryContactEmailRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactEmailRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryContactFaxRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactFaxRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryContactPhoneRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryContactTelexRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactTelexRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryContactURLRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactURLRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryContactFacebookRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactFacebookRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryContactTwitterRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactTwitterRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryContactLinkedInRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactLinkedInRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressLocation = group.Add(new VocabularyKey(nameof(PrimaryAddressLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PartyRecordId = group.Add(new VocabularyKey(nameof(PartyRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ContactPersonId { get; private set; }
public VocabularyKey ContactPersonPartyNumber { get; private set; }
public VocabularyKey ContactPersonName { get; private set; }
public VocabularyKey ContactPersonPartyType { get; private set; }
public VocabularyKey ContactForParty { get; private set; }
public VocabularyKey AssociatedPartyNumber { get; private set; }
public VocabularyKey FirstName { get; private set; }
public VocabularyKey MiddleName { get; private set; }
public VocabularyKey LastName { get; private set; }
public VocabularyKey SearchName { get; private set; }
public VocabularyKey AddressBookNames { get; private set; }
public VocabularyKey ContactInformationLanguageId { get; private set; }
public VocabularyKey ChildrenNames { get; private set; }
public VocabularyKey Hobbies { get; private set; }
public VocabularyKey Initials { get; private set; }
public VocabularyKey KnownAsName { get; private set; }
public VocabularyKey ProfessionalTitle { get; private set; }
public VocabularyKey ProfessionalSuffix { get; private set; }
public VocabularyKey PhoneticFirstName { get; private set; }
public VocabularyKey PhoneticMiddleName { get; private set; }
public VocabularyKey PhoneticLastName { get; private set; }
public VocabularyKey Gender { get; private set; }
public VocabularyKey MaritalStatus { get; private set; }
public VocabularyKey BirthDay { get; private set; }
public VocabularyKey BirthMonth { get; private set; }
public VocabularyKey BirthYear { get; private set; }
public VocabularyKey AnniversaryDay { get; private set; }
public VocabularyKey AnniversaryMonth { get; private set; }
public VocabularyKey AnniversaryYear { get; private set; }
public VocabularyKey PrimaryAddressDescription { get; private set; }
public VocabularyKey PrimaryAddressCity { get; private set; }
public VocabularyKey PrimaryAddressCityInKana { get; private set; }
public VocabularyKey PrimaryAddressCountryRegionId { get; private set; }
public VocabularyKey PrimaryAddressCountryRegionISOCode { get; private set; }
public VocabularyKey PrimaryAddressCountyId { get; private set; }
public VocabularyKey PrimaryAddressDistrictName { get; private set; }
public VocabularyKey PrimaryAddressLatitude { get; private set; }
public VocabularyKey PrimaryAddressLocationId { get; private set; }
public VocabularyKey PrimaryAddressLocationRoles { get; private set; }
public VocabularyKey PrimaryAddressLongitude { get; private set; }
public VocabularyKey PrimaryAddressStateId { get; private set; }
public VocabularyKey PrimaryAddressStreet { get; private set; }
public VocabularyKey PrimaryAddressStreetInKana { get; private set; }
public VocabularyKey PrimaryAddressTimeZone { get; private set; }
public VocabularyKey PrimaryAddressZipCode { get; private set; }
public VocabularyKey PrimaryAddressPostBox { get; private set; }
public VocabularyKey PrimaryAddressBuildingCompliment { get; private set; }
public VocabularyKey PrimaryAddressStreetNumber { get; private set; }
public VocabularyKey FormattedPrimaryAddress { get; private set; }
public VocabularyKey PrimaryAddressValidFrom { get; private set; }
public VocabularyKey PrimaryAddressValidTo { get; private set; }
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
public VocabularyKey EmploymentJobTitle { get; private set; }
public VocabularyKey EmploymentJobFunctionName { get; private set; }
public VocabularyKey EmploymentProfession { get; private set; }
public VocabularyKey EmploymentDepartment { get; private set; }
public VocabularyKey EmploymentOfficeLocation { get; private set; }
public VocabularyKey EmploymentComputerNetworkName { get; private set; }
public VocabularyKey AvailableFromTime { get; private set; }
public VocabularyKey AvailableToTime { get; private set; }
public VocabularyKey MicrosoftOutlookCategories { get; private set; }
public VocabularyKey ContactActivitySensitivityLevel { get; private set; }
public VocabularyKey ManagerContactPersonId { get; private set; }
public VocabularyKey MainResponsibleWorker { get; private set; }
public VocabularyKey ContactPersonResponsiblePersonnelNumber { get; private set; }
public VocabularyKey IsReceivingDirectMail { get; private set; }
public VocabularyKey Notes { get; private set; }
public VocabularyKey PrimarySalutationPhrase { get; private set; }
public VocabularyKey AlternateSalutationPhrase { get; private set; }
public VocabularyKey PrimaryComplimentaryClosingPhrase { get; private set; }
public VocabularyKey AlternateComplimentaryClosingPhrase { get; private set; }
public VocabularyKey OrganizationIdentificationNumber { get; private set; }
public VocabularyKey GovernmentIdentificationNumber { get; private set; }
public VocabularyKey MileageDistance { get; private set; }
public VocabularyKey LoyaltyLevelPhrase { get; private set; }
public VocabularyKey DecisionMakingRoleCode { get; private set; }
public VocabularyKey PersonalCharacterTypeCode { get; private set; }
public VocabularyKey IsVIP { get; private set; }
public VocabularyKey AssistantName { get; private set; }
public VocabularyKey AssistantPhoneNumber { get; private set; }
public VocabularyKey BillingInformation { get; private set; }
public VocabularyKey IsImported { get; private set; }
public VocabularyKey IsInactive { get; private set; }
public VocabularyKey LastEditDateTime { get; private set; }
public VocabularyKey IsDefaultContactPerson { get; private set; }
public VocabularyKey IdentityCardNumber { get; private set; }
public VocabularyKey SpouseName { get; private set; }
public VocabularyKey UserRole { get; private set; }
public VocabularyKey HasRequestedInternetAccess { get; private set; }
public VocabularyKey NameValidFrom { get; private set; }
public VocabularyKey NameValidTo { get; private set; }
public VocabularyKey DisplayNameSequencePatternName { get; private set; }
public VocabularyKey ElectronicLocationId { get; private set; }
public VocabularyKey IsVendorPortalAccessAllowed { get; private set; }
public VocabularyKey IsContactPersonExternallyMaintained { get; private set; }
public VocabularyKey PrimaryPostalAddressRecId { get; private set; }
public VocabularyKey PrimaryContactEmailRecordId { get; private set; }
public VocabularyKey PrimaryContactFaxRecordId { get; private set; }
public VocabularyKey PrimaryContactPhoneRecordId { get; private set; }
public VocabularyKey PrimaryContactTelexRecordId { get; private set; }
public VocabularyKey PrimaryContactURLRecordId { get; private set; }
public VocabularyKey PrimaryContactFacebookRecordId { get; private set; }
public VocabularyKey PrimaryContactTwitterRecordId { get; private set; }
public VocabularyKey PrimaryContactLinkedInRecordId { get; private set; }
public VocabularyKey PrimaryAddressLocation { get; private set; }
public VocabularyKey PartyRecordId { get; private set; }


    }
}