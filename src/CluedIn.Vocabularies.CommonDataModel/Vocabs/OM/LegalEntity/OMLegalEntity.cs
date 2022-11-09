using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OMLegalEntityVocabulary : SimpleVocabulary
    {
        public OMLegalEntityVocabulary()
        {
            VocabularyName = "Common Data Model OMLegalEntity";
            KeyPrefix = "commonDataModel.omlegalentity";
            KeySeparator = ".";
            Grouping = "/OMLegalEntity";

            AddGroup("Common Data Model OMLegalEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NameAlias = group.Add(new VocabularyKey(nameof(NameAlias), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressBooks = group.Add(new VocabularyKey(nameof(AddressBooks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FullPrimaryAddress = group.Add(new VocabularyKey(nameof(FullPrimaryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(AddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCounty = group.Add(new VocabularyKey(nameof(AddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLocationRoles = group.Add(new VocabularyKey(nameof(AddressLocationRoles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressTimeZone = group.Add(new VocabularyKey(nameof(AddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PartyType = group.Add(new VocabularyKey(nameof(PartyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PhoneticName = group.Add(new VocabularyKey(nameof(PhoneticName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingPersonnel = group.Add(new VocabularyKey(nameof(AccountingPersonnel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompanyRepresentative = group.Add(new VocabularyKey(nameof(CompanyRepresentative), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartDateOfBusiness = group.Add(new VocabularyKey(nameof(StartDateOfBusiness), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InitialCapitalInvestment = group.Add(new VocabularyKey(nameof(InitialCapitalInvestment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BusinessItem = group.Add(new VocabularyKey(nameof(BusinessItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CertifiedTaxAccountantName = group.Add(new VocabularyKey(nameof(CertifiedTaxAccountantName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalLegalRepresentativeName = group.Add(new VocabularyKey(nameof(ExternalLegalRepresentativeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonInCharge = group.Add(new VocabularyKey(nameof(PersonInCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountsOfficeReferenceNumber = group.Add(new VocabularyKey(nameof(AccountsOfficeReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommerceRegistration = group.Add(new VocabularyKey(nameof(CommerceRegistration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalForm = group.Add(new VocabularyKey(nameof(LegalForm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DNBRoutingNumber = group.Add(new VocabularyKey(nameof(DNBRoutingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TraderNumber = group.Add(new VocabularyKey(nameof(TraderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FICreditorID = group.Add(new VocabularyKey(nameof(FICreditorID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NationalRegistryNumber = group.Add(new VocabularyKey(nameof(NationalRegistryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrintCorrectiveInvoice = group.Add(new VocabularyKey(nameof(PrintCorrectiveInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrintCorrectiveInvoiceStartingDate = group.Add(new VocabularyKey(nameof(PrintCorrectiveInvoiceStartingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompanyType = group.Add(new VocabularyKey(nameof(CompanyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurpNumber = group.Add(new VocabularyKey(nameof(CurpNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurpLegalRepresentative = group.Add(new VocabularyKey(nameof(CurpLegalRepresentative), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalRepresentativeName = group.Add(new VocabularyKey(nameof(LegalRepresentativeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RfcLegalRepresentative = group.Add(new VocabularyKey(nameof(RfcLegalRepresentative), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Rfc = group.Add(new VocabularyKey(nameof(Rfc), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StateInscription = group.Add(new VocabularyKey(nameof(StateInscription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NationalClassificationOfCompanyEconomicActivity = group.Add(new VocabularyKey(nameof(NationalClassificationOfCompanyEconomicActivity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressLocationId = group.Add(new VocabularyKey(nameof(PrimaryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RegistrationNumber = group.Add(new VocabularyKey(nameof(RegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SoftwareIdentificationCode = group.Add(new VocabularyKey(nameof(SoftwareIdentificationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalCode = group.Add(new VocabularyKey(nameof(FiscalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalNature = group.Add(new VocabularyKey(nameof(LegalNature), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CUC = group.Add(new VocabularyKey(nameof(CUC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompanyName = group.Add(new VocabularyKey(nameof(CompanyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompanyCountry = group.Add(new VocabularyKey(nameof(CompanyCountry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportFolder = group.Add(new VocabularyKey(nameof(ReportFolder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrintINNKPPInAddress = group.Add(new VocabularyKey(nameof(PrintINNKPPInAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrintEnterpriseRegister = group.Add(new VocabularyKey(nameof(PrintEnterpriseRegister), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NAICS = group.Add(new VocabularyKey(nameof(NAICS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseForFinancialConsolidationProcess = group.Add(new VocabularyKey(nameof(UseForFinancialConsolidationProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseForFinancialEliminationProcess = group.Add(new VocabularyKey(nameof(UseForFinancialEliminationProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LocalizationCountryRegionCode = group.Add(new VocabularyKey(nameof(LocalizationCountryRegionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VATNum = group.Add(new VocabularyKey(nameof(VATNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ImportVATNum = group.Add(new VocabularyKey(nameof(ImportVATNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProfitMarginScheme = group.Add(new VocabularyKey(nameof(ProfitMarginScheme), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VATRefund = group.Add(new VocabularyKey(nameof(VATRefund), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VATOnCustomerBehalf = group.Add(new VocabularyKey(nameof(VATOnCustomerBehalf), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey NameAlias { get; private set; }
public VocabularyKey PartyNumber { get; private set; }
public VocabularyKey AddressBooks { get; private set; }
public VocabularyKey LanguageId { get; private set; }
public VocabularyKey FullPrimaryAddress { get; private set; }
public VocabularyKey AddressDescription { get; private set; }
public VocabularyKey AddressZipCode { get; private set; }
public VocabularyKey AddressCity { get; private set; }
public VocabularyKey AddressCountryRegionId { get; private set; }
public VocabularyKey AddressCountryRegionISOCode { get; private set; }
public VocabularyKey AddressCounty { get; private set; }
public VocabularyKey AddressDistrictName { get; private set; }
public VocabularyKey AddressLatitude { get; private set; }
public VocabularyKey AddressLocationRoles { get; private set; }
public VocabularyKey AddressLongitude { get; private set; }
public VocabularyKey AddressState { get; private set; }
public VocabularyKey AddressStreet { get; private set; }
public VocabularyKey AddressTimeZone { get; private set; }
public VocabularyKey AddressValidFrom { get; private set; }
public VocabularyKey AddressValidTo { get; private set; }
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
public VocabularyKey LegalEntityId { get; private set; }
public VocabularyKey PartyType { get; private set; }
public VocabularyKey PhoneticName { get; private set; }
public VocabularyKey AccountingPersonnel { get; private set; }
public VocabularyKey CompanyRepresentative { get; private set; }
public VocabularyKey StartDateOfBusiness { get; private set; }
public VocabularyKey InitialCapitalInvestment { get; private set; }
public VocabularyKey BusinessItem { get; private set; }
public VocabularyKey CertifiedTaxAccountantName { get; private set; }
public VocabularyKey ExternalLegalRepresentativeName { get; private set; }
public VocabularyKey PersonInCharge { get; private set; }
public VocabularyKey AccountsOfficeReferenceNumber { get; private set; }
public VocabularyKey CommerceRegistration { get; private set; }
public VocabularyKey LegalForm { get; private set; }
public VocabularyKey DNBRoutingNumber { get; private set; }
public VocabularyKey TraderNumber { get; private set; }
public VocabularyKey FICreditorID { get; private set; }
public VocabularyKey NationalRegistryNumber { get; private set; }
public VocabularyKey PrintCorrectiveInvoice { get; private set; }
public VocabularyKey PrintCorrectiveInvoiceStartingDate { get; private set; }
public VocabularyKey CompanyType { get; private set; }
public VocabularyKey CurpNumber { get; private set; }
public VocabularyKey CurpLegalRepresentative { get; private set; }
public VocabularyKey LegalRepresentativeName { get; private set; }
public VocabularyKey RfcLegalRepresentative { get; private set; }
public VocabularyKey Rfc { get; private set; }
public VocabularyKey StateInscription { get; private set; }
public VocabularyKey NationalClassificationOfCompanyEconomicActivity { get; private set; }
public VocabularyKey PrimaryAddressLocationId { get; private set; }
public VocabularyKey RegistrationNumber { get; private set; }
public VocabularyKey SoftwareIdentificationCode { get; private set; }
public VocabularyKey FiscalCode { get; private set; }
public VocabularyKey LegalNature { get; private set; }
public VocabularyKey CUC { get; private set; }
public VocabularyKey CompanyName { get; private set; }
public VocabularyKey CompanyCountry { get; private set; }
public VocabularyKey ReportFolder { get; private set; }
public VocabularyKey PrintINNKPPInAddress { get; private set; }
public VocabularyKey PrintEnterpriseRegister { get; private set; }
public VocabularyKey NAICS { get; private set; }
public VocabularyKey UseForFinancialConsolidationProcess { get; private set; }
public VocabularyKey UseForFinancialEliminationProcess { get; private set; }
public VocabularyKey LocalizationCountryRegionCode { get; private set; }
public VocabularyKey VATNum { get; private set; }
public VocabularyKey ImportVATNum { get; private set; }
public VocabularyKey ProfitMarginScheme { get; private set; }
public VocabularyKey VATRefund { get; private set; }
public VocabularyKey VATOnCustomerBehalf { get; private set; }


    }
}