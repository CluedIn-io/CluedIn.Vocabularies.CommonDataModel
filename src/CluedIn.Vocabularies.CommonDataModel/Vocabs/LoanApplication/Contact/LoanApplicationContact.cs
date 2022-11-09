using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LoanApplicationContactVocabulary : SimpleVocabulary
    {
        public LoanApplicationContactVocabulary()
        {
            VocabularyName = "Common Data Model LoanApplicationContact";
            KeyPrefix = "commonDataModel.loanapplicationcontact";
            KeySeparator = ".";
            Grouping = "/LoanApplicationContact";

            AddGroup("Common Data Model LoanApplicationContact Details", group =>
            {
                loanApplicationContactId = group.Add(new VocabularyKey(nameof(loanApplicationContactId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
addressLine1 = group.Add(new VocabularyKey(nameof(addressLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
addressLine2 = group.Add(new VocabularyKey(nameof(addressLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
addressLine3 = group.Add(new VocabularyKey(nameof(addressLine3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
assetsLiabilitiesVerificationStatus = group.Add(new VocabularyKey(nameof(assetsLiabilitiesVerificationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
birthday = group.Add(new VocabularyKey(nameof(birthday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
city = group.Add(new VocabularyKey(nameof(city), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
contactVerificationStatus = group.Add(new VocabularyKey(nameof(contactVerificationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
countryRegion = group.Add(new VocabularyKey(nameof(countryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
county = group.Add(new VocabularyKey(nameof(county), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
dependents = group.Add(new VocabularyKey(nameof(dependents), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
dependentsYears = group.Add(new VocabularyKey(nameof(dependentsYears), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
donotallowEmails = group.Add(new VocabularyKey(nameof(donotallowEmails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
donotallowTextMessages = group.Add(new VocabularyKey(nameof(donotallowTextMessages), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
email = group.Add(new VocabularyKey(nameof(email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
firstname = group.Add(new VocabularyKey(nameof(firstname), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
gender = group.Add(new VocabularyKey(nameof(gender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
governmentId = group.Add(new VocabularyKey(nameof(governmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isBorrowerEmployerRelationship = group.Add(new VocabularyKey(nameof(isBorrowerEmployerRelationship), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastName = group.Add(new VocabularyKey(nameof(lastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
loanApplicationRole = group.Add(new VocabularyKey(nameof(loanApplicationRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
loansinthepast90days = group.Add(new VocabularyKey(nameof(loansinthepast90days), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
maritalStatus = group.Add(new VocabularyKey(nameof(maritalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
middleName = group.Add(new VocabularyKey(nameof(middleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
numberofYearsatPresentAddress = group.Add(new VocabularyKey(nameof(numberofYearsatPresentAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
phone = group.Add(new VocabularyKey(nameof(phone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
postOfficeBox = group.Add(new VocabularyKey(nameof(postOfficeBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
prefix = group.Add(new VocabularyKey(nameof(prefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
presentAddressOwnershipStatus = group.Add(new VocabularyKey(nameof(presentAddressOwnershipStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
primaryMemberHelper = group.Add(new VocabularyKey(nameof(primaryMemberHelper), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateProvince = group.Add(new VocabularyKey(nameof(stateProvince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
yearsSchool = group.Add(new VocabularyKey(nameof(yearsSchool), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZIPPostalCode = group.Add(new VocabularyKey(nameof(ZIPPostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isPrimaryBorrower = group.Add(new VocabularyKey(nameof(isPrimaryBorrower), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey loanApplicationContactId { get; private set; }
public VocabularyKey createdOn { get; private set; }
public VocabularyKey modifiedOn { get; private set; }
public VocabularyKey statecode { get; private set; }
public VocabularyKey statuscode { get; private set; }
public VocabularyKey importSequenceNumber { get; private set; }
public VocabularyKey overriddenCreatedOn { get; private set; }
public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey addressLine1 { get; private set; }
public VocabularyKey addressLine2 { get; private set; }
public VocabularyKey addressLine3 { get; private set; }
public VocabularyKey assetsLiabilitiesVerificationStatus { get; private set; }
public VocabularyKey birthday { get; private set; }
public VocabularyKey city { get; private set; }
public VocabularyKey contactVerificationStatus { get; private set; }
public VocabularyKey countryRegion { get; private set; }
public VocabularyKey county { get; private set; }
public VocabularyKey dependents { get; private set; }
public VocabularyKey dependentsYears { get; private set; }
public VocabularyKey donotallowEmails { get; private set; }
public VocabularyKey donotallowTextMessages { get; private set; }
public VocabularyKey email { get; private set; }
public VocabularyKey firstname { get; private set; }
public VocabularyKey gender { get; private set; }
public VocabularyKey governmentId { get; private set; }
public VocabularyKey isBorrowerEmployerRelationship { get; private set; }
public VocabularyKey lastName { get; private set; }
public VocabularyKey loanApplicationRole { get; private set; }
public VocabularyKey loansinthepast90days { get; private set; }
public VocabularyKey maritalStatus { get; private set; }
public VocabularyKey middleName { get; private set; }
public VocabularyKey numberofYearsatPresentAddress { get; private set; }
public VocabularyKey phone { get; private set; }
public VocabularyKey postOfficeBox { get; private set; }
public VocabularyKey prefix { get; private set; }
public VocabularyKey presentAddressOwnershipStatus { get; private set; }
public VocabularyKey primaryMemberHelper { get; private set; }
public VocabularyKey stateProvince { get; private set; }
public VocabularyKey yearsSchool { get; private set; }
public VocabularyKey ZIPPostalCode { get; private set; }
public VocabularyKey isPrimaryBorrower { get; private set; }


    }
}