using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DirPersonEntityVocabulary : SimpleVocabulary
    {
        public DirPersonEntityVocabulary()
        {
            VocabularyName = "Common Data Model DirPersonEntity";
            KeyPrefix = "commonDataModel.dirpersonentity";
            KeySeparator = ".";
            Grouping = "/DirPersonEntity";

            AddGroup("Common Data Model DirPersonEntity Details", group =>
            {
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameAlias = group.Add(new VocabularyKey(nameof(NameAlias), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KnownAs = group.Add(new VocabularyKey(nameof(KnownAs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBooks = group.Add(new VocabularyKey(nameof(AddressBooks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AnniversaryDay = group.Add(new VocabularyKey(nameof(AnniversaryDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AnniversaryMonth = group.Add(new VocabularyKey(nameof(AnniversaryMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AnniversaryYear = group.Add(new VocabularyKey(nameof(AnniversaryYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BirthDay = group.Add(new VocabularyKey(nameof(BirthDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BirthMonth = group.Add(new VocabularyKey(nameof(BirthMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BirthYear = group.Add(new VocabularyKey(nameof(BirthYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChildrenNames = group.Add(new VocabularyKey(nameof(ChildrenNames), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Gender = group.Add(new VocabularyKey(nameof(Gender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Hobbies = group.Add(new VocabularyKey(nameof(Hobbies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Initials = group.Add(new VocabularyKey(nameof(Initials), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaritalStatus = group.Add(new VocabularyKey(nameof(MaritalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneticFirstName = group.Add(new VocabularyKey(nameof(PhoneticFirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneticLastName = group.Add(new VocabularyKey(nameof(PhoneticLastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneticMiddleName = group.Add(new VocabularyKey(nameof(PhoneticMiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonalSuffix = group.Add(new VocabularyKey(nameof(PersonalSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonalTitle = group.Add(new VocabularyKey(nameof(PersonalTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfessionalSuffix = group.Add(new VocabularyKey(nameof(ProfessionalSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfessionalTitle = group.Add(new VocabularyKey(nameof(ProfessionalTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullPrimaryAddress = group.Add(new VocabularyKey(nameof(FullPrimaryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(AddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCounty = group.Add(new VocabularyKey(nameof(AddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationId = group.Add(new VocabularyKey(nameof(AddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationRoles = group.Add(new VocabularyKey(nameof(AddressLocationRoles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressTimeZone = group.Add(new VocabularyKey(nameof(AddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressIsPrivate = group.Add(new VocabularyKey(nameof(AddressIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmail = group.Add(new VocabularyKey(nameof(PrimaryContactEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailDescription = group.Add(new VocabularyKey(nameof(PrimaryContactEmailDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailIsIM = group.Add(new VocabularyKey(nameof(PrimaryContactEmailIsIM), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactEmailPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFax = group.Add(new VocabularyKey(nameof(PrimaryContactFax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxDescription = group.Add(new VocabularyKey(nameof(PrimaryContactFaxDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxExtension = group.Add(new VocabularyKey(nameof(PrimaryContactFaxExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactFaxPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhone = group.Add(new VocabularyKey(nameof(PrimaryContactPhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneDescription = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneExtension = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneIsMobile = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneIsMobile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhonePurpose = group.Add(new VocabularyKey(nameof(PrimaryContactPhonePurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTelex = group.Add(new VocabularyKey(nameof(PrimaryContactTelex), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTelexDescription = group.Add(new VocabularyKey(nameof(PrimaryContactTelexDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTelexPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactTelexPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactURL = group.Add(new VocabularyKey(nameof(PrimaryContactURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactURLDescription = group.Add(new VocabularyKey(nameof(PrimaryContactURLDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                PartyType = group.Add(new VocabularyKey(nameof(PartyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameSequenceDisplayAs = group.Add(new VocabularyKey(nameof(NameSequenceDisplayAs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstName = group.Add(new VocabularyKey(nameof(FirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastNamePrefix = group.Add(new VocabularyKey(nameof(LastNamePrefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastName = group.Add(new VocabularyKey(nameof(LastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonNameValidFrom = group.Add(new VocabularyKey(nameof(PersonNameValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonNameValidTo = group.Add(new VocabularyKey(nameof(PersonNameValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicLocationId = group.Add(new VocabularyKey(nameof(ElectronicLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NameAlias { get; private set; }
        public VocabularyKey KnownAs { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey AddressBooks { get; private set; }
        public VocabularyKey AnniversaryDay { get; private set; }
        public VocabularyKey AnniversaryMonth { get; private set; }
        public VocabularyKey AnniversaryYear { get; private set; }
        public VocabularyKey BirthDay { get; private set; }
        public VocabularyKey BirthMonth { get; private set; }
        public VocabularyKey BirthYear { get; private set; }
        public VocabularyKey ChildrenNames { get; private set; }
        public VocabularyKey Gender { get; private set; }
        public VocabularyKey Hobbies { get; private set; }
        public VocabularyKey Initials { get; private set; }
        public VocabularyKey MaritalStatus { get; private set; }
        public VocabularyKey PhoneticFirstName { get; private set; }
        public VocabularyKey PhoneticLastName { get; private set; }
        public VocabularyKey PhoneticMiddleName { get; private set; }
        public VocabularyKey PersonalSuffix { get; private set; }
        public VocabularyKey PersonalTitle { get; private set; }
        public VocabularyKey ProfessionalSuffix { get; private set; }
        public VocabularyKey ProfessionalTitle { get; private set; }
        public VocabularyKey FullPrimaryAddress { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressCountryRegionId { get; private set; }
        public VocabularyKey AddressCountryRegionISOCode { get; private set; }
        public VocabularyKey AddressCounty { get; private set; }
        public VocabularyKey AddressDistrictName { get; private set; }
        public VocabularyKey AddressLatitude { get; private set; }
        public VocabularyKey AddressLocationId { get; private set; }
        public VocabularyKey AddressLocationRoles { get; private set; }
        public VocabularyKey AddressLongitude { get; private set; }
        public VocabularyKey AddressState { get; private set; }
        public VocabularyKey AddressStreet { get; private set; }
        public VocabularyKey AddressTimeZone { get; private set; }
        public VocabularyKey AddressValidFrom { get; private set; }
        public VocabularyKey AddressValidTo { get; private set; }
        public VocabularyKey AddressZipCode { get; private set; }
        public VocabularyKey AddressIsPrivate { get; private set; }
        public VocabularyKey AddressDescription { get; private set; }
        public VocabularyKey PrimaryContactEmail { get; private set; }
        public VocabularyKey PrimaryContactEmailDescription { get; private set; }
        public VocabularyKey PrimaryContactEmailIsIM { get; private set; }
        public VocabularyKey PrimaryContactEmailPurpose { get; private set; }
        public VocabularyKey PrimaryContactFax { get; private set; }
        public VocabularyKey PrimaryContactFaxDescription { get; private set; }
        public VocabularyKey PrimaryContactFaxExtension { get; private set; }
        public VocabularyKey PrimaryContactFaxPurpose { get; private set; }
        public VocabularyKey PrimaryContactPhone { get; private set; }
        public VocabularyKey PrimaryContactPhoneDescription { get; private set; }
        public VocabularyKey PrimaryContactPhoneExtension { get; private set; }
        public VocabularyKey PrimaryContactPhoneIsMobile { get; private set; }
        public VocabularyKey PrimaryContactPhonePurpose { get; private set; }
        public VocabularyKey PrimaryContactTelex { get; private set; }
        public VocabularyKey PrimaryContactTelexDescription { get; private set; }
        public VocabularyKey PrimaryContactTelexPurpose { get; private set; }
        public VocabularyKey PrimaryContactURL { get; private set; }
        public VocabularyKey PrimaryContactURLDescription { get; private set; }
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
        public VocabularyKey PartyType { get; private set; }
        public VocabularyKey NameSequenceDisplayAs { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey LastNamePrefix { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey PersonNameValidFrom { get; private set; }
        public VocabularyKey PersonNameValidTo { get; private set; }
        public VocabularyKey ElectronicLocationId { get; private set; }


    }
}