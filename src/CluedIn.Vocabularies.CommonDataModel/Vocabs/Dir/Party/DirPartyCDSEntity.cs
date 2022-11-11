using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DirPartyCDSEntityVocabulary : SimpleVocabulary
    {
        public DirPartyCDSEntityVocabulary()
        {
            VocabularyName = "DirPartyCDSEntity";
            KeyPrefix = "commonDataModel.dirpartycdsentity";
            KeySeparator = ".";
            Grouping = "/DirPartyCDSEntity";

            AddGroup("DirPartyCDSEntity Details", group =>
            {
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyType = group.Add(new VocabularyKey(nameof(PartyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameAlias = group.Add(new VocabularyKey(nameof(NameAlias), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KnownAs = group.Add(new VocabularyKey(nameof(KnownAs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                PersonPhoneticMiddleName = group.Add(new VocabularyKey(nameof(PersonPhoneticMiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonPhoneticLastName = group.Add(new VocabularyKey(nameof(PersonPhoneticLastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                DirPersonNameRecId = group.Add(new VocabularyKey(nameof(DirPersonNameRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey PartyType { get; private set; }
        public VocabularyKey NameAlias { get; private set; }
        public VocabularyKey KnownAs { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
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
        public VocabularyKey PersonPhoneticMiddleName { get; private set; }
        public VocabularyKey PersonPhoneticLastName { get; private set; }
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
        public VocabularyKey DirPersonNameRecId { get; private set; }


    }
}