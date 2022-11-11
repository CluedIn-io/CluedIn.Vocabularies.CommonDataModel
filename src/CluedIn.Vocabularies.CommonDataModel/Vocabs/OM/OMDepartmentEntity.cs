using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OMDepartmentEntityVocabulary : SimpleVocabulary
    {
        public OMDepartmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model OMDepartmentEntity";
            KeyPrefix = "commonDataModel.omdepartmententity";
            KeySeparator = ".";
            Grouping = "/OMDepartmentEntity";

            AddGroup("Common Data Model OMDepartmentEntity Details", group =>
            {
                PartyType = group.Add(new VocabularyKey(nameof(PartyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KnownAs = group.Add(new VocabularyKey(nameof(KnownAs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Memo = group.Add(new VocabularyKey(nameof(Memo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SearchName = group.Add(new VocabularyKey(nameof(SearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationType = group.Add(new VocabularyKey(nameof(OrganizationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitTypes = group.Add(new VocabularyKey(nameof(OperatingUnitTypes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(PrimaryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(PrimaryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressCounty = group.Add(new VocabularyKey(nameof(PrimaryAddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressCity = group.Add(new VocabularyKey(nameof(PrimaryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressDescription = group.Add(new VocabularyKey(nameof(PrimaryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressValidFrom = group.Add(new VocabularyKey(nameof(PrimaryAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressValidTo = group.Add(new VocabularyKey(nameof(PrimaryAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressZipCode = group.Add(new VocabularyKey(nameof(PrimaryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressState = group.Add(new VocabularyKey(nameof(PrimaryAddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressStreet = group.Add(new VocabularyKey(nameof(PrimaryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmail = group.Add(new VocabularyKey(nameof(PrimaryContactEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailIsIM = group.Add(new VocabularyKey(nameof(PrimaryContactEmailIsIM), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFax = group.Add(new VocabularyKey(nameof(PrimaryContactFax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhone = group.Add(new VocabularyKey(nameof(PrimaryContactPhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneExtension = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneIsMobile = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneIsMobile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTelex = group.Add(new VocabularyKey(nameof(PrimaryContactTelex), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactURL = group.Add(new VocabularyKey(nameof(PrimaryContactURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationRoles = group.Add(new VocabularyKey(nameof(AddressLocationRoles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhonePurpose = group.Add(new VocabularyKey(nameof(PrimaryContactPhonePurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactFaxPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactEmailPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTelexPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactTelexPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactURLPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactURLPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailDescription = group.Add(new VocabularyKey(nameof(PrimaryContactEmailDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxDescription = group.Add(new VocabularyKey(nameof(PrimaryContactFaxDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxExtension = group.Add(new VocabularyKey(nameof(PrimaryContactFaxExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneDescription = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTelexDescription = group.Add(new VocabularyKey(nameof(PrimaryContactTelexDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactURLDescription = group.Add(new VocabularyKey(nameof(PrimaryContactURLDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFacebookPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactFacebookPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFacebookIsPrivate = group.Add(new VocabularyKey(nameof(PrimaryContactFacebookIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFacebookDescription = group.Add(new VocabularyKey(nameof(PrimaryContactFacebookDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFacebook = group.Add(new VocabularyKey(nameof(PrimaryContactFacebook), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTwitterPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactTwitterPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTwitterIsPrivate = group.Add(new VocabularyKey(nameof(PrimaryContactTwitterIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTwitterDescription = group.Add(new VocabularyKey(nameof(PrimaryContactTwitterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTwitter = group.Add(new VocabularyKey(nameof(PrimaryContactTwitter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactLinkedInPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactLinkedInPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactLinkedInIsPrivate = group.Add(new VocabularyKey(nameof(PrimaryContactLinkedInIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactLinkedInDescription = group.Add(new VocabularyKey(nameof(PrimaryContactLinkedInDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactLinkedIn = group.Add(new VocabularyKey(nameof(PrimaryContactLinkedIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PartyType { get; private set; }
        public VocabularyKey KnownAs { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Memo { get; private set; }
        public VocabularyKey SearchName { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey OrganizationType { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }
        public VocabularyKey OperatingUnitTypes { get; private set; }
        public VocabularyKey PrimaryAddressCountryRegionId { get; private set; }
        public VocabularyKey PrimaryAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey PrimaryAddressCounty { get; private set; }
        public VocabularyKey PrimaryAddressCity { get; private set; }
        public VocabularyKey PrimaryAddressDescription { get; private set; }
        public VocabularyKey PrimaryAddressValidFrom { get; private set; }
        public VocabularyKey PrimaryAddressValidTo { get; private set; }
        public VocabularyKey PrimaryAddressZipCode { get; private set; }
        public VocabularyKey PrimaryAddressState { get; private set; }
        public VocabularyKey PrimaryAddressStreet { get; private set; }
        public VocabularyKey PrimaryContactEmail { get; private set; }
        public VocabularyKey PrimaryContactEmailIsIM { get; private set; }
        public VocabularyKey PrimaryContactFax { get; private set; }
        public VocabularyKey PrimaryContactPhone { get; private set; }
        public VocabularyKey PrimaryContactPhoneExtension { get; private set; }
        public VocabularyKey PrimaryContactPhoneIsMobile { get; private set; }
        public VocabularyKey PrimaryContactTelex { get; private set; }
        public VocabularyKey PrimaryContactURL { get; private set; }
        public VocabularyKey AddressLocationRoles { get; private set; }
        public VocabularyKey PrimaryContactPhonePurpose { get; private set; }
        public VocabularyKey PrimaryContactFaxPurpose { get; private set; }
        public VocabularyKey PrimaryContactEmailPurpose { get; private set; }
        public VocabularyKey PrimaryContactTelexPurpose { get; private set; }
        public VocabularyKey PrimaryContactURLPurpose { get; private set; }
        public VocabularyKey PrimaryContactEmailDescription { get; private set; }
        public VocabularyKey PrimaryContactFaxDescription { get; private set; }
        public VocabularyKey PrimaryContactFaxExtension { get; private set; }
        public VocabularyKey PrimaryContactPhoneDescription { get; private set; }
        public VocabularyKey PrimaryContactTelexDescription { get; private set; }
        public VocabularyKey PrimaryContactURLDescription { get; private set; }
        public VocabularyKey PrimaryContactFacebookPurpose { get; private set; }
        public VocabularyKey PrimaryContactFacebookIsPrivate { get; private set; }
        public VocabularyKey PrimaryContactFacebookDescription { get; private set; }
        public VocabularyKey PrimaryContactFacebook { get; private set; }
        public VocabularyKey PrimaryContactTwitterPurpose { get; private set; }
        public VocabularyKey PrimaryContactTwitterIsPrivate { get; private set; }
        public VocabularyKey PrimaryContactTwitterDescription { get; private set; }
        public VocabularyKey PrimaryContactTwitter { get; private set; }
        public VocabularyKey PrimaryContactLinkedInPurpose { get; private set; }
        public VocabularyKey PrimaryContactLinkedInIsPrivate { get; private set; }
        public VocabularyKey PrimaryContactLinkedInDescription { get; private set; }
        public VocabularyKey PrimaryContactLinkedIn { get; private set; }


    }
}