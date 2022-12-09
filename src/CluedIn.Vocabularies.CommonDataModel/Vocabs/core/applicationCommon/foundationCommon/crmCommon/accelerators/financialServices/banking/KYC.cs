using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class KYCVocabulary : SimpleVocabulary
    {
        public KYCVocabulary()
        {
            VocabularyName = "KYC";
            KeyPrefix = "commonDataModel.kyc";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.KYC;

            AddGroup("KYC Details for Banking", group =>
            {
			    AdditionalNationality = group.Add(new VocabularyKey(nameof(AdditionalNationality), "Additional Nationality", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BusinessLicenseExpiryDate = group.Add(new VocabularyKey(nameof(BusinessLicenseExpiryDate), "Business License Expiry Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BusinessLicenseNumber = group.Add(new VocabularyKey(nameof(BusinessLicenseNumber), "Business License Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ControllingUSCitizenOrTaxResident = group.Add(new VocabularyKey(nameof(ControllingUSCitizenOrTaxResident), "Controlling US Citizen or Tax Resident", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    CountryOfBirth = group.Add(new VocabularyKey(nameof(CountryOfBirth), "Country of Birth", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    CountryOfResidence = group.Add(new VocabularyKey(nameof(CountryOfResidence), "Country of Residence", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    DateOfBirth = group.Add(new VocabularyKey(nameof(DateOfBirth), "Date of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Email = group.Add(new VocabularyKey(nameof(Email), "Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    FirstName = group.Add(new VocabularyKey(nameof(FirstName), "First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IDExpiryDate = group.Add(new VocabularyKey(nameof(IDExpiryDate), "ID Expiry Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IDNumber = group.Add(new VocabularyKey(nameof(IDNumber), "ID Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IDType = group.Add(new VocabularyKey(nameof(IDType), "ID Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    KYCCountry = group.Add(new VocabularyKey(nameof(KYCCountry), "KYC Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    KYCId = group.Add(new VocabularyKey(nameof(KYCId), "KYC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    KYCPreparedOn = group.Add(new VocabularyKey(nameof(KYCPreparedOn), "KYC Prepared On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastName = group.Add(new VocabularyKey(nameof(LastName), "Last Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), "Middle Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MobileNumber = group.Add(new VocabularyKey(nameof(MobileNumber), "Mobile Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Nationality = group.Add(new VocabularyKey(nameof(Nationality), "Nationality", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NatureOfBusiness = group.Add(new VocabularyKey(nameof(NatureOfBusiness), "Nature of Business", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PhoneNumber = group.Add(new VocabularyKey(nameof(PhoneNumber), "Phone Number", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    PlaceOfBirth = group.Add(new VocabularyKey(nameof(PlaceOfBirth), "Place of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReviewFrequency = group.Add(new VocabularyKey(nameof(ReviewFrequency), "Review Frequency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RiskLevel = group.Add(new VocabularyKey(nameof(RiskLevel), "Risk Level", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    DeprecatedStageId = group.Add(new VocabularyKey(nameof(DeprecatedStageId), "(Deprecated) Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeprecatedTraversedPath = group.Add(new VocabularyKey(nameof(DeprecatedTraversedPath), "(Deprecated) Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="KYCId"/> from Vocab 'CompanyOnboarding.cdm.json/CompanyOnboarding' with Property 'MsfsiKycId'
            ///Property <see cref="KYCId"/> from Vocab 'ContactOnboardingFromProspect.cdm.json/ContactOnboardingFromProspect' with Property 'MsfsiKycId'
            #endregion
        }

        public VocabularyKey AdditionalNationality { get; private set; }
        public VocabularyKey BusinessLicenseExpiryDate { get; private set; }
        public VocabularyKey BusinessLicenseNumber { get; private set; }
        public VocabularyKey ControllingUSCitizenOrTaxResident { get; private set; }
        public VocabularyKey CountryOfBirth { get; private set; }
        public VocabularyKey CountryOfResidence { get; private set; }
        public VocabularyKey DateOfBirth { get; private set; }
        public VocabularyKey DeprecatedStageId { get; private set; }
        public VocabularyKey DeprecatedTraversedPath { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey IDExpiryDate { get; private set; }
        public VocabularyKey IDNumber { get; private set; }
        public VocabularyKey IDType { get; private set; }
        public VocabularyKey KYCCountry { get; private set; }
        public VocabularyKey KYCId { get; private set; }
        public VocabularyKey KYCPreparedOn { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey MobileNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Nationality { get; private set; }
        public VocabularyKey NatureOfBusiness { get; private set; }
        public VocabularyKey PhoneNumber { get; private set; }
        public VocabularyKey PlaceOfBirth { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey ReviewFrequency { get; private set; }
        public VocabularyKey RiskLevel { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}