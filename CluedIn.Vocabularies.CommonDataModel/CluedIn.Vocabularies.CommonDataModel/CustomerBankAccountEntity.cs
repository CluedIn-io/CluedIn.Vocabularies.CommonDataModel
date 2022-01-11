using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerBankAccountEntityVocabulary : SimpleVocabulary
    {
        public CustomerBankAccountEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustomerBankAccountEntity";
            KeyPrefix = "commonDataModel.customerbankaccountentity";
            KeySeparator = ".";
            Grouping = "/CustomerBankAccountEntity";

            AddGroup("Common Data Model CustomerBankAccountEntity Details", group =>
            {
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankAccountId = group.Add(new VocabularyKey(nameof(BankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankAccountNumber = group.Add(new VocabularyKey(nameof(BankAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankAccountType = group.Add(new VocabularyKey(nameof(BankAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankName = group.Add(new VocabularyKey(nameof(BankName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoutingNumber = group.Add(new VocabularyKey(nameof(RoutingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoutingNumberType = group.Add(new VocabularyKey(nameof(RoutingNumberType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankGroupId = group.Add(new VocabularyKey(nameof(BankGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankContractAccount = group.Add(new VocabularyKey(nameof(BankContractAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RateOfExchangeReference = group.Add(new VocabularyKey(nameof(RateOfExchangeReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CrossRate = group.Add(new VocabularyKey(nameof(CrossRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ESR = group.Add(new VocabularyKey(nameof(ESR), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IBAN = group.Add(new VocabularyKey(nameof(IBAN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SWIFTCode = group.Add(new VocabularyKey(nameof(SWIFTCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentTextCode = group.Add(new VocabularyKey(nameof(PaymentTextCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MessageToBank = group.Add(new VocabularyKey(nameof(MessageToBank), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPersonName = group.Add(new VocabularyKey(nameof(ContactPersonName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactMobilePhoneNumber = group.Add(new VocabularyKey(nameof(ContactMobilePhoneNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactEmailAddress = group.Add(new VocabularyKey(nameof(ContactEmailAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPager = group.Add(new VocabularyKey(nameof(ContactPager), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPhoneNumber = group.Add(new VocabularyKey(nameof(ContactPhoneNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPhoneNumberExtension = group.Add(new VocabularyKey(nameof(ContactPhoneNumberExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactEmailAddressForSendingSMS = group.Add(new VocabularyKey(nameof(ContactEmailAddressForSendingSMS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactFaxNumber = group.Add(new VocabularyKey(nameof(ContactFaxNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactTelexNumber = group.Add(new VocabularyKey(nameof(ContactTelexNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactInternetAddress = group.Add(new VocabularyKey(nameof(ContactInternetAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FullAddress = group.Add(new VocabularyKey(nameof(FullAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(AddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCounty = group.Add(new VocabularyKey(nameof(AddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLocationId = group.Add(new VocabularyKey(nameof(AddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressTimeZone = group.Add(new VocabularyKey(nameof(AddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankConstantSymbol = group.Add(new VocabularyKey(nameof(BankConstantSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankSpecificSymbol = group.Add(new VocabularyKey(nameof(BankSpecificSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ControlInternalNumber = group.Add(new VocabularyKey(nameof(ControlInternalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDefaultBankAccount = group.Add(new VocabularyKey(nameof(IsDefaultBankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QRIBAN = group.Add(new VocabularyKey(nameof(QRIBAN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CustomerAccountNumber { get; private set; }
public VocabularyKey BankAccountId { get; private set; }
public VocabularyKey BankAccountNumber { get; private set; }
public VocabularyKey BankAccountType { get; private set; }
public VocabularyKey BankName { get; private set; }
public VocabularyKey RoutingNumber { get; private set; }
public VocabularyKey RoutingNumberType { get; private set; }
public VocabularyKey BankGroupId { get; private set; }
public VocabularyKey BankContractAccount { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey RateOfExchangeReference { get; private set; }
public VocabularyKey CrossRate { get; private set; }
public VocabularyKey ESR { get; private set; }
public VocabularyKey IBAN { get; private set; }
public VocabularyKey SWIFTCode { get; private set; }
public VocabularyKey PaymentTextCode { get; private set; }
public VocabularyKey MessageToBank { get; private set; }
public VocabularyKey ContactPersonName { get; private set; }
public VocabularyKey ContactMobilePhoneNumber { get; private set; }
public VocabularyKey ContactEmailAddress { get; private set; }
public VocabularyKey ContactPager { get; private set; }
public VocabularyKey ContactPhoneNumber { get; private set; }
public VocabularyKey ContactPhoneNumberExtension { get; private set; }
public VocabularyKey ContactEmailAddressForSendingSMS { get; private set; }
public VocabularyKey ContactFaxNumber { get; private set; }
public VocabularyKey ContactTelexNumber { get; private set; }
public VocabularyKey ContactInternetAddress { get; private set; }
public VocabularyKey Location { get; private set; }
public VocabularyKey FullAddress { get; private set; }
public VocabularyKey AddressDescription { get; private set; }
public VocabularyKey AddressCountryRegionId { get; private set; }
public VocabularyKey AddressCountryRegionISOCode { get; private set; }
public VocabularyKey AddressState { get; private set; }
public VocabularyKey AddressCity { get; private set; }
public VocabularyKey AddressCounty { get; private set; }
public VocabularyKey AddressStreet { get; private set; }
public VocabularyKey AddressLatitude { get; private set; }
public VocabularyKey AddressLocationId { get; private set; }
public VocabularyKey AddressLongitude { get; private set; }
public VocabularyKey AddressZipCode { get; private set; }
public VocabularyKey AddressDistrictName { get; private set; }
public VocabularyKey AddressTimeZone { get; private set; }
public VocabularyKey AddressValidFrom { get; private set; }
public VocabularyKey AddressValidTo { get; private set; }
public VocabularyKey BankConstantSymbol { get; private set; }
public VocabularyKey BankSpecificSymbol { get; private set; }
public VocabularyKey ControlInternalNumber { get; private set; }
public VocabularyKey IsDefaultBankAccount { get; private set; }
public VocabularyKey QRIBAN { get; private set; }


    }
}