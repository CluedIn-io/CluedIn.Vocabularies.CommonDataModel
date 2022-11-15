using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendProspectiveVendorRegistrationEntityVocabulary : SimpleVocabulary
    {
        public VendProspectiveVendorRegistrationEntityVocabulary()
        {
            VocabularyName = "Vend Prospective Vendor Registration Entity";
            KeyPrefix = "commonDataModel.vendprospectivevendorregistrationentity";
            KeySeparator = ".";
            Grouping = "/VendProspectiveVendorRegistrationEntity";

            AddGroup("VendProspectiveVendorRegistrationEntity Details", group =>
            {
                AreTermsAndConditionsAccepted = group.Add(new VocabularyKey(nameof(AreTermsAndConditionsAccepted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DoingBusinessAs = group.Add(new VocabularyKey(nameof(DoingBusinessAs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyEmailAddress = group.Add(new VocabularyKey(nameof(CompanyEmailAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFemaleOwned = group.Add(new VocabularyKey(nameof(IsFemaleOwned), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLocallyOwned = group.Add(new VocabularyKey(nameof(IsLocallyOwned), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMinorityOwned = group.Add(new VocabularyKey(nameof(IsMinorityOwned), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfEmployees = group.Add(new VocabularyKey(nameof(NumberOfEmployees), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationNumber = group.Add(new VocabularyKey(nameof(OrganizationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationType = group.Add(new VocabularyKey(nameof(OrganizationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyPhoneNumber = group.Add(new VocabularyKey(nameof(CompanyPhoneNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSmallBusiness = group.Add(new VocabularyKey(nameof(IsSmallBusiness), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099Fields = group.Add(new VocabularyKey(nameof(Tax1099Fields), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyFaxNumber = group.Add(new VocabularyKey(nameof(CompanyFaxNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyTaxExemptNumber = group.Add(new VocabularyKey(nameof(CompanyTaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyWebsiteURL = group.Add(new VocabularyKey(nameof(CompanyWebsiteURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiretId = group.Add(new VocabularyKey(nameof(SiretId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NAFCode = group.Add(new VocabularyKey(nameof(NAFCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Federal1099Number = group.Add(new VocabularyKey(nameof(Federal1099Number), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Federal1099NumberType = group.Add(new VocabularyKey(nameof(Federal1099NumberType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCode = group.Add(new VocabularyKey(nameof(FiscalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForeignOwnershipIndicator = group.Add(new VocabularyKey(nameof(ForeignOwnershipIndicator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineOfBusiness = group.Add(new VocabularyKey(nameof(LineOfBusiness), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NationalRegistryNumber = group.Add(new VocabularyKey(nameof(NationalRegistryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsName = group.Add(new VocabularyKey(nameof(PaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099NameChoice = group.Add(new VocabularyKey(nameof(Tax1099NameChoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099GVendorStateId = group.Add(new VocabularyKey(nameof(Tax1099GVendorStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099GVendorStateTaxId = group.Add(new VocabularyKey(nameof(Tax1099GVendorStateTaxId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxStateIdentifierType = group.Add(new VocabularyKey(nameof(TaxStateIdentifierType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRegistrationRequestSubmitted = group.Add(new VocabularyKey(nameof(IsRegistrationRequestSubmitted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorGroupId = group.Add(new VocabularyKey(nameof(VendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonPhoneNumber = group.Add(new VocabularyKey(nameof(ContactPersonPhoneNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyName = group.Add(new VocabularyKey(nameof(CompanyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonEmailAddress = group.Add(new VocabularyKey(nameof(ContactPersonEmailAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorRegistrationId = group.Add(new VocabularyKey(nameof(VendorRegistrationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AreTermsAndConditionsAccepted { get; private set; }
        public VocabularyKey DoingBusinessAs { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey CompanyEmailAddress { get; private set; }
        public VocabularyKey IsFemaleOwned { get; private set; }
        public VocabularyKey IsLocallyOwned { get; private set; }
        public VocabularyKey IsMinorityOwned { get; private set; }
        public VocabularyKey NumberOfEmployees { get; private set; }
        public VocabularyKey OrganizationNumber { get; private set; }
        public VocabularyKey OrganizationType { get; private set; }
        public VocabularyKey CompanyPhoneNumber { get; private set; }
        public VocabularyKey IsSmallBusiness { get; private set; }
        public VocabularyKey Tax1099Fields { get; private set; }
        public VocabularyKey CompanyFaxNumber { get; private set; }
        public VocabularyKey CompanyTaxExemptNumber { get; private set; }
        public VocabularyKey CompanyWebsiteURL { get; private set; }
        public VocabularyKey SiretId { get; private set; }
        public VocabularyKey NAFCode { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey Federal1099Number { get; private set; }
        public VocabularyKey Federal1099NumberType { get; private set; }
        public VocabularyKey FiscalCode { get; private set; }
        public VocabularyKey ForeignOwnershipIndicator { get; private set; }
        public VocabularyKey LineOfBusiness { get; private set; }
        public VocabularyKey NationalRegistryNumber { get; private set; }
        public VocabularyKey PaymentTermsName { get; private set; }
        public VocabularyKey Tax1099NameChoice { get; private set; }
        public VocabularyKey Tax1099GVendorStateId { get; private set; }
        public VocabularyKey Tax1099GVendorStateTaxId { get; private set; }
        public VocabularyKey TaxStateIdentifierType { get; private set; }
        public VocabularyKey IsRegistrationRequestSubmitted { get; private set; }
        public VocabularyKey VendorGroupId { get; private set; }
        public VocabularyKey ContactPersonPhoneNumber { get; private set; }
        public VocabularyKey CompanyName { get; private set; }
        public VocabularyKey ContactPersonEmailAddress { get; private set; }
        public VocabularyKey VendorRegistrationId { get; private set; }
    }
}