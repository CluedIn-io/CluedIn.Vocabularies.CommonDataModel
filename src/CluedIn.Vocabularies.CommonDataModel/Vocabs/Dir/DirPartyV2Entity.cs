using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DirPartyV2EntityVocabulary : SimpleVocabulary
    {
        public DirPartyV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model DirPartyV2Entity";
            KeyPrefix = "commonDataModel.dirpartyv2entity";
            KeySeparator = ".";
            Grouping = "/DirPartyV2Entity";

            AddGroup("Common Data Model DirPartyV2Entity Details", group =>
            {
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyType = group.Add(new VocabularyKey(nameof(PartyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameAlias = group.Add(new VocabularyKey(nameof(NameAlias), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KnownAs = group.Add(new VocabularyKey(nameof(KnownAs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstanceRelationType = group.Add(new VocabularyKey(nameof(InstanceRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBooks = group.Add(new VocabularyKey(nameof(AddressBooks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationName = group.Add(new VocabularyKey(nameof(OrganizationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationABCCode = group.Add(new VocabularyKey(nameof(OrganizationABCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationNumOfEmployees = group.Add(new VocabularyKey(nameof(OrganizationNumOfEmployees), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationNumber = group.Add(new VocabularyKey(nameof(OrganizationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationPhoneticName = group.Add(new VocabularyKey(nameof(OrganizationPhoneticName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonFirstName = group.Add(new VocabularyKey(nameof(PersonFirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonMiddleName = group.Add(new VocabularyKey(nameof(PersonMiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonLastNamePrefix = group.Add(new VocabularyKey(nameof(PersonLastNamePrefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonLastName = group.Add(new VocabularyKey(nameof(PersonLastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonInitials = group.Add(new VocabularyKey(nameof(PersonInitials), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonPersonalSuffix = group.Add(new VocabularyKey(nameof(PersonPersonalSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonPersonalTitle = group.Add(new VocabularyKey(nameof(PersonPersonalTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonProfessionalTitle = group.Add(new VocabularyKey(nameof(PersonProfessionalTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonProfessionalSuffix = group.Add(new VocabularyKey(nameof(PersonProfessionalSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonPhoneticFirstName = group.Add(new VocabularyKey(nameof(PersonPhoneticFirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonPhoneticLastName = group.Add(new VocabularyKey(nameof(PersonPhoneticLastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonPhoneticMiddleName = group.Add(new VocabularyKey(nameof(PersonPhoneticMiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonGender = group.Add(new VocabularyKey(nameof(PersonGender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonMaritalStatus = group.Add(new VocabularyKey(nameof(PersonMaritalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonHobbies = group.Add(new VocabularyKey(nameof(PersonHobbies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonChildrenNames = group.Add(new VocabularyKey(nameof(PersonChildrenNames), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonAnniversaryDay = group.Add(new VocabularyKey(nameof(PersonAnniversaryDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonAnniversaryMonth = group.Add(new VocabularyKey(nameof(PersonAnniversaryMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonAnniversaryYear = group.Add(new VocabularyKey(nameof(PersonAnniversaryYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonBirthDay = group.Add(new VocabularyKey(nameof(PersonBirthDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonBirthMonth = group.Add(new VocabularyKey(nameof(PersonBirthMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonBirthYear = group.Add(new VocabularyKey(nameof(PersonBirthYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityDataArea = group.Add(new VocabularyKey(nameof(LegalEntityDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitType = group.Add(new VocabularyKey(nameof(OperatingUnitType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitTypeStr = group.Add(new VocabularyKey(nameof(OperatingUnitTypeStr), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TeamType = group.Add(new VocabularyKey(nameof(TeamType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TeamDescription = group.Add(new VocabularyKey(nameof(TeamDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TeamMembershipCriterion = group.Add(new VocabularyKey(nameof(TeamMembershipCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullPrimaryAddress = group.Add(new VocabularyKey(nameof(FullPrimaryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(AddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCounty = group.Add(new VocabularyKey(nameof(AddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressTimeZone = group.Add(new VocabularyKey(nameof(AddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationId = group.Add(new VocabularyKey(nameof(AddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationRoles = group.Add(new VocabularyKey(nameof(AddressLocationRoles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressIsPrivate = group.Add(new VocabularyKey(nameof(AddressIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmail = group.Add(new VocabularyKey(nameof(PrimaryContactEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailDescription = group.Add(new VocabularyKey(nameof(PrimaryContactEmailDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailIsIM = group.Add(new VocabularyKey(nameof(PrimaryContactEmailIsIM), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailIsPrivate = group.Add(new VocabularyKey(nameof(PrimaryContactEmailIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactEmailPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFax = group.Add(new VocabularyKey(nameof(PrimaryContactFax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxDescription = group.Add(new VocabularyKey(nameof(PrimaryContactFaxDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxExtension = group.Add(new VocabularyKey(nameof(PrimaryContactFaxExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxIsPrivate = group.Add(new VocabularyKey(nameof(PrimaryContactFaxIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactFaxPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhone = group.Add(new VocabularyKey(nameof(PrimaryContactPhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneDescription = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneExtension = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneIsMobile = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneIsMobile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneIsPrivate = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhonePurpose = group.Add(new VocabularyKey(nameof(PrimaryContactPhonePurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTelex = group.Add(new VocabularyKey(nameof(PrimaryContactTelex), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTelexDescription = group.Add(new VocabularyKey(nameof(PrimaryContactTelexDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTelexIsPrivate = group.Add(new VocabularyKey(nameof(PrimaryContactTelexIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTelexPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactTelexPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactURL = group.Add(new VocabularyKey(nameof(PrimaryContactURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactURLDescription = group.Add(new VocabularyKey(nameof(PrimaryContactURLDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactURLIsPrivate = group.Add(new VocabularyKey(nameof(PrimaryContactURLIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactURLPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactURLPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFacebook = group.Add(new VocabularyKey(nameof(PrimaryContactFacebook), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFacebookDescription = group.Add(new VocabularyKey(nameof(PrimaryContactFacebookDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFacebookIsPrivate = group.Add(new VocabularyKey(nameof(PrimaryContactFacebookIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFacebookPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactFacebookPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactLinkedIn = group.Add(new VocabularyKey(nameof(PrimaryContactLinkedIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactLinkedInDescription = group.Add(new VocabularyKey(nameof(PrimaryContactLinkedInDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactLinkedInIsPrivate = group.Add(new VocabularyKey(nameof(PrimaryContactLinkedInIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactLinkedInPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactLinkedInPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTwitter = group.Add(new VocabularyKey(nameof(PrimaryContactTwitter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTwitterDescription = group.Add(new VocabularyKey(nameof(PrimaryContactTwitterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTwitterIsPrivate = group.Add(new VocabularyKey(nameof(PrimaryContactTwitterIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTwitterPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactTwitterPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicLocationId = group.Add(new VocabularyKey(nameof(ElectronicLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressLocation = group.Add(new VocabularyKey(nameof(PrimaryAddressLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimaryAddressLocationOwner = group.Add(new VocabularyKey(nameof(IsPrimaryAddressLocationOwner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey PartyType { get; private set; }
        public VocabularyKey NameAlias { get; private set; }
        public VocabularyKey KnownAs { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey InstanceRelationType { get; private set; }
        public VocabularyKey AddressBooks { get; private set; }
        public VocabularyKey OrganizationName { get; private set; }
        public VocabularyKey OrganizationABCCode { get; private set; }
        public VocabularyKey OrganizationNumOfEmployees { get; private set; }
        public VocabularyKey OrganizationNumber { get; private set; }
        public VocabularyKey OrganizationPhoneticName { get; private set; }
        public VocabularyKey PersonFirstName { get; private set; }
        public VocabularyKey PersonMiddleName { get; private set; }
        public VocabularyKey PersonLastNamePrefix { get; private set; }
        public VocabularyKey PersonLastName { get; private set; }
        public VocabularyKey PersonInitials { get; private set; }
        public VocabularyKey PersonPersonalSuffix { get; private set; }
        public VocabularyKey PersonPersonalTitle { get; private set; }
        public VocabularyKey PersonProfessionalTitle { get; private set; }
        public VocabularyKey PersonProfessionalSuffix { get; private set; }
        public VocabularyKey PersonPhoneticFirstName { get; private set; }
        public VocabularyKey PersonPhoneticLastName { get; private set; }
        public VocabularyKey PersonPhoneticMiddleName { get; private set; }
        public VocabularyKey PersonGender { get; private set; }
        public VocabularyKey PersonMaritalStatus { get; private set; }
        public VocabularyKey PersonHobbies { get; private set; }
        public VocabularyKey PersonChildrenNames { get; private set; }
        public VocabularyKey PersonAnniversaryDay { get; private set; }
        public VocabularyKey PersonAnniversaryMonth { get; private set; }
        public VocabularyKey PersonAnniversaryYear { get; private set; }
        public VocabularyKey PersonBirthDay { get; private set; }
        public VocabularyKey PersonBirthMonth { get; private set; }
        public VocabularyKey PersonBirthYear { get; private set; }
        public VocabularyKey LegalEntityDataArea { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }
        public VocabularyKey OperatingUnitType { get; private set; }
        public VocabularyKey OperatingUnitTypeStr { get; private set; }
        public VocabularyKey TeamType { get; private set; }
        public VocabularyKey TeamDescription { get; private set; }
        public VocabularyKey TeamMembershipCriterion { get; private set; }
        public VocabularyKey FullPrimaryAddress { get; private set; }
        public VocabularyKey AddressZipCode { get; private set; }
        public VocabularyKey AddressCountryRegionId { get; private set; }
        public VocabularyKey AddressCountryRegionISOCode { get; private set; }
        public VocabularyKey AddressStreet { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressCounty { get; private set; }
        public VocabularyKey AddressDistrictName { get; private set; }
        public VocabularyKey AddressState { get; private set; }
        public VocabularyKey AddressLatitude { get; private set; }
        public VocabularyKey AddressLongitude { get; private set; }
        public VocabularyKey AddressTimeZone { get; private set; }
        public VocabularyKey AddressValidFrom { get; private set; }
        public VocabularyKey AddressValidTo { get; private set; }
        public VocabularyKey AddressLocationId { get; private set; }
        public VocabularyKey AddressLocationRoles { get; private set; }
        public VocabularyKey AddressIsPrivate { get; private set; }
        public VocabularyKey AddressDescription { get; private set; }
        public VocabularyKey PrimaryContactEmail { get; private set; }
        public VocabularyKey PrimaryContactEmailDescription { get; private set; }
        public VocabularyKey PrimaryContactEmailIsIM { get; private set; }
        public VocabularyKey PrimaryContactEmailIsPrivate { get; private set; }
        public VocabularyKey PrimaryContactEmailPurpose { get; private set; }
        public VocabularyKey PrimaryContactFax { get; private set; }
        public VocabularyKey PrimaryContactFaxDescription { get; private set; }
        public VocabularyKey PrimaryContactFaxExtension { get; private set; }
        public VocabularyKey PrimaryContactFaxIsPrivate { get; private set; }
        public VocabularyKey PrimaryContactFaxPurpose { get; private set; }
        public VocabularyKey PrimaryContactPhone { get; private set; }
        public VocabularyKey PrimaryContactPhoneDescription { get; private set; }
        public VocabularyKey PrimaryContactPhoneExtension { get; private set; }
        public VocabularyKey PrimaryContactPhoneIsMobile { get; private set; }
        public VocabularyKey PrimaryContactPhoneIsPrivate { get; private set; }
        public VocabularyKey PrimaryContactPhonePurpose { get; private set; }
        public VocabularyKey PrimaryContactTelex { get; private set; }
        public VocabularyKey PrimaryContactTelexDescription { get; private set; }
        public VocabularyKey PrimaryContactTelexIsPrivate { get; private set; }
        public VocabularyKey PrimaryContactTelexPurpose { get; private set; }
        public VocabularyKey PrimaryContactURL { get; private set; }
        public VocabularyKey PrimaryContactURLDescription { get; private set; }
        public VocabularyKey PrimaryContactURLIsPrivate { get; private set; }
        public VocabularyKey PrimaryContactURLPurpose { get; private set; }
        public VocabularyKey PrimaryContactFacebook { get; private set; }
        public VocabularyKey PrimaryContactFacebookDescription { get; private set; }
        public VocabularyKey PrimaryContactFacebookIsPrivate { get; private set; }
        public VocabularyKey PrimaryContactFacebookPurpose { get; private set; }
        public VocabularyKey PrimaryContactLinkedIn { get; private set; }
        public VocabularyKey PrimaryContactLinkedInDescription { get; private set; }
        public VocabularyKey PrimaryContactLinkedInIsPrivate { get; private set; }
        public VocabularyKey PrimaryContactLinkedInPurpose { get; private set; }
        public VocabularyKey PrimaryContactTwitter { get; private set; }
        public VocabularyKey PrimaryContactTwitterDescription { get; private set; }
        public VocabularyKey PrimaryContactTwitterIsPrivate { get; private set; }
        public VocabularyKey PrimaryContactTwitterPurpose { get; private set; }
        public VocabularyKey ElectronicLocationId { get; private set; }
        public VocabularyKey PrimaryAddressLocation { get; private set; }
        public VocabularyKey IsPrimaryAddressLocationOwner { get; private set; }


    }
}