using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmContractorEntityVocabulary : SimpleVocabulary
    {
        public HcmContractorEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmContractorEntity";
            KeyPrefix = "commonDataModel.hcmcontractorentity";
            KeySeparator = ".";
            Grouping = "/HcmContractorEntity";

            AddGroup("Common Data Model HcmContractorEntity Details", group =>
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
                PrimaryAddressLocation = group.Add(new VocabularyKey(nameof(PrimaryAddressLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                ProfessionalSuffix = group.Add(new VocabularyKey(nameof(ProfessionalSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfessionalTitle = group.Add(new VocabularyKey(nameof(ProfessionalTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonalTitle = group.Add(new VocabularyKey(nameof(PersonalTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonalSuffix = group.Add(new VocabularyKey(nameof(PersonalSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Title = group.Add(new VocabularyKey(nameof(Title), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TitleId = group.Add(new VocabularyKey(nameof(TitleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalHireDateTime = group.Add(new VocabularyKey(nameof(OriginalHireDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SeniorityDate = group.Add(new VocabularyKey(nameof(SeniorityDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AnniversaryDateTime = group.Add(new VocabularyKey(nameof(AnniversaryDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfficeLocation = group.Add(new VocabularyKey(nameof(OfficeLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfficeLocationId = group.Add(new VocabularyKey(nameof(OfficeLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SummaryValidFrom = group.Add(new VocabularyKey(nameof(SummaryValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SummaryValidTo = group.Add(new VocabularyKey(nameof(SummaryValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                IsDisabledVeteran = group.Add(new VocabularyKey(nameof(IsDisabledVeteran), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExpatriateRulingApplicable = group.Add(new VocabularyKey(nameof(IsExpatriateRulingApplicable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpatriateRulingValidFrom = group.Add(new VocabularyKey(nameof(ExpatriateRulingValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpatriateRulingValidTo = group.Add(new VocabularyKey(nameof(ExpatriateRulingValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaritalStatus = group.Add(new VocabularyKey(nameof(MaritalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfDependents = group.Add(new VocabularyKey(nameof(NumberOfDependents), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MilitaryServiceStartDate = group.Add(new VocabularyKey(nameof(MilitaryServiceStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MilitaryServiceEndDate = group.Add(new VocabularyKey(nameof(MilitaryServiceEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VeteranStatus = group.Add(new VocabularyKey(nameof(VeteranStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VeteranStatusId = group.Add(new VocabularyKey(nameof(VeteranStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonDetailsValidFrom = group.Add(new VocabularyKey(nameof(PersonDetailsValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonDetailsValidTo = group.Add(new VocabularyKey(nameof(PersonDetailsValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBooks = group.Add(new VocabularyKey(nameof(AddressBooks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(AddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCounty = group.Add(new VocabularyKey(nameof(AddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationId = group.Add(new VocabularyKey(nameof(AddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationRoles = group.Add(new VocabularyKey(nameof(AddressLocationRoles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressNameDescription = group.Add(new VocabularyKey(nameof(AddressNameDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstName = group.Add(new VocabularyKey(nameof(FirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastNamePrefix = group.Add(new VocabularyKey(nameof(LastNamePrefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastName = group.Add(new VocabularyKey(nameof(LastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameValidFrom = group.Add(new VocabularyKey(nameof(NameValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameValidTo = group.Add(new VocabularyKey(nameof(NameValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyType = group.Add(new VocabularyKey(nameof(PartyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameSequenceDisplayAs = group.Add(new VocabularyKey(nameof(NameSequenceDisplayAs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentStartDate = group.Add(new VocabularyKey(nameof(EmploymentStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentEndDate = group.Add(new VocabularyKey(nameof(EmploymentEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentLegalEntity = group.Add(new VocabularyKey(nameof(EmploymentLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentLegalEntityId = group.Add(new VocabularyKey(nameof(EmploymentLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegulatoryEstablishment = group.Add(new VocabularyKey(nameof(RegulatoryEstablishment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegulatoryEstablishmentId = group.Add(new VocabularyKey(nameof(RegulatoryEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdjustedWorkerStartDate = group.Add(new VocabularyKey(nameof(AdjustedWorkerStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastDateWorked = group.Add(new VocabularyKey(nameof(LastDateWorked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TerminationReason = group.Add(new VocabularyKey(nameof(TerminationReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TerminationReasonCodeId = group.Add(new VocabularyKey(nameof(TerminationReasonCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TerminationDate = group.Add(new VocabularyKey(nameof(TerminationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentNoticeEmployerQuantity = group.Add(new VocabularyKey(nameof(EmploymentNoticeEmployerQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentNoticeEmployerUnit = group.Add(new VocabularyKey(nameof(EmploymentNoticeEmployerUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentNoticeWorkerQuantity = group.Add(new VocabularyKey(nameof(EmploymentNoticeWorkerQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentNoticeWorkerUnit = group.Add(new VocabularyKey(nameof(EmploymentNoticeWorkerUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentDetailsEffective = group.Add(new VocabularyKey(nameof(EmploymentDetailsEffective), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentDetailsExpiration = group.Add(new VocabularyKey(nameof(EmploymentDetailsExpiration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicLocationId = group.Add(new VocabularyKey(nameof(ElectronicLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowRehire = group.Add(new VocabularyKey(nameof(AllowRehire), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorksFromHome = group.Add(new VocabularyKey(nameof(WorksFromHome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractorVendorDataAreaID = group.Add(new VocabularyKey(nameof(ContractorVendorDataAreaID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractorVendorDataArea = group.Add(new VocabularyKey(nameof(ContractorVendorDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractorVendorId = group.Add(new VocabularyKey(nameof(ContractorVendorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractorPurchaseRequisitionId = group.Add(new VocabularyKey(nameof(ContractorPurchaseRequisitionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractorPurchaseOrderId = group.Add(new VocabularyKey(nameof(ContractorPurchaseOrderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractorDetailsEffective = group.Add(new VocabularyKey(nameof(ContractorDetailsEffective), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractorDetailsExpiration = group.Add(new VocabularyKey(nameof(ContractorDetailsExpiration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalendarDataAreaId = group.Add(new VocabularyKey(nameof(CalendarDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

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
        public VocabularyKey PrimaryAddressLocation { get; private set; }
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
        public VocabularyKey ProfessionalSuffix { get; private set; }
        public VocabularyKey ProfessionalTitle { get; private set; }
        public VocabularyKey PersonalTitle { get; private set; }
        public VocabularyKey PersonalSuffix { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey TitleId { get; private set; }
        public VocabularyKey OriginalHireDateTime { get; private set; }
        public VocabularyKey SeniorityDate { get; private set; }
        public VocabularyKey AnniversaryDateTime { get; private set; }
        public VocabularyKey OfficeLocation { get; private set; }
        public VocabularyKey OfficeLocationId { get; private set; }
        public VocabularyKey SummaryValidFrom { get; private set; }
        public VocabularyKey SummaryValidTo { get; private set; }
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
        public VocabularyKey IsDisabledVeteran { get; private set; }
        public VocabularyKey IsExpatriateRulingApplicable { get; private set; }
        public VocabularyKey ExpatriateRulingValidFrom { get; private set; }
        public VocabularyKey ExpatriateRulingValidTo { get; private set; }
        public VocabularyKey MaritalStatus { get; private set; }
        public VocabularyKey NumberOfDependents { get; private set; }
        public VocabularyKey MilitaryServiceStartDate { get; private set; }
        public VocabularyKey MilitaryServiceEndDate { get; private set; }
        public VocabularyKey VeteranStatus { get; private set; }
        public VocabularyKey VeteranStatusId { get; private set; }
        public VocabularyKey PersonDetailsValidFrom { get; private set; }
        public VocabularyKey PersonDetailsValidTo { get; private set; }
        public VocabularyKey AddressBooks { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressCountryRegionId { get; private set; }
        public VocabularyKey AddressCountryRegionISOCode { get; private set; }
        public VocabularyKey AddressCounty { get; private set; }
        public VocabularyKey AddressDistrictName { get; private set; }
        public VocabularyKey AddressLocationId { get; private set; }
        public VocabularyKey AddressLocationRoles { get; private set; }
        public VocabularyKey AddressNameDescription { get; private set; }
        public VocabularyKey AddressState { get; private set; }
        public VocabularyKey AddressStreet { get; private set; }
        public VocabularyKey AddressZipCode { get; private set; }
        public VocabularyKey AddressValidFrom { get; private set; }
        public VocabularyKey AddressValidTo { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey LastNamePrefix { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey NameValidFrom { get; private set; }
        public VocabularyKey NameValidTo { get; private set; }
        public VocabularyKey PartyType { get; private set; }
        public VocabularyKey NameSequenceDisplayAs { get; private set; }
        public VocabularyKey EmploymentStartDate { get; private set; }
        public VocabularyKey EmploymentEndDate { get; private set; }
        public VocabularyKey EmploymentLegalEntity { get; private set; }
        public VocabularyKey EmploymentLegalEntityId { get; private set; }
        public VocabularyKey RegulatoryEstablishment { get; private set; }
        public VocabularyKey RegulatoryEstablishmentId { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey AdjustedWorkerStartDate { get; private set; }
        public VocabularyKey LastDateWorked { get; private set; }
        public VocabularyKey TerminationReason { get; private set; }
        public VocabularyKey TerminationReasonCodeId { get; private set; }
        public VocabularyKey TerminationDate { get; private set; }
        public VocabularyKey EmploymentNoticeEmployerQuantity { get; private set; }
        public VocabularyKey EmploymentNoticeEmployerUnit { get; private set; }
        public VocabularyKey EmploymentNoticeWorkerQuantity { get; private set; }
        public VocabularyKey EmploymentNoticeWorkerUnit { get; private set; }
        public VocabularyKey EmploymentDetailsEffective { get; private set; }
        public VocabularyKey EmploymentDetailsExpiration { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey ElectronicLocationId { get; private set; }
        public VocabularyKey AllowRehire { get; private set; }
        public VocabularyKey WorksFromHome { get; private set; }
        public VocabularyKey ContractorVendorDataAreaID { get; private set; }
        public VocabularyKey ContractorVendorDataArea { get; private set; }
        public VocabularyKey ContractorVendorId { get; private set; }
        public VocabularyKey ContractorPurchaseRequisitionId { get; private set; }
        public VocabularyKey ContractorPurchaseOrderId { get; private set; }
        public VocabularyKey ContractorDetailsEffective { get; private set; }
        public VocabularyKey ContractorDetailsExpiration { get; private set; }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey CalendarDataAreaId { get; private set; }


    }
}