using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmWorkerBaseEntityVocabulary : SimpleVocabulary
    {
        public HcmWorkerBaseEntityVocabulary()
        {
            VocabularyName = "HcmWorkerBaseEntity";
            KeyPrefix = "commonDataModel.hcmworkerbaseentity";
            KeySeparator = ".";
            Grouping = "/HcmWorkerBaseEntity";

            AddGroup("HcmWorkerBaseEntity Details", group =>
            {
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Person = group.Add(new VocabularyKey(nameof(Person), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KnownAs = group.Add(new VocabularyKey(nameof(KnownAs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameAlias = group.Add(new VocabularyKey(nameof(NameAlias), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneticFirstName = group.Add(new VocabularyKey(nameof(PhoneticFirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneticLastName = group.Add(new VocabularyKey(nameof(PhoneticLastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneticMiddleName = group.Add(new VocabularyKey(nameof(PhoneticMiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfessionalSuffix = group.Add(new VocabularyKey(nameof(ProfessionalSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfessionalTitle = group.Add(new VocabularyKey(nameof(ProfessionalTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonalTitle = group.Add(new VocabularyKey(nameof(PersonalTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonalSuffix = group.Add(new VocabularyKey(nameof(PersonalSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BirthDate = group.Add(new VocabularyKey(nameof(BirthDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CitizenshipCountryRegion = group.Add(new VocabularyKey(nameof(CitizenshipCountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NationalityCountryRegion = group.Add(new VocabularyKey(nameof(NationalityCountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeceasedDate = group.Add(new VocabularyKey(nameof(DeceasedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisabledVerificationDate = group.Add(new VocabularyKey(nameof(DisabledVerificationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Education = group.Add(new VocabularyKey(nameof(Education), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EthnicOrigin = group.Add(new VocabularyKey(nameof(EthnicOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EthnicOriginId = group.Add(new VocabularyKey(nameof(EthnicOriginId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FatherBirthCountryRegion = group.Add(new VocabularyKey(nameof(FatherBirthCountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Gender = group.Add(new VocabularyKey(nameof(Gender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDisabled = group.Add(new VocabularyKey(nameof(IsDisabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFulltimeStudent = group.Add(new VocabularyKey(nameof(IsFulltimeStudent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MotherBirthCountryRegion = group.Add(new VocabularyKey(nameof(MotherBirthCountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NativeLanguage = group.Add(new VocabularyKey(nameof(NativeLanguage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NativeLanguageId = group.Add(new VocabularyKey(nameof(NativeLanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonBirthCountryRegion = group.Add(new VocabularyKey(nameof(PersonBirthCountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonBirthCity = group.Add(new VocabularyKey(nameof(PersonBirthCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstName = group.Add(new VocabularyKey(nameof(FirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastNamePrefix = group.Add(new VocabularyKey(nameof(LastNamePrefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastName = group.Add(new VocabularyKey(nameof(LastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameValidFrom = group.Add(new VocabularyKey(nameof(NameValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameValidTo = group.Add(new VocabularyKey(nameof(NameValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyType = group.Add(new VocabularyKey(nameof(PartyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameSequenceDisplayAs = group.Add(new VocabularyKey(nameof(NameSequenceDisplayAs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicLocationId = group.Add(new VocabularyKey(nameof(ElectronicLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowRehire = group.Add(new VocabularyKey(nameof(AllowRehire), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey Person { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey KnownAs { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NameAlias { get; private set; }
        public VocabularyKey PhoneticFirstName { get; private set; }
        public VocabularyKey PhoneticLastName { get; private set; }
        public VocabularyKey PhoneticMiddleName { get; private set; }
        public VocabularyKey ProfessionalSuffix { get; private set; }
        public VocabularyKey ProfessionalTitle { get; private set; }
        public VocabularyKey PersonalTitle { get; private set; }
        public VocabularyKey PersonalSuffix { get; private set; }
        public VocabularyKey BirthDate { get; private set; }
        public VocabularyKey CitizenshipCountryRegion { get; private set; }
        public VocabularyKey NationalityCountryRegion { get; private set; }
        public VocabularyKey DeceasedDate { get; private set; }
        public VocabularyKey DisabledVerificationDate { get; private set; }
        public VocabularyKey Education { get; private set; }
        public VocabularyKey EthnicOrigin { get; private set; }
        public VocabularyKey EthnicOriginId { get; private set; }
        public VocabularyKey FatherBirthCountryRegion { get; private set; }
        public VocabularyKey Gender { get; private set; }
        public VocabularyKey IsDisabled { get; private set; }
        public VocabularyKey IsFulltimeStudent { get; private set; }
        public VocabularyKey MotherBirthCountryRegion { get; private set; }
        public VocabularyKey NativeLanguage { get; private set; }
        public VocabularyKey NativeLanguageId { get; private set; }
        public VocabularyKey PersonBirthCountryRegion { get; private set; }
        public VocabularyKey PersonBirthCity { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey LastNamePrefix { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey NameValidFrom { get; private set; }
        public VocabularyKey NameValidTo { get; private set; }
        public VocabularyKey PartyType { get; private set; }
        public VocabularyKey NameSequenceDisplayAs { get; private set; }
        public VocabularyKey ElectronicLocationId { get; private set; }
        public VocabularyKey AllowRehire { get; private set; }


    }
}