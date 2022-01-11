using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmWorkerBankAccountEntityVocabulary : SimpleVocabulary
    {
        public HcmWorkerBankAccountEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmWorkerBankAccountEntity";
            KeyPrefix = "commonDataModel.hcmworkerbankaccountentity";
            KeySeparator = ".";
            Grouping = "/HcmWorkerBankAccountEntity";

            AddGroup("Common Data Model HcmWorkerBankAccountEntity Details", group =>
            {
                AccountIdentification = group.Add(new VocabularyKey(nameof(AccountIdentification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankAccountNumber = group.Add(new VocabularyKey(nameof(BankAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankAccountType = group.Add(new VocabularyKey(nameof(BankAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoutingNumberType = group.Add(new VocabularyKey(nameof(RoutingNumberType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MobilePhone = group.Add(new VocabularyKey(nameof(MobilePhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NameOfPerson = group.Add(new VocabularyKey(nameof(NameOfPerson), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Telephone = group.Add(new VocabularyKey(nameof(Telephone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Extension = group.Add(new VocabularyKey(nameof(Extension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoutingNumber = group.Add(new VocabularyKey(nameof(RoutingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Fax = group.Add(new VocabularyKey(nameof(Fax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TelexNumber = group.Add(new VocabularyKey(nameof(TelexNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InternetAddress = group.Add(new VocabularyKey(nameof(InternetAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLocationId = group.Add(new VocabularyKey(nameof(AddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(AddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressStreetNumber = group.Add(new VocabularyKey(nameof(AddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressBuildingCompliment = group.Add(new VocabularyKey(nameof(AddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressPostBox = group.Add(new VocabularyKey(nameof(AddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCounty = group.Add(new VocabularyKey(nameof(AddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankIBAN = group.Add(new VocabularyKey(nameof(BankIBAN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SWIFTNo = group.Add(new VocabularyKey(nameof(SWIFTNo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BranchNumber = group.Add(new VocabularyKey(nameof(BranchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BranchName = group.Add(new VocabularyKey(nameof(BranchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountHolder = group.Add(new VocabularyKey(nameof(AccountHolder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankLocationCode = group.Add(new VocabularyKey(nameof(BankLocationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountIdentification { get; private set; }
public VocabularyKey BankAccountNumber { get; private set; }
public VocabularyKey BankAccountType { get; private set; }
public VocabularyKey RoutingNumberType { get; private set; }
public VocabularyKey MobilePhone { get; private set; }
public VocabularyKey NameOfPerson { get; private set; }
public VocabularyKey Email { get; private set; }
public VocabularyKey Location { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Telephone { get; private set; }
public VocabularyKey Extension { get; private set; }
public VocabularyKey RoutingNumber { get; private set; }
public VocabularyKey Fax { get; private set; }
public VocabularyKey TelexNumber { get; private set; }
public VocabularyKey InternetAddress { get; private set; }
public VocabularyKey Worker { get; private set; }
public VocabularyKey PersonnelNumber { get; private set; }
public VocabularyKey AddressLocationId { get; private set; }
public VocabularyKey AddressDescription { get; private set; }
public VocabularyKey AddressCountryRegionId { get; private set; }
public VocabularyKey AddressCountryRegionISOCode { get; private set; }
public VocabularyKey AddressZipCode { get; private set; }
public VocabularyKey AddressStreet { get; private set; }
public VocabularyKey AddressStreetNumber { get; private set; }
public VocabularyKey AddressBuildingCompliment { get; private set; }
public VocabularyKey AddressPostBox { get; private set; }
public VocabularyKey AddressCity { get; private set; }
public VocabularyKey AddressDistrictName { get; private set; }
public VocabularyKey AddressState { get; private set; }
public VocabularyKey AddressCounty { get; private set; }
public VocabularyKey AddressValidFrom { get; private set; }
public VocabularyKey AddressValidTo { get; private set; }
public VocabularyKey BankIBAN { get; private set; }
public VocabularyKey SWIFTNo { get; private set; }
public VocabularyKey BranchNumber { get; private set; }
public VocabularyKey BranchName { get; private set; }
public VocabularyKey AccountHolder { get; private set; }
public VocabularyKey BankLocationCode { get; private set; }


    }
}