using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendVendorBankAccountEntityVocabulary : SimpleVocabulary
    {
        public VendVendorBankAccountEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendVendorBankAccountEntity";
            KeyPrefix = "commonDataModel.vendvendorbankaccountentity";
            KeySeparator = ".";
            Grouping = "/VendVendorBankAccountEntity";

            AddGroup("Common Data Model VendVendorBankAccountEntity Details", group =>
            {
                VendorBankAccountId = group.Add(new VocabularyKey(nameof(VendorBankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankAccountNumber = group.Add(new VocabularyKey(nameof(BankAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankName = group.Add(new VocabularyKey(nameof(BankName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankNameInKana = group.Add(new VocabularyKey(nameof(BankNameInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankGroupId = group.Add(new VocabularyKey(nameof(BankGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoutingNumberType = group.Add(new VocabularyKey(nameof(RoutingNumberType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoutingNumber = group.Add(new VocabularyKey(nameof(RoutingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DUNSNumber = group.Add(new VocabularyKey(nameof(DUNSNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DUNS4NumberSuffix = group.Add(new VocabularyKey(nameof(DUNS4NumberSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ControlInternalNumber = group.Add(new VocabularyKey(nameof(ControlInternalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SWIFTCode = group.Add(new VocabularyKey(nameof(SWIFTCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IBAN = group.Add(new VocabularyKey(nameof(IBAN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankAccountType = group.Add(new VocabularyKey(nameof(BankAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CorrespondenceBankAccountNumber = group.Add(new VocabularyKey(nameof(CorrespondenceBankAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankConstantSymbol = group.Add(new VocabularyKey(nameof(BankConstantSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankSpecificSymbol = group.Add(new VocabularyKey(nameof(BankSpecificSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActiveDate = group.Add(new VocabularyKey(nameof(ActiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankTransactionType = group.Add(new VocabularyKey(nameof(BankTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForeignBankGroupId = group.Add(new VocabularyKey(nameof(ForeignBankGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForeignBankAccountNumber = group.Add(new VocabularyKey(nameof(ForeignBankAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForeignBankSWIFTCode = group.Add(new VocabularyKey(nameof(ForeignBankSWIFTCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RecipientTextCode = group.Add(new VocabularyKey(nameof(RecipientTextCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankMessage = group.Add(new VocabularyKey(nameof(BankMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RateOfExchangeReference = group.Add(new VocabularyKey(nameof(RateOfExchangeReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CrossRate = group.Add(new VocabularyKey(nameof(CrossRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrentCurrencyCode = group.Add(new VocabularyKey(nameof(CurrentCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDefaultBankAccountForCurrentCurrency = group.Add(new VocabularyKey(nameof(IsDefaultBankAccountForCurrentCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDefaultBankAccount = group.Add(new VocabularyKey(nameof(IsDefaultBankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankCorrespondenceBankGroupId = group.Add(new VocabularyKey(nameof(BankCorrespondenceBankGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankCorrespondenceAccountBankGroupId = group.Add(new VocabularyKey(nameof(BankCorrespondenceAccountBankGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InterimBankCorrespondenceBankAccountNumber = group.Add(new VocabularyKey(nameof(InterimBankCorrespondenceBankAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InterimVendorBankAccountNumber = group.Add(new VocabularyKey(nameof(InterimVendorBankAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPhoneNumber = group.Add(new VocabularyKey(nameof(ContactPhoneNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPhoneNumberExtension = group.Add(new VocabularyKey(nameof(ContactPhoneNumberExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactMobilePhoneNumber = group.Add(new VocabularyKey(nameof(ContactMobilePhoneNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPager = group.Add(new VocabularyKey(nameof(ContactPager), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactFaxNumber = group.Add(new VocabularyKey(nameof(ContactFaxNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactEmailAddress = group.Add(new VocabularyKey(nameof(ContactEmailAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactEmailAddressForSendingSMS = group.Add(new VocabularyKey(nameof(ContactEmailAddressForSendingSMS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactInternetAddress = group.Add(new VocabularyKey(nameof(ContactInternetAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactTelexNumber = group.Add(new VocabularyKey(nameof(ContactTelexNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactName = group.Add(new VocabularyKey(nameof(ContactName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FormattedAddress = group.Add(new VocabularyKey(nameof(FormattedAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLocation = group.Add(new VocabularyKey(nameof(AddressLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLocationId = group.Add(new VocabularyKey(nameof(AddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCountry = group.Add(new VocabularyKey(nameof(AddressCountry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCountryISOCode = group.Add(new VocabularyKey(nameof(AddressCountryISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCounty = group.Add(new VocabularyKey(nameof(AddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressStreetNumber = group.Add(new VocabularyKey(nameof(AddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCityInKana = group.Add(new VocabularyKey(nameof(AddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressStreetInKana = group.Add(new VocabularyKey(nameof(AddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressPostBox = group.Add(new VocabularyKey(nameof(AddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressBuildingCompliment = group.Add(new VocabularyKey(nameof(AddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressTimeZone = group.Add(new VocabularyKey(nameof(AddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CrossExchRate = group.Add(new VocabularyKey(nameof(CrossExchRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QRIBAN = group.Add(new VocabularyKey(nameof(QRIBAN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentSpecificationParameter = group.Add(new VocabularyKey(nameof(PaymentSpecificationParameter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey VendorBankAccountId { get; private set; }
public VocabularyKey BankAccountNumber { get; private set; }
public VocabularyKey BankName { get; private set; }
public VocabularyKey BankNameInKana { get; private set; }
public VocabularyKey BankGroupId { get; private set; }
public VocabularyKey VendorAccountNumber { get; private set; }
public VocabularyKey RoutingNumberType { get; private set; }
public VocabularyKey RoutingNumber { get; private set; }
public VocabularyKey DUNSNumber { get; private set; }
public VocabularyKey DUNS4NumberSuffix { get; private set; }
public VocabularyKey ControlInternalNumber { get; private set; }
public VocabularyKey SWIFTCode { get; private set; }
public VocabularyKey IBAN { get; private set; }
public VocabularyKey BankAccountType { get; private set; }
public VocabularyKey CorrespondenceBankAccountNumber { get; private set; }
public VocabularyKey BankConstantSymbol { get; private set; }
public VocabularyKey BankSpecificSymbol { get; private set; }
public VocabularyKey ActiveDate { get; private set; }
public VocabularyKey ExpirationDate { get; private set; }
public VocabularyKey BankTransactionType { get; private set; }
public VocabularyKey ForeignBankGroupId { get; private set; }
public VocabularyKey ForeignBankAccountNumber { get; private set; }
public VocabularyKey ForeignBankSWIFTCode { get; private set; }
public VocabularyKey RecipientTextCode { get; private set; }
public VocabularyKey BankMessage { get; private set; }
public VocabularyKey RateOfExchangeReference { get; private set; }
public VocabularyKey CrossRate { get; private set; }
public VocabularyKey CurrentCurrencyCode { get; private set; }
public VocabularyKey IsDefaultBankAccountForCurrentCurrency { get; private set; }
public VocabularyKey IsDefaultBankAccount { get; private set; }
public VocabularyKey BankCorrespondenceBankGroupId { get; private set; }
public VocabularyKey BankCorrespondenceAccountBankGroupId { get; private set; }
public VocabularyKey InterimBankCorrespondenceBankAccountNumber { get; private set; }
public VocabularyKey InterimVendorBankAccountNumber { get; private set; }
public VocabularyKey ContactPhoneNumber { get; private set; }
public VocabularyKey ContactPhoneNumberExtension { get; private set; }
public VocabularyKey ContactMobilePhoneNumber { get; private set; }
public VocabularyKey ContactPager { get; private set; }
public VocabularyKey ContactFaxNumber { get; private set; }
public VocabularyKey ContactEmailAddress { get; private set; }
public VocabularyKey ContactEmailAddressForSendingSMS { get; private set; }
public VocabularyKey ContactInternetAddress { get; private set; }
public VocabularyKey ContactTelexNumber { get; private set; }
public VocabularyKey ContactName { get; private set; }
public VocabularyKey FormattedAddress { get; private set; }
public VocabularyKey AddressLocation { get; private set; }
public VocabularyKey AddressLocationId { get; private set; }
public VocabularyKey AddressDescription { get; private set; }
public VocabularyKey AddressCountry { get; private set; }
public VocabularyKey AddressCountryISOCode { get; private set; }
public VocabularyKey AddressState { get; private set; }
public VocabularyKey AddressCity { get; private set; }
public VocabularyKey AddressCounty { get; private set; }
public VocabularyKey AddressStreet { get; private set; }
public VocabularyKey AddressStreetNumber { get; private set; }
public VocabularyKey AddressCityInKana { get; private set; }
public VocabularyKey AddressStreetInKana { get; private set; }
public VocabularyKey AddressLatitude { get; private set; }
public VocabularyKey AddressLongitude { get; private set; }
public VocabularyKey AddressZipCode { get; private set; }
public VocabularyKey AddressDistrictName { get; private set; }
public VocabularyKey AddressPostBox { get; private set; }
public VocabularyKey AddressBuildingCompliment { get; private set; }
public VocabularyKey AddressValidFrom { get; private set; }
public VocabularyKey AddressValidTo { get; private set; }
public VocabularyKey AddressTimeZone { get; private set; }
public VocabularyKey CrossExchRate { get; private set; }
public VocabularyKey QRIBAN { get; private set; }
public VocabularyKey PaymentSpecificationParameter { get; private set; }


    }
}