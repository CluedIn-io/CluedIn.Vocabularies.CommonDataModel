using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmContactPersonCDSV2EntityVocabulary : SimpleVocabulary
    {
        public SmmContactPersonCDSV2EntityVocabulary()
        {
            VocabularyName = "Smm Contact Person CDSV2 Entity";
            KeyPrefix = "commonDataModel.smmcontactpersoncdsv2entity";
            KeySeparator = ".";
            Grouping = "/SmmContactPersonCDSV2Entity";

            AddGroup("SmmContactPersonCDSV2Entity Details", group =>
            {
                ContactPersonPartyNumber = group.Add(new VocabularyKey(nameof(ContactPersonPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssociatedPartyNumber = group.Add(new VocabularyKey(nameof(AssociatedPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BirthDay = group.Add(new VocabularyKey(nameof(BirthDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BirthMonth = group.Add(new VocabularyKey(nameof(BirthMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BirthYear = group.Add(new VocabularyKey(nameof(BirthYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressCity = group.Add(new VocabularyKey(nameof(PrimaryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(PrimaryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(PrimaryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressCountyId = group.Add(new VocabularyKey(nameof(PrimaryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressDescription = group.Add(new VocabularyKey(nameof(PrimaryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressLocationRoles = group.Add(new VocabularyKey(nameof(PrimaryAddressLocationRoles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressStateId = group.Add(new VocabularyKey(nameof(PrimaryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressStreet = group.Add(new VocabularyKey(nameof(PrimaryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressStreetNumber = group.Add(new VocabularyKey(nameof(PrimaryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressZipCode = group.Add(new VocabularyKey(nameof(PrimaryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentDepartment = group.Add(new VocabularyKey(nameof(EmploymentDepartment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Gender = group.Add(new VocabularyKey(nameof(Gender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstName = group.Add(new VocabularyKey(nameof(FirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GovernmentIdentificationNumber = group.Add(new VocabularyKey(nameof(GovernmentIdentificationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReceivingDirectMail = group.Add(new VocabularyKey(nameof(IsReceivingDirectMail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaritalStatus = group.Add(new VocabularyKey(nameof(MaritalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonPartyType = group.Add(new VocabularyKey(nameof(ContactPersonPartyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryEmailAddress = group.Add(new VocabularyKey(nameof(PrimaryEmailAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryPhoneNumber = group.Add(new VocabularyKey(nameof(PrimaryPhoneNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryFaxNumber = group.Add(new VocabularyKey(nameof(PrimaryFaxNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryFacebook = group.Add(new VocabularyKey(nameof(PrimaryFacebook), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryLinkedIn = group.Add(new VocabularyKey(nameof(PrimaryLinkedIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryTwitter = group.Add(new VocabularyKey(nameof(PrimaryTwitter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DecisionMakingRoleCode = group.Add(new VocabularyKey(nameof(DecisionMakingRoleCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentProfession = group.Add(new VocabularyKey(nameof(EmploymentProfession), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInactive = group.Add(new VocabularyKey(nameof(IsInactive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastName = group.Add(new VocabularyKey(nameof(LastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryURL = group.Add(new VocabularyKey(nameof(PrimaryURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(ContactPersonResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsContactPersonExternallyMaintained = group.Add(new VocabularyKey(nameof(IsContactPersonExternallyMaintained), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpouseName = group.Add(new VocabularyKey(nameof(SpouseName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssociatedContactType = group.Add(new VocabularyKey(nameof(AssociatedContactType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssociatedContactNumber = group.Add(new VocabularyKey(nameof(AssociatedContactNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryPostalAddressRecId = group.Add(new VocabularyKey(nameof(PrimaryPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactEmailRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactFaxRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactLinkedInRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactLinkedInRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTwitterRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactTwitterRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFacebookRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactFacebookRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTelexRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactTelexRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactURLRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactURLRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressLocation = group.Add(new VocabularyKey(nameof(PrimaryAddressLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyRecordId = group.Add(new VocabularyKey(nameof(PartyRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ContactPersonPartyNumber { get; private set; }
        public VocabularyKey AssociatedPartyNumber { get; private set; }
        public VocabularyKey BirthDay { get; private set; }
        public VocabularyKey BirthMonth { get; private set; }
        public VocabularyKey BirthYear { get; private set; }
        public VocabularyKey PrimaryAddressCity { get; private set; }
        public VocabularyKey PrimaryAddressCountryRegionId { get; private set; }
        public VocabularyKey PrimaryAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey PrimaryAddressCountyId { get; private set; }
        public VocabularyKey PrimaryAddressDescription { get; private set; }
        public VocabularyKey PrimaryAddressLocationRoles { get; private set; }
        public VocabularyKey PrimaryAddressStateId { get; private set; }
        public VocabularyKey PrimaryAddressStreet { get; private set; }
        public VocabularyKey PrimaryAddressStreetNumber { get; private set; }
        public VocabularyKey PrimaryAddressZipCode { get; private set; }
        public VocabularyKey EmploymentDepartment { get; private set; }
        public VocabularyKey Notes { get; private set; }
        public VocabularyKey Gender { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey GovernmentIdentificationNumber { get; private set; }
        public VocabularyKey IsReceivingDirectMail { get; private set; }
        public VocabularyKey MaritalStatus { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey ContactPersonPartyType { get; private set; }
        public VocabularyKey PrimaryEmailAddress { get; private set; }
        public VocabularyKey PrimaryPhoneNumber { get; private set; }
        public VocabularyKey PrimaryFaxNumber { get; private set; }
        public VocabularyKey PrimaryFacebook { get; private set; }
        public VocabularyKey PrimaryLinkedIn { get; private set; }
        public VocabularyKey PrimaryTwitter { get; private set; }
        public VocabularyKey DecisionMakingRoleCode { get; private set; }
        public VocabularyKey EmploymentProfession { get; private set; }
        public VocabularyKey IsInactive { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey PrimaryURL { get; private set; }
        public VocabularyKey ContactPersonResponsiblePersonnelNumber { get; private set; }
        public VocabularyKey IsContactPersonExternallyMaintained { get; private set; }
        public VocabularyKey SpouseName { get; private set; }
        public VocabularyKey AssociatedContactType { get; private set; }
        public VocabularyKey AssociatedContactNumber { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey PrimaryPostalAddressRecId { get; private set; }
        public VocabularyKey PrimaryContactEmailRecordId { get; private set; }
        public VocabularyKey PrimaryContactFaxRecordId { get; private set; }
        public VocabularyKey PrimaryContactLinkedInRecordId { get; private set; }
        public VocabularyKey PrimaryContactTwitterRecordId { get; private set; }
        public VocabularyKey PrimaryContactFacebookRecordId { get; private set; }
        public VocabularyKey PrimaryContactPhoneRecordId { get; private set; }
        public VocabularyKey PrimaryContactTelexRecordId { get; private set; }
        public VocabularyKey PrimaryContactURLRecordId { get; private set; }
        public VocabularyKey PrimaryAddressLocation { get; private set; }
        public VocabularyKey PartyRecordId { get; private set; }
    }
}