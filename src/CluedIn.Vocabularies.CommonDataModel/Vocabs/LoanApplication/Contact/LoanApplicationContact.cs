using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LoanApplicationContactVocabulary : SimpleVocabulary
    {
        public LoanApplicationContactVocabulary()
        {
            VocabularyName = "Loan Application Contact";
            KeyPrefix = "commonDataModel.loanapplicationcontact";
            KeySeparator = ".";
            Grouping = "/LoanApplicationContact";

            AddGroup("LoanApplicationContact Details", group =>
            {
                LoanApplicationContactId = group.Add(new VocabularyKey(nameof(LoanApplicationContactId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statecode = group.Add(new VocabularyKey(nameof(Statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statuscode = group.Add(new VocabularyKey(nameof(Statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine1 = group.Add(new VocabularyKey(nameof(AddressLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine2 = group.Add(new VocabularyKey(nameof(AddressLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine3 = group.Add(new VocabularyKey(nameof(AddressLine3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetsLiabilitiesVerificationStatus = group.Add(new VocabularyKey(nameof(AssetsLiabilitiesVerificationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Birthday = group.Add(new VocabularyKey(nameof(Birthday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactVerificationStatus = group.Add(new VocabularyKey(nameof(ContactVerificationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                County = group.Add(new VocabularyKey(nameof(County), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dependents = group.Add(new VocabularyKey(nameof(Dependents), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DependentsYears = group.Add(new VocabularyKey(nameof(DependentsYears), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DonotallowEmails = group.Add(new VocabularyKey(nameof(DonotallowEmails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DonotallowTextMessages = group.Add(new VocabularyKey(nameof(DonotallowTextMessages), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Firstname = group.Add(new VocabularyKey(nameof(Firstname), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Gender = group.Add(new VocabularyKey(nameof(Gender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GovernmentId = group.Add(new VocabularyKey(nameof(GovernmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBorrowerEmployerRelationship = group.Add(new VocabularyKey(nameof(IsBorrowerEmployerRelationship), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastName = group.Add(new VocabularyKey(nameof(LastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoanApplicationRole = group.Add(new VocabularyKey(nameof(LoanApplicationRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Loansinthepast90days = group.Add(new VocabularyKey(nameof(Loansinthepast90days), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaritalStatus = group.Add(new VocabularyKey(nameof(MaritalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberofYearsatPresentAddress = group.Add(new VocabularyKey(nameof(NumberofYearsatPresentAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Phone = group.Add(new VocabularyKey(nameof(Phone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostOfficeBox = group.Add(new VocabularyKey(nameof(PostOfficeBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Prefix = group.Add(new VocabularyKey(nameof(Prefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PresentAddressOwnershipStatus = group.Add(new VocabularyKey(nameof(PresentAddressOwnershipStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryMemberHelper = group.Add(new VocabularyKey(nameof(PrimaryMemberHelper), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateProvince = group.Add(new VocabularyKey(nameof(StateProvince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearsSchool = group.Add(new VocabularyKey(nameof(YearsSchool), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZIPPostalCode = group.Add(new VocabularyKey(nameof(ZIPPostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimaryBorrower = group.Add(new VocabularyKey(nameof(IsPrimaryBorrower), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LoanApplicationContactId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AddressLine1 { get; private set; }
        public VocabularyKey AddressLine2 { get; private set; }
        public VocabularyKey AddressLine3 { get; private set; }
        public VocabularyKey AssetsLiabilitiesVerificationStatus { get; private set; }
        public VocabularyKey Birthday { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey ContactVerificationStatus { get; private set; }
        public VocabularyKey CountryRegion { get; private set; }
        public VocabularyKey County { get; private set; }
        public VocabularyKey Dependents { get; private set; }
        public VocabularyKey DependentsYears { get; private set; }
        public VocabularyKey DonotallowEmails { get; private set; }
        public VocabularyKey DonotallowTextMessages { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey Firstname { get; private set; }
        public VocabularyKey Gender { get; private set; }
        public VocabularyKey GovernmentId { get; private set; }
        public VocabularyKey IsBorrowerEmployerRelationship { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey LoanApplicationRole { get; private set; }
        public VocabularyKey Loansinthepast90days { get; private set; }
        public VocabularyKey MaritalStatus { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey NumberofYearsatPresentAddress { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey PostOfficeBox { get; private set; }
        public VocabularyKey Prefix { get; private set; }
        public VocabularyKey PresentAddressOwnershipStatus { get; private set; }
        public VocabularyKey PrimaryMemberHelper { get; private set; }
        public VocabularyKey StateProvince { get; private set; }
        public VocabularyKey YearsSchool { get; private set; }
        public VocabularyKey ZIPPostalCode { get; private set; }
        public VocabularyKey IsPrimaryBorrower { get; private set; }
    }
}